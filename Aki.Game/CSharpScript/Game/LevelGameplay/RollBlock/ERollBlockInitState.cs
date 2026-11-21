using System;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02005C00 RID: 23552
	public enum ERollBlockInitState
	{
		// Token: 0x0401E8DD RID: 125149
		None,
		// Token: 0x0401E8DE RID: 125150
		Enter,
		// Token: 0x0401E8DF RID: 125151
		WaitEntitiesCreate,
		// Token: 0x0401E8E0 RID: 125152
		WaitSceneItemLoadCompleted,
		// Token: 0x0401E8E1 RID: 125153
		HandleBirthEffect,
		// Token: 0x0401E8E2 RID: 125154
		WaitGuideGroupFinished,
		// Token: 0x0401E8E3 RID: 125155
		WaitGameplayReadyResponse,
		// Token: 0x0401E8E4 RID: 125156
		AllCompleted
	}
}
