using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A72 RID: 27250
	public interface IEntitySceneInteractPoint : ISceneInteractPoint
	{
		// Token: 0x06043BE5 RID: 277477
		[NullableContext(1)]
		EntityHandle GetEntityHandle();

		// Token: 0x06043BE6 RID: 277478
		[NullableContext(2)]
		AActor GetOwnerActor();
	}
}
