using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.QuickTimeAction;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020026C0 RID: 9920
[NullableContext(1)]
[Nullable(0)]
public class QtaCustomizationLimitedHoldItem : QtaItemBase
{
	// Token: 0x06014570 RID: 83312 RVA: 0x00525F44 File Offset: 0x00524144
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014571 RID: 83313 RVA: 0x005260B8 File Offset: 0x005242B8
	protected override UniTask OnBeforeStartAsync()
	{
		QtaCustomizationLimitedHoldItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<QtaCustomizationLimitedHoldItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014572 RID: 83314 RVA: 0x005260FC File Offset: 0x005242FC
	protected override void OnStart()
	{
		base.OnStart();
		for (int i = 5; i <= 9; i++)
		{
			base.InitTweenAnim(i);
		}
		base.SetUiActive(false);
	}

	// Token: 0x06014573 RID: 83315 RVA: 0x0052612C File Offset: 0x0052432C
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		if (!this.IsQtaEnd)
		{
			QtaCustomizationContext qtaContext = this.QtaContext;
			if (qtaContext != null && qtaContext.IsActive())
			{
				QtaController.Instance.StopQta(this.QtaContext.HandleId, false);
			}
		}
		this.UnbindAction();
		this.QtaContext = null;
		this.QtaHandle = -1;
		this.QtaActions.Clear();
	}

	// Token: 0x06014574 RID: 83316 RVA: 0x00526190 File Offset: 0x00524390
	protected override UniTask OnShowAsyncImplementImplement()
	{
		QtaCustomizationLimitedHoldItem.<OnShowAsyncImplementImplement>d__10 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<QtaCustomizationLimitedHoldItem.<OnShowAsyncImplementImplement>d__10>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06014575 RID: 83317 RVA: 0x005261D4 File Offset: 0x005243D4
	protected override UniTask OnHideAsyncImplementImplement()
	{
		QtaCustomizationLimitedHoldItem.<OnHideAsyncImplementImplement>d__11 <OnHideAsyncImplementImplement>d__;
		<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHideAsyncImplementImplement>d__.<>4__this = this;
		<OnHideAsyncImplementImplement>d__.<>1__state = -1;
		<OnHideAsyncImplementImplement>d__.<>t__builder.Start<QtaCustomizationLimitedHoldItem.<OnHideAsyncImplementImplement>d__11>(ref <OnHideAsyncImplementImplement>d__);
		return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06014576 RID: 83318 RVA: 0x00526218 File Offset: 0x00524418
	public override void SetQtaContext(QtaContextBase context)
	{
		QtaCustomizationContext qtaCustomizationContext = context as QtaCustomizationContext;
		if (qtaCustomizationContext == null)
		{
			return;
		}
		this.QtaHandle = context.HandleId;
		this.QtaContext = qtaCustomizationContext;
		this.QtaActions = (context.GetActions() ?? new List<string>());
		bool valid = ((QtaCustomizationLimitedHoldLogic)this.QtaContext.QtaCustomizationLogic).IsWithinRange();
		QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
		if (bgBarLogic != null)
		{
			bgBarLogic.SetValid(valid);
		}
		this.RefreshValidState(valid, true);
		base.SetQtaActive(context);
	}

	// Token: 0x06014577 RID: 83319 RVA: 0x00526290 File Offset: 0x00524490
	protected override void OnPlayQtaStart()
	{
		if (!this.IsQtaActive || this.IsQtaEnd || this.IsQtaPause || this.QtaContext == null)
		{
			return;
		}
		this.IsQtaPlayStart = true;
		base.SetUiActive(true);
		this.SetSelfActive(true);
		this.SetActive(true);
		this.BindAction();
		QtaCustomizationLimitedHoldLogic qtaCustomizationLimitedHoldLogic = this.QtaContext.QtaCustomizationLogic as QtaCustomizationLimitedHoldLogic;
		if (qtaCustomizationLimitedHoldLogic != null)
		{
			QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
			if (bgBarLogic != null)
			{
				bgBarLogic.SetBgParam(qtaCustomizationLimitedHoldLogic.GetBgValue(0));
			}
			QtaCustomizationLimitedHoldItemBar bgBarLogic2 = this.BgBarLogic;
			if (bgBarLogic2 != null)
			{
				bgBarLogic2.SetBgPercent(qtaCustomizationLimitedHoldLogic.GetBgProgress(0));
			}
		}
		this.QtaContext.UpdateTime(0f);
		QtaController.Instance.SetExpiredTimer(this.QtaContext);
		this.OnTick(0f);
	}

	// Token: 0x06014578 RID: 83320 RVA: 0x00526350 File Offset: 0x00524550
	private void RefreshValidState(bool valid, bool isStart = false)
	{
		if (isStart)
		{
			base.GetItem(2).SetUIActive(valid);
			base.GetItem(3).SetUIActive(!valid);
			return;
		}
		this.TweenAnimPlayer.StopTweenAnim((!valid) ? 6 : 7);
		this.TweenAnimPlayer.PlayTweenAnim(valid ? 6 : 7);
	}

	// Token: 0x06014579 RID: 83321 RVA: 0x005263A2 File Offset: 0x005245A2
	private void SetSelfActive(bool active)
	{
		if (!active)
		{
			base.Destroy(null);
			return;
		}
		if (this.IsQtaEnd)
		{
			return;
		}
		this.IsQtaStart = true;
		this.CanInteractive = true;
	}

	// Token: 0x0601457A RID: 83322 RVA: 0x005263C8 File Offset: 0x005245C8
	protected override void RefreshOnBattleUiVisibleChanged()
	{
		QtaCustomizationContext qtaContext = this.QtaContext;
		bool flag;
		if (qtaContext == null)
		{
			flag = true;
		}
		else
		{
			EQtaSource? source = qtaContext.Source;
			EQtaSource eqtaSource = EQtaSource.Battle;
			flag = !(source.GetValueOrDefault() == eqtaSource & source != null);
		}
		if (flag)
		{
			return;
		}
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQta);
		this.SetActive(childVisible);
	}

	// Token: 0x0601457B RID: 83323 RVA: 0x0052641C File Offset: 0x0052461C
	private void BindAction()
	{
		if (this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = true;
		if (!this.IsMobile)
		{
			foreach (string text in this.QtaActions)
			{
				InputDistributeController.Instance.BindActionIgnoreLimit(text, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				if (text == "幻象1")
				{
					InputDistributeController.Instance.BindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
				}
			}
		}
	}

	// Token: 0x0601457C RID: 83324 RVA: 0x005264C0 File Offset: 0x005246C0
	private void UnbindAction()
	{
		if (!this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = false;
		if (!this.IsMobile)
		{
			foreach (string text in this.QtaActions)
			{
				InputDistributeController.Instance.UnBindActionIgnoreLimit(text, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
				if (text == "幻象1")
				{
					InputDistributeController.Instance.UnBindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
				}
			}
		}
	}

	// Token: 0x0601457D RID: 83325 RVA: 0x00526564 File Offset: 0x00524764
	private void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
	{
		if (!base.IsValidInput())
		{
			return;
		}
		this.OnInput(actionType);
	}

	// Token: 0x0601457E RID: 83326 RVA: 0x00526578 File Offset: 0x00524778
	private void OnInputInteract(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification _)
	{
		if (Info.Instance.IsInGamepad())
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			GamepadSwitchInteractData gamepadSwitchInteractData;
			if (instance == null)
			{
				gamepadSwitchInteractData = null;
			}
			else
			{
				SkillButtonUiGamepadDataBase gamepadData = instance.GamepadData;
				gamepadSwitchInteractData = ((gamepadData != null) ? gamepadData.SwitchInteractData : null);
			}
			GamepadSwitchInteractData gamepadSwitchInteractData2 = gamepadSwitchInteractData;
			if (gamepadSwitchInteractData2 == null || !gamepadSwitchInteractData2.IsSwitchInteractOpen || gamepadSwitchInteractData2.State != EGamepadSwitchInteractState.Explore || !this.QtaActions.Contains("幻象1"))
			{
				return;
			}
		}
		this.OnInputCallback(actionName, actionType, _);
	}

	// Token: 0x0601457F RID: 83327 RVA: 0x005265DF File Offset: 0x005247DF
	private void OnInput(InputDistributeDefine.EActionType actionType)
	{
		if (this.QtaContext != null && this.QtaContext.IsActive() && this.QtaContext.IsPending())
		{
			this.QtaContext.QtaResponse(actionType == InputDistributeDefine.EActionType.Press);
		}
	}

	// Token: 0x06014580 RID: 83328 RVA: 0x00526612 File Offset: 0x00524812
	public override void OnQtaMoment(EQtaMomentName qtaMoment)
	{
		if (qtaMoment == EQtaMomentName.EnterValidRange)
		{
			this.RefreshValidState(true, false);
		}
		else if (qtaMoment == EQtaMomentName.ExitValidRange)
		{
			this.RefreshValidState(false, false);
		}
		QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
		if (bgBarLogic == null)
		{
			return;
		}
		bgBarLogic.SetValid(qtaMoment == EQtaMomentName.EnterValidRange);
	}

	// Token: 0x06014581 RID: 83329 RVA: 0x00526642 File Offset: 0x00524842
	protected override void HandleQtaEnd()
	{
		if (this.IsQtaEnd)
		{
			return;
		}
		this.IsQtaEnd = true;
		this.UnbindAction();
		base.ClearTickTimer();
		this.SetSelfActive(false);
	}

	// Token: 0x06014582 RID: 83330 RVA: 0x00526667 File Offset: 0x00524867
	protected override void OnQtaPause()
	{
		this.UnbindAction();
		if (this.QtaContext != null)
		{
			QtaController.Instance.PauseQta(this.QtaContext.HandleId);
		}
	}

	// Token: 0x06014583 RID: 83331 RVA: 0x0052668C File Offset: 0x0052488C
	protected override void OnQtaResume()
	{
		if (this.IsQtaPlayStart)
		{
			this.BindAction();
		}
		if (!this.IsQtaPlayStart)
		{
			base.PlayQtaStart();
		}
		if (this.QtaContext != null)
		{
			QtaController.Instance.ResumeQta(this.QtaContext.HandleId);
		}
	}

	// Token: 0x06014584 RID: 83332 RVA: 0x005266C8 File Offset: 0x005248C8
	protected override void OnTick(float delta)
	{
		UUIItem rootItem = this.RootItem;
		if (rootItem == null || !rootItem.IsValid())
		{
			this.HandleQtaEnd();
			return;
		}
		if (!this.IsQtaStart || this.IsQtaEnd || this.IsQtaPause)
		{
			return;
		}
		if (this.QtaContext == null || this.QtaContext.IsInvalid())
		{
			this.HandleQtaEnd();
			return;
		}
		this.QtaContext.UpdateTime(delta);
		if (!this.QtaContext.IsInvalid())
		{
			this.TmpRotation.Yaw = this.QtaContext.GetProgress() * 360f;
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIRelativeRotation(this.TmpRotation);
			}
			QtaCustomizationLimitedHoldItemBar bgBarLogic = this.BgBarLogic;
			if (bgBarLogic == null)
			{
				return;
			}
			QtaCustomizationBaseLogic qtaCustomizationLogic = this.QtaContext.QtaCustomizationLogic;
			bgBarLogic.SetBgPercent((qtaCustomizationLogic != null) ? qtaCustomizationLogic.GetBgProgress(0) : 0f);
		}
	}

	// Token: 0x040098EC RID: 39148
	private List<string> QtaActions = new List<string>();

	// Token: 0x040098ED RID: 39149
	private bool HasBindAction;

	// Token: 0x040098EE RID: 39150
	[Nullable(2)]
	private QtaCustomizationContext QtaContext;

	// Token: 0x040098EF RID: 39151
	[Nullable(2)]
	private QtaCustomizationLimitedHoldItemBar BgBarLogic;

	// Token: 0x040098F0 RID: 39152
	private FRotator TmpRotation = new FRotator();

	// Token: 0x02008D24 RID: 36132
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402DD09 RID: 187657
		public const int PnlBgBar = 0;

		// Token: 0x0402DD0A RID: 187658
		public const int BgItem = 1;

		// Token: 0x0402DD0B RID: 187659
		public const int Arrow1 = 2;

		// Token: 0x0402DD0C RID: 187660
		public const int Arrow2 = 3;

		// Token: 0x0402DD0D RID: 187661
		public const int PnlArrow = 4;

		// Token: 0x0402DD0E RID: 187662
		public const int AniIn = 5;

		// Token: 0x0402DD0F RID: 187663
		public const int AniToYellow = 6;

		// Token: 0x0402DD10 RID: 187664
		public const int AniToBlue = 7;

		// Token: 0x0402DD11 RID: 187665
		public const int AniSuccessOut = 8;

		// Token: 0x0402DD12 RID: 187666
		public const int AniNormalOut = 9;
	}
}
