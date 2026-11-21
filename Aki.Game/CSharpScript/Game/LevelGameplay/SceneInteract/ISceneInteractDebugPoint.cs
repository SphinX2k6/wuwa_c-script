using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BCE RID: 23502
	[NullableContext(1)]
	public interface ISceneInteractDebugPoint
	{
		// Token: 0x06039C30 RID: 236592
		[NullableContext(2)]
		Vector GetLocation();

		// Token: 0x06039C31 RID: 236593
		int GetEntityId();

		// Token: 0x06039C32 RID: 236594
		string BuildLockWeightDebugText(Vector charLoc);
	}
}
