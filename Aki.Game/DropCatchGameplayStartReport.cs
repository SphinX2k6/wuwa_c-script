using System;
using System.Runtime.CompilerServices;

// Token: 0x02001638 RID: 5688
[NullableContext(1)]
[Nullable(0)]
public class DropCatchGameplayStartReport : PlayerCommonLogData
{
	// Token: 0x17001530 RID: 5424
	// (get) Token: 0x0600DEC7 RID: 57031 RVA: 0x0041898C File Offset: 0x00416B8C
	// (set) Token: 0x0600DEC8 RID: 57032 RVA: 0x00418994 File Offset: 0x00416B94
	public override string event_id { get; set; } = "1848";

	// Token: 0x04007F32 RID: 32562
	public int i_activity_id;

	// Token: 0x04007F33 RID: 32563
	public int i_inst_id;

	// Token: 0x04007F34 RID: 32564
	public int i_first_pass;

	// Token: 0x04007F35 RID: 32565
	public string s_trace_id = "";
}
