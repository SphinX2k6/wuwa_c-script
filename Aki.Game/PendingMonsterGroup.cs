using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x020031C3 RID: 12739
[NullableContext(1)]
[Nullable(0)]
public class PendingMonsterGroup : IPendingMonsterGroup
{
	// Token: 0x17002602 RID: 9730
	// (get) Token: 0x0601B745 RID: 112453 RVA: 0x00783369 File Offset: 0x00781569
	// (set) Token: 0x0601B746 RID: 112454 RVA: 0x00783371 File Offset: 0x00781571
	[Nullable(2)]
	public GroupAiComponent GroupComp { [NullableContext(2)] get; [NullableContext(2)] set; }

	// Token: 0x17002603 RID: 9731
	// (get) Token: 0x0601B747 RID: 112455 RVA: 0x0078337A File Offset: 0x0078157A
	// (set) Token: 0x0601B748 RID: 112456 RVA: 0x00783382 File Offset: 0x00781582
	public HashSet<int> RegisteredPbDataIds { get; set; } = new HashSet<int>();
}
