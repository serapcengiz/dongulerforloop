using System;
namespace dongulerforloop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilensayıya kadar olan tek sayıları ekranan yazıdr
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayac=int.Parse(Console.ReadLine());
            for(int i=0; i<sayac; i++)
            {
                if(i%2==1)
                {
                    Console.WriteLine(i);
                }

            }
            //1 ile 1000 arasındaki tek ce çift sayıların toplamı
            int tekToplam=0;
            int ciftToplam=0;
            for(int i=0; i<=1000;i++)
            {
                if(i%2==0)
                {
                    ciftToplam=i+ciftToplam;
                }
                else
                {
                    tekToplam=i+tekToplam;
                }
                
            }
            Console.WriteLine("Çift Toplam"+ciftToplam);
            Console.WriteLine("Tek Toplam:"+tekToplam);

            //break continue
            for(int i=1; i<10;i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
            for(int i=1; i<10;i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
