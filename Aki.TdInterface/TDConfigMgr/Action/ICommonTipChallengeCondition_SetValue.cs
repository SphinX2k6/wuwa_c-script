using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001911 RID: 6417
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipChallengeCondition_SetValue
	{
		// Token: 0x04005625 RID: 22053
		public ECommonTipType Type;

		// Token: 0x04005626 RID: 22054
		public string TidMainText;

		// Token: 0x04005627 RID: 22055
		public string TidSubText;

		// Token: 0x04005628 RID: 22056
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005629 RID: 22057
		[Nullable(2)]
		public string EdTidSubText;
	}
}
