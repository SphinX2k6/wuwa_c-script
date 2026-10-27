using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000569 RID: 1385
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcPerformOnMonsterCloseby_SetValue
	{
		// Token: 0x04001441 RID: 5185
		public float Range;

		// Token: 0x04001442 RID: 5186
		public IMontageId Montage;

		// Token: 0x04001443 RID: 5187
		public IBubbleIndex Bubble;

		// Token: 0x04001444 RID: 5188
		public int BubbleRate;
	}
}
