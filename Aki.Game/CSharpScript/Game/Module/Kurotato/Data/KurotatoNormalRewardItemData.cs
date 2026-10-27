using System;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x0200579F RID: 22431
	public class KurotatoNormalRewardItemData : KurotatoRewardItemData
	{
		// Token: 0x06038FF1 RID: 233457 RVA: 0x00D8C146 File Offset: 0x00D8A346
		public KurotatoNormalRewardItemData(int rewardId, int current, int target, int status) : base(rewardId, current, target, status)
		{
			base.NormalConfig = KurotatoConfig.Instance.GetNormalRewardConfigById(rewardId);
		}
	}
}
