using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001811 RID: 6161
	public class IBlendFunction_SetValue
	{
		// Token: 0x040053B8 RID: 21432
		public EViewTargetBlendFunction Type;

		// Token: 0x040053B9 RID: 21433
		public float BlendExp;

		// Token: 0x040053BA RID: 21434
		[Nullable(2)]
		public string CurveAsset;
	}
}
