using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000383 RID: 899
	public class IEntityTrackControl_SetValue
	{
		// Token: 0x04000EAC RID: 3756
		public ETrackControlMode Type;

		// Token: 0x04000EAD RID: 3757
		public int EntityId;

		// Token: 0x04000EAE RID: 3758
		public List<IEntityTrackControlPoint> ControlPoints;
	}
}
