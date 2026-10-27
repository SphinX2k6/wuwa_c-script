using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C28 RID: 27688
	public class IOpenQuickHackSystemT
	{
		// Token: 0x1700CDF1 RID: 52721
		// (get) Token: 0x06030B35 RID: 199477 RVA: 0x0069C6CB File Offset: 0x0069A8CB
		// (set) Token: 0x06030B36 RID: 199478 RVA: 0x0069C6D3 File Offset: 0x0069A8D3
		public int DeviceId { get; set; }

		// Token: 0x1700CDF2 RID: 52722
		// (get) Token: 0x06030B37 RID: 199479 RVA: 0x0069C6DC File Offset: 0x0069A8DC
		// (set) Token: 0x06030B38 RID: 199480 RVA: 0x0069C6E4 File Offset: 0x0069A8E4
		public List<int> Entities { get; set; }

		// Token: 0x1700CDF3 RID: 52723
		// (get) Token: 0x06030B39 RID: 199481 RVA: 0x0069C6ED File Offset: 0x0069A8ED
		// (set) Token: 0x06030B3A RID: 199482 RVA: 0x0069C6F5 File Offset: 0x0069A8F5
		public IOpenQuickHackCameraConfigT CameraConfig { get; set; }

		// Token: 0x1700CDF4 RID: 52724
		// (get) Token: 0x06030B3B RID: 199483 RVA: 0x0069C6FE File Offset: 0x0069A8FE
		// (set) Token: 0x06030B3C RID: 199484 RVA: 0x0069C706 File Offset: 0x0069A906
		public byte NullMask { get; set; }

		// Token: 0x06030B3D RID: 199485 RVA: 0x0069C70F File Offset: 0x0069A90F
		public IOpenQuickHackSystemT()
		{
			this.DeviceId = 0;
			this.Entities = null;
			this.CameraConfig = null;
			this.NullMask = 0;
		}
	}
}
