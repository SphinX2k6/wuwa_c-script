using System;
using System.Runtime.CompilerServices;

// Token: 0x0200217D RID: 8573
[NullableContext(1)]
[Nullable(0)]
public class WeeklyChallengeRedClearLogEvent : PlayerCommonLogData
{
	// Token: 0x1700151C RID: 5404
	// (get) Token: 0x06010AA5 RID: 68261 RVA: 0x0040C6BC File Offset: 0x0040A8BC
	// (set) Token: 0x06010AA6 RID: 68262 RVA: 0x0040C6C4 File Offset: 0x0040A8C4
	public override string event_id { get; set; } = "1936";

	// Token: 0x04007EBD RID: 32445
	public int i_season_id;

	// Token: 0x04007EBE RID: 32446
	public int i_type;
}
