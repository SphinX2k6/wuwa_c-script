using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000762 RID: 1890
	public class ISequenceTrackControl_SetValue
	{
		// Token: 0x04001B6C RID: 7020
		public ETrackControlMode Type;

		// Token: 0x04001B6D RID: 7021
		public string Sequence;

		// Token: 0x04001B6E RID: 7022
		public List<ISequenceTrackControlPoint> ControlPoints;
	}
}
