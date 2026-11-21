using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02000B2A RID: 2858
[NullableContext(1)]
[Nullable(0)]
public abstract class ActivityControllerBase : ControllerBase, IActivityControllerBase
{
	// Token: 0x06007606 RID: 30214 RVA: 0x002469A2 File Offset: 0x00244BA2
	public override bool Init()
	{
		bool result = this.OnInit();
		this.OnRegisterNetEvent();
		this.OnAddEvents();
		return result;
	}

	// Token: 0x06007607 RID: 30215 RVA: 0x002469B6 File Offset: 0x00244BB6
	public override bool Clear()
	{
		this.OnUnRegisterNetEvent();
		this.OnRemoveEvents();
		return base.Clear();
	}

	// Token: 0x06007608 RID: 30216 RVA: 0x002469CC File Offset: 0x00244BCC
	public string GetActivityResource(ActivityBaseData data)
	{
		string resourceId = this.OnGetActivityResource(data);
		return UiResourceConfig.Instance.GetResourcePath(resourceId);
	}

	// Token: 0x06007609 RID: 30217 RVA: 0x002469EC File Offset: 0x00244BEC
	public ActivitySubViewBase CreateSubPageComponent(ActivityBaseData data)
	{
		return this.OnCreateSubPageComponent(data);
	}

	// Token: 0x0600760A RID: 30218 RVA: 0x002469F5 File Offset: 0x00244BF5
	public void OpenView(ActivityBaseData data)
	{
		this.OnOpenView(data);
	}

	// Token: 0x0600760B RID: 30219 RVA: 0x00246A00 File Offset: 0x00244C00
	[NullableContext(0)]
	public UniTask<bool> OpenViewByViewName(EUiViewName viewName, int activityId = 0)
	{
		ActivityControllerBase.<OpenViewByViewName>d__5 <OpenViewByViewName>d__;
		<OpenViewByViewName>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OpenViewByViewName>d__.<>4__this = this;
		<OpenViewByViewName>d__.viewName = viewName;
		<OpenViewByViewName>d__.activityId = activityId;
		<OpenViewByViewName>d__.<>1__state = -1;
		<OpenViewByViewName>d__.<>t__builder.Start<ActivityControllerBase.<OpenViewByViewName>d__5>(ref <OpenViewByViewName>d__);
		return <OpenViewByViewName>d__.<>t__builder.Task;
	}

	// Token: 0x0600760C RID: 30220 RVA: 0x00246A53 File Offset: 0x00244C53
	public ActivityBaseData CreateActivityData(ActivityData data)
	{
		ActivityBaseData activityBaseData = this.OnCreateActivityData(data);
		activityBaseData.Init(data);
		return activityBaseData;
	}

	// Token: 0x0600760D RID: 30221 RVA: 0x00246A63 File Offset: 0x00244C63
	public bool GetIsOpeningActivityRelativeView()
	{
		return this.OnGetIsOpeningActivityRelativeView();
	}

	// Token: 0x0600760E RID: 30222 RVA: 0x00246A6B File Offset: 0x00244C6B
	protected virtual void OnRegisterNetEvent()
	{
	}

	// Token: 0x0600760F RID: 30223 RVA: 0x00246A6D File Offset: 0x00244C6D
	protected virtual void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x06007610 RID: 30224 RVA: 0x00246A6F File Offset: 0x00244C6F
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x06007611 RID: 30225 RVA: 0x00246A71 File Offset: 0x00244C71
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x06007612 RID: 30226 RVA: 0x00246A73 File Offset: 0x00244C73
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06007613 RID: 30227 RVA: 0x00246A76 File Offset: 0x00244C76
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x06007614 RID: 30228
	protected abstract void OnOpenView(ActivityBaseData data);

	// Token: 0x06007615 RID: 30229
	protected abstract string OnGetActivityResource(ActivityBaseData data);

	// Token: 0x06007616 RID: 30230
	protected abstract ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data);

	// Token: 0x06007617 RID: 30231
	protected abstract ActivityBaseData OnCreateActivityData(ActivityData data);

	// Token: 0x06007618 RID: 30232
	protected abstract bool OnGetIsOpeningActivityRelativeView();

	// Token: 0x06007619 RID: 30233 RVA: 0x00246A7C File Offset: 0x00244C7C
	[NullableContext(0)]
	protected virtual UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		ActivityControllerBase.<OnOpenSubView>d__19 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<ActivityControllerBase.<OnOpenSubView>d__19>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x0600761A RID: 30234 RVA: 0x00246AB7 File Offset: 0x00244CB7
	public virtual bool GetActivityLevelUnlockState(int levelId)
	{
		return true;
	}

	// Token: 0x0600761B RID: 30235 RVA: 0x00246ABA File Offset: 0x00244CBA
	public virtual bool GetActivityMapMarkState(int markId)
	{
		return false;
	}

	// Token: 0x0600761C RID: 30236 RVA: 0x00246ABD File Offset: 0x00244CBD
	public virtual void OnActivityFirstUnlock(ActivityBaseData data)
	{
	}

	// Token: 0x0600761D RID: 30237 RVA: 0x00246AC0 File Offset: 0x00244CC0
	public virtual void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		if (data.LocalConfig != null && data.LocalConfig.Value.ShowUnlockTip)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipView, data, null);
		}
	}
}
