using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A7 RID: 4775
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2PhotoTargetEntityTarget_SetValue
	{
		// Token: 0x04004041 RID: 16449
		public ETakePhoto2TargetType Type;

		// Token: 0x04004042 RID: 16450
		public bool? IsOptionalTarget;

		// Token: 0x04004043 RID: 16451
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04004044 RID: 16452
		public int EntityId;

		// Token: 0x04004045 RID: 16453
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;
	}
}
