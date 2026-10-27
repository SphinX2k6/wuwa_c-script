using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000675 RID: 1653
	public class IRefreshSingle_SetValue
	{
		// Token: 0x0400186C RID: 6252
		public int RefreshInterval;

		// Token: 0x0400186D RID: 6253
		public int MaxRefreshTimes;

		// Token: 0x0400186E RID: 6254
		public bool DelayRefresh;

		// Token: 0x0400186F RID: 6255
		[Nullable(1)]
		public ITempleGuid TemplateGuid;
	}
}
