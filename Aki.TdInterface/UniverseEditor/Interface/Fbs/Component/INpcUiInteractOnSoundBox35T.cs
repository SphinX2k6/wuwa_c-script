using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005684 RID: 22148
	public class INpcUiInteractOnSoundBox35T
	{
		// Token: 0x1700A495 RID: 42133
		// (get) Token: 0x06024EDB RID: 151259 RVA: 0x00519688 File Offset: 0x00517888
		// (set) Token: 0x06024EDC RID: 151260 RVA: 0x00519690 File Offset: 0x00517890
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A496 RID: 42134
		// (get) Token: 0x06024EDD RID: 151261 RVA: 0x00519699 File Offset: 0x00517899
		// (set) Token: 0x06024EDE RID: 151262 RVA: 0x005196A1 File Offset: 0x005178A1
		public string EnterMontage { get; set; }

		// Token: 0x1700A497 RID: 42135
		// (get) Token: 0x06024EDF RID: 151263 RVA: 0x005196AA File Offset: 0x005178AA
		// (set) Token: 0x06024EE0 RID: 151264 RVA: 0x005196B2 File Offset: 0x005178B2
		public string StandByMontage { get; set; }

		// Token: 0x1700A498 RID: 42136
		// (get) Token: 0x06024EE1 RID: 151265 RVA: 0x005196BB File Offset: 0x005178BB
		// (set) Token: 0x06024EE2 RID: 151266 RVA: 0x005196C3 File Offset: 0x005178C3
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700A499 RID: 42137
		// (get) Token: 0x06024EE3 RID: 151267 RVA: 0x005196CC File Offset: 0x005178CC
		// (set) Token: 0x06024EE4 RID: 151268 RVA: 0x005196D4 File Offset: 0x005178D4
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A49A RID: 42138
		// (get) Token: 0x06024EE5 RID: 151269 RVA: 0x005196DD File Offset: 0x005178DD
		// (set) Token: 0x06024EE6 RID: 151270 RVA: 0x005196E5 File Offset: 0x005178E5
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A49B RID: 42139
		// (get) Token: 0x06024EE7 RID: 151271 RVA: 0x005196EE File Offset: 0x005178EE
		// (set) Token: 0x06024EE8 RID: 151272 RVA: 0x005196F6 File Offset: 0x005178F6
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A49C RID: 42140
		// (get) Token: 0x06024EE9 RID: 151273 RVA: 0x005196FF File Offset: 0x005178FF
		// (set) Token: 0x06024EEA RID: 151274 RVA: 0x00519707 File Offset: 0x00517907
		public string UpgradeSequence { get; set; }

		// Token: 0x1700A49D RID: 42141
		// (get) Token: 0x06024EEB RID: 151275 RVA: 0x00519710 File Offset: 0x00517910
		// (set) Token: 0x06024EEC RID: 151276 RVA: 0x00519718 File Offset: 0x00517918
		public IPlayFlowT UpgradeFlow { get; set; }

		// Token: 0x1700A49E RID: 42142
		// (get) Token: 0x06024EED RID: 151277 RVA: 0x00519721 File Offset: 0x00517921
		// (set) Token: 0x06024EEE RID: 151278 RVA: 0x00519729 File Offset: 0x00517929
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700A49F RID: 42143
		// (get) Token: 0x06024EEF RID: 151279 RVA: 0x00519732 File Offset: 0x00517932
		// (set) Token: 0x06024EF0 RID: 151280 RVA: 0x0051973A File Offset: 0x0051793A
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06024EF1 RID: 151281 RVA: 0x00519744 File Offset: 0x00517944
		public INpcUiInteractOnSoundBox35T()
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
