using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018E RID: 398
	[NullableContext(1)]
	[Nullable(0)]
	public class GroupAiComponent_SetValue
	{
		// Token: 0x0400078A RID: 1930
		public bool? Disabled;

		// Token: 0x0400078B RID: 1931
		public bool? EdIsLocked;

		// Token: 0x0400078C RID: 1932
		public List<int> Entities;

		// Token: 0x0400078D RID: 1933
		public IGroupAiMode Option;

		// Token: 0x0400078E RID: 1934
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> SyncTags;
	}
}
