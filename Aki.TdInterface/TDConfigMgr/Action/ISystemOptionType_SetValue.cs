using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F14 RID: 7956
	public class ISystemOptionType_SetValue
	{
		// Token: 0x0400651A RID: 25882
		public ESystemOptionType Type;

		// Token: 0x0400651B RID: 25883
		[Nullable(1)]
		public List<ISystemOption> SystemOptions;

		// Token: 0x0400651C RID: 25884
		public bool? KeepPreTalkItem;
	}
}
