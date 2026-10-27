using System;
using System.Reflection;
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

// Token: 0x02002615 RID: 9749
[NullableContext(2)]
[Nullable(0)]
public abstract class CommonQteItemBase<[Nullable(0)] TContextType> : CommonQteItemBase where TContextType : CommonQteContextBase
{
	// Token: 0x06013E67 RID: 81511 RVA: 0x004FFD27 File Offset: 0x004FDF27
	protected override void OnRegisterComponent()
	{
		this.IsMobile = Info.Instance.IsInTouch();
	}

	// Token: 0x06013E68 RID: 81512 RVA: 0x004FFD3C File Offset: 0x004FDF3C
	protected override void OnStart()
	{
		UUIItem floatUnit = UiLayer.Instance.GetFloatUnit(ELayerType.BattleFloat, 2);
		if (floatUnit != null)
		{
			this.GetOriginalItem().SetUIParent(floatUnit, false);
		}
	}

	// Token: 0x06013E69 RID: 81513 RVA: 0x004FFD68 File Offset: 0x004FDF68
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

	// Token: 0x06013E6A RID: 81514 RVA: 0x004FFE34 File Offset: 0x004FE034
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

	// Token: 0x06013E6B RID: 81515 RVA: 0x004FFEC0 File Offset: 0x004FE0C0
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

	// Token: 0x06013E6C RID: 81516 RVA: 0x004FFF49 File Offset: 0x004FE149
	protected virtual void OnBindAction()
	{
	}

	// Token: 0x06013E6D RID: 81517 RVA: 0x004FFF4B File Offset: 0x004FE14B
	protected virtual void OnUnbindAction()
	{
	}

	// Token: 0x06013E6E RID: 81518 RVA: 0x004FFF4D File Offset: 0x004FE14D
	protected virtual bool IsUseBaseAction()
	{
		return true;
	}

	// Token: 0x06013E6F RID: 81519 RVA: 0x004FFF50 File Offset: 0x004FE150
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

	// Token: 0x06013E70 RID: 81520 RVA: 0x004FFF70 File Offset: 0x004FE170
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

	// Token: 0x06013E71 RID: 81521 RVA: 0x00500022 File Offset: 0x004FE222
	protected virtual void OnInputPress()
	{
	}

	// Token: 0x06013E72 RID: 81522 RVA: 0x00500024 File Offset: 0x004FE224
	protected virtual void OnInputRelease()
	{
	}

	// Token: 0x06013E73 RID: 81523 RVA: 0x00500026 File Offset: 0x004FE226
	public override void OnInputTest()
	{
		this.OnInputPress();
	}

	// Token: 0x06013E74 RID: 81524 RVA: 0x0050002E File Offset: 0x004FE22E
	protected override void OnAfterShow()
	{
		base.OnAfterShow();
		this.ResumeQte(false);
	}

	// Token: 0x06013E75 RID: 81525 RVA: 0x0050003D File Offset: 0x004FE23D
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		this.PauseQte();
	}

	// Token: 0x06013E76 RID: 81526 RVA: 0x0050004C File Offset: 0x004FE24C
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

	// Token: 0x06013E77 RID: 81527 RVA: 0x005000D8 File Offset: 0x004FE2D8
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

	// Token: 0x06013E78 RID: 81528 RVA: 0x00500164 File Offset: 0x004FE364
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

	// Token: 0x06013E79 RID: 81529 RVA: 0x00500194 File Offset: 0x004FE394
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

	// Token: 0x06013E7A RID: 81530 RVA: 0x00500201 File Offset: 0x004FE401
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

	// Token: 0x06013E7B RID: 81531 RVA: 0x00500238 File Offset: 0x004FE438
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

	// Token: 0x06013E7C RID: 81532 RVA: 0x00500270 File Offset: 0x004FE470
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

	// Token: 0x06013E7D RID: 81533 RVA: 0x00500352 File Offset: 0x004FE552
	protected virtual void OnTickQteItem(float delta)
	{
	}

	// Token: 0x06013E7E RID: 81534 RVA: 0x00500354 File Offset: 0x004FE554
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

	// Token: 0x06013E7F RID: 81535 RVA: 0x00500390 File Offset: 0x004FE590
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

	// Token: 0x06013E80 RID: 81536 RVA: 0x005003F2 File Offset: 0x004FE5F2
	protected virtual void OnQtePause()
	{
		if (this.CommonQteContext != null)
		{
			CommonQteController.Instance.PauseQte(this.CommonQteContext.HandleId);
		}
		this.UnbindAction();
	}

	// Token: 0x06013E81 RID: 81537 RVA: 0x00500424 File Offset: 0x004FE624
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

	// Token: 0x06013E82 RID: 81538 RVA: 0x00500474 File Offset: 0x004FE674
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

	// Token: 0x06013E83 RID: 81539 RVA: 0x00500498 File Offset: 0x004FE698
	protected virtual void OnHandleQteEnd()
	{
	}

	// Token: 0x06013E84 RID: 81540 RVA: 0x0050049A File Offset: 0x004FE69A
	public bool IsValidInput()
	{
		return this.IsQteInteractive && !this.IsQteEnd && !this.IsQtePause;
	}

	// Token: 0x06013E85 RID: 81541 RVA: 0x005004B8 File Offset: 0x004FE6B8
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

	// Token: 0x06013E86 RID: 81542 RVA: 0x0050060F File Offset: 0x004FE80F
	protected virtual void OnPlayQteStart()
	{
	}

	// Token: 0x06013E87 RID: 81543 RVA: 0x00500614 File Offset: 0x004FE814
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

	// Token: 0x06013E88 RID: 81544 RVA: 0x005006A4 File Offset: 0x004FE8A4
	[NullableContext(1)]
	private void ApplyBaseUiConfig(object uiConfig)
	{
		FieldInfo field = uiConfig.GetType().GetField("InteractiveTiming");
		if (field != null)
		{
			object value = field.GetValue(uiConfig);
			if (value is ECommonQteInteractiveTiming)
			{
				ECommonQteInteractiveTiming ecommonQteInteractiveTiming = (ECommonQteInteractiveTiming)value;
				this.IsQteInteractive = (ecommonQteInteractiveTiming == ECommonQteInteractiveTiming.始终);
			}
		}
	}

	// Token: 0x06013E89 RID: 81545 RVA: 0x005006EC File Offset: 0x004FE8EC
	[NullableContext(1)]
	protected virtual bool IsContextMatched(CommonQteContextBase context)
	{
		return context is TContextType;
	}

	// Token: 0x06013E8A RID: 81546 RVA: 0x005006F7 File Offset: 0x004FE8F7
	[NullableContext(1)]
	protected virtual void OnRefreshActionUi(string action)
	{
	}

	// Token: 0x06013E8B RID: 81547 RVA: 0x005006F9 File Offset: 0x004FE8F9
	protected virtual void TryApplyQteUiConfig(object uiConfig)
	{
	}

	// Token: 0x06013E8C RID: 81548 RVA: 0x005006FC File Offset: 0x004FE8FC
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

	// Token: 0x06013E8D RID: 81549 RVA: 0x00500726 File Offset: 0x004FE926
	[NullableContext(1)]
	protected virtual void OnRefreshIcon(ULGUITexturePackerSpriteData sprite)
	{
	}

	// Token: 0x06013E8E RID: 81550 RVA: 0x00500728 File Offset: 0x004FE928
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

	// Token: 0x06013E8F RID: 81551 RVA: 0x005008A8 File Offset: 0x004FEAA8
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

	// Token: 0x06013E90 RID: 81552 RVA: 0x00500A9C File Offset: 0x004FEC9C
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

	// Token: 0x06013E91 RID: 81553 RVA: 0x00500BB8 File Offset: 0x004FEDB8
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

	// Token: 0x06013E92 RID: 81554 RVA: 0x00500CC8 File Offset: 0x004FEEC8
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

	// Token: 0x06013E93 RID: 81555 RVA: 0x00500DF0 File Offset: 0x004FEFF0
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

	// Token: 0x06013E94 RID: 81556 RVA: 0x00500EDB File Offset: 0x004FF0DB
	protected void ClearTickTimer()
	{
		if (this.TickTimer != null)
		{
			TimerSystem.Instance.Remove(this.TickTimer);
			this.TickTimer = null;
		}
	}

	// Token: 0x06013E95 RID: 81557 RVA: 0x00500EFD File Offset: 0x004FF0FD
	protected UUIItem GetAttachRootItem()
	{
		return this.AttachRootItem ?? this.GetOriginalItem();
	}

	// Token: 0x06013E96 RID: 81558 RVA: 0x00500F0F File Offset: 0x004FF10F
	protected void SetAttachRootItem(UUIItem item)
	{
		this.AttachRootItem = item;
	}

	// Token: 0x06013E97 RID: 81559 RVA: 0x00500F18 File Offset: 0x004FF118
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

	// Token: 0x06013E98 RID: 81560 RVA: 0x00500F38 File Offset: 0x004FF138
	protected virtual void RefreshUiOffset()
	{
	}

	// Token: 0x040095F1 RID: 38385
	private const float SCALE_TOLERATION = 0.01f;

	// Token: 0x040095F2 RID: 38386
	protected bool IsMobile;

	// Token: 0x040095F3 RID: 38387
	protected bool IsQteActive;

	// Token: 0x040095F4 RID: 38388
	protected bool IsQtePlayStart;

	// Token: 0x040095F5 RID: 38389
	protected bool IsQteStart;

	// Token: 0x040095F6 RID: 38390
	protected bool IsQteEnd;

	// Token: 0x040095F7 RID: 38391
	protected bool IsQteInteractive;

	// Token: 0x040095F8 RID: 38392
	protected bool IsQtePause;

	// Token: 0x040095F9 RID: 38393
	protected bool HasBindAction;

	// Token: 0x040095FA RID: 38394
	[Nullable(1)]
	protected string QteAction = "";

	// Token: 0x040095FB RID: 38395
	protected int QteHandle = -1;

	// Token: 0x040095FC RID: 38396
	protected TContextType CommonQteContext;

	// Token: 0x040095FD RID: 38397
	protected bool IsBindEvents;

	// Token: 0x040095FE RID: 38398
	protected TimerHandle TickTimer;

	// Token: 0x040095FF RID: 38399
	protected Number TickInterval = 20;

	// Token: 0x04009600 RID: 38400
	protected bool IsAttaching;

	// Token: 0x04009601 RID: 38401
	protected bool IsKeepRelativeToCamera;

	// Token: 0x04009602 RID: 38402
	protected bool IsUseTargetScreenPos;

	// Token: 0x04009603 RID: 38403
	protected Rotator OffsetRotator;

	// Token: 0x04009604 RID: 38404
	protected Rotator TempRotator;

	// Token: 0x04009605 RID: 38405
	protected bool IsInitPositionRef;

	// Token: 0x04009606 RID: 38406
	protected FVector2D ScreenPositionRef;

	// Token: 0x04009607 RID: 38407
	protected int ViewportSizeX;

	// Token: 0x04009608 RID: 38408
	protected int ViewportSizeY;

	// Token: 0x04009609 RID: 38409
	protected Vector2D UiRootSize;

	// Token: 0x0400960A RID: 38410
	protected Vector2D PointTransform;

	// Token: 0x0400960B RID: 38411
	protected Vector2D UiPositionOffset;

	// Token: 0x0400960C RID: 38412
	protected AActor AttachTarget;

	// Token: 0x0400960D RID: 38413
	protected UUIItem AttachRootItem;

	// Token: 0x0400960E RID: 38414
	protected UCurveFloat ScaleCurve;

	// Token: 0x0400960F RID: 38415
	protected Vector ScaleVector;

	// Token: 0x04009610 RID: 38416
	protected Vector TargetLocation;

	// Token: 0x04009611 RID: 38417
	private int? WorldUiRootOriginalDepth;
}
