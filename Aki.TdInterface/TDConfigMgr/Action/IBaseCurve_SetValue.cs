using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017F9 RID: 6137
	public class IBaseCurve_SetValue
	{
		// Token: 0x0400538D RID: 21389
		public EBaseCurveType Type;

		// Token: 0x0400538E RID: 21390
		public float N;

		// Token: 0x0400538F RID: 21391
		[Nullable(2)]
		public string CurveAsset;
	}
}
