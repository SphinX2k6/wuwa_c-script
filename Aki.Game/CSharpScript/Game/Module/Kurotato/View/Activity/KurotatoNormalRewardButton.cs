using System;

namespace CSharpScript.Game.Module.Kurotato.View.Activity
{
	// Token: 0x02004768 RID: 18280
	public class KurotatoNormalRewardButton : KurotatoRewardButton
	{
		// Token: 0x0602DE18 RID: 187928 RVA: 0x00CD7845 File Offset: 0x00CD5A45
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotKurotatoNormalRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x0602DE19 RID: 187929 RVA: 0x00CD785F File Offset: 0x00CD5A5F
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotKurotatoNormalRewardBtn, base.GetItem(2), 0);
		}
	}
}
