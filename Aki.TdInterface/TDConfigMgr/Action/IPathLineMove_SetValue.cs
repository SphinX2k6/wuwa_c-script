using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ED0 RID: 7888
	[NullableContext(2)]
	[Nullable(0)]
	public class IPathLineMove_SetValue
	{
		// Token: 0x040064FD RID: 25853
		public ESplineMovePattern Type;

		// Token: 0x040064FE RID: 25854
		public float? MaxOffsetDistance;

		// Token: 0x040064FF RID: 25855
		public bool? IsOneWay;

		// Token: 0x04006500 RID: 25856
		public float? LayerVerticalLimit;

		// Token: 0x04006501 RID: 25857
		public bool? DynamicGravity;

		// Token: 0x04006502 RID: 25858
		public float? GravitySwitchAngularVelocity;

		// Token: 0x04006503 RID: 25859
		public int? AutoExitDistance;

		// Token: 0x04006504 RID: 25860
		public IPathLineFacingType FacingConfig;

		// Token: 0x04006505 RID: 25861
		public string SplineMoveConfigDaPath;

		// Token: 0x04006506 RID: 25862
		public bool? IsAdaptiveClimbInput;

		// Token: 0x04006507 RID: 25863
		public bool? IsDisableStopAnim;

		// Token: 0x04006508 RID: 25864
		public bool? IsAllowEarlyExitClimb;
	}
}
