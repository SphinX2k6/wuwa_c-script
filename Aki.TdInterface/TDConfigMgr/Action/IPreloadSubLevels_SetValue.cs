using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4F RID: 7503
	public class IPreloadSubLevels_SetValue
	{
		// Token: 0x040060EF RID: 24815
		public ESwitchSubLevelsType Type;

		// Token: 0x040060F0 RID: 24816
		[Nullable(1)]
		public List<string> PreloadLevels;
	}
}
