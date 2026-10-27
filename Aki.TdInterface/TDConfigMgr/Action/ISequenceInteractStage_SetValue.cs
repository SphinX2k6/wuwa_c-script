using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E03 RID: 7683
	public class ISequenceInteractStage_SetValue
	{
		// Token: 0x0400626F RID: 25199
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IInteractEffect> EnterStageEffects;

		// Token: 0x04006270 RID: 25200
		[Nullable(1)]
		public List<IInteractPoint> InteractPoints;

		// Token: 0x04006271 RID: 25201
		[Nullable(2)]
		public string UiTipText;

		// Token: 0x04006272 RID: 25202
		public bool? IsResetAfterStageEnd;
	}
}
