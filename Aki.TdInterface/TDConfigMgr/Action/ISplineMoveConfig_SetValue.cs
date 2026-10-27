using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EA0 RID: 7840
	public class ISplineMoveConfig_SetValue
	{
		// Token: 0x040063FD RID: 25597
		public ESplineMoveConfigType Type;

		// Token: 0x040063FE RID: 25598
		[Nullable(1)]
		public ITargetEntityType Target;

		// Token: 0x040063FF RID: 25599
		public int SplineEntityId;
	}
}
