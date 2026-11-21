using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001CB2 RID: 7346
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerRankInfoCache
{
	// Token: 0x04009F08 RID: 40712
	public readonly List<RoleTowerRankData> FriendList = new List<RoleTowerRankData>();

	// Token: 0x04009F09 RID: 40713
	[Nullable(2)]
	public RoleTowerRankData SelfServer;

	// Token: 0x04009F0A RID: 40714
	public long RewardSettleTime;

	// Token: 0x04009F0B RID: 40715
	public long NextRefreshTime;

	// Token: 0x04009F0C RID: 40716
	public bool CanGetServerReward;

	// Token: 0x04009F0D RID: 40717
	public readonly List<Aki.Protocol.RewardItem> PreviewRewards = new List<Aki.Protocol.RewardItem>();
}
