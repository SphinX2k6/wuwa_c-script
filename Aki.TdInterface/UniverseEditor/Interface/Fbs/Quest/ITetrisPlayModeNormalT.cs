using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041CA RID: 16842
	public class ITetrisPlayModeNormalT
	{
		// Token: 0x1700776F RID: 30575
		// (get) Token: 0x06018CF6 RID: 101622 RVA: 0x0039201C File Offset: 0x0039021C
		// (set) Token: 0x06018CF7 RID: 101623 RVA: 0x00392024 File Offset: 0x00390224
		public ETetrisPlayMode Type { get; set; }

		// Token: 0x17007770 RID: 30576
		// (get) Token: 0x06018CF8 RID: 101624 RVA: 0x0039202D File Offset: 0x0039022D
		// (set) Token: 0x06018CF9 RID: 101625 RVA: 0x00392035 File Offset: 0x00390235
		public int Time { get; set; }

		// Token: 0x06018CFA RID: 101626 RVA: 0x0039203E File Offset: 0x0039023E
		public ITetrisPlayModeNormalT()
		{
			this.Type = ETetrisPlayMode.Normal;
			this.Time = 0;
		}
	}
}
