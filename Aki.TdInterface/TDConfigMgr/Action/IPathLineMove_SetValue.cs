using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CC9 RID: 7369
	[NullableContext(2)]
	[Nullable(0)]
	public class IPathLineMove_SetValue
	{
		// Token: 0x04005FA1 RID: 24481
		public ESplineMovePattern Type;

		// Token: 0x04005FA2 RID: 24482
		public float? MaxOffsetDistance;

		// Token: 0x04005FA3 RID: 24483
		public bool? IsOneWay;

		// Token: 0x04005FA4 RID: 24484
		public float? LayerVerticalLimit;

		// Token: 0x04005FA5 RID: 24485
		public bool? DynamicGravity;

		// Token: 0x04005FA6 RID: 24486
		public float? GravitySwitchAngularVelocity;

		// Token: 0x04005FA7 RID: 24487
		public int? AutoExitDistance;

		// Token: 0x04005FA8 RID: 24488
		public IPathLineFacingType FacingConfig;

		// Token: 0x04005FA9 RID: 24489
		public string SplineMoveConfigDaPath;

		// Token: 0x04005FAA RID: 24490
		public bool? IsAdaptiveClimbInput;

		// Token: 0x04005FAB RID: 24491
		public bool? IsDisableStopAnim;

		// Token: 0x04005FAC RID: 24492
		public bool? IsAllowEarlyExitClimb;
	}
}
