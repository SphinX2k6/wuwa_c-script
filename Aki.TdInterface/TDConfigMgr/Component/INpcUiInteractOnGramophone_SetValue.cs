using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005F4 RID: 1524
	public class INpcUiInteractOnGramophone_SetValue
	{
		// Token: 0x04001648 RID: 5704
		public ENpcUiInteractType Type;

		// Token: 0x04001649 RID: 5705
		public string EnterMontage;

		// Token: 0x0400164A RID: 5706
		public string StandByMontage;

		// Token: 0x0400164B RID: 5707
		public string SwitchMusicMontage;

		// Token: 0x0400164C RID: 5708
		public string ExitMontage;

		// Token: 0x0400164D RID: 5709
		[Nullable(2)]
		public PlayFlow EnterFlow;

		// Token: 0x0400164E RID: 5710
		[Nullable(2)]
		public PlayFlow FailedFlow;

		// Token: 0x0400164F RID: 5711
		[Nullable(2)]
		public PlayFlow SuccessFlow;
	}
}
