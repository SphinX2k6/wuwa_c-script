using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F78 RID: 20344
	[NullableContext(1)]
	public interface ITotalTopUpPreviewViewParam
	{
		// Token: 0x170063B7 RID: 25527
		// (get) Token: 0x060330B9 RID: 209081
		// (set) Token: 0x060330BA RID: 209082
		TotalTopUpReward RewardConfig { get; set; }

		// Token: 0x170063B8 RID: 25528
		// (get) Token: 0x060330BB RID: 209083
		// (set) Token: 0x060330BC RID: 209084
		TotalTopUpRewardData RewardData { get; set; }
	}
}
