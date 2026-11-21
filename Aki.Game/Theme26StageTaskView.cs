using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000768 RID: 1896
public class Theme26StageTaskView : SevenHillsStageTaskView, IUiViewResource
{
	// Token: 0x0600571F RID: 22303 RVA: 0x001C92BC File Offset: 0x001C74BC
	[NullableContext(1)]
	public Theme26StageTaskView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x17000B51 RID: 2897
	// (get) Token: 0x06005720 RID: 22304 RVA: 0x001C92C5 File Offset: 0x001C74C5
	protected override bool IsRefreshNow
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x001C92C8 File Offset: 0x001C74C8
	protected override void RefreshTitleIcon()
	{
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x001C92CC File Offset: 0x001C74CC
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
