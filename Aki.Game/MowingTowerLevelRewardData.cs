using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000832 RID: 2098
public class MowingTowerLevelRewardData
{
	// Token: 0x04003E90 RID: 16016
	[Nullable(2)]
	public MowingTowerLevelDetailInfo LevelInfo;

	// Token: 0x04003E91 RID: 16017
	[Nullable(1)]
	public List<IActivityRewardData> RewardInfo = new List<IActivityRewardData>();
}
