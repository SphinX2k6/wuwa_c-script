using System;
using System.Runtime.CompilerServices;

// Token: 0x020020FB RID: 8443
[NullableContext(1)]
[Nullable(0)]
public class MailJumpLogEvent : PlayerCommonLogData
{
	// Token: 0x170014A1 RID: 5281
	// (get) Token: 0x0601092D RID: 67885 RVA: 0x0040B12F File Offset: 0x0040932F
	// (set) Token: 0x0601092E RID: 67886 RVA: 0x0040B137 File Offset: 0x00409337
	public override string event_id { get; set; } = "1934";

	// Token: 0x04007C52 RID: 31826
	public string s_mail_id = "";

	// Token: 0x04007C53 RID: 31827
	public int i_level;

	// Token: 0x04007C54 RID: 31828
	public long l_received_time;

	// Token: 0x04007C55 RID: 31829
	public int i_reason;

	// Token: 0x04007C56 RID: 31830
	public long l_take_time;
}
