using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x02002731 RID: 10033
[NullableContext(1)]
public interface IPendingMonsterGroup
{
	// Token: 0x17002804 RID: 10244
	// (get) Token: 0x0601927A RID: 103034
	// (set) Token: 0x0601927B RID: 103035
	[Nullable(2)]
	GroupAiComponent GroupComp { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002805 RID: 10245
	// (get) Token: 0x0601927C RID: 103036
	// (set) Token: 0x0601927D RID: 103037
	HashSet<int> RegisteredPbDataIds { get; set; }
}
