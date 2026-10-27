using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000330 RID: 816
	public class IEntityPackageData_SetValue
	{
		// Token: 0x04000D91 RID: 3473
		public int? PackagedLevelId;

		// Token: 0x04000D92 RID: 3474
		public int? PackageEntityId;

		// Token: 0x04000D93 RID: 3475
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IEntityPackageNode> PackageTree;
	}
}
