using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002148 RID: 8520
[NullableContext(1)]
[Nullable(0)]
public class OnClickActivityCategorytab : PlayerCommonLogData
{
	// Token: 0x170014ED RID: 5357
	// (get) Token: 0x06010A12 RID: 68114 RVA: 0x0040BE9F File Offset: 0x0040A09F
	// (set) Token: 0x06010A13 RID: 68115 RVA: 0x0040BEA7 File Offset: 0x0040A0A7
	public override string event_id { get; set; } = "1818";

	// Token: 0x04007DA6 RID: 32166
	public int i_type;

	// Token: 0x04007DA7 RID: 32167
	public List<ActivityLogReportInfo> o_content = new List<ActivityLogReportInfo>();
}
