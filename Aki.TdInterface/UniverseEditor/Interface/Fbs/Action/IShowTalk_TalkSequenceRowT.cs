using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078D0 RID: 30928
	public class IShowTalk_TalkSequenceRowT
	{
		// Token: 0x1700E2F7 RID: 58103
		// (get) Token: 0x06036745 RID: 223045 RVA: 0x0074A999 File Offset: 0x00748B99
		// (set) Token: 0x06036746 RID: 223046 RVA: 0x0074A9A1 File Offset: 0x00748BA1
		public List<int> Items { get; set; }

		// Token: 0x06036747 RID: 223047 RVA: 0x0074A9AA File Offset: 0x00748BAA
		public IShowTalk_TalkSequenceRowT()
		{
			this.Items = null;
		}
	}
}
