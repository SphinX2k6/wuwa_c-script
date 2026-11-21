using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD1 RID: 23505
	public abstract class SceneInteractPointFactory
	{
		// Token: 0x06039C36 RID: 236598
		[NullableContext(1)]
		[return: Nullable(2)]
		public abstract ISceneInteractPoint Create(SceneInteractPointContext context);
	}
}
