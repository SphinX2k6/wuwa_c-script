using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C22 RID: 23586
	public class INpcUiInteractOnSoundBox3T
	{
		// Token: 0x1700AD0D RID: 44301
		// (get) Token: 0x060270CE RID: 159950 RVA: 0x0055962C File Offset: 0x0055782C
		// (set) Token: 0x060270CF RID: 159951 RVA: 0x00559634 File Offset: 0x00557834
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700AD0E RID: 44302
		// (get) Token: 0x060270D0 RID: 159952 RVA: 0x0055963D File Offset: 0x0055783D
		// (set) Token: 0x060270D1 RID: 159953 RVA: 0x00559645 File Offset: 0x00557845
		public string EnterMontage { get; set; }

		// Token: 0x1700AD0F RID: 44303
		// (get) Token: 0x060270D2 RID: 159954 RVA: 0x0055964E File Offset: 0x0055784E
		// (set) Token: 0x060270D3 RID: 159955 RVA: 0x00559656 File Offset: 0x00557856
		public string StandByMontage { get; set; }

		// Token: 0x1700AD10 RID: 44304
		// (get) Token: 0x060270D4 RID: 159956 RVA: 0x0055965F File Offset: 0x0055785F
		// (set) Token: 0x060270D5 RID: 159957 RVA: 0x00559667 File Offset: 0x00557867
		public string ShopSuccessMontage { get; set; }

		// Token: 0x1700AD11 RID: 44305
		// (get) Token: 0x060270D6 RID: 159958 RVA: 0x00559670 File Offset: 0x00557870
		// (set) Token: 0x060270D7 RID: 159959 RVA: 0x00559678 File Offset: 0x00557878
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700AD12 RID: 44306
		// (get) Token: 0x060270D8 RID: 159960 RVA: 0x00559681 File Offset: 0x00557881
		// (set) Token: 0x060270D9 RID: 159961 RVA: 0x00559689 File Offset: 0x00557889
		public IPlayFlowT ShopSuccessFlow { get; set; }

		// Token: 0x1700AD13 RID: 44307
		// (get) Token: 0x060270DA RID: 159962 RVA: 0x00559692 File Offset: 0x00557892
		// (set) Token: 0x060270DB RID: 159963 RVA: 0x0055969A File Offset: 0x0055789A
		public IPlayFlowT ShopFailedFlow { get; set; }

		// Token: 0x1700AD14 RID: 44308
		// (get) Token: 0x060270DC RID: 159964 RVA: 0x005596A3 File Offset: 0x005578A3
		// (set) Token: 0x060270DD RID: 159965 RVA: 0x005596AB File Offset: 0x005578AB
		public string UpgradeSequence { get; set; }

		// Token: 0x1700AD15 RID: 44309
		// (get) Token: 0x060270DE RID: 159966 RVA: 0x005596B4 File Offset: 0x005578B4
		// (set) Token: 0x060270DF RID: 159967 RVA: 0x005596BC File Offset: 0x005578BC
		public IPlayFlowT UpgradeFlow { get; set; }

		// Token: 0x1700AD16 RID: 44310
		// (get) Token: 0x060270E0 RID: 159968 RVA: 0x005596C5 File Offset: 0x005578C5
		// (set) Token: 0x060270E1 RID: 159969 RVA: 0x005596CD File Offset: 0x005578CD
		public TMontageConfigUnion ExitMontage { get; set; }

		// Token: 0x1700AD17 RID: 44311
		// (get) Token: 0x060270E2 RID: 159970 RVA: 0x005596D6 File Offset: 0x005578D6
		// (set) Token: 0x060270E3 RID: 159971 RVA: 0x005596DE File Offset: 0x005578DE
		public IPlayFlowT ExitFlow { get; set; }

		// Token: 0x060270E4 RID: 159972 RVA: 0x005596E8 File Offset: 0x005578E8
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
