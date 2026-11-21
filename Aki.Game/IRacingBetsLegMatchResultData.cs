using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BDD RID: 7133
[NullableContext(1)]
public interface IRacingBetsLegMatchResultData
{
	// Token: 0x17001ACE RID: 6862
	// (get) Token: 0x06011BE5 RID: 72677
	// (set) Token: 0x06011BE6 RID: 72678
	int DangoId { get; set; }

	// Token: 0x17001ACF RID: 6863
	// (get) Token: 0x06011BE7 RID: 72679
	// (set) Token: 0x06011BE8 RID: 72680
	int Rank { get; set; }

	// Token: 0x17001AD0 RID: 6864
	// (get) Token: 0x06011BE9 RID: 72681
	// (set) Token: 0x06011BEA RID: 72682
	bool HasAdvanced { get; set; }

	// Token: 0x17001AD1 RID: 6865
	// (get) Token: 0x06011BEB RID: 72683
	// (set) Token: 0x06011BEC RID: 72684
	ERacingBetsLegMatchType LegMatchType { get; set; }

	// Token: 0x17001AD2 RID: 6866
	// (get) Token: 0x06011BED RID: 72685
	// (set) Token: 0x06011BEE RID: 72686
	bool IsChampion { get; set; }

	// Token: 0x17001AD3 RID: 6867
	// (get) Token: 0x06011BEF RID: 72687
	// (set) Token: 0x06011BF0 RID: 72688
	ERacingBetsLegMatchResultType ResultShowType { get; set; }

	// Token: 0x17001AD4 RID: 6868
	// (get) Token: 0x06011BF1 RID: 72689
	// (set) Token: 0x06011BF2 RID: 72690
	string AdvancedNextMatchName { get; set; }

	// Token: 0x17001AD5 RID: 6869
	// (get) Token: 0x06011BF3 RID: 72691
	// (set) Token: 0x06011BF4 RID: 72692
	string LoserNextMatchName { get; set; }
}
