using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C69 RID: 7273
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcFollowConfig_SetValue
	{
		// Token: 0x04005EAA RID: 24234
		public IPerformerRangeBoundaryActionTrigger PerformerWhenEnter;

		// Token: 0x04005EAB RID: 24235
		public IPerformerRangeBoundaryActionTrigger PerformerWhenExit;
	}
}
