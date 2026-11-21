using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200553A RID: 21818
	public class DockyardShopBackpackPanelModel : DockyardBackpackPanelModelBase
	{
		// Token: 0x0603620B RID: 221707 RVA: 0x00F1BEF7 File Offset: 0x00F1A0F7
		public override bool GetIsTrawlOpen()
		{
			return FishingModel.Instance.IsInDock && DockyardModel.Instance.IsTrawlOpen;
		}

		// Token: 0x170068F0 RID: 26864
		// (get) Token: 0x0603620C RID: 221708 RVA: 0x00F1BF11 File Offset: 0x00F1A111
		// (set) Token: 0x0603620D RID: 221709 RVA: 0x00F1BF19 File Offset: 0x00F1A119
		public override bool IsAllSellOpen { get; set; } = true;

		// Token: 0x170068F1 RID: 26865
		// (get) Token: 0x0603620E RID: 221710 RVA: 0x00F1BF22 File Offset: 0x00F1A122
		// (set) Token: 0x0603620F RID: 221711 RVA: 0x00F1BF2A File Offset: 0x00F1A12A
		public override bool IsDeleteOpen { get; set; }

		// Token: 0x06036210 RID: 221712 RVA: 0x00F1BF33 File Offset: 0x00F1A133
		public override bool GetIsBackToWareHouseOpen()
		{
			return false;
		}
	}
}
