using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000599 RID: 1433
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcUiInteractOnVillageInfr_SetValue
	{
		// Token: 0x04001567 RID: 5479
		public ENpcUiInteractType Type;

		// Token: 0x04001568 RID: 5480
		public IMontageConfig EnterMontage;

		// Token: 0x04001569 RID: 5481
		public IMontageConfig DeliverSuccessMontage;

		// Token: 0x0400156A RID: 5482
		public IMontageConfig CompleteMontage;

		// Token: 0x0400156B RID: 5483
		public PlayFlow EnterFlow;

		// Token: 0x0400156C RID: 5484
		public PlayFlow DeliverSuccessFlow;

		// Token: 0x0400156D RID: 5485
		public PlayFlow CompleteFlow;
	}
}
