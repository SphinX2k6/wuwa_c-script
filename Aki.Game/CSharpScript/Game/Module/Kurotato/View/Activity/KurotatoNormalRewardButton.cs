using System;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02005791 RID: 22417
	public class KurotatoNormalRewardButton : KurotatoRewardButton
	{
		// Token: 0x06038F08 RID: 233224 RVA: 0x00D88AF5 File Offset: 0x00D86CF5
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotKurotatoNormalRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x06038F09 RID: 233225 RVA: 0x00D88B0F File Offset: 0x00D86D0F
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotKurotatoNormalRewardBtn, base.GetItem(2), 0);
		}
	}
}
