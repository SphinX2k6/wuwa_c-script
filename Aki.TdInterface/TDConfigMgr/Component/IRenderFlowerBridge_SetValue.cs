using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200067B RID: 1659
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderFlowerBridge_SetValue
	{
		// Token: 0x0400187C RID: 6268
		public ERenderSpecifiedRangeType Type;

		// Token: 0x0400187D RID: 6269
		public int Radius;

		// Token: 0x0400187E RID: 6270
		public ITargetEntityType CenterTarget;

		// Token: 0x0400187F RID: 6271
		public string AkEvent;
	}
}
