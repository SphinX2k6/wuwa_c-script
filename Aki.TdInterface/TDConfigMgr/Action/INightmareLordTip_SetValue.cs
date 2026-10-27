using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5F RID: 7263
	[NullableContext(1)]
	[Nullable(0)]
	public class INightmareLordTip_SetValue
	{
		// Token: 0x04005E89 RID: 24201
		public ECommonTipType Type;

		// Token: 0x04005E8A RID: 24202
		public string TidMainText;

		// Token: 0x04005E8B RID: 24203
		public string TidSubText;

		// Token: 0x04005E8C RID: 24204
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005E8D RID: 24205
		[Nullable(2)]
		public string EdTidSubText;
	}
}
