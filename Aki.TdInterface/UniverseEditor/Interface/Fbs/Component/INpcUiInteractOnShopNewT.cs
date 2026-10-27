using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567E RID: 22142
	public class INpcUiInteractOnShopNewT
	{
		// Token: 0x1700A468 RID: 42088
		// (get) Token: 0x06024E51 RID: 151121 RVA: 0x00517E2B File Offset: 0x0051602B
		// (set) Token: 0x06024E52 RID: 151122 RVA: 0x00517E33 File Offset: 0x00516033
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A469 RID: 42089
		// (get) Token: 0x06024E53 RID: 151123 RVA: 0x00517E3C File Offset: 0x0051603C
		// (set) Token: 0x06024E54 RID: 151124 RVA: 0x00517E44 File Offset: 0x00516044
		public TMontageConfigUnion EnterMontage { get; set; }

		// Token: 0x1700A46A RID: 42090
		// (get) Token: 0x06024E55 RID: 151125 RVA: 0x00517E4D File Offset: 0x0051604D
		// (set) Token: 0x06024E56 RID: 151126 RVA: 0x00517E55 File Offset: 0x00516055
		public TMontageConfigUnion StandByMontage { get; set; }

		// Token: 0x1700A46B RID: 42091
		// (get) Token: 0x06024E57 RID: 151127 RVA: 0x00517E5E File Offset: 0x0051605E
		// (set) Token: 0x06024E58 RID: 151128 RVA: 0x00517E66 File Offset: 0x00516066
		public TMontageConfigUnion ShopSuccessMontage { get; set; }

		// Token: 0x1700A46C RID: 42092
		// (get) Token: 0x06024E59 RID: 151129 RVA: 0x00517E6F File Offset: 0x0051606F
		// (set) Token: 0x06024E5A RID: 151130 RVA: 0x00517E77 File Offset: 0x00516077
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A46D RID: 42093
		// (get) Token: 0x06024E5B RID: 151131 RVA: 0x00517E80 File Offset: 0x00516080
		// (set) Token: 0x06024E5C RID: 151132 RVA: 0x00517E88 File Offset: 0x00516088
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A46E RID: 42094
		// (get) Token: 0x06024E5D RID: 151133 RVA: 0x00517E91 File Offset: 0x00516091
		// (set) Token: 0x06024E5E RID: 151134 RVA: 0x00517E99 File Offset: 0x00516099
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A46F RID: 42095
		// (get) Token: 0x06024E5F RID: 151135 RVA: 0x00517EA2 File Offset: 0x005160A2
		// (set) Token: 0x06024E60 RID: 151136 RVA: 0x00517EAA File Offset: 0x005160AA
		public IPlayFlowT WorkingFlow { get; set; }

		// Token: 0x1700A470 RID: 42096
		// (get) Token: 0x06024E61 RID: 151137 RVA: 0x00517EB3 File Offset: 0x005160B3
		// (set) Token: 0x06024E62 RID: 151138 RVA: 0x00517EBB File Offset: 0x005160BB
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700A471 RID: 42097
		// (get) Token: 0x06024E63 RID: 151139 RVA: 0x00517EC4 File Offset: 0x005160C4
		// (set) Token: 0x06024E64 RID: 151140 RVA: 0x00517ECC File Offset: 0x005160CC
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06024E65 RID: 151141 RVA: 0x00517ED8 File Offset: 0x005160D8
		public INpcUiInteractOnShopNewT()
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
