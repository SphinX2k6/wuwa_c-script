using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742B RID: 29739
	public class IPhotographCameraParamsT
	{
		// Token: 0x1700DA6D RID: 55917
		// (get) Token: 0x06034088 RID: 213128 RVA: 0x00703299 File Offset: 0x00701499
		// (set) Token: 0x06034089 RID: 213129 RVA: 0x007032A1 File Offset: 0x007014A1
		public IPhotographCameraTransformAbsoluteT CameraTransform { get; set; }

		// Token: 0x1700DA6E RID: 55918
		// (get) Token: 0x0603408A RID: 213130 RVA: 0x007032AA File Offset: 0x007014AA
		// (set) Token: 0x0603408B RID: 213131 RVA: 0x007032B2 File Offset: 0x007014B2
		public float Fov { get; set; }

		// Token: 0x1700DA6F RID: 55919
		// (get) Token: 0x0603408C RID: 213132 RVA: 0x007032BB File Offset: 0x007014BB
		// (set) Token: 0x0603408D RID: 213133 RVA: 0x007032C3 File Offset: 0x007014C3
		public byte NullMask { get; set; }

		// Token: 0x0603408E RID: 213134 RVA: 0x007032CC File Offset: 0x007014CC
		public IPhotographCameraParamsT()
		{
			this.CameraTransform = null;
			this.Fov = 0f;
			this.NullMask = 0;
		}
	}
}
