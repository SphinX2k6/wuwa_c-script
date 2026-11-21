using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000377 RID: 887
	public class IEntityPackageData_SetValue
	{
		// Token: 0x04000E7C RID: 3708
		public int? PackagedLevelId;

		// Token: 0x04000E7D RID: 3709
		public int? PackageEntityId;

		// Token: 0x04000E7E RID: 3710
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IEntityPackageNode> PackageTree;
	}
}
