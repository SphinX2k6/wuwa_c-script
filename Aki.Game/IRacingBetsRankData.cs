using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F9 RID: 9977
[NullableContext(1)]
public interface IRacingBetsRankData
{
	// Token: 0x17001ABA RID: 6842
	// (get) Token: 0x0601474E RID: 83790
	// (set) Token: 0x0601474F RID: 83791
	int PlayerId { get; set; }

	// Token: 0x17001ABB RID: 6843
	// (get) Token: 0x06014750 RID: 83792
	// (set) Token: 0x06014751 RID: 83793
	int PlayerHeadPhoto { get; set; }

	// Token: 0x17001ABC RID: 6844
	// (get) Token: 0x06014752 RID: 83794
	// (set) Token: 0x06014753 RID: 83795
	int RankNum { get; set; }

	// Token: 0x17001ABD RID: 6845
	// (get) Token: 0x06014754 RID: 83796
	// (set) Token: 0x06014755 RID: 83797
	string Name { get; set; }

	// Token: 0x17001ABE RID: 6846
	// (get) Token: 0x06014756 RID: 83798
	// (set) Token: 0x06014757 RID: 83799
	int HitNum { get; set; }

	// Token: 0x17001ABF RID: 6847
	// (get) Token: 0x06014758 RID: 83800
	// (set) Token: 0x06014759 RID: 83801
	int CashNum { get; set; }
}
