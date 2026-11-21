using System;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FF1 RID: 12273
	internal enum ETetrisDragCancelReason
	{
		// Token: 0x0400F570 RID: 62832
		Explicit,
		// Token: 0x0400F571 RID: 62833
		MissingPointerPosition,
		// Token: 0x0400F572 RID: 62834
		InvalidPointerPosition,
		// Token: 0x0400F573 RID: 62835
		InvalidHandShape,
		// Token: 0x0400F574 RID: 62836
		GameplayUnavailable,
		// Token: 0x0400F575 RID: 62837
		InputControllerUnavailable,
		// Token: 0x0400F576 RID: 62838
		InputOwnershipLost,
		// Token: 0x0400F577 RID: 62839
		ApplicationInactive,
		// Token: 0x0400F578 RID: 62840
		InputModeChanged,
		// Token: 0x0400F579 RID: 62841
		ViewHidden,
		// Token: 0x0400F57A RID: 62842
		ViewDestroyed,
		// Token: 0x0400F57B RID: 62843
		SourceDestroyed
	}
}
