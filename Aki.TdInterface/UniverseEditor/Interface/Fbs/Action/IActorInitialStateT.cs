using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006731 RID: 26417
	public class IActorInitialStateT
	{
		// Token: 0x1700C008 RID: 49160
		// (get) Token: 0x0602CC06 RID: 183302 RVA: 0x0061F4AE File Offset: 0x0061D6AE
		// (set) Token: 0x0602CC07 RID: 183303 RVA: 0x0061F4B6 File Offset: 0x0061D6B6
		public IActorInitialMontageT InitialMontage { get; set; }

		// Token: 0x1700C009 RID: 49161
		// (get) Token: 0x0602CC08 RID: 183304 RVA: 0x0061F4BF File Offset: 0x0061D6BF
		// (set) Token: 0x0602CC09 RID: 183305 RVA: 0x0061F4C7 File Offset: 0x0061D6C7
		public IActorLookAtData_UnionUnion InitialLookAt { get; set; }

		// Token: 0x1700C00A RID: 49162
		// (get) Token: 0x0602CC0A RID: 183306 RVA: 0x0061F4D0 File Offset: 0x0061D6D0
		// (set) Token: 0x0602CC0B RID: 183307 RVA: 0x0061F4D8 File Offset: 0x0061D6D8
		public IActorInitialEffectT InitialEffects { get; set; }

		// Token: 0x1700C00B RID: 49163
		// (get) Token: 0x0602CC0C RID: 183308 RVA: 0x0061F4E1 File Offset: 0x0061D6E1
		// (set) Token: 0x0602CC0D RID: 183309 RVA: 0x0061F4E9 File Offset: 0x0061D6E9
		public int InitialFaceExpressionId { get; set; }

		// Token: 0x1700C00C RID: 49164
		// (get) Token: 0x0602CC0E RID: 183310 RVA: 0x0061F4F2 File Offset: 0x0061D6F2
		// (set) Token: 0x0602CC0F RID: 183311 RVA: 0x0061F4FA File Offset: 0x0061D6FA
		public byte NullMask { get; set; }

		// Token: 0x0602CC10 RID: 183312 RVA: 0x0061F503 File Offset: 0x0061D703
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
