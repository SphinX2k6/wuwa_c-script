using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020026FB RID: 9979
[NullableContext(1)]
public interface IRacingBetsSelfRankData
{
	// Token: 0x17001AC6 RID: 6854
	// (get) Token: 0x06014767 RID: 83815
	// (set) Token: 0x06014768 RID: 83816
	RacingBetsRankStatus RankStatus { get; set; }

	// Token: 0x17001AC7 RID: 6855
	// (get) Token: 0x06014769 RID: 83817
	// (set) Token: 0x0601476A RID: 83818
	int RankNum { get; set; }

	// Token: 0x17001AC8 RID: 6856
	// (get) Token: 0x0601476B RID: 83819
	// (set) Token: 0x0601476C RID: 83820
	int HeadIcon { get; set; }

	// Token: 0x17001AC9 RID: 6857
	// (get) Token: 0x0601476D RID: 83821
	// (set) Token: 0x0601476E RID: 83822
	string Name { get; set; }

	// Token: 0x17001ACA RID: 6858
	// (get) Token: 0x0601476F RID: 83823
	// (set) Token: 0x06014770 RID: 83824
	int HitNum { get; set; }

	// Token: 0x17001ACB RID: 6859
	// (get) Token: 0x06014771 RID: 83825
	// (set) Token: 0x06014772 RID: 83826
	int CashNum { get; set; }
}
