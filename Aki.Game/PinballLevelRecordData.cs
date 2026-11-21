using System;
using System.Runtime.CompilerServices;

// Token: 0x02000896 RID: 2198
public class PinballLevelRecordData
{
	// Token: 0x0400401C RID: 16412
	public int LevelId;

	// Token: 0x0400401D RID: 16413
	public int ChapterId;

	// Token: 0x0400401E RID: 16414
	[Nullable(1)]
	public int[] LevelStarConditionIds = Array.Empty<int>();

	// Token: 0x0400401F RID: 16415
	public int LevelScore;

	// Token: 0x04004020 RID: 16416
	public int LevelPassedTime;

	// Token: 0x04004021 RID: 16417
	public EPinballLevelShowType LevelShowType = EPinballLevelShowType.Normal;

	// Token: 0x04004022 RID: 16418
	public EPinballLevelPassStatus PassStatus = EPinballLevelPassStatus.Unfinished;
}
