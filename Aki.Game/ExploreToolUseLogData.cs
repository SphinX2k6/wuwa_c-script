using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020015AA RID: 5546
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolUseLogData : PlayerCommonLogData
{
	// Token: 0x170014A9 RID: 5289
	// (get) Token: 0x0600DD2B RID: 56619 RVA: 0x00417256 File Offset: 0x00415456
	// (set) Token: 0x0600DD2C RID: 56620 RVA: 0x0041725E File Offset: 0x0041545E
	public override string event_id { get; set; } = "1026";

	// Token: 0x04007CB4 RID: 31924
	public string i_tool_id = "";

	// Token: 0x04007CB5 RID: 31925
	public List<IUnitLogData> o_report = new List<IUnitLogData>();
}
