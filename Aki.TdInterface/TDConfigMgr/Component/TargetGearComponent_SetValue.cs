using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000959 RID: 2393
	public class TargetGearComponent_SetValue
	{
		// Token: 0x040022E2 RID: 8930
		public bool? Disabled;

		// Token: 0x040022E3 RID: 8931
		[Nullable(2)]
		public IHitBulletType HitBullet;

		// Token: 0x040022E4 RID: 8932
		[Nullable(2)]
		public IHitTimeScaleRatio AttackerHitTimeScaleRatio;

		// Token: 0x040022E5 RID: 8933
		[Nullable(2)]
		public IHitTimeScaleRatio VictimHitTimeScaleRatio;

		// Token: 0x040022E6 RID: 8934
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IAimPart> AimParts;

		// Token: 0x040022E7 RID: 8935
		public bool? EdIsLocked;

		// Token: 0x040022E8 RID: 8936
		public string Type;

		// Token: 0x040022E9 RID: 8937
		public bool IsCycle;

		// Token: 0x040022EA RID: 8938
		public int CycleInterval;

		// Token: 0x040022EB RID: 8939
		public List<string> CycleStates;

		// Token: 0x040022EC RID: 8940
		public IHitLogicType HitLogicType;

		// Token: 0x040022ED RID: 8941
		[Nullable(2)]
		public ISplineMove Patrol;

		// Token: 0x040022EE RID: 8942
		public float? HitCd;
	}
}
