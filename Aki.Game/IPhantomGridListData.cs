using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001948 RID: 6472
[NullableContext(1)]
public interface IPhantomGridListData
{
	// Token: 0x17001892 RID: 6290
	// (get) Token: 0x0600FFCA RID: 65482
	// (set) Token: 0x0600FFCB RID: 65483
	EGridTitleType TitleType { get; set; }

	// Token: 0x17001893 RID: 6291
	// (get) Token: 0x0600FFCC RID: 65484
	// (set) Token: 0x0600FFCD RID: 65485
	List<int> MonsterIds { get; set; }
}
