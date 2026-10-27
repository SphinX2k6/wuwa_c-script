using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070FE RID: 28926
	public class IShowTalkFrameEventPositionT
	{
		// Token: 0x1700D709 RID: 55049
		// (get) Token: 0x06033469 RID: 210025 RVA: 0x006E9DD0 File Offset: 0x006E7FD0
		// (set) Token: 0x0603346A RID: 210026 RVA: 0x006E9DD8 File Offset: 0x006E7FD8
		public int TalkItemId { get; set; }

		// Token: 0x1700D70A RID: 55050
		// (get) Token: 0x0603346B RID: 210027 RVA: 0x006E9DE1 File Offset: 0x006E7FE1
		// (set) Token: 0x0603346C RID: 210028 RVA: 0x006E9DE9 File Offset: 0x006E7FE9
		public int Offset { get; set; }

		// Token: 0x0603346D RID: 210029 RVA: 0x006E9DF2 File Offset: 0x006E7FF2
		public IShowTalkFrameEventPositionT()
		{
			this.TalkItemId = 0;
			this.Offset = 0;
		}
	}
}
