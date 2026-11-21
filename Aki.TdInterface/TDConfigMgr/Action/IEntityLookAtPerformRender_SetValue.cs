using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001BA6 RID: 7078
	[NullableContext(2)]
	[Nullable(0)]
	public class IEntityLookAtPerformRender_SetValue
	{
		// Token: 0x04005CEC RID: 23788
		public int EntityId;

		// Token: 0x04005CED RID: 23789
		public int? FaceExpressionId;

		// Token: 0x04005CEE RID: 23790
		public IMontageId OverlapMontageId;

		// Token: 0x04005CEF RID: 23791
		public ILookAtPerformOverlapMontageConfig OverlapMontageConfig;
	}
}
