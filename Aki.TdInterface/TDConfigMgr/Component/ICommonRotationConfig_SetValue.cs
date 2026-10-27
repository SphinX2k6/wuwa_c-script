using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000252 RID: 594
	public class ICommonRotationConfig_SetValue
	{
		// Token: 0x04000A8E RID: 2702
		public ERotationType Type;

		// Token: 0x04000A8F RID: 2703
		public float Time;

		// Token: 0x04000A90 RID: 2704
		public float? Cd;

		// Token: 0x04000A91 RID: 2705
		[Nullable(2)]
		public string Curve;
	}
}
