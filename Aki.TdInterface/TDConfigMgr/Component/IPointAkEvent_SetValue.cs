using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006A4 RID: 1700
	public class IPointAkEvent_SetValue
	{
		// Token: 0x04001901 RID: 6401
		public EAkEventType Type;

		// Token: 0x04001902 RID: 6402
		[Nullable(2)]
		public List<int> PointIds;

		// Token: 0x04001903 RID: 6403
		public bool? UseListenerCone;

		// Token: 0x04001904 RID: 6404
		public bool? EnableOcclusion;
	}
}
