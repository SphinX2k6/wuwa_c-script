using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D2F RID: 27951
	public class IEnterMovieModeT
	{
		// Token: 0x1700CD0D RID: 52493
		// (get) Token: 0x06030367 RID: 197479 RVA: 0x0068E1D8 File Offset: 0x0068C3D8
		// (set) Token: 0x06030368 RID: 197480 RVA: 0x0068E1E0 File Offset: 0x0068C3E0
		public IMovieCameraConfigT MovieCameraConfig { get; set; }

		// Token: 0x1700CD0E RID: 52494
		// (get) Token: 0x06030369 RID: 197481 RVA: 0x0068E1E9 File Offset: 0x0068C3E9
		// (set) Token: 0x0603036A RID: 197482 RVA: 0x0068E1F1 File Offset: 0x0068C3F1
		public IEnableFuncConfigT EnableFuncConfig { get; set; }

		// Token: 0x1700CD0F RID: 52495
		// (get) Token: 0x0603036B RID: 197483 RVA: 0x0068E1FA File Offset: 0x0068C3FA
		// (set) Token: 0x0603036C RID: 197484 RVA: 0x0068E202 File Offset: 0x0068C402
		public float BorderAnimDuration { get; set; }

		// Token: 0x1700CD10 RID: 52496
		// (get) Token: 0x0603036D RID: 197485 RVA: 0x0068E20B File Offset: 0x0068C40B
		// (set) Token: 0x0603036E RID: 197486 RVA: 0x0068E213 File Offset: 0x0068C413
		public TEnterMovieModeDurationTypeUnion DurationType { get; set; }

		// Token: 0x1700CD11 RID: 52497
		// (get) Token: 0x0603036F RID: 197487 RVA: 0x0068E21C File Offset: 0x0068C41C
		// (set) Token: 0x06030370 RID: 197488 RVA: 0x0068E224 File Offset: 0x0068C424
		public bool AutoExitInFlow { get; set; }

		// Token: 0x1700CD12 RID: 52498
		// (get) Token: 0x06030371 RID: 197489 RVA: 0x0068E22D File Offset: 0x0068C42D
		// (set) Token: 0x06030372 RID: 197490 RVA: 0x0068E235 File Offset: 0x0068C435
		public byte NullMask { get; set; }

		// Token: 0x06030373 RID: 197491 RVA: 0x0068E23E File Offset: 0x0068C43E
		public IEnterMovieModeT()
		{
			this.MovieCameraConfig = null;
			this.EnableFuncConfig = null;
			this.BorderAnimDuration = 0f;
			this.DurationType = null;
			this.AutoExitInFlow = false;
			this.NullMask = 0;
		}
	}
}
