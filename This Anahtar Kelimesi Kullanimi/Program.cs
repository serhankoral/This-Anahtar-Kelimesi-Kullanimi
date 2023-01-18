using System;

namespace This_Anahtar_Kelimesi_Kullanimi
{
    class Program
    {
        public int x;
        static void Main(string[] args)
        {
           Program program =new Program();
        }
        public Program() 
        {
            A nesne = new A(5, 15, 25);
            Console.WriteLine(nesne.x);
            Console.WriteLine(nesne.y);
            Console.WriteLine(nesne.z);
        }
    }

    class A
    {
        public  int x;
        public  int y;
        public  int z;
        private A(int x)
        {
            this.x = x;
        }
        public A(int x, int y, int z) : this(x)
        {
            this.y = y;
            this.z = z;
        }
    }

}
