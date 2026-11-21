using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000103 RID: 259
	public class EntityBundleComponent_SetValue
	{
		// Token: 0x04000566 RID: 1382
		public bool? Disabled;

		// Token: 0x04000567 RID: 1383
		public bool? EdIsLocked;

		// Token: 0x04000568 RID: 1384
		public int BundleId;

		// Token: 0x04000569 RID: 1385
		public List<IEntityBundleChildInfo> ChildInfos;
	}
}
