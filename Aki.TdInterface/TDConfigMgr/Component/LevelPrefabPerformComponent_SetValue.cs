using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000826 RID: 2086
	public class LevelPrefabPerformComponent_SetValue
	{
		// Token: 0x04001E0C RID: 7692
		public bool? Disabled;

		// Token: 0x04001E0D RID: 7693
		public bool? EdIsLocked;

		// Token: 0x04001E0E RID: 7694
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ITowardEntityConfig> TowardEntity;

		// Token: 0x04001E0F RID: 7695
		[Nullable(2)]
		public ILevelPrefabParamsConfig PrefabParams;

		// Token: 0x04001E10 RID: 7696
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IPrefabCompTransform> CompTransform;
	}
}
