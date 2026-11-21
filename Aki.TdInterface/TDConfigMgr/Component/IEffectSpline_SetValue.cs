using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200033B RID: 827
	public class IEffectSpline_SetValue
	{
		// Token: 0x04000DC5 RID: 3525
		public ESplineType Type;

		// Token: 0x04000DC6 RID: 3526
		public string Effect;

		// Token: 0x04000DC7 RID: 3527
		public IEffectSplineCreationMode CreateOption;

		// Token: 0x04000DC8 RID: 3528
		public List<ICommonSplinePoint> Points;
	}
}
