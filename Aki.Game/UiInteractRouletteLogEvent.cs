using System;
using System.Runtime.CompilerServices;

// Token: 0x020015FF RID: 5631
[NullableContext(1)]
[Nullable(0)]
public class UiInteractRouletteLogEvent : PlayerCommonLogData
{
	// Token: 0x170014FB RID: 5371
	// (get) Token: 0x0600DE24 RID: 56868 RVA: 0x004180A4 File Offset: 0x004162A4
	// (set) Token: 0x0600DE25 RID: 56869 RVA: 0x004180AC File Offset: 0x004162AC
	public override string event_id { get; set; } = "1808";

	// Token: 0x04007E20 RID: 32288
	public int i_old_count;

	// Token: 0x04007E21 RID: 32289
	public int i_new_count;

	// Token: 0x04007E22 RID: 32290
	public int i_inst_id;

	// Token: 0x04007E23 RID: 32291
	public double i_cost_time;

	// Token: 0x04007E24 RID: 32292
	public long i_skill_id;
}
