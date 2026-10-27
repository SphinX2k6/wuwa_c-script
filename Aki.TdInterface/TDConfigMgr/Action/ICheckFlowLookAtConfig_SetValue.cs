using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001893 RID: 6291
	[NullableContext(1)]
	[Nullable(0)]
	public class ICheckFlowLookAtConfig_SetValue
	{
		// Token: 0x0400551B RID: 21787
		public PlayFlow Flow;

		// Token: 0x0400551C RID: 21788
		public ICheckFlowLookAtTarget Target;

		// Token: 0x0400551D RID: 21789
		[Nullable(2)]
		public IEntityLookAtPerform EntityLookAtPerform;
	}
}
