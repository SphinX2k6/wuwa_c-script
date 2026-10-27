using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006126 RID: 24870
	public class IAddBuffToTriggeredEntityT
	{
		// Token: 0x1700B74B RID: 46923
		// (get) Token: 0x0602A831 RID: 174129 RVA: 0x005DAB79 File Offset: 0x005D8D79
		// (set) Token: 0x0602A832 RID: 174130 RVA: 0x005DAB81 File Offset: 0x005D8D81
		public List<long> BuffIds { get; set; }

		// Token: 0x0602A833 RID: 174131 RVA: 0x005DAB8A File Offset: 0x005D8D8A
		public IAddBuffToTriggeredEntityT()
		{
			this.BuffIds = null;
		}
	}
}
