using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020D6 RID: 8406
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolEquipLogData : PlayerCommonLogData
{
	// Token: 0x1700147E RID: 5246
	// (get) Token: 0x060108C2 RID: 67778 RVA: 0x0040ABD0 File Offset: 0x00408DD0
	// (set) Token: 0x060108C3 RID: 67779 RVA: 0x0040ABD8 File Offset: 0x00408DD8
	public override string event_id { get; set; } = "1018";

	// Token: 0x04007BBE RID: 31678
	public int i_explore_tool_id;

	// Token: 0x04007BBF RID: 31679
	public List<List<int>> o_authorization = new List<List<int>>();

	// Token: 0x04007BC0 RID: 31680
	public List<ExploreToolAuthorizationLogData> o_new_authorization = new List<ExploreToolAuthorizationLogData>();

	// Token: 0x04007BC1 RID: 31681
	public int i_item_id;

	// Token: 0x04007BC2 RID: 31682
	public int i_operation;

	// Token: 0x04007BC3 RID: 31683
	public int i_roulette_id;
}
