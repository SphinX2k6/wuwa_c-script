using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001993 RID: 6547
[NullableContext(1)]
public interface IMainRecommendAttrItemData
{
	// Token: 0x170018DF RID: 6367
	// (get) Token: 0x0601025E RID: 66142
	// (set) Token: 0x0601025F RID: 66143
	[Nullable(2)]
	string CostLabel { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x170018E0 RID: 6368
	// (get) Token: 0x06010260 RID: 66144
	// (set) Token: 0x06010261 RID: 66145
	List<RecommendItemData> Items { get; set; }
}
