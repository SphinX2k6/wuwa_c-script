using System;
using System.Runtime.CompilerServices;

// Token: 0x020013E2 RID: 5090
public class PinballLevelRecordData
{
	// Token: 0x04003F84 RID: 16260
	public int LevelId;

	// Token: 0x04003F85 RID: 16261
	public int ChapterId;

	// Token: 0x04003F86 RID: 16262
	[Nullable(1)]
	public int[] LevelStarConditionIds = Array.Empty<int>();

	// Token: 0x04003F87 RID: 16263
	public int LevelScore;

	// Token: 0x04003F88 RID: 16264
	public int LevelPassedTime;

	// Token: 0x04003F89 RID: 16265
	public EPinballLevelShowType LevelShowType = EPinballLevelShowType.Normal;

	// Token: 0x04003F8A RID: 16266
	public EPinballLevelPassStatus PassStatus = EPinballLevelPassStatus.Unfinished;
}
