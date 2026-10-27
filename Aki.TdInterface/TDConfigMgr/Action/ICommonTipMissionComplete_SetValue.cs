using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200191F RID: 6431
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipMissionComplete_SetValue
	{
		// Token: 0x04005649 RID: 22089
		public ECommonTipType Type;

		// Token: 0x0400564A RID: 22090
		public string TidMainText;

		// Token: 0x0400564B RID: 22091
		public string TidSubText;

		// Token: 0x0400564C RID: 22092
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x0400564D RID: 22093
		[Nullable(2)]
		public string EdTidSubText;
	}
}
