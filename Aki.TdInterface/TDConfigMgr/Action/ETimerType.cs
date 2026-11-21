using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001854 RID: 6228
	[EnumExtensions]
	public enum ETimerType
	{
		// Token: 0x04005340 RID: 21312
		CountDownChallenge,
		// Token: 0x04005341 RID: 21313
		[EnumStringMember("GameStartCountDown")]
		PlayStartCountDown,
		// Token: 0x04005342 RID: 21314
		PublicTime,
		// Token: 0x04005343 RID: 21315
		WaitTime,
		// Token: 0x04005344 RID: 21316
		BehaviorTreeTimer1,
		// Token: 0x04005345 RID: 21317
		BehaviorTreeTimer2,
		// Token: 0x04005346 RID: 21318
		BehaviorTreeTimer3,
		// Token: 0x04005347 RID: 21319
		BehaviorTreeTimer4,
		// Token: 0x04005348 RID: 21320
		BehaviorTreeTimer5
	}
}
