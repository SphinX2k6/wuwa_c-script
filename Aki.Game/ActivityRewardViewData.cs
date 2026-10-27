using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010AE RID: 4270
[NullableContext(1)]
[Nullable(0)]
public class ActivityRewardViewData : IActivityRewardViewData
{
	// Token: 0x1700094A RID: 2378
	// (get) Token: 0x06006F26 RID: 28454 RVA: 0x0016B569 File Offset: 0x00169769
	// (set) Token: 0x06006F27 RID: 28455 RVA: 0x0016B571 File Offset: 0x00169771
	public List<IActivityRewardDataPage> DataPageList { get; set; }

	// Token: 0x1700094B RID: 2379
	// (get) Token: 0x06006F28 RID: 28456 RVA: 0x0016B57A File Offset: 0x0016977A
	// (set) Token: 0x06006F29 RID: 28457 RVA: 0x0016B582 File Offset: 0x00169782
	public EActivityRewardSource Source { get; set; }

	// Token: 0x1700094C RID: 2380
	// (get) Token: 0x06006F2A RID: 28458 RVA: 0x0016B58B File Offset: 0x0016978B
	// (set) Token: 0x06006F2B RID: 28459 RVA: 0x0016B593 File Offset: 0x00169793
	[Nullable(2)]
	public string TitleTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
}
