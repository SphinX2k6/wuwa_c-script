using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200516D RID: 20845
	public class IPhotographCameraCheckBlurIntensityT
	{
		// Token: 0x17009557 RID: 38231
		// (get) Token: 0x06020CBF RID: 134335 RVA: 0x0048A7B2 File Offset: 0x004889B2
		// (set) Token: 0x06020CC0 RID: 134336 RVA: 0x0048A7BA File Offset: 0x004889BA
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x17009558 RID: 38232
		// (get) Token: 0x06020CC1 RID: 134337 RVA: 0x0048A7C3 File Offset: 0x004889C3
		// (set) Token: 0x06020CC2 RID: 134338 RVA: 0x0048A7CB File Offset: 0x004889CB
		public int MinBlurIntensity { get; set; }

		// Token: 0x17009559 RID: 38233
		// (get) Token: 0x06020CC3 RID: 134339 RVA: 0x0048A7D4 File Offset: 0x004889D4
		// (set) Token: 0x06020CC4 RID: 134340 RVA: 0x0048A7DC File Offset: 0x004889DC
		public int MaxBlurIntensity { get; set; }

		// Token: 0x06020CC5 RID: 134341 RVA: 0x0048A7E5 File Offset: 0x004889E5
		public IPhotographCameraCheckBlurIntensityT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
			this.MinBlurIntensity = 0;
			this.MaxBlurIntensity = 0;
		}
	}
}
