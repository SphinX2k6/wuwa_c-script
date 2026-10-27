using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065BC RID: 26044
	public class DockyardShopBackpackPanelModel : DockyardBackpackPanelModelBase
	{
		// Token: 0x06041546 RID: 267590 RVA: 0x00FD4EBB File Offset: 0x00FD30BB
		public override bool GetIsTrawlOpen()
		{
			return FishingModel.Instance.IsInDock && DockyardModel.Instance.IsTrawlOpen;
		}

		// Token: 0x1700958E RID: 38286
		// (get) Token: 0x06041547 RID: 267591 RVA: 0x00FD4ED5 File Offset: 0x00FD30D5
		// (set) Token: 0x06041548 RID: 267592 RVA: 0x00FD4EDD File Offset: 0x00FD30DD
		public override bool IsAllSellOpen { get; set; } = true;

		// Token: 0x1700958F RID: 38287
		// (get) Token: 0x06041549 RID: 267593 RVA: 0x00FD4EE6 File Offset: 0x00FD30E6
		// (set) Token: 0x0604154A RID: 267594 RVA: 0x00FD4EEE File Offset: 0x00FD30EE
		public override bool IsDeleteOpen { get; set; }

		// Token: 0x0604154B RID: 267595 RVA: 0x00FD4EF7 File Offset: 0x00FD30F7
		public override bool GetIsBackToWareHouseOpen()
		{
			return false;
		}
	}
}
