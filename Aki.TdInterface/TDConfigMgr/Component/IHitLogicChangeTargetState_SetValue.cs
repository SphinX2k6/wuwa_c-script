using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000484 RID: 1156
	public class IHitLogicChangeTargetState_SetValue
	{
		// Token: 0x040011BF RID: 4543
		public EHitLogicType Type;

		// Token: 0x040011C0 RID: 4544
		public List<IConditionHitConfigWithBullet> TargetBulletHitConfigs;

		// Token: 0x040011C1 RID: 4545
		public List<IConditionHitConfig> OtherBulletsHitConfig;
	}
}
