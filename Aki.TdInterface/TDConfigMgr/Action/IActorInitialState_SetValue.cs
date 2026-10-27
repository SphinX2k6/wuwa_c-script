using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200177B RID: 6011
	[NullableContext(2)]
	[Nullable(0)]
	public class IActorInitialState_SetValue
	{
		// Token: 0x040050ED RID: 20717
		public IActorInitialMontage InitialMontage;

		// Token: 0x040050EE RID: 20718
		public IActorLookAtData InitialLookAt;

		// Token: 0x040050EF RID: 20719
		public IActorInitialEffect InitialEffects;

		// Token: 0x040050F0 RID: 20720
		public int? InitialFaceExpressionId;
	}
}
