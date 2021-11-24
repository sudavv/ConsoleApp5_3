using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int num;
            var Random = new Random();
            int[] array = new int[10];
            Console.WriteLine("Числа массива");
            for (int i = 0; i < 10; i++)
            {
                num = Random.Next(-50, 50);
                array[i] = num;
                Console.WriteLine(num);
            }

            Console.WriteLine("");
            int[] plus = new int[5];
            int[] minus = new int[5];
            plus[0] = array[0];
            minus[0] = array[5];
            int current_plus = 51;
            int current_minus = 52;
            Console.WriteLine("Возрастание   Убывание");

            for (int i = 0; i < 5; i++) // по массиву
            {
                for (int pls=0; pls<5; pls++)
                {
                    if (array[pls] != 51)
                    {
                        plus[i] = array[pls];
                        break;
                    }                
                }

                for (int min = 5; min < 10; min++)
                {
                    if (array[min] != 52)
                    {
                        minus[i] = array[min];
                        break;
                    }             
                }              

                    for (int j = 0; j < 5; j++) // сравниваем со всеми
                {
                    if (array[j] <= plus[i] & array[j] != 51) // текущий в массиве меньше
                    {
                        plus[i] = array[j];
                        current_plus = j;
                    }
                    if (array[j+5] >= minus[i] & array[j+5] != 52) // текущий в массиве больше
                    {
                        minus[i] = array[j+5];
                        current_minus = j+5;
                    }
                }

                array[current_minus] = 52;
                array[current_plus] = 51;
                int len = plus[i].ToString().Length;
                string add;
                if (len == 3)
                {
                    add = "";
                }
                else if (len==2)
                {
                    add = " ";
                }
                else
                {
                    add = "  ";
                }

                Console.WriteLine(plus[i] + "           " + add + minus[i]);
            }
            
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}