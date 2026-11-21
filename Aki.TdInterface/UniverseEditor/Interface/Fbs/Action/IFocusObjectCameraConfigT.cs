using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC1 RID: 28353
	public class IFocusObjectCameraConfigT
	{
		// Token: 0x1700CFFF RID: 53247
		// (get) Token: 0x060310ED RID: 200941 RVA: 0x006A7279 File Offset: 0x006A5479
		// (set) Token: 0x060310EE RID: 200942 RVA: 0x006A7281 File Offset: 0x006A5481
		public ICameraParamsT CameraConfig { get; set; }

		// Token: 0x1700D000 RID: 53248
		// (get) Token: 0x060310EF RID: 200943 RVA: 0x006A728A File Offset: 0x006A548A
		// (set) Token: 0x060310F0 RID: 200944 RVA: 0x006A7292 File Offset: 0x006A5492
		public float BlendInTime { get; set; }

		// Token: 0x1700D001 RID: 53249
		// (get) Token: 0x060310F1 RID: 200945 RVA: 0x006A729B File Offset: 0x006A549B
		// (set) Token: 0x060310F2 RID: 200946 RVA: 0x006A72A3 File Offset: 0x006A54A3
		public byte NullMask { get; set; }

		// Token: 0x060310F3 RID: 200947 RVA: 0x006A72AC File Offset: 0x006A54AC
		public IFocusObjectCameraConfigT()
		{
			this.CameraConfig = null;
			this.BlendInTime = 0f;
			this.NullMask = 0;
		}
	}
}
