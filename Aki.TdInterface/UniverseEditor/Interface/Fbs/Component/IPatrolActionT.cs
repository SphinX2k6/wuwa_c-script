using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CF4 RID: 23796
	public class IPatrolActionT
	{
		// Token: 0x1700AEE2 RID: 44770
		// (get) Token: 0x0602785C RID: 161884 RVA: 0x005687B3 File Offset: 0x005669B3
		// (set) Token: 0x0602785D RID: 161885 RVA: 0x005687BB File Offset: 0x005669BB
		public int Point { get; set; }

		// Token: 0x1700AEE3 RID: 44771
		// (get) Token: 0x0602785E RID: 161886 RVA: 0x005687C4 File Offset: 0x005669C4
		// (set) Token: 0x0602785F RID: 161887 RVA: 0x005687CC File Offset: 0x005669CC
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x06027860 RID: 161888 RVA: 0x005687D5 File Offset: 0x005669D5
		public IPatrolActionT()
		{
			this.Point = 0;
			this.Actions = null;
		}
	}
}
