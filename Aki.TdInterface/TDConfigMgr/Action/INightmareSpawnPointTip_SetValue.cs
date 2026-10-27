using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C61 RID: 7265
	[NullableContext(1)]
	[Nullable(0)]
	public class INightmareSpawnPointTip_SetValue
	{
		// Token: 0x04005E90 RID: 24208
		public ECommonTipType Type;

		// Token: 0x04005E91 RID: 24209
		public string TidMainText;

		// Token: 0x04005E92 RID: 24210
		public string TidSubText;

		// Token: 0x04005E93 RID: 24211
		[Nullable(2)]
		public string EdTidMainText;

		// Token: 0x04005E94 RID: 24212
		[Nullable(2)]
		public string EdTidSubText;
	}
}
