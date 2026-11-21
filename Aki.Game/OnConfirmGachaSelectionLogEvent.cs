using System;
using System.Runtime.CompilerServices;

// Token: 0x020015C8 RID: 5576
[NullableContext(1)]
[Nullable(0)]
public class OnConfirmGachaSelectionLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C4 RID: 5316
	// (get) Token: 0x0600DD7F RID: 56703 RVA: 0x004176D7 File Offset: 0x004158D7
	// (set) Token: 0x0600DD80 RID: 56704 RVA: 0x004176DF File Offset: 0x004158DF
	public override string event_id { get; set; } = "1855";

	// Token: 0x04007D32 RID: 32050
	public int i_type;

	// Token: 0x04007D33 RID: 32051
	public int i_roleid_id;

	// Token: 0x04007D34 RID: 32052
	public int i_time_left;
}
