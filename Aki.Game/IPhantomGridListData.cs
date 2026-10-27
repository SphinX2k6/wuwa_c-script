using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002463 RID: 9315
[NullableContext(1)]
public interface IPhantomGridListData
{
	// Token: 0x17001858 RID: 6232
	// (get) Token: 0x06012B12 RID: 76562
	// (set) Token: 0x06012B13 RID: 76563
	EGridTitleType TitleType { get; set; }

	// Token: 0x17001859 RID: 6233
	// (get) Token: 0x06012B14 RID: 76564
	// (set) Token: 0x06012B15 RID: 76565
	List<int> MonsterIds { get; set; }
}
