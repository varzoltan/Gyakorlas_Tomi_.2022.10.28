using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Fájlok beolvasásához és kiírásához használt gyüjtemény

namespace Gyakorlas_Tomi_._2022._10._28
{
    internal class Program
    {
        struct Adat
        {
            public string adoszam;//Adattagok
            public string utca;
            public string hazszam;
            public string adosav;
            public int negyzetmeter;
            public Adat(string sor)//Konstruktor
            {
                string[] darabol = sor.Split(' ');
                adoszam = darabol[0];
                utca = darabol[1];
                hazszam = darabol[2];
                adosav = darabol[3];
                negyzetmeter = int.Parse(darabol[4]);
            }

        }
        static void Main(string[] args)
        {
            //Véletlen szám generálása
            Random random = new Random();//Példányosítom a Random osztályt
            int veletlen = random.Next(51);//Generál 0 és 50 közötti egész számot!
            Console.WriteLine("A véletlen egész szám: "+veletlen);

            //Generáljunk 10 és 60 közötti egész számot!
            int veletlen2 = random.Next(10,61);//Ez 10 és 60 közötti értéket generál,amibe a 10 és 60 is benne van.
            Console.WriteLine("A másik véletlen egész szám: " + veletlen2);

            //Egydimenziós tömb
            //Ismertek az elemei a tömbnek
            int[] tomb = { 5, 10, 45, -10, 1, 0 };
            Console.WriteLine($"A tömbelem 3.eleme: {tomb[2]}");

            //Nem ismert a tömb elemei
            //Maga a tömb statikus
            int[] tomb2 = new int[10];
            //Töltsük fel ezt a tömböt véletlen egész számokkal, -10 és 10 közötti értékekkel.
            for (int i = 0;i<10;i++)
            {
                tomb2[i] = random.Next(-10,11);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(tomb2[i]+" ");
            }
            Console.WriteLine();

            //Két dimenziós tömb létrehozása
            int[,] tomb3 = new int[4, 5];
            for (int i = 0; i<4;i++)
            {
                for (int j = 0;j<5;j++)
                {
                    tomb3[i,j] = random.Next(-10,11);
                }
            }
            Console.WriteLine();
            //Kiírás
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(tomb3[i, j]+" ");
                }
                Console.WriteLine();
            }
            //Írd ki a tömb 2 sorának 4.-dik elemét
            Console.WriteLine($"A tömb második sorának 4. eleme: {tomb3[1,3]}");

            //Fájl beolvasása
            List<Adat> lista = new List<Adat>();//Lista létrehozása: Adat struktúra alapján
            foreach (var i in File.ReadAllLines("utca.txt").Skip(1))
            {
                lista.Add(new Adat(i));
            }
            Console.ReadKey();
        }
    }
}
