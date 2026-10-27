using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020024AC RID: 9388
[NullableContext(1)]
public interface IMainRecommendAttrItemData
{
	// Token: 0x170018A5 RID: 6309
	// (get) Token: 0x06012D9E RID: 77214
	// (set) Token: 0x06012D9F RID: 77215
	[Nullable(2)]
	string CostLabel { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018A6 RID: 6310
	// (get) Token: 0x06012DA0 RID: 77216
	// (set) Token: 0x06012DA1 RID: 77217
	List<RecommendItemData> Items { get; set; }
}
