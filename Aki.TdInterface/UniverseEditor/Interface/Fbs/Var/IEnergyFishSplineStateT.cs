using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E78 RID: 15992
	public class IEnergyFishSplineStateT
	{
		// Token: 0x17006C0B RID: 27659
		// (get) Token: 0x0601591A RID: 88346 RVA: 0x0031C054 File Offset: 0x0031A254
		// (set) Token: 0x0601591B RID: 88347 RVA: 0x0031C05C File Offset: 0x0031A25C
		public EEnergyFishState Type { get; set; }

		// Token: 0x17006C0C RID: 27660
		// (get) Token: 0x0601591C RID: 88348 RVA: 0x0031C065 File Offset: 0x0031A265
		// (set) Token: 0x0601591D RID: 88349 RVA: 0x0031C06D File Offset: 0x0031A26D
		public int SplineId { get; set; }

		// Token: 0x17006C0D RID: 27661
		// (get) Token: 0x0601591E RID: 88350 RVA: 0x0031C076 File Offset: 0x0031A276
		// (set) Token: 0x0601591F RID: 88351 RVA: 0x0031C07E File Offset: 0x0031A27E
		public float NiagaraOrbitSpeed { get; set; }

		// Token: 0x17006C0E RID: 27662
		// (get) Token: 0x06015920 RID: 88352 RVA: 0x0031C087 File Offset: 0x0031A287
		// (set) Token: 0x06015921 RID: 88353 RVA: 0x0031C08F File Offset: 0x0031A28F
		public bool NiagaraOrbitDirection { get; set; }

		// Token: 0x17006C0F RID: 27663
		// (get) Token: 0x06015922 RID: 88354 RVA: 0x0031C098 File Offset: 0x0031A298
		// (set) Token: 0x06015923 RID: 88355 RVA: 0x0031C0A0 File Offset: 0x0031A2A0
		public float NiagaraOrbitTrackWidth { get; set; }

		// Token: 0x17006C10 RID: 27664
		// (get) Token: 0x06015924 RID: 88356 RVA: 0x0031C0A9 File Offset: 0x0031A2A9
		// (set) Token: 0x06015925 RID: 88357 RVA: 0x0031C0B1 File Offset: 0x0031A2B1
		public float NiagaraOrbitTrackHeight { get; set; }

		// Token: 0x17006C11 RID: 27665
		// (get) Token: 0x06015926 RID: 88358 RVA: 0x0031C0BA File Offset: 0x0031A2BA
		// (set) Token: 0x06015927 RID: 88359 RVA: 0x0031C0C2 File Offset: 0x0031A2C2
		public float NiagaraOrbitCaptureStrength { get; set; }

		// Token: 0x17006C12 RID: 27666
		// (get) Token: 0x06015928 RID: 88360 RVA: 0x0031C0CB File Offset: 0x0031A2CB
		// (set) Token: 0x06015929 RID: 88361 RVA: 0x0031C0D3 File Offset: 0x0031A2D3
		public byte NullMask { get; set; }

		// Token: 0x0601592A RID: 88362 RVA: 0x0031C0DC File Offset: 0x0031A2DC
		public IEnergyFishSplineStateT()
		{
			this.Type = EEnergyFishState.Spline;
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
