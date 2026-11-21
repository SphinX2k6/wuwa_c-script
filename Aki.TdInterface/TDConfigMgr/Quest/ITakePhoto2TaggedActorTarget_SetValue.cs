using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AF RID: 4783
	public class ITakePhoto2TaggedActorTarget_SetValue
	{
		// Token: 0x04004055 RID: 16469
		public ETakePhoto2TargetType Type;

		// Token: 0x04004056 RID: 16470
		public bool? IsOptionalTarget;

		// Token: 0x04004057 RID: 16471
		[Nullable(2)]
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04004058 RID: 16472
		public string Tag;

		// Token: 0x04004059 RID: 16473
		[Nullable(2)]
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;

		// Token: 0x0400405A RID: 16474
		public int TargetSatisfiedCount;
	}
}
