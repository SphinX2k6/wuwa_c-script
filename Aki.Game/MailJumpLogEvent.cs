using System;
using System.Runtime.CompilerServices;

// Token: 0x020015D3 RID: 5587
[NullableContext(1)]
[Nullable(0)]
public class MailJumpLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CF RID: 5327
	// (get) Token: 0x0600DDA0 RID: 56736 RVA: 0x00417863 File Offset: 0x00415A63
	// (set) Token: 0x0600DDA1 RID: 56737 RVA: 0x0041786B File Offset: 0x00415A6B
	public override string event_id { get; set; } = "1934";

	// Token: 0x04007D54 RID: 32084
	public string s_mail_id = "";

	// Token: 0x04007D55 RID: 32085
	public int i_level;

	// Token: 0x04007D56 RID: 32086
	public long l_received_time;

	// Token: 0x04007D57 RID: 32087
	public int i_reason;

	// Token: 0x04007D58 RID: 32088
	public long l_take_time;
}
