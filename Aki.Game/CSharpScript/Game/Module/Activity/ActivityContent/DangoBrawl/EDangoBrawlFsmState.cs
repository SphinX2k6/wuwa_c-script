using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006775 RID: 26485
	public enum EDangoBrawlFsmState
	{
		// Token: 0x04022799 RID: 141209
		None,
		// Token: 0x0402279A RID: 141210
		GameStart,
		// Token: 0x0402279B RID: 141211
		ShopState,
		// Token: 0x0402279C RID: 141212
		TrashTalkState,
		// Token: 0x0402279D RID: 141213
		LoadingBattle,
		// Token: 0x0402279E RID: 141214
		FightingState,
		// Token: 0x0402279F RID: 141215
		RoundSettle,
		// Token: 0x040227A0 RID: 141216
		FinalSettle,
		// Token: 0x040227A1 RID: 141217
		GameExit
	}
}
