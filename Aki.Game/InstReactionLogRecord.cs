using System;
using System.Runtime.CompilerServices;

// Token: 0x0200159C RID: 5532
[NullableContext(1)]
[Nullable(0)]
public class InstReactionLogRecord : ReactionLogRecord
{
	// Token: 0x0600DD00 RID: 56576 RVA: 0x00416CB8 File Offset: 0x00414EB8
	public InstReactionLogRecord(int inst_id, string fight_id)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700149C RID: 5276
	// (get) Token: 0x0600DD01 RID: 56577 RVA: 0x00416CE4 File Offset: 0x00414EE4
	// (set) Token: 0x0600DD02 RID: 56578 RVA: 0x00416CEC File Offset: 0x00414EEC
	public override string event_id { get; set; } = "102807";

	// Token: 0x04007BFF RID: 31743
	public int i_inst_id;

	// Token: 0x04007C00 RID: 31744
	public string s_fight_id = "";
}
