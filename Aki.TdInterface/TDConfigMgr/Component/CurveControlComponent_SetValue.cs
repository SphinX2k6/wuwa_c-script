using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004F RID: 79
	public class CurveControlComponent_SetValue
	{
		// Token: 0x0400019D RID: 413
		public bool? Disabled;

		// Token: 0x0400019E RID: 414
		public bool? EdIsLocked;

		// Token: 0x0400019F RID: 415
		[Nullable(2)]
		public IChargeSlashControl CurveControlConfig;
	}
}
