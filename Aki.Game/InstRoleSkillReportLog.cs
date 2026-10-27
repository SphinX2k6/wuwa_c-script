using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C4 RID: 8388
[NullableContext(1)]
[Nullable(0)]
public class InstRoleSkillReportLog : RoleSkillReportLog
{
	// Token: 0x0601088D RID: 67725 RVA: 0x0040A573 File Offset: 0x00408773
	public InstRoleSkillReportLog(int inst_id, string fight_id)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700146E RID: 5230
	// (get) Token: 0x0601088E RID: 67726 RVA: 0x0040A59F File Offset: 0x0040879F
	// (set) Token: 0x0601088F RID: 67727 RVA: 0x0040A5A7 File Offset: 0x004087A7
	public override string event_id { get; set; } = "102806";

	// Token: 0x04007AFE RID: 31486
	public int i_inst_id;

	// Token: 0x04007AFF RID: 31487
	public string s_fight_id = "";
}
