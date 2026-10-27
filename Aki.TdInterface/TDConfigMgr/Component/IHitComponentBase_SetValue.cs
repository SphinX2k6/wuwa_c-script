using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200041D RID: 1053
	[NullableContext(2)]
	[Nullable(0)]
	public class IHitComponentBase_SetValue
	{
		// Token: 0x04001078 RID: 4216
		public bool? Disabled;

		// Token: 0x04001079 RID: 4217
		public bool? EdIsLocked;

		// Token: 0x0400107A RID: 4218
		public IHitBulletType HitBullet;

		// Token: 0x0400107B RID: 4219
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x0400107C RID: 4220
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x0400107D RID: 4221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAimPart> AimParts;
	}
}
