using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F4 RID: 756
	[NullableContext(1)]
	[Nullable(0)]
	public class IEffectSpline_SetValue
	{
		// Token: 0x04000CDB RID: 3291
		public ESplineType Type;

		// Token: 0x04000CDC RID: 3292
		public string Effect;

		// Token: 0x04000CDD RID: 3293
		public IEffectSplineCreationMode CreateOption;

		// Token: 0x04000CDE RID: 3294
		public List<ICommonSplinePoint> Points;
	}
}
