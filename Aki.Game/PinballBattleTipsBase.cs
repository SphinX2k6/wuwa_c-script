using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011CD RID: 4557
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleTipsBase : UiViewBase
{
	// Token: 0x0600B4E3 RID: 46307 RVA: 0x00356FBE File Offset: 0x003551BE
	[NullableContext(1)]
	public PinballBattleTipsBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600B4E4 RID: 46308 RVA: 0x00356FD4 File Offset: 0x003551D4
	protected override void OnStart()
	{
		IPinballBattleTipsBaseParam pinballBattleTipsBaseParam = this.OpenParam as IPinballBattleTipsBaseParam;
		this.MoveToBehind = ((pinballBattleTipsBaseParam != null) ? pinballBattleTipsBaseParam.MoveToBehind : null).GetValueOrDefault();
		PinballModel instance = PinballModel.Instance;
		UUIItem uuiitem = (instance != null) ? instance.GetBattleCenterRootItem() : null;
		if (uuiitem != null)
		{
			base.SetParentUiItem(uuiitem);
			if (this.MoveToBehind)
			{
				UUIItem rootItem = base.GetRootItem();
				if (rootItem != null)
				{
					rootItem.SetAsFirstHierarchy();
				}
			}
		}
		this.CloseCallback = ((pinballBattleTipsBaseParam != null) ? pinballBattleTipsBaseParam.CloseCallback : null);
		this.AddMask = ((pinballBattleTipsBaseParam != null) ? pinballBattleTipsBaseParam.AddMask : null).GetValueOrDefault();
		if (this.AddMask)
		{
			this.TrySetMaskActive(true);
		}
		this.CloseTime = ((pinballBattleTipsBaseParam != null) ? pinballBattleTipsBaseParam.CloseTime : null).GetValueOrDefault(2000);
		this.AddCloseTimer();
	}

	// Token: 0x0600B4E5 RID: 46309 RVA: 0x003570B4 File Offset: 0x003552B4
	protected override void OnBeforeDestroy()
	{
		this.RemoveCloseTimer();
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		if (this.AddMask)
		{
			this.TrySetMaskActive(false);
		}
	}

	// Token: 0x0600B4E6 RID: 46310 RVA: 0x003570DC File Offset: 0x003552DC
	private void AddCloseTimer()
	{
		if (this.CloseTimerHandle != null)
		{
			return;
		}
		this.CloseTimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			base.CloseMe(null);
			this.CloseTimerHandle = null;
		}, (float)this.CloseTime, null, null, true, 1f);
	}

	// Token: 0x0600B4E7 RID: 46311 RVA: 0x00357112 File Offset: 0x00355312
	private void RemoveCloseTimer()
	{
		if (this.CloseTimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CloseTimerHandle);
			this.CloseTimerHandle = null;
		}
	}

	// Token: 0x0600B4E8 RID: 46312 RVA: 0x00357134 File Offset: 0x00355334
	public void ResetCloseTimer()
	{
		this.RemoveCloseTimer();
		this.AddCloseTimer();
	}

	// Token: 0x0600B4E9 RID: 46313 RVA: 0x00357142 File Offset: 0x00355342
	private void TrySetMaskActive(bool active)
	{
		CommonGameMainView commonGameMainView = UiManager.Instance.GetViewByName(EUiViewName.CommonGameMainView) as CommonGameMainView;
		if (commonGameMainView == null)
		{
			return;
		}
		commonGameMainView.SetMaskItemActive(active);
	}

	// Token: 0x0600B4EA RID: 46314 RVA: 0x00357163 File Offset: 0x00355363
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B4EB RID: 46315 RVA: 0x00357196 File Offset: 0x00355396
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600B4EC RID: 46316 RVA: 0x003571C9 File Offset: 0x003553C9
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PinballBattlePauseView && this.CloseTimerHandle != null && !this.CloseTimerHandle.IsPause())
		{
			this.CloseTimerHandle.Pause();
		}
	}

	// Token: 0x0600B4ED RID: 46317 RVA: 0x003571F9 File Offset: 0x003553F9
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PinballBattlePauseView && this.CloseTimerHandle != null && this.CloseTimerHandle.IsPause())
		{
			this.CloseTimerHandle.Resume();
		}
	}

	// Token: 0x040068A5 RID: 26789
	private const int PINBALL_DEFAULT_TIPS_DURATION = 2000;

	// Token: 0x040068A6 RID: 26790
	private TimerHandle CloseTimerHandle;

	// Token: 0x040068A7 RID: 26791
	private int CloseTime = 2000;

	// Token: 0x040068A8 RID: 26792
	private Action CloseCallback;

	// Token: 0x040068A9 RID: 26793
	private bool AddMask;

	// Token: 0x040068AA RID: 26794
	private bool MoveToBehind;
}
