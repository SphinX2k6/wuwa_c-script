using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200010B RID: 267
	public class EntityPackageComponent_SetValue
	{
		// Token: 0x04000587 RID: 1415
		public bool? Disabled;

		// Token: 0x04000588 RID: 1416
		public bool? EdIsLocked;

		// Token: 0x04000589 RID: 1417
		public bool BindTemplate;

		// Token: 0x0400058A RID: 1418
		[Nullable(2)]
		public IEntityPackageData PackageData;
	}
}
