using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E93 RID: 16019
	public class IFishSplinePatrolStateT
	{
		// Token: 0x17006C53 RID: 27731
		// (get) Token: 0x06015A24 RID: 88612 RVA: 0x0031E0D0 File Offset: 0x0031C2D0
		// (set) Token: 0x06015A25 RID: 88613 RVA: 0x0031E0D8 File Offset: 0x0031C2D8
		public EFishState Type { get; set; }

		// Token: 0x17006C54 RID: 27732
		// (get) Token: 0x06015A26 RID: 88614 RVA: 0x0031E0E1 File Offset: 0x0031C2E1
		// (set) Token: 0x06015A27 RID: 88615 RVA: 0x0031E0E9 File Offset: 0x0031C2E9
		public int SplineId { get; set; }

		// Token: 0x17006C55 RID: 27733
		// (get) Token: 0x06015A28 RID: 88616 RVA: 0x0031E0F2 File Offset: 0x0031C2F2
		// (set) Token: 0x06015A29 RID: 88617 RVA: 0x0031E0FA File Offset: 0x0031C2FA
		public float NiagaraOrbitSpeed { get; set; }

		// Token: 0x17006C56 RID: 27734
		// (get) Token: 0x06015A2A RID: 88618 RVA: 0x0031E103 File Offset: 0x0031C303
		// (set) Token: 0x06015A2B RID: 88619 RVA: 0x0031E10B File Offset: 0x0031C30B
		public bool NiagaraOrbitDirection { get; set; }

		// Token: 0x17006C57 RID: 27735
		// (get) Token: 0x06015A2C RID: 88620 RVA: 0x0031E114 File Offset: 0x0031C314
		// (set) Token: 0x06015A2D RID: 88621 RVA: 0x0031E11C File Offset: 0x0031C31C
		public float NiagaraOrbitTrackWidth { get; set; }

		// Token: 0x17006C58 RID: 27736
		// (get) Token: 0x06015A2E RID: 88622 RVA: 0x0031E125 File Offset: 0x0031C325
		// (set) Token: 0x06015A2F RID: 88623 RVA: 0x0031E12D File Offset: 0x0031C32D
		public float NiagaraOrbitTrackHeight { get; set; }

		// Token: 0x17006C59 RID: 27737
		// (get) Token: 0x06015A30 RID: 88624 RVA: 0x0031E136 File Offset: 0x0031C336
		// (set) Token: 0x06015A31 RID: 88625 RVA: 0x0031E13E File Offset: 0x0031C33E
		public float NiagaraOrbitCaptureStrength { get; set; }

		// Token: 0x17006C5A RID: 27738
		// (get) Token: 0x06015A32 RID: 88626 RVA: 0x0031E147 File Offset: 0x0031C347
		// (set) Token: 0x06015A33 RID: 88627 RVA: 0x0031E14F File Offset: 0x0031C34F
		public byte NullMask { get; set; }

		// Token: 0x06015A34 RID: 88628 RVA: 0x0031E158 File Offset: 0x0031C358
		public IFishSplinePatrolStateT()
		{
			this.Type = EFishState.Idle;
			this.SplineId = 0;
			this.NiagaraOrbitSpeed = 0f;
			this.NiagaraOrbitDirection = false;
			this.NiagaraOrbitTrackWidth = 0f;
			this.NiagaraOrbitTrackHeight = 0f;
			this.NiagaraOrbitCaptureStrength = 0f;
			this.NullMask = 0;
		}
	}
}
