using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200080A RID: 2058
	[NullableContext(1)]
	[Nullable(0)]
	public class IWuWaGoLevelCenter_SetValue
	{
		// Token: 0x04001D8B RID: 7563
		public EWuWaGoEntityType Type;

		// Token: 0x04001D8C RID: 7564
		public string LevelKey;

		// Token: 0x04001D8D RID: 7565
		public List<int> LevelEntityIds;

		// Token: 0x04001D8E RID: 7566
		[Nullable(2)]
		public string EdActorPath;
	}
}
