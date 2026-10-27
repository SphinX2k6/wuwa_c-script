using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200117D RID: 4477
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2TargetEntityType_SetValue
	{
		// Token: 0x04003D0C RID: 15628
		public ETakePhoto2TargetType Type;

		// Token: 0x04003D0D RID: 15629
		public bool? IsOptionalTarget;

		// Token: 0x04003D0E RID: 15630
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04003D0F RID: 15631
		[Nullable(1)]
		public IEntityCategory EntityCategory;

		// Token: 0x04003D10 RID: 15632
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;

		// Token: 0x04003D11 RID: 15633
		public ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition;

		// Token: 0x04003D12 RID: 15634
		public ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition;

		// Token: 0x04003D13 RID: 15635
		public int TargetSatisfiedCount;
	}
}
