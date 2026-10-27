using System;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B86 RID: 19334
	public enum ETetrominoState
	{
		// Token: 0x0401AB26 RID: 109350
		Init,
		// Token: 0x0401AB27 RID: 109351
		Aiming,
		// Token: 0x0401AB28 RID: 109352
		WaitFallingEvent,
		// Token: 0x0401AB29 RID: 109353
		InitFallData,
		// Token: 0x0401AB2A RID: 109354
		Falling,
		// Token: 0x0401AB2B RID: 109355
		PlayLockEffect,
		// Token: 0x0401AB2C RID: 109356
		Lock
	}
}
