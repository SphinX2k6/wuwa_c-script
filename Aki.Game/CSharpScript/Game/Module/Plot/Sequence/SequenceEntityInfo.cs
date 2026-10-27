using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02005013 RID: 20499
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceEntityInfo
	{
		// Token: 0x0603477C RID: 214908 RVA: 0x00C5BB4C File Offset: 0x00C59D4C
		[NullableContext(2)]
		public SequenceEntityInfo(int moveCompDisableHandle = -1, int ueMoveCompDisableHandle = -1, EMovementMode cacheMovementMode = EMovementMode.MOVE_None, bool cacheMovementSync = false, Vector cacheLocation = null, Rotator cacheRotation = null, bool cacheAiEnable = false, bool cacheDisableHumanIk = false)
		{
			this.MoveCompDisableHandle = moveCompDisableHandle;
			this.UeMoveCompDisableHandle = ueMoveCompDisableHandle;
			this.CacheMovementMode = cacheMovementMode;
			this.CacheMovementSync = cacheMovementSync;
			this.CacheLocation = (cacheLocation ?? Vector.Create());
			this.CacheRotation = (cacheRotation ?? Rotator.Create());
			this.CacheAiEnable = cacheAiEnable;
			this.CacheDisableHumanIk = cacheDisableHumanIk;
		}

		// Token: 0x0401BF23 RID: 114467
		public int MoveCompDisableHandle = -1;

		// Token: 0x0401BF24 RID: 114468
		public int UeMoveCompDisableHandle = -1;

		// Token: 0x0401BF25 RID: 114469
		public EMovementMode CacheMovementMode;

		// Token: 0x0401BF26 RID: 114470
		public bool CacheMovementSync;

		// Token: 0x0401BF27 RID: 114471
		public Vector CacheLocation = Vector.Create();

		// Token: 0x0401BF28 RID: 114472
		public Rotator CacheRotation = Rotator.Create();

		// Token: 0x0401BF29 RID: 114473
		public bool CacheAiEnable;

		// Token: 0x0401BF2A RID: 114474
		public bool CacheDisableHumanIk;
	}
}
