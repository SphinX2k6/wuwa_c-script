using System;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FC2 RID: 28610
	public interface IPinballRoleTotalInfo
	{
		// Token: 0x17009B82 RID: 39810
		// (get) Token: 0x060458ED RID: 284909
		// (set) Token: 0x060458EE RID: 284910
		float Damage { get; set; }

		// Token: 0x17009B83 RID: 39811
		// (get) Token: 0x060458EF RID: 284911
		// (set) Token: 0x060458F0 RID: 284912
		int SkillTimes { get; set; }

		// Token: 0x17009B84 RID: 39812
		// (get) Token: 0x060458F1 RID: 284913
		// (set) Token: 0x060458F2 RID: 284914
		float DropCostHp { get; set; }

		// Token: 0x17009B85 RID: 39813
		// (get) Token: 0x060458F3 RID: 284915
		// (set) Token: 0x060458F4 RID: 284916
		float HitCostHp { get; set; }

		// Token: 0x17009B86 RID: 39814
		// (get) Token: 0x060458F5 RID: 284917
		// (set) Token: 0x060458F6 RID: 284918
		int DieTimes { get; set; }

		// Token: 0x17009B87 RID: 39815
		// (get) Token: 0x060458F7 RID: 284919
		// (set) Token: 0x060458F8 RID: 284920
		int ReviveTimes { get; set; }
	}
}
