using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A1 RID: 4769
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2EntityTarget_SetValue
	{
		// Token: 0x0400402D RID: 16429
		public ETakePhoto2TargetType Type;

		// Token: 0x0400402E RID: 16430
		public bool? IsOptionalTarget;

		// Token: 0x0400402F RID: 16431
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04004030 RID: 16432
		public int EntityId;

		// Token: 0x04004031 RID: 16433
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;

		// Token: 0x04004032 RID: 16434
		public ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition;

		// Token: 0x04004033 RID: 16435
		public ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition;

		// Token: 0x04004034 RID: 16436
		public ITakePhoto2TargetPartCondition TargetPartCondition;
	}
}
