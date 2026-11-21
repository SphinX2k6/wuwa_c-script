using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02000769 RID: 1897
public class Theme26UnlockTipView : UiViewBase, IUiViewResource
{
	// Token: 0x06005723 RID: 22307 RVA: 0x001C9319 File Offset: 0x001C7519
	[NullableContext(1)]
	public Theme26UnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x001C9322 File Offset: 0x001C7522
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x06005725 RID: 22309 RVA: 0x001C932C File Offset: 0x001C752C
	[NullableContext(1)]
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		ActivityLongShanData activityLongShanData = param as ActivityLongShanData;
		return ActivityLongShanController.Instance.GetActivityUiConfig(activityLongShanData.Id).OpenTipId;
	}
}
