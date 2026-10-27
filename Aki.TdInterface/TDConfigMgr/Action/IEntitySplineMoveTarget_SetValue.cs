using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A15 RID: 6677
	public class IEntitySplineMoveTarget_SetValue
	{
		// Token: 0x04005894 RID: 22676
		public ESplineMoveTargetType Type;

		// Token: 0x04005895 RID: 22677
		public int EntityId;

		// Token: 0x04005896 RID: 22678
		[Nullable(2)]
		public ISplineMoveDriveMode MoveDriveMode;
	}
}
