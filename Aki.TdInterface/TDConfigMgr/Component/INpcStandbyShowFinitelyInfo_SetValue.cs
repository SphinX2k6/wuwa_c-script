using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200057D RID: 1405
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcStandbyShowFinitelyInfo_SetValue
	{
		// Token: 0x04001477 RID: 5239
		public string Montage;

		// Token: 0x04001478 RID: 5240
		public IMontageId RegisteredMontageId;

		// Token: 0x04001479 RID: 5241
		public int? FaceExpressionId;

		// Token: 0x0400147A RID: 5242
		public int Time;

		// Token: 0x0400147B RID: 5243
		public IIgnoreEntityIdsCollision IgnoreEntityCollision;
	}
}
