using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C2 RID: 8386
[NullableContext(1)]
[Nullable(0)]
public class InstRoleStateRecord : RoleStateRecord
{
	// Token: 0x06010887 RID: 67719 RVA: 0x0040A4F5 File Offset: 0x004086F5
	public InstRoleStateRecord(int roleId, int inst_id, string fight_id) : base(roleId)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700146C RID: 5228
	// (get) Token: 0x06010888 RID: 67720 RVA: 0x0040A522 File Offset: 0x00408722
	// (set) Token: 0x06010889 RID: 67721 RVA: 0x0040A52A File Offset: 0x0040872A
	public override string event_id { get; set; } = "102804";

	// Token: 0x04007AF8 RID: 31480
	public int i_inst_id;

	// Token: 0x04007AF9 RID: 31481
	public string s_fight_id = "";
}
