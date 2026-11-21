using System;
using System.Runtime.CompilerServices;

// Token: 0x02001654 RID: 5716
[NullableContext(1)]
[Nullable(0)]
public class WeeklyChallengeEndTimeRefreshLogEvent : PlayerCommonLogData
{
	// Token: 0x17001549 RID: 5449
	// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x00418DE0 File Offset: 0x00416FE0
	// (set) Token: 0x0600DF16 RID: 57110 RVA: 0x00418DE8 File Offset: 0x00416FE8
	public override string event_id { get; set; } = "1935";

	// Token: 0x04007FCB RID: 32715
	public int i_season_id;
}
