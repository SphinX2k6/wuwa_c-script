using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001114 RID: 4372
public class GachaAccumulateGroupData
{
	// Token: 0x040064E9 RID: 25833
	public int GroupId;

	// Token: 0x040064EA RID: 25834
	public int CurGachaNum;

	// Token: 0x040064EB RID: 25835
	[Nullable(1)]
	public List<GachaAccumulateRewardData> RewardInfos = new List<GachaAccumulateRewardData>();
}
