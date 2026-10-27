using System;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x020057A0 RID: 22432
	public class KurotatoLimitedTimeRewardItemData : KurotatoRewardItemData
	{
		// Token: 0x06038FF2 RID: 233458 RVA: 0x00D8C164 File Offset: 0x00D8A364
		public KurotatoLimitedTimeRewardItemData(int rewardId, int current, int target, int status) : base(rewardId, current, target, status)
		{
			base.LimitConfig = KurotatoConfig.Instance.GetLimitRewardConfigById(rewardId);
		}

		// Token: 0x06038FF3 RID: 233459 RVA: 0x00D8C184 File Offset: 0x00D8A384
		public int GetTabId()
		{
			return base.LimitConfig.Value.TabId;
		}
	}
}
