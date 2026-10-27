using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085C RID: 2140
	public class ProceduralVisualComponent_SetValue
	{
		// Token: 0x04001F2C RID: 7980
		public bool? Disabled;

		// Token: 0x04001F2D RID: 7981
		public bool? EdIsLocked;

		// Token: 0x04001F2E RID: 7982
		[Nullable(1)]
		public List<IProceduralVisualBase> Configs;
	}
}
