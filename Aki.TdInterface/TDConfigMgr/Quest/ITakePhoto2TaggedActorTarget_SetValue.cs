using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001175 RID: 4469
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TaggedActorTarget_SetValue
	{
		// Token: 0x04003CED RID: 15597
		public ETakePhoto2TargetType Type;

		// Token: 0x04003CEE RID: 15598
		public bool? IsOptionalTarget;

		// Token: 0x04003CEF RID: 15599
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04003CF0 RID: 15600
		[Nullable(1)]
		public string Tag;

		// Token: 0x04003CF1 RID: 15601
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;

		// Token: 0x04003CF2 RID: 15602
		public int TargetSatisfiedCount;
	}
}
