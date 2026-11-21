using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CCF RID: 31951
	public class IUnlockEntityT
	{
		// Token: 0x1700EF27 RID: 61223
		// (get) Token: 0x06039A32 RID: 236082 RVA: 0x007C6AD1 File Offset: 0x007C4CD1
		// (set) Token: 0x06039A33 RID: 236083 RVA: 0x007C6AD9 File Offset: 0x007C4CD9
		public List<int> EntityIds { get; set; }

		// Token: 0x06039A34 RID: 236084 RVA: 0x007C6AE2 File Offset: 0x007C4CE2
		public IUnlockEntityT()
		{
			this.EntityIds = null;
		}
	}
}
