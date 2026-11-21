using System;
using System.Runtime.CompilerServices;

// Token: 0x0200162F RID: 5679
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRewardAppearReport : PlayerCommonLogData
{
	// Token: 0x17001528 RID: 5416
	// (get) Token: 0x0600DEAE RID: 57006 RVA: 0x00418843 File Offset: 0x00416A43
	// (set) Token: 0x0600DEAF RID: 57007 RVA: 0x0041884B File Offset: 0x00416A4B
	public override string event_id { get; set; } = "1840";

	// Token: 0x04007F13 RID: 32531
	public int i_activity_id;

	// Token: 0x04007F14 RID: 32532
	public int i_round;

	// Token: 0x04007F15 RID: 32533
	public int i_step_id;
}
