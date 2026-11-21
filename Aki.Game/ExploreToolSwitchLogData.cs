using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020015AC RID: 5548
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolSwitchLogData : PlayerCommonLogData
{
	// Token: 0x170014AA RID: 5290
	// (get) Token: 0x0600DD2F RID: 56623 RVA: 0x004172A6 File Offset: 0x004154A6
	// (set) Token: 0x0600DD30 RID: 56624 RVA: 0x004172AE File Offset: 0x004154AE
	public override string event_id { get; set; } = "1011";

	// Token: 0x04007CB9 RID: 31929
	public int i_explore_tool_id;

	// Token: 0x04007CBA RID: 31930
	public List<List<int>> o_authorization = new List<List<int>>();

	// Token: 0x04007CBB RID: 31931
	public List<ExploreToolAuthorizationLogData> o_new_authorization = new List<ExploreToolAuthorizationLogData>();
}
