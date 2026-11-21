using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005878 RID: 22648
	public class IGazePerformanceT
	{
		// Token: 0x1700A412 RID: 42002
		// (get) Token: 0x06024B68 RID: 150376 RVA: 0x0050B08E File Offset: 0x0050928E
		// (set) Token: 0x06024B69 RID: 150377 RVA: 0x0050B096 File Offset: 0x00509296
		public float FadeInTime { get; set; }

		// Token: 0x1700A413 RID: 42003
		// (get) Token: 0x06024B6A RID: 150378 RVA: 0x0050B09F File Offset: 0x0050929F
		// (set) Token: 0x06024B6B RID: 150379 RVA: 0x0050B0A7 File Offset: 0x005092A7
		public float StayTime { get; set; }

		// Token: 0x1700A414 RID: 42004
		// (get) Token: 0x06024B6C RID: 150380 RVA: 0x0050B0B0 File Offset: 0x005092B0
		// (set) Token: 0x06024B6D RID: 150381 RVA: 0x0050B0B8 File Offset: 0x005092B8
		public float FadeOutTime { get; set; }

		// Token: 0x1700A415 RID: 42005
		// (get) Token: 0x06024B6E RID: 150382 RVA: 0x0050B0C1 File Offset: 0x005092C1
		// (set) Token: 0x06024B6F RID: 150383 RVA: 0x0050B0C9 File Offset: 0x005092C9
		public bool LockCamera { get; set; }

		// Token: 0x1700A416 RID: 42006
		// (get) Token: 0x06024B70 RID: 150384 RVA: 0x0050B0D2 File Offset: 0x005092D2
		// (set) Token: 0x06024B71 RID: 150385 RVA: 0x0050B0DA File Offset: 0x005092DA
		public byte NullMask { get; set; }

		// Token: 0x06024B72 RID: 150386 RVA: 0x0050B0E3 File Offset: 0x005092E3
		public IGazePerformanceT()
		{
			this.FadeInTime = 0f;
			this.StayTime = 0f;
			this.FadeOutTime = 0f;
			this.LockCamera = false;
			this.NullMask = 0;
		}
	}
}
