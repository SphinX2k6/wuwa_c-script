using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200672E RID: 26414
	[NullableContext(1)]
	[Nullable(0)]
	public class IDropPoolRuntime
	{
		// Token: 0x04022593 RID: 140691
		public int PoolId;

		// Token: 0x04022594 RID: 140692
		public double LastSpawnTime;

		// Token: 0x04022595 RID: 140693
		public DropCatchGameplayAttribute SpawnTimeInterval;

		// Token: 0x04022596 RID: 140694
		public double LastSpawnPosX;

		// Token: 0x04022597 RID: 140695
		public double SpawnPosInterval;

		// Token: 0x04022598 RID: 140696
		public IAliasTable AliasTable;

		// Token: 0x04022599 RID: 140697
		public List<double> TimeRange = new List<double>();
	}
}
