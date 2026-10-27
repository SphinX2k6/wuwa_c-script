using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F12 RID: 7954
	public class ISystemOption_SetValue
	{
		// Token: 0x04006514 RID: 25876
		public int? OptionId;

		// Token: 0x04006515 RID: 25877
		[Nullable(1)]
		public List<ActionInfo> Actions;
	}
}
