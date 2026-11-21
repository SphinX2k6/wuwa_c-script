using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C16 RID: 23574
	public class INpcUiInteractOnGramophoneT
	{
		// Token: 0x1700ACC2 RID: 44226
		// (get) Token: 0x06026FDC RID: 159708 RVA: 0x00556AFF File Offset: 0x00554CFF
		// (set) Token: 0x06026FDD RID: 159709 RVA: 0x00556B07 File Offset: 0x00554D07
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700ACC3 RID: 44227
		// (get) Token: 0x06026FDE RID: 159710 RVA: 0x00556B10 File Offset: 0x00554D10
		// (set) Token: 0x06026FDF RID: 159711 RVA: 0x00556B18 File Offset: 0x00554D18
		public string EnterMontage { get; set; }

		// Token: 0x1700ACC4 RID: 44228
		// (get) Token: 0x06026FE0 RID: 159712 RVA: 0x00556B21 File Offset: 0x00554D21
		// (set) Token: 0x06026FE1 RID: 159713 RVA: 0x00556B29 File Offset: 0x00554D29
		public string StandByMontage { get; set; }

		// Token: 0x1700ACC5 RID: 44229
		// (get) Token: 0x06026FE2 RID: 159714 RVA: 0x00556B32 File Offset: 0x00554D32
		// (set) Token: 0x06026FE3 RID: 159715 RVA: 0x00556B3A File Offset: 0x00554D3A
		public string SwitchMusicMontage { get; set; }

		// Token: 0x1700ACC6 RID: 44230
		// (get) Token: 0x06026FE4 RID: 159716 RVA: 0x00556B43 File Offset: 0x00554D43
		// (set) Token: 0x06026FE5 RID: 159717 RVA: 0x00556B4B File Offset: 0x00554D4B
		public string ExitMontage { get; set; }

		// Token: 0x1700ACC7 RID: 44231
		// (get) Token: 0x06026FE6 RID: 159718 RVA: 0x00556B54 File Offset: 0x00554D54
		// (set) Token: 0x06026FE7 RID: 159719 RVA: 0x00556B5C File Offset: 0x00554D5C
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700ACC8 RID: 44232
		// (get) Token: 0x06026FE8 RID: 159720 RVA: 0x00556B65 File Offset: 0x00554D65
		// (set) Token: 0x06026FE9 RID: 159721 RVA: 0x00556B6D File Offset: 0x00554D6D
		public IPlayFlowT FailedFlow { get; set; }

		// Token: 0x1700ACC9 RID: 44233
		// (get) Token: 0x06026FEA RID: 159722 RVA: 0x00556B76 File Offset: 0x00554D76
		// (set) Token: 0x06026FEB RID: 159723 RVA: 0x00556B7E File Offset: 0x00554D7E
		public IPlayFlowT SuccessFlow { get; set; }

		// Token: 0x06026FEC RID: 159724 RVA: 0x00556B87 File Offset: 0x00554D87
		public INpcUiInteractOnGramophoneT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.StandByMontage = null;
			this.SwitchMusicMontage = null;
			this.ExitMontage = null;
			this.EnterFlow = null;
			this.FailedFlow = null;
			this.SuccessFlow = null;
		}
	}
}
