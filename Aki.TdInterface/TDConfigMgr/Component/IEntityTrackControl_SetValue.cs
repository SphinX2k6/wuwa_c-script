using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033C RID: 828
	public class IEntityTrackControl_SetValue
	{
		// Token: 0x04000DC1 RID: 3521
		public ETrackControlMode Type;

		// Token: 0x04000DC2 RID: 3522
		public int EntityId;

		// Token: 0x04000DC3 RID: 3523
		[Nullable(1)]
		public List<IEntityTrackControlPoint> ControlPoints;
	}
}
