using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006979 RID: 27001
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnDestructibleStoneTrackTargetWhileRotate : ILevelEventBlueprintToSpawnType
	{
		// Token: 0x04023025 RID: 143397
		public EBpTypeName? DestructibleStoneBlueprintType;

		// Token: 0x04023026 RID: 143398
		public EBpTypeName? TrackTargetWhileRotateBlueprintType;

		// Token: 0x04023027 RID: 143399
		public FTransformDouble StartTransform;

		// Token: 0x04023028 RID: 143400
		public APawn TargetToTrack;

		// Token: 0x04023029 RID: 143401
		public IFauxPhysicsRotateParam RotateParam;

		// Token: 0x0402302A RID: 143402
		public int DamageAmount;

		// Token: 0x0402302B RID: 143403
		[Nullable(2)]
		public Action Callback;
	}
}
