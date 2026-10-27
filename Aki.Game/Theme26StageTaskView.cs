using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012B4 RID: 4788
public class Theme26StageTaskView : SevenHillsStageTaskView, IUiViewResource
{
	// Token: 0x06008388 RID: 33672 RVA: 0x001C052C File Offset: 0x001BE72C
	[NullableContext(1)]
	public Theme26StageTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x17000B31 RID: 2865
	// (get) Token: 0x06008389 RID: 33673 RVA: 0x001C0535 File Offset: 0x001BE735
	protected override bool IsRefreshNow
	{
		get
		{
			return false;
		}
	}

	// Token: 0x0600838A RID: 33674 RVA: 0x001C0538 File Offset: 0x001BE738
	protected override void RefreshTitleIcon()
	{
	}

	// Token: 0x0600838B RID: 33675 RVA: 0x001C053C File Offset: 0x001BE73C
	[NullableContext(1)]
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		object[] array = param as object[];
		if (array == null || array.Length < 2)
		{
			return "";
		}
		ActivityLongShanData activityLongShanData = array[0] as ActivityLongShanData;
		if (activityLongShanData == null)
		{
			return "";
		}
		return ActivityLongShanController.Instance.GetActivityUiConfig(activityLongShanData.Id).RewardViewId;
	}
}
