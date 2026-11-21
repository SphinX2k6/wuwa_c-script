using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA8 RID: 6824
	public class ICommonTipMissionComplete_SetValue
	{
		// Token: 0x04005A99 RID: 23193
		public ECommonTipType Type;

		// Token: 0x04005A9A RID: 23194
		public string TidMainText;

		// Token: 0x04005A9B RID: 23195
		public string TidSubText;

		// Token: 0x04005A9C RID: 23196
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005A9D RID: 23197
		[Nullable(2)]
		public string EdTidSubText;
	}
}
