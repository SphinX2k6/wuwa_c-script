using System;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038B5 RID: 14517
	public enum EFindNavigationResult
	{
		// Token: 0x04014C6C RID: 85100
		None,
		// Token: 0x04014C6D RID: 85101
		CanFocus,
		// Token: 0x04014C6E RID: 85102
		CantFocus,
		// Token: 0x04014C6F RID: 85103
		LoopOrLayoutDataInit,
		// Token: 0x04014C70 RID: 85104
		LoopOrLayoutAnimation,
		// Token: 0x04014C71 RID: 85105
		WaitRegisterToPanelConfig,
		// Token: 0x04014C72 RID: 85106
		WaitDynamicListener,
		// Token: 0x04014C73 RID: 85107
		DynamicScrollViewNotReady,
		// Token: 0x04014C74 RID: 85108
		MultiTemplateScrollViewNotReady
	}
}
