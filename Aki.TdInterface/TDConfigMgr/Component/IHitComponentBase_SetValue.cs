using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000476 RID: 1142
	[NullableContext(2)]
	[Nullable(0)]
	public class IHitComponentBase_SetValue
	{
		// Token: 0x0400119A RID: 4506
		public bool? Disabled;

		// Token: 0x0400119B RID: 4507
		public bool? EdIsLocked;

		// Token: 0x0400119C RID: 4508
		public IHitBulletType HitBullet;

		// Token: 0x0400119D RID: 4509
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x0400119E RID: 4510
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x0400119F RID: 4511
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAimPart> AimParts;
	}
}
