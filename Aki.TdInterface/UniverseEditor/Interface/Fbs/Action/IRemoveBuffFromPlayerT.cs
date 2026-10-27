using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3E RID: 28222
	public class IRemoveBuffFromPlayerT
	{
		// Token: 0x1700D24E RID: 53838
		// (get) Token: 0x06031DF8 RID: 204280 RVA: 0x006BFD85 File Offset: 0x006BDF85
		// (set) Token: 0x06031DF9 RID: 204281 RVA: 0x006BFD8D File Offset: 0x006BDF8D
		public List<long> BuffIds { get; set; }

		// Token: 0x06031DFA RID: 204282 RVA: 0x006BFD96 File Offset: 0x006BDF96
		public IRemoveBuffFromPlayerT()
		{
			this.BuffIds = null;
		}
	}
}
