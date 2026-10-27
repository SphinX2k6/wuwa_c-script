using System;
using System.Runtime.CompilerServices;

// Token: 0x02002168 RID: 8552
[NullableContext(1)]
[Nullable(0)]
public class SheriffQuestLogEvent : PlayerCommonLogData
{
	// Token: 0x1700150A RID: 5386
	// (get) Token: 0x06010A6C RID: 68204 RVA: 0x0040C390 File Offset: 0x0040A590
	// (set) Token: 0x06010A6D RID: 68205 RVA: 0x0040C398 File Offset: 0x0040A598
	public override string event_id { get; set; } = "1930";

	// Token: 0x04007E4F RID: 32335
	public int i_area_id;

	// Token: 0x04007E50 RID: 32336
	public int i_quest_id;

	// Token: 0x04007E51 RID: 32337
	public int i_quest_status;
}
