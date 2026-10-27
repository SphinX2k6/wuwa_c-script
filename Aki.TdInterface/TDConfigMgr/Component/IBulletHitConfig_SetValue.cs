using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200020A RID: 522
	[NullableContext(2)]
	[Nullable(0)]
	public class IBulletHitConfig_SetValue
	{
		// Token: 0x04000941 RID: 2369
		[Nullable(1)]
		public IHitBulletType HitBullet;

		// Token: 0x04000942 RID: 2370
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x04000943 RID: 2371
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;
	}
}
