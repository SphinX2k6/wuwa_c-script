using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566C RID: 22124
	public class INpcUiInteractOnAntiqueShopT
	{
		// Token: 0x1700A3FE RID: 41982
		// (get) Token: 0x06024D03 RID: 150787 RVA: 0x00514798 File Offset: 0x00512998
		// (set) Token: 0x06024D04 RID: 150788 RVA: 0x005147A0 File Offset: 0x005129A0
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A3FF RID: 41983
		// (get) Token: 0x06024D05 RID: 150789 RVA: 0x005147A9 File Offset: 0x005129A9
		// (set) Token: 0x06024D06 RID: 150790 RVA: 0x005147B1 File Offset: 0x005129B1
		public string EnterMontage { get; set; }

		// Token: 0x1700A400 RID: 41984
		// (get) Token: 0x06024D07 RID: 150791 RVA: 0x005147BA File Offset: 0x005129BA
		// (set) Token: 0x06024D08 RID: 150792 RVA: 0x005147C2 File Offset: 0x005129C2
		public string StandByMontage { get; set; }

		// Token: 0x1700A401 RID: 41985
		// (get) Token: 0x06024D09 RID: 150793 RVA: 0x005147CB File Offset: 0x005129CB
		// (set) Token: 0x06024D0A RID: 150794 RVA: 0x005147D3 File Offset: 0x005129D3
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700A402 RID: 41986
		// (get) Token: 0x06024D0B RID: 150795 RVA: 0x005147DC File Offset: 0x005129DC
		// (set) Token: 0x06024D0C RID: 150796 RVA: 0x005147E4 File Offset: 0x005129E4
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A403 RID: 41987
		// (get) Token: 0x06024D0D RID: 150797 RVA: 0x005147ED File Offset: 0x005129ED
		// (set) Token: 0x06024D0E RID: 150798 RVA: 0x005147F5 File Offset: 0x005129F5
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A404 RID: 41988
		// (get) Token: 0x06024D0F RID: 150799 RVA: 0x005147FE File Offset: 0x005129FE
		// (set) Token: 0x06024D10 RID: 150800 RVA: 0x00514806 File Offset: 0x00512A06
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A405 RID: 41989
		// (get) Token: 0x06024D11 RID: 150801 RVA: 0x0051480F File Offset: 0x00512A0F
		// (set) Token: 0x06024D12 RID: 150802 RVA: 0x00514817 File Offset: 0x00512A17
		public string UpgradeSequence { get; set; }

		// Token: 0x1700A406 RID: 41990
		// (get) Token: 0x06024D13 RID: 150803 RVA: 0x00514820 File Offset: 0x00512A20
		// (set) Token: 0x06024D14 RID: 150804 RVA: 0x00514828 File Offset: 0x00512A28
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700A407 RID: 41991
		// (get) Token: 0x06024D15 RID: 150805 RVA: 0x00514831 File Offset: 0x00512A31
		// (set) Token: 0x06024D16 RID: 150806 RVA: 0x00514839 File Offset: 0x00512A39
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06024D17 RID: 150807 RVA: 0x00514844 File Offset: 0x00512A44
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
