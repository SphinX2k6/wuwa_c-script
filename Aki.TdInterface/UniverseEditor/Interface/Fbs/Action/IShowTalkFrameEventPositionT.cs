using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078CA RID: 30922
	public class IShowTalkFrameEventPositionT
	{
		// Token: 0x1700E2EC RID: 58092
		// (get) Token: 0x0603670B RID: 222987 RVA: 0x0074A3DC File Offset: 0x007485DC
		// (set) Token: 0x0603670C RID: 222988 RVA: 0x0074A3E4 File Offset: 0x007485E4
		public int TalkItemId { get; set; }

		// Token: 0x1700E2ED RID: 58093
		// (get) Token: 0x0603670D RID: 222989 RVA: 0x0074A3ED File Offset: 0x007485ED
		// (set) Token: 0x0603670E RID: 222990 RVA: 0x0074A3F5 File Offset: 0x007485F5
		public int Offset { get; set; }

		// Token: 0x0603670F RID: 222991 RVA: 0x0074A3FE File Offset: 0x007485FE
		public IShowTalkFrameEventPositionT()
		{
			this.TalkItemId = 0;
			this.Offset = 0;
		}
	}
}
