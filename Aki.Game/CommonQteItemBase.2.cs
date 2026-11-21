using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B00 RID: 6912
[NullableContext(2)]
[Nullable(0)]
public abstract class CommonQteItemBase<[Nullable(0)] TContextType> : CommonQteItemBase where TContextType : CommonQteContextBase
{
	// Token: 0x06011349 RID: 70473 RVA: 0x0050EB9B File Offset: 0x0050CD9B
	protected override void OnRegisterComponent()
	{
		this.IsMobile = Info.Instance.IsInTouch();
	}

	// Token: 0x0601134A RID: 70474 RVA: 0x0050EBB0 File Offset: 0x0050CDB0
	protected override void OnStart()
	{
		UUIItem floatUnit = UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, 2);
		if (floatUnit != null)
		{
			this.GetOriginalItem().SetUIParent(floatUnit, false);
		}
	}

	// Token: 0x0601134B RID: 70475 RVA: 0x0050EBDC File Offset: 0x0050CDDC
	protected override void OnBeforeDestroy()
	{
		this.UnbindEvents();
		this.UnbindAction();
		if (!this.IsQteEnd)
		{
			TContextType tcontextType = this.CommonQteContext;
			if (tcontextType != null && tcontextType.IsActive())
			{
				CommonQteController.Instance.StopQte(this.CommonQteContext.HandleId);
			}
		}
		this.CommonQteContext = default(TContextType);
		this.QteHandle = -1;
		this.QteAction = "";
		this.ClearTickTimer();
		if (this.WorldUiRootOriginalDepth != null)
		{
			AActor worldSpaceUiRoot = UiLayer.Instance.WorldSpaceUiRoot;
			ULGUIWorldSpaceInteraction ulguiworldSpaceInteraction = ((worldSpaceUiRoot != null) ? worldSpaceUiRoot.GetComponentByClass(ULGUIWorldSpaceInteraction.StaticClass()) : null) as ULGUIWorldSpaceInteraction;
			if (ulguiworldSpaceInteraction != null)
			{
				ulguiworldSpaceInteraction.depth = this.WorldUiRootOriginalDepth.Value;
			}
			this.WorldUiRootOriginalDepth = null;
		}
	}

	// Token: 0x0601134C RID: 70476 RVA: 0x0050ECA8 File Offset: 0x0050CEA8
	protected void BindAction()
	{
		if (this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = true;
		if (!this.IsMobile && this.IsUseBaseAction() && !string.IsNullOrEmpty(this.QteAction))
		{
			InputDistributeController.Instance.BindActionIgnoreLimit(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
			if (this.QteAction == "幻象1")
			{
				InputDistributeController.Instance.BindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
			}
		}
		this.OnBindAction();
	}

	// Token: 0x0601134D RID: 70477 RVA: 0x0050ED34 File Offset: 0x0050CF34
	protected void UnbindAction()
	{
		if (!this.HasBindAction)
		{
			return;
		}
		this.HasBindAction = false;
		if (!this.IsMobile && this.IsUseBaseAction() && !string.IsNullOrEmpty(this.QteAction))
		{
			InputDistributeController.Instance.UnBindActionIgnoreLimit(this.QteAction, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputCallback));
			if (this.QteAction == "幻象1")
			{
				InputDistributeController.Instance.UnBindActionIgnoreLimit("通用交互", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputInteract));
			}
		}
		this.OnUnbindAction();
	}

	// Token: 0x0601134E RID: 70478 RVA: 0x0050EDBD File Offset: 0x0050CFBD
	protected virtual void OnBindAction()
	{
	}

	// Token: 0x0601134F RID: 70479 RVA: 0x0050EDBF File Offset: 0x0050CFBF
	protected virtual void OnUnbindAction()
	{
	}

	// Token: 0x06011350 RID: 70480 RVA: 0x0050EDC1 File Offset: 0x0050CFC1
	protected virtual bool IsUseBaseAction()
	{
		return true;
	}

	// Token: 0x06011351 RID: 70481 RVA: 0x0050EDC4 File Offset: 0x0050CFC4
	[NullableContext(1)]
	protected void OnInputCallback(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		if (!this.IsValidInput())
		{
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Press)
		{
			this.OnInputPress();
			return;
		}
		if (actionType == InputDistributeDefine.EActionType.Release)
		{
			this.OnInputRelease();
		}
	}

	// Token: 0x06011352 RID: 70482 RVA: 0x0050EDE4 File Offset: 0x0050CFE4
	[NullableContext(1)]
	private void OnInputInteract(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
	{
		if (Info.Instance.IsInGamepad())
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			bool flag;
			if (instance == null)
			{
				flag = false;
			}
			else
			{
				SkillButtonUiGamepadDataBase gamepadData = instance.GamepadData;
				flag = ((gamepadData != null) ? new bool?(gamepadData.SwitchInteractData.IsSwitchInteractOpen) : null).GetValueOrDefault();
			}
			if (flag)
			{
				SkillButtonUiModel instance2 = SkillButtonUiModel.Instance;
				bool flag2;
				if (instance2 == null)
				{
					flag2 = false;
				}
				else
				{
					SkillButtonUiGamepadDataBase gamepadData2 = instance2.GamepadData;
					flag2 = (((gamepadData2 != null) ? new EGamepadSwitchInteractState?(gamepadData2.SwitchInteractData.State) : null).GetValueOrDefault() == EGamepadSwitchInteractState.Explore);
				}
				if (flag2 && this.QteAction == "幻象1")
				{
					this.OnInputCallback(this.QteAction, actionType, inputIdentification);
					return;
				}
			}
		}
	}

	// Token: 0x06011353 RID: 70483 RVA: 0x0050EE96 File Offset: 0x0050D096
	protected virtual void OnInputPress()
	{
	}

	// Token: 0x06011354 RID: 70484 RVA: 0x0050EE98 File Offset: 0x0050D098
	protected virtual void OnInputRelease()
	{
	}

	// Token: 0x06011355 RID: 70485 RVA: 0x0050EE9A File Offset: 0x0050D09A
	public override void OnInputTest()
	{
		this.OnInputPress();
	}

	// Token: 0x06011356 RID: 70486 RVA: 0x0050EEA2 File Offset: 0x0050D0A2
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ResumeQte(false);
	}

	// Token: 0x06011357 RID: 70487 RVA: 0x0050EEB1 File Offset: 0x0050D0B1
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.PauseQte();
	}

	// Token: 0x06011358 RID: 70488 RVA: 0x0050EEC0 File Offset: 0x0050D0C0
	private void BindEvents()
	{
		if (this.IsBindEvents)
		{
			return;
		}
		this.IsBindEvents = true;
		EventSystem.Instance.Emit<string>(EEventName.DisableCustomInputData, this.RootActor.GetName());
		BattleUiModel.Instance.ChildViewData.AddCallback(EBattleUiChild.PanelQTE, new Action(this.OnBattleUiVisibleChanged));
		EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		EventSystem.Instance.Add<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
	}

	// Token: 0x06011359 RID: 70489 RVA: 0x0050EF4C File Offset: 0x0050D14C
	private void UnbindEvents()
	{
		if (!this.IsBindEvents)
		{
			return;
		}
		this.IsBindEvents = false;
		EventSystem.Instance.Emit<string>(EEventName.EnableCacheCustomInputData, this.RootActor.GetName());
		BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.PanelQTE, new Action(this.OnBattleUiVisibleChanged));
		EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnTriggerUiTimeDilation));
		EventSystem.Instance.Remove<int?>(EEventName.CommonQteEnd, new Action<int?>(this.OnCommonQteEnd));
	}

	// Token: 0x0601135A RID: 70490 RVA: 0x0050EFD8 File Offset: 0x0050D1D8
	private void OnCommonQteEnd(int? handleId)
	{
		int qteHandle = this.QteHandle;
		int? num = handleId;
		if (!(qteHandle == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.HandleQteEnd();
	}

	// Token: 0x0601135B RID: 70491 RVA: 0x0050F008 File Offset: 0x0050D208
	private void OnBattleUiVisibleChanged()
	{
		if (this.CommonQteContext == null || this.IsAttaching)
		{
			return;
		}
		EQteSource? source = this.CommonQteContext.Source;
		EQteSource eqteSource = EQteSource.Battle;
		if (!(source.GetValueOrDefault() == eqteSource & source != null))
		{
			return;
		}
		bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQTE);
		if (base.GetActive() != childVisible)
		{
			this.SetActive(childVisible);
		}
	}

	// Token: 0x0601135C RID: 70492 RVA: 0x0050F075 File Offset: 0x0050D275
	private void OnTriggerUiTimeDilation()
	{
		if (this.IsQteEnd)
		{
			return;
		}
		if (CommonQteController.Instance.IsSelfTriggeringTimeDilationChange())
		{
			return;
		}
		if (Time.Instance.TimeDilation == 0f)
		{
			this.PauseQte();
			return;
		}
		this.ResumeQte(true);
	}

	// Token: 0x0601135D RID: 70493 RVA: 0x0050F0AC File Offset: 0x0050D2AC
	protected void Tick(float delta)
	{
		if (this.IsKeepRelativeToCamera)
		{
			this.UpdateRelativeRotation();
		}
		else if (this.IsUseTargetScreenPos)
		{
			this.UpdateScreenPosition();
		}
		if (this.ScaleCurve != null)
		{
			this.UpdateScale();
		}
		this.OnTick(delta);
	}

	// Token: 0x0601135E RID: 70494 RVA: 0x0050F0E4 File Offset: 0x0050D2E4
	protected virtual void OnTick(float delta)
	{
		UUIItem originalItem = this.GetOriginalItem();
		if (originalItem == null || !originalItem.IsValid())
		{
			if (this.CommonQteContext == null || this.CommonQteContext.IsInvalid())
			{
				this.HandleQteEnd();
				return;
			}
			CommonQteController.Instance.StopQte(this.CommonQteContext.HandleId);
			return;
		}
		else
		{
			if (!this.IsQteStart || this.IsQteEnd || this.IsQtePause)
			{
				return;
			}
			if (this.CommonQteContext == null || this.CommonQteContext.IsInvalid())
			{
				this.HandleQteEnd();
				return;
			}
			this.CommonQteContext.UpdateTime(delta);
			if (this.CommonQteContext != null)
			{
				this.OnTickQteItem(delta);
			}
			CommonQteModel instance = CommonQteModel.Instance;
			if (instance != null && instance.IsRefreshMode)
			{
				this.RefreshUiOffset();
			}
			return;
		}
	}

	// Token: 0x0601135F RID: 70495 RVA: 0x0050F1C6 File Offset: 0x0050D3C6
	protected virtual void OnTickQteItem(float delta)
	{
	}

	// Token: 0x06011360 RID: 70496 RVA: 0x0050F1C8 File Offset: 0x0050D3C8
	protected void PauseQte()
	{
		if (this.IsQtePause || this.IsQteEnd)
		{
			return;
		}
		TimerHandle tickTimer = this.TickTimer;
		if (tickTimer != null)
		{
			tickTimer.Pause();
		}
		this.IsQtePause = true;
		if (this.IsQteActive)
		{
			this.OnQtePause();
		}
	}

	// Token: 0x06011361 RID: 70497 RVA: 0x0050F204 File Offset: 0x0050D404
	protected void ResumeQte(bool delay = false)
	{
		if (!this.IsQtePause || this.IsQteEnd)
		{
			return;
		}
		TimerHandle tickTimer = this.TickTimer;
		if (tickTimer != null)
		{
			tickTimer.Resume();
		}
		this.IsQtePause = false;
		if (this.IsQteActive)
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
					this.OnQteResume();
				}, null, null);
				return;
			}
			this.OnQteResume();
		}
	}

	// Token: 0x06011362 RID: 70498 RVA: 0x0050F266 File Offset: 0x0050D466
	protected virtual void OnQtePause()
	{
		if (this.CommonQteContext != null)
		{
			CommonQteController.Instance.PauseQte(this.CommonQteContext.HandleId);
		}
		this.UnbindAction();
	}

	// Token: 0x06011363 RID: 70499 RVA: 0x0050F298 File Offset: 0x0050D498
	protected virtual void OnQteResume()
	{
		if (this.CommonQteContext != null)
		{
			CommonQteController.Instance.ResumeQte(this.CommonQteContext.HandleId);
		}
		if (this.IsQteActive)
		{
			this.BindAction();
		}
		if (!this.IsQtePlayStart)
		{
			this.PlayQteStart();
		}
	}

	// Token: 0x06011364 RID: 70500 RVA: 0x0050F2E8 File Offset: 0x0050D4E8
	protected void HandleQteEnd()
	{
		if (this.IsQteEnd)
		{
			return;
		}
		this.IsQteEnd = true;
		this.OnHandleQteEnd();
		this.UnbindAction();
		this.ClearTickTimer();
	}

	// Token: 0x06011365 RID: 70501 RVA: 0x0050F30C File Offset: 0x0050D50C
	protected virtual void OnHandleQteEnd()
	{
	}

	// Token: 0x06011366 RID: 70502 RVA: 0x0050F30E File Offset: 0x0050D50E
	public bool IsValidInput()
	{
		return this.IsQteInteractive && !this.IsQteEnd && !this.IsQtePause;
	}

	// Token: 0x06011367 RID: 70503 RVA: 0x0050F32C File Offset: 0x0050D52C
	public unsafe override void PlayQteStart()
	{
		Log.Instance.Info(ELogModule.CommonQte, ELogAuthor.WWJ, "[CommonQteItemBase] PlayQteStart", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (this.IsQtePlayStart || !this.IsQteActive || this.IsQteEnd || this.IsQtePause || this.CommonQteContext == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "[CommonQteItemBase] PlayQteStart Failed";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsQtePlayStart", this.IsQtePlayStart);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsQteActive", this.IsQteActive);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsQteEnd", this.IsQteEnd);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("IsQtePause", this.IsQtePause);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("CommonQteContext", this.CommonQteContext != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return;
		}
		this.IsQtePlayStart = true;
		this.OnPlayQteStart();
		CommonQteController.Instance.SetExpiredTimer(this.CommonQteContext);
	}

	// Token: 0x06011368 RID: 70504 RVA: 0x0050F483 File Offset: 0x0050D683
	protected virtual void OnPlayQteStart()
	{
	}

	// Token: 0x06011369 RID: 70505 RVA: 0x0050F488 File Offset: 0x0050D688
	[NullableContext(1)]
	public override void SetQteContext(CommonQteContextBase context)
	{
		if (!this.IsContextMatched(context))
		{
			return;
		}
		this.QteHandle = context.HandleId;
		this.CommonQteContext = (TContextType)((object)context);
		string action = context.GetAction(null);
		if (!string.IsNullOrEmpty(action))
		{
			this.QteAction = action;
			this.OnRefreshActionUi(action);
		}
		this.IsQteInteractive = false;
		object uiConfig = context.GetUiConfig();
		if (uiConfig != null)
		{
			this.ApplyBaseUiConfig(uiConfig);
		}
		this.TryApplyQteUiConfig(uiConfig);
		this.TryApplyQteIcon(context);
		this.RefreshUiOffset();
		this.SetQteActive(context);
		this.PlayQteStart();
	}

	// Token: 0x0601136A RID: 70506 RVA: 0x0050F518 File Offset: 0x0050D718
	[NullableContext(1)]
	private void ApplyBaseUiConfig(object uiConfig)
	{
		SCommonQte_SingleClick scommonQte_SingleClick = uiConfig as SCommonQte_SingleClick;
		bool isQteInteractive;
		if (scommonQte_SingleClick == null)
		{
			SCommonQte_ContinuousClick scommonQte_ContinuousClick = uiConfig as SCommonQte_ContinuousClick;
			if (scommonQte_ContinuousClick == null)
			{
				SCommonQte_LongPress scommonQte_LongPress = uiConfig as SCommonQte_LongPress;
				if (scommonQte_LongPress == null)
				{
					SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
					isQteInteractive = (scommonQte_Drag != null && scommonQte_Drag.InteractiveTiming == ECommonQteInteractiveTiming.始终);
				}
				else
				{
					isQteInteractive = (scommonQte_LongPress.InteractiveTiming == ECommonQteInteractiveTiming.始终);
				}
			}
			else
			{
				isQteInteractive = (scommonQte_ContinuousClick.InteractiveTiming == ECommonQteInteractiveTiming.始终);
			}
		}
		else
		{
			isQteInteractive = (scommonQte_SingleClick.InteractiveTiming == ECommonQteInteractiveTiming.始终);
		}
		this.IsQteInteractive = isQteInteractive;
	}

	// Token: 0x0601136B RID: 70507 RVA: 0x0050F5AE File Offset: 0x0050D7AE
	[NullableContext(1)]
	protected virtual bool IsContextMatched(CommonQteContextBase context)
	{
		return context is TContextType;
	}

	// Token: 0x0601136C RID: 70508 RVA: 0x0050F5B9 File Offset: 0x0050D7B9
	[NullableContext(1)]
	protected virtual void OnRefreshActionUi(string action)
	{
	}

	// Token: 0x0601136D RID: 70509 RVA: 0x0050F5BB File Offset: 0x0050D7BB
	protected virtual void TryApplyQteUiConfig(object uiConfig)
	{
	}

	// Token: 0x0601136E RID: 70510 RVA: 0x0050F5C0 File Offset: 0x0050D7C0
	[NullableContext(1)]
	protected virtual void TryApplyQteIcon(CommonQteContextBase context)
	{
		IQteResource resource = context.Resource;
		ULGUITexturePackerSpriteData ulguitexturePackerSpriteData = (resource != null) ? resource.Icon : null;
		if (ulguitexturePackerSpriteData != null)
		{
			this.OnRefreshIcon(ulguitexturePackerSpriteData);
		}
	}

	// Token: 0x0601136F RID: 70511 RVA: 0x0050F5EA File Offset: 0x0050D7EA
	[NullableContext(1)]
	protected virtual void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
	{
	}

	// Token: 0x06011370 RID: 70512 RVA: 0x0050F5EC File Offset: 0x0050D7EC
	[NullableContext(1)]
	protected void SetQteActive(CommonQteContextBase context)
	{
		this.IsQteActive = true;
		this.ClearTickTimer();
		this.TickTimer = TimerSystem.Instance.Forever(new TTimerAction(this.Tick), this.TickInterval, 1f, null, null, true);
		if (context.IsAttachToActor())
		{
			SCommonQte_Attach? attachConfig = context.GetAttachConfig();
			if (attachConfig != null && attachConfig.GetValueOrDefault().UseTargetScreenPos)
			{
				this.AttachToTargetScreenPos(context);
			}
			else
			{
				this.AttachToTarget(context);
			}
			if (Time.Instance.TimeDilation == 0f)
			{
				this.PauseQte();
			}
		}
		else if (context.Source.GetValueOrDefault() == EQteSource.CG)
		{
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.VideoView);
			if (viewByName != null)
			{
				UUIItem rootItem = viewByName.GetRootItem();
				if (rootItem != null)
				{
					this.GetOriginalItem().SetUIParent(rootItem, false);
				}
			}
		}
		else
		{
			EQteSource? source = context.Source;
			EQteSource eqteSource = EQteSource.Battle;
			if (source.GetValueOrDefault() == eqteSource & source != null)
			{
				bool childVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.PanelQTE);
				if (base.GetActive() != childVisible)
				{
					this.SetActive(childVisible);
				}
				if (!childVisible || Time.Instance.TimeDilation == 0f)
				{
					this.PauseQte();
				}
			}
			else if (context.Source.GetValueOrDefault() == EQteSource.Level && Time.Instance.TimeDilation == 0f)
			{
				this.PauseQte();
			}
		}
		this.BindEvents();
		if (!this.IsQtePause)
		{
			this.BindAction();
		}
	}

	// Token: 0x06011371 RID: 70513 RVA: 0x0050F76C File Offset: 0x0050D96C
	[NullableContext(1)]
	protected void AttachToTarget(CommonQteContextBase context)
	{
		SCommonQte_Attach? attachConfig = context.GetAttachConfig();
		AActor attachTarget = context.GetAttachTarget();
		if (attachConfig == null || attachTarget == null)
		{
			return;
		}
		SCommonQte_Attach value = attachConfig.Value;
		this.OffsetRotator = Rotator.Create((float)value.Rotation.X, (float)value.Rotation.Y, (float)value.Rotation.Z);
		this.TempRotator = Rotator.Create();
		this.IsKeepRelativeToCamera = value.KeepRelativeToCamera;
		this.AttachTarget = attachTarget;
		USceneComponent parent = attachTarget.GetComponentByClass(USceneComponent.StaticClass()) as USceneComponent;
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor != null)
		{
			rootActor.K2_AttachToComponent(parent, null, EAttachmentRule.KeepRelative, this.IsKeepRelativeToCamera ? EAttachmentRule.KeepWorld : EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
		}
		this.UpdateRelativeRotation();
		Vector vector = Vector.Create(value.Location.X, value.Location.Y, value.Location.Z);
		FHitResult fhitResult = null;
		AUIBaseActor rootActor2 = this.RootActor;
		if (rootActor2 != null)
		{
			rootActor2.D_K2_SetActorRelativeLocation(vector.ToUeVector(false), false, ref fhitResult, true);
		}
		IQteResource resource = context.Resource;
		this.ScaleCurve = ((resource != null) ? resource.ScaleCurve : null);
		if (this.ScaleCurve != null)
		{
			this.TargetLocation = Vector.Create();
			this.ScaleVector = Vector.Create(1.0, 1.0, 1.0);
			this.UpdateScale();
		}
		this.IsAttaching = true;
		base.SetUiActive(true);
		if (context.Source.GetValueOrDefault() == EQteSource.Plot)
		{
			AActor uiRoot = UiLayer.Instance.UiRoot;
			ULGUIScreenSpaceInteraction ulguiscreenSpaceInteraction = ((uiRoot != null) ? uiRoot.GetComponentByClass(ULGUIScreenSpaceInteraction.StaticClass()) : null) as ULGUIScreenSpaceInteraction;
			AActor worldSpaceUiRoot = UiLayer.Instance.WorldSpaceUiRoot;
			ULGUIWorldSpaceInteraction ulguiworldSpaceInteraction = ((worldSpaceUiRoot != null) ? worldSpaceUiRoot.GetComponentByClass(ULGUIWorldSpaceInteraction.StaticClass()) : null) as ULGUIWorldSpaceInteraction;
			if (ulguiscreenSpaceInteraction != null && ulguiworldSpaceInteraction != null)
			{
				this.WorldUiRootOriginalDepth = new int?(ulguiworldSpaceInteraction.depth);
				ulguiworldSpaceInteraction.depth = ulguiscreenSpaceInteraction.depth + 1;
			}
		}
	}

	// Token: 0x06011372 RID: 70514 RVA: 0x0050F960 File Offset: 0x0050DB60
	private void UpdateRelativeRotation()
	{
		UUIItem attachRootItem = this.GetAttachRootItem();
		if (attachRootItem != null && this.TempRotator != null && this.OffsetRotator != null)
		{
			FRotator frotator;
			if (this.IsKeepRelativeToCamera)
			{
				Rotator cameraRotator = CameraController.Instance.MainModel.CameraRotator;
				float num = cameraRotator.Pitch - 90f;
				float num2 = cameraRotator.Yaw + 90f;
				this.TempRotator.Roll = this.OffsetRotator.Roll + num;
				this.TempRotator.Pitch = this.OffsetRotator.Pitch;
				this.TempRotator.Yaw = this.OffsetRotator.Yaw + num2;
				UUIItem uuiitem = attachRootItem;
				frotator = this.TempRotator.ToUeRotator();
				uuiitem.SetUIWorldRotation(frotator);
				return;
			}
			this.TempRotator.Roll = this.OffsetRotator.Roll - 90f;
			this.TempRotator.Pitch = this.OffsetRotator.Pitch;
			this.TempRotator.Yaw = this.OffsetRotator.Yaw;
			UUIItem uuiitem2 = attachRootItem;
			frotator = this.TempRotator.ToUeRotator();
			uuiitem2.SetUIRelativeRotation(frotator);
		}
	}

	// Token: 0x06011373 RID: 70515 RVA: 0x0050FA7C File Offset: 0x0050DC7C
	[NullableContext(1)]
	protected void AttachToTargetScreenPos(CommonQteContextBase context)
	{
		SCommonQte_Attach? attachConfig = context.GetAttachConfig();
		AActor attachTarget = context.GetAttachTarget();
		if (attachConfig == null || attachTarget == null)
		{
			return;
		}
		SCommonQte_Attach value = attachConfig.Value;
		this.IsUseTargetScreenPos = value.UseTargetScreenPos;
		this.AttachTarget = attachTarget;
		if (!this.IsInitPositionRef)
		{
			this.IsInitPositionRef = true;
			UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
			this.UiRootSize = Vector2D.Create((double)((uiRootItem != null) ? uiRootItem.GetWidth() : 0f), (double)((uiRootItem != null) ? uiRootItem.GetHeight() : 0f));
			this.PointTransform = Vector2D.Create(1.0, -1.0);
			this.UiPositionOffset = Vector2D.Create(value.Location.X, value.Location.Y);
			this.OffsetRotator = Rotator.Create((float)value.Rotation.X, (float)value.Rotation.Y, (float)value.Rotation.Z);
		}
		this.UpdateScreenPosition();
		this.IsAttaching = true;
		base.SetUiActive(true);
	}

	// Token: 0x06011374 RID: 70516 RVA: 0x0050FB8C File Offset: 0x0050DD8C
	protected void UpdateScreenPosition()
	{
		if (this.AttachTarget == null || !this.AttachTarget.IsValid())
		{
			return;
		}
		APlayerController characterController = Global.CharacterController;
		FVectorDouble fvectorDouble = this.AttachTarget.D_K2_GetActorLocation();
		if (!UGameplayStatics.D_ProjectWorldToScreen(characterController, fvectorDouble, ref this.ScreenPositionRef, false))
		{
			return;
		}
		FVector2D screenPositionRef = this.ScreenPositionRef;
		Global.CharacterController.GetViewportSize(ref this.ViewportSizeX, ref this.ViewportSizeY);
		int viewportSizeX = this.ViewportSizeX;
		if (this.UiRootSize == null || this.PointTransform == null || this.UiPositionOffset == null)
		{
			return;
		}
		Vector2D vector2D = Vector2D.Create();
		vector2D.FromUeVector2D(screenPositionRef);
		vector2D.MultiplyEqual((double)((float)(this.UiRootSize.X / (double)viewportSizeX)));
		Vector2D vector2D2 = Vector2D.Create();
		this.UiRootSize.Multiply(0.5, vector2D2);
		vector2D.SubtractionEqual(vector2D2);
		vector2D.MultiplyEqual(this.PointTransform);
		vector2D.AdditionEqual(this.UiPositionOffset);
		UUIItem attachRootItem = this.GetAttachRootItem();
		if (attachRootItem != null)
		{
			attachRootItem.SetAnchorOffset(vector2D.ToUeVector2D(false));
		}
		if (this.OffsetRotator != null && attachRootItem != null)
		{
			UUIItem uuiitem = attachRootItem;
			FRotator frotator = this.OffsetRotator.ToUeRotator();
			uuiitem.SetUIRelativeRotation(frotator);
		}
	}

	// Token: 0x06011375 RID: 70517 RVA: 0x0050FCB4 File Offset: 0x0050DEB4
	protected void UpdateScale()
	{
		if (this.AttachTarget == null || this.ScaleCurve == null || this.TargetLocation == null || this.ScaleVector == null)
		{
			return;
		}
		Vector cameraLocation = CameraController.Instance.MainModel.CameraLocation;
		FVectorDouble fvectorDouble = this.AttachTarget.D_K2_GetActorLocation();
		this.TargetLocation.FromUeVector(fvectorDouble);
		double num = Vector.DistSquared(cameraLocation, this.TargetLocation);
		CommonQteModel instance = CommonQteModel.Instance;
		if (instance != null)
		{
			bool isRefreshMode = instance.IsRefreshMode;
		}
		float floatValue = this.ScaleCurve.GetFloatValue((float)num);
		if (floatValue <= 0f)
		{
			return;
		}
		if (Math.Abs((float)(this.ScaleVector.Z - (double)floatValue)) > 0.01f)
		{
			this.ScaleVector.X = (double)floatValue;
			this.ScaleVector.Y = (double)floatValue;
			this.ScaleVector.Z = (double)floatValue;
			UUIItem attachRootItem = this.GetAttachRootItem();
			if (attachRootItem == null)
			{
				return;
			}
			FVector fvector = this.ScaleVector.ToUeVectorOld();
			attachRootItem.SetUIRelativeScale3D(fvector);
		}
	}

	// Token: 0x06011376 RID: 70518 RVA: 0x0050FD9F File Offset: 0x0050DF9F
	protected void ClearTickTimer()
	{
		if (this.TickTimer != null)
		{
			TimerSystem.Instance.Remove(this.TickTimer);
			this.TickTimer = null;
		}
	}

	// Token: 0x06011377 RID: 70519 RVA: 0x0050FDC1 File Offset: 0x0050DFC1
	protected UUIItem GetAttachRootItem()
	{
		return this.AttachRootItem ?? this.GetOriginalItem();
	}

	// Token: 0x06011378 RID: 70520 RVA: 0x0050FDD3 File Offset: 0x0050DFD3
	protected void SetAttachRootItem(UUIItem item)
	{
		this.AttachRootItem = item;
	}

	// Token: 0x06011379 RID: 70521 RVA: 0x0050FDDC File Offset: 0x0050DFDC
	[NullableContext(1)]
	public override void Reattach(CommonQteContextBase context)
	{
		this.IsInitPositionRef = false;
		if (this.IsUseTargetScreenPos)
		{
			this.AttachToTargetScreenPos(context);
			return;
		}
		this.AttachToTarget(context);
	}

	// Token: 0x0601137A RID: 70522 RVA: 0x0050FDFC File Offset: 0x0050DFFC
	protected virtual void RefreshUiOffset()
	{
	}

	// Token: 0x04009748 RID: 38728
	private const float SCALE_TOLERATION = 0.01f;

	// Token: 0x04009749 RID: 38729
	protected bool IsMobile;

	// Token: 0x0400974A RID: 38730
	protected bool IsQteActive;

	// Token: 0x0400974B RID: 38731
	protected bool IsQtePlayStart;

	// Token: 0x0400974C RID: 38732
	protected bool IsQteStart;

	// Token: 0x0400974D RID: 38733
	protected bool IsQteEnd;

	// Token: 0x0400974E RID: 38734
	protected bool IsQteInteractive;

	// Token: 0x0400974F RID: 38735
	protected bool IsQtePause;

	// Token: 0x04009750 RID: 38736
	protected bool HasBindAction;

	// Token: 0x04009751 RID: 38737
	[Nullable(1)]
	protected string QteAction = "";

	// Token: 0x04009752 RID: 38738
	protected int QteHandle = -1;

	// Token: 0x04009753 RID: 38739
	protected TContextType CommonQteContext;

	// Token: 0x04009754 RID: 38740
	protected bool IsBindEvents;

	// Token: 0x04009755 RID: 38741
	protected TimerHandle TickTimer;

	// Token: 0x04009756 RID: 38742
	protected Number TickInterval = 20;

	// Token: 0x04009757 RID: 38743
	protected bool IsAttaching;

	// Token: 0x04009758 RID: 38744
	protected bool IsKeepRelativeToCamera;

	// Token: 0x04009759 RID: 38745
	protected bool IsUseTargetScreenPos;

	// Token: 0x0400975A RID: 38746
	protected Rotator OffsetRotator;

	// Token: 0x0400975B RID: 38747
	protected Rotator TempRotator;

	// Token: 0x0400975C RID: 38748
	protected bool IsInitPositionRef;

	// Token: 0x0400975D RID: 38749
	protected FVector2D ScreenPositionRef;

	// Token: 0x0400975E RID: 38750
	protected int ViewportSizeX;

	// Token: 0x0400975F RID: 38751
	protected int ViewportSizeY;

	// Token: 0x04009760 RID: 38752
	protected Vector2D UiRootSize;

	// Token: 0x04009761 RID: 38753
	protected Vector2D PointTransform;

	// Token: 0x04009762 RID: 38754
	protected Vector2D UiPositionOffset;

	// Token: 0x04009763 RID: 38755
	protected AActor AttachTarget;

	// Token: 0x04009764 RID: 38756
	protected UUIItem AttachRootItem;

	// Token: 0x04009765 RID: 38757
	protected UCurveFloat ScaleCurve;

	// Token: 0x04009766 RID: 38758
	protected Vector ScaleVector;

	// Token: 0x04009767 RID: 38759
	protected Vector TargetLocation;

	// Token: 0x04009768 RID: 38760
	private int? WorldUiRootOriginalDepth;
}
