using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F5 RID: 21237
	public class IGazePerformanceT
	{
		// Token: 0x17009BE1 RID: 39905
		// (get) Token: 0x06022ACE RID: 142030 RVA: 0x004CE562 File Offset: 0x004CC762
		// (set) Token: 0x06022ACF RID: 142031 RVA: 0x004CE56A File Offset: 0x004CC76A
		public float FadeInTime { get; set; }

		// Token: 0x17009BE2 RID: 39906
		// (get) Token: 0x06022AD0 RID: 142032 RVA: 0x004CE573 File Offset: 0x004CC773
		// (set) Token: 0x06022AD1 RID: 142033 RVA: 0x004CE57B File Offset: 0x004CC77B
		public float StayTime { get; set; }

		// Token: 0x17009BE3 RID: 39907
		// (get) Token: 0x06022AD2 RID: 142034 RVA: 0x004CE584 File Offset: 0x004CC784
		// (set) Token: 0x06022AD3 RID: 142035 RVA: 0x004CE58C File Offset: 0x004CC78C
		public float FadeOutTime { get; set; }

		// Token: 0x17009BE4 RID: 39908
		// (get) Token: 0x06022AD4 RID: 142036 RVA: 0x004CE595 File Offset: 0x004CC795
		// (set) Token: 0x06022AD5 RID: 142037 RVA: 0x004CE59D File Offset: 0x004CC79D
		public bool LockCamera { get; set; }

		// Token: 0x17009BE5 RID: 39909
		// (get) Token: 0x06022AD6 RID: 142038 RVA: 0x004CE5A6 File Offset: 0x004CC7A6
		// (set) Token: 0x06022AD7 RID: 142039 RVA: 0x004CE5AE File Offset: 0x004CC7AE
		public byte NullMask { get; set; }

		// Token: 0x06022AD8 RID: 142040 RVA: 0x004CE5B7 File Offset: 0x004CC7B7
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
