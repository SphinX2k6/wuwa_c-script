using System;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Process
{
	// Token: 0x0200425B RID: 16987
	public enum EPlayingCardProcessState
	{
		// Token: 0x040173F4 RID: 95220
		None,
		// Token: 0x040173F5 RID: 95221
		TimeStart,
		// Token: 0x040173F6 RID: 95222
		OwnChangeCard,
		// Token: 0x040173F7 RID: 95223
		BothDrawCard,
		// Token: 0x040173F8 RID: 95224
		OpponentTimeStart,
		// Token: 0x040173F9 RID: 95225
		OpponentPlaying,
		// Token: 0x040173FA RID: 95226
		GameOverByOpponent,
		// Token: 0x040173FB RID: 95227
		OwnTimeStart,
		// Token: 0x040173FC RID: 95228
		ShowOwnCoreCard,
		// Token: 0x040173FD RID: 95229
		OwnPlaying,
		// Token: 0x040173FE RID: 95230
		TimeEnd,
		// Token: 0x040173FF RID: 95231
		JumpLoading
	}
}
