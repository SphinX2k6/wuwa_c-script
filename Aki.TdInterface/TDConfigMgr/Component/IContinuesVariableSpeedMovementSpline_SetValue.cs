using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000282 RID: 642
	public class IContinuesVariableSpeedMovementSpline_SetValue
	{
		// Token: 0x04000B56 RID: 2902
		public ESplineType Type;

		// Token: 0x04000B57 RID: 2903
		public int? TransitionSpeed;

		// Token: 0x04000B58 RID: 2904
		[Nullable(2)]
		public ITimePathConfig EntireTimePathConfig;

		// Token: 0x04000B59 RID: 2905
		public EMoveCircleMode? CircleMode;

		// Token: 0x04000B5A RID: 2906
		[Nullable(1)]
		public List<IContinuesVariableSpeedSplinePoint> Points;
	}
}
