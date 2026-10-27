using System;
using System.Runtime.CompilerServices;

// Token: 0x02002136 RID: 8502
[NullableContext(1)]
[Nullable(0)]
public class ActivityPreWarmStayLogEvent : PlayerCommonLogData
{
	// Token: 0x170014DC RID: 5340
	// (get) Token: 0x060109DE RID: 68062 RVA: 0x0040BB99 File Offset: 0x00409D99
	// (set) Token: 0x060109DF RID: 68063 RVA: 0x0040BBA1 File Offset: 0x00409DA1
	public override string event_id { get; set; } = "1812";

	// Token: 0x04007D49 RID: 32073
	public int i_activity_id;

	// Token: 0x04007D4A RID: 32074
	public int i_chapter_id;

	// Token: 0x04007D4B RID: 32075
	public double i_cost_time;
}
