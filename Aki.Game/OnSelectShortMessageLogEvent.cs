using System;
using System.Runtime.CompilerServices;

// Token: 0x02002145 RID: 8517
[NullableContext(1)]
[Nullable(0)]
public class OnSelectShortMessageLogEvent : PlayerCommonLogData
{
	// Token: 0x170014EA RID: 5354
	// (get) Token: 0x06010A09 RID: 68105 RVA: 0x0040BE33 File Offset: 0x0040A033
	// (set) Token: 0x06010A0A RID: 68106 RVA: 0x0040BE3B File Offset: 0x0040A03B
	public override string event_id { get; set; } = "1816";

	// Token: 0x04007D93 RID: 32147
	public int i_id;

	// Token: 0x04007D94 RID: 32148
	public int i_type;

	// Token: 0x04007D95 RID: 32149
	public int i_reason;

	// Token: 0x04007D96 RID: 32150
	public long l_received_time;

	// Token: 0x04007D97 RID: 32151
	public int i_role_id;
}
