using System;
using System.Runtime.CompilerServices;

// Token: 0x02002154 RID: 8532
[NullableContext(1)]
[Nullable(0)]
public class GuessJokerExitSaveReport : PlayerCommonLogData
{
	// Token: 0x170014F7 RID: 5367
	// (get) Token: 0x06010A32 RID: 68146 RVA: 0x0040C084 File Offset: 0x0040A284
	// (set) Token: 0x06010A33 RID: 68147 RVA: 0x0040C08C File Offset: 0x0040A28C
	public override string event_id { get; set; } = "1837";

	// Token: 0x04007DF5 RID: 32245
	public int i_level_id;

	// Token: 0x04007DF6 RID: 32246
	public string s_trace_id = "";

	// Token: 0x04007DF7 RID: 32247
	public int i_turn_id;

	// Token: 0x04007DF8 RID: 32248
	public int i_role_hp;

	// Token: 0x04007DF9 RID: 32249
	public int i_enemy_hp;
}
