using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A71 RID: 27249
	[NullableContext(1)]
	public interface ISceneInteractDebugPoint
	{
		// Token: 0x06043BE2 RID: 277474
		[NullableContext(2)]
		Vector GetLocation();

		// Token: 0x06043BE3 RID: 277475
		int GetEntityId();

		// Token: 0x06043BE4 RID: 277476
		string BuildLockWeightDebugText(Vector charLoc);
	}
}
