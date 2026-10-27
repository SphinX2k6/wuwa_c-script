using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200042B RID: 1067
	[NullableContext(1)]
	[Nullable(0)]
	public class IHitLogicChangeTargetState_SetValue
	{
		// Token: 0x0400109D RID: 4253
		public EHitLogicType Type;

		// Token: 0x0400109E RID: 4254
		public List<IConditionHitConfigWithBullet> TargetBulletHitConfigs;

		// Token: 0x0400109F RID: 4255
		public List<IConditionHitConfig> OtherBulletsHitConfig;
	}
}
