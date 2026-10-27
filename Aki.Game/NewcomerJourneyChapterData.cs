using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020013A6 RID: 5030
public class NewcomerJourneyChapterData
{
	// Token: 0x06008D4F RID: 36175 RVA: 0x001E628D File Offset: 0x001E448D
	public NewcomerJourneyChapterData(int id)
	{
		this.Id = id;
	}

	// Token: 0x04003EA6 RID: 16038
	public int Id;

	// Token: 0x04003EA7 RID: 16039
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<NewcomerJourneyTaskData> TaskDataList;

	// Token: 0x04003EA8 RID: 16040
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, NewcomerJourneyTaskData> TaskDataMap;

	// Token: 0x04003EA9 RID: 16041
	[Nullable(2)]
	public NewbieAdventureV2ChapterPb Data;

	// Token: 0x04003EAA RID: 16042
	public int ChapterId = -1;
}
