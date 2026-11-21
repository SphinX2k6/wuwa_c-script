using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002036 RID: 8246
	public class ISequenceInteractStage_SetValue
	{
		// Token: 0x04006846 RID: 26694
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IInteractEffect> EnterStageEffects;

		// Token: 0x04006847 RID: 26695
		public List<IInteractPoint> InteractPoints;

		// Token: 0x04006848 RID: 26696
		[Nullable(2)]
		public string UiTipText;

		// Token: 0x04006849 RID: 26697
		public bool? IsResetAfterStageEnd;
	}
}
