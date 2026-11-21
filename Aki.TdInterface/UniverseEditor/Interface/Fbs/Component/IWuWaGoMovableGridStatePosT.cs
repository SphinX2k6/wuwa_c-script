using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061E1 RID: 25057
	public class IWuWaGoMovableGridStatePosT
	{
		// Token: 0x1700BAD7 RID: 47831
		// (get) Token: 0x0602A9E3 RID: 174563 RVA: 0x005CFA67 File Offset: 0x005CDC67
		// (set) Token: 0x0602A9E4 RID: 174564 RVA: 0x005CFA6F File Offset: 0x005CDC6F
		public string EntityState { get; set; }

		// Token: 0x1700BAD8 RID: 47832
		// (get) Token: 0x0602A9E5 RID: 174565 RVA: 0x005CFA78 File Offset: 0x005CDC78
		// (set) Token: 0x0602A9E6 RID: 174566 RVA: 0x005CFA80 File Offset: 0x005CDC80
		public IVectorInfoT GridPos { get; set; }

		// Token: 0x0602A9E7 RID: 174567 RVA: 0x005CFA89 File Offset: 0x005CDC89
		public IWuWaGoMovableGridStatePosT()
		{
			this.EntityState = null;
			this.GridPos = null;
		}
	}
}
