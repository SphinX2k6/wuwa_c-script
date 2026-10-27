using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566F RID: 22127
	public class INpcUiInteractOnChengXiaoShanShopT
	{
		// Token: 0x1700A414 RID: 42004
		// (get) Token: 0x06024D45 RID: 150853 RVA: 0x0051516F File Offset: 0x0051336F
		// (set) Token: 0x06024D46 RID: 150854 RVA: 0x00515177 File Offset: 0x00513377
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A415 RID: 42005
		// (get) Token: 0x06024D47 RID: 150855 RVA: 0x00515180 File Offset: 0x00513380
		// (set) Token: 0x06024D48 RID: 150856 RVA: 0x00515188 File Offset: 0x00513388
		public string EnterMontage { get; set; }

		// Token: 0x1700A416 RID: 42006
		// (get) Token: 0x06024D49 RID: 150857 RVA: 0x00515191 File Offset: 0x00513391
		// (set) Token: 0x06024D4A RID: 150858 RVA: 0x00515199 File Offset: 0x00513399
		public string StandByMontage { get; set; }

		// Token: 0x1700A417 RID: 42007
		// (get) Token: 0x06024D4B RID: 150859 RVA: 0x005151A2 File Offset: 0x005133A2
		// (set) Token: 0x06024D4C RID: 150860 RVA: 0x005151AA File Offset: 0x005133AA
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700A418 RID: 42008
		// (get) Token: 0x06024D4D RID: 150861 RVA: 0x005151B3 File Offset: 0x005133B3
		// (set) Token: 0x06024D4E RID: 150862 RVA: 0x005151BB File Offset: 0x005133BB
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A419 RID: 42009
		// (get) Token: 0x06024D4F RID: 150863 RVA: 0x005151C4 File Offset: 0x005133C4
		// (set) Token: 0x06024D50 RID: 150864 RVA: 0x005151CC File Offset: 0x005133CC
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A41A RID: 42010
		// (get) Token: 0x06024D51 RID: 150865 RVA: 0x005151D5 File Offset: 0x005133D5
		// (set) Token: 0x06024D52 RID: 150866 RVA: 0x005151DD File Offset: 0x005133DD
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A41B RID: 42011
		// (get) Token: 0x06024D53 RID: 150867 RVA: 0x005151E6 File Offset: 0x005133E6
		// (set) Token: 0x06024D54 RID: 150868 RVA: 0x005151EE File Offset: 0x005133EE
		public string UpgradeSequence { get; set; }

		// Token: 0x1700A41C RID: 42012
		// (get) Token: 0x06024D55 RID: 150869 RVA: 0x005151F7 File Offset: 0x005133F7
		// (set) Token: 0x06024D56 RID: 150870 RVA: 0x005151FF File Offset: 0x005133FF
		public string FinishDeliverySequence { get; set; }

		// Token: 0x1700A41D RID: 42013
		// (get) Token: 0x06024D57 RID: 150871 RVA: 0x00515208 File Offset: 0x00513408
		// (set) Token: 0x06024D58 RID: 150872 RVA: 0x00515210 File Offset: 0x00513410
		public bool ShowNpcWhilePlayingSequence { get; set; }

		// Token: 0x1700A41E RID: 42014
		// (get) Token: 0x06024D59 RID: 150873 RVA: 0x00515219 File Offset: 0x00513419
		// (set) Token: 0x06024D5A RID: 150874 RVA: 0x00515221 File Offset: 0x00513421
		public byte NullMask { get; set; }

		// Token: 0x06024D5B RID: 150875 RVA: 0x0051522C File Offset: 0x0051342C
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
