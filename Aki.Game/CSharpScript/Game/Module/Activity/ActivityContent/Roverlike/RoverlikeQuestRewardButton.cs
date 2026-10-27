using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006116 RID: 24854
	public class RoverlikeQuestRewardButton : RoverlikeRewardButton
	{
		// Token: 0x0603ED7F RID: 257407 RVA: 0x00F2D79F File Offset: 0x00F2B99F
		protected override void OnStart()
		{
			this.ClickCallback = delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeQuestRewardView, null, null);
			};
		}

		// Token: 0x0603ED80 RID: 257408 RVA: 0x00F2D7C6 File Offset: 0x00F2B9C6
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotRoverlikeQuestRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x0603ED81 RID: 257409 RVA: 0x00F2D7E0 File Offset: 0x00F2B9E0
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotRoverlikeQuestRewardBtn, base.GetItem(2), 0);
		}
	}
}
