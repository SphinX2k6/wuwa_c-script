using System;
using System.Runtime.CompilerServices;

// Token: 0x0200159B RID: 5531
[NullableContext(1)]
[Nullable(0)]
public class InstRoleSkillReportLog : RoleSkillReportLog
{
	// Token: 0x0600DCFD RID: 56573 RVA: 0x00416C7B File Offset: 0x00414E7B
	public InstRoleSkillReportLog(int inst_id, string fight_id)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700149B RID: 5275
	// (get) Token: 0x0600DCFE RID: 56574 RVA: 0x00416CA7 File Offset: 0x00414EA7
	// (set) Token: 0x0600DCFF RID: 56575 RVA: 0x00416CAF File Offset: 0x00414EAF
	public override string event_id { get; set; } = "102806";

	// Token: 0x04007BFC RID: 31740
	public int i_inst_id;

	// Token: 0x04007BFD RID: 31741
	public string s_fight_id = "";
}
