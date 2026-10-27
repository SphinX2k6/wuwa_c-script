using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A78 RID: 27256
	[NullableContext(1)]
	public interface ISceneInteractPointSource
	{
		// Token: 0x06043C12 RID: 277522
		IReadOnlyList<ISceneInteractPoint> GetInteractPoints();
	}
}
