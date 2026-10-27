using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006115 RID: 24853
	public class RoverlikeShopRewardButton : RoverlikeRewardButton
	{
		// Token: 0x0603ED7B RID: 257403 RVA: 0x00F2D73D File Offset: 0x00F2B93D
		protected override void OnStart()
		{
			this.ClickCallback = delegate()
			{
				RoverlikeActivityController instance = RoverlikeActivityController.Instance;
				int? num;
				if (instance == null)
				{
					num = null;
				}
				else
				{
					RoverlikeActivityData currentActivityData = instance.GetCurrentActivityData();
					RoverRogueActivity? roverRogueActivity;
					num = ((currentActivityData != null) ? ((currentActivityData.GetParamConfig() != null) ? new int?(roverRogueActivity.GetValueOrDefault().ShopId) : null) : null);
				}
				int? num2 = num;
				if (num2.GetValueOrDefault() <= 0)
				{
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.RoverlikeShopView, null, null);
			};
		}

		// Token: 0x0603ED7C RID: 257404 RVA: 0x00F2D764 File Offset: 0x00F2B964
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotRoverlikeShopRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x0603ED7D RID: 257405 RVA: 0x00F2D77E File Offset: 0x00F2B97E
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotRoverlikeShopRewardBtn, base.GetItem(2), 0);
		}
	}
}
