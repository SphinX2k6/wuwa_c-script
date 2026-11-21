using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006096 RID: 24726
	public class ITimePatrolSplineT
	{
		// Token: 0x1700B7C6 RID: 47046
		// (get) Token: 0x06029D21 RID: 171297 RVA: 0x005B5913 File Offset: 0x005B3B13
		// (set) Token: 0x06029D22 RID: 171298 RVA: 0x005B591B File Offset: 0x005B3B1B
		public ESplineType Type { get; set; }

		// Token: 0x1700B7C7 RID: 47047
		// (get) Token: 0x06029D23 RID: 171299 RVA: 0x005B5924 File Offset: 0x005B3B24
		// (set) Token: 0x06029D24 RID: 171300 RVA: 0x005B592C File Offset: 0x005B3B2C
		public List<ITimePatrolSplinePointT> Points { get; set; }

		// Token: 0x06029D25 RID: 171301 RVA: 0x005B5935 File Offset: 0x005B3B35
		public ITimePatrolSplineT()
		{
			this.Type = ESplineType.Common;
			this.Points = null;
		}
	}
}
