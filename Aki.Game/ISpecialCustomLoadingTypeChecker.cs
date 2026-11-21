using System;
using CSharpScript.Game.Ui;

// Token: 0x02001548 RID: 5448
public interface ISpecialCustomLoadingTypeChecker
{
	// Token: 0x0600DA2E RID: 55854
	bool CanHandle(int instanceId);

	// Token: 0x0600DA2F RID: 55855
	EUiViewName? GetLoadingViewName(int instanceId);
}
