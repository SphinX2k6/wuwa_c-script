using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200516A RID: 20842
	public class IPhotographCameraCheckAspectRatioTypeT
	{
		// Token: 0x17009551 RID: 38225
		// (get) Token: 0x06020CA7 RID: 134311 RVA: 0x0048A554 File Offset: 0x00488754
		// (set) Token: 0x06020CA8 RID: 134312 RVA: 0x0048A55C File Offset: 0x0048875C
		public EPhotographCameraCheckType Type { get; set; }

		// Token: 0x17009552 RID: 38226
		// (get) Token: 0x06020CA9 RID: 134313 RVA: 0x0048A565 File Offset: 0x00488765
		// (set) Token: 0x06020CAA RID: 134314 RVA: 0x0048A56D File Offset: 0x0048876D
		public int AspectRatioTypeId { get; set; }

		// Token: 0x06020CAB RID: 134315 RVA: 0x0048A576 File Offset: 0x00488776
		public IPhotographCameraCheckAspectRatioTypeT()
		{
			this.Type = EPhotographCameraCheckType.CameraTemplate;
			this.AspectRatioTypeId = 0;
		}
	}
}
