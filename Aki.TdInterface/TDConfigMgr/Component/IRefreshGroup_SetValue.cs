using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200066D RID: 1645
	[NullableContext(1)]
	[Nullable(0)]
	public class IRefreshGroup_SetValue
	{
		// Token: 0x04001859 RID: 6233
		public bool? Disabled;

		// Token: 0x0400185A RID: 6234
		public bool? EdIsLocked;

		// Token: 0x0400185B RID: 6235
		public int RefreshInterval;

		// Token: 0x0400185C RID: 6236
		public bool DelayRefresh;

		// Token: 0x0400185D RID: 6237
		public List<int> EntityIdList;

		// Token: 0x0400185E RID: 6238
		public ICylinder IsUesCylinder;
	}
}
