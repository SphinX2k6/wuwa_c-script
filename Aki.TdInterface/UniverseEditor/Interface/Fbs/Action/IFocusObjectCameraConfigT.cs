using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200683B RID: 26683
	public class IFocusObjectCameraConfigT
	{
		// Token: 0x1700C63B RID: 50747
		// (get) Token: 0x0602E865 RID: 190565 RVA: 0x00659339 File Offset: 0x00657539
		// (set) Token: 0x0602E866 RID: 190566 RVA: 0x00659341 File Offset: 0x00657541
		public ICameraParamsT CameraConfig { get; set; }

		// Token: 0x1700C63C RID: 50748
		// (get) Token: 0x0602E867 RID: 190567 RVA: 0x0065934A File Offset: 0x0065754A
		// (set) Token: 0x0602E868 RID: 190568 RVA: 0x00659352 File Offset: 0x00657552
		public float BlendInTime { get; set; }

		// Token: 0x1700C63D RID: 50749
		// (get) Token: 0x0602E869 RID: 190569 RVA: 0x0065935B File Offset: 0x0065755B
		// (set) Token: 0x0602E86A RID: 190570 RVA: 0x00659363 File Offset: 0x00657563
		public byte NullMask { get; set; }

		// Token: 0x0602E86B RID: 190571 RVA: 0x0065936C File Offset: 0x0065756C
		public IFocusObjectCameraConfigT()
		{
			this.CameraConfig = null;
			this.BlendInTime = 0f;
			this.NullMask = 0;
		}
	}
}
