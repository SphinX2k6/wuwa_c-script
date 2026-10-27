using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000334 RID: 820
	public class IEntityScanFunction_SetValue
	{
		// Token: 0x04000D9E RID: 3486
		public int ScanId;

		// Token: 0x04000D9F RID: 3487
		public bool IsConcealed;

		// Token: 0x04000DA0 RID: 3488
		[Nullable(2)]
		public IScanTraceEffect TraceEffect;

		// Token: 0x04000DA1 RID: 3489
		public ESpecificScanType? SpecificScanType;
	}
}
