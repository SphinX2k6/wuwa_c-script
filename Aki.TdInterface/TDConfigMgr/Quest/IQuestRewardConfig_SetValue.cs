using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020011C6 RID: 4550
	public class IQuestRewardConfig_SetValue
	{
		// Token: 0x04003D11 RID: 15633
		public int RewardId;

		// Token: 0x04003D12 RID: 15634
		public EItemGetUiType? RewardGetUiType;

		// Token: 0x04003D13 RID: 15635
		[Nullable(2)]
		public IItemGetUiConfigSpecialQuest UiConfig;
	}
}
