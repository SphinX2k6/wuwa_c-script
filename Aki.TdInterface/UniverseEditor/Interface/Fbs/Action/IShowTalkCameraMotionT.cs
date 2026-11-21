using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078BB RID: 30907
	public class IShowTalkCameraMotionT
	{
		// Token: 0x1700E2CB RID: 58059
		// (get) Token: 0x0603668D RID: 222861 RVA: 0x007493F2 File Offset: 0x007475F2
		// (set) Token: 0x0603668E RID: 222862 RVA: 0x007493FA File Offset: 0x007475FA
		public EShowTalkCameraMotionType Type { get; set; }

		// Token: 0x0603668F RID: 222863 RVA: 0x00749403 File Offset: 0x00747603
		public IShowTalkCameraMotionT()
		{
			this.Type = EShowTalkCameraMotionType.Preset;
		}
	}
}
