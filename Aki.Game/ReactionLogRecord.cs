using System;
using System.Runtime.CompilerServices;

// Token: 0x02001595 RID: 5525
[NullableContext(1)]
[Nullable(0)]
public class ReactionLogRecord : PlayerCommonLogData
{
	// Token: 0x17001496 RID: 5270
	// (get) Token: 0x0600DCEB RID: 56555 RVA: 0x00416956 File Offset: 0x00414B56
	// (set) Token: 0x0600DCEC RID: 56556 RVA: 0x0041695E File Offset: 0x00414B5E
	public override string event_id { get; set; } = "102703";

	// Token: 0x04007BCB RID: 31691
	public string s_battle_id = "";

	// Token: 0x04007BCC RID: 31692
	public string s_reports = "";
}
