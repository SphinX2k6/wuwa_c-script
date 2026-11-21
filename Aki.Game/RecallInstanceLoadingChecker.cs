using System;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;

// Token: 0x02001540 RID: 5440
public class RecallInstanceLoadingChecker : ISpecialCustomLoadingTypeChecker
{
	// Token: 0x0600D9DF RID: 55775 RVA: 0x00408F1C File Offset: 0x0040711C
	public bool CanHandle(int instanceId)
	{
		return RecallQuestModel.Instance.IsInRecallInstance();
	}

	// Token: 0x0600D9E0 RID: 55776 RVA: 0x00408F28 File Offset: 0x00407128
	public EUiViewName? GetLoadingViewName(int instanceId)
	{
		return new EUiViewName?(EUiViewName.RecallLoadingView);
	}
}
