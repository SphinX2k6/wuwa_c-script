using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B5A RID: 23386
	public class IWaySplineCommonPointT
	{
		// Token: 0x1700B0AF RID: 45231
		// (get) Token: 0x0602803F RID: 163903 RVA: 0x005806D2 File Offset: 0x0057E8D2
		// (set) Token: 0x06028040 RID: 163904 RVA: 0x005806DA File Offset: 0x0057E8DA
		public EWaySplinePointType Type { get; set; }

		// Token: 0x06028041 RID: 163905 RVA: 0x005806E3 File Offset: 0x0057E8E3
		public IWaySplineCommonPointT()
		{
			this.Type = EWaySplinePointType.Common;
		}
	}
}
