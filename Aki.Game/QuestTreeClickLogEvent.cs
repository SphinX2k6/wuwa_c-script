using System;
using System.Runtime.CompilerServices;

// Token: 0x02001609 RID: 5641
[NullableContext(1)]
[Nullable(0)]
public class QuestTreeClickLogEvent : PlayerCommonLogData
{
	// Token: 0x17001505 RID: 5381
	// (get) Token: 0x0600DE42 RID: 56898 RVA: 0x00418222 File Offset: 0x00416422
	// (set) Token: 0x0600DE43 RID: 56899 RVA: 0x0041822A File Offset: 0x0041642A
	public override string event_id { get; set; } = "1912";

	// Token: 0x04007E46 RID: 32326
	public int i_chapter_id;

	// Token: 0x04007E47 RID: 32327
	public int i_quest_id;

	// Token: 0x04007E48 RID: 32328
	public int i_quest_status;

	// Token: 0x04007E49 RID: 32329
	public int i_quest_type;
}
