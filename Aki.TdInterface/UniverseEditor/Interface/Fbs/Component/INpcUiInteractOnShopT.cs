using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1C RID: 23580
	public class INpcUiInteractOnShopT
	{
		// Token: 0x1700ACE2 RID: 44258
		// (get) Token: 0x06027044 RID: 159812 RVA: 0x00557B4C File Offset: 0x00555D4C
		// (set) Token: 0x06027045 RID: 159813 RVA: 0x00557B54 File Offset: 0x00555D54
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700ACE3 RID: 44259
		// (get) Token: 0x06027046 RID: 159814 RVA: 0x00557B5D File Offset: 0x00555D5D
		// (set) Token: 0x06027047 RID: 159815 RVA: 0x00557B65 File Offset: 0x00555D65
		public string EnterMontage { get; set; }

		// Token: 0x1700ACE4 RID: 44260
		// (get) Token: 0x06027048 RID: 159816 RVA: 0x00557B6E File Offset: 0x00555D6E
		// (set) Token: 0x06027049 RID: 159817 RVA: 0x00557B76 File Offset: 0x00555D76
		public string StandByMontage { get; set; }

		// Token: 0x1700ACE5 RID: 44261
		// (get) Token: 0x0602704A RID: 159818 RVA: 0x00557B7F File Offset: 0x00555D7F
		// (set) Token: 0x0602704B RID: 159819 RVA: 0x00557B87 File Offset: 0x00555D87
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700ACE6 RID: 44262
		// (get) Token: 0x0602704C RID: 159820 RVA: 0x00557B90 File Offset: 0x00555D90
		// (set) Token: 0x0602704D RID: 159821 RVA: 0x00557B98 File Offset: 0x00555D98
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700ACE7 RID: 44263
		// (get) Token: 0x0602704E RID: 159822 RVA: 0x00557BA1 File Offset: 0x00555DA1
		// (set) Token: 0x0602704F RID: 159823 RVA: 0x00557BA9 File Offset: 0x00555DA9
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700ACE8 RID: 44264
		// (get) Token: 0x06027050 RID: 159824 RVA: 0x00557BB2 File Offset: 0x00555DB2
		// (set) Token: 0x06027051 RID: 159825 RVA: 0x00557BBA File Offset: 0x00555DBA
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700ACE9 RID: 44265
		// (get) Token: 0x06027052 RID: 159826 RVA: 0x00557BC3 File Offset: 0x00555DC3
		// (set) Token: 0x06027053 RID: 159827 RVA: 0x00557BCB File Offset: 0x00555DCB
		public IPlayFlowT WorkingFlow { get; set; }

		// Token: 0x1700ACEA RID: 44266
		// (get) Token: 0x06027054 RID: 159828 RVA: 0x00557BD4 File Offset: 0x00555DD4
		// (set) Token: 0x06027055 RID: 159829 RVA: 0x00557BDC File Offset: 0x00555DDC
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700ACEB RID: 44267
		// (get) Token: 0x06027056 RID: 159830 RVA: 0x00557BE5 File Offset: 0x00555DE5
		// (set) Token: 0x06027057 RID: 159831 RVA: 0x00557BED File Offset: 0x00555DED
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06027058 RID: 159832 RVA: 0x00557BF8 File Offset: 0x00555DF8
		public INpcUiInteractOnShopT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.ShopSuccessMontage = null;
			this.EnterFlow = null;
			this.ShopSuccessFlow = null;
			this.ShopFailedFlow = null;
			this.WorkingFlow = null;
			this.ExitMontage = null;
			this.ExitFlow = null;
		}
	}
}
