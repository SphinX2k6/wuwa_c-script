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

// Token: 0x02001BAD RID: 7085
[NullableContext(1)]
[Nullable(0)]
public class QtaItemBase : UiPanelBase
{
	// Token: 0x06011A6E RID: 72302 RVA: 0x00535829 File Offset: 0x00533A29
	public virtual void SetPreloadQta(int qtaId)
	{
	}

	// Token: 0x06011A6F RID: 72303 RVA: 0x0053582B File Offset: 0x00533A2B
	public virtual void SetQtaContext(QtaContextBase context)
	{
	}

	// Token: 0x06011A70 RID: 72304 RVA: 0x0053582D File Offset: 0x00533A2D
	public void PlayQtaStart()
	{
		this.OnPlayQtaStart();
	}

	// Token: 0x06011A71 RID: 72305 RVA: 0x00535835 File Offset: 0x00533A35
	protected virtual void OnPlayQtaStart()
	{
	}

	// Token: 0x06011A72 RID: 72306 RVA: 0x00535837 File Offset: 0x00533A37
	protected override void OnRegisterComponent()
	{
		this.IsMobile = Info.Instance.IsInTouch();
	}

	// Token: 0x06011A73 RID: 72307 RVA: 0x0053584C File Offset: 0x00533A4C
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

	// Token: 0x06011A74 RID: 72308 RVA: 0x005358E4 File Offset: 0x00533AE4
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Emit<string>(EEventName.EnableCacheCustomInputData, this.RootActor.GetName());
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.PanelQta, new Action(this.OnBattleUiVisibleChanged));
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		EventSystem.Instance.Remove(EEventName.QtaEnd, new Action<int?>(this.OnQtaEnd));
		this.ClearTickTimer();
	}

	// Token: 0x06011A75 RID: 72309 RVA: 0x00535964 File Offset: 0x00533B64
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ResumeQta(false);
	}

	// Token: 0x06011A76 RID: 72310 RVA: 0x00535973 File Offset: 0x00533B73
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.PauseQta();
	}

	// Token: 0x06011A77 RID: 72311 RVA: 0x00535981 File Offset: 0x00533B81
	protected void InitTweenAnim(int itemId)
	{
		this.TweenAnimPlayer.InitTweenAnim(itemId, base.GetItem(itemId), false);
	}

	// Token: 0x06011A78 RID: 72312 RVA: 0x00535998 File Offset: 0x00533B98
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

	// Token: 0x06011A79 RID: 72313 RVA: 0x005359C7 File Offset: 0x00533BC7
	private void OnBattleUiVisibleChanged()
	{
		this.RefreshOnBattleUiVisibleChanged();
	}

	// Token: 0x06011A7A RID: 72314 RVA: 0x005359CF File Offset: 0x00533BCF
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

	// Token: 0x06011A7B RID: 72315 RVA: 0x005359F9 File Offset: 0x00533BF9
	protected virtual void RefreshOnBattleUiVisibleChanged()
	{
	}

	// Token: 0x06011A7C RID: 72316 RVA: 0x005359FB File Offset: 0x00533BFB
	public virtual void OnQtaMoment(EQtaMomentName moment)
	{
	}

	// Token: 0x06011A7D RID: 72317 RVA: 0x005359FD File Offset: 0x00533BFD
	protected virtual void HandleQtaEnd()
	{
	}

	// Token: 0x06011A7E RID: 72318 RVA: 0x005359FF File Offset: 0x00533BFF
	protected void Tick(float delta)
	{
		this.OnTick(delta);
	}

	// Token: 0x06011A7F RID: 72319 RVA: 0x00535A08 File Offset: 0x00533C08
	protected virtual void OnTick(float delta)
	{
	}

	// Token: 0x06011A80 RID: 72320 RVA: 0x00535A0A File Offset: 0x00533C0A
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

	// Token: 0x06011A81 RID: 72321 RVA: 0x00535A44 File Offset: 0x00533C44
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

	// Token: 0x06011A82 RID: 72322 RVA: 0x00535AA6 File Offset: 0x00533CA6
	protected virtual void OnQtaPause()
	{
	}

	// Token: 0x06011A83 RID: 72323 RVA: 0x00535AA8 File Offset: 0x00533CA8
	protected virtual void OnQtaResume()
	{
	}

	// Token: 0x06011A84 RID: 72324 RVA: 0x00535AAA File Offset: 0x00533CAA
	public bool IsValidInput()
	{
		return this.CanInteractive && !this.IsQtaEnd && !this.IsQtaPause;
	}

	// Token: 0x06011A85 RID: 72325 RVA: 0x00535AC8 File Offset: 0x00533CC8
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

	// Token: 0x06011A86 RID: 72326 RVA: 0x00535B5B File Offset: 0x00533D5B
	protected void ClearTickTimer()
	{
		if (this.TickTimer != null)
		{
			TimerSystem.Instance.Remove(this.TickTimer);
			this.TickTimer = null;
		}
	}

	// Token: 0x04009A54 RID: 39508
	protected int QtaHandle;

	// Token: 0x04009A55 RID: 39509
	protected bool IsMobile;

	// Token: 0x04009A56 RID: 39510
	protected bool IsQtaActive;

	// Token: 0x04009A57 RID: 39511
	protected bool IsQtaPlayStart;

	// Token: 0x04009A58 RID: 39512
	protected bool IsQtaStart;

	// Token: 0x04009A59 RID: 39513
	protected bool IsQtaEnd;

	// Token: 0x04009A5A RID: 39514
	protected bool CanInteractive;

	// Token: 0x04009A5B RID: 39515
	protected bool IsQtaPause;

	// Token: 0x04009A5C RID: 39516
	[Nullable(2)]
	protected TimerHandle TickTimer;

	// Token: 0x04009A5D RID: 39517
	protected int TickInterval = 20;

	// Token: 0x04009A5E RID: 39518
	protected BattleUiTweenAnimPlayer TweenAnimPlayer = new BattleUiTweenAnimPlayer();
}
