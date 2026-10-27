using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x020013BF RID: 5055
[NullableContext(1)]
public interface IActivityNewPlayerSupportRewardViewParam
{
	// Token: 0x17000BF9 RID: 3065
	// (get) Token: 0x06008E94 RID: 36500
	RewardData<ICommonRewardInfo> RewardData { get; }

	// Token: 0x17000BFA RID: 3066
	// (get) Token: 0x06008E95 RID: 36501
	List<int> TrialRoleList { get; }
}
