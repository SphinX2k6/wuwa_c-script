using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A0F RID: 6671
	public class IEntityLookAtPerform_SetValue
	{
		// Token: 0x0400587D RID: 22653
		public int EntityId;

		// Token: 0x0400587E RID: 22654
		public int? FaceExpressionId;

		// Token: 0x0400587F RID: 22655
		public int? OverlapMontageId;

		// Token: 0x04005880 RID: 22656
		[Nullable(2)]
		public ILookAtPerformOverlapMontageConfig OverlapMontageConfig;
	}
}
