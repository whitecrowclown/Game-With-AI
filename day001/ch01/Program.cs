namespace ch01

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player();
            p.Attacked();
            p.Heal();

            Monster m = new Monster();
            /* Monseter 클래스에 deal () 메서드가 존재하지 않으므로 주석 처리하였습니다.
            m.deal();
            */
        }
    }

    class Player
    {
        string name;
        int hp = 10;
        public void Attack()
        {
            Console.WriteLine("Player attack!");
        }

        public void Attacked()
        {
            Console.Write("Player attacked! ");
            hp -= 1;
            Console.WriteLine($"Player HP: {hp}");
        }

        public void Heal()
        {  
            if (hp == 10)
                {
                    Console.WriteLine("Player is already at full health!");
                    return;
                }

            else
                {
                    Console.Write("Player healed! ");
                    hp += 1;
                    Console.WriteLine($"Player HP: {hp}");
                    return;
                }
        }
    }

    class Monster
    {
        int hp = 200;
        public void deal()
        {
            Console.WriteLine("몬스터가 공격하였습니다!");
            hp = hp - 30;
            Console.WriteLine(hp);
        }
    }
}