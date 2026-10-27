using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C09 RID: 7177
	public class IMontageParam_SetValue
	{
		// Token: 0x04005D9F RID: 23967
		[Nullable(1)]
		public IMontageId MontageId;

		// Token: 0x04005DA0 RID: 23968
		public bool? IsLoop;

		// Token: 0x04005DA1 RID: 23969
		public bool? KeepPose;

		// Token: 0x04005DA2 RID: 23970
		public float? DelayTime;
	}
}
