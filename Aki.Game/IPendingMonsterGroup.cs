using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x020031C2 RID: 12738
[NullableContext(1)]
public interface IPendingMonsterGroup
{
	// Token: 0x17002600 RID: 9728
	// (get) Token: 0x0601B741 RID: 112449
	// (set) Token: 0x0601B742 RID: 112450
	[Nullable(2)]
	GroupAiComponent GroupComp { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002601 RID: 9729
	// (get) Token: 0x0601B743 RID: 112451
	// (set) Token: 0x0601B744 RID: 112452
	HashSet<int> RegisteredPbDataIds { get; set; }
}
