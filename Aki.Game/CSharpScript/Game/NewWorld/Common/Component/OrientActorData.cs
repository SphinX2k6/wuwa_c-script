using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Common.Component
{
	// Token: 0x0200708D RID: 28813
	[NullableContext(1)]
	[Nullable(0)]
	internal class OrientActorData
	{
		// Token: 0x0604633D RID: 287549 RVA: 0x0118C6E5 File Offset: 0x0118A8E5
		public OrientActorData(AActor origin, BaseActorComponent target)
		{
			this.OriginActor = origin;
			this.TargetActor = target;
		}

		// Token: 0x04024C6F RID: 150639
		public AActor OriginActor;

		// Token: 0x04024C70 RID: 150640
		public BaseActorComponent TargetActor;
	}
}
