using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200698C RID: 27020
	public class IChangeRandomStateT
	{
		// Token: 0x1700C6F1 RID: 50929
		// (get) Token: 0x0602E596 RID: 189846 RVA: 0x00653C49 File Offset: 0x00651E49
		// (set) Token: 0x0602E597 RID: 189847 RVA: 0x00653C51 File Offset: 0x00651E51
		public List<int> StateIds { get; set; }

		// Token: 0x0602E598 RID: 189848 RVA: 0x00653C5A File Offset: 0x00651E5A
		public IChangeRandomStateT()
		{
			this.StateIds = null;
		}
	}
}
