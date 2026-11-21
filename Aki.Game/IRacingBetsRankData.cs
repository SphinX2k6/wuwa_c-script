using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE4 RID: 7140
[NullableContext(1)]
public interface IRacingBetsRankData
{
	// Token: 0x17001AF2 RID: 6898
	// (get) Token: 0x06011C30 RID: 72752
	// (set) Token: 0x06011C31 RID: 72753
	int PlayerId { get; set; }

	// Token: 0x17001AF3 RID: 6899
	// (get) Token: 0x06011C32 RID: 72754
	// (set) Token: 0x06011C33 RID: 72755
	int PlayerHeadPhoto { get; set; }

	// Token: 0x17001AF4 RID: 6900
	// (get) Token: 0x06011C34 RID: 72756
	// (set) Token: 0x06011C35 RID: 72757
	int RankNum { get; set; }

	// Token: 0x17001AF5 RID: 6901
	// (get) Token: 0x06011C36 RID: 72758
	// (set) Token: 0x06011C37 RID: 72759
	string Name { get; set; }

	// Token: 0x17001AF6 RID: 6902
	// (get) Token: 0x06011C38 RID: 72760
	// (set) Token: 0x06011C39 RID: 72761
	int HitNum { get; set; }

	// Token: 0x17001AF7 RID: 6903
	// (get) Token: 0x06011C3A RID: 72762
	// (set) Token: 0x06011C3B RID: 72763
	int CashNum { get; set; }
}
