using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A74 RID: 27252
	public abstract class SceneInteractPointFactory
	{
		// Token: 0x06043BE8 RID: 277480
		[NullableContext(1)]
		[return: Nullable(2)]
		public abstract ISceneInteractPoint Create(SceneInteractPointContext context);
	}
}
