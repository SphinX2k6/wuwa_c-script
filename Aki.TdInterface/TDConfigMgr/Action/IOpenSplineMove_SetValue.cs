using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CB1 RID: 7345
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenSplineMove_SetValue
	{
		// Token: 0x04005F6D RID: 24429
		public ESplineMoveConfigType Type;

		// Token: 0x04005F6E RID: 24430
		public ITargetEntityType Target;

		// Token: 0x04005F6F RID: 24431
		public int SplineEntityId;

		// Token: 0x04005F70 RID: 24432
		public ISplineMovePattern Pattern;
	}
}
