using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F1 RID: 1265
	public class IIntervalSplineSpawn_SetValue
	{
		// Token: 0x040012D2 RID: 4818
		public EPathDrivenActorSpawnType Type;

		// Token: 0x040012D3 RID: 4819
		public string ActorBlueprintPath;

		// Token: 0x040012D4 RID: 4820
		public IPathDrivenActorSplineMove MoveMode;

		// Token: 0x040012D5 RID: 4821
		public float SpawnInterval;

		// Token: 0x040012D6 RID: 4822
		public int? MaxActiveCount;

		// Token: 0x040012D7 RID: 4823
		public float? MaxSpawnInterval;

		// Token: 0x040012D8 RID: 4824
		[Nullable(2)]
		public IPathDrivenActorInitialSpawnConfig InitialSpawnConfig;

		// Token: 0x040012D9 RID: 4825
		[Nullable(2)]
		public IIntervalSplineSpawnAllActorAudio AudioConfig;
	}
}
