using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A8C RID: 27276
	[NullableContext(1)]
	[Nullable(0)]
	public class ActorBinding
	{
		// Token: 0x06043C75 RID: 277621 RVA: 0x010970C8 File Offset: 0x010952C8
		public ActorBinding(AActor Actor)
		{
			this.Actor = Actor;
		}

		// Token: 0x06043C76 RID: 277622 RVA: 0x010970D7 File Offset: 0x010952D7
		public bool IsValid()
		{
			return this.Actor.IsValid();
		}

		// Token: 0x0402369A RID: 145050
		public readonly AActor Actor;
	}
}
