using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ItemReward;

// Token: 0x02000873 RID: 2163
[NullableContext(1)]
public interface IActivityNewPlayerSupportRewardViewParam
{
	// Token: 0x17000C19 RID: 3097
	// (get) Token: 0x06006229 RID: 25129
	RewardData<ICommonRewardInfo> RewardData { get; }

	// Token: 0x17000C1A RID: 3098
	// (get) Token: 0x0600622A RID: 25130
	List<int> TrialRoleList { get; }
}
