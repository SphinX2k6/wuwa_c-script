using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001927 RID: 6439
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipTriggerDelegation_SetValue
	{
		// Token: 0x0400565D RID: 22109
		public ECommonTipType Type;

		// Token: 0x0400565E RID: 22110
		public string TidMainText;

		// Token: 0x0400565F RID: 22111
		public string TidSubText;

		// Token: 0x04005660 RID: 22112
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005661 RID: 22113
		[Nullable(2)]
		public string EdTidSubText;
	}
}
