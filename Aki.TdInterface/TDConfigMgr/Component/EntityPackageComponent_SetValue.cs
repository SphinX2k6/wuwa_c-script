using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000102 RID: 258
	public class EntityPackageComponent_SetValue
	{
		// Token: 0x0400055D RID: 1373
		public bool? Disabled;

		// Token: 0x0400055E RID: 1374
		public bool? EdIsLocked;

		// Token: 0x0400055F RID: 1375
		public bool BindTemplate;

		// Token: 0x04000560 RID: 1376
		[Nullable(2)]
		public IEntityPackageData PackageData;
	}
}
