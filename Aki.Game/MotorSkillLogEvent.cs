using System;
using System.Runtime.CompilerServices;

// Token: 0x020015F5 RID: 5621
[NullableContext(1)]
[Nullable(0)]
public class MotorSkillLogEvent : PlayerCommonLogData
{
	// Token: 0x170014F1 RID: 5361
	// (get) Token: 0x0600DE06 RID: 56838 RVA: 0x00417F31 File Offset: 0x00416131
	// (set) Token: 0x0600DE07 RID: 56839 RVA: 0x00417F39 File Offset: 0x00416139
	public override string event_id { get; set; } = "2000";

	// Token: 0x04007E04 RID: 32260
	public string i_skill_id = "";
}
