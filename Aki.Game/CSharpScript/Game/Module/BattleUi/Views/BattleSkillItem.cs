using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CEA RID: 23786
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillItem : BattleChildView
	{
		// Token: 0x17008E10 RID: 36368
		// (get) Token: 0x0603C340 RID: 246592 RVA: 0x00E68604 File Offset: 0x00E66804
		[Nullable(1)]
		protected BattleSkillUltraItem GetUltraComponent
		{
			[NullableContext(1)]
			get
			{
				if (this.UltraComponent == null)
				{
					UUIItem item = base.GetItem(8);
					this.UltraComponent = new BattleSkillUltraItem(item);
				}
				return this.UltraComponent;
			}
		}

		// Token: 0x17008E11 RID: 36369
		// (get) Token: 0x0603C341 RID: 246593 RVA: 0x00E68634 File Offset: 0x00E66834
		protected BattleSkillNumItem GetNumComponent
		{
			get
			{
				if (this.IsHideNumComp)
				{
					return null;
				}
				if (this.NumComponent == null)
				{
					UUIItem item = base.GetItem(8);
					this.NumComponent = new BattleSkillNumItem(item);
				}
				return this.NumComponent;
			}
		}

		// Token: 0x17008E12 RID: 36370
		// (get) Token: 0x0603C342 RID: 246594 RVA: 0x00E68670 File Offset: 0x00E66870
		protected BattleSkillDotIndicatorItem GetDotIndicatorComponent
		{
			get
			{
				ISkillButtonData skillButtonData = this.SkillButtonData;
				if (skillButtonData == null || !skillButtonData.IsEnableDotIndicator)
				{
					return null;
				}
				if (this.DotIndicatorComponent == null)
				{
					UUIItem item = base.GetItem(8);
					this.DotIndicatorComponent = new BattleSkillDotIndicatorItem(item);
				}
				return this.DotIndicatorComponent;
			}
		}

		// Token: 0x17008E13 RID: 36371
		// (get) Token: 0x0603C343 RID: 246595 RVA: 0x00E686B8 File Offset: 0x00E668B8
		[Nullable(1)]
		protected BattleSkillSwitchComponent GetSwitchComponent
		{
			[NullableContext(1)]
			get
			{
				if (this.SwitchComponent == null)
				{
					UUIItem item = base.GetItem(8);
					this.SwitchComponent = new BattleSkillSwitchComponent();
					this.SwitchComponent.CreateByResourceIdAsync("UiItem_BattleSkillSwitchItem", item, false).Forget();
				}
				return this.SwitchComponent;
			}
		}

		// Token: 0x17008E14 RID: 36372
		// (get) Token: 0x0603C344 RID: 246596 RVA: 0x00E68700 File Offset: 0x00E66900
		[Nullable(1)]
		protected BattleSkillLongPressItem GetLongPressComponent
		{
			[NullableContext(1)]
			get
			{
				if (this.LongPressComponent == null)
				{
					UUIItem item = base.GetItem(8);
					this.LongPressComponent = new BattleSkillLongPressItem();
					this.LongPressComponent.CreateByResourceIdAsync("UiItem_BattleSkillLongPressItem", item, false).Forget();
				}
				return this.LongPressComponent;
			}
		}

		// Token: 0x17008E15 RID: 36373
		// (get) Token: 0x0603C345 RID: 246597 RVA: 0x00E68748 File Offset: 0x00E66948
		[Nullable(1)]
		protected BattleSkillConfigLongPressItem GetConfigLongPressComponent
		{
			[NullableContext(1)]
			get
			{
				if (this.ConfigLongPressComponent == null)
				{
					UUIItem item = base.GetItem(8);
					this.ConfigLongPressComponent = new BattleSkillConfigLongPressItem();
					this.ConfigLongPressComponent.CreateByResourceIdAsync("UiItem_BattleSkillLongPressItem", item, false).Forget();
				}
				return this.ConfigLongPressComponent;
			}
		}

		// Token: 0x0603C346 RID: 246598 RVA: 0x00E6878D File Offset: 0x00E6698D
		protected UUIItem GetExtraContainer()
		{
			return base.GetItem(8);
		}

		// Token: 0x0603C347 RID: 246599 RVA: 0x00E68796 File Offset: 0x00E66996
		protected virtual UUIButtonComponent GetPointEventButton()
		{
			return this.SkillButton;
		}

		// Token: 0x0603C348 RID: 246600 RVA: 0x00E687A0 File Offset: 0x00E669A0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 14;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			if (!Info.Instance.IsInTouch())
			{
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(14, typeof(UUISprite)));
				this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(15, typeof(UUIItem)));
			}
		}

		// Token: 0x0603C349 RID: 246601 RVA: 0x00E689E0 File Offset: 0x00E66BE0
		public override void Initialize(object param = null)
		{
			base.Initialize(param);
			if (param is int)
			{
				int inputIndex = (int)param;
				this.InputIndex = inputIndex;
			}
			this.SkillButton = base.GetButton(5);
			this.CoolDownUiItem = base.GetItem(0);
			this.CoolDownUiText = base.GetText(2);
			this.CoolDownBarUiSprite = base.GetSprite(1);
			this.SkillTexture = base.GetTexture(4);
			this.SkillSprite = base.GetSprite(3);
			this.SkillTextureTransitionComp = (this.SkillTexture.GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent);
			this.SkillSpriteTransitionComp = (this.SkillSprite.GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition);
			this.DefaultSkillTextureData = this.SkillTexture.GetTexture();
			this.DefaultSkillSpriteData = this.SkillSprite.GetSprite();
			this.IsDefaultSkillTexture = true;
			this.IsDefaultSkillSprite = true;
			this.SkillNameText = base.GetText(11);
			this.ClickEffect = new BattleUiNiagaraItem(base.GetUiNiagara(10));
			this.DynamicEffect = new BattleSkillItemDynamicEffect(base.GetUiNiagara(7));
			base.GetUiNiagara(6).SetNiagaraUIActive(false, false);
			base.GetUiNiagara(7).SetNiagaraUIActive(false, true);
			this.AddEvents();
		}

		// Token: 0x0603C34A RID: 246602 RVA: 0x00E68B28 File Offset: 0x00E66D28
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleSkillItem.<InitializeAsync>d__85 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleSkillItem.<InitializeAsync>d__85>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C34B RID: 246603 RVA: 0x00E68B6C File Offset: 0x00E66D6C
		public virtual void Refresh(ISkillButtonData skillButtonData)
		{
			if (this.SkillButtonData != skillButtonData)
			{
				this.TryReleaseButton();
				BattleUiNiagaraItem clickEffect = this.ClickEffect;
				if (clickEffect != null)
				{
					clickEffect.Stop();
				}
				BattleSkillExtraEffectItem extraEffectComponent = this.ExtraEffectComponent;
				if (extraEffectComponent != null)
				{
					extraEffectComponent.Stop();
				}
				BattleUiModel.Instance.SlideControlData.OnRelease(this.RootItem);
				this.ResetButtonDisappearStateForReuse();
			}
			if (skillButtonData == null)
			{
				return;
			}
			this.SkillButtonData = skillButtonData;
			this.InitVehicleHandle();
			this.RefreshVisible();
			this.RefreshSkillIcon();
			this.RefreshSkillName();
			this.RefreshCdCompletedEffect();
			this.RefreshDynamicEffect();
			this.RefreshKey();
			this.RefreshTimeDilation();
			this.RefreshSkillCoolDown();
			this.RefreshLimitCount(true);
			this.RefreshDotIndicator(true);
			this.RefreshConfigLongPress(-1, 0);
			this.RefreshAttribute(false);
			if (this.RefreshSwitchComponentVisible())
			{
				this.RefreshEquipExplore();
			}
			this.RefreshSkillButtonLongPress();
			this.RefreshSlideControl();
			if (this.HasBattleLinkEvent)
			{
				this.RefreshLinkStatus(new int?(this.LinkStatus));
			}
		}

		// Token: 0x0603C34C RID: 246604 RVA: 0x00E68C58 File Offset: 0x00E66E58
		public virtual void Deactivate()
		{
			this.TryReleaseButton();
			this.ResetSkillCoolDown();
			this.RemoveLongPressTimer();
			this.RemoveEquipEffectTimer();
			BattleUiModel.Instance.SlideControlData.OnRelease(this.RootItem);
			this.ResetButtonDisappearStateForReuse();
			this.SkillButtonData = null;
			this.SetTextureHandleId = 0;
			this.OnCoolDownFinishedCallback = null;
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem != null)
			{
				keyItem.SetActive(false);
			}
			InputMultiKeyItem keyItem2 = this.KeyItem;
			if (keyItem2 != null)
			{
				keyItem2.ResetLongPress();
			}
			this.KeyActionName = null;
			this.KeyOperationType = null;
			this.PressActionType = CSharpScript.Game.Input.EInputAction.None;
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect != null)
			{
				clickEffect.Stop();
			}
			this.LinkStatus = 0;
			BattleSkillItemDynamicEffect dynamicEffect = this.DynamicEffect;
			if (dynamicEffect != null)
			{
				dynamicEffect.Reset();
			}
			this.CancelLoadCdCompletedNiagara();
			this.HideAndClearSkillSprite("休眠技能按钮");
			this.HideAndClearSkillTexture();
			this.SkillIconPath = null;
			if (this.UltraComponent != null)
			{
				this.UltraComponent.Destroy(null);
				this.UltraComponent = null;
			}
			if (this.NumComponent != null)
			{
				this.NumComponent.Destroy(null);
				this.NumComponent = null;
			}
			if (this.DotIndicatorComponent != null)
			{
				this.DotIndicatorComponent.Destroy(null);
				this.DotIndicatorComponent = null;
			}
			if (this.SwitchComponent != null)
			{
				this.SwitchComponent.Destroy(null);
				this.SwitchComponent = null;
			}
			if (this.LongPressComponent != null)
			{
				this.LongPressComponent.Destroy(null);
				this.LongPressComponent = null;
			}
			if (this.ExtraEffectComponent != null)
			{
				this.ExtraEffectComponent.Stop();
				this.ExtraEffectComponent.Destroy(null);
				this.ExtraEffectComponent = null;
			}
			this.OnRefreshVisible(false);
			this.OnDeactivate();
		}

		// Token: 0x0603C34D RID: 246605 RVA: 0x00E68DEF File Offset: 0x00E66FEF
		protected override void OnShowBattleChildView()
		{
			UUIItem parentItem = this.ParentItem;
			if (parentItem == null)
			{
				return;
			}
			parentItem.SetUIActive(true);
		}

		// Token: 0x0603C34E RID: 246606 RVA: 0x00E68E02 File Offset: 0x00E67002
		protected override void OnHideBattleChildView()
		{
			UUIItem parentItem = this.ParentItem;
			if (parentItem == null)
			{
				return;
			}
			parentItem.SetUIActive(false);
		}

		// Token: 0x0603C34F RID: 246607 RVA: 0x00E68E15 File Offset: 0x00E67015
		public void UpdateAlpha()
		{
			this.BaseAlpha = this.RootItem.GetAlpha();
			if (this.BaseAlpha > this.TargetAlpha)
			{
				this.RootItem.SetAlpha(this.TargetAlpha);
				return;
			}
			this.TargetAlpha = this.BaseAlpha;
		}

		// Token: 0x0603C350 RID: 246608 RVA: 0x00E68E54 File Offset: 0x00E67054
		public override void Reset()
		{
			this.RemoveEvents();
			this.Deactivate();
			this.SkillButton = null;
			this.KeyItem = null;
			this.ClickEffect = null;
			this.SkillIconPath = null;
			this.AlphaTweenComp = null;
			this.SkillTexture = null;
			this.SkillSprite = null;
			this.SkillTextureTransitionComp = null;
			this.SkillSpriteTransitionComp = null;
			this.DefaultSkillTextureData = null;
			this.DefaultSkillSpriteData = null;
			this.OnVisibleChangedCallback = null;
			base.Reset();
		}

		// Token: 0x0603C351 RID: 246609 RVA: 0x00E68EC7 File Offset: 0x00E670C7
		public virtual void Tick(float delta)
		{
			this.TickSkillCoolDown(delta);
			BattleSkillConfigLongPressItem configLongPressComponent = this.ConfigLongPressComponent;
			if (configLongPressComponent == null)
			{
				return;
			}
			configLongPressComponent.Tick(delta);
		}

		// Token: 0x0603C352 RID: 246610 RVA: 0x00E68EE4 File Offset: 0x00E670E4
		protected void AddEvents()
		{
			if (this.IsAddedEvents)
			{
				return;
			}
			this.GetPointEventButton().OnPointDownCallBack.Bind(new Action(this.OnSkillButtonPressed));
			this.GetPointEventButton().OnPointUpCallBack.Bind(new Action(this.OnSkillButtonPointUp));
			this.GetPointEventButton().OnPointCancelCallBack.Bind(new Action(this.OnSkillButtonCancel));
			this.DraggableComponent = (this.GetPointEventButton().GetOwner().GetComponentByClass(UUIDraggableComponent.StaticClass()) as UUIDraggableComponent);
			int[] touchIdList = new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9
			};
			InputDistributeController.Instance.BindTouches(touchIdList, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			if (BattleLinkModel.Instance.CheckInBattleLink())
			{
				this.HasBattleLinkEvent = true;
				EventSystem.Instance.Add<ELinkStatus>(EEventName.OnBattleLinkStatusChanged, new Action<ELinkStatus>(this.OnBattleLinkStatusChanged));
			}
			EventSystem.Instance.Add(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSelfCenteredMode));
			this.IsAddedEvents = true;
		}

		// Token: 0x0603C353 RID: 246611 RVA: 0x00E68FF4 File Offset: 0x00E671F4
		protected void RemoveEvents()
		{
			if (!this.IsAddedEvents)
			{
				return;
			}
			if (this.GetPointEventButton() != null)
			{
				this.GetPointEventButton().OnPointDownCallBack.Unbind();
				this.GetPointEventButton().OnPointUpCallBack.Unbind();
				this.GetPointEventButton().OnPointCancelCallBack.Unbind();
			}
			int[] touchIdList = new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9
			};
			InputDistributeController.Instance.UnBindTouches(touchIdList, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			if (this.HasBattleLinkEvent)
			{
				this.HasBattleLinkEvent = false;
				EventSystem.Instance.Remove(EEventName.OnBattleLinkStatusChanged, new Action<ELinkStatus>(this.OnBattleLinkStatusChanged));
			}
			EventSystem.Instance.Remove(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.OnSelfCenteredMode));
			this.IsAddedEvents = false;
		}

		// Token: 0x0603C354 RID: 246612 RVA: 0x00E690BB File Offset: 0x00E672BB
		protected void OnSelfCenteredMode(ESelfCenteredMode selfCenteredMode, float dilation)
		{
			if (TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId))
			{
				TimerSystem.Instance.ChangeDilation(this.ChangeCoolDownRefreshTimerId, 1f / dilation, null);
			}
		}

		// Token: 0x0603C355 RID: 246613 RVA: 0x00E690E8 File Offset: 0x00E672E8
		protected void OnBattleLinkStatusChanged(ELinkStatus status)
		{
			this.RefreshLinkStatus(new int?((int)status));
		}

		// Token: 0x0603C356 RID: 246614 RVA: 0x00E690F8 File Offset: 0x00E672F8
		protected void RefreshLinkStatus(int? status = null)
		{
			int num = status ?? this.LinkStatus;
			this.LinkStatus = num;
			if (this.SkillButtonData == null)
			{
				return;
			}
			CSharpScript.Game.Input.EInputAction actionType = this.SkillButtonData.GetActionType();
			if (actionType != CSharpScript.Game.Input.EInputAction.大招 && actionType != CSharpScript.Game.Input.EInputAction.技能1 && actionType != CSharpScript.Game.Input.EInputAction.攻击 && actionType != CSharpScript.Game.Input.EInputAction.幻象2)
			{
				if (this.IsPlayingLinkEffect)
				{
					base.GetUiNiagara(12).SetNiagaraUIActive(false, true);
					this.IsPlayingLinkEffect = false;
				}
				return;
			}
			if (actionType == CSharpScript.Game.Input.EInputAction.大招)
			{
				this.SetUltraComponentVisible(num != 4, BattleSkillItem.EUltraComponentVisibleReason.Link);
			}
			if (num == 4)
			{
				base.GetUiNiagara(12).SetNiagaraUIActive(true, true);
				this.IsPlayingLinkEffect = true;
				return;
			}
			base.GetUiNiagara(12).SetNiagaraUIActive(false, true);
			this.IsPlayingLinkEffect = false;
		}

		// Token: 0x0603C357 RID: 246615 RVA: 0x00E691DC File Offset: 0x00E673DC
		[NullableContext(1)]
		protected virtual void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
		{
			if (!this.IsLongPress && !this.EnableSlideControl)
			{
				return;
			}
			InputDistributeDefine.ETouchType touchType = touchData.TouchType;
			int fingerIndex = int.Parse(touchIdName);
			TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData((EFingerIndex)fingerIndex);
			USceneComponent usceneComponent;
			if (touchFingerData == null)
			{
				usceneComponent = null;
			}
			else
			{
				ULGUIPointerEventData pointerEventData = touchFingerData.GetPointerEventData();
				usceneComponent = ((pointerEventData != null) ? pointerEventData.pressComponent : null);
			}
			USceneComponent usceneComponent2 = usceneComponent;
			if (usceneComponent2 == null)
			{
				return;
			}
			if (usceneComponent2.GetOwner() != this.SkillButton.GetOwner())
			{
				return;
			}
			if (this.EnableSlideControl)
			{
				BattleUiModel.Instance.SlideControlData.OnTouch(touchData);
				return;
			}
			if (touchType != InputDistributeDefine.ETouchType.TouchMove)
			{
				return;
			}
			ControlScreenController.Instance.ExecuteCameraRotation((EFingerIndex)fingerIndex);
		}

		// Token: 0x0603C358 RID: 246616 RVA: 0x00E69270 File Offset: 0x00E67470
		protected virtual void OnSkillButtonPressed()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.IsEnableSlideControl)
			{
				FVector relativeLocation = this.RootItem.RelativeLocation;
				FVector relativeScale3D = this.RootItem.RelativeScale3D;
				BattleUiModel.Instance.SlideControlData.OnPress(this.RootItem, relativeLocation.X - 120f * relativeScale3D.X, relativeLocation.Y + 120f * relativeScale3D.Y);
				this.EnableSlideControl = true;
				return;
			}
			this.EnableSlideControl = false;
			if (this.SkillButtonData.IsEnableInput() && this.TargetAlpha != 0f)
			{
				CSharpScript.Game.Input.EInputAction actionType = this.SkillButtonData.GetActionType();
				this.OnInputAction(false);
				this.PressActionType = actionType;
				if (Info.Instance.OperationType == EOperationType.Pad)
				{
					string inputAction = this.SkillButtonData.GetInputAction();
					InputDistributeController.Instance.InputAction(inputAction, true);
				}
				else
				{
					InputController.Instance.InputAction(actionType, EInputState.Press);
				}
			}
			if (!this.IsNeedLongPress())
			{
				return;
			}
			double longPressTime = this.SkillButtonData.GetLongPressTime();
			if (longPressTime <= 0.0)
			{
				this.SkillButtonData.RefreshLongPressTime();
				longPressTime = this.SkillButtonData.GetLongPressTime();
			}
			if (longPressTime <= 0.0)
			{
				return;
			}
			this.LongPressTimerId = TimerSystem.Instance.Delay(new TTimerAction(this.OnLongPress), (float)longPressTime * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
		}

		// Token: 0x0603C359 RID: 246617 RVA: 0x00E693D8 File Offset: 0x00E675D8
		protected virtual bool IsNeedLongPress()
		{
			return this.SkillButtonData.GetIsLongPressControlCamera().Value;
		}

		// Token: 0x0603C35A RID: 246618 RVA: 0x00E693F8 File Offset: 0x00E675F8
		protected void OnSkillButtonPointUp()
		{
			this.OnSkillButtonReleased();
		}

		// Token: 0x0603C35B RID: 246619 RVA: 0x00E69400 File Offset: 0x00E67600
		protected virtual void OnSkillButtonReleased()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.EnableSlideControl)
			{
				BattleUiModel.Instance.SlideControlData.OnRelease(this.RootItem);
				this.EnableSlideControl = false;
			}
			if (this.PressActionType != CSharpScript.Game.Input.EInputAction.None)
			{
				CSharpScript.Game.Input.EInputAction actionType = this.SkillButtonData.GetActionType();
				if (this.PressActionType == actionType)
				{
					if (Info.Instance.OperationType == EOperationType.Pad)
					{
						string inputAction = this.SkillButtonData.GetInputAction();
						InputDistributeController.Instance.InputAction(inputAction, false);
					}
					else
					{
						InputController.Instance.InputAction(actionType, EInputState.Release);
					}
				}
				else if (Info.Instance.OperationType == EOperationType.Pad)
				{
					InputDistributeController.Instance.InputAction(this.PressActionType.Name, false);
				}
				else
				{
					InputController.Instance.InputAction(this.PressActionType, EInputState.Release);
				}
			}
			this.PressActionType = CSharpScript.Game.Input.EInputAction.None;
			this.RemoveLongPressTimer();
			this.IsLongPress = false;
		}

		// Token: 0x0603C35C RID: 246620 RVA: 0x00E694EE File Offset: 0x00E676EE
		protected virtual void OnSkillButtonCancel()
		{
			this.OnSkillButtonReleased();
		}

		// Token: 0x0603C35D RID: 246621 RVA: 0x00E694F6 File Offset: 0x00E676F6
		public void TryReleaseButton()
		{
			if (this.PressActionType != CSharpScript.Game.Input.EInputAction.None)
			{
				this.OnSkillButtonReleased();
			}
		}

		// Token: 0x0603C35E RID: 246622 RVA: 0x00E69510 File Offset: 0x00E67710
		private void OnLongPress(float _)
		{
			this.IsLongPress = true;
			this.OnLongPressButton();
		}

		// Token: 0x0603C35F RID: 246623 RVA: 0x00E6951F File Offset: 0x00E6771F
		protected virtual void OnLongPressButton()
		{
		}

		// Token: 0x0603C360 RID: 246624 RVA: 0x00E69524 File Offset: 0x00E67724
		public void SetSkillIcon(string skillIconPath)
		{
			if (string.IsNullOrEmpty(skillIconPath))
			{
				return;
			}
			if (this.SkillIconPath == skillIconPath)
			{
				return;
			}
			if (this.SetTextureHandleId != 0)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.SetTextureHandleId);
			}
			this.IsLoadingSkillIcon = true;
			UUITexture skillTexture = this.SkillTexture;
			UUISprite skillSprite = this.SkillSprite;
			this.SkillIconPath = skillIconPath;
			if (this.CheckSkillIconIsTexture(skillIconPath))
			{
				if (skillSprite != null)
				{
					this.HideAndClearSkillSprite("资源类型是Texture");
				}
				this.SetTextureHandleId = ResourceSystem.Instance.LoadAsync<UTexture>(skillIconPath, delegate([Nullable(2)] UTexture skillIconTexture, string _)
				{
					this.IsLoadingSkillIcon = false;
					if (skillTexture == null || this.SkillIconPath != skillIconPath)
					{
						return;
					}
					if (skillIconTexture == null)
					{
						this.HideAndClearSkillTexture();
						return;
					}
					this.ShowAndSetSkillTexture(skillIconTexture);
				}, 103, "js_undefined");
				this.SkillIconPath = skillIconPath;
				if (this.IsLoadingSkillIcon)
				{
					skillTexture.SetUIActive(false);
					return;
				}
			}
			else
			{
				this.HideAndClearSkillTexture();
				this.SetTextureHandleId = ResourceSystem.Instance.LoadAsync<ULGUISpriteData_BaseObject>(skillIconPath, delegate([Nullable(2)] ULGUISpriteData_BaseObject skillIconSprite, string _)
				{
					this.IsLoadingSkillIcon = false;
					if (skillSprite == null || this.SkillIconPath != skillIconPath)
					{
						return;
					}
					if (skillIconSprite == null)
					{
						this.HideAndClearSkillSprite("技能图标加载资源失败");
						return;
					}
					this.ShowAndSetSkillSprite(skillIconSprite);
				}, 103, "js_undefined");
				if (this.IsLoadingSkillIcon)
				{
					skillSprite.SetUIActive(false);
				}
			}
		}

		// Token: 0x0603C361 RID: 246625 RVA: 0x00E69658 File Offset: 0x00E67858
		[NullableContext(1)]
		protected virtual bool CheckSkillIconIsTexture(string skillIconPath)
		{
			return skillIconPath.Contains("Image/");
		}

		// Token: 0x0603C362 RID: 246626 RVA: 0x00E69668 File Offset: 0x00E67868
		protected void HideAndClearSkillTexture()
		{
			if (this.SkillTexture == null)
			{
				return;
			}
			if (!this.IsDefaultSkillTexture)
			{
				this.SkillTexture.SetTexture(this.DefaultSkillTextureData);
				UUITextureTransitionComponent skillTextureTransitionComp = this.SkillTextureTransitionComp;
				if (skillTextureTransitionComp != null)
				{
					skillTextureTransitionComp.SetAllStateTexture(this.DefaultSkillTextureData);
				}
				this.IsDefaultSkillTexture = true;
			}
			this.SkillTexture.SetUIActive(false);
		}

		// Token: 0x0603C363 RID: 246627 RVA: 0x00E696C1 File Offset: 0x00E678C1
		[NullableContext(1)]
		protected void ShowAndSetSkillTexture(UTexture textureData)
		{
			this.SkillTexture.SetTexture(textureData);
			UUITextureTransitionComponent skillTextureTransitionComp = this.SkillTextureTransitionComp;
			if (skillTextureTransitionComp != null)
			{
				skillTextureTransitionComp.SetAllStateTexture(textureData);
			}
			this.IsDefaultSkillTexture = false;
			this.SkillTexture.SetUIActive(true);
		}

		// Token: 0x0603C364 RID: 246628 RVA: 0x00E696F4 File Offset: 0x00E678F4
		[NullableContext(1)]
		protected void HideAndClearSkillSprite(string reason)
		{
			if (this.SkillSprite == null)
			{
				return;
			}
			if (!this.IsDefaultSkillSprite)
			{
				this.SkillSprite.SetSprite(this.DefaultSkillSpriteData, true);
				UUISpriteTransition skillSpriteTransitionComp = this.SkillSpriteTransitionComp;
				if (skillSpriteTransitionComp != null)
				{
					skillSpriteTransitionComp.SetAllTransitionSprite(this.DefaultSkillSpriteData);
				}
				this.IsDefaultSkillSprite = true;
			}
			this.SkillSprite.SetUIActive(false);
		}

		// Token: 0x0603C365 RID: 246629 RVA: 0x00E6974E File Offset: 0x00E6794E
		[NullableContext(1)]
		protected void ShowAndSetSkillSprite(ULGUISpriteData_BaseObject spriteData)
		{
			this.SkillSprite.SetSprite(spriteData, true);
			UUISpriteTransition skillSpriteTransitionComp = this.SkillSpriteTransitionComp;
			if (skillSpriteTransitionComp != null)
			{
				skillSpriteTransitionComp.SetAllTransitionSprite(spriteData);
			}
			this.IsDefaultSkillSprite = false;
			this.SkillSprite.SetUIActive(true);
		}

		// Token: 0x0603C366 RID: 246630 RVA: 0x00E69784 File Offset: 0x00E67984
		public virtual void RefreshSkillIcon()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.IsMultiStageSkill().GetValueOrDefault())
			{
				string multiSkillTexturePath = this.SkillButtonData.GetMultiSkillTexturePath();
				this.SetSkillIcon(multiSkillTexturePath);
				return;
			}
			string skillTexturePath = this.SkillButtonData.GetSkillTexturePath();
			this.SetSkillIcon(skillTexturePath);
		}

		// Token: 0x0603C367 RID: 246631 RVA: 0x00E697D8 File Offset: 0x00E679D8
		public virtual void RefreshSkillName()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			int? num = (skillButtonData != null) ? new int?(skillButtonData.GetSkillId()) : null;
			if (num == null)
			{
				this.SkillNameText.SetUIActive(false);
				return;
			}
			string skillIconName = this.SkillButtonData.GetSkillIconName();
			if (!string.IsNullOrEmpty(skillIconName))
			{
				LguiUtil.Instance.SetLocalTextNew(this.SkillNameText, skillIconName, Array.Empty<object>());
				this.SkillNameText.SetUIActive(true);
				return;
			}
			string skillNameBySkillId = SkillButtonUiModel.Instance.GetSkillNameBySkillId(num.Value);
			if (!string.IsNullOrEmpty(skillNameBySkillId))
			{
				LguiUtil.Instance.SetLocalTextNew(this.SkillNameText, skillNameBySkillId, Array.Empty<object>());
				this.SkillNameText.SetUIActive(true);
				return;
			}
			this.SkillNameText.SetUIActive(false);
		}

		// Token: 0x0603C368 RID: 246632 RVA: 0x00E6989B File Offset: 0x00E67A9B
		protected void SetSkillItemEnable(bool bVisible, bool bForce = false)
		{
			if (this.SkillButton == null)
			{
				return;
			}
			if (bForce)
			{
				this.SkillButton.SetSelfInteractive(bVisible);
				return;
			}
			if (this.SkillButton.GetSelfInteractive() != bVisible)
			{
				this.SkillButton.SetSelfInteractive(bVisible);
			}
		}

		// Token: 0x0603C369 RID: 246633 RVA: 0x00E698D0 File Offset: 0x00E67AD0
		public virtual void RefreshKey()
		{
			EOperationType operationType = Info.Instance.OperationType;
			if (operationType != EOperationType.Desktop)
			{
				return;
			}
			string actionName = this.SkillButtonData.GetActionName();
			if (this.KeyActionName == actionName)
			{
				EOperationType? keyOperationType = this.KeyOperationType;
				EOperationType eoperationType = operationType;
				if (keyOperationType.GetValueOrDefault() == eoperationType & keyOperationType != null)
				{
					return;
				}
			}
			if (this.KeyItem != null)
			{
				InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
				{
					ActionOrAxisName = actionName
				};
				this.KeyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
				this.KeyItem.SetActive(true);
			}
			this.KeyOperationType = new EOperationType?(operationType);
			this.KeyActionName = actionName;
		}

		// Token: 0x0603C36A RID: 246634 RVA: 0x00E69968 File Offset: 0x00E67B68
		public void PauseGame(int flag)
		{
			if (flag == 1)
			{
				if (TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId) && !TimerSystem.Instance.IsPause(this.ChangeCoolDownRefreshTimerId))
				{
					TimerSystem.Instance.Pause(this.ChangeCoolDownRefreshTimerId, null);
				}
				if (TimerSystem.Instance.Has(this.HideCdTimerId) && !TimerSystem.Instance.IsPause(this.HideCdTimerId))
				{
					TimerSystem.Instance.Pause(this.HideCdTimerId, null);
					return;
				}
			}
			else if (flag == 0)
			{
				if (TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId) && TimerSystem.Instance.IsPause(this.ChangeCoolDownRefreshTimerId))
				{
					TimerSystem.Instance.Resume(this.ChangeCoolDownRefreshTimerId);
				}
				if (TimerSystem.Instance.Has(this.HideCdTimerId) && TimerSystem.Instance.IsPause(this.HideCdTimerId))
				{
					TimerSystem.Instance.Resume(this.HideCdTimerId);
				}
			}
		}

		// Token: 0x0603C36B RID: 246635 RVA: 0x00E69A59 File Offset: 0x00E67C59
		public void RefreshSkillCoolDownOnShow()
		{
			if (this.CurrentCoolDownTime <= 0.0 || this.TotalCoolDownTime <= 0.0 || this.CoolDownBarUiSprite == null)
			{
				return;
			}
			this.RefreshSkillCoolDown();
		}

		// Token: 0x0603C36C RID: 246636 RVA: 0x00E69A8C File Offset: 0x00E67C8C
		public virtual void RefreshSkillCoolDown()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.TotalCoolDownCustom > 0)
			{
				this.RefreshLimitCount(true);
				this.PlaySkillCd(this.SkillButtonData.GetRemainingCoolDownCustom(), (float)this.SkillButtonData.TotalCoolDownCustom, this.SkillButtonData.HideCoolDownTextCustom);
				this.RefreshEnable(false);
				return;
			}
			if (this.IsSkillInItemUseBuffCd() && this.TryRefreshItemUseBuffCd())
			{
				this.RefreshEnable(false);
				return;
			}
			if (this.IsSkillInItemUseSkillCd() && this.TryRefreshItemUseSkillCd())
			{
				this.RefreshEnable(false);
				return;
			}
			if (this.SkillButtonData.IsMultiStageSkill().GetValueOrDefault() && this.TryRefreshMultiSkillCoolDown())
			{
				this.RefreshEnable(false);
				return;
			}
			if (this.IsVehicleSkillInCd() && this.TryRefreshVehicleSkillCd())
			{
				this.RefreshLimitCount(false);
				this.RefreshEnable(false);
				return;
			}
			this.RefreshLimitCount(false);
			this.TryRefreshCommonSkillCoolDown();
			this.RefreshEnable(false);
		}

		// Token: 0x0603C36D RID: 246637 RVA: 0x00E69B70 File Offset: 0x00E67D70
		public bool TryRefreshMultiSkillCoolDown()
		{
			MultiSkillInfo multiSkillInfo = this.SkillButtonData.GetMultiSkillInfo();
			if (multiSkillInfo != null)
			{
				int? nextSkillId = multiSkillInfo.NextSkillId;
				int num = 0;
				if (!(nextSkillId.GetValueOrDefault() == num & nextSkillId != null))
				{
					double remainingStartTime = multiSkillInfo.RemainingStartTime;
					float startTime = multiSkillInfo.StartTime;
					if (remainingStartTime > 0.0)
					{
						this.PlaySkillCd((float)remainingStartTime, startTime, false);
					}
					else
					{
						this.PlaySkillCd((float)multiSkillInfo.RemainingStopTime, multiSkillInfo.StopTime - startTime, true);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603C36E RID: 246638 RVA: 0x00E69BEC File Offset: 0x00E67DEC
		private void TryRefreshCommonSkillCoolDown()
		{
			if (this.SkillButtonData.GetSkillId() == -1)
			{
				this.PlaySkillCd(0f, 0f, false);
				return;
			}
			GroupSkillCdInfo groupSkillCdInfo = this.SkillButtonData.GetGroupSkillCdInfo();
			if (groupSkillCdInfo == null)
			{
				if (!this.SkillButtonData.HasCdComponent())
				{
					this.PlaySkillCd(0f, 0f, false);
				}
				return;
			}
			if (this.IsHideNumComp && groupSkillCdInfo.RemainingCount > 0)
			{
				this.PlaySkillCd(0f, 0f, false);
				return;
			}
			float curRemainingCd = groupSkillCdInfo.CurRemainingCd;
			float curMaxCd = groupSkillCdInfo.CurMaxCd;
			this.PlaySkillCd(curRemainingCd, curMaxCd, false);
		}

		// Token: 0x0603C36F RID: 246639 RVA: 0x00E69C81 File Offset: 0x00E67E81
		protected void PlaySkillCd(float remainingCoolDown, float totalCoolDown, bool hideCdText = false)
		{
			this.HideCdText = hideCdText;
			if (remainingCoolDown <= 0f || totalCoolDown <= 0f)
			{
				this.FinishSkillCoolDown();
				return;
			}
			if (this.SkillButtonData.IsCdVisible())
			{
				this.PlayCommonCd((double)remainingCoolDown, (double)totalCoolDown, null);
				return;
			}
			this.PlayHideCd(remainingCoolDown);
		}

		// Token: 0x0603C370 RID: 246640 RVA: 0x00E69CC4 File Offset: 0x00E67EC4
		private void PlayCommonCd(double remainingCoolDown, double totalCoolDown, Action additionalCdFinishedCb = null)
		{
			BattleSkillItem.<>c__DisplayClass123_0 CS$<>8__locals1 = new BattleSkillItem.<>c__DisplayClass123_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.additionalCdFinishedCb = additionalCdFinishedCb;
			BattleSkillItem.<>c__DisplayClass123_0 CS$<>8__locals2 = CS$<>8__locals1;
			ISkillButtonData skillButtonData = this.SkillButtonData;
			CS$<>8__locals2.skillId = ((skillButtonData != null) ? new int?(skillButtonData.GetSkillId()) : null);
			if (this.ShouldListenUltraAttribute())
			{
				this.RefreshMaxEnergyEffect(true, null, new bool?(true));
			}
			this.PlaySkillTimeDown(remainingCoolDown, totalCoolDown, new Action(CS$<>8__locals1.<PlayCommonCd>g__OnSkillCoolDownFinished|0));
		}

		// Token: 0x0603C371 RID: 246641 RVA: 0x00E69D3C File Offset: 0x00E67F3C
		private void PlayHideCd(float remainingCoolDown)
		{
			this.ResetSkillCoolDown();
			this.HideCdTimerId = TimerSystem.Instance.Delay(new TTimerAction(this.<PlayHideCd>g__OnHideCdFinish|124_0), remainingCoolDown * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			this.RefreshTimeDilationAtTimerCreate(this.HideCdTimerId);
		}

		// Token: 0x0603C372 RID: 246642 RVA: 0x00E69D8C File Offset: 0x00E67F8C
		private void ActivateCdCompletedNiagara()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.GetCdCompletedEffectId() < 0)
			{
				return;
			}
			if (this.TargetAlpha == 0f)
			{
				return;
			}
			UUINiagara uiNiagara = base.GetUiNiagara(6);
			if (!uiNiagara.bIsUIActive)
			{
				uiNiagara.SetUIActive(true);
			}
			uiNiagara.ActivateSystem(true);
		}

		// Token: 0x0603C373 RID: 246643 RVA: 0x00E69DE0 File Offset: 0x00E67FE0
		protected void PlaySkillTimeDown(double coolDownTime, double totalCoolDown, Action onCoolDownFinished = null)
		{
			this.ResetCoolDownTimer();
			this.CurrentCoolDownTime = 0.0;
			if (coolDownTime <= 0.0)
			{
				this.CoolDownUiItem.SetUIActive(false);
				return;
			}
			this.CurrentCoolDownTime = coolDownTime;
			this.TotalCoolDownTime = totalCoolDown;
			this.CoolDownStartTime = Time.Instance.FlowTime * TimeUtil.Instance.Millisecond - (totalCoolDown - coolDownTime);
			this.OnCoolDownFinishedCallback = onCoolDownFinished;
			UUIText coolDownUiText = this.CoolDownUiText;
			string newText;
			if (!this.HideCdText)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendLiteral("F");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.CdFixedPoint);
				newText = this.CurrentCoolDownTime.ToString(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			else
			{
				newText = string.Empty;
			}
			coolDownUiText.SetText(newText, true);
			this.ChangeCoolDownRefreshTimerId = TimerSystem.Instance.Forever(new TTimerAction(this.OnSkillCoolDownRefresh), 100f, 1f, null, null, true);
			this.RefreshTimeDilationAtTimerCreate(this.ChangeCoolDownRefreshTimerId);
			this.CoolDownUiItem.SetUIActive(true);
			if (SkillCdController.Instance.IsPause())
			{
				UUISprite coolDownBarUiSprite = this.CoolDownBarUiSprite;
				if (coolDownBarUiSprite == null)
				{
					return;
				}
				coolDownBarUiSprite.SetFillAmount((float)((totalCoolDown - coolDownTime) / totalCoolDown));
			}
		}

		// Token: 0x0603C374 RID: 246644 RVA: 0x00E69F04 File Offset: 0x00E68104
		private void OnSkillCoolDownRefresh(float delta)
		{
			this.CurrentCoolDownTime -= 0.1;
			this.CurrentCoolDownTime = (double)((float)Math.Round(this.CurrentCoolDownTime * 10.0) / 10f);
			if (this.CurrentCoolDownTime > 0.0)
			{
				if (!this.HideCdText)
				{
					UUIText coolDownUiText = this.CoolDownUiText;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
					defaultInterpolatedStringHandler.AppendLiteral("F");
					defaultInterpolatedStringHandler.AppendFormatted<int>(this.CdFixedPoint);
					coolDownUiText.SetText(this.CurrentCoolDownTime.ToString(defaultInterpolatedStringHandler.ToStringAndClear()), true);
					return;
				}
			}
			else
			{
				this.FinishSkillCoolDown();
			}
		}

		// Token: 0x0603C375 RID: 246645 RVA: 0x00E69FAA File Offset: 0x00E681AA
		protected void FinishSkillCoolDown()
		{
			this.ResetSkillCoolDown();
			if (this.OnCoolDownFinishedCallback != null)
			{
				Action onCoolDownFinishedCallback = this.OnCoolDownFinishedCallback;
				this.OnCoolDownFinishedCallback = null;
				onCoolDownFinishedCallback();
			}
		}

		// Token: 0x0603C376 RID: 246646 RVA: 0x00E69FCC File Offset: 0x00E681CC
		private void TickSkillCoolDown(float _)
		{
			if (this.CurrentCoolDownTime <= 0.0 || this.TotalCoolDownTime <= 0.0 || this.CoolDownBarUiSprite == null)
			{
				return;
			}
			double num = (Time.Instance.FlowTime * TimeUtil.Instance.Millisecond - this.CoolDownStartTime) / this.TotalCoolDownTime;
			this.CoolDownBarUiSprite.SetFillAmount((float)num);
		}

		// Token: 0x0603C377 RID: 246647 RVA: 0x00E6A035 File Offset: 0x00E68235
		public void ResetSkillCoolDown()
		{
			this.CoolDownUiItem.SetUIActive(false);
			this.ResetCoolDownTimer();
			this.CurrentCoolDownTime = 0.0;
		}

		// Token: 0x0603C378 RID: 246648 RVA: 0x00E6A058 File Offset: 0x00E68258
		private void ResetCoolDownTimer()
		{
			if (TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId))
			{
				TimerSystem.Instance.Remove(this.ChangeCoolDownRefreshTimerId);
			}
			if (TimerSystem.Instance.Has(this.HideCdTimerId))
			{
				TimerSystem.Instance.Remove(this.HideCdTimerId);
			}
		}

		// Token: 0x0603C379 RID: 246649 RVA: 0x00E6A0AC File Offset: 0x00E682AC
		public virtual void RefreshEnable(bool bForce = false)
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			bool bVisible = this.IsInputEnable();
			this.SetSkillItemEnable(bVisible, bForce);
		}

		// Token: 0x0603C37A RID: 246650 RVA: 0x00E6A0D1 File Offset: 0x00E682D1
		public void DisableButton()
		{
			this.SetSkillItemEnable(false, true);
		}

		// Token: 0x0603C37B RID: 246651 RVA: 0x00E6A0DC File Offset: 0x00E682DC
		public virtual void RefreshVisible()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem == null || !rootItem.IsValid())
			{
				return;
			}
			bool flag = this.IsVisible();
			if (flag == this.RootItem.bIsUIActive && (this.ParentItem == null || flag == this.ParentItem.bIsUIActive))
			{
				return;
			}
			this.OnRefreshVisible(flag);
		}

		// Token: 0x0603C37C RID: 246652 RVA: 0x00E6A134 File Offset: 0x00E68334
		protected void OnRefreshVisible(bool bIsVisible)
		{
			if (bIsVisible)
			{
				if (!base.IsShowOrShowing)
				{
					base.Show(null);
					this.RefreshEnable(true);
					Action onVisibleChangedCallback = this.OnVisibleChangedCallback;
					if (onVisibleChangedCallback == null)
					{
						return;
					}
					onVisibleChangedCallback();
					return;
				}
			}
			else if (!base.IsHideOrHiding)
			{
				this.TryReleaseButton();
				base.Hide(null);
				Action onVisibleChangedCallback2 = this.OnVisibleChangedCallback;
				if (onVisibleChangedCallback2 == null)
				{
					return;
				}
				onVisibleChangedCallback2();
			}
		}

		// Token: 0x0603C37D RID: 246653 RVA: 0x00E6A190 File Offset: 0x00E68390
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public UUIItem[] GetGuideItem()
		{
			if (base.IsCreateOrCreating)
			{
				return null;
			}
			UUIItem uuiitem = base.GetTexture(4);
			if (uuiitem == null)
			{
				return null;
			}
			if (!ObjectUtils.IsValid(uuiitem) || !uuiitem.IsUIActiveInHierarchy())
			{
				uuiitem = base.GetSprite(3);
				if (uuiitem == null)
				{
					return null;
				}
			}
			return new UUIItem[]
			{
				this.RootItem,
				uuiitem
			};
		}

		// Token: 0x0603C37E RID: 246654 RVA: 0x00E6A1E4 File Offset: 0x00E683E4
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public UUIItem[] GetSpriteGuideItem()
		{
			if (base.IsCreateOrCreating)
			{
				return null;
			}
			UUISprite sprite = base.GetSprite(3);
			if (sprite == null)
			{
				return null;
			}
			if (!ObjectUtils.IsValid(sprite))
			{
				return null;
			}
			return new UUIItem[]
			{
				this.RootItem,
				sprite
			};
		}

		// Token: 0x0603C37F RID: 246655 RVA: 0x00E6A228 File Offset: 0x00E68428
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public UUIItem[] GetTextureGuideItem()
		{
			if (base.IsCreateOrCreating)
			{
				return null;
			}
			UUITexture texture = base.GetTexture(4);
			if (texture == null)
			{
				return null;
			}
			if (!ObjectUtils.IsValid(texture))
			{
				return null;
			}
			return new UUIItem[]
			{
				this.RootItem,
				texture
			};
		}

		// Token: 0x0603C380 RID: 246656 RVA: 0x00E6A26C File Offset: 0x00E6846C
		protected void RefreshCdCompletedEffect()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.GetCdCompletedEffectId() <= 0)
			{
				return;
			}
			if (this.SkillButtonData.AttributeId > EAttributeType.None)
			{
				return;
			}
			SkillButtonEffect? cdCompletedEffectConfig = this.SkillButtonData.GetCdCompletedEffectConfig();
			if (cdCompletedEffectConfig == null)
			{
				return;
			}
			string niagaraPath = cdCompletedEffectConfig.Value.NiagaraPath;
			if (string.IsNullOrEmpty(niagaraPath))
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.CdCompletedEffectPath) && this.CdCompletedEffectPath == niagaraPath)
			{
				return;
			}
			this.CancelLoadCdCompletedNiagara();
			this.LoadCdCompletedNiagaraHandleId = new int?(ResourceSystem.Instance.LoadAsync<UNiagaraSystem>(niagaraPath, delegate([Nullable(2)] UNiagaraSystem effectObject, string _)
			{
				if (effectObject == null || !effectObject.IsValid())
				{
					return;
				}
				UUINiagara uiNiagara = base.GetUiNiagara(6);
				if (uiNiagara == null)
				{
					return;
				}
				uiNiagara.SetNiagaraSystem(effectObject);
			}, 100, "js_undefined"));
			this.CdCompletedEffectPath = niagaraPath;
		}

		// Token: 0x0603C381 RID: 246657 RVA: 0x00E6A321 File Offset: 0x00E68521
		protected void CancelLoadCdCompletedNiagara()
		{
			if (this.LoadCdCompletedNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadCdCompletedNiagaraHandleId.Value);
			this.LoadCdCompletedNiagaraHandleId = null;
		}

		// Token: 0x0603C382 RID: 246658 RVA: 0x00E6A354 File Offset: 0x00E68554
		protected virtual SkillButtonEffect? GetDynamicEffectConfig()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			if (skillButtonData == null)
			{
				return null;
			}
			return skillButtonData.GetDynamicEffectConfig();
		}

		// Token: 0x0603C383 RID: 246659 RVA: 0x00E6A37A File Offset: 0x00E6857A
		protected void CancelLoadDynamicEffectNiagara()
		{
			this.DynamicEffect.CancelLoadDynamicEffectNiagara();
		}

		// Token: 0x0603C384 RID: 246660 RVA: 0x00E6A388 File Offset: 0x00E68588
		public virtual void RefreshDynamicEffect()
		{
			SkillButtonEffect? dynamicEffectConfig = this.GetDynamicEffectConfig();
			this.DynamicEffect.RefreshDynamicEffect(dynamicEffectConfig);
		}

		// Token: 0x0603C385 RID: 246661 RVA: 0x00E6A3A8 File Offset: 0x00E685A8
		protected void SetDynamicEffectVisible(bool visible)
		{
			this.DynamicEffect.SetDynamicEffectVisible(visible);
		}

		// Token: 0x0603C386 RID: 246662 RVA: 0x00E6A3B6 File Offset: 0x00E685B6
		public void RefreshTimeDilation()
		{
			this.SetTimeDilation(this.GetTimeDilation());
		}

		// Token: 0x0603C387 RID: 246663 RVA: 0x00E6A3C4 File Offset: 0x00E685C4
		private float GetTimeDilation()
		{
			if (SkillCdController.Instance.IsPause())
			{
				return 0f;
			}
			return Time.Instance.TimeDilation;
		}

		// Token: 0x0603C388 RID: 246664 RVA: 0x00E6A3E4 File Offset: 0x00E685E4
		[NullableContext(1)]
		private void RefreshTimeDilationAtTimerCreate(TimerHandle timerId)
		{
			float num = this.GetTimeDilation() * CharacterModel.Instance.InverseSelfCenteredTimeDilation;
			if (num != 1f)
			{
				if (num > 0f)
				{
					TimerSystem.Instance.ChangeDilation(timerId, num, null);
					return;
				}
				TimerSystem.Instance.Pause(timerId, null);
			}
		}

		// Token: 0x0603C389 RID: 246665 RVA: 0x00E6A430 File Offset: 0x00E68630
		private void SetTimeDilation(float timeDilation)
		{
			if (TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId))
			{
				if (timeDilation > 0f)
				{
					if (TimerSystem.Instance.IsPause(this.ChangeCoolDownRefreshTimerId))
					{
						TimerSystem.Instance.Resume(this.ChangeCoolDownRefreshTimerId);
					}
					TimerSystem.Instance.ChangeDilation(this.ChangeCoolDownRefreshTimerId, timeDilation * CharacterModel.Instance.InverseSelfCenteredTimeDilation, null);
				}
				else if (!TimerSystem.Instance.IsPause(this.ChangeCoolDownRefreshTimerId))
				{
					TimerSystem.Instance.Pause(this.ChangeCoolDownRefreshTimerId, null);
				}
			}
			if (TimerSystem.Instance.Has(this.HideCdTimerId))
			{
				if (timeDilation > 0f)
				{
					if (TimerSystem.Instance.IsPause(this.HideCdTimerId))
					{
						TimerSystem.Instance.Resume(this.HideCdTimerId);
					}
					TimerSystem.Instance.ChangeDilation(this.HideCdTimerId, timeDilation, null);
					return;
				}
				if (!TimerSystem.Instance.IsPause(this.HideCdTimerId))
				{
					TimerSystem.Instance.Pause(this.HideCdTimerId, null);
				}
			}
		}

		// Token: 0x0603C38A RID: 246666 RVA: 0x00E6A533 File Offset: 0x00E68733
		private void RemoveLongPressTimer()
		{
			if (this.LongPressTimerId == null)
			{
				return;
			}
			if (!TimerSystem.Instance.Has(this.LongPressTimerId))
			{
				return;
			}
			TimerSystem.Instance.Remove(this.LongPressTimerId);
			this.LongPressTimerId = null;
		}

		// Token: 0x0603C38B RID: 246667 RVA: 0x00E6A56C File Offset: 0x00E6876C
		private bool RefreshSwitchComponentVisible()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			bool flag = skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && !this.SkillButtonData.HasConfigFollower();
			if (this.SwitchComponent != null)
			{
				this.GetSwitchComponent.SetComponentActive(flag);
			}
			else if (flag)
			{
				this.GetSwitchComponent.SetComponentActive(flag);
			}
			return flag;
		}

		// Token: 0x0603C38C RID: 246668 RVA: 0x00E6A5C8 File Offset: 0x00E687C8
		public void RefreshAttribute(bool bBurstMaxEffect = true)
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			if (skillButtonData == null || skillButtonData.AttributeUsageMode != ESkillButtonAttributeUsageMode.RecoverWithStack)
			{
				bool flag = this.HasListenAttribute();
				BattleSkillUltraItem ultraComponent = this.UltraComponent;
				bool? flag2 = (ultraComponent != null) ? new bool?(ultraComponent.Visible) : null;
				bool? flag3 = flag2;
				bool flag4 = flag;
				if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
				{
					this.SetUltraComponentVisible(flag, BattleSkillItem.EUltraComponentVisibleReason.Attribute);
					if (flag2.GetValueOrDefault())
					{
						this.DeactivateMaxEnergyEffect();
					}
				}
				if (flag)
				{
					this.RefreshFrameSprite();
					this.LoadMaxAttributeEffect();
					this.LoadMaxAttributeBurstEffect();
					this.RefreshAttributePercent(bBurstMaxEffect);
				}
				this.RefreshEnable(false);
				return;
			}
			BattleSkillConfigLongPressItem configLongPressComponent = this.ConfigLongPressComponent;
			if (configLongPressComponent == null)
			{
				return;
			}
			configLongPressComponent.RefreshAttributeValue(this.SkillButtonData.GetAttribute());
		}

		// Token: 0x0603C38D RID: 246669 RVA: 0x00E6A684 File Offset: 0x00E68884
		private void SetUltraComponentVisible(bool visible, BattleSkillItem.EUltraComponentVisibleReason reason)
		{
			this.UltraComponentVisibleState = VisibleStateUtil.SetVisible(this.UltraComponentVisibleState, visible, (int)reason);
			bool visible2 = VisibleStateUtil.GetVisible(this.UltraComponentVisibleState);
			if (this.UltraComponent != null)
			{
				this.GetUltraComponent.SetComponentActive(visible2);
				return;
			}
			if (visible2)
			{
				this.GetUltraComponent.SetComponentActive(visible2);
			}
		}

		// Token: 0x0603C38E RID: 246670 RVA: 0x00E6A6D4 File Offset: 0x00E688D4
		protected void RefreshFrameSprite()
		{
			if (this.ShouldListenUltraAttribute())
			{
				FColor? frameSpriteColor = this.SkillButtonData.GetFrameSpriteColor();
				this.GetUltraComponent.SetFrameSprite(frameSpriteColor.Value);
			}
		}

		// Token: 0x0603C38F RID: 246671 RVA: 0x00E6A708 File Offset: 0x00E68908
		private void RefreshAttributePercent(bool bBurstMaxEffect = true)
		{
			float attribute = this.SkillButtonData.GetAttribute();
			float maxAttribute = this.SkillButtonData.GetMaxAttribute();
			if (maxAttribute == 0f)
			{
				this.SetEnergyPercent(1f, bBurstMaxEffect);
				this.RefreshMaxEnergyEffect(bBurstMaxEffect, new bool?(false), null);
				return;
			}
			this.SetEnergyPercent(attribute / maxAttribute, bBurstMaxEffect);
			this.RefreshMaxEnergyEffect(bBurstMaxEffect, new bool?(attribute < maxAttribute), null);
		}

		// Token: 0x0603C390 RID: 246672 RVA: 0x00E6A77C File Offset: 0x00E6897C
		private void RefreshMaxEnergyEffect(bool refreshMaxEffectTip, bool? energyNoEnough, bool? inCoolDown)
		{
			bool? flag = energyNoEnough;
			bool? flag2 = inCoolDown;
			if (!flag.GetValueOrDefault() || flag2.GetValueOrDefault())
			{
				if (energyNoEnough == null)
				{
					float attribute = this.SkillButtonData.GetAttribute();
					float maxAttribute = this.SkillButtonData.GetMaxAttribute();
					flag = new bool?(attribute < maxAttribute);
				}
				bool value = flag2.GetValueOrDefault();
				if (flag2 == null)
				{
					value = (this.SkillButtonData.GetSkillRemainingCoolDown() > 0f);
					flag2 = new bool?(value);
				}
			}
			bool flag3 = !flag.GetValueOrDefault() && !flag2.GetValueOrDefault();
			this.SetMaxEnergyEffectEnable(flag3);
			if (refreshMaxEffectTip)
			{
				this.SetMaxEnergyEffectBurst(flag3);
			}
		}

		// Token: 0x0603C391 RID: 246673 RVA: 0x00E6A824 File Offset: 0x00E68A24
		private bool IsSkillInItemUseBuffCd()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseBuffCd();
		}

		// Token: 0x0603C392 RID: 246674 RVA: 0x00E6A850 File Offset: 0x00E68A50
		private bool TryRefreshItemUseBuffCd()
		{
			ValueTuple<double, double> equippedItemUsingBuffCd = this.SkillButtonData.GetEquippedItemUsingBuffCd();
			double item = equippedItemUsingBuffCd.Item1;
			double item2 = equippedItemUsingBuffCd.Item2;
			if (item > 0.0)
			{
				this.PlayCommonCd(item, item2, delegate
				{
					EventSystem.Instance.Emit(EEventName.OnChangeSelectedExploreId);
					this.RefreshEnable(false);
				});
				return true;
			}
			return false;
		}

		// Token: 0x0603C393 RID: 246675 RVA: 0x00E6A898 File Offset: 0x00E68A98
		private bool IsSkillInItemUseSkillCd()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseSkillCd();
		}

		// Token: 0x0603C394 RID: 246676 RVA: 0x00E6A8C4 File Offset: 0x00E68AC4
		private bool TryRefreshItemUseSkillCd()
		{
			ValueTuple<double, double> equippedItemUsingSkillCd = this.SkillButtonData.GetEquippedItemUsingSkillCd();
			double item = equippedItemUsingSkillCd.Item1;
			double item2 = equippedItemUsingSkillCd.Item2;
			if (item > 0.0)
			{
				this.PlayCommonCd(item, item2, delegate
				{
					EventSystem.Instance.Emit(EEventName.OnChangeSelectedExploreId);
					this.RefreshEnable(false);
				});
				return true;
			}
			return false;
		}

		// Token: 0x0603C395 RID: 246677 RVA: 0x00E6A90C File Offset: 0x00E68B0C
		private bool IsVehicleSkillInCd()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.闪避 && this.SkillButtonData.IsVehicleSkillInCd();
		}

		// Token: 0x0603C396 RID: 246678 RVA: 0x00E6A938 File Offset: 0x00E68B38
		private bool TryRefreshVehicleSkillCd()
		{
			ValueTuple<double, double> vehicleSkillCd = this.SkillButtonData.GetVehicleSkillCd();
			double item = vehicleSkillCd.Item1;
			double item2 = vehicleSkillCd.Item2;
			if (item > 0.0)
			{
				this.PlayCommonCd(item, item2, delegate
				{
					this.RefreshEnable(false);
				});
				return true;
			}
			return false;
		}

		// Token: 0x0603C397 RID: 246679 RVA: 0x00E6A980 File Offset: 0x00E68B80
		public void RefreshEquipExplore()
		{
			UUIItem item = base.GetItem(9);
			if (item.IsUIActiveSelf())
			{
				item.SetUIActive(false);
			}
			if (this.SkillButtonData.GetExploreSkillChange())
			{
				item.SetUIActive(true);
				this.SkillButtonData.SetExploreSkillChange(false);
				this.RemoveEquipEffectTimer();
				this.EquipEffectTimerId = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.EquipEffectTimerId = null;
					item.SetUIActive(false);
				}, 500f, null, null, true, 1f);
			}
			this.GetSwitchComponent.RefreshSwitch();
			ISkillButtonData skillButtonData = this.SkillButtonData;
			if (skillButtonData == null || !skillButtonData.IsExploreAsFight)
			{
				ISkillButtonData skillButtonData2 = this.SkillButtonData;
				if (skillButtonData2 == null || !skillButtonData2.IsSkillIdChangeByTag())
				{
					bool flag = RouletteModel.Instance.IsExploreSkillHasNum();
					if (!flag)
					{
						this.GetSwitchComponent.UpdateNumPanel(flag, null);
					}
					else
					{
						int exploreSkillShowNum = RouletteModel.Instance.GetExploreSkillShowNum();
						this.GetSwitchComponent.UpdateNumPanel(flag, new int?(exploreSkillShowNum));
					}
					int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
					bool flag2 = RouletteModel.Instance.IsExploreSkillHasSetNum(currentExploreSkillId);
					if (!flag2)
					{
						this.GetSwitchComponent.UpdatePointPanel(flag2, null, null);
						return;
					}
					ValueTuple<int, int> exploreSkillShowSetNumById = RouletteModel.Instance.GetExploreSkillShowSetNumById((ERouletteExploreId)currentExploreSkillId);
					int item3 = exploreSkillShowSetNumById.Item1;
					int item2 = exploreSkillShowSetNumById.Item2;
					this.GetSwitchComponent.UpdatePointPanel(flag2, new int?(item2), new int?(item3));
					return;
				}
			}
			this.GetSwitchComponent.UpdateNumPanel(false, null);
			this.GetSwitchComponent.UpdatePointPanel(false, null, null);
		}

		// Token: 0x0603C398 RID: 246680 RVA: 0x00E6AB33 File Offset: 0x00E68D33
		private void RemoveEquipEffectTimer()
		{
			if (this.EquipEffectTimerId != null)
			{
				TimerSystem.Instance.Remove(this.EquipEffectTimerId);
				this.EquipEffectTimerId = null;
			}
		}

		// Token: 0x0603C399 RID: 246681 RVA: 0x00E6AB55 File Offset: 0x00E68D55
		public void SetMaxEnergyEffectEnable(bool bEnable)
		{
			this.GetUltraComponent.SetUltraEffectEnable(bEnable);
		}

		// Token: 0x0603C39A RID: 246682 RVA: 0x00E6AB63 File Offset: 0x00E68D63
		private void SetMaxEnergyTipEffectEnable(bool bEnable)
		{
		}

		// Token: 0x0603C39B RID: 246683 RVA: 0x00E6AB65 File Offset: 0x00E68D65
		private void SetEnergyUpEffectEnable(bool bEnable)
		{
			this.GetUltraComponent.SetUltraUpEffectEnable(bEnable);
		}

		// Token: 0x0603C39C RID: 246684 RVA: 0x00E6AB73 File Offset: 0x00E68D73
		public void SetEnergyPercent(float energyPercent, bool bPlayUpEffect)
		{
			this.GetUltraComponent.SetBarPercent(energyPercent, bPlayUpEffect);
		}

		// Token: 0x0603C39D RID: 246685 RVA: 0x00E6AB82 File Offset: 0x00E68D82
		private void SetMaxEnergyEffectBurst(bool bBurst)
		{
			if (this.HasEruptedMaxEffect == bBurst)
			{
				return;
			}
			this.HasEruptedMaxEffect = bBurst;
			if (bBurst)
			{
				this.ActivateBurstMaxEnergyEffect();
				return;
			}
			this.DeactivateMaxEnergyEffect();
		}

		// Token: 0x0603C39E RID: 246686 RVA: 0x00E6ABA5 File Offset: 0x00E68DA5
		private void ActivateBurstMaxEnergyEffect()
		{
			this.SetMaxEnergyTipEffectEnable(true);
		}

		// Token: 0x0603C39F RID: 246687 RVA: 0x00E6ABAE File Offset: 0x00E68DAE
		private void DeactivateMaxEnergyEffect()
		{
			if (this.UltraComponent != null)
			{
				this.SetMaxEnergyTipEffectEnable(false);
				this.SetMaxEnergyEffectEnable(false);
				this.SetEnergyUpEffectEnable(false);
			}
		}

		// Token: 0x0603C3A0 RID: 246688 RVA: 0x00E6ABD0 File Offset: 0x00E68DD0
		private void LoadMaxAttributeEffect()
		{
			if (!this.ShouldListenUltraAttribute())
			{
				return;
			}
			string maxAttributeEffectPath = this.SkillButtonData.GetMaxAttributeEffectPath();
			if (!string.IsNullOrEmpty(maxAttributeEffectPath))
			{
				this.GetUltraComponent.RefreshUltraEffect(maxAttributeEffectPath, this.SkillButtonData.GetMaxAttributeColor().Value);
			}
			if (BattleLinkModel.Instance.CheckInDreamLink())
			{
				this.GetUltraComponent.RefreshUltraDynamicEffect("/Game/Aki/Effect/UI/Niagaras/Common/NS_Fx_LGUI_Fight_Link.NS_Fx_LGUI_Fight_Link", null);
				return;
			}
			this.GetUltraComponent.StopUltraDynamicEffect();
		}

		// Token: 0x0603C3A1 RID: 246689 RVA: 0x00E6AC4C File Offset: 0x00E68E4C
		private void LoadMaxAttributeBurstEffect()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.GetMaxAttributeBurstEffectId() <= 0)
			{
				return;
			}
			SkillButtonEffect? maxAttributeBurstEffectConfig = this.SkillButtonData.GetMaxAttributeBurstEffectConfig();
			if (maxAttributeBurstEffectConfig == null)
			{
				return;
			}
			string niagaraPath = maxAttributeBurstEffectConfig.Value.NiagaraPath;
			if (string.IsNullOrEmpty(niagaraPath))
			{
				return;
			}
			this.GetUltraComponent.RefreshUltraTipsEffect(niagaraPath);
		}

		// Token: 0x0603C3A2 RID: 246690 RVA: 0x00E6ACAC File Offset: 0x00E68EAC
		public void SetLimitUseSkillCount(int remainingUseCount)
		{
			BattleSkillNumItem getNumComponent = this.GetNumComponent;
			if (getNumComponent == null)
			{
				return;
			}
			getNumComponent.SetRemainingCount(remainingUseCount);
		}

		// Token: 0x0603C3A3 RID: 246691 RVA: 0x00E6ACC0 File Offset: 0x00E68EC0
		public void RefreshLimitCount(bool refreshVisible = false)
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			int limitUseSkillCount = 0;
			bool flag;
			if (this.SkillButtonData.IsLimitCountCustom)
			{
				flag = true;
				limitUseSkillCount = this.SkillButtonData.RemainingCountCustom;
			}
			else if (this.SkillButtonData.IsLimitCountVehicleSkill)
			{
				flag = true;
				limitUseSkillCount = this.SkillButtonData.RemainingCountVehicleSkill;
			}
			else
			{
				GroupSkillCdInfo groupSkillCdInfo = this.SkillButtonData.GetGroupSkillCdInfo();
				flag = (groupSkillCdInfo != null && groupSkillCdInfo.LimitCount > 1);
				if (flag)
				{
					limitUseSkillCount = groupSkillCdInfo.RemainingCount;
				}
			}
			BattleSkillNumItem numComponent = this.NumComponent;
			if ((numComponent != null && numComponent.TargetActive) != flag || refreshVisible)
			{
				if (this.NumComponent != null)
				{
					BattleSkillNumItem getNumComponent = this.GetNumComponent;
					if (getNumComponent != null)
					{
						getNumComponent.SetComponentActive(flag);
					}
				}
				else if (flag)
				{
					BattleSkillNumItem getNumComponent2 = this.GetNumComponent;
					if (getNumComponent2 != null)
					{
						getNumComponent2.SetComponentActive(flag);
					}
				}
			}
			if (flag)
			{
				this.SetLimitUseSkillCount(limitUseSkillCount);
			}
		}

		// Token: 0x0603C3A4 RID: 246692 RVA: 0x00E6AD90 File Offset: 0x00E68F90
		public void RefreshSkillButtonLongPress()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			bool flag = this.SkillButtonData.IsShowLongPress();
			if (flag)
			{
				BattleSkillLongPressItem getLongPressComponent = this.GetLongPressComponent;
				getLongPressComponent.SetComponentActive(flag);
				BattleSkillLongPressItem battleSkillLongPressItem = getLongPressComponent;
				CSharpScript.Game.Input.EInputAction actionType = this.SkillButtonData.GetActionType();
				battleSkillLongPressItem.SetAction(actionType);
				this.SkillButtonData.RefreshLongPressDuration();
				getLongPressComponent.SetDuration((float)this.SkillButtonData.GetLongPressDuration());
				if (this.SkillButtonData.GetIsLongPressing())
				{
					getLongPressComponent.StartProgress();
					return;
				}
			}
			else
			{
				BattleSkillLongPressItem longPressComponent = this.LongPressComponent;
				if (longPressComponent == null)
				{
					return;
				}
				longPressComponent.SetComponentActive(false);
			}
		}

		// Token: 0x0603C3A5 RID: 246693 RVA: 0x00E6AE1C File Offset: 0x00E6901C
		private void RefreshDotIndicator(bool show = true)
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			bool flag = this.SkillButtonData.IsEnableDotIndicator && show;
			BattleSkillDotIndicatorItem dotIndicatorComponent = this.DotIndicatorComponent;
			bool flag2 = dotIndicatorComponent != null && dotIndicatorComponent.IsComponentActive;
			if (flag != flag2)
			{
				if (this.DotIndicatorComponent != null)
				{
					this.DotIndicatorComponent.SetComponentActive(flag);
				}
				else
				{
					BattleSkillDotIndicatorItem getDotIndicatorComponent = this.GetDotIndicatorComponent;
					if (getDotIndicatorComponent != null)
					{
						getDotIndicatorComponent.SetComponentActive(flag);
					}
				}
			}
			if (flag && this.DotIndicatorComponent != null)
			{
				this.DotIndicatorComponent.SetCount(this.SkillButtonData.DotIndicatorCount, false);
				SkillButtonData skillButtonData = this.SkillButtonData as SkillButtonData;
				string iconPath = ((skillButtonData != null) ? skillButtonData.DotIndicatorIconPath : null) ?? "";
				this.DotIndicatorComponent.SetIconPath(iconPath, false);
			}
		}

		// Token: 0x0603C3A6 RID: 246694 RVA: 0x00E6AED0 File Offset: 0x00E690D0
		public void RefreshCustomHdData(int from = -1, int param = 0)
		{
			if (from > 100)
			{
				if (from == 101)
				{
					this.RefreshConfigLongPress(from, param);
					return;
				}
			}
			else
			{
				switch (from)
				{
				case 5:
					this.RefreshDotIndicator(true);
					return;
				case 6:
				case 7:
					this.RefreshConfigLongPress(from, param);
					return;
				case 8:
					this.RefreshFrameSprite();
					this.LoadMaxAttributeEffect();
					return;
				case 9:
					break;
				case 10:
					this.RefreshButtonDisappear();
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0603C3A7 RID: 246695 RVA: 0x00E6AF37 File Offset: 0x00E69137
		public void InitVehicleHandle()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			if (skillButtonData == null)
			{
				return;
			}
			skillButtonData.InitVehicleHandle();
		}

		// Token: 0x0603C3A8 RID: 246696 RVA: 0x00E6AF4C File Offset: 0x00E6914C
		public void RefreshConfigLongPress(int from = -1, int param = 0)
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.GetIsConfigShowLongPress())
			{
				BattleSkillConfigLongPressItem getConfigLongPressComponent = this.GetConfigLongPressComponent;
				getConfigLongPressComponent.SetComponentActive(true);
				CSharpScript.Game.Input.EInputAction actionType = this.SkillButtonData.GetActionType();
				getConfigLongPressComponent.SetAction(actionType);
				getConfigLongPressComponent.SetDuration((float)this.SkillButtonData.GetLongPressTime());
				getConfigLongPressComponent.SetSharedFxActions(this.SkillButtonData.GetValidSharedHoldRingFxActions());
				getConfigLongPressComponent.SetCustomLogicParam(this.SkillButtonData as SkillButtonData, from, param);
				return;
			}
			BattleSkillConfigLongPressItem configLongPressComponent = this.ConfigLongPressComponent;
			if (configLongPressComponent == null)
			{
				return;
			}
			configLongPressComponent.SetComponentActive(false);
		}

		// Token: 0x17008E16 RID: 36374
		// (get) Token: 0x0603C3A9 RID: 246697 RVA: 0x00E6AFD7 File Offset: 0x00E691D7
		protected bool IsHiddenByButtonDisappear
		{
			get
			{
				return this.IsDisappearAnimFinished;
			}
		}

		// Token: 0x0603C3AA RID: 246698 RVA: 0x00E6AFE0 File Offset: 0x00E691E0
		protected void ResetButtonDisappearStateForReuse()
		{
			if (this.ButtonDisappearComponent == null && !this.IsDisappearAnimFinished)
			{
				return;
			}
			SkillItemDisappear buttonDisappearComponent = this.ButtonDisappearComponent;
			if (buttonDisappearComponent != null)
			{
				buttonDisappearComponent.Destroy(null);
			}
			this.ButtonDisappearComponent = null;
			this.IsDisappearAnimFinished = false;
			foreach (BattleSkillItem.EBattleSkillItem name in BattleSkillItem.DISAPPEAR_HIDE_ITEMS)
			{
				UUISprite sprite = base.GetSprite((int)name);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
			}
			if (this.UltraComponent != null)
			{
				this.UltraComponent.SetComponentActive(VisibleStateUtil.GetVisible(this.UltraComponentVisibleState));
			}
		}

		// Token: 0x0603C3AB RID: 246699 RVA: 0x00E6B068 File Offset: 0x00E69268
		private void RefreshButtonDisappear()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			SkillButtonData skillButtonData = this.SkillButtonData as SkillButtonData;
			bool flag = skillButtonData != null && skillButtonData.IsButtonDisappear;
			SkillItemDisappear getButtonDisappearComponent = this.GetButtonDisappearComponent;
			if (getButtonDisappearComponent != null)
			{
				getButtonDisappearComponent.SetDisappear(flag);
			}
			if (!flag)
			{
				foreach (BattleSkillItem.EBattleSkillItem name in BattleSkillItem.DISAPPEAR_HIDE_ITEMS)
				{
					UUISprite sprite = base.GetSprite((int)name);
					if (sprite != null)
					{
						sprite.SetUIActive(true);
					}
				}
				if (this.UltraComponent != null)
				{
					this.UltraComponent.SetComponentActive(VisibleStateUtil.GetVisible(this.UltraComponentVisibleState));
				}
				if (this.IsDisappearAnimFinished)
				{
					this.IsDisappearAnimFinished = false;
					this.RefreshVisible();
				}
			}
		}

		// Token: 0x0603C3AC RID: 246700 RVA: 0x00E6B10C File Offset: 0x00E6930C
		private void OnButtonDisappearAnimStart()
		{
			SkillButtonData skillButtonData = this.SkillButtonData as SkillButtonData;
			if (skillButtonData == null || !skillButtonData.IsButtonDisappear)
			{
				return;
			}
			foreach (BattleSkillItem.EBattleSkillItem name in BattleSkillItem.DISAPPEAR_HIDE_ITEMS)
			{
				UUISprite sprite = base.GetSprite((int)name);
				if (sprite != null)
				{
					sprite.SetUIActive(false);
				}
			}
			if (this.UltraComponent != null)
			{
				this.UltraComponent.SetComponentActive(false);
			}
		}

		// Token: 0x0603C3AD RID: 246701 RVA: 0x00E6B175 File Offset: 0x00E69375
		private void OnButtonDisappearAnimFinished()
		{
			SkillButtonData skillButtonData = this.SkillButtonData as SkillButtonData;
			if (skillButtonData == null || !skillButtonData.IsButtonDisappear)
			{
				return;
			}
			this.IsDisappearAnimFinished = true;
			this.RefreshVisible();
		}

		// Token: 0x17008E17 RID: 36375
		// (get) Token: 0x0603C3AE RID: 246702 RVA: 0x00E6B1A4 File Offset: 0x00E693A4
		protected SkillItemDisappear GetButtonDisappearComponent
		{
			get
			{
				if (this.ButtonDisappearComponent != null)
				{
					return this.ButtonDisappearComponent;
				}
				SkillButtonData skillButtonData = this.SkillButtonData as SkillButtonData;
				if (skillButtonData == null || !skillButtonData.IsButtonDisappear)
				{
					return null;
				}
				UUIItem item = base.GetItem(8);
				SkillButtonData skillButtonData2 = this.SkillButtonData as SkillButtonData;
				string iconPath = (skillButtonData2 != null) ? skillButtonData2.ButtonDisappearIconPath : null;
				this.ButtonDisappearComponent = new SkillItemDisappear(item, iconPath);
				this.ButtonDisappearComponent.SetOnDisappearFinishedCallback(new Action(this.OnButtonDisappearAnimFinished));
				this.ButtonDisappearComponent.SetOnDisappearStartCallback(new Action(this.OnButtonDisappearAnimStart));
				return this.ButtonDisappearComponent;
			}
		}

		// Token: 0x0603C3AF RID: 246703 RVA: 0x00E6B240 File Offset: 0x00E69440
		public void RefreshExtraEffect()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			SkillButtonTypeFormationData formationData = this.SkillButtonData.GetFormationData();
			if (formationData == null || formationData.ExtraEffect == ESkillButtonExtraEffect.None)
			{
				if (this.ExtraEffectComponent != null)
				{
					this.ExtraEffectComponent.SetComponentActive(false);
				}
				return;
			}
			if (this.ExtraEffectComponent != null)
			{
				if (this.ExtraEffectComponent.GetEffectType() == formationData.ExtraEffect)
				{
					this.ExtraEffectComponent.SetComponentActive(true);
					this.ExtraEffectComponent.Refresh(formationData.ExtraEffectDuration);
					return;
				}
				this.ExtraEffectComponent.Destroy(null);
				this.ExtraEffectComponent = null;
			}
			if (formationData.ExtraEffect == ESkillButtonExtraEffect.Rhythm)
			{
				this.ExtraEffectComponent = new BattleSkillExtraEffectRhythmItem();
				this.ExtraEffectComponent.Init(this.GetExtraContainer());
				this.ExtraEffectComponent.SetComponentActive(true);
				this.ExtraEffectComponent.Refresh(formationData.ExtraEffectDuration);
			}
			BattleSkillExtraEffectItem extraEffectComponent = this.ExtraEffectComponent;
			if (extraEffectComponent == null)
			{
				return;
			}
			extraEffectComponent.SetEffectType(formationData.ExtraEffect);
		}

		// Token: 0x0603C3B0 RID: 246704 RVA: 0x00E6B326 File Offset: 0x00E69526
		public void RefreshSlideControl()
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			if (this.SkillButtonData.IsEnableSlideControl)
			{
				BattleUiModel.Instance.SlideControlData.Preload();
			}
		}

		// Token: 0x0603C3B1 RID: 246705 RVA: 0x00E6B34D File Offset: 0x00E6954D
		private bool IsInputEnable()
		{
			return this.SkillButtonData != null && this.SkillButtonData.IsEnable();
		}

		// Token: 0x0603C3B2 RID: 246706 RVA: 0x00E6B364 File Offset: 0x00E69564
		public virtual bool IsVisible()
		{
			return this.SkillButtonData != null && !this.IsDisappearAnimFinished && this.SkillButtonData.IsVisible();
		}

		// Token: 0x0603C3B3 RID: 246707 RVA: 0x00E6B385 File Offset: 0x00E69585
		public EAttributeType GetAttributeId()
		{
			return this.SkillButtonData.AttributeId;
		}

		// Token: 0x0603C3B4 RID: 246708 RVA: 0x00E6B392 File Offset: 0x00E69592
		public bool HasListenAttribute()
		{
			return this.SkillButtonData != null && this.SkillButtonData.HasAttribute();
		}

		// Token: 0x0603C3B5 RID: 246709 RVA: 0x00E6B3A9 File Offset: 0x00E695A9
		public bool ShouldListenUltraAttribute()
		{
			return this.SkillButtonData != null && this.SkillButtonData.HasAttribute() && this.SkillButtonData.AttributeUsageMode == ESkillButtonAttributeUsageMode.Ultra;
		}

		// Token: 0x0603C3B6 RID: 246710 RVA: 0x00E6B3D2 File Offset: 0x00E695D2
		public SkillButtonData GetSkillButtonData()
		{
			return this.SkillButtonData as SkillButtonData;
		}

		// Token: 0x0603C3B7 RID: 246711 RVA: 0x00E6B3DF File Offset: 0x00E695DF
		public int GetInputIndex()
		{
			return this.InputIndex;
		}

		// Token: 0x0603C3B8 RID: 246712 RVA: 0x00E6B3E7 File Offset: 0x00E695E7
		public virtual void OnInputAction(bool bForcePlayClickEffect = false)
		{
			if (!bForcePlayClickEffect && (this.SkillButtonData == null || !this.SkillButtonData.IsEnable() || !this.SkillButtonData.IsVisible()))
			{
				return;
			}
			BattleUiNiagaraItem clickEffect = this.ClickEffect;
			if (clickEffect == null)
			{
				return;
			}
			clickEffect.Play();
		}

		// Token: 0x0603C3B9 RID: 246713 RVA: 0x00E6B420 File Offset: 0x00E69620
		public void SetVisibleByExploreMode(bool visible, bool anim = false)
		{
			bool raycastTarget = false;
			if (visible)
			{
				this.TargetAlpha = this.BaseAlpha;
				raycastTarget = true;
			}
			else
			{
				this.TargetAlpha = 0f;
			}
			if (this.RootItem == null)
			{
				return;
			}
			this.RootItem.SetRaycastTarget(raycastTarget);
			base.GetItem(8).SetUIActive(visible);
			if (!anim)
			{
				if (this.AlphaTweenComp != null)
				{
					this.AlphaTweenComp.Stop();
				}
				this.RootItem.SetAlpha(this.TargetAlpha);
				return;
			}
			if (this.AlphaTweenComp == null)
			{
				this.AlphaTweenComp = (this.RootActor.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			}
			else
			{
				this.AlphaTweenComp.Stop();
			}
			ULGUIPlayTween_Float ulguiplayTween_Float = this.AlphaTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
			ulguiplayTween_Float.from = this.RootItem.GetAlpha();
			ulguiplayTween_Float.to = this.TargetAlpha;
			this.AlphaTweenComp.Play();
		}

		// Token: 0x0603C3BA RID: 246714 RVA: 0x00E6B503 File Offset: 0x00E69703
		protected void OnDeactivate()
		{
		}

		// Token: 0x0603C3BB RID: 246715 RVA: 0x00E6B505 File Offset: 0x00E69705
		[NullableContext(1)]
		public void SetOnVisibleChangedCallback(Action callback)
		{
			this.OnVisibleChangedCallback = callback;
		}

		// Token: 0x0603C3BC RID: 246716 RVA: 0x00E6B510 File Offset: 0x00E69710
		[NullableContext(1)]
		public void SetSkillItemLayout(SkillItemLayout layout)
		{
			if (this.LayoutIndex == layout.Index)
			{
				return;
			}
			this.LayoutIndex = layout.Index;
			UUIItem rootItem = this.RootItem;
			UUIItem uuiitem = (rootItem != null) ? rootItem.GetParentAsUIItem() : null;
			if (uuiitem != null)
			{
				uuiitem.SetUIParent(layout.Item, false);
			}
			if (layout.Index == 0 && uuiitem != null)
			{
				uuiitem.SetHierarchyIndex(1);
			}
		}

		// Token: 0x0603C3BD RID: 246717 RVA: 0x00E6B56D File Offset: 0x00E6976D
		public InputMultiKeyItem GetKeyItem()
		{
			return this.KeyItem;
		}

		// Token: 0x0603C3BE RID: 246718 RVA: 0x00E6B575 File Offset: 0x00E69775
		public bool GetSkillButtonInteractive()
		{
			UUIButtonComponent skillButton = this.SkillButton;
			return skillButton != null && skillButton.IsSelfInteractive;
		}

		// Token: 0x0603C3C1 RID: 246721 RVA: 0x00E6B609 File Offset: 0x00E69809
		[CompilerGenerated]
		private void <PlayHideCd>g__OnHideCdFinish|124_0(float _)
		{
			this.SkillButtonData.RefreshIsEnable();
			this.FinishSkillCoolDown();
		}

		// Token: 0x0401F5FD RID: 128509
		private const int SKILL_COOLDOWN_INTERVAL = 100;

		// Token: 0x0401F5FE RID: 128510
		private const double SKILL_COOLDOWN_LOOP_INTERVAL = 0.1;

		// Token: 0x0401F5FF RID: 128511
		private const int EQUIP_EFFECT_TIME = 500;

		// Token: 0x0401F600 RID: 128512
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly BattleSkillItem.EBattleSkillItem[] DISAPPEAR_HIDE_ITEMS = new BattleSkillItem.EBattleSkillItem[]
		{
			BattleSkillItem.EBattleSkillItem.SkillSprite,
			BattleSkillItem.EBattleSkillItem.SkillSpriteBg
		};

		// Token: 0x0401F601 RID: 128513
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat PlaySkillCdStat = Stat.Create("[SkillButton]PlaySkillCd", "", "");

		// Token: 0x0401F602 RID: 128514
		private UUIItem ParentItem;

		// Token: 0x0401F603 RID: 128515
		protected UUIDraggableComponent DraggableComponent;

		// Token: 0x0401F604 RID: 128516
		protected ISkillButtonData SkillButtonData;

		// Token: 0x0401F605 RID: 128517
		private UUIButtonComponent SkillButton;

		// Token: 0x0401F606 RID: 128518
		private TimerHandle ChangeCoolDownRefreshTimerId;

		// Token: 0x0401F607 RID: 128519
		private UUIItem CoolDownUiItem;

		// Token: 0x0401F608 RID: 128520
		protected UUIText CoolDownUiText;

		// Token: 0x0401F609 RID: 128521
		private UUISprite CoolDownBarUiSprite;

		// Token: 0x0401F60A RID: 128522
		private double CurrentCoolDownTime;

		// Token: 0x0401F60B RID: 128523
		private double TotalCoolDownTime;

		// Token: 0x0401F60C RID: 128524
		private double CoolDownStartTime;

		// Token: 0x0401F60D RID: 128525
		protected Action OnCoolDownFinishedCallback;

		// Token: 0x0401F60E RID: 128526
		private bool HasEruptedMaxEffect;

		// Token: 0x0401F60F RID: 128527
		private TimerHandle LongPressTimerId;

		// Token: 0x0401F610 RID: 128528
		protected bool IsLongPress;

		// Token: 0x0401F611 RID: 128529
		private bool IsAddedEvents;

		// Token: 0x0401F612 RID: 128530
		[Nullable(1)]
		private string CdCompletedEffectPath = string.Empty;

		// Token: 0x0401F613 RID: 128531
		private BattleSkillItemDynamicEffect DynamicEffect;

		// Token: 0x0401F614 RID: 128532
		private string SkillIconPath;

		// Token: 0x0401F615 RID: 128533
		private int InputIndex;

		// Token: 0x0401F616 RID: 128534
		private TimerHandle HideCdTimerId;

		// Token: 0x0401F617 RID: 128535
		private TimerHandle EquipEffectTimerId;

		// Token: 0x0401F618 RID: 128536
		protected InputMultiKeyItem KeyItem;

		// Token: 0x0401F619 RID: 128537
		protected int SetTextureHandleId;

		// Token: 0x0401F61A RID: 128538
		private int? LoadCdCompletedNiagaraHandleId = new int?(0);

		// Token: 0x0401F61B RID: 128539
		protected string KeyActionName;

		// Token: 0x0401F61C RID: 128540
		protected EOperationType? KeyOperationType;

		// Token: 0x0401F61D RID: 128541
		protected BattleUiNiagaraItem ClickEffect;

		// Token: 0x0401F61E RID: 128542
		protected UUISprite CombinePressTipSprite;

		// Token: 0x0401F61F RID: 128543
		protected CSharpScript.Game.Input.EInputAction PressActionType = CSharpScript.Game.Input.EInputAction.None;

		// Token: 0x0401F620 RID: 128544
		private int LinkStatus;

		// Token: 0x0401F621 RID: 128545
		private bool HasBattleLinkEvent;

		// Token: 0x0401F622 RID: 128546
		private bool IsPlayingLinkEffect;

		// Token: 0x0401F623 RID: 128547
		private UUITexture SkillTexture;

		// Token: 0x0401F624 RID: 128548
		private UUISprite SkillSprite;

		// Token: 0x0401F625 RID: 128549
		private UUITextureTransitionComponent SkillTextureTransitionComp;

		// Token: 0x0401F626 RID: 128550
		private UUISpriteTransition SkillSpriteTransitionComp;

		// Token: 0x0401F627 RID: 128551
		private UTexture DefaultSkillTextureData;

		// Token: 0x0401F628 RID: 128552
		private ULGUISpriteData_BaseObject DefaultSkillSpriteData;

		// Token: 0x0401F629 RID: 128553
		private bool IsDefaultSkillTexture;

		// Token: 0x0401F62A RID: 128554
		private bool IsDefaultSkillSprite;

		// Token: 0x0401F62B RID: 128555
		private bool IsLoadingSkillIcon;

		// Token: 0x0401F62C RID: 128556
		protected bool HideCdText;

		// Token: 0x0401F62D RID: 128557
		protected int CdFixedPoint = 1;

		// Token: 0x0401F62E RID: 128558
		protected bool IsHideNumComp;

		// Token: 0x0401F62F RID: 128559
		private float TargetAlpha = 1f;

		// Token: 0x0401F630 RID: 128560
		private float BaseAlpha = 1f;

		// Token: 0x0401F631 RID: 128561
		protected UUIText SkillNameText;

		// Token: 0x0401F632 RID: 128562
		protected int UltraComponentVisibleState;

		// Token: 0x0401F633 RID: 128563
		private int LayoutIndex;

		// Token: 0x0401F634 RID: 128564
		private Action OnVisibleChangedCallback;

		// Token: 0x0401F635 RID: 128565
		private bool EnableSlideControl;

		// Token: 0x0401F636 RID: 128566
		private bool IsDisappearAnimFinished;

		// Token: 0x0401F637 RID: 128567
		protected BattleSkillUltraItem UltraComponent;

		// Token: 0x0401F638 RID: 128568
		protected BattleSkillNumItem NumComponent;

		// Token: 0x0401F639 RID: 128569
		protected BattleSkillDotIndicatorItem DotIndicatorComponent;

		// Token: 0x0401F63A RID: 128570
		protected SkillItemDisappear ButtonDisappearComponent;

		// Token: 0x0401F63B RID: 128571
		protected BattleSkillSwitchComponent SwitchComponent;

		// Token: 0x0401F63C RID: 128572
		protected BattleSkillLongPressItem LongPressComponent;

		// Token: 0x0401F63D RID: 128573
		protected BattleSkillConfigLongPressItem ConfigLongPressComponent;

		// Token: 0x0401F63E RID: 128574
		protected BattleSkillExtraEffectItem ExtraEffectComponent;

		// Token: 0x0401F63F RID: 128575
		protected ULGUIPlayTweenComponent AlphaTweenComp;

		// Token: 0x0200BF41 RID: 48961
		[NullableContext(0)]
		private enum EBattleSkillItem
		{
			// Token: 0x04039AFC RID: 236284
			CoolDownItem,
			// Token: 0x04039AFD RID: 236285
			CoolDownBarSprite,
			// Token: 0x04039AFE RID: 236286
			CoolDownText,
			// Token: 0x04039AFF RID: 236287
			SkillSprite,
			// Token: 0x04039B00 RID: 236288
			SkillTexture,
			// Token: 0x04039B01 RID: 236289
			SkillButton,
			// Token: 0x04039B02 RID: 236290
			CdCompletedNiagara,
			// Token: 0x04039B03 RID: 236291
			DynamicEffectNiagara,
			// Token: 0x04039B04 RID: 236292
			ExtraContainer,
			// Token: 0x04039B05 RID: 236293
			ExploreSkillEquip,
			// Token: 0x04039B06 RID: 236294
			ClickEffectNiagara,
			// Token: 0x04039B07 RID: 236295
			SkillNameText,
			// Token: 0x04039B08 RID: 236296
			LinkExplosionNiagara,
			// Token: 0x04039B09 RID: 236297
			SkillSpriteBg,
			// Token: 0x04039B0A RID: 236298
			CombinePressTipSprite,
			// Token: 0x04039B0B RID: 236299
			KeyItem
		}

		// Token: 0x0200BF42 RID: 48962
		[NullableContext(0)]
		private enum EUltraComponentVisibleReason
		{
			// Token: 0x04039B0D RID: 236301
			Attribute,
			// Token: 0x04039B0E RID: 236302
			Link
		}
	}
}
