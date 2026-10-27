using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020011B9 RID: 4537
public class BossRushLevelRewardData
{
	// Token: 0x04003771 RID: 14193
	[Nullable(2)]
	public BossRushLevelDetailInfo LevelInfo;

	// Token: 0x04003772 RID: 14194
	[Nullable(1)]
	public List<IActivityRewardData> RewardInfo = new List<IActivityRewardData>();
}
