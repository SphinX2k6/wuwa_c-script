using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E05 RID: 7685
	public class ISequenceUnlockPoints_SetValue
	{
		// Token: 0x04006277 RID: 25207
		public EInteractUnlockType Type;

		// Token: 0x04006278 RID: 25208
		[Nullable(1)]
		public List<ISequenceInteractStage> Stages;
	}
}
