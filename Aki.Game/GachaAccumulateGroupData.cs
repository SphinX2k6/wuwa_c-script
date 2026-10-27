using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001C55 RID: 7253
public class GachaAccumulateGroupData
{
	// Token: 0x04006417 RID: 25623
	public int GroupId;

	// Token: 0x04006418 RID: 25624
	public int CurGachaNum;

	// Token: 0x04006419 RID: 25625
	[Nullable(1)]
	public List<GachaAccumulateRewardData> RewardInfos = new List<GachaAccumulateRewardData>();
}
