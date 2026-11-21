using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001639 RID: 5689
[NullableContext(1)]
[Nullable(0)]
public class DropCatchGameplayEndReport : PlayerCommonLogData
{
	// Token: 0x17001531 RID: 5425
	// (get) Token: 0x0600DECA RID: 57034 RVA: 0x004189BB File Offset: 0x00416BBB
	// (set) Token: 0x0600DECB RID: 57035 RVA: 0x004189C3 File Offset: 0x00416BC3
	public override string event_id { get; set; } = "1849";

	// Token: 0x04007F37 RID: 32567
	public int i_activity_id;

	// Token: 0x04007F38 RID: 32568
	public int i_inst_id;

	// Token: 0x04007F39 RID: 32569
	public int i_first_pass;

	// Token: 0x04007F3A RID: 32570
	public string s_trace_id = "";

	// Token: 0x04007F3B RID: 32571
	public int i_result;

	// Token: 0x04007F3C RID: 32572
	public int i_reason;

	// Token: 0x04007F3D RID: 32573
	public int i_get_score;

	// Token: 0x04007F3E RID: 32574
	public int i_skill_times;

	// Token: 0x04007F3F RID: 32575
	public int i_cost_time;

	// Token: 0x04007F40 RID: 32576
	public int i_add_time;

	// Token: 0x04007F41 RID: 32577
	[Nullable(2)]
	public List<int> o_item_report;
}
