using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F27 RID: 7975
	public class ITalkEffectPlay_SetValue
	{
		// Token: 0x04006545 RID: 25925
		public ETalkEffectActionType Type;

		// Token: 0x04006546 RID: 25926
		[Nullable(1)]
		public ITalkCommonEffect Effect;

		// Token: 0x04006547 RID: 25927
		public bool? KeepPlay;

		// Token: 0x04006548 RID: 25928
		[Nullable(2)]
		public string EffectKey;

		// Token: 0x04006549 RID: 25929
		public float? DelayTime;
	}
}
