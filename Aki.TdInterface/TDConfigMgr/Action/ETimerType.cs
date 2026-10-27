using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016D9 RID: 5849
	[EnumExtensions]
	public enum ETimerType
	{
		// Token: 0x04004F16 RID: 20246
		CountDownChallenge,
		// Token: 0x04004F17 RID: 20247
		[EnumStringMember("GameStartCountDown")]
		PlayStartCountDown,
		// Token: 0x04004F18 RID: 20248
		PublicTime,
		// Token: 0x04004F19 RID: 20249
		WaitTime,
		// Token: 0x04004F1A RID: 20250
		BehaviorTreeTimer1,
		// Token: 0x04004F1B RID: 20251
		BehaviorTreeTimer2,
		// Token: 0x04004F1C RID: 20252
		BehaviorTreeTimer3,
		// Token: 0x04004F1D RID: 20253
		BehaviorTreeTimer4,
		// Token: 0x04004F1E RID: 20254
		BehaviorTreeTimer5
	}
}
