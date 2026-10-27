using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x0200493E RID: 18750
	public enum EFindNavigationResult
	{
		// Token: 0x0401A3F9 RID: 107513
		None,
		// Token: 0x0401A3FA RID: 107514
		CanFocus,
		// Token: 0x0401A3FB RID: 107515
		CantFocus,
		// Token: 0x0401A3FC RID: 107516
		LoopOrLayoutDataInit,
		// Token: 0x0401A3FD RID: 107517
		LoopOrLayoutAnimation,
		// Token: 0x0401A3FE RID: 107518
		WaitRegisterToPanelConfig,
		// Token: 0x0401A3FF RID: 107519
		WaitDynamicListener,
		// Token: 0x0401A400 RID: 107520
		DynamicScrollViewNotReady,
		// Token: 0x0401A401 RID: 107521
		MultiTemplateScrollViewNotReady
	}
}
