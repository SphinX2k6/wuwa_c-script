using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000498 RID: 1176
	[NullableContext(1)]
	[Nullable(0)]
	public class IIntervalSplineSpawn_SetValue
	{
		// Token: 0x040011B0 RID: 4528
		public EPathDrivenActorSpawnType Type;

		// Token: 0x040011B1 RID: 4529
		public string ActorBlueprintPath;

		// Token: 0x040011B2 RID: 4530
		public IPathDrivenActorSplineMove MoveMode;

		// Token: 0x040011B3 RID: 4531
		public float SpawnInterval;

		// Token: 0x040011B4 RID: 4532
		public int? MaxActiveCount;

		// Token: 0x040011B5 RID: 4533
		public float? MaxSpawnInterval;

		// Token: 0x040011B6 RID: 4534
		[Nullable(2)]
		public IPathDrivenActorInitialSpawnConfig InitialSpawnConfig;

		// Token: 0x040011B7 RID: 4535
		[Nullable(2)]
		public IIntervalSplineSpawnAllActorAudio AudioConfig;
	}
}
