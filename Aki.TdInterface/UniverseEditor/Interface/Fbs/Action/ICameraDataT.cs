using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068E7 RID: 26855
	public class ICameraDataT
	{
		// Token: 0x1700C560 RID: 50528
		// (get) Token: 0x0602DF7E RID: 188286 RVA: 0x00648733 File Offset: 0x00646933
		// (set) Token: 0x0602DF7F RID: 188287 RVA: 0x0064873B File Offset: 0x0064693B
		public IFlowTemplateModeT Camera { get; set; }

		// Token: 0x1700C561 RID: 50529
		// (get) Token: 0x0602DF80 RID: 188288 RVA: 0x00648744 File Offset: 0x00646944
		// (set) Token: 0x0602DF81 RID: 188289 RVA: 0x0064874C File Offset: 0x0064694C
		public ISetCameraAnimT CameraAnim { get; set; }

		// Token: 0x0602DF82 RID: 188290 RVA: 0x00648755 File Offset: 0x00646955
		public ICameraDataT()
		{
			this.Camera = null;
			this.CameraAnim = null;
		}
	}
}
