using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568A RID: 22154
	public class INpcUiInteractOnVillageInfrT
	{
		// Token: 0x1700A4BF RID: 42175
		// (get) Token: 0x06024F5F RID: 151391 RVA: 0x0051ADCE File Offset: 0x00518FCE
		// (set) Token: 0x06024F60 RID: 151392 RVA: 0x0051ADD6 File Offset: 0x00518FD6
		public ENpcUiInteractType Type { get; set; }

		// Token: 0x1700A4C0 RID: 42176
		// (get) Token: 0x06024F61 RID: 151393 RVA: 0x0051ADDF File Offset: 0x00518FDF
		// (set) Token: 0x06024F62 RID: 151394 RVA: 0x0051ADE7 File Offset: 0x00518FE7
		public TMontageConfigUnion EnterMontage { get; set; }

		// Token: 0x1700A4C1 RID: 42177
		// (get) Token: 0x06024F63 RID: 151395 RVA: 0x0051ADF0 File Offset: 0x00518FF0
		// (set) Token: 0x06024F64 RID: 151396 RVA: 0x0051ADF8 File Offset: 0x00518FF8
		public TMontageConfigUnion DeliverSuccessMontage { get; set; }

		// Token: 0x1700A4C2 RID: 42178
		// (get) Token: 0x06024F65 RID: 151397 RVA: 0x0051AE01 File Offset: 0x00519001
		// (set) Token: 0x06024F66 RID: 151398 RVA: 0x0051AE09 File Offset: 0x00519009
		public TMontageConfigUnion CompleteMontage { get; set; }

		// Token: 0x1700A4C3 RID: 42179
		// (get) Token: 0x06024F67 RID: 151399 RVA: 0x0051AE12 File Offset: 0x00519012
		// (set) Token: 0x06024F68 RID: 151400 RVA: 0x0051AE1A File Offset: 0x0051901A
		public IPlayFlowT EnterFlow { get; set; }

		// Token: 0x1700A4C4 RID: 42180
		// (get) Token: 0x06024F69 RID: 151401 RVA: 0x0051AE23 File Offset: 0x00519023
		// (set) Token: 0x06024F6A RID: 151402 RVA: 0x0051AE2B File Offset: 0x0051902B
		public IPlayFlowT DeliverSuccessFlow { get; set; }

		// Token: 0x1700A4C5 RID: 42181
		// (get) Token: 0x06024F6B RID: 151403 RVA: 0x0051AE34 File Offset: 0x00519034
		// (set) Token: 0x06024F6C RID: 151404 RVA: 0x0051AE3C File Offset: 0x0051903C
		public IPlayFlowT CompleteFlow { get; set; }

		// Token: 0x06024F6D RID: 151405 RVA: 0x0051AE45 File Offset: 0x00519045
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
