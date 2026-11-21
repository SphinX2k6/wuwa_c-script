using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA4 RID: 7076
	public class IEntityLookAtPerform_SetValue
	{
		// Token: 0x04005CE2 RID: 23778
		public int EntityId;

		// Token: 0x04005CE3 RID: 23779
		public int? FaceExpressionId;

		// Token: 0x04005CE4 RID: 23780
		public int? OverlapMontageId;

		// Token: 0x04005CE5 RID: 23781
		[Nullable(2)]
		public ILookAtPerformOverlapMontageConfig OverlapMontageConfig;
	}
}
