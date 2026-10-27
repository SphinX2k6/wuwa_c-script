using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C74 RID: 19572
	public class IPhotographCameraCheckBlurIntensityT
	{
		// Token: 0x17008E29 RID: 36393
		// (get) Token: 0x0601F09D RID: 127133 RVA: 0x00456C62 File Offset: 0x00454E62
		// (set) Token: 0x0601F09E RID: 127134 RVA: 0x00456C6A File Offset: 0x00454E6A
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x17008E2A RID: 36394
		// (get) Token: 0x0601F09F RID: 127135 RVA: 0x00456C73 File Offset: 0x00454E73
		// (set) Token: 0x0601F0A0 RID: 127136 RVA: 0x00456C7B File Offset: 0x00454E7B
		public int MinBlurIntensity { get; set; }

		// Token: 0x17008E2B RID: 36395
		// (get) Token: 0x0601F0A1 RID: 127137 RVA: 0x00456C84 File Offset: 0x00454E84
		// (set) Token: 0x0601F0A2 RID: 127138 RVA: 0x00456C8C File Offset: 0x00454E8C
		public int MaxBlurIntensity { get; set; }

		// Token: 0x0601F0A3 RID: 127139 RVA: 0x00456C95 File Offset: 0x00454E95
		public IPhotographCameraCheckBlurIntensityT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
			this.MinBlurIntensity = 0;
			this.MaxBlurIntensity = 0;
		}
	}
}
