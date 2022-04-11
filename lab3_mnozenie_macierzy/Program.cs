using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab3_mnozenie_macierzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[10, 10];
            int[,] arr2 = new int[10, 10];
            int[,] arr3 = new int[10, 10];
            int liczba_watkow = 10;
            Thread[] threads = new Thread[liczba_watkow];

            
                Random r = new Random();

                for (int ki = 0; ki < 10; ki++)
                {
                    for (int kj = 0; kj < 10; kj++)
                    {
                        arr1[ki, kj] = r.Next(1, 20);
                    }
                }

                for (int ki = 0; ki < 10; ki++)
                {
                    for (int kj = 0; kj < 10; kj++)
                    {
                        arr2[ki, kj] = r.Next(1, 100);
                    }
                }
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    int s = 0;
                    for (int k = 0; k < 10; k++)
                    {
                        s += arr1[i, k] * arr2[k, j];
                    }
                    arr3[i,j] = s;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Macierz wynikowa: \n");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadLine();

        }
    }
}
