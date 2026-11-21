using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200199C RID: 6556
	public class IBlendFunction_SetValue
	{
		// Token: 0x04005803 RID: 22531
		public EViewTargetBlendFunction Type;

		// Token: 0x04005804 RID: 22532
		public float BlendExp;

		// Token: 0x04005805 RID: 22533
		[Nullable(2)]
		public string CurveAsset;
	}
}
