using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200137E RID: 4990
public class MowingTowerLevelRewardData
{
	// Token: 0x04003DF8 RID: 15864
	[Nullable(2)]
	public MowingTowerLevelDetailInfo LevelInfo;

	// Token: 0x04003DF9 RID: 15865
	[Nullable(1)]
	public List<IActivityRewardData> RewardInfo = new List<IActivityRewardData>();
}
