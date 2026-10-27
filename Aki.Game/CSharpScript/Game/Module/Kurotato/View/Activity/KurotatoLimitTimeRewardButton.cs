using System;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02005792 RID: 22418
	public class KurotatoLimitTimeRewardButton : KurotatoRewardButton
	{
		// Token: 0x06038F0B RID: 233227 RVA: 0x00D88B30 File Offset: 0x00D86D30
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotKurotatoLimitRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x06038F0C RID: 233228 RVA: 0x00D88B4A File Offset: 0x00D86D4A
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotKurotatoLimitRewardBtn, base.GetItem(2), 0);
		}
	}
}
