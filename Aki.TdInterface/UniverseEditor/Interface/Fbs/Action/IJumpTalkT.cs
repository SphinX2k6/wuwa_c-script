using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D6 RID: 27094
	public class IJumpTalkT
	{
		// Token: 0x1700C90F RID: 51471
		// (get) Token: 0x0602F5D9 RID: 194009 RVA: 0x006733EA File Offset: 0x006715EA
		// (set) Token: 0x0602F5DA RID: 194010 RVA: 0x006733F2 File Offset: 0x006715F2
		public int TalkId { get; set; }

		// Token: 0x0602F5DB RID: 194011 RVA: 0x006733FB File Offset: 0x006715FB
		public IJumpTalkT()
		{
			this.TalkId = 0;
		}
	}
}
