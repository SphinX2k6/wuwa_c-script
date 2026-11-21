using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x02002732 RID: 10034
[NullableContext(1)]
[Nullable(0)]
public class PendingMonsterGroup : IPendingMonsterGroup
{
	// Token: 0x17002806 RID: 10246
	// (get) Token: 0x0601927E RID: 103038 RVA: 0x007AB558 File Offset: 0x007A9758
	// (set) Token: 0x0601927F RID: 103039 RVA: 0x007AB560 File Offset: 0x007A9760
	[Nullable(2)]
	public GroupAiComponent GroupComp { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002807 RID: 10247
	// (get) Token: 0x06019280 RID: 103040 RVA: 0x007AB569 File Offset: 0x007A9769
	// (set) Token: 0x06019281 RID: 103041 RVA: 0x007AB571 File Offset: 0x007A9771
	public HashSet<int> RegisteredPbDataIds { get; set; } = new HashSet<int>();
}
