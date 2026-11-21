using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002C5 RID: 709
	public class IContinuesVariableSpeedMovementSpline_SetValue
	{
		// Token: 0x04000C37 RID: 3127
		public ESplineType Type;

		// Token: 0x04000C38 RID: 3128
		public int? TransitionSpeed;

		// Token: 0x04000C39 RID: 3129
		[Nullable(2)]
		public ITimePathConfig EntireTimePathConfig;

		// Token: 0x04000C3A RID: 3130
		public EMoveCircleMode? CircleMode;

		// Token: 0x04000C3B RID: 3131
		public List<IContinuesVariableSpeedSplinePoint> Points;
	}
}
