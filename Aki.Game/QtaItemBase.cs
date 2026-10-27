using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026C2 RID: 9922
[NullableContext(1)]
[Nullable(0)]
public class QtaItemBase : UiPanelBase
{
	// Token: 0x0601458C RID: 83340 RVA: 0x00526AF1 File Offset: 0x00524CF1
	public virtual void SetPreloadQta(int qtaId)
	{
	}

	// Token: 0x0601458D RID: 83341 RVA: 0x00526AF3 File Offset: 0x00524CF3
	public virtual void SetQtaContext(QtaContextBase context)
	{
	}

	// Token: 0x0601458E RID: 83342 RVA: 0x00526AF5 File Offset: 0x00524CF5
	public void PlayQtaStart()
	{
		this.OnPlayQtaStart();
	}

	// Token: 0x0601458F RID: 83343 RVA: 0x00526AFD File Offset: 0x00524CFD
	protected virtual void OnPlayQtaStart()
	{
	}

	// Token: 0x06014590 RID: 83344 RVA: 0x00526AFF File Offset: 0x00524CFF
	protected override void OnRegisterComponent()
	{
		this.IsMobile = Info.Instance.IsInTouch();
	}

	// Token: 0x06014591 RID: 83345 RVA: 0x00526B14 File Offset: 0x00524D14
	protected override void OnStart()
	{
		UUIItem floatUnit = UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, 2);
		if (floatUnit != null)
		{
			this.GetOriginalItem().SetUIParent(floatUnit, false);
		}
		EventSystem.Instance.Emit<string>(EEventName.DisableCustomInputData, this.RootActor.GetName());
		BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.PanelQta, new Action(this.OnBattleUiVisibleChanged));
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		EventSystem.Instance.Add<int?>(EEventName.QtaEnd, new Action<int?>(this.OnQtaEnd));
	}

	// Token: 0x06014592 RID: 83346 RVA: 0x00526BAC File Offset: 0x00524DAC
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<string>(EEventName.EnableCacheCustomInputData, this.RootActor.GetName());
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.PanelQta, new Action(this.OnBattleUiVisibleChanged));
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		EventSystem.Instance.Remove(EEventName.QtaEnd, new Action<int?>(this.OnQtaEnd));
		this.ClearTickTimer();
	}

	// Token: 0x06014593 RID: 83347 RVA: 0x00526C2C File Offset: 0x00524E2C
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ResumeQta(false);
	}

	// Token: 0x06014594 RID: 83348 RVA: 0x00526C3B File Offset: 0x00524E3B
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.PauseQta();
	}

	// Token: 0x06014595 RID: 83349 RVA: 0x00526C49 File Offset: 0x00524E49
	protected void InitTweenAnim(int itemId)
	{
		this.TweenAnimPlayer.InitTweenAnim(itemId, base.GetItem(itemId), false);
	}

	// Token: 0x06014596 RID: 83350 RVA: 0x00526C60 File Offset: 0x00524E60
	private void OnQtaEnd(int? handleId)
	{
		int qtaHandle = this.QtaHandle;
		int? num = handleId;
		if (!(qtaHandle == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.HandleQtaEnd();
	}

	// Token: 0x06014597 RID: 83351 RVA: 0x00526C8F File Offset: 0x00524E8F
	private void OnBattleUiVisibleChanged()
	{
		this.RefreshOnBattleUiVisibleChanged();
	}

	// Token: 0x06014598 RID: 83352 RVA: 0x00526C97 File Offset: 0x00524E97
	private void OnTriggerUiTimeDilation()
	{
		if (this.IsQtaEnd)
		{
			return;
		}
		if (Time.Instance.TimeDilation == 0f)
		{
			this.PauseQta();
			return;
		}
		this.ResumeQta(true);
	}

	// Token: 0x06014599 RID: 83353 RVA: 0x00526CC1 File Offset: 0x00524EC1
	protected virtual void RefreshOnBattleUiVisibleChanged()
	{
	}

	// Token: 0x0601459A RID: 83354 RVA: 0x00526CC3 File Offset: 0x00524EC3
	public virtual void OnQtaMoment(EQtaMomentName moment)
	{
	}

	// Token: 0x0601459B RID: 83355 RVA: 0x00526CC5 File Offset: 0x00524EC5
	protected virtual void HandleQtaEnd()
	{
	}

	// Token: 0x0601459C RID: 83356 RVA: 0x00526CC7 File Offset: 0x00524EC7
	protected void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x0601459D RID: 83357 RVA: 0x00526CD0 File Offset: 0x00524ED0
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x0601459E RID: 83358 RVA: 0x00526CD2 File Offset: 0x00524ED2
	protected void PauseQta()
	{
		if (this.IsQtaPause || this.IsQtaEnd)
		{
			return;
		}
		TimerHandle tickTimer = this.TickTimer;
		if (tickTimer != null)
		{
			tickTimer.Pause();
		}
		this.IsQtaPause = true;
		if (this.IsQtaActive)
		{
			this.OnQtaPause();
		}
	}

	// Token: 0x0601459F RID: 83359 RVA: 0x00526D0C File Offset: 0x00524F0C
	protected void ResumeQta(bool delay = false)
	{
		if (!this.IsQtaPause || this.IsQtaEnd)
		{
			return;
		}
		TimerHandle tickTimer = this.TickTimer;
		if (tickTimer != null)
		{
			tickTimer.Resume();
		}
		this.IsQtaPause = false;
		if (this.IsQtaActive)
		{
			if (delay)
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					UUIItem originalItem = this.GetOriginalItem();
					if (originalItem == null || !originalItem.IsValid())
					{
						return;
					}
					this.OnQtaResume();
				}, null, null);
				return;
			}
			this.OnQtaResume();
		}
	}

	// Token: 0x060145A0 RID: 83360 RVA: 0x00526D6E File Offset: 0x00524F6E
	protected virtual void OnQtaPause()
	{
	}

	// Token: 0x060145A1 RID: 83361 RVA: 0x00526D70 File Offset: 0x00524F70
	protected virtual void OnQtaResume()
	{
	}

	// Token: 0x060145A2 RID: 83362 RVA: 0x00526D72 File Offset: 0x00524F72
	public bool IsValidInput()
	{
		return this.CanInteractive && !this.IsQtaEnd && !this.IsQtaPause;
	}

	// Token: 0x060145A3 RID: 83363 RVA: 0x00526D90 File Offset: 0x00524F90
	protected void SetQtaActive(QtaContextBase context)
	{
		this.IsQtaActive = true;
		this.ClearTickTimer();
		this.TickTimer = TimerSystem.Instance.Forever(delegate(float delta)
		{
			this.Tick(delta);
		}, (float)this.TickInterval, 1f, null, null, true);
		EQtaSource? source = context.Source;
		EQtaSource eqtaSource = EQtaSource.Battle;
		if (source.GetValueOrDefault() == eqtaSource & source != null)
		{
			if (!BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQta))
			{
				this.PauseQta();
				return;
			}
			if (Time.Instance.TimeDilation == 0f)
			{
				this.PauseQta();
			}
		}
	}

	// Token: 0x060145A4 RID: 83364 RVA: 0x00526E23 File Offset: 0x00525023
	protected void ClearTickTimer()
	{
		if (this.TickTimer != null)
		{
			TimerSystem.Instance.Remove(this.TickTimer);
			this.TickTimer = null;
		}
	}

	// Token: 0x040098FC RID: 39164
	protected int QtaHandle;

	// Token: 0x040098FD RID: 39165
	protected bool IsMobile;

	// Token: 0x040098FE RID: 39166
	protected bool IsQtaActive;

	// Token: 0x040098FF RID: 39167
	protected bool IsQtaPlayStart;

	// Token: 0x04009900 RID: 39168
	protected bool IsQtaStart;

	// Token: 0x04009901 RID: 39169
	protected bool IsQtaEnd;

	// Token: 0x04009902 RID: 39170
	protected bool CanInteractive;

	// Token: 0x04009903 RID: 39171
	protected bool IsQtaPause;

	// Token: 0x04009904 RID: 39172
	[Nullable(2)]
	protected TimerHandle TickTimer;

	// Token: 0x04009905 RID: 39173
	protected int TickInterval = 20;

	// Token: 0x04009906 RID: 39174
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}
