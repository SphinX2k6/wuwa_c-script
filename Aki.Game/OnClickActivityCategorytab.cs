using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001620 RID: 5664
[NullableContext(1)]
[Nullable(0)]
public class OnClickActivityCategorytab : PlayerCommonLogData
{
	// Token: 0x1700151B RID: 5403
	// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x004185E7 File Offset: 0x004167E7
	// (set) Token: 0x0600DE86 RID: 56966 RVA: 0x004185EF File Offset: 0x004167EF
	public override string event_id { get; set; } = "1818";

	// Token: 0x04007EB6 RID: 32438
	public int i_type;

	// Token: 0x04007EB7 RID: 32439
	public List<ActivityLogReportInfo> o_content = new List<ActivityLogReportInfo>();
}
