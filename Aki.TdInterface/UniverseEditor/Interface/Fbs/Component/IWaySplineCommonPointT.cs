using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006170 RID: 24944
	public class IWaySplineCommonPointT
	{
		// Token: 0x1700B9F7 RID: 47607
		// (get) Token: 0x0602A603 RID: 173571 RVA: 0x005C8162 File Offset: 0x005C6362
		// (set) Token: 0x0602A604 RID: 173572 RVA: 0x005C816A File Offset: 0x005C636A
		public EWaySplinePointType Type { get; set; }

		// Token: 0x0602A605 RID: 173573 RVA: 0x005C8173 File Offset: 0x005C6373
		public IWaySplineCommonPointT()
		{
			this.Type = EWaySplinePointType.Common;
		}
	}
}
