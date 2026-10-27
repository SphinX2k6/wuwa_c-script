using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x020012B5 RID: 4789
public class Theme26UnlockTipView : UiViewBase, IUiViewResource
{
	// Token: 0x0600838C RID: 33676 RVA: 0x001C0589 File Offset: 0x001BE789
	[NullableContext(1)]
	public Theme26UnlockTipView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600838D RID: 33677 RVA: 0x001C0592 File Offset: 0x001BE792
	protected override void OnAfterShow()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600838E RID: 33678 RVA: 0x001C059C File Offset: 0x001BE79C
	[NullableContext(1)]
	public string GetExtraResourceId([Nullable(2)] object param = null)
	{
		ActivityLongShanData activityLongShanData = param as ActivityLongShanData;
		return ActivityLongShanController.Instance.GetActivityUiConfig(activityLongShanData.Id).OpenTipId;
	}
}
