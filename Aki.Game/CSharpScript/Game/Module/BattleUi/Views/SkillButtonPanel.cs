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
	// Token: 0x02004CAE RID: 19630
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonPanel : BattleChildViewPanel
	{
		// Token: 0x0603107A RID: 200826 RVA: 0x00DAFA48 File Offset: 0x00DADC48
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

		// Token: 0x0603107B RID: 200827 RVA: 0x00DAFD7C File Offset: 0x00DADF7C
		public override UniTask InitializeAsync()
		{
			SkillButtonPanel.<InitializeAsync>d__18 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<SkillButtonPanel.<InitializeAsync>d__18>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603107C RID: 200828 RVA: 0x00DAFDBF File Offset: 0x00DADFBF
		public override void Reset()
		{
			this.BattleSkillItemList.Clear();
			base.Reset();
			this.OffsetTweenComp = null;
			this.ClearRefreshLayoutTimer();
		}

		// Token: 0x0603107D RID: 200829 RVA: 0x00DAFDE0 File Offset: 0x00DADFE0
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

		// Token: 0x0603107E RID: 200830 RVA: 0x00DAFE78 File Offset: 0x00DAE078
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

		// Token: 0x0603107F RID: 200831 RVA: 0x00DAFEE4 File Offset: 0x00DAE0E4
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshSkillCoolDownOnShow();
			}
			EventSystem.Instance.Emit(EEventName.OnSkillButtonPanelVisibleChange);
		}

		// Token: 0x06031080 RID: 200832 RVA: 0x00DAFF44 File Offset: 0x00DAE144
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

		// Token: 0x06031081 RID: 200833 RVA: 0x00DAFFA0 File Offset: 0x00DAE1A0
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

		// Token: 0x06031082 RID: 200834 RVA: 0x00DB0034 File Offset: 0x00DAE234
		private void DeactivateAllBattleSkillItems()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.Deactivate();
			}
		}

		// Token: 0x06031083 RID: 200835 RVA: 0x00DB0084 File Offset: 0x00DAE284
		public UniTask NewAllBattleSkillItems()
		{
			SkillButtonPanel.<NewAllBattleSkillItems>d__26 <NewAllBattleSkillItems>d__;
			<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBattleSkillItems>d__.<>4__this = this;
			<NewAllBattleSkillItems>d__.<>1__state = -1;
			<NewAllBattleSkillItems>d__.<>t__builder.Start<SkillButtonPanel.<NewAllBattleSkillItems>d__26>(ref <NewAllBattleSkillItems>d__);
			return <NewAllBattleSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06031084 RID: 200836 RVA: 0x00DB00C8 File Offset: 0x00DAE2C8
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

		// Token: 0x06031085 RID: 200837 RVA: 0x00DB0123 File Offset: 0x00DAE323
		[NullableContext(2)]
		private BattleSkillItem GetBattleSkillItem(int inputIndex)
		{
			if (inputIndex < 0 || inputIndex >= this.BattleSkillItemList.Count)
			{
				return null;
			}
			return this.BattleSkillItemList[inputIndex];
		}

		// Token: 0x06031086 RID: 200838 RVA: 0x00DB0148 File Offset: 0x00DAE348
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

		// Token: 0x06031087 RID: 200839 RVA: 0x00DB0170 File Offset: 0x00DAE370
		private UniTask NewAllBehaviorButton()
		{
			SkillButtonPanel.<NewAllBehaviorButton>d__30 <NewAllBehaviorButton>d__;
			<NewAllBehaviorButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBehaviorButton>d__.<>4__this = this;
			<NewAllBehaviorButton>d__.<>1__state = -1;
			<NewAllBehaviorButton>d__.<>t__builder.Start<SkillButtonPanel.<NewAllBehaviorButton>d__30>(ref <NewAllBehaviorButton>d__);
			return <NewAllBehaviorButton>d__.<>t__builder.Task;
		}

		// Token: 0x06031088 RID: 200840 RVA: 0x00DB01B4 File Offset: 0x00DAE3B4
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

		// Token: 0x06031089 RID: 200841 RVA: 0x00DB0208 File Offset: 0x00DAE408
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

		// Token: 0x0603108A RID: 200842 RVA: 0x00DB0278 File Offset: 0x00DAE478
		[NullableContext(2)]
		private BehaviorButton GetBehaviorButton(EBehaviorType inputActionType)
		{
			return this.BehaviorButtonMap.GetValueOrDefault(inputActionType);
		}

		// Token: 0x0603108B RID: 200843 RVA: 0x00DB0288 File Offset: 0x00DAE488
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

		// Token: 0x0603108C RID: 200844 RVA: 0x00DB05F8 File Offset: 0x00DAE7F8
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

		// Token: 0x0603108D RID: 200845 RVA: 0x00DB0968 File Offset: 0x00DAEB68
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

		// Token: 0x0603108E RID: 200846 RVA: 0x00DB09BC File Offset: 0x00DAEBBC
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

		// Token: 0x0603108F RID: 200847 RVA: 0x00DB09DA File Offset: 0x00DAEBDA
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

		// Token: 0x06031090 RID: 200848 RVA: 0x00DB09FD File Offset: 0x00DAEBFD
		private void OnSkillButtonDataClear()
		{
			this.DeactivateAllBattleSkillItems();
		}

		// Token: 0x06031091 RID: 200849 RVA: 0x00DB0A05 File Offset: 0x00DAEC05
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

		// Token: 0x06031092 RID: 200850 RVA: 0x00DB0A38 File Offset: 0x00DAEC38
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

		// Token: 0x06031093 RID: 200851 RVA: 0x00DB0A64 File Offset: 0x00DAEC64
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

		// Token: 0x06031094 RID: 200852 RVA: 0x00DB0AAC File Offset: 0x00DAECAC
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

		// Token: 0x06031095 RID: 200853 RVA: 0x00DB0AD4 File Offset: 0x00DAECD4
		private void OnSkillButtonCustomRefresh(ESkillButtonType buttonType, int from = -1, int param = 0)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshCustomHdData(from, param);
			}
		}

		// Token: 0x06031096 RID: 200854 RVA: 0x00DB0B00 File Offset: 0x00DAED00
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

		// Token: 0x06031097 RID: 200855 RVA: 0x00DB0B54 File Offset: 0x00DAED54
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshAttribute(true);
		}

		// Token: 0x06031098 RID: 200856 RVA: 0x00DB0B74 File Offset: 0x00DAED74
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

		// Token: 0x06031099 RID: 200857 RVA: 0x00DB0B9C File Offset: 0x00DAED9C
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillCoolDown();
		}

		// Token: 0x0603109A RID: 200858 RVA: 0x00DB0BBC File Offset: 0x00DAEDBC
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

		// Token: 0x0603109B RID: 200859 RVA: 0x00DB0BE4 File Offset: 0x00DAEDE4
		private void OnSkillButtonExtraEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshExtraEffect();
		}

		// Token: 0x0603109C RID: 200860 RVA: 0x00DB0C04 File Offset: 0x00DAEE04
		private void OnSkillButtonEnableSlideControlRefresh(ESkillButtonType buttonType)
		{
			BattleSkillItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSlideControl();
		}

		// Token: 0x0603109D RID: 200861 RVA: 0x00DB0C24 File Offset: 0x00DAEE24
		private void OnBehaviorButtonEnableRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshEnable(false);
		}

		// Token: 0x0603109E RID: 200862 RVA: 0x00DB0C44 File Offset: 0x00DAEE44
		private void OnBehaviorButtonVisibleRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshVisible();
		}

		// Token: 0x0603109F RID: 200863 RVA: 0x00DB0C57 File Offset: 0x00DAEE57
		private void OnBehaviorButtonSkillIdRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshAll();
		}

		// Token: 0x060310A0 RID: 200864 RVA: 0x00DB0C6A File Offset: 0x00DAEE6A
		private void OnBehaviorButtonIconPathRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshSkillIcon();
		}

		// Token: 0x060310A1 RID: 200865 RVA: 0x00DB0C7D File Offset: 0x00DAEE7D
		private void OnBehaviorButtonDynamicEffectRefresh(EBehaviorType buttonType)
		{
			BehaviorButton behaviorButton = this.GetBehaviorButton(buttonType);
			if (behaviorButton == null)
			{
				return;
			}
			behaviorButton.RefreshDynamicEffect();
		}

		// Token: 0x060310A2 RID: 200866 RVA: 0x00DB0C90 File Offset: 0x00DAEE90
		private void OnPauseGame(int flag)
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.PauseGame(flag);
			}
		}

		// Token: 0x060310A3 RID: 200867 RVA: 0x00DB0CE4 File Offset: 0x00DAEEE4
		private void OnChangedTimeScale()
		{
			foreach (BattleSkillItem battleSkillItem in this.BattleSkillItemList)
			{
				battleSkillItem.RefreshTimeDilation();
			}
		}

		// Token: 0x060310A4 RID: 200868 RVA: 0x00DB0D34 File Offset: 0x00DAEF34
		private void OnCharSkillCdPauseStateChanged(bool _)
		{
			this.OnChangedTimeScale();
		}

		// Token: 0x060310A5 RID: 200869 RVA: 0x00DB0D3C File Offset: 0x00DAEF3C
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

		// Token: 0x060310A6 RID: 200870 RVA: 0x00DB0D6D File Offset: 0x00DAEF6D
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

		// Token: 0x060310A7 RID: 200871 RVA: 0x00DB0DAC File Offset: 0x00DAEFAC
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

		// Token: 0x060310A8 RID: 200872 RVA: 0x00DB0E24 File Offset: 0x00DAF024
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

		// Token: 0x060310A9 RID: 200873 RVA: 0x00DB0ED4 File Offset: 0x00DAF0D4
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

		// Token: 0x060310AA RID: 200874 RVA: 0x00DB0FA8 File Offset: 0x00DAF1A8
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

		// Token: 0x060310AB RID: 200875 RVA: 0x00DB0FD8 File Offset: 0x00DAF1D8
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

		// Token: 0x060310AC RID: 200876 RVA: 0x00DB10E8 File Offset: 0x00DAF2E8
		private void OnViewPortSizeChange()
		{
			this.UpdateAspectRatio();
			this.RefreshSkillItemLayout();
		}

		// Token: 0x060310AD RID: 200877 RVA: 0x00DB10F6 File Offset: 0x00DAF2F6
		private void OnSkillItemVisibleChanged()
		{
			this.SetRefreshLayoutTimer();
		}

		// Token: 0x060310AE RID: 200878 RVA: 0x00DB10FE File Offset: 0x00DAF2FE
		private void SetRefreshLayoutTimer()
		{
			if (this.RefreshLayoutTimer != null)
			{
				return;
			}
			this.RefreshLayoutTimer = TimerSystem.Instance.Next(new TTimerAction(this.RefreshSkillItemLayoutNextTick), null, null);
		}

		// Token: 0x060310AF RID: 200879 RVA: 0x00DB1127 File Offset: 0x00DAF327
		private void RefreshSkillItemLayoutNextTick(float _)
		{
			this.RefreshLayoutTimer = null;
			this.RefreshSkillItemLayout();
		}

		// Token: 0x060310B0 RID: 200880 RVA: 0x00DB1136 File Offset: 0x00DAF336
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

		// Token: 0x060310B1 RID: 200881 RVA: 0x00DB116C File Offset: 0x00DAF36C
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

		// Token: 0x060310B2 RID: 200882 RVA: 0x00DB1268 File Offset: 0x00DAF468
		private void OnPressMotorcycleCombineButtonChanged(bool b)
		{
			this.RefreshKeyItemEnableInMotorcycle();
		}

		// Token: 0x060310B3 RID: 200883 RVA: 0x00DB1270 File Offset: 0x00DAF470
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

		// Token: 0x060310B4 RID: 200884 RVA: 0x00DB1478 File Offset: 0x00DAF678
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

		// Token: 0x060310B6 RID: 200886 RVA: 0x00DB1594 File Offset: 0x00DAF794
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

		// Token: 0x0401A004 RID: 106500
		private const float INIT_OFFSET_X = -86f;

		// Token: 0x0401A005 RID: 106501
		private const int ITEM_WIDTH = 144;

		// Token: 0x0401A006 RID: 106502
		private const int MOBILE_INDEX_EXPLORE_ITEM = 3;

		// Token: 0x0401A007 RID: 106503
		private const int SECOND_LAYOUT_START_COUNT = 6;

		// Token: 0x0401A008 RID: 106504
		[StaticVariableRuleIgnore]
		private static readonly List<string> ActionNameList;

		// Token: 0x0401A009 RID: 106505
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshAllBattleSkillItemObject;

		// Token: 0x0401A00A RID: 106506
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshSkillItemLayoutStat;

		// Token: 0x0401A00B RID: 106507
		private readonly List<BattleSkillItem> BattleSkillItemList = new List<BattleSkillItem>();

		// Token: 0x0401A00C RID: 106508
		private readonly Dictionary<EBehaviorType, BehaviorButton> BehaviorButtonMap = new Dictionary<EBehaviorType, BehaviorButton>();

		// Token: 0x0401A00D RID: 106509
		[Nullable(2)]
		private ULGUIPlayTweenComponent OffsetTweenComp;

		// Token: 0x0401A00E RID: 106510
		private bool IsInExploreMode;

		// Token: 0x0401A00F RID: 106511
		private readonly List<SkillItemLayout> SkillItemLayoutList = new List<SkillItemLayout>();

		// Token: 0x0401A010 RID: 106512
		private float AspectRatio = 1.77778f;

		// Token: 0x0401A011 RID: 106513
		private float AspectRatioThreshold = 1.33333f;

		// Token: 0x0401A012 RID: 106514
		[Nullable(2)]
		private TimerHandle RefreshLayoutTimer;

		// Token: 0x0200A8E9 RID: 43241
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x040342E1 RID: 213729
			SkillItem1,
			// Token: 0x040342E2 RID: 213730
			SkillItem2,
			// Token: 0x040342E3 RID: 213731
			SkillItem3,
			// Token: 0x040342E4 RID: 213732
			SkillItem4,
			// Token: 0x040342E5 RID: 213733
			SkillItem5,
			// Token: 0x040342E6 RID: 213734
			SkillItem6,
			// Token: 0x040342E7 RID: 213735
			AimButtonItem,
			// Token: 0x040342E8 RID: 213736
			LockButtonItem,
			// Token: 0x040342E9 RID: 213737
			SkillItem7,
			// Token: 0x040342EA RID: 213738
			SkillLayout1,
			// Token: 0x040342EB RID: 213739
			SkillLayout2
		}

		// Token: 0x0200A8EA RID: 43242
		[NullableContext(0)]
		private enum EPadChildType
		{
			// Token: 0x040342ED RID: 213741
			SkillItem1,
			// Token: 0x040342EE RID: 213742
			SkillItem2,
			// Token: 0x040342EF RID: 213743
			SkillItem3,
			// Token: 0x040342F0 RID: 213744
			SkillItem4,
			// Token: 0x040342F1 RID: 213745
			SkillItem5,
			// Token: 0x040342F2 RID: 213746
			SkillItem6,
			// Token: 0x040342F3 RID: 213747
			SkillItem7,
			// Token: 0x040342F4 RID: 213748
			LockButtonItem,
			// Token: 0x040342F5 RID: 213749
			AimButtonItem,
			// Token: 0x040342F6 RID: 213750
			SkillItem8,
			// Token: 0x040342F7 RID: 213751
			SkillItem9
		}
	}
}
