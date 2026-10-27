using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F2 RID: 9970
[NullableContext(1)]
public interface IRacingBetsLegMatchResultData
{
	// Token: 0x17001A96 RID: 6806
	// (get) Token: 0x06014703 RID: 83715
	// (set) Token: 0x06014704 RID: 83716
	int DangoId { get; set; }

	// Token: 0x17001A97 RID: 6807
	// (get) Token: 0x06014705 RID: 83717
	// (set) Token: 0x06014706 RID: 83718
	int Rank { get; set; }

	// Token: 0x17001A98 RID: 6808
	// (get) Token: 0x06014707 RID: 83719
	// (set) Token: 0x06014708 RID: 83720
	bool HasAdvanced { get; set; }

	// Token: 0x17001A99 RID: 6809
	// (get) Token: 0x06014709 RID: 83721
	// (set) Token: 0x0601470A RID: 83722
	ERacingBetsLegMatchType LegMatchType { get; set; }

	// Token: 0x17001A9A RID: 6810
	// (get) Token: 0x0601470B RID: 83723
	// (set) Token: 0x0601470C RID: 83724
	bool IsChampion { get; set; }

	// Token: 0x17001A9B RID: 6811
	// (get) Token: 0x0601470D RID: 83725
	// (set) Token: 0x0601470E RID: 83726
	ERacingBetsLegMatchResultType ResultShowType { get; set; }

	// Token: 0x17001A9C RID: 6812
	// (get) Token: 0x0601470F RID: 83727
	// (set) Token: 0x06014710 RID: 83728
	string AdvancedNextMatchName { get; set; }

	// Token: 0x17001A9D RID: 6813
	// (get) Token: 0x06014711 RID: 83729
	// (set) Token: 0x06014712 RID: 83730
	string LoserNextMatchName { get; set; }
}
