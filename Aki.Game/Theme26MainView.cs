using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000767 RID: 1895
public class Theme26MainView : SevenHillsMainView, IUiViewResource
{
	// Token: 0x0600571B RID: 22299 RVA: 0x001C925B File Offset: 0x001C745B
	[NullableContext(1)]
	public Theme26MainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x001C9264 File Offset: 0x001C7464
	protected override void OnClickStageItem(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.Theme26StageTaskView, new object[]
		{
			this.ActivityBaseData,
			stageId
		}, null);
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x001C928E File Offset: 0x001C748E
	protected override void RefreshTitleIcon()
	{
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x001C9290 File Offset: 0x001C7490
	[NullableContext(1)]
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		ActivityLongShanData activityLongShanData = param as ActivityLongShanData;
		return ActivityLongShanController.Instance.GetActivityUiConfig(activityLongShanData.Id).MainViewId;
	}
}
