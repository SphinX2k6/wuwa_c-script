using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C28 RID: 23592
	public class INpcUiInteractOnSunSpiritT
	{
		// Token: 0x1700AD3B RID: 44347
		// (get) Token: 0x0602715A RID: 160090 RVA: 0x0055AE1C File Offset: 0x0055901C
		// (set) Token: 0x0602715B RID: 160091 RVA: 0x0055AE24 File Offset: 0x00559024
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700AD3C RID: 44348
		// (get) Token: 0x0602715C RID: 160092 RVA: 0x0055AE2D File Offset: 0x0055902D
		// (set) Token: 0x0602715D RID: 160093 RVA: 0x0055AE35 File Offset: 0x00559035
		public string EnterMontage { get; set; }

		// Token: 0x1700AD3D RID: 44349
		// (get) Token: 0x0602715E RID: 160094 RVA: 0x0055AE3E File Offset: 0x0055903E
		// (set) Token: 0x0602715F RID: 160095 RVA: 0x0055AE46 File Offset: 0x00559046
		public string StandByMontage { get; set; }

		// Token: 0x1700AD3E RID: 44350
		// (get) Token: 0x06027160 RID: 160096 RVA: 0x0055AE4F File Offset: 0x0055904F
		// (set) Token: 0x06027161 RID: 160097 RVA: 0x0055AE57 File Offset: 0x00559057
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700AD3F RID: 44351
		// (get) Token: 0x06027162 RID: 160098 RVA: 0x0055AE60 File Offset: 0x00559060
		// (set) Token: 0x06027163 RID: 160099 RVA: 0x0055AE68 File Offset: 0x00559068
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700AD40 RID: 44352
		// (get) Token: 0x06027164 RID: 160100 RVA: 0x0055AE71 File Offset: 0x00559071
		// (set) Token: 0x06027165 RID: 160101 RVA: 0x0055AE79 File Offset: 0x00559079
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700AD41 RID: 44353
		// (get) Token: 0x06027166 RID: 160102 RVA: 0x0055AE82 File Offset: 0x00559082
		// (set) Token: 0x06027167 RID: 160103 RVA: 0x0055AE8A File Offset: 0x0055908A
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700AD42 RID: 44354
		// (get) Token: 0x06027168 RID: 160104 RVA: 0x0055AE93 File Offset: 0x00559093
		// (set) Token: 0x06027169 RID: 160105 RVA: 0x0055AE9B File Offset: 0x0055909B
		public string UpgradeSequence { get; set; }

		// Token: 0x1700AD43 RID: 44355
		// (get) Token: 0x0602716A RID: 160106 RVA: 0x0055AEA4 File Offset: 0x005590A4
		// (set) Token: 0x0602716B RID: 160107 RVA: 0x0055AEAC File Offset: 0x005590AC
		public IPlayFlowT UpgradeFlow { get; set; }

		// Token: 0x1700AD44 RID: 44356
		// (get) Token: 0x0602716C RID: 160108 RVA: 0x0055AEB5 File Offset: 0x005590B5
		// (set) Token: 0x0602716D RID: 160109 RVA: 0x0055AEBD File Offset: 0x005590BD
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700AD45 RID: 44357
		// (get) Token: 0x0602716E RID: 160110 RVA: 0x0055AEC6 File Offset: 0x005590C6
		// (set) Token: 0x0602716F RID: 160111 RVA: 0x0055AECE File Offset: 0x005590CE
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06027170 RID: 160112 RVA: 0x0055AED8 File Offset: 0x005590D8
		public INpcUiInteractOnSunSpiritT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.ShopSuccessMontage = null;
			this.EnterFlow = null;
			this.ShopSuccessFlow = null;
			this.ShopFailedFlow = null;
			this.UpgradeSequence = null;
			this.UpgradeFlow = null;
			this.ExitMontage = null;
			this.ExitFlow = null;
		}
	}
}
