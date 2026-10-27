using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020D5 RID: 8405
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolSwitchLogData : PlayerCommonLogData
{
	// Token: 0x1700147D RID: 5245
	// (get) Token: 0x060108BF RID: 67775 RVA: 0x0040AB96 File Offset: 0x00408D96
	// (set) Token: 0x060108C0 RID: 67776 RVA: 0x0040AB9E File Offset: 0x00408D9E
	public override string event_id { get; set; } = "1011";

	// Token: 0x04007BBA RID: 31674
	public int i_explore_tool_id;

	// Token: 0x04007BBB RID: 31675
	public List<List<int>> o_authorization = new List<List<int>>();

	// Token: 0x04007BBC RID: 31676
	public List<ExploreToolAuthorizationLogData> o_new_authorization = new List<ExploreToolAuthorizationLogData>();
}
