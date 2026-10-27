using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200085E RID: 2142
	[NullableContext(2)]
	[Nullable(0)]
	public class ProgressBarControlComponent_SetValue
	{
		// Token: 0x04001F37 RID: 7991
		public bool? Disabled;

		// Token: 0x04001F38 RID: 7992
		public IHitBulletType HitBullet;

		// Token: 0x04001F39 RID: 7993
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x04001F3A RID: 7994
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x04001F3B RID: 7995
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAimPart> AimParts;

		// Token: 0x04001F3C RID: 7996
		public bool? EdIsLocked;

		// Token: 0x04001F3D RID: 7997
		[Nullable(1)]
		public IProgressBarControl Control;
	}
}
