using System;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006143 RID: 24899
	public interface IPinballRoleTotalInfo
	{
		// Token: 0x170070C2 RID: 28866
		// (get) Token: 0x0603BA9D RID: 244381
		// (set) Token: 0x0603BA9E RID: 244382
		float Damage { get; set; }

		// Token: 0x170070C3 RID: 28867
		// (get) Token: 0x0603BA9F RID: 244383
		// (set) Token: 0x0603BAA0 RID: 244384
		int SkillTimes { get; set; }

		// Token: 0x170070C4 RID: 28868
		// (get) Token: 0x0603BAA1 RID: 244385
		// (set) Token: 0x0603BAA2 RID: 244386
		float DropCostHp { get; set; }

		// Token: 0x170070C5 RID: 28869
		// (get) Token: 0x0603BAA3 RID: 244387
		// (set) Token: 0x0603BAA4 RID: 244388
		float HitCostHp { get; set; }

		// Token: 0x170070C6 RID: 28870
		// (get) Token: 0x0603BAA5 RID: 244389
		// (set) Token: 0x0603BAA6 RID: 244390
		int DieTimes { get; set; }

		// Token: 0x170070C7 RID: 28871
		// (get) Token: 0x0603BAA7 RID: 244391
		// (set) Token: 0x0603BAA8 RID: 244392
		int ReviveTimes { get; set; }
	}
}
