using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020010AD RID: 4269
[NullableContext(1)]
public interface IActivityRewardViewData
{
	// Token: 0x17000947 RID: 2375
	// (get) Token: 0x06006F20 RID: 28448
	// (set) Token: 0x06006F21 RID: 28449
	List<IActivityRewardDataPage> DataPageList { get; set; }

	// Token: 0x17000948 RID: 2376
	// (get) Token: 0x06006F22 RID: 28450
	// (set) Token: 0x06006F23 RID: 28451
	EActivityRewardSource Source { get; set; }

	// Token: 0x17000949 RID: 2377
	// (get) Token: 0x06006F24 RID: 28452
	// (set) Token: 0x06006F25 RID: 28453
	[Nullable(2)]
	string TitleTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
}
