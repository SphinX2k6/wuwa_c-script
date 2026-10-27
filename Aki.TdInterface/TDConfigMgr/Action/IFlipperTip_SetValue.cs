using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A76 RID: 6774
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlipperTip_SetValue
	{
		// Token: 0x04005980 RID: 22912
		public ECommonTipType Type;

		// Token: 0x04005981 RID: 22913
		public string TidMainText;

		// Token: 0x04005982 RID: 22914
		public string TidSubText;

		// Token: 0x04005983 RID: 22915
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005984 RID: 22916
		[Nullable(2)]
		public string EdTidSubText;
	}
}
