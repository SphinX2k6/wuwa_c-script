using System;
using CSharpScript.Game.Ui;

// Token: 0x02002075 RID: 8309
public interface ISpecialCustomLoadingTypeChecker
{
	// Token: 0x060105C6 RID: 67014
	bool CanHandle(int instanceId);

	// Token: 0x060105C7 RID: 67015
	EUiViewName? GetLoadingViewName(int instanceId);
}
