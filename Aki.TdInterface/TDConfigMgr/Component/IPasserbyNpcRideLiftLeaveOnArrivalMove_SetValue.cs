using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000654 RID: 1620
	public class IPasserbyNpcRideLiftLeaveOnArrivalMove_SetValue
	{
		// Token: 0x040017F9 RID: 6137
		public EPasserbyNpcLiftMoveType Type;

		// Token: 0x040017FA RID: 6138
		public int LiftEntityId;

		// Token: 0x040017FB RID: 6139
		public IPasserbyNpcLiftStopExitTiming ExitTiming;

		// Token: 0x040017FC RID: 6140
		public List<IPasserbyNpcFloorSpline> FloorSplines;
	}
}
