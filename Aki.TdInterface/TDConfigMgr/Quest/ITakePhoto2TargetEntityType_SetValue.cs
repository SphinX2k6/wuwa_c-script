using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B7 RID: 4791
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TargetEntityType_SetValue
	{
		// Token: 0x04004074 RID: 16500
		public ETakePhoto2TargetType Type;

		// Token: 0x04004075 RID: 16501
		public bool? IsOptionalTarget;

		// Token: 0x04004076 RID: 16502
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04004077 RID: 16503
		[Nullable(0)]
		public IEntityCategory EntityCategory;

		// Token: 0x04004078 RID: 16504
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;

		// Token: 0x04004079 RID: 16505
		public ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition;

		// Token: 0x0400407A RID: 16506
		public ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition;

		// Token: 0x0400407B RID: 16507
		public int TargetSatisfiedCount;
	}
}
