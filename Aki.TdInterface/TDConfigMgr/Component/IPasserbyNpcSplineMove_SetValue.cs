using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D3 RID: 1491
	public class IPasserbyNpcSplineMove_SetValue
	{
		// Token: 0x0400164B RID: 5707
		public EPasserbyNpcMoveType Type;

		// Token: 0x0400164C RID: 5708
		[Nullable(1)]
		public List<IPasserbyNpcSpline> Routes;
	}
}
