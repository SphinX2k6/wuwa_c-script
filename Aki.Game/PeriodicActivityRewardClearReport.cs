using System;
using System.Runtime.CompilerServices;

// Token: 0x02001630 RID: 5680
[NullableContext(1)]
[Nullable(0)]
public class PeriodicActivityRewardClearReport : PlayerCommonLogData
{
	// Token: 0x17001529 RID: 5417
	// (get) Token: 0x0600DEB1 RID: 57009 RVA: 0x00418867 File Offset: 0x00416A67
	// (set) Token: 0x0600DEB2 RID: 57010 RVA: 0x0041886F File Offset: 0x00416A6F
	public override string event_id { get; set; } = "1841";

	// Token: 0x04007F17 RID: 32535
	public int i_activity_id;

	// Token: 0x04007F18 RID: 32536
	public int i_round;

	// Token: 0x04007F19 RID: 32537
	public int i_step_id;

	// Token: 0x04007F1A RID: 32538
	public int i_way;
}
