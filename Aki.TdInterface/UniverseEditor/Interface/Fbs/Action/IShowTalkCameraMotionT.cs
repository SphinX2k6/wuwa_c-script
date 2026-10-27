using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EF RID: 28911
	public class IShowTalkCameraMotionT
	{
		// Token: 0x1700D6E8 RID: 55016
		// (get) Token: 0x060333EB RID: 209899 RVA: 0x006E8DE6 File Offset: 0x006E6FE6
		// (set) Token: 0x060333EC RID: 209900 RVA: 0x006E8DEE File Offset: 0x006E6FEE
		public EShowTalkCameraMotionType Type { get; set; }

		// Token: 0x060333ED RID: 209901 RVA: 0x006E8DF7 File Offset: 0x006E6FF7
		public IShowTalkCameraMotionT()
		{
			this.Type = EShowTalkCameraMotionType.Preset;
		}
	}
}
