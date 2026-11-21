using System;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004777 RID: 18295
	public class KurotatoLimitedTimeRewardItemData : KurotatoRewardItemData
	{
		// Token: 0x0602DF02 RID: 188162 RVA: 0x00CDAEE0 File Offset: 0x00CD90E0
		public KurotatoLimitedTimeRewardItemData(int rewardId, int current, int target, int status) : base(rewardId, current, target, status)
		{
			base.LimitConfig = KurotatoConfig.Instance.GetLimitRewardConfigById(rewardId);
		}

		// Token: 0x0602DF03 RID: 188163 RVA: 0x00CDAF00 File Offset: 0x00CD9100
		public int GetTabId()
		{
			return base.LimitConfig.Value.TabId;
		}
	}
}
