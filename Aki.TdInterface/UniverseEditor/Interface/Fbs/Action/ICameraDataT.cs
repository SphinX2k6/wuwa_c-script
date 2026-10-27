using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006276 RID: 25206
	public class ICameraDataT
	{
		// Token: 0x1700BBD8 RID: 48088
		// (get) Token: 0x0602B81D RID: 178205 RVA: 0x005FD92B File Offset: 0x005FBB2B
		// (set) Token: 0x0602B81E RID: 178206 RVA: 0x005FD933 File Offset: 0x005FBB33
		public IFlowTemplateModeT Camera { get; set; }

		// Token: 0x1700BBD9 RID: 48089
		// (get) Token: 0x0602B81F RID: 178207 RVA: 0x005FD93C File Offset: 0x005FBB3C
		// (set) Token: 0x0602B820 RID: 178208 RVA: 0x005FD944 File Offset: 0x005FBB44
		public ISetCameraAnimT CameraAnim { get; set; }

		// Token: 0x0602B821 RID: 178209 RVA: 0x005FD94D File Offset: 0x005FBB4D
		public ICameraDataT()
		{
			this.Camera = null;
			this.CameraAnim = null;
		}
	}
}
