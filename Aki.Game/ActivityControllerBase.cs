using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001672 RID: 5746
[NullableContext(1)]
[Nullable(0)]
public abstract class ActivityControllerBase : ControllerBase, IActivityControllerBase
{
	// Token: 0x0600A228 RID: 41512 RVA: 0x0023CB12 File Offset: 0x0023AD12
	public override bool Init()
	{
		bool result = this.OnInit();
		this.OnRegisterNetEvent();
		this.OnAddEvents();
		return result;
	}

	// Token: 0x0600A229 RID: 41513 RVA: 0x0023CB26 File Offset: 0x0023AD26
	public override bool Clear()
	{
		this.OnUnRegisterNetEvent();
		this.OnRemoveEvents();
		return base.Clear();
	}

	// Token: 0x0600A22A RID: 41514 RVA: 0x0023CB3C File Offset: 0x0023AD3C
	public string GetActivityResource(ActivityBaseData data)
	{
		string resourceId = this.OnGetActivityResource(data);
		return UiResourceConfig.Instance.GetResourcePath(resourceId);
	}

	// Token: 0x0600A22B RID: 41515 RVA: 0x0023CB5C File Offset: 0x0023AD5C
	public ActivitySubViewBase CreateSubPageComponent(ActivityBaseData data)
	{
		return this.OnCreateSubPageComponent(data);
	}

	// Token: 0x0600A22C RID: 41516 RVA: 0x0023CB65 File Offset: 0x0023AD65
	public void OpenView(ActivityBaseData data)
	{
		this.OnOpenView(data);
	}

	// Token: 0x0600A22D RID: 41517 RVA: 0x0023CB70 File Offset: 0x0023AD70
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

	// Token: 0x0600A22E RID: 41518 RVA: 0x0023CBC3 File Offset: 0x0023ADC3
	public ActivityBaseData CreateActivityData(ActivityData data)
	{
		ActivityBaseData activityBaseData = this.OnCreateActivityData(data);
		activityBaseData.Init(data);
		return activityBaseData;
	}

	// Token: 0x0600A22F RID: 41519 RVA: 0x0023CBD3 File Offset: 0x0023ADD3
	public bool GetIsOpeningActivityRelativeView()
	{
		return this.OnGetIsOpeningActivityRelativeView();
	}

	// Token: 0x0600A230 RID: 41520 RVA: 0x0023CBDB File Offset: 0x0023ADDB
	protected virtual void OnRegisterNetEvent()
	{
	}

	// Token: 0x0600A231 RID: 41521 RVA: 0x0023CBDD File Offset: 0x0023ADDD
	protected virtual void OnUnRegisterNetEvent()
	{
	}

	// Token: 0x0600A232 RID: 41522 RVA: 0x0023CBDF File Offset: 0x0023ADDF
	protected virtual void OnAddEvents()
	{
	}

	// Token: 0x0600A233 RID: 41523 RVA: 0x0023CBE1 File Offset: 0x0023ADE1
	protected virtual void OnRemoveEvents()
	{
	}

	// Token: 0x0600A234 RID: 41524 RVA: 0x0023CBE3 File Offset: 0x0023ADE3
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600A235 RID: 41525 RVA: 0x0023CBE6 File Offset: 0x0023ADE6
	protected override bool OnClear()
	{
		return true;
	}

	// Token: 0x0600A236 RID: 41526
	protected abstract void OnOpenView(ActivityBaseData data);

	// Token: 0x0600A237 RID: 41527
	protected abstract string OnGetActivityResource(ActivityBaseData data);

	// Token: 0x0600A238 RID: 41528
	protected abstract ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data);

	// Token: 0x0600A239 RID: 41529
	protected abstract ActivityBaseData OnCreateActivityData(ActivityData data);

	// Token: 0x0600A23A RID: 41530
	protected abstract bool OnGetIsOpeningActivityRelativeView();

	// Token: 0x0600A23B RID: 41531 RVA: 0x0023CBEC File Offset: 0x0023ADEC
	[NullableContext(0)]
	protected virtual UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
	{
		ActivityControllerBase.<OnOpenSubView>d__19 <OnOpenSubView>d__;
		<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnOpenSubView>d__.<>1__state = -1;
		<OnOpenSubView>d__.<>t__builder.Start<ActivityControllerBase.<OnOpenSubView>d__19>(ref <OnOpenSubView>d__);
		return <OnOpenSubView>d__.<>t__builder.Task;
	}

	// Token: 0x0600A23C RID: 41532 RVA: 0x0023CC27 File Offset: 0x0023AE27
	public virtual bool GetActivityLevelUnlockState(int levelId)
	{
		return true;
	}

	// Token: 0x0600A23D RID: 41533 RVA: 0x0023CC2A File Offset: 0x0023AE2A
	public virtual bool GetActivityMapMarkState(int markId)
	{
		return false;
	}

	// Token: 0x0600A23E RID: 41534 RVA: 0x0023CC2D File Offset: 0x0023AE2D
	public virtual void OnActivityFirstUnlock(ActivityBaseData data)
	{
	}

	// Token: 0x0600A23F RID: 41535 RVA: 0x0023CC30 File Offset: 0x0023AE30
	public virtual void OnShowActivityFirstUnlockView(ActivityBaseData data)
	{
		if (data.LocalConfig != null && data.LocalConfig.Value.ShowUnlockTip)
		{
			UiManager.Instance.OpenView(EUiViewName.ActivityUnlockTipView, data, null);
		}
	}
}
