using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008C9 RID: 2249
	public class LevelPrefabPerformComponent_SetValue
	{
		// Token: 0x04002018 RID: 8216
		public bool? Disabled;

		// Token: 0x04002019 RID: 8217
		public bool? EdIsLocked;

		// Token: 0x0400201A RID: 8218
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ITowardEntityConfig> TowardEntity;

		// Token: 0x0400201B RID: 8219
		[Nullable(2)]
		public ILevelPrefabParamsConfig PrefabParams;

		// Token: 0x0400201C RID: 8220
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IPrefabCompTransform> CompTransform;
	}
}
