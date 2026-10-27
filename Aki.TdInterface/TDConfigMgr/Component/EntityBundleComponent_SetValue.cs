using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020000FA RID: 250
	public class EntityBundleComponent_SetValue
	{
		// Token: 0x0400053C RID: 1340
		public bool? Disabled;

		// Token: 0x0400053D RID: 1341
		public bool? EdIsLocked;

		// Token: 0x0400053E RID: 1342
		public int BundleId;

		// Token: 0x0400053F RID: 1343
		[Nullable(1)]
		public List<IEntityBundleChildInfo> ChildInfos;
	}
}
