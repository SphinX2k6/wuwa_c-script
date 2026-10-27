using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200116D RID: 4461
	[NullableContext(2)]
	[Nullable(0)]
	public class ITakePhoto2EntityTarget_SetValue
	{
		// Token: 0x04003CCE RID: 15566
		public ETakePhoto2TargetType Type;

		// Token: 0x04003CCF RID: 15567
		public bool? IsOptionalTarget;

		// Token: 0x04003CD0 RID: 15568
		public ITakePhoto2TargetCameraDistanceCondition TargetCameraDistanceCondition;

		// Token: 0x04003CD1 RID: 15569
		public int EntityId;

		// Token: 0x04003CD2 RID: 15570
		public ITakePhoto2TargetPosByRangeCondition TargetPosCondition;

		// Token: 0x04003CD3 RID: 15571
		public ITakePhoto2TargetPlayMontageCondition TargetPlayMontageCondition;

		// Token: 0x04003CD4 RID: 15572
		public ITakePhoto2TargetAnsTagCondition TargetAnsTagCondition;

		// Token: 0x04003CD5 RID: 15573
		public ITakePhoto2TargetPartCondition TargetPartCondition;
	}
}
