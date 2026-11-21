using System;
using CSharpScript.Game.Ui;

// Token: 0x0200153E RID: 5438
public class HonamiStoryLoadingChecker : ISpecialCustomLoadingTypeChecker
{
	// Token: 0x0600D9D9 RID: 55769 RVA: 0x00408DDD File Offset: 0x00406FDD
	public bool CanHandle(int instanceId)
	{
		return HonamiStoryUtil.CheckEnterOrExitHonamiStoryDungeon(instanceId);
	}

	// Token: 0x0600D9DA RID: 55770 RVA: 0x00408DE5 File Offset: 0x00406FE5
	public EUiViewName? GetLoadingViewName(int instanceId)
	{
		return HonamiStoryModel.Instance.GetCurLoadViewName();
	}
}
