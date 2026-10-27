using System;
using System.Runtime.CompilerServices;

// Token: 0x02002128 RID: 8488
[NullableContext(1)]
[Nullable(0)]
public class UiInteractChatLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CE RID: 5326
	// (get) Token: 0x060109B4 RID: 68020 RVA: 0x0040B980 File Offset: 0x00409B80
	// (set) Token: 0x060109B5 RID: 68021 RVA: 0x0040B988 File Offset: 0x00409B88
	public override string event_id { get; set; } = "1809";

	// Token: 0x04007D18 RID: 32024
	public int i_old_count;

	// Token: 0x04007D19 RID: 32025
	public int i_new_count;

	// Token: 0x04007D1A RID: 32026
	public int i_inst_id;

	// Token: 0x04007D1B RID: 32027
	public double i_cost_time;

	// Token: 0x04007D1C RID: 32028
	public long i_skill_id;
}
