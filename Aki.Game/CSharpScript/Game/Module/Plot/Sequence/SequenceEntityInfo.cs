using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence
{
	// Token: 0x02003FDD RID: 16349
	[NullableContext(1)]
	[Nullable(0)]
	public class SequenceEntityInfo
	{
		// Token: 0x0602961F RID: 169503 RVA: 0x00BA708C File Offset: 0x00BA528C
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

		// Token: 0x0401690C RID: 92428
		public int MoveCompDisableHandle = -1;

		// Token: 0x0401690D RID: 92429
		public int UeMoveCompDisableHandle = -1;

		// Token: 0x0401690E RID: 92430
		public EMovementMode CacheMovementMode;

		// Token: 0x0401690F RID: 92431
		public bool CacheMovementSync;

		// Token: 0x04016910 RID: 92432
		public Vector CacheLocation = Vector.Create();

		// Token: 0x04016911 RID: 92433
		public Rotator CacheRotation = Rotator.Create();

		// Token: 0x04016912 RID: 92434
		public bool CacheAiEnable;

		// Token: 0x04016913 RID: 92435
		public bool CacheDisableHumanIk;
	}
}
