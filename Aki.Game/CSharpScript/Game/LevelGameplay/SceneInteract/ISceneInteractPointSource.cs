using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BD5 RID: 23509
	[NullableContext(1)]
	public interface ISceneInteractPointSource
	{
		// Token: 0x06039C60 RID: 236640
		IReadOnlyList<ISceneInteractPoint> GetInteractPoints();
	}
}
