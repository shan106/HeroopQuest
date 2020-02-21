using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.gameclasses
{
    enum HeldType { Barbaar, Dwerg, Elf, Tovenaar}
    class Held
    {
        public Held(HeldType type, string v)
        {
            switch (type)
            {
                case HeldType.Barbaar:
                    break;
                case HeldType.Dwerg:
                    break;
                case HeldType.Elf:
                    break;
                case HeldType.Tovenaar:
                    break;
                default:
            }
        }
        public string naam { get; set; }
        public string Beschrijving { get; private set; }
        public int maxIntelligentie { get; private set; }
        public int MaxLichaam { get; private set; }
        public int HuidigeIntelligentie { get; set; }
        public int HuidigeLichaam { get; set; }
        public HeldType HeldType { get; private set; }

        public int AanvalDobbelstenen { get; private set; } = 2;
        public int VerdedigingDobbelsteen { get; private set; } = 2;
        public int LoopDobbelsteen { get; private set; } = 2;
    }
}
