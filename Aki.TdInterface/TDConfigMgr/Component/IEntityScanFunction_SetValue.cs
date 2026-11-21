using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200037B RID: 891
	public class IEntityScanFunction_SetValue
	{
		// Token: 0x04000E89 RID: 3721
		public int ScanId;

		// Token: 0x04000E8A RID: 3722
		public bool IsConcealed;

		// Token: 0x04000E8B RID: 3723
		[Nullable(2)]
		public IScanTraceEffect TraceEffect;

		// Token: 0x04000E8C RID: 3724
		public ESpecificScanType? SpecificScanType;
	}
}
