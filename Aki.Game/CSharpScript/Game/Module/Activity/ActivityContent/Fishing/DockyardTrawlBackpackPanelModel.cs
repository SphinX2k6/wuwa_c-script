using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065CF RID: 26063
	public class DockyardTrawlBackpackPanelModel : DockyardBackpackPanelModelBase
	{
		// Token: 0x060415E5 RID: 267749 RVA: 0x00FD757F File Offset: 0x00FD577F
		public override bool GetIsTrawlOpen()
		{
			return FishingModel.Instance.IsInDock && DockyardModel.Instance.IsTrawlOpen;
		}

		// Token: 0x060415E6 RID: 267750 RVA: 0x00FD7599 File Offset: 0x00FD5799
		public override bool GetIsBackToWareHouseOpen()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			return viewModel != null && viewModel.IsTrawlInteractive();
		}
	}
}
