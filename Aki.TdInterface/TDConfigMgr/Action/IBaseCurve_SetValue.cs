using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001982 RID: 6530
	public class IBaseCurve_SetValue
	{
		// Token: 0x040057D5 RID: 22485
		public EBaseCurveType Type;

		// Token: 0x040057D6 RID: 22486
		public float N;

		// Token: 0x040057D7 RID: 22487
		[Nullable(2)]
		public string CurveAsset;
	}
}
