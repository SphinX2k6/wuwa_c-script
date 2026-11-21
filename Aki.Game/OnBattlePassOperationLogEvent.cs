using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D0 RID: 5584
[NullableContext(1)]
[Nullable(0)]
public class OnBattlePassOperationLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CC RID: 5324
	// (get) Token: 0x0600DD97 RID: 56727 RVA: 0x004177F7 File Offset: 0x004159F7
	// (set) Token: 0x0600DD98 RID: 56728 RVA: 0x004177FF File Offset: 0x004159FF
	public override string event_id { get; set; } = "1832";

	// Token: 0x04007D4D RID: 32077
	public int i_operation_type;
}
