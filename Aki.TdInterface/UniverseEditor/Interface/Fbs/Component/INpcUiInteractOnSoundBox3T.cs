using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005681 RID: 22145
	public class INpcUiInteractOnSoundBox3T
	{
		// Token: 0x1700A47E RID: 42110
		// (get) Token: 0x06024E95 RID: 151189 RVA: 0x00518A90 File Offset: 0x00516C90
		// (set) Token: 0x06024E96 RID: 151190 RVA: 0x00518A98 File Offset: 0x00516C98
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A47F RID: 42111
		// (get) Token: 0x06024E97 RID: 151191 RVA: 0x00518AA1 File Offset: 0x00516CA1
		// (set) Token: 0x06024E98 RID: 151192 RVA: 0x00518AA9 File Offset: 0x00516CA9
		public string EnterMontage { get; set; }

		// Token: 0x1700A480 RID: 42112
		// (get) Token: 0x06024E99 RID: 151193 RVA: 0x00518AB2 File Offset: 0x00516CB2
		// (set) Token: 0x06024E9A RID: 151194 RVA: 0x00518ABA File Offset: 0x00516CBA
		public string StandByMontage { get; set; }

		// Token: 0x1700A481 RID: 42113
		// (get) Token: 0x06024E9B RID: 151195 RVA: 0x00518AC3 File Offset: 0x00516CC3
		// (set) Token: 0x06024E9C RID: 151196 RVA: 0x00518ACB File Offset: 0x00516CCB
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700A482 RID: 42114
		// (get) Token: 0x06024E9D RID: 151197 RVA: 0x00518AD4 File Offset: 0x00516CD4
		// (set) Token: 0x06024E9E RID: 151198 RVA: 0x00518ADC File Offset: 0x00516CDC
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A483 RID: 42115
		// (get) Token: 0x06024E9F RID: 151199 RVA: 0x00518AE5 File Offset: 0x00516CE5
		// (set) Token: 0x06024EA0 RID: 151200 RVA: 0x00518AED File Offset: 0x00516CED
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700A484 RID: 42116
		// (get) Token: 0x06024EA1 RID: 151201 RVA: 0x00518AF6 File Offset: 0x00516CF6
		// (set) Token: 0x06024EA2 RID: 151202 RVA: 0x00518AFE File Offset: 0x00516CFE
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700A485 RID: 42117
		// (get) Token: 0x06024EA3 RID: 151203 RVA: 0x00518B07 File Offset: 0x00516D07
		// (set) Token: 0x06024EA4 RID: 151204 RVA: 0x00518B0F File Offset: 0x00516D0F
		public string UpgradeSequence { get; set; }

		// Token: 0x1700A486 RID: 42118
		// (get) Token: 0x06024EA5 RID: 151205 RVA: 0x00518B18 File Offset: 0x00516D18
		// (set) Token: 0x06024EA6 RID: 151206 RVA: 0x00518B20 File Offset: 0x00516D20
		public IPlayFlowT UpgradeFlow { get; set; }

		// Token: 0x1700A487 RID: 42119
		// (get) Token: 0x06024EA7 RID: 151207 RVA: 0x00518B29 File Offset: 0x00516D29
		// (set) Token: 0x06024EA8 RID: 151208 RVA: 0x00518B31 File Offset: 0x00516D31
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700A488 RID: 42120
		// (get) Token: 0x06024EA9 RID: 151209 RVA: 0x00518B3A File Offset: 0x00516D3A
		// (set) Token: 0x06024EAA RID: 151210 RVA: 0x00518B42 File Offset: 0x00516D42
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x06024EAB RID: 151211 RVA: 0x00518B4C File Offset: 0x00516D4C
		public INpcUiInteractOnSoundBox3T()
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
