using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BA1 RID: 23457
	public class INoiseRemovalBoxBoarderT
	{
		// Token: 0x1700AB73 RID: 43891
		// (get) Token: 0x06026AA1 RID: 158369 RVA: 0x0054B1C8 File Offset: 0x005493C8
		// (set) Token: 0x06026AA2 RID: 158370 RVA: 0x0054B1D0 File Offset: 0x005493D0
		public ENoiseRemovalBoarderShape Type { get; set; }

		// Token: 0x1700AB74 RID: 43892
		// (get) Token: 0x06026AA3 RID: 158371 RVA: 0x0054B1D9 File Offset: 0x005493D9
		// (set) Token: 0x06026AA4 RID: 158372 RVA: 0x0054B1E1 File Offset: 0x005493E1
		public IVectorInfoT BoxExtendPositive { get; set; }

		// Token: 0x1700AB75 RID: 43893
		// (get) Token: 0x06026AA5 RID: 158373 RVA: 0x0054B1EA File Offset: 0x005493EA
		// (set) Token: 0x06026AA6 RID: 158374 RVA: 0x0054B1F2 File Offset: 0x005493F2
		public IVectorInfoT BoxExtendNegative { get; set; }

		// Token: 0x06026AA7 RID: 158375 RVA: 0x0054B1FB File Offset: 0x005493FB
		public INoiseRemovalBoxBoarderT()
		{
			this.Type = ENoiseRemovalBoarderShape.Box;
			this.BoxExtendPositive = null;
			this.BoxExtendNegative = null;
		}
	}
}
