using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6F RID: 7279
	public class INpcLookAtConfig_SetValue
	{
		// Token: 0x04005EB5 RID: 24245
		[Nullable(1)]
		public INpcLookAtTypeBase Target;

		// Token: 0x04005EB6 RID: 24246
		public bool? IsKeepOverAngle;

		// Token: 0x04005EB7 RID: 24247
		public float MaxDistance;

		// Token: 0x04005EB8 RID: 24248
		public float MaxAngle;
	}
}
