using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001AB RID: 427
	[NullableContext(2)]
	[Nullable(0)]
	public class HitComponent_SetValue
	{
		// Token: 0x04000800 RID: 2048
		public bool? Disabled;

		// Token: 0x04000801 RID: 2049
		public IHitBulletType HitBullet;

		// Token: 0x04000802 RID: 2050
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x04000803 RID: 2051
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x04000804 RID: 2052
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAimPart> AimParts;

		// Token: 0x04000805 RID: 2053
		public bool? EdIsLocked;

		// Token: 0x04000806 RID: 2054
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IBulletHitConfig> BulletHitConfigs;
	}
}
