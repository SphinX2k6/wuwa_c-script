using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001098 RID: 4248
	public class IQuestRewardConfig_SetValue
	{
		// Token: 0x040039C4 RID: 14788
		public int RewardId;

		// Token: 0x040039C5 RID: 14789
		public EItemGetUiType? RewardGetUiType;

		// Token: 0x040039C6 RID: 14790
		[Nullable(2)]
		public IItemGetUiConfigSpecialQuest UiConfig;
	}
}
