using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D0B RID: 7435
[NullableContext(2)]
[Nullable(0)]
public class PinballBattleTipsBase : UiViewBase
{
	// Token: 0x0600E0C6 RID: 57542 RVA: 0x0034B58E File Offset: 0x0034978E
	[NullableContext(1)]
	public PinballBattleTipsBase(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E0C7 RID: 57543 RVA: 0x0034B5A4 File Offset: 0x003497A4
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

	// Token: 0x0600E0C8 RID: 57544 RVA: 0x0034B684 File Offset: 0x00349884
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

	// Token: 0x0600E0C9 RID: 57545 RVA: 0x0034B6AC File Offset: 0x003498AC
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

	// Token: 0x0600E0CA RID: 57546 RVA: 0x0034B6E2 File Offset: 0x003498E2
	private void RemoveCloseTimer()
	{
		if (this.CloseTimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.CloseTimerHandle);
			this.CloseTimerHandle = null;
		}
	}

	// Token: 0x0600E0CB RID: 57547 RVA: 0x0034B704 File Offset: 0x00349904
	public void ResetCloseTimer()
	{
		this.RemoveCloseTimer();
		this.AddCloseTimer();
	}

	// Token: 0x0600E0CC RID: 57548 RVA: 0x0034B712 File Offset: 0x00349912
	private void TrySetMaskActive(bool active)
	{
		CommonGameMainView commonGameMainView = UiManager.Instance.GetViewByName(EUiViewName.CommonGameMainView) as CommonGameMainView;
		if (commonGameMainView == null)
		{
			return;
		}
		commonGameMainView.SetMaskItemActive(active);
	}

	// Token: 0x0600E0CD RID: 57549 RVA: 0x0034B733 File Offset: 0x00349933
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E0CE RID: 57550 RVA: 0x0034B766 File Offset: 0x00349966
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
	}

	// Token: 0x0600E0CF RID: 57551 RVA: 0x0034B799 File Offset: 0x00349999
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PinballBattlePauseView && this.CloseTimerHandle != null && !this.CloseTimerHandle.IsPause())
		{
			this.CloseTimerHandle.Pause();
		}
	}

	// Token: 0x0600E0D0 RID: 57552 RVA: 0x0034B7C9 File Offset: 0x003499C9
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (viewName == EUiViewName.PinballBattlePauseView && this.CloseTimerHandle != null && this.CloseTimerHandle.IsPause())
		{
			this.CloseTimerHandle.Resume();
		}
	}

	// Token: 0x040067C6 RID: 26566
	private const int PINBALL_DEFAULT_TIPS_DURATION = 2000;

	// Token: 0x040067C7 RID: 26567
	private TimerHandle CloseTimerHandle;

	// Token: 0x040067C8 RID: 26568
	private int CloseTime = 2000;

	// Token: 0x040067C9 RID: 26569
	private Action CloseCallback;

	// Token: 0x040067CA RID: 26570
	private bool AddMask;

	// Token: 0x040067CB RID: 26571
	private bool MoveToBehind;
}
