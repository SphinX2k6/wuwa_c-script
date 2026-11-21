using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200070A RID: 1802
	public class IRefreshGroup_SetValue
	{
		// Token: 0x04001A4B RID: 6731
		public bool? Disabled;

		// Token: 0x04001A4C RID: 6732
		public bool? EdIsLocked;

		// Token: 0x04001A4D RID: 6733
		public int RefreshInterval;

		// Token: 0x04001A4E RID: 6734
		public bool DelayRefresh;

		// Token: 0x04001A4F RID: 6735
		public List<int> EntityIdList;

		// Token: 0x04001A50 RID: 6736
		public ICylinder IsUesCylinder;
	}
}
