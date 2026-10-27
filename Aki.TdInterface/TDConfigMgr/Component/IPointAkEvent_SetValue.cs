using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000607 RID: 1543
	public class IPointAkEvent_SetValue
	{
		// Token: 0x0400170F RID: 5903
		public EAkEventType Type;

		// Token: 0x04001710 RID: 5904
		[Nullable(2)]
		public List<int> PointIds;

		// Token: 0x04001711 RID: 5905
		public bool? UseListenerCone;

		// Token: 0x04001712 RID: 5906
		public bool? EnableOcclusion;
	}
}
