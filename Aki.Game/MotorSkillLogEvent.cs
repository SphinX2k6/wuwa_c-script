using System;
using System.Runtime.CompilerServices;

// Token: 0x0200211D RID: 8477
[NullableContext(1)]
[Nullable(0)]
public class MotorSkillLogEvent : PlayerCommonLogData
{
	// Token: 0x170014C3 RID: 5315
	// (get) Token: 0x06010993 RID: 67987 RVA: 0x0040B7E9 File Offset: 0x004099E9
	// (set) Token: 0x06010994 RID: 67988 RVA: 0x0040B7F1 File Offset: 0x004099F1
	public override string event_id { get; set; } = "2000";

	// Token: 0x04007CF6 RID: 31990
	public string i_skill_id = "";
}
