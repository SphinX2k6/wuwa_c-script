using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000901 RID: 2305
	[NullableContext(2)]
	[Nullable(0)]
	public class ProgressBarControlComponent_SetValue
	{
		// Token: 0x04002149 RID: 8521
		public bool? Disabled;

		// Token: 0x0400214A RID: 8522
		public IHitBulletType HitBullet;

		// Token: 0x0400214B RID: 8523
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x0400214C RID: 8524
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x0400214D RID: 8525
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAimPart> AimParts;

		// Token: 0x0400214E RID: 8526
		public bool? EdIsLocked;

		// Token: 0x0400214F RID: 8527
		[Nullable(0)]
		public IProgressBarControl Control;
	}
}
