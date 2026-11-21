using System;
using System.Runtime.CompilerServices;

// Token: 0x02001599 RID: 5529
[NullableContext(1)]
[Nullable(0)]
public class InstRoleStateRecord : RoleStateRecord
{
	// Token: 0x0600DCF7 RID: 56567 RVA: 0x00416BFD File Offset: 0x00414DFD
	public InstRoleStateRecord(int roleId, int inst_id, string fight_id) : base(roleId)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x17001499 RID: 5273
	// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x00416C2A File Offset: 0x00414E2A
	// (set) Token: 0x0600DCF9 RID: 56569 RVA: 0x00416C32 File Offset: 0x00414E32
	public override string event_id { get; set; } = "102804";

	// Token: 0x04007BF6 RID: 31734
	public int i_inst_id;

	// Token: 0x04007BF7 RID: 31735
	public string s_fight_id = "";
}
