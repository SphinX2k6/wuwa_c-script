using System;
using System.Runtime.CompilerServices;

// Token: 0x020020BA RID: 8378
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillReportLog : PlayerCommonLogData
{
	// Token: 0x17001467 RID: 5223
	// (get) Token: 0x06010873 RID: 67699 RVA: 0x0040A189 File Offset: 0x00408389
	// (set) Token: 0x06010874 RID: 67700 RVA: 0x0040A191 File Offset: 0x00408391
	public override string event_id { get; set; } = "102702";

	// Token: 0x04007AB2 RID: 31410
	public string s_battle_id = "";

	// Token: 0x04007AB3 RID: 31411
	public int i_role_id;

	// Token: 0x04007AB4 RID: 31412
	public int i_role_level;

	// Token: 0x04007AB5 RID: 31413
	public int i_role_quality;

	// Token: 0x04007AB6 RID: 31414
	public string s_reports = "";
}
