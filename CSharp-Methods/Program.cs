using System;

namespace CSharp_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soz daxil edin: ");
            string word = Console.ReadLine();
            Console.WriteLine("Simvol daxil edin: ");
            char sym = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(FindIndex(word, sym));


            Console.WriteLine("Eded daxil edin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ededin en yaxin asagi kokaltisi --> "+FindSqrt(number));


            Console.WriteLine("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ededin reqemlerinin cemi --> "+Sum(num));


            Console.WriteLine("Siyahidaki ededlerin sayini yazin: ");
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i+1}. ededi daxil edin: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Siyahidaki en boyuk eded --> "+FindMaxNumber(arr));


            Console.WriteLine("Siyahidaki ededlerin sayini yazin: ");
            int counter = Convert.ToInt32(Console.ReadLine());
            int[] arrInt = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"{i + 1}. ededi daxil edin: ");
                arrInt[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("--Array change to positive--");
            foreach (var item in ChangePositive(arrInt))
            {
                Console.WriteLine(item);
            }
        }

        //1. Verilmiş string dəyərində verilmiş char-ın hansı index-də yerləşdiyini tapıb qaytaran metod.Misalçün metodu call edib "salam" və 'l' dəyərləri göndərsək geriyə 2 qaytarmalıdır amma char həmin string-də olmasa -1 qaytarmalıdır.
        static int FindIndex(string str, char ch)
        {
            
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    return i;
                }
            }

            return -1;
        }

        //2. Verilmiş  ədədin ən yaxın aşağı kökaltısını tapıb qaytaran metod.
        static int FindSqrt(int number)
        {
            int sqrtNum = 0;
            for (int i = 1; i*i < number; i++)
            {
                sqrtNum = i;
            }
            return sqrtNum;
        }

        //3. Verilmiş  ədədin rəqəmləri cəmini tapıb qaytaran metod.
        static int Sum(int number)
        {
            int sum = 0, digit=0;
            while (0<number)
            {
                digit = number % 10;
                sum += digit;
                number /= 10;
            }
            return sum;
        }

        //4. Verilmiş  integer array-in icindəki ən böyük dəyəri tapan metod
        static int FindMaxNumber(int[] arr)
        {
            int max = 0;
            foreach (int item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        //5. Verilmiş integer array-in  bütün elementlərini  musbet şəkildə qaytaran metod.Misalçün parametr olaraq { 1,-4,9,-8} dəyərləri olan array daxil edilsə arqument kimi metod bizə {1,4,9,8} dəyərləri olan array qaytarmalıdır.
        static int[] ChangePositive(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr[i] = 0 - arr[i];
                }
            }
            return arr;
        }
    }
}
