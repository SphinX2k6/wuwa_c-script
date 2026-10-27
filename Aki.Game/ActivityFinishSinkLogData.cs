using System;
using System.Runtime.CompilerServices;

// Token: 0x02002179 RID: 8569
[NullableContext(1)]
[Nullable(0)]
public class ActivityFinishSinkLogData : PlayerCommonLogData
{
	// Token: 0x17001518 RID: 5400
	// (get) Token: 0x06010A99 RID: 68249 RVA: 0x0040C621 File Offset: 0x0040A821
	// (set) Token: 0x06010A9A RID: 68250 RVA: 0x0040C629 File Offset: 0x0040A829
	public override string event_id { get; set; } = "1937";

	// Token: 0x04007E98 RID: 32408
	public int i_activity_id;
}
