using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000892 RID: 2194
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemLifeCycleComponent_SetValue
	{
		// Token: 0x0400202F RID: 8239
		public bool? Disabled;

		// Token: 0x04002030 RID: 8240
		public bool? EdIsLocked;

		// Token: 0x04002031 RID: 8241
		public ICreateStageConfig CreateStageConfig;

		// Token: 0x04002032 RID: 8242
		public IDestroyStageConfig DestroyStageConfig;
	}
}
