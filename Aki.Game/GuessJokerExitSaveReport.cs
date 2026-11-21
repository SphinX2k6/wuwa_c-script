using System;
using System.Runtime.CompilerServices;

// Token: 0x0200162C RID: 5676
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerExitSaveReport : PlayerCommonLogData
{
	// Token: 0x17001525 RID: 5413
	// (get) Token: 0x0600DEA5 RID: 56997 RVA: 0x004187CC File Offset: 0x004169CC
	// (set) Token: 0x0600DEA6 RID: 56998 RVA: 0x004187D4 File Offset: 0x004169D4
	public override string event_id { get; set; } = "1837";

	// Token: 0x04007F05 RID: 32517
	public int i_level_id;

	// Token: 0x04007F06 RID: 32518
	public string s_trace_id = "";

	// Token: 0x04007F07 RID: 32519
	public int i_turn_id;

	// Token: 0x04007F08 RID: 32520
	public int i_role_hp;

	// Token: 0x04007F09 RID: 32521
	public int i_enemy_hp;
}
