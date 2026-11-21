using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020015AD RID: 5549
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolEquipLogData : PlayerCommonLogData
{
	// Token: 0x170014AB RID: 5291
	// (get) Token: 0x0600DD32 RID: 56626 RVA: 0x004172E0 File Offset: 0x004154E0
	// (set) Token: 0x0600DD33 RID: 56627 RVA: 0x004172E8 File Offset: 0x004154E8
	public override string event_id { get; set; } = "1018";

	// Token: 0x04007CBD RID: 31933
	public int i_explore_tool_id;

	// Token: 0x04007CBE RID: 31934
	public List<List<int>> o_authorization = new List<List<int>>();

	// Token: 0x04007CBF RID: 31935
	public List<ExploreToolAuthorizationLogData> o_new_authorization = new List<ExploreToolAuthorizationLogData>();

	// Token: 0x04007CC0 RID: 31936
	public int i_item_id;

	// Token: 0x04007CC1 RID: 31937
	public int i_operation;

	// Token: 0x04007CC2 RID: 31938
	public int i_roulette_id;
}
