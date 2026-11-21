using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000113 RID: 275
	public static class ActorExtensions
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x00034231 File Offset: 0x00032431
		[NullableContext(1)]
		public static bool D_K2_SetActorTransform(this AActor actor, in FTransformDouble newTransform, bool bSweep, [Nullable(2)] FHitResult sweepHitResult, bool bTeleport)
		{
			return actor.D_K2_SetActorTransform(newTransform, bSweep, ref sweepHitResult, bTeleport);
		}
	}
}
