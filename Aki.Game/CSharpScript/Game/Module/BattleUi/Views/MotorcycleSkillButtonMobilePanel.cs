using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D84 RID: 19844
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleSkillButtonMobilePanel : UiPanelBase
	{
		// Token: 0x06031D0F RID: 204047 RVA: 0x00DEE914 File Offset: 0x00DECB14
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
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

		// Token: 0x06031D10 RID: 204048 RVA: 0x00DEEA88 File Offset: 0x00DECC88
		protected override UniTask OnBeforeStartAsync()
		{
			MotorcycleSkillButtonMobilePanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031D11 RID: 204049 RVA: 0x00DEEACB File Offset: 0x00DECCCB
		protected override void OnBeforeDestroy()
		{
			this.BattleSkillItemList.Clear();
			this.BehaviorButtonMap.Clear();
			BattleUiModel.Instance.ChildViewData.RemoveCallback(EBattleUiChild.MotorcycleMobileSkillButton, new Action(this.OnSkillButtonVisibleChanged));
		}

		// Token: 0x06031D12 RID: 204050 RVA: 0x00DEEB00 File Offset: 0x00DECD00
		protected override void OnAfterShow()
		{
			this.AddEvents();
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshEnable(true);
			}
			foreach (BehaviorButton behaviorButton in this.BehaviorButtonMap.Values)
			{
				behaviorButton.UpdateAlpha();
			}
			this.DataDirty = true;
		}

		// Token: 0x06031D13 RID: 204051 RVA: 0x00DEEBA4 File Offset: 0x00DECDA4
		protected override void OnBeforeHide()
		{
			this.RemoveEvents();
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				if (battleSkillItem.IsShowOrShowing)
				{
					battleSkillItem.TryReleaseButton();
				}
			}
		}

		// Token: 0x06031D14 RID: 204052 RVA: 0x00DEEC04 File Offset: 0x00DECE04
		protected override void OnBeforeShow()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshSkillCoolDownOnShow();
			}
		}

		// Token: 0x06031D15 RID: 204053 RVA: 0x00DEEC54 File Offset: 0x00DECE54
		public void Tick(float delta)
		{
			if (!base.IsShowOrShowing)
			{
				return;
			}
			if (this.DataDirty)
			{
				this.DataDirty = false;
				this.RefreshAllBattleSkillItems();
				this.RefreshAllBehaviorButton();
			}
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Tick(delta);
			}
		}

		// Token: 0x06031D16 RID: 204054 RVA: 0x00DEECCC File Offset: 0x00DECECC
		private void RefreshAllBattleSkillItems()
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			IList<int> motorPadButtonTypeList = instance.GetMotorPadButtonTypeList();
			for (int i = 0; i < this.BattleSkillItemList.Count; i++)
			{
				int num = (motorPadButtonTypeList.Count > i) ? motorPadButtonTypeList[i] : 0;
				BattleSkillItem battleSkillItem = this.BattleSkillItemList[i];
				SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)num);
				if (skillButtonDataByButton == null)
				{
					battleSkillItem.Deactivate();
				}
				else if (num == 0)
				{
					battleSkillItem.Deactivate();
				}
				else if (num < 0)
				{
					battleSkillItem.Deactivate();
				}
				else
				{
					skillButtonDataByButton.GetSkillId();
					battleSkillItem.Refresh(skillButtonDataByButton);
				}
			}
		}

		// Token: 0x06031D17 RID: 204055 RVA: 0x00DEED60 File Offset: 0x00DECF60
		private void DeactivateAllBattleSkillItems()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Deactivate();
			}
		}

		// Token: 0x06031D18 RID: 204056 RVA: 0x00DEEDB0 File Offset: 0x00DECFB0
		public UniTask NewAllBattleSkillItems()
		{
			MotorcycleSkillButtonMobilePanel.<NewAllBattleSkillItems>d__17 <NewAllBattleSkillItems>d__;
			<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBattleSkillItems>d__.<>4__this = this;
			<NewAllBattleSkillItems>d__.<>1__state = -1;
			<NewAllBattleSkillItems>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewAllBattleSkillItems>d__17>(ref <NewAllBattleSkillItems>d__);
			return <NewAllBattleSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031D19 RID: 204057 RVA: 0x00DEEDF4 File Offset: 0x00DECFF4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleSkillItem> NewBattleSkillItem(AActor rootActor, int inputIndex)
		{
			MotorcycleSkillButtonMobilePanel.<NewBattleSkillItem>d__18 <NewBattleSkillItem>d__;
			<NewBattleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleSkillItem>.Create();
			<NewBattleSkillItem>d__.<>4__this = this;
			<NewBattleSkillItem>d__.rootActor = rootActor;
			<NewBattleSkillItem>d__.inputIndex = inputIndex;
			<NewBattleSkillItem>d__.<>1__state = -1;
			<NewBattleSkillItem>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewBattleSkillItem>d__18>(ref <NewBattleSkillItem>d__);
			return <NewBattleSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031D1A RID: 204058 RVA: 0x00DEEE47 File Offset: 0x00DED047
		private BattleSkillItem GetBattleSkillItem(int inputIndex)
		{
			return this.BattleSkillItemList[inputIndex];
		}

		// Token: 0x06031D1B RID: 204059 RVA: 0x00DEEE58 File Offset: 0x00DED058
		[NullableContext(2)]
		public BattleSkillItem GetBattleSkillItemByButtonType(ESkillButtonType buttonType)
		{
			int motorPadSkillButtonIndexByButton = SkillButtonUiModel.Instance.GetMotorPadSkillButtonIndexByButton((int)buttonType);
			if (motorPadSkillButtonIndexByButton < 0)
			{
				return null;
			}
			return this.GetBattleSkillItem(motorPadSkillButtonIndexByButton);
		}

		// Token: 0x06031D1C RID: 204060 RVA: 0x00DEEE80 File Offset: 0x00DED080
		private UniTask NewAllBehaviorButton()
		{
			MotorcycleSkillButtonMobilePanel.<NewAllBehaviorButton>d__21 <NewAllBehaviorButton>d__;
			<NewAllBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBehaviorButton>d__.<>4__this = this;
			<NewAllBehaviorButton>d__.<>1__state = -1;
			<NewAllBehaviorButton>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewAllBehaviorButton>d__21>(ref <NewAllBehaviorButton>d__);
			return <NewAllBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031D1D RID: 204061 RVA: 0x00DEEEC4 File Offset: 0x00DED0C4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BehaviorButton> NewBehaviorButton(AActor rootActor, EBehaviorType inputActionType)
		{
			MotorcycleSkillButtonMobilePanel.<NewBehaviorButton>d__22 <NewBehaviorButton>d__;
			<NewBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BehaviorButton>.Create();
			<NewBehaviorButton>d__.<>4__this = this;
			<NewBehaviorButton>d__.rootActor = rootActor;
			<NewBehaviorButton>d__.inputActionType = inputActionType;
			<NewBehaviorButton>d__.<>1__state = -1;
			<NewBehaviorButton>d__.<>t__builder.Start<MotorcycleSkillButtonMobilePanel.<NewBehaviorButton>d__22>(ref <NewBehaviorButton>d__);
			return <NewBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031D1E RID: 204062 RVA: 0x00DEEF18 File Offset: 0x00DED118
		private void RefreshAllBehaviorButton()
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			foreach (BehaviorButton behaviorButton in this.BehaviorButtonMap.Values)
			{
				BehaviorButtonData behaviorButtonDataByButton = instance.GetBehaviorButtonDataByButton(behaviorButton.BehaviorType);
				if (behaviorButtonDataByButton != null)
				{
					behaviorButton.Refresh(behaviorButtonDataByButton);
				}
			}
		}

		// Token: 0x06031D1F RID: 204063 RVA: 0x00DEEF88 File Offset: 0x00DED188
		[NullableContext(2)]
		private BehaviorButton GetBehaviorButton(EBehaviorType inputActionType)
		{
			return this.BehaviorButtonMap.GetValueOrDefault(inputActionType);
		}

		// Token: 0x06031D20 RID: 204064 RVA: 0x00DEEF98 File Offset: 0x00DED198
		protected void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnSetUiVisible));
			EventSystem.Instance.Add<ESkillButtonRefreshReason>(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Add(EEventName.OnSkillButtonDataClear, new Action(this.OnSkillButtonDataClear));
			EventSystem.Instance.Add(EEventName.OnMotorPadSkillButtonIndexRefresh, new Action(this.OnSkillButtonIndexRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int>(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<ESkillButtonType, int, int>(EEventName.OnSkillButtonCustomRefresh, new Action<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Add<bool>(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
		}

		// Token: 0x06031D21 RID: 204065 RVA: 0x00DEF208 File Offset: 0x00DED408
		protected void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnSetUiVisible));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataClear, new Action(this.OnSkillButtonDataClear));
			EventSystem.Instance.Remove(EEventName.OnMotorPadSkillButtonIndexRefresh, new Action(this.OnSkillButtonIndexRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCustomRefresh, new Action<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Remove(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
		}

		// Token: 0x06031D22 RID: 204066 RVA: 0x00DEF478 File Offset: 0x00DED678
		private void OnSetUiVisible(bool bVisible)
		{
			if (bVisible)
			{
				foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
				{
					battleSkillItem.RefreshEnable(true);
				}
			}
		}

		// Token: 0x06031D23 RID: 204067 RVA: 0x00DEF4CC File Offset: 0x00DED6CC
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			if (refreshReason == ESkillButtonRefreshReason.GamepadRefreshAimState || refreshReason == ESkillButtonRefreshReason.GamepadRefreshKeyAction)
			{
				return;
			}
			this.DataDirty = true;
		}

		// Token: 0x06031D24 RID: 204068 RVA: 0x00DEF4DE File Offset: 0x00DED6DE
		private void OnSkillButtonDataClear()
		{
			this.DeactivateAllBattleSkillItems();
		}

		// Token: 0x06031D25 RID: 204069 RVA: 0x00DEF4E6 File Offset: 0x00DED6E6
		private void OnSkillButtonIndexRefresh()
		{
			if (!BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				return;
			}
			this.DataDirty = true;
		}

		// Token: 0x06031D26 RID: 204070 RVA: 0x00DEF504 File Offset: 0x00DED704
		private void OnSkillButtonEnableRefresh(ESkillButtonType buttonType, int extendCoolDown)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (battleSkillItemByButtonType.GetSkillButtonData() == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshEnable(false);
		}

		// Token: 0x06031D27 RID: 204071 RVA: 0x00DEF530 File Offset: 0x00DED730
		private void OnSkillButtonVisibleRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (battleSkillItemByButtonType.GetSkillButtonData() == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshVisible();
			battleSkillItemByButtonType.RefreshKey();
		}

		// Token: 0x06031D28 RID: 204072 RVA: 0x00DEF560 File Offset: 0x00DED760
		private void OnSkillButtonDynamicEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (battleSkillItemByButtonType.GetSkillButtonData() == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshDynamicEffect();
		}

		// Token: 0x06031D29 RID: 204073 RVA: 0x00DEF588 File Offset: 0x00DED788
		private void OnSkillButtonCustomRefresh(ESkillButtonType buttonType, int from, int param)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshCustomHdData(from, param);
			}
		}

		// Token: 0x06031D2A RID: 204074 RVA: 0x00DEF5B4 File Offset: 0x00DED7B4
		private void OnSkillButtonSkillIdRefresh(ESkillButtonType actionType)
		{
			SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(actionType);
			if (skillButtonDataByButton == null)
			{
				return;
			}
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(actionType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			skillButtonDataByButton.GetSkillId();
			battleSkillItemByButtonType.Refresh(skillButtonDataByButton);
		}

		// Token: 0x06031D2B RID: 204075 RVA: 0x00DEF5EC File Offset: 0x00DED7EC
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshAttribute(true);
		}

		// Token: 0x06031D2C RID: 204076 RVA: 0x00DEF60C File Offset: 0x00DED80C
		private void OnSkillButtonIconPathRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillIcon();
			battleSkillItemByButtonType.RefreshSkillName();
		}

		// Token: 0x06031D2D RID: 204077 RVA: 0x00DEF634 File Offset: 0x00DED834
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillCoolDown();
		}

		// Token: 0x06031D2E RID: 204078 RVA: 0x00DEF654 File Offset: 0x00DED854
		private void OnSkillButtonLongPressRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillButtonLongPress();
			battleSkillItemByButtonType.RefreshConfigLongPress(-1, 0);
		}

		// Token: 0x06031D2F RID: 204079 RVA: 0x00DEF67C File Offset: 0x00DED87C
		private void OnSkillButtonExtraEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshExtraEffect();
		}

		// Token: 0x06031D30 RID: 204080 RVA: 0x00DEF69C File Offset: 0x00DED89C
		private void OnBehaviorButtonEnableRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshEnable(false);
		}

		// Token: 0x06031D31 RID: 204081 RVA: 0x00DEF6BC File Offset: 0x00DED8BC
		private void OnBehaviorButtonVisibleRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshVisible();
		}

		// Token: 0x06031D32 RID: 204082 RVA: 0x00DEF6DC File Offset: 0x00DED8DC
		private void OnBehaviorButtonSkillIdRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshAll();
		}

		// Token: 0x06031D33 RID: 204083 RVA: 0x00DEF6FC File Offset: 0x00DED8FC
		private void OnBehaviorButtonIconPathRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshSkillIcon();
		}

		// Token: 0x06031D34 RID: 204084 RVA: 0x00DEF71C File Offset: 0x00DED91C
		private void OnBehaviorButtonDynamicEffectRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshDynamicEffect();
		}

		// Token: 0x06031D35 RID: 204085 RVA: 0x00DEF73C File Offset: 0x00DED93C
		private void OnPauseGame(int flag)
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.PauseGame(flag);
			}
		}

		// Token: 0x06031D36 RID: 204086 RVA: 0x00DEF790 File Offset: 0x00DED990
		private void OnChangedTimeScale()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshTimeDilation();
			}
		}

		// Token: 0x06031D37 RID: 204087 RVA: 0x00DEF7E0 File Offset: 0x00DED9E0
		private void OnCharSkillCdPauseStateChanged(bool _)
		{
			this.OnChangedTimeScale();
		}

		// Token: 0x06031D38 RID: 204088 RVA: 0x00DEF7E8 File Offset: 0x00DED9E8
		private void OnSkillButtonVisibleChanged()
		{
			bool visible = this.GetVisible();
			this.BaseVisible = BattleUiModel.Instance.ChildViewData.GetChildVisible(EBattleUiChild.MotorcycleMobileSkillButton);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x06031D39 RID: 204089 RVA: 0x00DEF81C File Offset: 0x00DEDA1C
		public override void SetActive(bool visibility)
		{
			if (this.GetVisible() != visibility)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "战斗子界面不要直接调用SetActive, 请调用SetVisible", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			base.SetActive(visibility);
		}

		// Token: 0x06031D3A RID: 204090 RVA: 0x00DEF858 File Offset: 0x00DEDA58
		public void SetVisible(int visibleReason, bool bVisible)
		{
			bool visible = this.GetVisible();
			this.SetVisibleInner(visibleReason, bVisible);
			this.CheckVisibleChange(visible);
		}

		// Token: 0x06031D3B RID: 204091 RVA: 0x00DEF87B File Offset: 0x00DEDA7B
		private void SetVisibleInner(int visibleReason, bool bVisible)
		{
			this.InnerVisibleState = VisibleStateUtil.SetVisible(this.InnerVisibleState, bVisible, visibleReason);
		}

		// Token: 0x06031D3C RID: 204092 RVA: 0x00DEF890 File Offset: 0x00DEDA90
		public bool GetVisible()
		{
			return this.BaseVisible && this.InnerVisibleState == 0;
		}

		// Token: 0x06031D3D RID: 204093 RVA: 0x00DEF8A8 File Offset: 0x00DEDAA8
		private void CheckVisibleChange(bool oldVisible)
		{
			bool visible = this.GetVisible();
			if (oldVisible == visible)
			{
				return;
			}
			this.SetActive(visible);
		}

		// Token: 0x0401A5FA RID: 108026
		private const int MOBILE_INDEX_EXPLORE_ITEM = 3;

		// Token: 0x0401A5FB RID: 108027
		private readonly List<BattleSkillItem> BattleSkillItemList = new List<BattleSkillItem>();

		// Token: 0x0401A5FC RID: 108028
		private readonly Dictionary<EBehaviorType, BehaviorButton> BehaviorButtonMap = new Dictionary<EBehaviorType, BehaviorButton>();

		// Token: 0x0401A5FD RID: 108029
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshAllBattleSkillItemObject = Stat.Create("[SkillButton]RefreshAllBattleSkillItem", "", "");

		// Token: 0x0401A5FE RID: 108030
		private bool BaseVisible;

		// Token: 0x0401A5FF RID: 108031
		private int InnerVisibleState = 1;

		// Token: 0x0401A600 RID: 108032
		private bool DataDirty;

		// Token: 0x0200AA80 RID: 43648
		[NullableContext(0)]
		private enum EPadChildType
		{
			// Token: 0x04034B14 RID: 215828
			SkillItem1,
			// Token: 0x04034B15 RID: 215829
			SkillItem2,
			// Token: 0x04034B16 RID: 215830
			SkillItem3,
			// Token: 0x04034B17 RID: 215831
			SkillItem4,
			// Token: 0x04034B18 RID: 215832
			SkillItem5,
			// Token: 0x04034B19 RID: 215833
			SkillItem6,
			// Token: 0x04034B1A RID: 215834
			SkillItem7,
			// Token: 0x04034B1B RID: 215835
			LockButtonItem,
			// Token: 0x04034B1C RID: 215836
			AimItem,
			// Token: 0x04034B1D RID: 215837
			SkillItem8
		}
	}
}
