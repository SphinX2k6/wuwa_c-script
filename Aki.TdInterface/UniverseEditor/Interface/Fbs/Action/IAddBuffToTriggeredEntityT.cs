using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006788 RID: 26504
	public class IAddBuffToTriggeredEntityT
	{
		// Token: 0x1700C0B6 RID: 49334
		// (get) Token: 0x0602CF12 RID: 184082 RVA: 0x00624B21 File Offset: 0x00622D21
		// (set) Token: 0x0602CF13 RID: 184083 RVA: 0x00624B29 File Offset: 0x00622D29
		public List<long> BuffIds { get; set; }

		// Token: 0x0602CF14 RID: 184084 RVA: 0x00624B32 File Offset: 0x00622D32
		public IAddBuffToTriggeredEntityT()
		{
			this.BuffIds = null;
		}
	}
}
