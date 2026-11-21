using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002160 RID: 8544
	public class ITalkEffectPlay_SetValue
	{
		// Token: 0x04006B34 RID: 27444
		public ETalkEffectActionType Type;

		// Token: 0x04006B35 RID: 27445
		public ITalkCommonEffect Effect;

		// Token: 0x04006B36 RID: 27446
		public bool? KeepPlay;

		// Token: 0x04006B37 RID: 27447
		[Nullable(2)]
		public string EffectKey;

		// Token: 0x04006B38 RID: 27448
		public float? DelayTime;
	}
}
