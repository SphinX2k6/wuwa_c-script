using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F7 RID: 9975
[NullableContext(1)]
public interface IRacingBetsDangoActorData
{
	// Token: 0x17001AAC RID: 6828
	// (get) Token: 0x06014731 RID: 83761
	// (set) Token: 0x06014732 RID: 83762
	EUiModelUseWay UiModelUseWay { get; set; }

	// Token: 0x17001AAD RID: 6829
	// (get) Token: 0x06014733 RID: 83763
	// (set) Token: 0x06014734 RID: 83764
	int DangoId { get; set; }

	// Token: 0x17001AAE RID: 6830
	// (get) Token: 0x06014735 RID: 83765
	// (set) Token: 0x06014736 RID: 83766
	int Odds { get; set; }

	// Token: 0x17001AAF RID: 6831
	// (get) Token: 0x06014737 RID: 83767
	// (set) Token: 0x06014738 RID: 83768
	string DangoPointCase { get; set; }

	// Token: 0x17001AB0 RID: 6832
	// (get) Token: 0x06014739 RID: 83769
	// (set) Token: 0x0601473A RID: 83770
	string DangoCamera { get; set; }

	// Token: 0x17001AB1 RID: 6833
	// (get) Token: 0x0601473B RID: 83771
	// (set) Token: 0x0601473C RID: 83772
	float DangoOffset { get; set; }

	// Token: 0x17001AB2 RID: 6834
	// (get) Token: 0x0601473D RID: 83773
	// (set) Token: 0x0601473E RID: 83774
	bool IsAbuDango { get; set; }
}
