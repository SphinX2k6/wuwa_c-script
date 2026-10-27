using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB5 RID: 27829
	public class IPhotographCameraParamsT
	{
		// Token: 0x1700CF30 RID: 53040
		// (get) Token: 0x060310B1 RID: 200881 RVA: 0x006A8065 File Offset: 0x006A6265
		// (set) Token: 0x060310B2 RID: 200882 RVA: 0x006A806D File Offset: 0x006A626D
		public IPhotographCameraTransformAbsoluteT CameraTransform { get; set; }

		// Token: 0x1700CF31 RID: 53041
		// (get) Token: 0x060310B3 RID: 200883 RVA: 0x006A8076 File Offset: 0x006A6276
		// (set) Token: 0x060310B4 RID: 200884 RVA: 0x006A807E File Offset: 0x006A627E
		public float Fov { get; set; }

		// Token: 0x1700CF32 RID: 53042
		// (get) Token: 0x060310B5 RID: 200885 RVA: 0x006A8087 File Offset: 0x006A6287
		// (set) Token: 0x060310B6 RID: 200886 RVA: 0x006A808F File Offset: 0x006A628F
		public byte NullMask { get; set; }

		// Token: 0x060310B7 RID: 200887 RVA: 0x006A8098 File Offset: 0x006A6298
		public IPhotographCameraParamsT()
		{
			this.CameraTransform = null;
			this.Fov = 0f;
			this.NullMask = 0;
		}
	}
}
