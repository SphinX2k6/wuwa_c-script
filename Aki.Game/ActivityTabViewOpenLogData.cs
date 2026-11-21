using System;
using System.Runtime.CompilerServices;

// Token: 0x020015B6 RID: 5558
[NullableContext(1)]
[Nullable(0)]
public class ActivityTabViewOpenLogData : PlayerCommonLogData
{
	// Token: 0x170014B4 RID: 5300
	// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x0041743A File Offset: 0x0041563A
	// (set) Token: 0x0600DD4E RID: 56654 RVA: 0x00417442 File Offset: 0x00415642
	public override string event_id { get; set; } = "1020";

	// Token: 0x04007CF4 RID: 31988
	public int i_activity_id;

	// Token: 0x04007CF5 RID: 31989
	public int i_activity_type;

	// Token: 0x04007CF6 RID: 31990
	public int i_time_left;

	// Token: 0x04007CF7 RID: 31991
	public int i_unlock;

	// Token: 0x04007CF8 RID: 31992
	public int i_type;
}
