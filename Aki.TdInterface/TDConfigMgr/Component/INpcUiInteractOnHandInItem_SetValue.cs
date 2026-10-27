using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058D RID: 1421
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnHandInItem_SetValue
	{
		// Token: 0x040014E8 RID: 5352
		public ENpcUiInteractType Type;

		// Token: 0x040014E9 RID: 5353
		public string EnterMontage;

		// Token: 0x040014EA RID: 5354
		public string StandByMontage;

		// Token: 0x040014EB RID: 5355
		public string HandInFailedMontage;

		// Token: 0x040014EC RID: 5356
		[Nullable(2)]
		public PlayFlow EnterFlow;

		// Token: 0x040014ED RID: 5357
		[Nullable(2)]
		public PlayFlow HandInFailedFlow;
	}
}
