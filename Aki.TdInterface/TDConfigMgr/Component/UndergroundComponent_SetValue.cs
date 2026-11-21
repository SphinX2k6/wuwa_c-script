using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200097A RID: 2426
	public class UndergroundComponent_SetValue
	{
		// Token: 0x040023A6 RID: 9126
		public bool? Disabled;

		// Token: 0x040023A7 RID: 9127
		public bool? EdIsLocked;

		// Token: 0x040023A8 RID: 9128
		public int TestState;

		// Token: 0x040023A9 RID: 9129
		public bool IsRestartPlayer;

		// Token: 0x040023AA RID: 9130
		public List<string> DestroyTag;

		// Token: 0x040023AB RID: 9131
		public List<IUndergroundStateInfo> StateInfo;
	}
}
