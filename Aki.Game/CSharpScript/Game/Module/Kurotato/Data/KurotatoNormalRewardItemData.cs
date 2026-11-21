using System;

namespace CSharpScript.Game.Module.Kurotato.Data
{
	// Token: 0x02004776 RID: 18294
	public class KurotatoNormalRewardItemData : KurotatoRewardItemData
	{
		// Token: 0x0602DF01 RID: 188161 RVA: 0x00CDAEC2 File Offset: 0x00CD90C2
		public KurotatoNormalRewardItemData(int rewardId, int current, int target, int status) : base(rewardId, current, target, status)
		{
			base.NormalConfig = KurotatoConfig.Instance.GetNormalRewardConfigById(rewardId);
		}
	}
}
