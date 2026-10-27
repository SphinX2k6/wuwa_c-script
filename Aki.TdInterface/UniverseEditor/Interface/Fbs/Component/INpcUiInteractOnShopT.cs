using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567B RID: 22139
	public class INpcUiInteractOnShopT
	{
		// Token: 0x1700A453 RID: 42067
		// (get) Token: 0x06024E0B RID: 151051 RVA: 0x00516FB0 File Offset: 0x005151B0
		// (set) Token: 0x06024E0C RID: 151052 RVA: 0x00516FB8 File Offset: 0x005151B8
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A454 RID: 42068
		// (get) Token: 0x06024E0D RID: 151053 RVA: 0x00516FC1 File Offset: 0x005151C1
		// (set) Token: 0x06024E0E RID: 151054 RVA: 0x00516FC9 File Offset: 0x005151C9
		public string EnterMontage { get; set; }

		// Token: 0x1700A455 RID: 42069
		// (get) Token: 0x06024E0F RID: 151055 RVA: 0x00516FD2 File Offset: 0x005151D2
		// (set) Token: 0x06024E10 RID: 151056 RVA: 0x00516FDA File Offset: 0x005151DA
		public string StandByMontage { get; set; }

		// Token: 0x1700A456 RID: 42070
		// (get) Token: 0x06024E11 RID: 151057 RVA: 0x00516FE3 File Offset: 0x005151E3
		// (set) Token: 0x06024E12 RID: 151058 RVA: 0x00516FEB File Offset: 0x005151EB
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700A457 RID: 42071
		// (get) Token: 0x06024E13 RID: 151059 RVA: 0x00516FF4 File Offset: 0x005151F4
		// (set) Token: 0x06024E14 RID: 151060 RVA: 0x00516FFC File Offset: 0x005151FC
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A458 RID: 42072
		// (get) Token: 0x06024E15 RID: 151061 RVA: 0x00517005 File Offset: 0x00515205
		// (set) Token: 0x06024E16 RID: 151062 RVA: 0x0051700D File Offset: 0x0051520D
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A459 RID: 42073
		// (get) Token: 0x06024E17 RID: 151063 RVA: 0x00517016 File Offset: 0x00515216
		// (set) Token: 0x06024E18 RID: 151064 RVA: 0x0051701E File Offset: 0x0051521E
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A45A RID: 42074
		// (get) Token: 0x06024E19 RID: 151065 RVA: 0x00517027 File Offset: 0x00515227
		// (set) Token: 0x06024E1A RID: 151066 RVA: 0x0051702F File Offset: 0x0051522F
		public IPlayFlowT WorkingFlow { get; set; }

		// Token: 0x1700A45B RID: 42075
		// (get) Token: 0x06024E1B RID: 151067 RVA: 0x00517038 File Offset: 0x00515238
		// (set) Token: 0x06024E1C RID: 151068 RVA: 0x00517040 File Offset: 0x00515240
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700A45C RID: 42076
		// (get) Token: 0x06024E1D RID: 151069 RVA: 0x00517049 File Offset: 0x00515249
		// (set) Token: 0x06024E1E RID: 151070 RVA: 0x00517051 File Offset: 0x00515251
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06024E1F RID: 151071 RVA: 0x0051705C File Offset: 0x0051525C
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
