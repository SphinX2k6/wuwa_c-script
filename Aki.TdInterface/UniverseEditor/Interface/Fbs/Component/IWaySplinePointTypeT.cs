using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006176 RID: 24950
	public class IWaySplinePointTypeT
	{
		// Token: 0x1700BA07 RID: 47623
		// (get) Token: 0x0602A63F RID: 173631 RVA: 0x005C8AA2 File Offset: 0x005C6CA2
		// (set) Token: 0x0602A640 RID: 173632 RVA: 0x005C8AAA File Offset: 0x005C6CAA
		public EWaySplinePointType Type { get; set; }

		// Token: 0x0602A641 RID: 173633 RVA: 0x005C8AB3 File Offset: 0x005C6CB3
		public IWaySplinePointTypeT()
		{
			this.Type = EWaySplinePointType.Common;
		}
	}
}
