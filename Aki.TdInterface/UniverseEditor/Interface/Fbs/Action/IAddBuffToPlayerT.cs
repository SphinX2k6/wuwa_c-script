using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006123 RID: 24867
	public class IAddBuffToPlayerT
	{
		// Token: 0x1700B746 RID: 46918
		// (get) Token: 0x0602A813 RID: 174099 RVA: 0x005DA88A File Offset: 0x005D8A8A
		// (set) Token: 0x0602A814 RID: 174100 RVA: 0x005DA892 File Offset: 0x005D8A92
		public List<long> BuffIds { get; set; }

		// Token: 0x1700B747 RID: 46919
		// (get) Token: 0x0602A815 RID: 174101 RVA: 0x005DA89B File Offset: 0x005D8A9B
		// (set) Token: 0x0602A816 RID: 174102 RVA: 0x005DA8A3 File Offset: 0x005D8AA3
		public List<long> PersistOnDestroyBuffIds { get; set; }

		// Token: 0x1700B748 RID: 46920
		// (get) Token: 0x0602A817 RID: 174103 RVA: 0x005DA8AC File Offset: 0x005D8AAC
		// (set) Token: 0x0602A818 RID: 174104 RVA: 0x005DA8B4 File Offset: 0x005D8AB4
		public byte NullMask { get; set; }

		// Token: 0x0602A819 RID: 174105 RVA: 0x005DA8BD File Offset: 0x005D8ABD
		public IAddBuffToPlayerT()
		{
			this.BuffIds = null;
			this.PersistOnDestroyBuffIds = null;
			this.NullMask = 0;
		}
	}
}
