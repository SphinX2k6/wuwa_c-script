using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001618 RID: 5656
[NullableContext(1)]
[Nullable(0)]
public class MobileResCleanUpLogEvent : CommonLogData
{
	// Token: 0x17001513 RID: 5395
	// (get) Token: 0x0600DE6D RID: 56941 RVA: 0x0041846F File Offset: 0x0041666F
	// (set) Token: 0x0600DE6E RID: 56942 RVA: 0x00418477 File Offset: 0x00416677
	public override string event_id { get; set; } = "1713";

	// Token: 0x04007E8D RID: 32397
	public int i_required_space;

	// Token: 0x04007E8E RID: 32398
	public List<MobileResCleanUpLogEventContentData> o_content = new List<MobileResCleanUpLogEventContentData>();

	// Token: 0x04007E8F RID: 32399
	public int i_type;

	// Token: 0x04007E90 RID: 32400
	public string s_trace_id = "";

	// Token: 0x04007E91 RID: 32401
	public string unique_id = "";

	// Token: 0x04007E92 RID: 32402
	public string player_id = "";
}
