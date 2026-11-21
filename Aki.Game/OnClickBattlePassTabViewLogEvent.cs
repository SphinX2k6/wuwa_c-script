using System;
using System.Runtime.CompilerServices;

// Token: 0x020015CF RID: 5583
[NullableContext(1)]
[Nullable(0)]
public class OnClickBattlePassTabViewLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CB RID: 5323
	// (get) Token: 0x0600DD94 RID: 56724 RVA: 0x004177D3 File Offset: 0x004159D3
	// (set) Token: 0x0600DD95 RID: 56725 RVA: 0x004177DB File Offset: 0x004159DB
	public override string event_id { get; set; } = "1831";

	// Token: 0x04007D4B RID: 32075
	public int i_tabIndex;
}
