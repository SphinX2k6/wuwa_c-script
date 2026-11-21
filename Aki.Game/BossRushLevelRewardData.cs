using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200066D RID: 1645
public class BossRushLevelRewardData
{
	// Token: 0x0400380A RID: 14346
	[Nullable(2)]
	public BossRushLevelDetailInfo LevelInfo;

	// Token: 0x0400380B RID: 14347
	[Nullable(1)]
	public List<IActivityRewardData> RewardInfo = new List<IActivityRewardData>();
}
