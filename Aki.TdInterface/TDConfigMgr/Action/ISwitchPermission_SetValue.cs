using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F04 RID: 7940
	public class ISwitchPermission_SetValue
	{
		// Token: 0x040064F2 RID: 25842
		public ESwitchSubLevelsType Type;

		// Token: 0x040064F3 RID: 25843
		public bool IsAllowClientSwitch;

		// Token: 0x040064F4 RID: 25844
		[Nullable(1)]
		public List<string> Levels;
	}
}
