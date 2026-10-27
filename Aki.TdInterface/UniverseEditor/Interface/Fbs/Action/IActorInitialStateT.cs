using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060CF RID: 24783
	public class IActorInitialStateT
	{
		// Token: 0x1700B69D RID: 46749
		// (get) Token: 0x0602A525 RID: 173349 RVA: 0x005D5506 File Offset: 0x005D3706
		// (set) Token: 0x0602A526 RID: 173350 RVA: 0x005D550E File Offset: 0x005D370E
		public IActorInitialMontageT InitialMontage { get; set; }

		// Token: 0x1700B69E RID: 46750
		// (get) Token: 0x0602A527 RID: 173351 RVA: 0x005D5517 File Offset: 0x005D3717
		// (set) Token: 0x0602A528 RID: 173352 RVA: 0x005D551F File Offset: 0x005D371F
		public IActorLookAtData_UnionUnion InitialLookAt { get; set; }

		// Token: 0x1700B69F RID: 46751
		// (get) Token: 0x0602A529 RID: 173353 RVA: 0x005D5528 File Offset: 0x005D3728
		// (set) Token: 0x0602A52A RID: 173354 RVA: 0x005D5530 File Offset: 0x005D3730
		public IActorInitialEffectT InitialEffects { get; set; }

		// Token: 0x1700B6A0 RID: 46752
		// (get) Token: 0x0602A52B RID: 173355 RVA: 0x005D5539 File Offset: 0x005D3739
		// (set) Token: 0x0602A52C RID: 173356 RVA: 0x005D5541 File Offset: 0x005D3741
		public int InitialFaceExpressionId { get; set; }

		// Token: 0x1700B6A1 RID: 46753
		// (get) Token: 0x0602A52D RID: 173357 RVA: 0x005D554A File Offset: 0x005D374A
		// (set) Token: 0x0602A52E RID: 173358 RVA: 0x005D5552 File Offset: 0x005D3752
		public byte NullMask { get; set; }

		// Token: 0x0602A52F RID: 173359 RVA: 0x005D555B File Offset: 0x005D375B
		public IActorInitialStateT()
		{
			this.InitialMontage = null;
			this.InitialLookAt = null;
			this.InitialEffects = null;
			this.InitialFaceExpressionId = 0;
			this.NullMask = 0;
		}
	}
}
