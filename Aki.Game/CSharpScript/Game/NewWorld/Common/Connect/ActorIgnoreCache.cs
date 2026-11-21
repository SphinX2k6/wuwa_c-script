using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Connect
{
	// Token: 0x020061F9 RID: 25081
	internal sealed class ActorIgnoreCache
	{
		// Token: 0x0401FE3F RID: 130623
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x0401FE40 RID: 130624
		[Nullable(1)]
		public readonly List<AActor> Actors = new List<AActor>();

		// Token: 0x0401FE41 RID: 130625
		public bool Ready;
	}
}
