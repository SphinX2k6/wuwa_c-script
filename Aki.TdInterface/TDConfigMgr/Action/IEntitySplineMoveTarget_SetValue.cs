using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BAA RID: 7082
	public class IEntitySplineMoveTarget_SetValue
	{
		// Token: 0x04005CF9 RID: 23801
		public ESplineMoveTargetType Type;

		// Token: 0x04005CFA RID: 23802
		public int EntityId;

		// Token: 0x04005CFB RID: 23803
		[Nullable(2)]
		public ISplineMoveDriveMode MoveDriveMode;
	}
}
