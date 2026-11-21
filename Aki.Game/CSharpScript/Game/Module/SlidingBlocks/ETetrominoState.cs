using System;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B30 RID: 15152
	public enum ETetrominoState
	{
		// Token: 0x0401547A RID: 87162
		Init,
		// Token: 0x0401547B RID: 87163
		Aiming,
		// Token: 0x0401547C RID: 87164
		WaitFallingEvent,
		// Token: 0x0401547D RID: 87165
		InitFallData,
		// Token: 0x0401547E RID: 87166
		Falling,
		// Token: 0x0401547F RID: 87167
		PlayLockEffect,
		// Token: 0x04015480 RID: 87168
		Lock
	}
}
