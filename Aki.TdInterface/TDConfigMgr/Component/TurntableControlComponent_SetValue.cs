using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D3 RID: 2259
	public class TurntableControlComponent_SetValue
	{
		// Token: 0x04002188 RID: 8584
		public bool? Disabled;

		// Token: 0x04002189 RID: 8585
		public bool? EdIsLocked;

		// Token: 0x0400218A RID: 8586
		[Nullable(1)]
		public ITurntableControlType Config;
	}
}
