using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADA RID: 6874
	public class IGravityControlOption_SetValue
	{
		// Token: 0x04005A8F RID: 23183
		public ESystemOptionType Type;

		// Token: 0x04005A90 RID: 23184
		[Nullable(1)]
		public List<ISystemOption> SystemOptions;

		// Token: 0x04005A91 RID: 23185
		public bool? KeepPreTalkItem;
	}
}
