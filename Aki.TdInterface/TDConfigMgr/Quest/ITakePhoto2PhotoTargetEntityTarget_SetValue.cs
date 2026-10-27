using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116F RID: 4463
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2PhotoTargetEntityTarget_SetValue
	{
		// Token: 0x04003CDC RID: 15580
		public ETakePhoto2TargetType Type;

		// Token: 0x04003CDD RID: 15581
		public bool? IsOptionalTarget;

		// Token: 0x04003CDE RID: 15582
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04003CDF RID: 15583
		public int EntityId;

		// Token: 0x04003CE0 RID: 15584
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;
	}
}
