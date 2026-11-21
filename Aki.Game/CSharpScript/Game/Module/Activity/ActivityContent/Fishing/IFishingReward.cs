using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005577 RID: 21879
	public interface IFishingReward
	{
		// Token: 0x1700692E RID: 26926
		// (get) Token: 0x060363B1 RID: 222129
		// (set) Token: 0x060363B2 RID: 222130
		int Id { get; set; }

		// Token: 0x1700692F RID: 26927
		// (get) Token: 0x060363B3 RID: 222131
		// (set) Token: 0x060363B4 RID: 222132
		int Current { get; set; }

		// Token: 0x17006930 RID: 26928
		// (get) Token: 0x060363B5 RID: 222133
		// (set) Token: 0x060363B6 RID: 222134
		int Target { get; set; }

		// Token: 0x17006931 RID: 26929
		// (get) Token: 0x060363B7 RID: 222135
		// (set) Token: 0x060363B8 RID: 222136
		bool IsFinished { get; set; }

		// Token: 0x17006932 RID: 26930
		// (get) Token: 0x060363B9 RID: 222137
		// (set) Token: 0x060363BA RID: 222138
		bool IsTaken { get; set; }
	}
}
