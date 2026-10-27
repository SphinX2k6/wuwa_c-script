using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7D RID: 23165
	public class ITimelineTrackControlComponentT
	{
		// Token: 0x1700AE7E RID: 44670
		// (get) Token: 0x06027753 RID: 161619 RVA: 0x0056E02D File Offset: 0x0056C22D
		// (set) Token: 0x06027754 RID: 161620 RVA: 0x0056E035 File Offset: 0x0056C235
		public bool Disabled { get; set; }

		// Token: 0x1700AE7F RID: 44671
		// (get) Token: 0x06027755 RID: 161621 RVA: 0x0056E03E File Offset: 0x0056C23E
		// (set) Token: 0x06027756 RID: 161622 RVA: 0x0056E046 File Offset: 0x0056C246
		public List<ITimelineControlGroupT> ControlGroups { get; set; }

		// Token: 0x1700AE80 RID: 44672
		// (get) Token: 0x06027757 RID: 161623 RVA: 0x0056E04F File Offset: 0x0056C24F
		// (set) Token: 0x06027758 RID: 161624 RVA: 0x0056E057 File Offset: 0x0056C257
		public byte NullMask { get; set; }

		// Token: 0x06027759 RID: 161625 RVA: 0x0056E060 File Offset: 0x0056C260
		public ITimelineTrackControlComponentT()
		{
			this.Disabled = false;
			this.ControlGroups = null;
			this.NullMask = 0;
		}
	}
}
