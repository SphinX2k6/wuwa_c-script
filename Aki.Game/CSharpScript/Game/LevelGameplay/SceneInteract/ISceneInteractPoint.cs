using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BCD RID: 23501
	[NullableContext(2)]
	public interface ISceneInteractPoint
	{
		// Token: 0x06039C2B RID: 236587
		void Init();

		// Token: 0x06039C2C RID: 236588
		void Clear();

		// Token: 0x06039C2D RID: 236589
		ESceneInteractSearchStrategyType? GetPointStrategyType();

		// Token: 0x06039C2E RID: 236590
		Vector GetLocation();

		// Token: 0x06039C2F RID: 236591
		ESceneInteractType GetInteractType();
	}
}
