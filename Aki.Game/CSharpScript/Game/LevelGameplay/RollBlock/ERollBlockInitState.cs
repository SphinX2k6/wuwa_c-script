using System;

namespace CSharpScript.Game.LevelGamePlay.RollBlock
{
	// Token: 0x02006AA3 RID: 27299
	public enum ERollBlockInitState
	{
		// Token: 0x040236EB RID: 145131
		None,
		// Token: 0x040236EC RID: 145132
		Enter,
		// Token: 0x040236ED RID: 145133
		WaitEntitiesCreate,
		// Token: 0x040236EE RID: 145134
		WaitSceneItemLoadCompleted,
		// Token: 0x040236EF RID: 145135
		HandleBirthEffect,
		// Token: 0x040236F0 RID: 145136
		WaitGuideGroupFinished,
		// Token: 0x040236F1 RID: 145137
		WaitGameplayReadyResponse,
		// Token: 0x040236F2 RID: 145138
		AllCompleted
	}
}
