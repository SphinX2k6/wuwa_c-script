using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D1E RID: 23838
	public class IPavedWayConfigT
	{
		// Token: 0x1700AF3E RID: 44862
		// (get) Token: 0x060279D4 RID: 162260 RVA: 0x0056B776 File Offset: 0x00569976
		// (set) Token: 0x060279D5 RID: 162261 RVA: 0x0056B77E File Offset: 0x0056997E
		public bool AutoSprint { get; set; }

		// Token: 0x060279D6 RID: 162262 RVA: 0x0056B787 File Offset: 0x00569987
		public IPavedWayConfigT()
		{
			this.AutoSprint = false;
		}
	}
}
