using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C10 RID: 23568
	public class INpcUiInteractOnChengXiaoShanShopT
	{
		// Token: 0x1700ACA3 RID: 44195
		// (get) Token: 0x06026F7E RID: 159614 RVA: 0x00555D0B File Offset: 0x00553F0B
		// (set) Token: 0x06026F7F RID: 159615 RVA: 0x00555D13 File Offset: 0x00553F13
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700ACA4 RID: 44196
		// (get) Token: 0x06026F80 RID: 159616 RVA: 0x00555D1C File Offset: 0x00553F1C
		// (set) Token: 0x06026F81 RID: 159617 RVA: 0x00555D24 File Offset: 0x00553F24
		public string EnterMontage { get; set; }

		// Token: 0x1700ACA5 RID: 44197
		// (get) Token: 0x06026F82 RID: 159618 RVA: 0x00555D2D File Offset: 0x00553F2D
		// (set) Token: 0x06026F83 RID: 159619 RVA: 0x00555D35 File Offset: 0x00553F35
		public string StandByMontage { get; set; }

		// Token: 0x1700ACA6 RID: 44198
		// (get) Token: 0x06026F84 RID: 159620 RVA: 0x00555D3E File Offset: 0x00553F3E
		// (set) Token: 0x06026F85 RID: 159621 RVA: 0x00555D46 File Offset: 0x00553F46
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700ACA7 RID: 44199
		// (get) Token: 0x06026F86 RID: 159622 RVA: 0x00555D4F File Offset: 0x00553F4F
		// (set) Token: 0x06026F87 RID: 159623 RVA: 0x00555D57 File Offset: 0x00553F57
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700ACA8 RID: 44200
		// (get) Token: 0x06026F88 RID: 159624 RVA: 0x00555D60 File Offset: 0x00553F60
		// (set) Token: 0x06026F89 RID: 159625 RVA: 0x00555D68 File Offset: 0x00553F68
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700ACA9 RID: 44201
		// (get) Token: 0x06026F8A RID: 159626 RVA: 0x00555D71 File Offset: 0x00553F71
		// (set) Token: 0x06026F8B RID: 159627 RVA: 0x00555D79 File Offset: 0x00553F79
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700ACAA RID: 44202
		// (get) Token: 0x06026F8C RID: 159628 RVA: 0x00555D82 File Offset: 0x00553F82
		// (set) Token: 0x06026F8D RID: 159629 RVA: 0x00555D8A File Offset: 0x00553F8A
		public string UpgradeSequence { get; set; }

		// Token: 0x1700ACAB RID: 44203
		// (get) Token: 0x06026F8E RID: 159630 RVA: 0x00555D93 File Offset: 0x00553F93
		// (set) Token: 0x06026F8F RID: 159631 RVA: 0x00555D9B File Offset: 0x00553F9B
		public string FinishDeliverySequence { get; set; }

		// Token: 0x1700ACAC RID: 44204
		// (get) Token: 0x06026F90 RID: 159632 RVA: 0x00555DA4 File Offset: 0x00553FA4
		// (set) Token: 0x06026F91 RID: 159633 RVA: 0x00555DAC File Offset: 0x00553FAC
		public bool ShowNpcWhilePlayingSequence { get; set; }

		// Token: 0x1700ACAD RID: 44205
		// (get) Token: 0x06026F92 RID: 159634 RVA: 0x00555DB5 File Offset: 0x00553FB5
		// (set) Token: 0x06026F93 RID: 159635 RVA: 0x00555DBD File Offset: 0x00553FBD
		public byte NullMask { get; set; }

		// Token: 0x06026F94 RID: 159636 RVA: 0x00555DC8 File Offset: 0x00553FC8
		public INpcUiInteractOnChengXiaoShanShopT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.ShopSuccessMontage = null;
			this.EnterFlow = null;
			this.ShopSuccessFlow = null;
			this.ShopFailedFlow = null;
			this.UpgradeSequence = null;
			this.FinishDeliverySequence = null;
			this.ShowNpcWhilePlayingSequence = false;
			this.NullMask = 0;
		}
	}
}
