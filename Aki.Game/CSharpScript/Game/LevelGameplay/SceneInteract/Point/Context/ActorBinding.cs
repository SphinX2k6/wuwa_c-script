using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BE9 RID: 23529
	[NullableContext(1)]
	[Nullable(0)]
	public class ActorBinding
	{
		// Token: 0x06039CC3 RID: 236739 RVA: 0x0103B91C File Offset: 0x01039B1C
		public ActorBinding(AActor Actor)
		{
			this.Actor = Actor;
		}

		// Token: 0x06039CC4 RID: 236740 RVA: 0x0103B92B File Offset: 0x01039B2B
		public bool IsValid()
		{
			return this.Actor.IsValid();
		}

		// Token: 0x0401E88C RID: 125068
		public readonly AActor Actor;
	}
}
