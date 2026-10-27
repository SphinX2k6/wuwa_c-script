using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008B6 RID: 2230
	[NullableContext(2)]
	[Nullable(0)]
	public class TargetGearComponent_SetValue
	{
		// Token: 0x040020D0 RID: 8400
		public bool? Disabled;

		// Token: 0x040020D1 RID: 8401
		public IHitBulletType HitBullet;

		// Token: 0x040020D2 RID: 8402
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x040020D3 RID: 8403
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x040020D4 RID: 8404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IAimPart> AimParts;

		// Token: 0x040020D5 RID: 8405
		public bool? EdIsLocked;

		// Token: 0x040020D6 RID: 8406
		[Nullable(1)]
		public string Type;

		// Token: 0x040020D7 RID: 8407
		public bool IsCycle;

		// Token: 0x040020D8 RID: 8408
		public int CycleInterval;

		// Token: 0x040020D9 RID: 8409
		[Nullable(1)]
		public List<string> CycleStates;

		// Token: 0x040020DA RID: 8410
		[Nullable(1)]
		public IHitLogicType HitLogicType;

		// Token: 0x040020DB RID: 8411
		public ISplineMove Patrol;

		// Token: 0x040020DC RID: 8412
		public float? HitCd;
	}
}
