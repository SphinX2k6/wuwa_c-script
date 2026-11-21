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
	// Token: 0x02004CCC RID: 19660
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillItem : BattleChildView
	{
		// Token: 0x170061E2 RID: 25058
		// (get) Token: 0x06031296 RID: 201366 RVA: 0x00DB8BB8 File Offset: 0x00DB6DB8
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

		// Token: 0x170061E3 RID: 25059
		// (get) Token: 0x06031297 RID: 201367 RVA: 0x00DB8BE8 File Offset: 0x00DB6DE8
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

		// Token: 0x170061E4 RID: 25060
		// (get) Token: 0x06031298 RID: 201368 RVA: 0x00DB8C24 File Offset: 0x00DB6E24
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

		// Token: 0x170061E5 RID: 25061
		// (get) Token: 0x06031299 RID: 201369 RVA: 0x00DB8C6C File Offset: 0x00DB6E6C
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

		// Token: 0x170061E6 RID: 25062
		// (get) Token: 0x0603129A RID: 201370 RVA: 0x00DB8CB4 File Offset: 0x00DB6EB4
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

		// Token: 0x170061E7 RID: 25063
		// (get) Token: 0x0603129B RID: 201371 RVA: 0x00DB8CFC File Offset: 0x00DB6EFC
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

		// Token: 0x0603129C RID: 201372 RVA: 0x00DB8D41 File Offset: 0x00DB6F41
		protected UUIItem GetExtraContainer()
		{
			return base.GetItem(8);
		}

		// Token: 0x0603129D RID: 201373 RVA: 0x00DB8D4A File Offset: 0x00DB6F4A
		protected virtual UUIButtonComponent GetPointEventButton()
		{
			return this.SkillButton;
		}

		// Token: 0x0603129E RID: 201374 RVA: 0x00DB8D54 File Offset: 0x00DB6F54
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

		// Token: 0x0603129F RID: 201375 RVA: 0x00DB8F94 File Offset: 0x00DB7194
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

		// Token: 0x060312A0 RID: 201376 RVA: 0x00DB90DC File Offset: 0x00DB72DC
		protected override UniTask InitializeAsync(object param = null)
		{
			BattleSkillItem.<InitializeAsync>d__85 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<BattleSkillItem.<InitializeAsync>d__85>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060312A1 RID: 201377 RVA: 0x00DB9120 File Offset: 0x00DB7320
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

		// Token: 0x060312A2 RID: 201378 RVA: 0x00DB920C File Offset: 0x00DB740C
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

		// Token: 0x060312A3 RID: 201379 RVA: 0x00DB93A3 File Offset: 0x00DB75A3
		protected override void OnShowBattleChildView()
		{
			UUIItem parentItem = this.ParentItem;
			if (parentItem == null)
			{
				return;
			}
			parentItem.SetUIActive(true);
		}

		// Token: 0x060312A4 RID: 201380 RVA: 0x00DB93B6 File Offset: 0x00DB75B6
		protected override void OnHideBattleChildView()
		{
			UUIItem parentItem = this.ParentItem;
			if (parentItem == null)
			{
				return;
			}
			parentItem.SetUIActive(false);
		}

		// Token: 0x060312A5 RID: 201381 RVA: 0x00DB93C9 File Offset: 0x00DB75C9
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

		// Token: 0x060312A6 RID: 201382 RVA: 0x00DB9408 File Offset: 0x00DB7608
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

		// Token: 0x060312A7 RID: 201383 RVA: 0x00DB947B File Offset: 0x00DB767B
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

		// Token: 0x060312A8 RID: 201384 RVA: 0x00DB9498 File Offset: 0x00DB7698
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

		// Token: 0x060312A9 RID: 201385 RVA: 0x00DB95A8 File Offset: 0x00DB77A8
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

		// Token: 0x060312AA RID: 201386 RVA: 0x00DB966F File Offset: 0x00DB786F
		protected void OnSelfCenteredMode(ESelfCenteredMode selfCenteredMode, float dilation)
		{
			if (TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId))
			{
				TimerSystem.Instance.ChangeDilation(this.ChangeCoolDownRefreshTimerId, 1f / dilation, null);
			}
		}

		// Token: 0x060312AB RID: 201387 RVA: 0x00DB969C File Offset: 0x00DB789C
		protected void OnBattleLinkStatusChanged(ELinkStatus status)
		{
			this.RefreshLinkStatus(new int?((int)status));
		}

		// Token: 0x060312AC RID: 201388 RVA: 0x00DB96AC File Offset: 0x00DB78AC
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

		// Token: 0x060312AD RID: 201389 RVA: 0x00DB9790 File Offset: 0x00DB7990
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

		// Token: 0x060312AE RID: 201390 RVA: 0x00DB9824 File Offset: 0x00DB7A24
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

		// Token: 0x060312AF RID: 201391 RVA: 0x00DB998C File Offset: 0x00DB7B8C
		protected virtual bool IsNeedLongPress()
		{
			return this.SkillButtonData.GetIsLongPressControlCamera().Value;
		}

		// Token: 0x060312B0 RID: 201392 RVA: 0x00DB99AC File Offset: 0x00DB7BAC
		protected void OnSkillButtonPointUp()
		{
			this.OnSkillButtonReleased();
		}

		// Token: 0x060312B1 RID: 201393 RVA: 0x00DB99B4 File Offset: 0x00DB7BB4
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

		// Token: 0x060312B2 RID: 201394 RVA: 0x00DB9AA2 File Offset: 0x00DB7CA2
		protected virtual void OnSkillButtonCancel()
		{
			this.OnSkillButtonReleased();
		}

		// Token: 0x060312B3 RID: 201395 RVA: 0x00DB9AAA File Offset: 0x00DB7CAA
		public void TryReleaseButton()
		{
			if (this.PressActionType != CSharpScript.Game.Input.EInputAction.None)
			{
				this.OnSkillButtonReleased();
			}
		}

		// Token: 0x060312B4 RID: 201396 RVA: 0x00DB9AC4 File Offset: 0x00DB7CC4
		protected virtual void OnLongPress(float _)
		{
			this.IsLongPress = true;
			this.OnLongPressButton();
		}

		// Token: 0x060312B5 RID: 201397 RVA: 0x00DB9AD3 File Offset: 0x00DB7CD3
		protected virtual void OnLongPressButton()
		{
		}

		// Token: 0x060312B6 RID: 201398 RVA: 0x00DB9AD8 File Offset: 0x00DB7CD8
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

		// Token: 0x060312B7 RID: 201399 RVA: 0x00DB9C0C File Offset: 0x00DB7E0C
		[NullableContext(1)]
		protected virtual bool CheckSkillIconIsTexture(string skillIconPath)
		{
			return skillIconPath.Contains("Image/");
		}

		// Token: 0x060312B8 RID: 201400 RVA: 0x00DB9C1C File Offset: 0x00DB7E1C
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

		// Token: 0x060312B9 RID: 201401 RVA: 0x00DB9C75 File Offset: 0x00DB7E75
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

		// Token: 0x060312BA RID: 201402 RVA: 0x00DB9CA8 File Offset: 0x00DB7EA8
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

		// Token: 0x060312BB RID: 201403 RVA: 0x00DB9D02 File Offset: 0x00DB7F02
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

		// Token: 0x060312BC RID: 201404 RVA: 0x00DB9D38 File Offset: 0x00DB7F38
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

		// Token: 0x060312BD RID: 201405 RVA: 0x00DB9D8C File Offset: 0x00DB7F8C
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

		// Token: 0x060312BE RID: 201406 RVA: 0x00DB9E4F File Offset: 0x00DB804F
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

		// Token: 0x060312BF RID: 201407 RVA: 0x00DB9E84 File Offset: 0x00DB8084
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

		// Token: 0x060312C0 RID: 201408 RVA: 0x00DB9F1C File Offset: 0x00DB811C
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

		// Token: 0x060312C1 RID: 201409 RVA: 0x00DBA00D File Offset: 0x00DB820D
		public void RefreshSkillCoolDownOnShow()
		{
			if (this.CurrentCoolDownTime <= 0.0 || this.TotalCoolDownTime <= 0.0 || this.CoolDownBarUiSprite == null)
			{
				return;
			}
			this.RefreshSkillCoolDown();
		}

		// Token: 0x060312C2 RID: 201410 RVA: 0x00DBA040 File Offset: 0x00DB8240
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

		// Token: 0x060312C3 RID: 201411 RVA: 0x00DBA124 File Offset: 0x00DB8324
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

		// Token: 0x060312C4 RID: 201412 RVA: 0x00DBA1A0 File Offset: 0x00DB83A0
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

		// Token: 0x060312C5 RID: 201413 RVA: 0x00DBA235 File Offset: 0x00DB8435
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

		// Token: 0x060312C6 RID: 201414 RVA: 0x00DBA278 File Offset: 0x00DB8478
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

		// Token: 0x060312C7 RID: 201415 RVA: 0x00DBA2F0 File Offset: 0x00DB84F0
		private void PlayHideCd(float remainingCoolDown)
		{
			this.ResetSkillCoolDown();
			this.HideCdTimerId = TimerSystem.Instance.Delay(new TTimerAction(this.<PlayHideCd>g__OnHideCdFinish|124_0), remainingCoolDown * (float)TimeUtil.Instance.InverseMillisecond, null, null, true, 1f);
			this.RefreshTimeDilationAtTimerCreate(this.HideCdTimerId);
		}

		// Token: 0x060312C8 RID: 201416 RVA: 0x00DBA340 File Offset: 0x00DB8540
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

		// Token: 0x060312C9 RID: 201417 RVA: 0x00DBA394 File Offset: 0x00DB8594
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

		// Token: 0x060312CA RID: 201418 RVA: 0x00DBA4B8 File Offset: 0x00DB86B8
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

		// Token: 0x060312CB RID: 201419 RVA: 0x00DBA55E File Offset: 0x00DB875E
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

		// Token: 0x060312CC RID: 201420 RVA: 0x00DBA580 File Offset: 0x00DB8780
		private void TickSkillCoolDown(float _)
		{
			if (this.CurrentCoolDownTime <= 0.0 || this.TotalCoolDownTime <= 0.0 || this.CoolDownBarUiSprite == null)
			{
				return;
			}
			double num = (Time.Instance.FlowTime * TimeUtil.Instance.Millisecond - this.CoolDownStartTime) / this.TotalCoolDownTime;
			this.CoolDownBarUiSprite.SetFillAmount((float)num);
		}

		// Token: 0x060312CD RID: 201421 RVA: 0x00DBA5E9 File Offset: 0x00DB87E9
		public void ResetSkillCoolDown()
		{
			this.CoolDownUiItem.SetUIActive(false);
			this.ResetCoolDownTimer();
			this.CurrentCoolDownTime = 0.0;
		}

		// Token: 0x060312CE RID: 201422 RVA: 0x00DBA60C File Offset: 0x00DB880C
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

		// Token: 0x060312CF RID: 201423 RVA: 0x00DBA660 File Offset: 0x00DB8860
		public virtual void RefreshEnable(bool bForce = false)
		{
			if (this.SkillButtonData == null)
			{
				return;
			}
			bool bVisible = this.IsInputEnable();
			this.SetSkillItemEnable(bVisible, bForce);
		}

		// Token: 0x060312D0 RID: 201424 RVA: 0x00DBA685 File Offset: 0x00DB8885
		public void DisableButton()
		{
			this.SetSkillItemEnable(false, true);
		}

		// Token: 0x060312D1 RID: 201425 RVA: 0x00DBA690 File Offset: 0x00DB8890
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

		// Token: 0x060312D2 RID: 201426 RVA: 0x00DBA6E8 File Offset: 0x00DB88E8
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

		// Token: 0x060312D3 RID: 201427 RVA: 0x00DBA744 File Offset: 0x00DB8944
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

		// Token: 0x060312D4 RID: 201428 RVA: 0x00DBA798 File Offset: 0x00DB8998
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

		// Token: 0x060312D5 RID: 201429 RVA: 0x00DBA7DC File Offset: 0x00DB89DC
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

		// Token: 0x060312D6 RID: 201430 RVA: 0x00DBA820 File Offset: 0x00DB8A20
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

		// Token: 0x060312D7 RID: 201431 RVA: 0x00DBA8D5 File Offset: 0x00DB8AD5
		protected void CancelLoadCdCompletedNiagara()
		{
			if (this.LoadCdCompletedNiagaraHandleId == null)
			{
				return;
			}
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadCdCompletedNiagaraHandleId.Value);
			this.LoadCdCompletedNiagaraHandleId = null;
		}

		// Token: 0x060312D8 RID: 201432 RVA: 0x00DBA908 File Offset: 0x00DB8B08
		protected virtual SkillButtonEffect? GetDynamicEffectConfig()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			if (skillButtonData == null)
			{
				return null;
			}
			return skillButtonData.GetDynamicEffectConfig();
		}

		// Token: 0x060312D9 RID: 201433 RVA: 0x00DBA92E File Offset: 0x00DB8B2E
		protected void CancelLoadDynamicEffectNiagara()
		{
			this.DynamicEffect.CancelLoadDynamicEffectNiagara();
		}

		// Token: 0x060312DA RID: 201434 RVA: 0x00DBA93C File Offset: 0x00DB8B3C
		public virtual void RefreshDynamicEffect()
		{
			SkillButtonEffect? dynamicEffectConfig = this.GetDynamicEffectConfig();
			this.DynamicEffect.RefreshDynamicEffect(dynamicEffectConfig);
		}

		// Token: 0x060312DB RID: 201435 RVA: 0x00DBA95C File Offset: 0x00DB8B5C
		protected void SetDynamicEffectVisible(bool visible)
		{
			this.DynamicEffect.SetDynamicEffectVisible(visible);
		}

		// Token: 0x060312DC RID: 201436 RVA: 0x00DBA96A File Offset: 0x00DB8B6A
		public void RefreshTimeDilation()
		{
			this.SetTimeDilation(this.GetTimeDilation());
		}

		// Token: 0x060312DD RID: 201437 RVA: 0x00DBA978 File Offset: 0x00DB8B78
		private float GetTimeDilation()
		{
			if (SkillCdController.Instance.IsPause())
			{
				return 0f;
			}
			return Time.Instance.TimeDilation;
		}

		// Token: 0x060312DE RID: 201438 RVA: 0x00DBA998 File Offset: 0x00DB8B98
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

		// Token: 0x060312DF RID: 201439 RVA: 0x00DBA9E4 File Offset: 0x00DB8BE4
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

		// Token: 0x060312E0 RID: 201440 RVA: 0x00DBAAE7 File Offset: 0x00DB8CE7
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

		// Token: 0x060312E1 RID: 201441 RVA: 0x00DBAB20 File Offset: 0x00DB8D20
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

		// Token: 0x060312E2 RID: 201442 RVA: 0x00DBAB7C File Offset: 0x00DB8D7C
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

		// Token: 0x060312E3 RID: 201443 RVA: 0x00DBAC38 File Offset: 0x00DB8E38
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

		// Token: 0x060312E4 RID: 201444 RVA: 0x00DBAC88 File Offset: 0x00DB8E88
		protected void RefreshFrameSprite()
		{
			if (this.ShouldListenUltraAttribute())
			{
				FColor? frameSpriteColor = this.SkillButtonData.GetFrameSpriteColor();
				this.GetUltraComponent.SetFrameSprite(frameSpriteColor.Value);
			}
		}

		// Token: 0x060312E5 RID: 201445 RVA: 0x00DBACBC File Offset: 0x00DB8EBC
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

		// Token: 0x060312E6 RID: 201446 RVA: 0x00DBAD30 File Offset: 0x00DB8F30
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

		// Token: 0x060312E7 RID: 201447 RVA: 0x00DBADD8 File Offset: 0x00DB8FD8
		private bool IsSkillInItemUseBuffCd()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseBuffCd();
		}

		// Token: 0x060312E8 RID: 201448 RVA: 0x00DBAE04 File Offset: 0x00DB9004
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

		// Token: 0x060312E9 RID: 201449 RVA: 0x00DBAE4C File Offset: 0x00DB904C
		private bool IsSkillInItemUseSkillCd()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.幻象1 && this.SkillButtonData.IsSkillInItemUseSkillCd();
		}

		// Token: 0x060312EA RID: 201450 RVA: 0x00DBAE78 File Offset: 0x00DB9078
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

		// Token: 0x060312EB RID: 201451 RVA: 0x00DBAEC0 File Offset: 0x00DB90C0
		private bool IsVehicleSkillInCd()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			return skillButtonData != null && skillButtonData.GetButtonType() == ESkillButtonType.闪避 && this.SkillButtonData.IsVehicleSkillInCd();
		}

		// Token: 0x060312EC RID: 201452 RVA: 0x00DBAEEC File Offset: 0x00DB90EC
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

		// Token: 0x060312ED RID: 201453 RVA: 0x00DBAF34 File Offset: 0x00DB9134
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

		// Token: 0x060312EE RID: 201454 RVA: 0x00DBB0E7 File Offset: 0x00DB92E7
		private void RemoveEquipEffectTimer()
		{
			if (this.EquipEffectTimerId != null)
			{
				TimerSystem.Instance.Remove(this.EquipEffectTimerId);
				this.EquipEffectTimerId = null;
			}
		}

		// Token: 0x060312EF RID: 201455 RVA: 0x00DBB109 File Offset: 0x00DB9309
		public void SetMaxEnergyEffectEnable(bool bEnable)
		{
			this.GetUltraComponent.SetUltraEffectEnable(bEnable);
		}

		// Token: 0x060312F0 RID: 201456 RVA: 0x00DBB117 File Offset: 0x00DB9317
		private void SetMaxEnergyTipEffectEnable(bool bEnable)
		{
		}

		// Token: 0x060312F1 RID: 201457 RVA: 0x00DBB119 File Offset: 0x00DB9319
		private void SetEnergyUpEffectEnable(bool bEnable)
		{
			this.GetUltraComponent.SetUltraUpEffectEnable(bEnable);
		}

		// Token: 0x060312F2 RID: 201458 RVA: 0x00DBB127 File Offset: 0x00DB9327
		public void SetEnergyPercent(float energyPercent, bool bPlayUpEffect)
		{
			this.GetUltraComponent.SetBarPercent(energyPercent, bPlayUpEffect);
		}

		// Token: 0x060312F3 RID: 201459 RVA: 0x00DBB136 File Offset: 0x00DB9336
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

		// Token: 0x060312F4 RID: 201460 RVA: 0x00DBB159 File Offset: 0x00DB9359
		private void ActivateBurstMaxEnergyEffect()
		{
			this.SetMaxEnergyTipEffectEnable(true);
		}

		// Token: 0x060312F5 RID: 201461 RVA: 0x00DBB162 File Offset: 0x00DB9362
		private void DeactivateMaxEnergyEffect()
		{
			if (this.UltraComponent != null)
			{
				this.SetMaxEnergyTipEffectEnable(false);
				this.SetMaxEnergyEffectEnable(false);
				this.SetEnergyUpEffectEnable(false);
			}
		}

		// Token: 0x060312F6 RID: 201462 RVA: 0x00DBB184 File Offset: 0x00DB9384
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

		// Token: 0x060312F7 RID: 201463 RVA: 0x00DBB200 File Offset: 0x00DB9400
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

		// Token: 0x060312F8 RID: 201464 RVA: 0x00DBB260 File Offset: 0x00DB9460
		public void SetLimitUseSkillCount(int remainingUseCount)
		{
			BattleSkillNumItem getNumComponent = this.GetNumComponent;
			if (getNumComponent == null)
			{
				return;
			}
			getNumComponent.SetRemainingCount(remainingUseCount);
		}

		// Token: 0x060312F9 RID: 201465 RVA: 0x00DBB274 File Offset: 0x00DB9474
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

		// Token: 0x060312FA RID: 201466 RVA: 0x00DBB344 File Offset: 0x00DB9544
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

		// Token: 0x060312FB RID: 201467 RVA: 0x00DBB3D0 File Offset: 0x00DB95D0
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

		// Token: 0x060312FC RID: 201468 RVA: 0x00DBB484 File Offset: 0x00DB9684
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

		// Token: 0x060312FD RID: 201469 RVA: 0x00DBB4EB File Offset: 0x00DB96EB
		public void InitVehicleHandle()
		{
			ISkillButtonData skillButtonData = this.SkillButtonData;
			if (skillButtonData == null)
			{
				return;
			}
			skillButtonData.InitVehicleHandle();
		}

		// Token: 0x060312FE RID: 201470 RVA: 0x00DBB500 File Offset: 0x00DB9700
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

		// Token: 0x170061E8 RID: 25064
		// (get) Token: 0x060312FF RID: 201471 RVA: 0x00DBB58B File Offset: 0x00DB978B
		protected bool IsHiddenByButtonDisappear
		{
			get
			{
				return this.IsDisappearAnimFinished;
			}
		}

		// Token: 0x06031300 RID: 201472 RVA: 0x00DBB594 File Offset: 0x00DB9794
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

		// Token: 0x06031301 RID: 201473 RVA: 0x00DBB61C File Offset: 0x00DB981C
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

		// Token: 0x06031302 RID: 201474 RVA: 0x00DBB6C0 File Offset: 0x00DB98C0
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

		// Token: 0x06031303 RID: 201475 RVA: 0x00DBB729 File Offset: 0x00DB9929
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

		// Token: 0x170061E9 RID: 25065
		// (get) Token: 0x06031304 RID: 201476 RVA: 0x00DBB758 File Offset: 0x00DB9958
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

		// Token: 0x06031305 RID: 201477 RVA: 0x00DBB7F4 File Offset: 0x00DB99F4
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

		// Token: 0x06031306 RID: 201478 RVA: 0x00DBB8DA File Offset: 0x00DB9ADA
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

		// Token: 0x06031307 RID: 201479 RVA: 0x00DBB901 File Offset: 0x00DB9B01
		private bool IsInputEnable()
		{
			return this.SkillButtonData != null && this.SkillButtonData.IsEnable();
		}

		// Token: 0x06031308 RID: 201480 RVA: 0x00DBB918 File Offset: 0x00DB9B18
		public virtual bool IsVisible()
		{
			return this.SkillButtonData != null && !this.IsDisappearAnimFinished && this.SkillButtonData.IsVisible();
		}

		// Token: 0x06031309 RID: 201481 RVA: 0x00DBB939 File Offset: 0x00DB9B39
		public EAttributeType GetAttributeId()
		{
			return this.SkillButtonData.AttributeId;
		}

		// Token: 0x0603130A RID: 201482 RVA: 0x00DBB946 File Offset: 0x00DB9B46
		public bool HasListenAttribute()
		{
			return this.SkillButtonData != null && this.SkillButtonData.HasAttribute();
		}

		// Token: 0x0603130B RID: 201483 RVA: 0x00DBB95D File Offset: 0x00DB9B5D
		public bool ShouldListenUltraAttribute()
		{
			return this.SkillButtonData != null && this.SkillButtonData.HasAttribute() && this.SkillButtonData.AttributeUsageMode == ESkillButtonAttributeUsageMode.Ultra;
		}

		// Token: 0x0603130C RID: 201484 RVA: 0x00DBB986 File Offset: 0x00DB9B86
		public SkillButtonData GetSkillButtonData()
		{
			return this.SkillButtonData as SkillButtonData;
		}

		// Token: 0x0603130D RID: 201485 RVA: 0x00DBB993 File Offset: 0x00DB9B93
		public int GetInputIndex()
		{
			return this.InputIndex;
		}

		// Token: 0x0603130E RID: 201486 RVA: 0x00DBB99B File Offset: 0x00DB9B9B
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

		// Token: 0x0603130F RID: 201487 RVA: 0x00DBB9D4 File Offset: 0x00DB9BD4
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

		// Token: 0x06031310 RID: 201488 RVA: 0x00DBBAB7 File Offset: 0x00DB9CB7
		protected void OnDeactivate()
		{
		}

		// Token: 0x06031311 RID: 201489 RVA: 0x00DBBAB9 File Offset: 0x00DB9CB9
		[NullableContext(1)]
		public void SetOnVisibleChangedCallback(Action callback)
		{
			this.OnVisibleChangedCallback = callback;
		}

		// Token: 0x06031312 RID: 201490 RVA: 0x00DBBAC4 File Offset: 0x00DB9CC4
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

		// Token: 0x06031313 RID: 201491 RVA: 0x00DBBB21 File Offset: 0x00DB9D21
		public InputMultiKeyItem GetKeyItem()
		{
			return this.KeyItem;
		}

		// Token: 0x06031314 RID: 201492 RVA: 0x00DBBB29 File Offset: 0x00DB9D29
		public bool GetSkillButtonInteractive()
		{
			UUIButtonComponent skillButton = this.SkillButton;
			return skillButton != null && skillButton.IsSelfInteractive;
		}

		// Token: 0x06031317 RID: 201495 RVA: 0x00DBBBBD File Offset: 0x00DB9DBD
		[CompilerGenerated]
		private void <PlayHideCd>g__OnHideCdFinish|124_0(float _)
		{
			this.SkillButtonData.RefreshIsEnable();
			this.FinishSkillCoolDown();
		}

		// Token: 0x0401A0B6 RID: 106678
		private const int SKILL_COOLDOWN_INTERVAL = 100;

		// Token: 0x0401A0B7 RID: 106679
		private const double SKILL_COOLDOWN_LOOP_INTERVAL = 0.1;

		// Token: 0x0401A0B8 RID: 106680
		private const int EQUIP_EFFECT_TIME = 500;

		// Token: 0x0401A0B9 RID: 106681
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly BattleSkillItem.EBattleSkillItem[] DISAPPEAR_HIDE_ITEMS = new BattleSkillItem.EBattleSkillItem[]
		{
			BattleSkillItem.EBattleSkillItem.SkillSprite,
			BattleSkillItem.EBattleSkillItem.SkillSpriteBg
		};

		// Token: 0x0401A0BA RID: 106682
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		private static readonly Stat PlaySkillCdStat = Stat.Create("[SkillButton]PlaySkillCd", "", "");

		// Token: 0x0401A0BB RID: 106683
		private UUIItem ParentItem;

		// Token: 0x0401A0BC RID: 106684
		protected UUIDraggableComponent DraggableComponent;

		// Token: 0x0401A0BD RID: 106685
		protected ISkillButtonData SkillButtonData;

		// Token: 0x0401A0BE RID: 106686
		private UUIButtonComponent SkillButton;

		// Token: 0x0401A0BF RID: 106687
		private TimerHandle ChangeCoolDownRefreshTimerId;

		// Token: 0x0401A0C0 RID: 106688
		private UUIItem CoolDownUiItem;

		// Token: 0x0401A0C1 RID: 106689
		protected UUIText CoolDownUiText;

		// Token: 0x0401A0C2 RID: 106690
		private UUISprite CoolDownBarUiSprite;

		// Token: 0x0401A0C3 RID: 106691
		private double CurrentCoolDownTime;

		// Token: 0x0401A0C4 RID: 106692
		private double TotalCoolDownTime;

		// Token: 0x0401A0C5 RID: 106693
		private double CoolDownStartTime;

		// Token: 0x0401A0C6 RID: 106694
		protected Action OnCoolDownFinishedCallback;

		// Token: 0x0401A0C7 RID: 106695
		private bool HasEruptedMaxEffect;

		// Token: 0x0401A0C8 RID: 106696
		protected TimerHandle LongPressTimerId;

		// Token: 0x0401A0C9 RID: 106697
		protected bool IsLongPress;

		// Token: 0x0401A0CA RID: 106698
		private bool IsAddedEvents;

		// Token: 0x0401A0CB RID: 106699
		[Nullable(1)]
		private string CdCompletedEffectPath = string.Empty;

		// Token: 0x0401A0CC RID: 106700
		private BattleSkillItemDynamicEffect DynamicEffect;

		// Token: 0x0401A0CD RID: 106701
		private string SkillIconPath;

		// Token: 0x0401A0CE RID: 106702
		private int InputIndex;

		// Token: 0x0401A0CF RID: 106703
		private TimerHandle HideCdTimerId;

		// Token: 0x0401A0D0 RID: 106704
		private TimerHandle EquipEffectTimerId;

		// Token: 0x0401A0D1 RID: 106705
		protected InputMultiKeyItem KeyItem;

		// Token: 0x0401A0D2 RID: 106706
		protected int SetTextureHandleId;

		// Token: 0x0401A0D3 RID: 106707
		private int? LoadCdCompletedNiagaraHandleId = new int?(0);

		// Token: 0x0401A0D4 RID: 106708
		protected string KeyActionName;

		// Token: 0x0401A0D5 RID: 106709
		protected EOperationType? KeyOperationType;

		// Token: 0x0401A0D6 RID: 106710
		protected BattleUiNiagaraItem ClickEffect;

		// Token: 0x0401A0D7 RID: 106711
		protected UUISprite CombinePressTipSprite;

		// Token: 0x0401A0D8 RID: 106712
		protected CSharpScript.Game.Input.EInputAction PressActionType = CSharpScript.Game.Input.EInputAction.None;

		// Token: 0x0401A0D9 RID: 106713
		private int LinkStatus;

		// Token: 0x0401A0DA RID: 106714
		private bool HasBattleLinkEvent;

		// Token: 0x0401A0DB RID: 106715
		private bool IsPlayingLinkEffect;

		// Token: 0x0401A0DC RID: 106716
		private UUITexture SkillTexture;

		// Token: 0x0401A0DD RID: 106717
		private UUISprite SkillSprite;

		// Token: 0x0401A0DE RID: 106718
		private UUITextureTransitionComponent SkillTextureTransitionComp;

		// Token: 0x0401A0DF RID: 106719
		private UUISpriteTransition SkillSpriteTransitionComp;

		// Token: 0x0401A0E0 RID: 106720
		private UTexture DefaultSkillTextureData;

		// Token: 0x0401A0E1 RID: 106721
		private ULGUISpriteData_BaseObject DefaultSkillSpriteData;

		// Token: 0x0401A0E2 RID: 106722
		private bool IsDefaultSkillTexture;

		// Token: 0x0401A0E3 RID: 106723
		private bool IsDefaultSkillSprite;

		// Token: 0x0401A0E4 RID: 106724
		private bool IsLoadingSkillIcon;

		// Token: 0x0401A0E5 RID: 106725
		protected bool HideCdText;

		// Token: 0x0401A0E6 RID: 106726
		protected int CdFixedPoint = 1;

		// Token: 0x0401A0E7 RID: 106727
		protected bool IsHideNumComp;

		// Token: 0x0401A0E8 RID: 106728
		private float TargetAlpha = 1f;

		// Token: 0x0401A0E9 RID: 106729
		private float BaseAlpha = 1f;

		// Token: 0x0401A0EA RID: 106730
		protected UUIText SkillNameText;

		// Token: 0x0401A0EB RID: 106731
		protected int UltraComponentVisibleState;

		// Token: 0x0401A0EC RID: 106732
		private int LayoutIndex;

		// Token: 0x0401A0ED RID: 106733
		private Action OnVisibleChangedCallback;

		// Token: 0x0401A0EE RID: 106734
		private bool EnableSlideControl;

		// Token: 0x0401A0EF RID: 106735
		private bool IsDisappearAnimFinished;

		// Token: 0x0401A0F0 RID: 106736
		protected BattleSkillUltraItem UltraComponent;

		// Token: 0x0401A0F1 RID: 106737
		protected BattleSkillNumItem NumComponent;

		// Token: 0x0401A0F2 RID: 106738
		protected BattleSkillDotIndicatorItem DotIndicatorComponent;

		// Token: 0x0401A0F3 RID: 106739
		protected SkillItemDisappear ButtonDisappearComponent;

		// Token: 0x0401A0F4 RID: 106740
		protected BattleSkillSwitchComponent SwitchComponent;

		// Token: 0x0401A0F5 RID: 106741
		protected BattleSkillLongPressItem LongPressComponent;

		// Token: 0x0401A0F6 RID: 106742
		protected BattleSkillConfigLongPressItem ConfigLongPressComponent;

		// Token: 0x0401A0F7 RID: 106743
		protected BattleSkillExtraEffectItem ExtraEffectComponent;

		// Token: 0x0401A0F8 RID: 106744
		protected ULGUIPlayTweenComponent AlphaTweenComp;

		// Token: 0x0200A947 RID: 43335
		[NullableContext(0)]
		private enum EBattleSkillItem
		{
			// Token: 0x040344BE RID: 214206
			CoolDownItem,
			// Token: 0x040344BF RID: 214207
			CoolDownBarSprite,
			// Token: 0x040344C0 RID: 214208
			CoolDownText,
			// Token: 0x040344C1 RID: 214209
			SkillSprite,
			// Token: 0x040344C2 RID: 214210
			SkillTexture,
			// Token: 0x040344C3 RID: 214211
			SkillButton,
			// Token: 0x040344C4 RID: 214212
			CdCompletedNiagara,
			// Token: 0x040344C5 RID: 214213
			DynamicEffectNiagara,
			// Token: 0x040344C6 RID: 214214
			ExtraContainer,
			// Token: 0x040344C7 RID: 214215
			ExploreSkillEquip,
			// Token: 0x040344C8 RID: 214216
			ClickEffectNiagara,
			// Token: 0x040344C9 RID: 214217
			SkillNameText,
			// Token: 0x040344CA RID: 214218
			LinkExplosionNiagara,
			// Token: 0x040344CB RID: 214219
			SkillSpriteBg,
			// Token: 0x040344CC RID: 214220
			CombinePressTipSprite,
			// Token: 0x040344CD RID: 214221
			KeyItem
		}

		// Token: 0x0200A948 RID: 43336
		[NullableContext(0)]
		private enum EUltraComponentVisibleReason
		{
			// Token: 0x040344CF RID: 214223
			Attribute,
			// Token: 0x040344D0 RID: 214224
			Link
		}
	}
}
