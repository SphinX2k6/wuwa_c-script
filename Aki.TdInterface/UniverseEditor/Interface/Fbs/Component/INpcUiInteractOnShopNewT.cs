using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1F RID: 23583
	public class INpcUiInteractOnShopNewT
	{
		// Token: 0x1700ACF7 RID: 44279
		// (get) Token: 0x0602708A RID: 159882 RVA: 0x005589C7 File Offset: 0x00556BC7
		// (set) Token: 0x0602708B RID: 159883 RVA: 0x005589CF File Offset: 0x00556BCF
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700ACF8 RID: 44280
		// (get) Token: 0x0602708C RID: 159884 RVA: 0x005589D8 File Offset: 0x00556BD8
		// (set) Token: 0x0602708D RID: 159885 RVA: 0x005589E0 File Offset: 0x00556BE0
		public TMontageConfigUnion EnterMontage { get; set; }

		// Token: 0x1700ACF9 RID: 44281
		// (get) Token: 0x0602708E RID: 159886 RVA: 0x005589E9 File Offset: 0x00556BE9
		// (set) Token: 0x0602708F RID: 159887 RVA: 0x005589F1 File Offset: 0x00556BF1
		public TMontageConfigUnion StandByMontage { get; set; }

		// Token: 0x1700ACFA RID: 44282
		// (get) Token: 0x06027090 RID: 159888 RVA: 0x005589FA File Offset: 0x00556BFA
		// (set) Token: 0x06027091 RID: 159889 RVA: 0x00558A02 File Offset: 0x00556C02
		public TMontageConfigUnion ShopSuccessMontage { get; set; }

		// Token: 0x1700ACFB RID: 44283
		// (get) Token: 0x06027092 RID: 159890 RVA: 0x00558A0B File Offset: 0x00556C0B
		// (set) Token: 0x06027093 RID: 159891 RVA: 0x00558A13 File Offset: 0x00556C13
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700ACFC RID: 44284
		// (get) Token: 0x06027094 RID: 159892 RVA: 0x00558A1C File Offset: 0x00556C1C
		// (set) Token: 0x06027095 RID: 159893 RVA: 0x00558A24 File Offset: 0x00556C24
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700ACFD RID: 44285
		// (get) Token: 0x06027096 RID: 159894 RVA: 0x00558A2D File Offset: 0x00556C2D
		// (set) Token: 0x06027097 RID: 159895 RVA: 0x00558A35 File Offset: 0x00556C35
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700ACFE RID: 44286
		// (get) Token: 0x06027098 RID: 159896 RVA: 0x00558A3E File Offset: 0x00556C3E
		// (set) Token: 0x06027099 RID: 159897 RVA: 0x00558A46 File Offset: 0x00556C46
		public IPlayFlowT WorkingFlow { get; set; }

		// Token: 0x1700ACFF RID: 44287
		// (get) Token: 0x0602709A RID: 159898 RVA: 0x00558A4F File Offset: 0x00556C4F
		// (set) Token: 0x0602709B RID: 159899 RVA: 0x00558A57 File Offset: 0x00556C57
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700AD00 RID: 44288
		// (get) Token: 0x0602709C RID: 159900 RVA: 0x00558A60 File Offset: 0x00556C60
		// (set) Token: 0x0602709D RID: 159901 RVA: 0x00558A68 File Offset: 0x00556C68
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x0602709E RID: 159902 RVA: 0x00558A74 File Offset: 0x00556C74
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
