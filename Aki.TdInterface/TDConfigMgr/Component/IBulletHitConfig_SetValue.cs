using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000233 RID: 563
	public class IBulletHitConfig_SetValue
	{
		// Token: 0x040009D2 RID: 2514
		public IHitBulletType HitBullet;

		// Token: 0x040009D3 RID: 2515
		[Nullable(2)]
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x040009D4 RID: 2516
		[Nullable(2)]
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;
	}
}
