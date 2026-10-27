using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ABB RID: 23227
	public class ITimeStopTargetT
	{
		// Token: 0x1700AEEE RID: 44782
		// (get) Token: 0x06027942 RID: 162114 RVA: 0x0057197F File Offset: 0x0056FB7F
		// (set) Token: 0x06027943 RID: 162115 RVA: 0x00571987 File Offset: 0x0056FB87
		public List<int> EntityIds { get; set; }

		// Token: 0x1700AEEF RID: 44783
		// (get) Token: 0x06027944 RID: 162116 RVA: 0x00571990 File Offset: 0x0056FB90
		// (set) Token: 0x06027945 RID: 162117 RVA: 0x00571998 File Offset: 0x0056FB98
		public IDynamicEntityMatchT EntityMatch { get; set; }

		// Token: 0x06027946 RID: 162118 RVA: 0x005719A1 File Offset: 0x0056FBA1
		public ITimeStopTargetT()
		{
			this.EntityIds = null;
			this.EntityMatch = null;
		}
	}
}
