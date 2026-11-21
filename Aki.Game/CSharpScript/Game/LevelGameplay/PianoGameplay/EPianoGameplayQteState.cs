using System;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C1B RID: 23579
	[EnumExtensions]
	public enum EPianoGameplayQteState
	{
		// Token: 0x0401E9C0 RID: 125376
		Idle,
		// Token: 0x0401E9C1 RID: 125377
		ShowKey,
		// Token: 0x0401E9C2 RID: 125378
		Judge,
		// Token: 0x0401E9C3 RID: 125379
		JudgeFail,
		// Token: 0x0401E9C4 RID: 125380
		JudgeSuccess,
		// Token: 0x0401E9C5 RID: 125381
		WaitRecover,
		// Token: 0x0401E9C6 RID: 125382
		Recover
	}
}
