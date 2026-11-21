using System;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FF2 RID: 12274
	internal enum ETetrisDragCompleteResult
	{
		// Token: 0x0400F57D RID: 62845
		Ignored,
		// Token: 0x0400F57E RID: 62846
		Cancelled,
		// Token: 0x0400F57F RID: 62847
		OutsideBoard,
		// Token: 0x0400F580 RID: 62848
		Rotating,
		// Token: 0x0400F581 RID: 62849
		NoDropTarget,
		// Token: 0x0400F582 RID: 62850
		DropRequested,
		// Token: 0x0400F583 RID: 62851
		IsAnimating,
		// Token: 0x0400F584 RID: 62852
		GameOver
	}
}
