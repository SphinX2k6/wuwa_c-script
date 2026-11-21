using System;
using System.Runtime.CompilerServices;

// Token: 0x02001591 RID: 5521
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillReportLog : PlayerCommonLogData
{
	// Token: 0x17001494 RID: 5268
	// (get) Token: 0x0600DCE3 RID: 56547 RVA: 0x00416891 File Offset: 0x00414A91
	// (set) Token: 0x0600DCE4 RID: 56548 RVA: 0x00416899 File Offset: 0x00414A99
	public override string event_id { get; set; } = "102702";

	// Token: 0x04007BB0 RID: 31664
	public string s_battle_id = "";

	// Token: 0x04007BB1 RID: 31665
	public int i_role_id;

	// Token: 0x04007BB2 RID: 31666
	public int i_role_level;

	// Token: 0x04007BB3 RID: 31667
	public int i_role_quality;

	// Token: 0x04007BB4 RID: 31668
	public string s_reports = "";
}
