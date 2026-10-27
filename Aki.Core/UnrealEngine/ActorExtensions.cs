using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000113 RID: 275
	public static class ActorExtensions
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00033855 File Offset: 0x00031A55
		[NullableContext(1)]
		public static bool D_K2_SetActorTransform(this AActor actor, in FTransformDouble newTransform, bool bSweep, [Nullable(2)] FHitResult sweepHitResult, bool bTeleport)
		{
			return actor.D_K2_SetActorTransform(newTransform, bSweep, ref sweepHitResult, bTeleport);
		}
	}
}
