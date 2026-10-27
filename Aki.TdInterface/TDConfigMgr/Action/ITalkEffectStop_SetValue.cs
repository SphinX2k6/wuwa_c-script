using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F29 RID: 7977
	public class ITalkEffectStop_SetValue
	{
		// Token: 0x0400654C RID: 25932
		public ETalkEffectActionType Type;

		// Token: 0x0400654D RID: 25933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> EffectKeys;

		// Token: 0x0400654E RID: 25934
		public float? DelayTime;

		// Token: 0x0400654F RID: 25935
		public bool? ImmediatelyDestroy;
	}
}
