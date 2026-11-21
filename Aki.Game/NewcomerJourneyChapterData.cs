using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200085A RID: 2138
public class NewcomerJourneyChapterData
{
	// Token: 0x060060E5 RID: 24805 RVA: 0x001EEEC1 File Offset: 0x001ED0C1
	public NewcomerJourneyChapterData(int id)
	{
		this.Id = id;
	}

	// Token: 0x04003F3E RID: 16190
	public int Id;

	// Token: 0x04003F3F RID: 16191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<NewcomerJourneyTaskData> TaskDataList;

	// Token: 0x04003F40 RID: 16192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, NewcomerJourneyTaskData> TaskDataMap;

	// Token: 0x04003F41 RID: 16193
	[Nullable(2)]
	public NewbieAdventureV2ChapterPb Data;

	// Token: 0x04003F42 RID: 16194
	public int ChapterId = -1;
}
