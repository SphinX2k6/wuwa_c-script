using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200055F RID: 1375
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcHitShow_SetValue
	{
		// Token: 0x04001420 RID: 5152
		public string HitMontage;

		// Token: 0x04001421 RID: 5153
		public IBubbleIndex HitBubble;

		// Token: 0x04001422 RID: 5154
		public int BubbleRate;
	}
}
