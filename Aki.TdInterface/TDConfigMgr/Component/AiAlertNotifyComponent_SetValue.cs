using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000018 RID: 24
	public class AiAlertNotifyComponent_SetValue
	{
		// Token: 0x04000047 RID: 71
		public bool? Disabled;

		// Token: 0x04000048 RID: 72
		public bool? EdIsLocked;

		// Token: 0x04000049 RID: 73
		public IExtraAiAlert ExtraAiAlert;

		// Token: 0x0400004A RID: 74
		[Nullable(2)]
		public List<int> ExcludeEntities;

		// Token: 0x0400004B RID: 75
		[Nullable(2)]
		public string AlertSound;
	}
}
