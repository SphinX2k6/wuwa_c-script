using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020020D3 RID: 8403
[NullableContext(1)]
[Nullable(0)]
public class ExploreToolUseLogData : PlayerCommonLogData
{
	// Token: 0x1700147C RID: 5244
	// (get) Token: 0x060108BB RID: 67771 RVA: 0x0040AB46 File Offset: 0x00408D46
	// (set) Token: 0x060108BC RID: 67772 RVA: 0x0040AB4E File Offset: 0x00408D4E
	public override string event_id { get; set; } = "1026";

	// Token: 0x04007BB5 RID: 31669
	public string i_tool_id = "";

	// Token: 0x04007BB6 RID: 31670
	public List<IUnitLogData> o_report = new List<IUnitLogData>();
}
