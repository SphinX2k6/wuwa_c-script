using System;
using System.Runtime.CompilerServices;

// Token: 0x02002127 RID: 8487
[NullableContext(1)]
[Nullable(0)]
public class UiInteractRouletteLogEvent : PlayerCommonLogData
{
	// Token: 0x170014CD RID: 5325
	// (get) Token: 0x060109B1 RID: 68017 RVA: 0x0040B95C File Offset: 0x00409B5C
	// (set) Token: 0x060109B2 RID: 68018 RVA: 0x0040B964 File Offset: 0x00409B64
	public override string event_id { get; set; } = "1808";

	// Token: 0x04007D12 RID: 32018
	public int i_old_count;

	// Token: 0x04007D13 RID: 32019
	public int i_new_count;

	// Token: 0x04007D14 RID: 32020
	public int i_inst_id;

	// Token: 0x04007D15 RID: 32021
	public double i_cost_time;

	// Token: 0x04007D16 RID: 32022
	public long i_skill_id;
}
