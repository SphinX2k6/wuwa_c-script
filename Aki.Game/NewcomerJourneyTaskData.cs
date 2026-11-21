using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02000859 RID: 2137
public class NewcomerJourneyTaskData
{
	// Token: 0x060060E4 RID: 24804 RVA: 0x001EEEAB File Offset: 0x001ED0AB
	public NewcomerJourneyTaskData(int id)
	{
		this.Id = id;
	}

	// Token: 0x04003F3A RID: 16186
	public int Id;

	// Token: 0x04003F3B RID: 16187
	[Nullable(2)]
	public ConditionTask TaskData;

	// Token: 0x04003F3C RID: 16188
	public AdventureTaskV2? Config;

	// Token: 0x04003F3D RID: 16189
	public int ChapterId = -1;
}
