using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200088C RID: 2188
	public class SceneItemAiComponent_SetValue
	{
		// Token: 0x04002019 RID: 8217
		public bool? Disabled;

		// Token: 0x0400201A RID: 8218
		public bool? EdIsLocked;

		// Token: 0x0400201B RID: 8219
		[Nullable(1)]
		public ISceneItemPatrol AiConfig;
	}
}
