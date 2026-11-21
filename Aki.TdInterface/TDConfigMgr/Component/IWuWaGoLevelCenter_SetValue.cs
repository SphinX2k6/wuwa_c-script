using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008AD RID: 2221
	public class IWuWaGoLevelCenter_SetValue
	{
		// Token: 0x04001F97 RID: 8087
		public EWuWaGoEntityType Type;

		// Token: 0x04001F98 RID: 8088
		public string LevelKey;

		// Token: 0x04001F99 RID: 8089
		public List<int> LevelEntityIds;

		// Token: 0x04001F9A RID: 8090
		[Nullable(2)]
		public string EdActorPath;
	}
}
