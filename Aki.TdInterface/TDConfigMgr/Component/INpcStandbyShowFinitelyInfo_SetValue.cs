using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005E6 RID: 1510
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowFinitelyInfo_SetValue
	{
		// Token: 0x040015E5 RID: 5605
		public string Montage;

		// Token: 0x040015E6 RID: 5606
		public IMontageId RegisteredMontageId;

		// Token: 0x040015E7 RID: 5607
		public int? FaceExpressionId;

		// Token: 0x040015E8 RID: 5608
		public int Time;

		// Token: 0x040015E9 RID: 5609
		public IIgnoreEntityIdsCollision IgnoreEntityCollision;
	}
}
