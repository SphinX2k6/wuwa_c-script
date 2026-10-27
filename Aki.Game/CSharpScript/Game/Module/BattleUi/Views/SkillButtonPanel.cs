using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.InputSetting;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CCC RID: 23756
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonPanel : BattleChildViewPanel
	{
		// Token: 0x0603C125 RID: 246053 RVA: 0x00E5F4F4 File Offset: 0x00E5D6F4
		protected unsafe override void OnRegisterComponent()
		{
			EOperationType operationType = base.GetOperationType();
			if (operationType != EOperationType.Pad)
			{
				if (operationType == EOperationType.Desktop)
				{
					int num = 11;
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
					num2++;
					*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
					this.ComponentRegisterInfos = list;
					return;
				}
			}
			else
			{
				int num2 = 11;
				List<ValueTuple<int, Type>> list2 = new List<ValueTuple<int, Type>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list2, num2);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list2);
				int num = 0;
				*span[num] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(5, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(6, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(7, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(8, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(9, typeof(UUIItem));
				num++;
				*span[num] = new ValueTuple<int, Type>(10, typeof(UUIItem));
				this.ComponentRegisterInfos = list2;
			}
		}

		// Token: 0x0603C126 RID: 246054 RVA: 0x00E5F828 File Offset: 0x00E5DA28
		public override UniTask InitializeAsync()
		{
			SkillButtonPanel.<InitializeAsync>d__18 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<SkillButtonPanel.<InitializeAsync>d__18>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C127 RID: 246055 RVA: 0x00E5F86B File Offset: 0x00E5DA6B
		public override void Reset()
		{
			this.BattleSkillItemList.Clear();
			base.Reset();
			this.OffsetTweenComp = null;
			this.ClearRefreshLayoutTimer();
		}

		// Token: 0x0603C128 RID: 246056 RVA: 0x00E5F88C File Offset: 0x00E5DA8C
		protected override void OnAfterShow()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshEnable(true);
			}
			foreach (BehaviorButton behaviorButton in this.BehaviorButtonMap.Values)
			{
				behaviorButton.UpdateAlpha();
			}
		}

		// Token: 0x0603C129 RID: 246057 RVA: 0x00E5F924 File Offset: 0x00E5DB24
		protected override void OnHideBattleChildViewPanel()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				if (battleSkillItem.IsShowOrShowing)
				{
					battleSkillItem.TryReleaseButton();
				}
			}
			EventSystem.Instance.Emit(EEventName.OnSkillButtonPanelVisibleChange);
		}

		// Token: 0x0603C12A RID: 246058 RVA: 0x00E5F990 File Offset: 0x00E5DB90
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshSkillCoolDownOnShow();
			}
			EventSystem.Instance.Emit(EEventName.OnSkillButtonPanelVisibleChange);
		}

		// Token: 0x0603C12B RID: 246059 RVA: 0x00E5F9F0 File Offset: 0x00E5DBF0
		public override void OnTickBattleChildViewPanel(float delta)
		{
			if (!this.Visible)
			{
				return;
			}
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Tick(delta);
			}
		}

		// Token: 0x0603C12C RID: 246060 RVA: 0x00E5FA4C File Offset: 0x00E5DC4C
		private void RefreshAllBattleSkillItems()
		{
			if (Info.Instance.IsInGamepad())
			{
				return;
			}
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			IReadOnlyList<int> buttonTypeList = instance.GetButtonTypeList();
			for (int i = 0; i < this.BattleSkillItemList.Count; i++)
			{
				BattleSkillItem battleSkillItem = this.BattleSkillItemList[i];
				int num;
				if (!buttonTypeList.TryGetValue(i, out num) || num <= 0)
				{
					battleSkillItem.Deactivate();
				}
				else
				{
					SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)num);
					if (skillButtonDataByButton == null)
					{
						battleSkillItem.Deactivate();
					}
					else if (skillButtonDataByButton.GetSkillId() == 0)
					{
						battleSkillItem.Deactivate();
					}
					else
					{
						battleSkillItem.Refresh(skillButtonDataByButton);
					}
				}
			}
		}

		// Token: 0x0603C12D RID: 246061 RVA: 0x00E5FAE0 File Offset: 0x00E5DCE0
		private void DeactivateAllBattleSkillItems()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Deactivate();
			}
		}

		// Token: 0x0603C12E RID: 246062 RVA: 0x00E5FB30 File Offset: 0x00E5DD30
		public UniTask NewAllBattleSkillItems()
		{
			SkillButtonPanel.<NewAllBattleSkillItems>d__26 <NewAllBattleSkillItems>d__;
			<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBattleSkillItems>d__.<>4__this = this;
			<NewAllBattleSkillItems>d__.<>1__state = -1;
			<NewAllBattleSkillItems>d__.<>t__builder.Start<SkillButtonPanel.<NewAllBattleSkillItems>d__26>(ref <NewAllBattleSkillItems>d__);
			return <NewAllBattleSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C12F RID: 246063 RVA: 0x00E5FB74 File Offset: 0x00E5DD74
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleSkillItem> NewBattleSkillItem(AActor rootActor, int inputIndex, bool isMobile)
		{
			SkillButtonPanel.<NewBattleSkillItem>d__27 <NewBattleSkillItem>d__;
			<NewBattleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleSkillItem>.Create();
			<NewBattleSkillItem>d__.<>4__this = this;
			<NewBattleSkillItem>d__.rootActor = rootActor;
			<NewBattleSkillItem>d__.inputIndex = inputIndex;
			<NewBattleSkillItem>d__.isMobile = isMobile;
			<NewBattleSkillItem>d__.<>1__state = -1;
			<NewBattleSkillItem>d__.<>t__builder.Start<SkillButtonPanel.<NewBattleSkillItem>d__27>(ref <NewBattleSkillItem>d__);
			return <NewBattleSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C130 RID: 246064 RVA: 0x00E5FBCF File Offset: 0x00E5DDCF
		[NullableContext(2)]
		private BattleSkillItem GetBattleSkillItem(int inputIndex)
		{
			if (inputIndex < 0 || inputIndex >= this.BattleSkillItemList.Count)
			{
				return null;
			}
			return this.BattleSkillItemList[inputIndex];
		}

		// Token: 0x0603C131 RID: 246065 RVA: 0x00E5FBF4 File Offset: 0x00E5DDF4
		[NullableContext(2)]
		public BattleSkillItem GetBattleSkillItemByButtonType(ESkillButtonType buttonType)
		{
			int skillButtonIndexByButton = SkillButtonUiModel.Instance.GetSkillButtonIndexByButton((int)buttonType);
			if (skillButtonIndexByButton < 0)
			{
				return null;
			}
			return this.GetBattleSkillItem(skillButtonIndexByButton);
		}

		// Token: 0x0603C132 RID: 246066 RVA: 0x00E5FC1C File Offset: 0x00E5DE1C
		private UniTask NewAllBehaviorButton()
		{
			SkillButtonPanel.<NewAllBehaviorButton>d__30 <NewAllBehaviorButton>d__;
			<NewAllBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBehaviorButton>d__.<>4__this = this;
			<NewAllBehaviorButton>d__.<>1__state = -1;
			<NewAllBehaviorButton>d__.<>t__builder.Start<SkillButtonPanel.<NewAllBehaviorButton>d__30>(ref <NewAllBehaviorButton>d__);
			return <NewAllBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C133 RID: 246067 RVA: 0x00E5FC60 File Offset: 0x00E5DE60
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BehaviorButton> NewBehaviorButton(AActor rootActor, EBehaviorType inputActionType, bool isToggle = false)
		{
			SkillButtonPanel.<NewBehaviorButton>d__31 <NewBehaviorButton>d__;
			<NewBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder<BehaviorButton>.Create();
			<NewBehaviorButton>d__.<>4__this = this;
			<NewBehaviorButton>d__.rootActor = rootActor;
			<NewBehaviorButton>d__.inputActionType = inputActionType;
			<NewBehaviorButton>d__.<>1__state = -1;
			<NewBehaviorButton>d__.<>t__builder.Start<SkillButtonPanel.<NewBehaviorButton>d__31>(ref <NewBehaviorButton>d__);
			return <NewBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x0603C134 RID: 246068 RVA: 0x00E5FCB4 File Offset: 0x00E5DEB4
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

		// Token: 0x0603C135 RID: 246069 RVA: 0x00E5FD24 File Offset: 0x00E5DF24
		[NullableContext(2)]
		private BehaviorButton GetBehaviorButton(EBehaviorType inputActionType)
		{
			return this.BehaviorButtonMap.GetValueOrDefault(inputActionType);
		}

		// Token: 0x0603C136 RID: 246070 RVA: 0x00E5FD34 File Offset: 0x00E5DF34
		protected override void AddEvents()
		{
			EventSystem.Instance.Add<bool>(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnSetUiVisible));
			EventSystem.Instance.Add<ESkillButtonRefreshReason>(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Add(EEventName.OnSkillButtonDataClear, new Action(this.OnSkillButtonDataClear));
			EventSystem.Instance.Add(EEventName.OnSkillButtonIndexRefresh, new Action(this.OnSkillButtonIndexRefresh));
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
			EventSystem.Instance.Add<ESkillButtonType>(EEventName.OnSkillButtonSlideControlRefresh, new Action<ESkillButtonType>(this.OnSkillButtonEnableSlideControlRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Add<bool>(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add<EFunctionType, bool>(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiExploreModeChanged, new Action<bool>(this.OnBattleUiExploreModeChanged));
			EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnPressMotorcycleCombineButtonChanged));
				EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChange));
				InputDistributeController.Instance.BindActions(SkillButtonPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603C137 RID: 246071 RVA: 0x00E600A4 File Offset: 0x00E5E2A4
		protected override void RemoveEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnUiScreenRootVisibleChange, new Action<bool>(this.OnSetUiVisible));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataRefresh, new Action<ESkillButtonRefreshReason>(this.OnSkillButtonDataRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDataClear, new Action(this.OnSkillButtonDataClear));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonIndexRefresh, new Action(this.OnSkillButtonIndexRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonEnableRefresh, new Action<ESkillButtonType, int>(this.OnSkillButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonVisibleRefresh, new Action<ESkillButtonType>(this.OnSkillButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonDynamicEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCustomRefresh, new <>f__AnonymousDelegate3<ESkillButtonType, int, int>(this.OnSkillButtonCustomRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonSkillIdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonAttributeRefresh, new Action<ESkillButtonType>(this.OnSkillButtonAttributeRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonIconPathRefresh, new Action<ESkillButtonType>(this.OnSkillButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonCdRefresh, new Action<ESkillButtonType>(this.OnSkillButtonCdRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonLongPressRefresh, new Action<ESkillButtonType>(this.OnSkillButtonLongPressRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonExtraEffectRefresh, new Action<ESkillButtonType>(this.OnSkillButtonExtraEffectRefresh));
			EventSystem.Instance.Remove(EEventName.OnSkillButtonSlideControlRefresh, new Action<ESkillButtonType>(this.OnSkillButtonEnableSlideControlRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Remove(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenSet, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove(EEventName.OnFunctionOpenUpdate, new Action<EFunctionType, bool>(this.OnFunctionOpenUpdate));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.BattleUiExploreModeChanged, new Action<bool>(this.OnBattleUiExploreModeChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.OnMotorcycleStateChanged));
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				EventSystem.Instance.Remove(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnPressMotorcycleCombineButtonChanged));
				EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnViewPortSizeChange));
				InputDistributeController.Instance.UnBindActions(SkillButtonPanel.ActionNameList, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x0603C138 RID: 246072 RVA: 0x00E60414 File Offset: 0x00E5E614
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

		// Token: 0x0603C139 RID: 246073 RVA: 0x00E60468 File Offset: 0x00E5E668
		private void OnFunctionOpenUpdate(EFunctionType functionType, bool isOpen)
		{
			if (functionType != EFunctionType.ShowLockOnButton)
			{
				return;
			}
			BehaviorButton behaviorButton = this.GetBehaviorButton(EBehaviorType.LockTarget);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.SetActive(isOpen);
		}

		// Token: 0x0603C13A RID: 246074 RVA: 0x00E60486 File Offset: 0x00E5E686
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			if (refreshReason == ESkillButtonRefreshReason.GamepadRefreshAimState || refreshReason == ESkillButtonRefreshReason.GamepadRefreshKeyAction)
			{
				return;
			}
			this.RefreshAllBattleSkillItems();
			this.RefreshAllBehaviorButton();
			this.RefreshSkillItemByExploreMode();
			this.RefreshSkillItemLayout();
		}

		// Token: 0x0603C13B RID: 246075 RVA: 0x00E604A9 File Offset: 0x00E5E6A9
		private void OnSkillButtonDataClear()
		{
			this.DeactivateAllBattleSkillItems();
		}

		// Token: 0x0603C13C RID: 246076 RVA: 0x00E604B1 File Offset: 0x00E5E6B1
		private void OnSkillButtonIndexRefresh()
		{
			if (Info.Instance.IsInTouch() && BattleUiModel.Instance.MotorcycleData.IsDriving)
			{
				return;
			}
			this.RefreshAllBattleSkillItems();
			this.RefreshSkillItemByExploreMode();
			this.RefreshSkillItemLayout();
		}

		// Token: 0x0603C13D RID: 246077 RVA: 0x00E604E4 File Offset: 0x00E5E6E4
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

		// Token: 0x0603C13E RID: 246078 RVA: 0x00E60510 File Offset: 0x00E5E710
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
			if (!Info.Instance.IsInTouch())
			{
				this.RefreshSkillItemByExploreMode();
				this.RefreshSkillItemLayout();
			}
		}

		// Token: 0x0603C13F RID: 246079 RVA: 0x00E60558 File Offset: 0x00E5E758
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

		// Token: 0x0603C140 RID: 246080 RVA: 0x00E60580 File Offset: 0x00E5E780
		private void OnSkillButtonCustomRefresh(ESkillButtonType buttonType, int from = -1, int param = 0)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshCustomHdData(from, param);
			}
		}

		// Token: 0x0603C141 RID: 246081 RVA: 0x00E605AC File Offset: 0x00E5E7AC
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
			if (skillButtonDataByButton.GetSkillId() == 0)
			{
				battleSkillItemByButtonType.Deactivate();
			}
			else
			{
				battleSkillItemByButtonType.Refresh(skillButtonDataByButton);
			}
			if (!Info.Instance.IsInTouch())
			{
				this.RefreshSkillItemByExploreMode();
			}
		}

		// Token: 0x0603C142 RID: 246082 RVA: 0x00E60600 File Offset: 0x00E5E800
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshAttribute(true);
		}

		// Token: 0x0603C143 RID: 246083 RVA: 0x00E60620 File Offset: 0x00E5E820
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

		// Token: 0x0603C144 RID: 246084 RVA: 0x00E60648 File Offset: 0x00E5E848
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillCoolDown();
		}

		// Token: 0x0603C145 RID: 246085 RVA: 0x00E60668 File Offset: 0x00E5E868
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

		// Token: 0x0603C146 RID: 246086 RVA: 0x00E60690 File Offset: 0x00E5E890
		private void OnSkillButtonExtraEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshExtraEffect();
		}

		// Token: 0x0603C147 RID: 246087 RVA: 0x00E606B0 File Offset: 0x00E5E8B0
		private void OnSkillButtonEnableSlideControlRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSlideControl();
		}

		// Token: 0x0603C148 RID: 246088 RVA: 0x00E606D0 File Offset: 0x00E5E8D0
		private void OnBehaviorButtonEnableRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshEnable(false);
		}

		// Token: 0x0603C149 RID: 246089 RVA: 0x00E606F0 File Offset: 0x00E5E8F0
		private void OnBehaviorButtonVisibleRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshVisible();
		}

		// Token: 0x0603C14A RID: 246090 RVA: 0x00E60703 File Offset: 0x00E5E903
		private void OnBehaviorButtonSkillIdRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshAll();
		}

		// Token: 0x0603C14B RID: 246091 RVA: 0x00E60716 File Offset: 0x00E5E916
		private void OnBehaviorButtonIconPathRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshSkillIcon();
		}

		// Token: 0x0603C14C RID: 246092 RVA: 0x00E60729 File Offset: 0x00E5E929
		private void OnBehaviorButtonDynamicEffectRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshDynamicEffect();
		}

		// Token: 0x0603C14D RID: 246093 RVA: 0x00E6073C File Offset: 0x00E5E93C
		private void OnPauseGame(int flag)
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.PauseGame(flag);
			}
		}

		// Token: 0x0603C14E RID: 246094 RVA: 0x00E60790 File Offset: 0x00E5E990
		private void OnChangedTimeScale()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshTimeDilation();
			}
		}

		// Token: 0x0603C14F RID: 246095 RVA: 0x00E607E0 File Offset: 0x00E5E9E0
		private void OnCharSkillCdPauseStateChanged(bool _)
		{
			this.OnChangedTimeScale();
		}

		// Token: 0x0603C150 RID: 246096 RVA: 0x00E607E8 File Offset: 0x00E5E9E8
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (Info.Instance.IsInGamepad())
			{
				base.SetVisible(EBattleUiVisibleReason.Gamepad, false);
				return;
			}
			base.SetVisible(EBattleUiVisibleReason.Gamepad, true);
			this.RefreshAllBattleSkillItems();
			this.RefreshSkillItemByExploreMode();
			this.RefreshSkillItemLayout();
		}

		// Token: 0x0603C151 RID: 246097 RVA: 0x00E60819 File Offset: 0x00E5EA19
		private void OnBattleUiExploreModeChanged(bool isInExploreMode)
		{
			if (SkillButtonUiModel.Instance.CurSkillButtonIndexData.IsNormalButtonTypeList)
			{
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				if (curRoleData == null || !curRoleData.IsPhantom())
				{
					if (this.IsInExploreMode == isInExploreMode)
					{
						return;
					}
					this.RefreshSkillItemByExploreModeInner(isInExploreMode, true);
					return;
				}
			}
		}

		// Token: 0x0603C152 RID: 246098 RVA: 0x00E60858 File Offset: 0x00E5EA58
		private void RefreshSkillItemByExploreMode()
		{
			bool isInExploreMode = BattleUiModel.Instance.ExploreModeData.GetIsInExploreMode();
			if (!SkillButtonUiModel.Instance.CurSkillButtonIndexData.IsNormalButtonTypeList)
			{
				BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
				if (curRoleData == null || !curRoleData.IsPhantom())
				{
					if (!this.IsInExploreMode)
					{
						return;
					}
					this.RefreshSkillItemByExploreModeInner(false, false);
					return;
				}
			}
			if (this.IsInExploreMode == isInExploreMode && Info.Instance.IsInTouch())
			{
				return;
			}
			this.RefreshSkillItemByExploreModeInner(isInExploreMode, false);
		}

		// Token: 0x0603C153 RID: 246099 RVA: 0x00E608D0 File Offset: 0x00E5EAD0
		private void RefreshSkillItemByExploreModeInner(bool isInExploreMode, bool anim = false)
		{
			this.IsInExploreMode = isInExploreMode;
			bool visible = !isInExploreMode;
			BehaviorButton valueOrDefault = this.BehaviorButtonMap.GetValueOrDefault(EBehaviorType.Aim);
			if (valueOrDefault != null)
			{
				valueOrDefault.SetVisibleByExploreMode(visible, anim);
			}
			BehaviorButton valueOrDefault2 = this.BehaviorButtonMap.GetValueOrDefault(EBehaviorType.LockTarget);
			if (valueOrDefault2 != null)
			{
				valueOrDefault2.SetVisibleByExploreMode(visible, anim);
			}
			this.BattleSkillItemList[1].SetVisibleByExploreMode(visible, anim);
			this.BattleSkillItemList[2].SetVisibleByExploreMode(visible, anim);
			if (!Info.Instance.IsInTouch())
			{
				this.BattleSkillItemList[3].SetVisibleByExploreMode(visible, anim);
				this.RefreshRootItemOffsetByExploreMode(isInExploreMode, anim);
				return;
			}
			this.BattleSkillItemList[4].SetVisibleByExploreMode(visible, anim);
		}

		// Token: 0x0603C154 RID: 246100 RVA: 0x00E60980 File Offset: 0x00E5EB80
		private void RefreshRootItemOffsetByExploreMode(bool isInExploreMode, bool anim = false)
		{
			float num = -86f;
			if (isInExploreMode)
			{
				int num2 = 0;
				for (int i = 1; i < 4; i++)
				{
					if (this.BattleSkillItemList[i].IsShowOrShowing)
					{
						num2++;
					}
				}
				num += (float)(num2 * 144);
			}
			if (anim)
			{
				if (this.OffsetTweenComp == null)
				{
					this.OffsetTweenComp = (this.RootActor.GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
				}
				else
				{
					this.OffsetTweenComp.Stop();
				}
				ULGUIPlayTween_Float ulguiplayTween_Float = this.OffsetTweenComp.GetPlayTween() as ULGUIPlayTween_Float;
				ulguiplayTween_Float.from = this.RootItem.GetAnchorOffsetX();
				ulguiplayTween_Float.to = num;
				this.OffsetTweenComp.Play();
				return;
			}
			ULGUIPlayTweenComponent offsetTweenComp = this.OffsetTweenComp;
			if (offsetTweenComp != null)
			{
				offsetTweenComp.Stop();
			}
			UUIItem rootItem = this.RootItem;
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetAnchorOffsetX(num);
		}

		// Token: 0x0603C155 RID: 246101 RVA: 0x00E60A54 File Offset: 0x00E5EC54
		private void UpdateAspectRatio()
		{
			int num = 0;
			int num2 = 0;
			Global.CharacterController.GetViewportSize(ref num, ref num2);
			if (num2 != 0)
			{
				this.AspectRatio = (float)num / (float)num2;
			}
		}

		// Token: 0x0603C156 RID: 246102 RVA: 0x00E60A84 File Offset: 0x00E5EC84
		private void RefreshSkillItemLayout()
		{
			if (!Info.Instance.IsInKeyBoard() || this.SkillItemLayoutList.Count == 0)
			{
				return;
			}
			BehaviorButton valueOrDefault = this.BehaviorButtonMap.GetValueOrDefault(EBehaviorType.Aim);
			BehaviorButton valueOrDefault2 = this.BehaviorButtonMap.GetValueOrDefault(EBehaviorType.LockTarget);
			bool flag = valueOrDefault != null && valueOrDefault.IsVisible() && valueOrDefault2 != null && valueOrDefault2.IsVisible();
			int num = 0;
			for (int i = this.BattleSkillItemList.Count - 1; i >= 0; i--)
			{
				BattleSkillItem battleSkillItem = this.BattleSkillItemList[i];
				if (battleSkillItem.IsVisible())
				{
					num++;
				}
				if (num < 6)
				{
					battleSkillItem.SetSkillItemLayout(this.SkillItemLayoutList[0]);
				}
				else if (num == 6)
				{
					if (this.AspectRatio <= this.AspectRatioThreshold || flag)
					{
						battleSkillItem.SetSkillItemLayout(this.SkillItemLayoutList[1]);
					}
					else
					{
						battleSkillItem.SetSkillItemLayout(this.SkillItemLayoutList[0]);
					}
				}
				else
				{
					battleSkillItem.SetSkillItemLayout(this.SkillItemLayoutList[1]);
				}
			}
			this.ClearRefreshLayoutTimer();
		}

		// Token: 0x0603C157 RID: 246103 RVA: 0x00E60B94 File Offset: 0x00E5ED94
		private void OnViewPortSizeChange()
		{
			this.UpdateAspectRatio();
			this.RefreshSkillItemLayout();
		}

		// Token: 0x0603C158 RID: 246104 RVA: 0x00E60BA2 File Offset: 0x00E5EDA2
		private void OnSkillItemVisibleChanged()
		{
			this.SetRefreshLayoutTimer();
		}

		// Token: 0x0603C159 RID: 246105 RVA: 0x00E60BAA File Offset: 0x00E5EDAA
		private void SetRefreshLayoutTimer()
		{
			if (this.RefreshLayoutTimer != null)
			{
				return;
			}
			this.RefreshLayoutTimer = TimerSystem.Instance.Next(new TTimerAction(this.RefreshSkillItemLayoutNextTick), null, null);
		}

		// Token: 0x0603C15A RID: 246106 RVA: 0x00E60BD3 File Offset: 0x00E5EDD3
		private void RefreshSkillItemLayoutNextTick(float _)
		{
			this.RefreshLayoutTimer = null;
			this.RefreshSkillItemLayout();
		}

		// Token: 0x0603C15B RID: 246107 RVA: 0x00E60BE2 File Offset: 0x00E5EDE2
		private void ClearRefreshLayoutTimer()
		{
			if (this.RefreshLayoutTimer != null)
			{
				if (TimerSystem.Instance.Has(this.RefreshLayoutTimer))
				{
					TimerSystem.Instance.Remove(this.RefreshLayoutTimer);
				}
				this.RefreshLayoutTimer = null;
			}
		}

		// Token: 0x0603C15C RID: 246108 RVA: 0x00E60C18 File Offset: 0x00E5EE18
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (actionName == "瞄准" || actionName == "载具视角切换")
			{
				BehaviorButton valueOrDefault = this.BehaviorButtonMap.GetValueOrDefault(EBehaviorType.Aim);
				if (((valueOrDefault != null) ? valueOrDefault.GetActionName() : null) == actionName)
				{
					valueOrDefault.OnInputAction();
				}
				return;
			}
			if (actionName == "锁定目标" || actionName == "载具锁定目标")
			{
				BehaviorButton valueOrDefault2 = this.BehaviorButtonMap.GetValueOrDefault(EBehaviorType.LockTarget);
				if (((valueOrDefault2 != null) ? valueOrDefault2.GetActionName() : null) == actionName)
				{
					valueOrDefault2.OnInputAction();
				}
				return;
			}
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				SkillButtonData skillButtonData = battleSkillItem.GetSkillButtonData();
				if (skillButtonData != null && !(skillButtonData.GetActionName() != actionName))
				{
					battleSkillItem.OnInputAction(false);
					break;
				}
			}
		}

		// Token: 0x0603C15D RID: 246109 RVA: 0x00E60D14 File Offset: 0x00E5EF14
		private void OnPressMotorcycleCombineButtonChanged(bool b)
		{
			this.RefreshKeyItemEnableInMotorcycle();
		}

		// Token: 0x0603C15E RID: 246110 RVA: 0x00E60D1C File Offset: 0x00E5EF1C
		public void RefreshKeyItemEnableInMotorcycle()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			if (motorcycleData == null || !motorcycleData.IsDriving)
			{
				return;
			}
			SkillButtonUiGamepadDataBase gamepadDataByType = SkillButtonUiModel.Instance.GetGamepadDataByType(ESkillButtonGamepadDataType.Motorcycle);
			if (gamepadDataByType != null && gamepadDataByType.GetIsPressCombineButton())
			{
				foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
				{
					if (battleSkillItem.IsVisible())
					{
						InputMultiKeyItem keyItem = battleSkillItem.GetKeyItem();
						if (keyItem != null)
						{
							keyItem.SetDisableBySingleKeyList(new <>z__ReadOnlyArray<string>(new string[]
							{
								EKey.LeftMouseButton,
								EKey.RightMouseButton,
								EKey.MiddleMouseButton
							}));
						}
					}
				}
				using (Dictionary<EBehaviorType, BehaviorButton>.ValueCollection.Enumerator enumerator2 = this.BehaviorButtonMap.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						BehaviorButton behaviorButton = enumerator2.Current;
						if (behaviorButton.IsVisible())
						{
							InputMultiKeyItem keyItem2 = behaviorButton.GetKeyItem();
							if (keyItem2 != null)
							{
								keyItem2.SetDisableBySingleKeyList(new <>z__ReadOnlyArray<string>(new string[]
								{
									EKey.LeftMouseButton,
									EKey.RightMouseButton,
									EKey.MiddleMouseButton
								}));
							}
						}
					}
					return;
				}
			}
			foreach (BattleSkillItem battleSkillItem2 in this.BattleSkillItemList)
			{
				InputMultiKeyItem keyItem3 = battleSkillItem2.GetKeyItem();
				if (keyItem3 != null)
				{
					keyItem3.SetEnable(true, false);
				}
			}
			foreach (BehaviorButton behaviorButton2 in this.BehaviorButtonMap.Values)
			{
				InputMultiKeyItem keyItem4 = behaviorButton2.GetKeyItem();
				if (keyItem4 != null)
				{
					keyItem4.SetEnable(true, false);
				}
			}
		}

		// Token: 0x0603C15F RID: 246111 RVA: 0x00E60F24 File Offset: 0x00E5F124
		private void OnMotorcycleStateChanged(bool b)
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			BattleUiMotorcycleData motorcycleData = BattleUiModel.Instance.MotorcycleData;
			if (motorcycleData == null || !motorcycleData.IsDriving)
			{
				foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
				{
					InputMultiKeyItem keyItem = battleSkillItem.GetKeyItem();
					if (keyItem != null)
					{
						keyItem.SetEnable(true, false);
					}
				}
				foreach (BehaviorButton behaviorButton in this.BehaviorButtonMap.Values)
				{
					InputMultiKeyItem keyItem2 = behaviorButton.GetKeyItem();
					if (keyItem2 != null)
					{
						keyItem2.SetEnable(true, false);
					}
				}
			}
		}

		// Token: 0x0603C161 RID: 246113 RVA: 0x00E61040 File Offset: 0x00E5F240
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static SkillButtonPanel()
		{
			int num = 18;
			List<string> list = new List<string>(num);
			CollectionsMarshal.SetCount<string>(list, num);
			Span<string> span = CollectionsMarshal.AsSpan<string>(list);
			int num2 = 0;
			*span[num2] = "跳跃";
			num2++;
			*span[num2] = "攻击";
			num2++;
			*span[num2] = "大招";
			num2++;
			*span[num2] = "幻象1";
			num2++;
			*span[num2] = "幻象2";
			num2++;
			*span[num2] = "技能1";
			num2++;
			*span[num2] = "闪避";
			num2++;
			*span[num2] = "瞄准";
			num2++;
			*span[num2] = "锁定目标";
			num2++;
			*span[num2] = "载具漂移";
			num2++;
			*span[num2] = "载具子弹跳";
			num2++;
			*span[num2] = "载具退场技和下车";
			num2++;
			*span[num2] = "载具探索工具";
			num2++;
			*span[num2] = "载具氮气";
			num2++;
			*span[num2] = "载具空中抬升";
			num2++;
			*span[num2] = "载具子弹跳1";
			num2++;
			*span[num2] = "载具视角切换";
			num2++;
			*span[num2] = "载具锁定目标";
			SkillButtonPanel.ActionNameList = list;
			SkillButtonPanel.RefreshAllBattleSkillItemObject = Stat.Create("[SkillButton]RefreshAllBattleSkillItem", "", "");
			SkillButtonPanel.RefreshSkillItemLayoutStat = Stat.Create("[SkillButton]RefreshSkillItemLayoutStat", "", "");
		}

		// Token: 0x0401F54B RID: 128331
		private const float INIT_OFFSET_X = -86f;

		// Token: 0x0401F54C RID: 128332
		private const int ITEM_WIDTH = 144;

		// Token: 0x0401F54D RID: 128333
		private const int MOBILE_INDEX_EXPLORE_ITEM = 3;

		// Token: 0x0401F54E RID: 128334
		private const int SECOND_LAYOUT_START_COUNT = 6;

		// Token: 0x0401F54F RID: 128335
		[StaticVariableRuleIgnore]
		private static readonly List<string> ActionNameList;

		// Token: 0x0401F550 RID: 128336
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshAllBattleSkillItemObject;

		// Token: 0x0401F551 RID: 128337
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshSkillItemLayoutStat;

		// Token: 0x0401F552 RID: 128338
		private readonly List<BattleSkillItem> BattleSkillItemList = new List<BattleSkillItem>();

		// Token: 0x0401F553 RID: 128339
		private readonly Dictionary<EBehaviorType, BehaviorButton> BehaviorButtonMap = new Dictionary<EBehaviorType, BehaviorButton>();

		// Token: 0x0401F554 RID: 128340
		[Nullable(2)]
		private ULGUIPlayTweenComponent OffsetTweenComp;

		// Token: 0x0401F555 RID: 128341
		private bool IsInExploreMode;

		// Token: 0x0401F556 RID: 128342
		private readonly List<SkillItemLayout> SkillItemLayoutList = new List<SkillItemLayout>();

		// Token: 0x0401F557 RID: 128343
		private float AspectRatio = 1.77778f;

		// Token: 0x0401F558 RID: 128344
		private float AspectRatioThreshold = 1.33333f;

		// Token: 0x0401F559 RID: 128345
		[Nullable(2)]
		private TimerHandle RefreshLayoutTimer;

		// Token: 0x0200BEE3 RID: 48867
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x04039920 RID: 235808
			SkillItem1,
			// Token: 0x04039921 RID: 235809
			SkillItem2,
			// Token: 0x04039922 RID: 235810
			SkillItem3,
			// Token: 0x04039923 RID: 235811
			SkillItem4,
			// Token: 0x04039924 RID: 235812
			SkillItem5,
			// Token: 0x04039925 RID: 235813
			SkillItem6,
			// Token: 0x04039926 RID: 235814
			AimButtonItem,
			// Token: 0x04039927 RID: 235815
			LockButtonItem,
			// Token: 0x04039928 RID: 235816
			SkillItem7,
			// Token: 0x04039929 RID: 235817
			SkillLayout1,
			// Token: 0x0403992A RID: 235818
			SkillLayout2
		}

		// Token: 0x0200BEE4 RID: 48868
		[NullableContext(0)]
		private enum EPadChildType
		{
			// Token: 0x0403992C RID: 235820
			SkillItem1,
			// Token: 0x0403992D RID: 235821
			SkillItem2,
			// Token: 0x0403992E RID: 235822
			SkillItem3,
			// Token: 0x0403992F RID: 235823
			SkillItem4,
			// Token: 0x04039930 RID: 235824
			SkillItem5,
			// Token: 0x04039931 RID: 235825
			SkillItem6,
			// Token: 0x04039932 RID: 235826
			SkillItem7,
			// Token: 0x04039933 RID: 235827
			LockButtonItem,
			// Token: 0x04039934 RID: 235828
			AimButtonItem,
			// Token: 0x04039935 RID: 235829
			SkillItem8,
			// Token: 0x04039936 RID: 235830
			SkillItem9
		}
	}
}
