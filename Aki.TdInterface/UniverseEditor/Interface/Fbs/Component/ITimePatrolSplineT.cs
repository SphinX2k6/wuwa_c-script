using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A89 RID: 23177
	public class ITimePatrolSplineT
	{
		// Token: 0x1700AE8E RID: 44686
		// (get) Token: 0x060277A9 RID: 161705 RVA: 0x0056E907 File Offset: 0x0056CB07
		// (set) Token: 0x060277AA RID: 161706 RVA: 0x0056E90F File Offset: 0x0056CB0F
		public ESplineType Type { get; set; }

		// Token: 0x1700AE8F RID: 44687
		// (get) Token: 0x060277AB RID: 161707 RVA: 0x0056E918 File Offset: 0x0056CB18
		// (set) Token: 0x060277AC RID: 161708 RVA: 0x0056E920 File Offset: 0x0056CB20
		public List<ITimePatrolSplinePointT> Points { get; set; }

		// Token: 0x060277AD RID: 161709 RVA: 0x0056E929 File Offset: 0x0056CB29
		public ITimePatrolSplineT()
		{
			this.Type = ESplineType.Common;
			this.Points = null;
		}
	}
}
