using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BCF RID: 23503
	public interface IEntitySceneInteractPoint : ISceneInteractPoint
	{
		// Token: 0x06039C33 RID: 236595
		[NullableContext(1)]
		EntityHandle GetEntityHandle();

		// Token: 0x06039C34 RID: 236596
		[NullableContext(2)]
		AActor GetOwnerActor();
	}
}
