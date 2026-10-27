using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018EB RID: 6379
	public class ICloseSplineMove_SetValue
	{
		// Token: 0x040055CD RID: 21965
		public ESplineMoveConfigType Type;

		// Token: 0x040055CE RID: 21966
		[Nullable(1)]
		public ITargetEntityType Target;

		// Token: 0x040055CF RID: 21967
		public int SplineEntityId;
	}
}
