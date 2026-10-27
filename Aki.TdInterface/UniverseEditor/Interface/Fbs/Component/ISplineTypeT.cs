using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005987 RID: 22919
	public class ISplineTypeT
	{
		// Token: 0x1700AC02 RID: 44034
		// (get) Token: 0x06026CF8 RID: 158968 RVA: 0x00557AA2 File Offset: 0x00555CA2
		// (set) Token: 0x06026CF9 RID: 158969 RVA: 0x00557AAA File Offset: 0x00555CAA
		public ESplineType Type { get; set; }

		// Token: 0x06026CFA RID: 158970 RVA: 0x00557AB3 File Offset: 0x00555CB3
		public ISplineTypeT()
		{
			this.Type = ESplineType.Common;
		}
	}
}
