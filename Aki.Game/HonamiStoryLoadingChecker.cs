using System;
using CSharpScript.Game.Ui;

// Token: 0x0200206B RID: 8299
public class HonamiStoryLoadingChecker : ISpecialCustomLoadingTypeChecker
{
	// Token: 0x06010571 RID: 66929 RVA: 0x003FC995 File Offset: 0x003FAB95
	public bool CanHandle(int instanceId)
	{
		return HonamiStoryUtil.CheckEnterOrExitHonamiStoryDungeon(instanceId);
	}

	// Token: 0x06010572 RID: 66930 RVA: 0x003FC99D File Offset: 0x003FAB9D
	public EUiViewName? GetLoadingViewName(int instanceId)
	{
		return HonamiStoryModel.Instance.GetCurLoadViewName();
	}
}
