using System;
using System.Runtime.CompilerServices;

// Token: 0x02001655 RID: 5717
[NullableContext(1)]
[Nullable(0)]
public class WeeklyChallengeRedClearLogEvent : PlayerCommonLogData
{
	// Token: 0x1700154A RID: 5450
	// (get) Token: 0x0600DF18 RID: 57112 RVA: 0x00418E04 File Offset: 0x00417004
	// (set) Token: 0x0600DF19 RID: 57113 RVA: 0x00418E0C File Offset: 0x0041700C
	public override string event_id { get; set; } = "1936";

	// Token: 0x04007FCD RID: 32717
	public int i_season_id;

	// Token: 0x04007FCE RID: 32718
	public int i_type;
}
