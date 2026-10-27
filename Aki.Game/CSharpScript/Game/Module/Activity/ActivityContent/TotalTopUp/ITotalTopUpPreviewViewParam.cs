using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F91 RID: 24465
	[NullableContext(1)]
	public interface ITotalTopUpPreviewViewParam
	{
		// Token: 0x17008FE5 RID: 36837
		// (get) Token: 0x0603E11F RID: 254239
		// (set) Token: 0x0603E120 RID: 254240
		TotalTopUpReward RewardConfig { get; set; }

		// Token: 0x17008FE6 RID: 36838
		// (get) Token: 0x0603E121 RID: 254241
		// (set) Token: 0x0603E122 RID: 254242
		TotalTopUpRewardData RewardData { get; set; }
	}
}
