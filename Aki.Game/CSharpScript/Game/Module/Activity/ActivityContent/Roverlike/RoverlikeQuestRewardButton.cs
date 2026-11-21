using System;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005094 RID: 20628
	public class RoverlikeQuestRewardButton : RoverlikeRewardButton
	{
		// Token: 0x06033A41 RID: 211521 RVA: 0x00E745B3 File Offset: 0x00E727B3
		protected override void OnStart()
		{
			this.ClickCallback = delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.RoverlikeQuestRewardView, null, null);
			};
		}

		// Token: 0x06033A42 RID: 211522 RVA: 0x00E745DA File Offset: 0x00E727DA
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotRoverlikeQuestRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x06033A43 RID: 211523 RVA: 0x00E745F4 File Offset: 0x00E727F4
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotRoverlikeQuestRewardBtn, base.GetItem(2), 0);
		}
	}
}
