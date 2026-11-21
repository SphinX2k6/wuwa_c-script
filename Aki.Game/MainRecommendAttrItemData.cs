using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001994 RID: 6548
[NullableContext(1)]
[Nullable(0)]
public class MainRecommendAttrItemData : IMainRecommendAttrItemData
{
	// Token: 0x170018E1 RID: 6369
	// (get) Token: 0x06010262 RID: 66146 RVA: 0x004B5BBE File Offset: 0x004B3DBE
	// (set) Token: 0x06010263 RID: 66147 RVA: 0x004B5BC6 File Offset: 0x004B3DC6
	[Nullable(2)]
	public string CostLabel { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018E2 RID: 6370
	// (get) Token: 0x06010264 RID: 66148 RVA: 0x004B5BCF File Offset: 0x004B3DCF
	// (set) Token: 0x06010265 RID: 66149 RVA: 0x004B5BD7 File Offset: 0x004B3DD7
	public List<RecommendItemData> Items { get; set; } = new List<RecommendItemData>();
}
