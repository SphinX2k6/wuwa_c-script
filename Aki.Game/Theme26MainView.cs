using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012B3 RID: 4787
public class Theme26MainView : SevenHillsMainView, IUiViewResource
{
	// Token: 0x06008384 RID: 33668 RVA: 0x001C04CB File Offset: 0x001BE6CB
	[NullableContext(1)]
	public Theme26MainView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06008385 RID: 33669 RVA: 0x001C04D4 File Offset: 0x001BE6D4
	protected override void OnClickStageItem(int stageId)
	{
		UiManager.Instance.OpenView(EUiViewName.Theme26StageTaskView, new object[]
		{
			this.ActivityBaseData,
			stageId
		}, null);
	}

	// Token: 0x06008386 RID: 33670 RVA: 0x001C04FE File Offset: 0x001BE6FE
	protected override void RefreshTitleIcon()
	{
	}

	// Token: 0x06008387 RID: 33671 RVA: 0x001C0500 File Offset: 0x001BE700
	[NullableContext(1)]
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		ActivityLongShanData activityLongShanData = param as ActivityLongShanData;
		return ActivityLongShanController.Instance.GetActivityUiConfig(activityLongShanData.Id).MainViewId;
	}
}
