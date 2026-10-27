using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D9 RID: 29913
	public class IUnlockEntityT
	{
		// Token: 0x1700E2FD RID: 58109
		// (get) Token: 0x0603661D RID: 222749 RVA: 0x00763881 File Offset: 0x00761A81
		// (set) Token: 0x0603661E RID: 222750 RVA: 0x00763889 File Offset: 0x00761A89
		public List<int> EntityIds { get; set; }

		// Token: 0x0603661F RID: 222751 RVA: 0x00763892 File Offset: 0x00761A92
		public IUnlockEntityT()
		{
			this.EntityIds = null;
		}
	}
}
