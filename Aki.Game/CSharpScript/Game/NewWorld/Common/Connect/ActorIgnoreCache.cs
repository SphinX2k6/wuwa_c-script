using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Connect
{
	// Token: 0x02007078 RID: 28792
	internal sealed class ActorIgnoreCache
	{
		// Token: 0x04024B84 RID: 150404
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x04024B85 RID: 150405
		[Nullable(1)]
		public readonly List<AActor> Actors = new List<AActor>();

		// Token: 0x04024B86 RID: 150406
		public bool Ready;
	}
}
