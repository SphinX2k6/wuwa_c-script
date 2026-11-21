using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000602 RID: 1538
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnVillageInfr_SetValue
	{
		// Token: 0x040016D5 RID: 5845
		public ENpcUiInteractType Type;

		// Token: 0x040016D6 RID: 5846
		public IMontageConfig EnterMontage;

		// Token: 0x040016D7 RID: 5847
		public IMontageConfig DeliverSuccessMontage;

		// Token: 0x040016D8 RID: 5848
		public IMontageConfig CompleteMontage;

		// Token: 0x040016D9 RID: 5849
		public PlayFlow EnterFlow;

		// Token: 0x040016DA RID: 5850
		public PlayFlow DeliverSuccessFlow;

		// Token: 0x040016DB RID: 5851
		public PlayFlow CompleteFlow;
	}
}
