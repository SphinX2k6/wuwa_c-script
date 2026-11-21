using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200554D RID: 21837
	public class DockyardTrawlBackpackPanelModel : DockyardBackpackPanelModelBase
	{
		// Token: 0x060362AA RID: 221866 RVA: 0x00F1E5BF File Offset: 0x00F1C7BF
		public override bool GetIsTrawlOpen()
		{
			return FishingModel.Instance.IsInDock && DockyardModel.Instance.IsTrawlOpen;
		}

		// Token: 0x060362AB RID: 221867 RVA: 0x00F1E5D9 File Offset: 0x00F1C7D9
		public override bool GetIsBackToWareHouseOpen()
		{
			IDockyardBackpackInterface viewModel = this.ViewModel;
			return viewModel != null && viewModel.IsTrawlInteractive();
		}
	}
}
