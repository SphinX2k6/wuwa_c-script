using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001517 RID: 5399
	public class CommonTip_SetValue
	{
		// Token: 0x04004703 RID: 18179
		[Nullable(1)]
		public ICommonTipType TipOption;

		// Token: 0x04004704 RID: 18180
		public int? Duration;

		// Token: 0x04004705 RID: 18181
		[Nullable(2)]
		public string Token;
	}
}
