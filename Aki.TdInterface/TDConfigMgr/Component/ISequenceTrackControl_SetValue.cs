using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006C1 RID: 1729
	[NullableContext(1)]
	[Nullable(0)]
	public class ISequenceTrackControl_SetValue
	{
		// Token: 0x0400196D RID: 6509
		public ETrackControlMode Type;

		// Token: 0x0400196E RID: 6510
		public string Sequence;

		// Token: 0x0400196F RID: 6511
		public List<ISequenceTrackControlPoint> ControlPoints;
	}
}
