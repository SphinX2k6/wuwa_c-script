using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AD5 RID: 23253
	[NullableContext(1)]
	[Nullable(0)]
	public class ISpawnDestructibleStoneTrackTargetWhileRotate : ILevelEventBlueprintToSpawnType
	{
		// Token: 0x0401E20F RID: 123407
		public EBpTypeName? DestructibleStoneBlueprintType;

		// Token: 0x0401E210 RID: 123408
		public EBpTypeName? TrackTargetWhileRotateBlueprintType;

		// Token: 0x0401E211 RID: 123409
		public FTransformDouble StartTransform;

		// Token: 0x0401E212 RID: 123410
		public APawn TargetToTrack;

		// Token: 0x0401E213 RID: 123411
		public IFauxPhysicsRotateParam RotateParam;

		// Token: 0x0401E214 RID: 123412
		public int DamageAmount;

		// Token: 0x0401E215 RID: 123413
		[Nullable(2)]
		public Action Callback;
	}
}
