using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008D5 RID: 2261
	[NullableContext(1)]
	[Nullable(0)]
	public class UndergroundComponent_SetValue
	{
		// Token: 0x0400218F RID: 8591
		public bool? Disabled;

		// Token: 0x04002190 RID: 8592
		public bool? EdIsLocked;

		// Token: 0x04002191 RID: 8593
		public int TestState;

		// Token: 0x04002192 RID: 8594
		public bool IsRestartPlayer;

		// Token: 0x04002193 RID: 8595
		public List<string> DestroyTag;

		// Token: 0x04002194 RID: 8596
		public List<IUndergroundStateInfo> StateInfo;
	}
}
