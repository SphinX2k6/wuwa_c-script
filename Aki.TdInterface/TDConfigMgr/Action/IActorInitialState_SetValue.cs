using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018FC RID: 6396
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorInitialState_SetValue
	{
		// Token: 0x04005523 RID: 21795
		public IActorInitialMontage InitialMontage;

		// Token: 0x04005524 RID: 21796
		public IActorLookAtData InitialLookAt;

		// Token: 0x04005525 RID: 21797
		public IActorInitialEffect InitialEffects;

		// Token: 0x04005526 RID: 21798
		public int? InitialFaceExpressionId;
	}
}
