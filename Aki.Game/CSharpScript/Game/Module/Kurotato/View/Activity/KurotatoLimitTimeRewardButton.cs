using System;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004769 RID: 18281
	public class KurotatoLimitTimeRewardButton : KurotatoRewardButton
	{
		// Token: 0x0602DE1B RID: 187931 RVA: 0x00CD7880 File Offset: 0x00CD5A80
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotKurotatoLimitRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x0602DE1C RID: 187932 RVA: 0x00CD789A File Offset: 0x00CD5A9A
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotKurotatoLimitRewardBtn, base.GetItem(2), 0);
		}
	}
}
