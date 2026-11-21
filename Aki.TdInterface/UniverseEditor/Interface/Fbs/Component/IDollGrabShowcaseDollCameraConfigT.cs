using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560E RID: 22030
	public class IDollGrabShowcaseDollCameraConfigT
	{
		// Token: 0x17009DFF RID: 40447
		// (get) Token: 0x06023217 RID: 143895 RVA: 0x004D5F8F File Offset: 0x004D418F
		// (set) Token: 0x06023218 RID: 143896 RVA: 0x004D5F97 File Offset: 0x004D4197
		public IShowcaseFullViewCameraConfigT FullViewCamera { get; set; }

		// Token: 0x17009E00 RID: 40448
		// (get) Token: 0x06023219 RID: 143897 RVA: 0x004D5FA0 File Offset: 0x004D41A0
		// (set) Token: 0x0602321A RID: 143898 RVA: 0x004D5FA8 File Offset: 0x004D41A8
		public IDollComboCameraT DollCamera { get; set; }

		// Token: 0x0602321B RID: 143899 RVA: 0x004D5FB1 File Offset: 0x004D41B1
		public IDollGrabShowcaseDollCameraConfigT()
		{
			this.FullViewCamera = null;
			this.DollCamera = null;
		}
	}
}
