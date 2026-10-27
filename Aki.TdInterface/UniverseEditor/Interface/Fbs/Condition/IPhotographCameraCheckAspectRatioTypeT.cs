using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C71 RID: 19569
	public class IPhotographCameraCheckAspectRatioTypeT
	{
		// Token: 0x17008E23 RID: 36387
		// (get) Token: 0x0601F085 RID: 127109 RVA: 0x00456A04 File Offset: 0x00454C04
		// (set) Token: 0x0601F086 RID: 127110 RVA: 0x00456A0C File Offset: 0x00454C0C
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x17008E24 RID: 36388
		// (get) Token: 0x0601F087 RID: 127111 RVA: 0x00456A15 File Offset: 0x00454C15
		// (set) Token: 0x0601F088 RID: 127112 RVA: 0x00456A1D File Offset: 0x00454C1D
		public int AspectRatioTypeId { get; set; }

		// Token: 0x0601F089 RID: 127113 RVA: 0x00456A26 File Offset: 0x00454C26
		public IPhotographCameraCheckAspectRatioTypeT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
			this.AspectRatioTypeId = 0;
		}
	}
}
