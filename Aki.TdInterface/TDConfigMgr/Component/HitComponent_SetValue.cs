using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000194 RID: 404
	[NullableContext(2)]
	[Nullable(0)]
	public class HitComponent_SetValue
	{
		// Token: 0x040007AA RID: 1962
		public bool? Disabled;

		// Token: 0x040007AB RID: 1963
		public IHitBulletType HitBullet;

		// Token: 0x040007AC RID: 1964
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x040007AD RID: 1965
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x040007AE RID: 1966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAimPart> AimParts;

		// Token: 0x040007AF RID: 1967
		public bool? EdIsLocked;

		// Token: 0x040007B0 RID: 1968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IBulletHitConfig> BulletHitConfigs;
	}
}
