using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002162 RID: 8546
	public class ITalkEffectStop_SetValue
	{
		// Token: 0x04006B3B RID: 27451
		public ETalkEffectActionType Type;

		// Token: 0x04006B3C RID: 27452
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> EffectKeys;

		// Token: 0x04006B3D RID: 27453
		public float? DelayTime;

		// Token: 0x04006B3E RID: 27454
		public bool? ImmediatelyDestroy;
	}
}
