using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000295 RID: 661
	public class ICommonRotationConfig_SetValue
	{
		// Token: 0x04000B6F RID: 2927
		public ERotationType Type;

		// Token: 0x04000B70 RID: 2928
		public float Time;

		// Token: 0x04000B71 RID: 2929
		public float? Cd;

		// Token: 0x04000B72 RID: 2930
		[Nullable(2)]
		public string Curve;
	}
}
