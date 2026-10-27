using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000890 RID: 2192
	public class SceneItemEventListenerComponent_SetValue
	{
		// Token: 0x04002026 RID: 8230
		public bool? Disabled;

		// Token: 0x04002027 RID: 8231
		public bool? EdIsLocked;

		// Token: 0x04002028 RID: 8232
		[Nullable(1)]
		public List<ISceneItemEventConfig> Events;
	}
}
