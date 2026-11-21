using System;
using Aki.Config;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005093 RID: 20627
	public class RoverlikeShopRewardButton : RoverlikeRewardButton
	{
		// Token: 0x06033A3D RID: 211517 RVA: 0x00E74551 File Offset: 0x00E72751
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

		// Token: 0x06033A3E RID: 211518 RVA: 0x00E74578 File Offset: 0x00E72778
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotRoverlikeShopRewardBtn, base.GetItem(2), null, 0);
		}

		// Token: 0x06033A3F RID: 211519 RVA: 0x00E74592 File Offset: 0x00E72792
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotRoverlikeShopRewardBtn, base.GetItem(2), 0);
		}
	}
}
