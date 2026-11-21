using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056C5 RID: 22213
	public enum EDangoBrawlFsmState
	{
		// Token: 0x0401CFF6 RID: 118774
		None,
		// Token: 0x0401CFF7 RID: 118775
		GameStart,
		// Token: 0x0401CFF8 RID: 118776
		ShopState,
		// Token: 0x0401CFF9 RID: 118777
		TrashTalkState,
		// Token: 0x0401CFFA RID: 118778
		LoadingBattle,
		// Token: 0x0401CFFB RID: 118779
		FightingState,
		// Token: 0x0401CFFC RID: 118780
		RoundSettle,
		// Token: 0x0401CFFD RID: 118781
		FinalSettle,
		// Token: 0x0401CFFE RID: 118782
		GameExit
	}
}
