using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004F RID: 79
	public class CurveControlComponent_SetValue
	{
		// Token: 0x04000198 RID: 408
		public bool? Disabled;

		// Token: 0x04000199 RID: 409
		public bool? EdIsLocked;

		// Token: 0x0400019A RID: 410
		[Nullable(2)]
		public IChargeSlashControl CurveControlConfig;
	}
}
