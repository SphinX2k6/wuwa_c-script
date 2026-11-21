using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0D RID: 23565
	public class INpcUiInteractOnAntiqueShopT
	{
		// Token: 0x1700AC8D RID: 44173
		// (get) Token: 0x06026F3C RID: 159548 RVA: 0x00555334 File Offset: 0x00553534
		// (set) Token: 0x06026F3D RID: 159549 RVA: 0x0055533C File Offset: 0x0055353C
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700AC8E RID: 44174
		// (get) Token: 0x06026F3E RID: 159550 RVA: 0x00555345 File Offset: 0x00553545
		// (set) Token: 0x06026F3F RID: 159551 RVA: 0x0055534D File Offset: 0x0055354D
		public string EnterMontage { get; set; }

		// Token: 0x1700AC8F RID: 44175
		// (get) Token: 0x06026F40 RID: 159552 RVA: 0x00555356 File Offset: 0x00553556
		// (set) Token: 0x06026F41 RID: 159553 RVA: 0x0055535E File Offset: 0x0055355E
		public string StandByMontage { get; set; }

		// Token: 0x1700AC90 RID: 44176
		// (get) Token: 0x06026F42 RID: 159554 RVA: 0x00555367 File Offset: 0x00553567
		// (set) Token: 0x06026F43 RID: 159555 RVA: 0x0055536F File Offset: 0x0055356F
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700AC91 RID: 44177
		// (get) Token: 0x06026F44 RID: 159556 RVA: 0x00555378 File Offset: 0x00553578
		// (set) Token: 0x06026F45 RID: 159557 RVA: 0x00555380 File Offset: 0x00553580
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700AC92 RID: 44178
		// (get) Token: 0x06026F46 RID: 159558 RVA: 0x00555389 File Offset: 0x00553589
		// (set) Token: 0x06026F47 RID: 159559 RVA: 0x00555391 File Offset: 0x00553591
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700AC93 RID: 44179
		// (get) Token: 0x06026F48 RID: 159560 RVA: 0x0055539A File Offset: 0x0055359A
		// (set) Token: 0x06026F49 RID: 159561 RVA: 0x005553A2 File Offset: 0x005535A2
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700AC94 RID: 44180
		// (get) Token: 0x06026F4A RID: 159562 RVA: 0x005553AB File Offset: 0x005535AB
		// (set) Token: 0x06026F4B RID: 159563 RVA: 0x005553B3 File Offset: 0x005535B3
		public string UpgradeSequence { get; set; }

		// Token: 0x1700AC95 RID: 44181
		// (get) Token: 0x06026F4C RID: 159564 RVA: 0x005553BC File Offset: 0x005535BC
		// (set) Token: 0x06026F4D RID: 159565 RVA: 0x005553C4 File Offset: 0x005535C4
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700AC96 RID: 44182
		// (get) Token: 0x06026F4E RID: 159566 RVA: 0x005553CD File Offset: 0x005535CD
		// (set) Token: 0x06026F4F RID: 159567 RVA: 0x005553D5 File Offset: 0x005535D5
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06026F50 RID: 159568 RVA: 0x005553E0 File Offset: 0x005535E0
		public INpcUiInteractOnAntiqueShopT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.ShopSuccessMontage = null;
			this.EnterFlow = null;
			this.ShopSuccessFlow = null;
			this.ShopFailedFlow = null;
			this.UpgradeSequence = null;
			this.ExitMontage = null;
			this.ExitFlow = null;
		}
	}
}
