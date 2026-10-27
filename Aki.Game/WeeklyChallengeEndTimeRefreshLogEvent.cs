using System;
using System.Runtime.CompilerServices;

// Token: 0x0200217C RID: 8572
[NullableContext(1)]
[Nullable(0)]
public class WeeklyChallengeEndTimeRefreshLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151B RID: 5403
	// (get) Token: 0x06010AA2 RID: 68258 RVA: 0x0040C698 File Offset: 0x0040A898
	// (set) Token: 0x06010AA3 RID: 68259 RVA: 0x0040C6A0 File Offset: 0x0040A8A0
	public override string event_id { get; set; } = "1935";

	// Token: 0x04007EBB RID: 32443
	public int i_season_id;
}
