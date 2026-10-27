using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024AD RID: 9389
[NullableContext(1)]
[Nullable(0)]
public class MainRecommendAttrItemData : IMainRecommendAttrItemData
{
	// Token: 0x170018A7 RID: 6311
	// (get) Token: 0x06012DA2 RID: 77218 RVA: 0x004A800A File Offset: 0x004A620A
	// (set) Token: 0x06012DA3 RID: 77219 RVA: 0x004A8012 File Offset: 0x004A6212
	[Nullable(2)]
	public string CostLabel { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018A8 RID: 6312
	// (get) Token: 0x06012DA4 RID: 77220 RVA: 0x004A801B File Offset: 0x004A621B
	// (set) Token: 0x06012DA5 RID: 77221 RVA: 0x004A8023 File Offset: 0x004A6223
	public List<RecommendItemData> Items { get; set; } = new List<RecommendItemData>();
}
