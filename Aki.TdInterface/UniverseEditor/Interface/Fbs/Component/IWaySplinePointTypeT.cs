using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B60 RID: 23392
	public class IWaySplinePointTypeT
	{
		// Token: 0x1700B0BF RID: 45247
		// (get) Token: 0x0602807B RID: 163963 RVA: 0x00581012 File Offset: 0x0057F212
		// (set) Token: 0x0602807C RID: 163964 RVA: 0x0058101A File Offset: 0x0057F21A
		public EWaySplinePointType Type { get; set; }

		// Token: 0x0602807D RID: 163965 RVA: 0x00581023 File Offset: 0x0057F223
		public IWaySplinePointTypeT()
		{
			this.Type = EWaySplinePointType.Common;
		}
	}
}
