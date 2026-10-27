using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A11 RID: 6673
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerformRender_SetValue
	{
		// Token: 0x04005887 RID: 22663
		public int EntityId;

		// Token: 0x04005888 RID: 22664
		public int? FaceExpressionId;

		// Token: 0x04005889 RID: 22665
		public IMontageId OverlapMontageId;

		// Token: 0x0400588A RID: 22666
		public ILookAtPerformOverlapMontageConfig OverlapMontageConfig;
	}
}
