using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Process
{
	// Token: 0x0200528B RID: 21131
	public enum EPlayingCardProcessState
	{
		// Token: 0x0401C9BF RID: 117183
		None,
		// Token: 0x0401C9C0 RID: 117184
		TimeStart,
		// Token: 0x0401C9C1 RID: 117185
		OwnChangeCard,
		// Token: 0x0401C9C2 RID: 117186
		BothDrawCard,
		// Token: 0x0401C9C3 RID: 117187
		OpponentTimeStart,
		// Token: 0x0401C9C4 RID: 117188
		OpponentPlaying,
		// Token: 0x0401C9C5 RID: 117189
		GameOverByOpponent,
		// Token: 0x0401C9C6 RID: 117190
		OwnTimeStart,
		// Token: 0x0401C9C7 RID: 117191
		ShowOwnCoreCard,
		// Token: 0x0401C9C8 RID: 117192
		OwnPlaying,
		// Token: 0x0401C9C9 RID: 117193
		TimeEnd,
		// Token: 0x0401C9CA RID: 117194
		JumpLoading
	}
}
