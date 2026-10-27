using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200211A RID: 8474
	[NullableContext(2)]
	[Nullable(0)]
	public class PlayMontage_SetValue
	{
		// Token: 0x04006F9E RID: 28574
		public int EntityId;

		// Token: 0x04006F9F RID: 28575
		[Nullable(1)]
		public IActionMontage ActionMontage;

		// Token: 0x04006FA0 RID: 28576
		public string ExpressionMontage;

		// Token: 0x04006FA1 RID: 28577
		public string MouthSequence;

		// Token: 0x04006FA2 RID: 28578
		public int? Duration;
	}
}
