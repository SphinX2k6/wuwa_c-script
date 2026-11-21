using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C25 RID: 23589
	public class INpcUiInteractOnSoundBox35T
	{
		// Token: 0x1700AD24 RID: 44324
		// (get) Token: 0x06027114 RID: 160020 RVA: 0x0055A224 File Offset: 0x00558424
		// (set) Token: 0x06027115 RID: 160021 RVA: 0x0055A22C File Offset: 0x0055842C
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700AD25 RID: 44325
		// (get) Token: 0x06027116 RID: 160022 RVA: 0x0055A235 File Offset: 0x00558435
		// (set) Token: 0x06027117 RID: 160023 RVA: 0x0055A23D File Offset: 0x0055843D
		public string EnterMontage { get; set; }

		// Token: 0x1700AD26 RID: 44326
		// (get) Token: 0x06027118 RID: 160024 RVA: 0x0055A246 File Offset: 0x00558446
		// (set) Token: 0x06027119 RID: 160025 RVA: 0x0055A24E File Offset: 0x0055844E
		public string StandByMontage { get; set; }

		// Token: 0x1700AD27 RID: 44327
		// (get) Token: 0x0602711A RID: 160026 RVA: 0x0055A257 File Offset: 0x00558457
		// (set) Token: 0x0602711B RID: 160027 RVA: 0x0055A25F File Offset: 0x0055845F
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700AD28 RID: 44328
		// (get) Token: 0x0602711C RID: 160028 RVA: 0x0055A268 File Offset: 0x00558468
		// (set) Token: 0x0602711D RID: 160029 RVA: 0x0055A270 File Offset: 0x00558470
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700AD29 RID: 44329
		// (get) Token: 0x0602711E RID: 160030 RVA: 0x0055A279 File Offset: 0x00558479
		// (set) Token: 0x0602711F RID: 160031 RVA: 0x0055A281 File Offset: 0x00558481
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700AD2A RID: 44330
		// (get) Token: 0x06027120 RID: 160032 RVA: 0x0055A28A File Offset: 0x0055848A
		// (set) Token: 0x06027121 RID: 160033 RVA: 0x0055A292 File Offset: 0x00558492
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700AD2B RID: 44331
		// (get) Token: 0x06027122 RID: 160034 RVA: 0x0055A29B File Offset: 0x0055849B
		// (set) Token: 0x06027123 RID: 160035 RVA: 0x0055A2A3 File Offset: 0x005584A3
		public string UpgradeSequence { get; set; }

		// Token: 0x1700AD2C RID: 44332
		// (get) Token: 0x06027124 RID: 160036 RVA: 0x0055A2AC File Offset: 0x005584AC
		// (set) Token: 0x06027125 RID: 160037 RVA: 0x0055A2B4 File Offset: 0x005584B4
		public IPlayFlowT UpgradeFlow { get; set; }

		// Token: 0x1700AD2D RID: 44333
		// (get) Token: 0x06027126 RID: 160038 RVA: 0x0055A2BD File Offset: 0x005584BD
		// (set) Token: 0x06027127 RID: 160039 RVA: 0x0055A2C5 File Offset: 0x005584C5
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700AD2E RID: 44334
		// (get) Token: 0x06027128 RID: 160040 RVA: 0x0055A2CE File Offset: 0x005584CE
		// (set) Token: 0x06027129 RID: 160041 RVA: 0x0055A2D6 File Offset: 0x005584D6
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x0602712A RID: 160042 RVA: 0x0055A2E0 File Offset: 0x005584E0
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
