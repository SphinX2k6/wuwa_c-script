using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A70 RID: 27248
	[NullableContext(2)]
	public interface ISceneInteractPoint
	{
		// Token: 0x06043BDD RID: 277469
		void Init();

		// Token: 0x06043BDE RID: 277470
		void Clear();

		// Token: 0x06043BDF RID: 277471
		ESceneInteractSearchStrategyType? GetPointStrategyType();

		// Token: 0x06043BE0 RID: 277472
		Vector GetLocation();

		// Token: 0x06043BE1 RID: 277473
		ESceneInteractType GetInteractType();
	}
}
