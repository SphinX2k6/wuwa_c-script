using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020013A5 RID: 5029
public class NewcomerJourneyTaskData
{
	// Token: 0x06008D4E RID: 36174 RVA: 0x001E6277 File Offset: 0x001E4477
	public NewcomerJourneyTaskData(int id)
	{
		this.Id = id;
	}

	// Token: 0x04003EA2 RID: 16034
	public int Id;

	// Token: 0x04003EA3 RID: 16035
	[Nullable(2)]
	public ConditionTask TaskData;

	// Token: 0x04003EA4 RID: 16036
	public AdventureTaskV2? Config;

	// Token: 0x04003EA5 RID: 16037
	public int ChapterId = -1;
}
