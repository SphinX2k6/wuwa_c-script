using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2B RID: 23595
	public class INpcUiInteractOnVillageInfrT
	{
		// Token: 0x1700AD4E RID: 44366
		// (get) Token: 0x06027198 RID: 160152 RVA: 0x0055B96A File Offset: 0x00559B6A
		// (set) Token: 0x06027199 RID: 160153 RVA: 0x0055B972 File Offset: 0x00559B72
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700AD4F RID: 44367
		// (get) Token: 0x0602719A RID: 160154 RVA: 0x0055B97B File Offset: 0x00559B7B
		// (set) Token: 0x0602719B RID: 160155 RVA: 0x0055B983 File Offset: 0x00559B83
		public TMontageConfigUnion EnterMontage { get; set; }

		// Token: 0x1700AD50 RID: 44368
		// (get) Token: 0x0602719C RID: 160156 RVA: 0x0055B98C File Offset: 0x00559B8C
		// (set) Token: 0x0602719D RID: 160157 RVA: 0x0055B994 File Offset: 0x00559B94
		public TMontageConfigUnion DeliverSuccessMontage { get; set; }

		// Token: 0x1700AD51 RID: 44369
		// (get) Token: 0x0602719E RID: 160158 RVA: 0x0055B99D File Offset: 0x00559B9D
		// (set) Token: 0x0602719F RID: 160159 RVA: 0x0055B9A5 File Offset: 0x00559BA5
		public TMontageConfigUnion CompleteMontage { get; set; }

		// Token: 0x1700AD52 RID: 44370
		// (get) Token: 0x060271A0 RID: 160160 RVA: 0x0055B9AE File Offset: 0x00559BAE
		// (set) Token: 0x060271A1 RID: 160161 RVA: 0x0055B9B6 File Offset: 0x00559BB6
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700AD53 RID: 44371
		// (get) Token: 0x060271A2 RID: 160162 RVA: 0x0055B9BF File Offset: 0x00559BBF
		// (set) Token: 0x060271A3 RID: 160163 RVA: 0x0055B9C7 File Offset: 0x00559BC7
		public IPlayFlowT DeliverSuccessFlow { get; set; }

		// Token: 0x1700AD54 RID: 44372
		// (get) Token: 0x060271A4 RID: 160164 RVA: 0x0055B9D0 File Offset: 0x00559BD0
		// (set) Token: 0x060271A5 RID: 160165 RVA: 0x0055B9D8 File Offset: 0x00559BD8
		public IPlayFlowT CompleteFlow { get; set; }

		// Token: 0x060271A6 RID: 160166 RVA: 0x0055B9E1 File Offset: 0x00559BE1
		public INpcUiInteractOnVillageInfrT()
		{
			this.Type = ENpcUiInteractType.HandInItem;
			this.EnterMontage = null;
			this.DeliverSuccessMontage = null;
			this.CompleteMontage = null;
			this.EnterFlow = null;
			this.DeliverSuccessFlow = null;
			this.CompleteFlow = null;
		}
	}
}
