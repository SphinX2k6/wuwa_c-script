using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A59 RID: 31321
	public class ISystemOptionT
	{
		// Token: 0x1700E576 RID: 58742
		// (get) Token: 0x0603733F RID: 226111 RVA: 0x0075FB31 File Offset: 0x0075DD31
		// (set) Token: 0x06037340 RID: 226112 RVA: 0x0075FB39 File Offset: 0x0075DD39
		public int OptionId { get; set; }

		// Token: 0x1700E577 RID: 58743
		// (get) Token: 0x06037341 RID: 226113 RVA: 0x0075FB42 File Offset: 0x0075DD42
		// (set) Token: 0x06037342 RID: 226114 RVA: 0x0075FB4A File Offset: 0x0075DD4A
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700E578 RID: 58744
		// (get) Token: 0x06037343 RID: 226115 RVA: 0x0075FB53 File Offset: 0x0075DD53
		// (set) Token: 0x06037344 RID: 226116 RVA: 0x0075FB5B File Offset: 0x0075DD5B
		public byte NullMask { get; set; }

		// Token: 0x06037345 RID: 226117 RVA: 0x0075FB64 File Offset: 0x0075DD64
		public ISystemOptionT()
		{
			this.OptionId = 0;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
