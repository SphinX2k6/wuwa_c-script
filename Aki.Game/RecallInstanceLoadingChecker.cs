using System;
using CSharpScript.Game.Module.RecallQuest.Model;
using CSharpScript.Game.Ui;

// Token: 0x0200206D RID: 8301
public class RecallInstanceLoadingChecker : ISpecialCustomLoadingTypeChecker
{
	// Token: 0x06010577 RID: 66935 RVA: 0x003FCAD4 File Offset: 0x003FACD4
	public bool CanHandle(int instanceId)
	{
		return RecallQuestModel.Instance.IsInRecallInstance();
	}

	// Token: 0x06010578 RID: 66936 RVA: 0x003FCAE0 File Offset: 0x003FACE0
	public EUiViewName? GetLoadingViewName(int instanceId)
	{
		return new EUiViewName?(EUiViewName.RecallLoadingView);
	}
}
