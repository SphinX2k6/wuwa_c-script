using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200058B RID: 1419
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcUiInteractOnGramophone_SetValue
	{
		// Token: 0x040014DA RID: 5338
		public ENpcUiInteractType Type;

		// Token: 0x040014DB RID: 5339
		public string EnterMontage;

		// Token: 0x040014DC RID: 5340
		public string StandByMontage;

		// Token: 0x040014DD RID: 5341
		public string SwitchMusicMontage;

		// Token: 0x040014DE RID: 5342
		public string ExitMontage;

		// Token: 0x040014DF RID: 5343
		[Nullable(2)]
		public PlayFlow EnterFlow;

		// Token: 0x040014E0 RID: 5344
		[Nullable(2)]
		public PlayFlow FailedFlow;

		// Token: 0x040014E1 RID: 5345
		[Nullable(2)]
		public PlayFlow SuccessFlow;
	}
}
