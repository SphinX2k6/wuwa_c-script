using System;
using System.Runtime.CompilerServices;

// Token: 0x0200214E RID: 8526
[NullableContext(1)]
[Nullable(0)]
public class DrinksGameplayInviteLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F3 RID: 5363
	// (get) Token: 0x06010A24 RID: 68132 RVA: 0x0040BF98 File Offset: 0x0040A198
	// (set) Token: 0x06010A25 RID: 68133 RVA: 0x0040BFA0 File Offset: 0x0040A1A0
	public override string event_id { get; set; } = "1833";

	// Token: 0x04007DC5 RID: 32197
	public int i_activity_id;

	// Token: 0x04007DC6 RID: 32198
	public int i_role_id;

	// Token: 0x04007DC7 RID: 32199
	public int i_inst_id;

	// Token: 0x04007DC8 RID: 32200
	public int i_first_pass;

	// Token: 0x04007DC9 RID: 32201
	public string s_trace_id = "";
}
