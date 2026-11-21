using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000561 RID: 1377
[NullableContext(1)]
public interface IActivityRewardViewData
{
	// Token: 0x17000967 RID: 2407
	// (get) Token: 0x060042B6 RID: 17078
	// (set) Token: 0x060042B7 RID: 17079
	List<IActivityRewardDataPage> DataPageList { get; set; }

	// Token: 0x17000968 RID: 2408
	// (get) Token: 0x060042B8 RID: 17080
	// (set) Token: 0x060042B9 RID: 17081
	EActivityRewardSource Source { get; set; }

	// Token: 0x17000969 RID: 2409
	// (get) Token: 0x060042BA RID: 17082
	// (set) Token: 0x060042BB RID: 17083
	[Nullable(2)]
	string TitleTextId { [NullableContext(2)] get; [NullableContext(2)] set; }
}
