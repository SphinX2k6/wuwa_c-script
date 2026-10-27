using System;
using System.Runtime.CompilerServices;

// Token: 0x020020C5 RID: 8389
[NullableContext(1)]
[Nullable(0)]
public class InstReactionLogRecord : ReactionLogRecord
{
	// Token: 0x06010890 RID: 67728 RVA: 0x0040A5B0 File Offset: 0x004087B0
	public InstReactionLogRecord(int inst_id, string fight_id)
	{
		this.i_inst_id = inst_id;
		this.s_fight_id = fight_id;
	}

	// Token: 0x1700146F RID: 5231
	// (get) Token: 0x06010891 RID: 67729 RVA: 0x0040A5DC File Offset: 0x004087DC
	// (set) Token: 0x06010892 RID: 67730 RVA: 0x0040A5E4 File Offset: 0x004087E4
	public override string event_id { get; set; } = "102807";

	// Token: 0x04007B01 RID: 31489
	public int i_inst_id;

	// Token: 0x04007B02 RID: 31490
	public string s_fight_id = "";
}
