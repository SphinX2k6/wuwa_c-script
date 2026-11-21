using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.SkillButtonUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C9F RID: 19615
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadSkillButtonPanel : BattleChildViewPanel
	{
		// Token: 0x06030F96 RID: 200598 RVA: 0x00DA9FF4 File Offset: 0x00DA81F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 23;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(21, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(22, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030F97 RID: 200599 RVA: 0x00DAA321 File Offset: 0x00DA8521
		public override void InitializeTemp()
		{
			this.GamepadData = SkillButtonUiModel.Instance.GamepadData;
		}

		// Token: 0x06030F98 RID: 200600 RVA: 0x00DAA334 File Offset: 0x00DA8534
		public override UniTask InitializeAsync()
		{
			GamepadSkillButtonPanel.<InitializeAsync>d__21 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<GamepadSkillButtonPanel.<InitializeAsync>d__21>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030F99 RID: 200601 RVA: 0x00DAA378 File Offset: 0x00DA8578
		public override void Reset()
		{
			this.BattleSkillItemList.Clear();
			BattleUiTweenAnimPlayer tweenAnimPlayer = this.TweenAnimPlayer;
			if (tweenAnimPlayer != null)
			{
				tweenAnimPlayer.Clear(false);
			}
			this.TweenAnimPlayer = null;
			LevelSequencePlayer dpadLevelSequencePlayer = this.DpadLevelSequencePlayer;
			if (dpadLevelSequencePlayer != null)
			{
				dpadLevelSequencePlayer.Clear();
			}
			this.DpadLevelSequencePlayer = null;
			SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
			if (gamepadData != null)
			{
				gamepadData.ClearInputAxis();
			}
			base.Reset();
		}

		// Token: 0x06030F9A RID: 200602 RVA: 0x00DAA3D8 File Offset: 0x00DA85D8
		protected override void OnAfterShow()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.RefreshEnable(true);
			}
		}

		// Token: 0x06030F9B RID: 200603 RVA: 0x00DAA42C File Offset: 0x00DA862C
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.RefreshSkillCoolDownOnShow();
			}
		}

		// Token: 0x06030F9C RID: 200604 RVA: 0x00DAA47C File Offset: 0x00DA867C
		public override void OnTickBattleChildViewPanel(float delta)
		{
			if (!this.Visible)
			{
				return;
			}
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.Tick(delta);
			}
		}

		// Token: 0x06030F9D RID: 200605 RVA: 0x00DAA4D8 File Offset: 0x00DA86D8
		protected override void AddEvents()
		{
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
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Add<EBehaviorType>(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Add<int>(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Add<bool>(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Add<EUiViewName, UiViewBase>(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnViewDone));
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Add(EEventName.BattleUiChatScrollViewVisibleChanged, new Action(this.OnChatScrollViewVisibleChanged));
			EventSystem.Instance.Add(EEventName.BattleUiSwitchInteractStateChanged, new Action(this.OnSwitchInteractStateChanged));
			EventSystem.Instance.Add(EEventName.BattleUiGamepadDataChanged, new Action(this.OnGamepadDataChanged));
			if (this.GamepadData.GamepadDataType == ESkillButtonGamepadDataType.Motorcycle)
			{
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputMotorcycleCombineButton));
			}
			else
			{
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
			}
			InputDistributeController.Instance.BindActions(this.GamepadData.GetAllActionNameList(), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.BindAxes(this.GamepadData.GetAllAxisNameList(), new TInputHandle<float>(this.OnInputAxis));
			InputDistributeController.Instance.BindAxis("MoveForward", new TInputHandle<float>(this.OnInputMoveForward));
			InputDistributeController.Instance.BindAxis("MoveRight", new TInputHandle<float>(this.OnInputMoveRight));
		}

		// Token: 0x06030F9E RID: 200606 RVA: 0x00DAA858 File Offset: 0x00DA8A58
		protected override void RemoveEvents()
		{
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
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonEnableRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonEnableRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonVisibleRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonVisibleRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonSkillIdRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonSkillIdRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonIconPathRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonIconPathRefresh));
			EventSystem.Instance.Remove(EEventName.OnBehaviorButtonDynamicEffectRefresh, new Action<EBehaviorType>(this.OnBehaviorButtonDynamicEffectRefresh));
			EventSystem.Instance.Remove(EEventName.PauseGame, new Action<int>(this.OnPauseGame));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnChangedTimeScale));
			EventSystem.Instance.Remove(EEventName.CharSkillCdPauseStateChanged, new Action<bool>(this.OnCharSkillCdPauseStateChanged));
			EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
			EventSystem.Instance.Remove(EEventName.OnViewDone, new Action<EUiViewName, UiViewBase>(this.OnViewDone));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
			EventSystem.Instance.Remove(EEventName.BattleUiChatScrollViewVisibleChanged, new Action(this.OnChatScrollViewVisibleChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiSwitchInteractStateChanged, new Action(this.OnSwitchInteractStateChanged));
			EventSystem.Instance.Remove(EEventName.BattleUiGamepadDataChanged, new Action(this.OnGamepadDataChanged));
			InputDistributeController.Instance.UnBindActions(this.GamepadData.GetAllActionNameList(), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.UnBindAxes(this.GamepadData.GetAllAxisNameList(), new TInputHandle<float>(this.OnInputAxis));
			InputDistributeController.Instance.UnBindAxis("MoveForward", new TInputHandle<float>(this.OnInputMoveForward));
			InputDistributeController.Instance.UnBindAxis("MoveRight", new TInputHandle<float>(this.OnInputMoveRight));
			if (this.GamepadData.GamepadDataType == ESkillButtonGamepadDataType.Motorcycle)
			{
				EventSystem.Instance.Remove(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputMotorcycleCombineButton));
				return;
			}
			EventSystem.Instance.Remove(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
		}

		// Token: 0x06030F9F RID: 200607 RVA: 0x00DAABD4 File Offset: 0x00DA8DD4
		private void RefreshGamepadData()
		{
			base.SetVisible(EBattleUiVisibleReason.Gamepad, Info.Instance.IsInGamepad());
			this.GamepadData.RefreshInteractBehaviorData();
			this.GamepadData.RefreshAimState();
		}

		// Token: 0x06030FA0 RID: 200608 RVA: 0x00DAAC00 File Offset: 0x00DA8E00
		private void InitKeyName()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				if (battleSkillGamepadItem.IsSubButton)
				{
					int index = battleSkillGamepadItem.GetInputIndex() - 4;
					battleSkillGamepadItem.SetKeyName(this.GamepadData.ButtonKeyList[index]);
				}
			}
		}

		// Token: 0x06030FA1 RID: 200609 RVA: 0x00DAAC74 File Offset: 0x00DA8E74
		private void RefreshAllBattleSkillItems()
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			this.RefreshMainBattleSkillItems();
			this.RefreshDpadMiddleItem();
			this.RefreshSubBattleSkillItems();
			BattleSkillCombineItem combineItem = this.CombineItem;
			if (combineItem == null)
			{
				return;
			}
			combineItem.Refresh();
		}

		// Token: 0x06030FA2 RID: 200610 RVA: 0x00DAACA8 File Offset: 0x00DA8EA8
		private void RefreshMainBattleSkillItems()
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			List<int?> curButtonTypeList = this.GamepadData.CurButtonTypeList;
			for (int i = 0; i < 12; i++)
			{
				BattleSkillGamepadItem battleSkillGamepadItem = this.BattleSkillItemList[i];
				if (i >= curButtonTypeList.Count)
				{
					battleSkillGamepadItem.Refresh(null);
				}
				else
				{
					int? num = curButtonTypeList[i];
					if (num == null)
					{
						battleSkillGamepadItem.Refresh(null);
					}
					else
					{
						SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)num.Value);
						if (skillButtonDataByButton == null)
						{
							BehaviorButtonData behaviorButtonDataByButton = instance.GetBehaviorButtonDataByButton((EBehaviorType)num.Value);
							if (behaviorButtonDataByButton != null && behaviorButtonDataByButton.IsVisible())
							{
								battleSkillGamepadItem.RefreshByBehaviorButtonData(behaviorButtonDataByButton);
								goto IL_95;
							}
						}
						this.RefreshMainSkillItemBySkillButtonData(battleSkillGamepadItem, skillButtonDataByButton);
					}
				}
				IL_95:;
			}
		}

		// Token: 0x06030FA3 RID: 200611 RVA: 0x00DAAD56 File Offset: 0x00DA8F56
		private void RefreshMainSkillItemBySkillButtonData(BattleSkillGamepadItem battleSkillItem, [Nullable(2)] SkillButtonData skillButtonData)
		{
			if (skillButtonData == null)
			{
				battleSkillItem.Refresh(null);
				return;
			}
			if (skillButtonData.GetSkillId() == 0 || !skillButtonData.IsVisible())
			{
				battleSkillItem.Refresh(null);
				return;
			}
			battleSkillItem.Refresh(skillButtonData);
		}

		// Token: 0x06030FA4 RID: 200612 RVA: 0x00DAAD84 File Offset: 0x00DA8F84
		private void RefreshDpadMiddleItem()
		{
			bool existDpadSkillItem = this.ExistDpadSkillItem;
			this.ExistDpadSkillItem = false;
			for (int i = 0; i < 4; i++)
			{
				if (this.BattleSkillItemList[i + 8].IsVisible())
				{
					this.DpadItem.SetArrowVisible(i, true);
					this.ExistDpadSkillItem = true;
				}
				else
				{
					this.DpadItem.SetArrowVisible(i, false);
				}
			}
			BattleSkillDpadItem dpadItem = this.DpadItem;
			if (dpadItem != null)
			{
				dpadItem.SetBgVisible(this.ExistDpadSkillItem);
			}
			if (existDpadSkillItem != this.ExistDpadSkillItem && this.DpadLevelSequencePlayer != null)
			{
				this.DpadLevelSequencePlayer.StopCurrentSequence(false, false);
				this.DpadLevelSequencePlayer.PlaySequencePurely(this.ExistDpadSkillItem ? "Show" : "Hide", false, false, null, null, false);
			}
		}

		// Token: 0x06030FA5 RID: 200613 RVA: 0x00DAAE44 File Offset: 0x00DA9044
		private void RefreshSubBattleSkillItems()
		{
			SkillButtonUiModel instance = SkillButtonUiModel.Instance;
			List<int?> curButtonTypeList = this.GamepadData.CurButtonTypeList;
			for (int i = 12; i < 16; i++)
			{
				BattleSkillGamepadItem battleSkillGamepadItem = this.BattleSkillItemList[i];
				if (i >= curButtonTypeList.Count)
				{
					battleSkillGamepadItem.Deactivate();
				}
				else
				{
					int? num = curButtonTypeList[i];
					if (num == null)
					{
						battleSkillGamepadItem.Deactivate();
					}
					else
					{
						SkillButtonData skillButtonDataByButton = instance.GetSkillButtonDataByButton((ESkillButtonType)num.Value);
						if (skillButtonDataByButton == null)
						{
							BehaviorButtonData behaviorButtonDataByButton = instance.GetBehaviorButtonDataByButton((EBehaviorType)num.Value);
							if (behaviorButtonDataByButton != null)
							{
								battleSkillGamepadItem.RefreshByBehaviorButtonData(behaviorButtonDataByButton);
							}
							else
							{
								battleSkillGamepadItem.Deactivate();
							}
						}
						else if (skillButtonDataByButton.GetSkillId() == 0)
						{
							battleSkillGamepadItem.Deactivate();
						}
						else
						{
							battleSkillGamepadItem.Refresh(skillButtonDataByButton);
						}
					}
				}
			}
		}

		// Token: 0x06030FA6 RID: 200614 RVA: 0x00DAAF00 File Offset: 0x00DA9100
		private void DeactivateAllBattleSkillItems()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.Deactivate();
			}
		}

		// Token: 0x06030FA7 RID: 200615 RVA: 0x00DAAF50 File Offset: 0x00DA9150
		public UniTask NewAllBattleSkillItems()
		{
			GamepadSkillButtonPanel.<NewAllBattleSkillItems>d__36 <NewAllBattleSkillItems>d__;
			<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBattleSkillItems>d__.<>4__this = this;
			<NewAllBattleSkillItems>d__.<>1__state = -1;
			<NewAllBattleSkillItems>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewAllBattleSkillItems>d__36>(ref <NewAllBattleSkillItems>d__);
			return <NewAllBattleSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x06030FA8 RID: 200616 RVA: 0x00DAAF94 File Offset: 0x00DA9194
		private UniTask NewCombineItem()
		{
			GamepadSkillButtonPanel.<NewCombineItem>d__37 <NewCombineItem>d__;
			<NewCombineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewCombineItem>d__.<>4__this = this;
			<NewCombineItem>d__.<>1__state = -1;
			<NewCombineItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewCombineItem>d__37>(ref <NewCombineItem>d__);
			return <NewCombineItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030FA9 RID: 200617 RVA: 0x00DAAFD8 File Offset: 0x00DA91D8
		private UniTask NewDpadItem()
		{
			GamepadSkillButtonPanel.<NewDpadItem>d__38 <NewDpadItem>d__;
			<NewDpadItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDpadItem>d__.<>4__this = this;
			<NewDpadItem>d__.<>1__state = -1;
			<NewDpadItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewDpadItem>d__38>(ref <NewDpadItem>d__);
			return <NewDpadItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030FAA RID: 200618 RVA: 0x00DAB01C File Offset: 0x00DA921C
		private UniTask NewRouletteItem()
		{
			GamepadSkillButtonPanel.<NewRouletteItem>d__39 <NewRouletteItem>d__;
			<NewRouletteItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRouletteItem>d__.<>4__this = this;
			<NewRouletteItem>d__.<>1__state = -1;
			<NewRouletteItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewRouletteItem>d__39>(ref <NewRouletteItem>d__);
			return <NewRouletteItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030FAB RID: 200619 RVA: 0x00DAB060 File Offset: 0x00DA9260
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<BattleSkillGamepadItem> NewBattleSkillItem(AActor rootActor, int inputIndex)
		{
			GamepadSkillButtonPanel.<NewBattleSkillItem>d__40 <NewBattleSkillItem>d__;
			<NewBattleSkillItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<BattleSkillGamepadItem>.Create();
			<NewBattleSkillItem>d__.<>4__this = this;
			<NewBattleSkillItem>d__.rootActor = rootActor;
			<NewBattleSkillItem>d__.inputIndex = inputIndex;
			<NewBattleSkillItem>d__.<>1__state = -1;
			<NewBattleSkillItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewBattleSkillItem>d__40>(ref <NewBattleSkillItem>d__);
			return <NewBattleSkillItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030FAC RID: 200620 RVA: 0x00DAB0B3 File Offset: 0x00DA92B3
		[NullableContext(2)]
		private BattleSkillGamepadItem GetBattleSkillItem(int inputIndex)
		{
			if (inputIndex < 0 || inputIndex >= this.BattleSkillItemList.Count)
			{
				return null;
			}
			return this.BattleSkillItemList[inputIndex];
		}

		// Token: 0x06030FAD RID: 200621 RVA: 0x00DAB0D8 File Offset: 0x00DA92D8
		[NullableContext(2)]
		public BattleSkillGamepadItem GetBattleSkillItemByButtonType(int buttonType)
		{
			int num = SkillButtonUiModel.Instance.GamepadData.CurButtonTypeList.IndexOf(new int?(buttonType));
			if (num < 0)
			{
				return null;
			}
			return this.GetBattleSkillItem(num);
		}

		// Token: 0x06030FAE RID: 200622 RVA: 0x00DAB10D File Offset: 0x00DA930D
		[NullableContext(2)]
		private BattleSkillGamepadItem GetSwitchBattleSkillItemByButtonType(int buttonType)
		{
			if (buttonType != 7)
			{
				return null;
			}
			SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
			if (gamepadData == null || !gamepadData.SwitchInteractData.IsSwitchInteractOpen)
			{
				return null;
			}
			return this.GetBattleSkillItemByButtonType(104);
		}

		// Token: 0x06030FAF RID: 200623 RVA: 0x00DAB13B File Offset: 0x00DA933B
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			this.RefreshAllBattleSkillItems();
		}

		// Token: 0x06030FB0 RID: 200624 RVA: 0x00DAB143 File Offset: 0x00DA9343
		private void OnSkillButtonDataClear()
		{
			this.DeactivateAllBattleSkillItems();
		}

		// Token: 0x06030FB1 RID: 200625 RVA: 0x00DAB14B File Offset: 0x00DA934B
		private void OnSkillButtonIndexRefresh()
		{
			if (this.GamepadData.RefreshButtonData())
			{
				this.RefreshAllBattleSkillItems();
			}
		}

		// Token: 0x06030FB2 RID: 200626 RVA: 0x00DAB160 File Offset: 0x00DA9360
		private void OnSkillButtonEnableRefresh(ESkillButtonType buttonType, int extendCoolDown)
		{
			if (!this.Visible)
			{
				return;
			}
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshEnable(false);
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshEnable(false);
			}
		}

		// Token: 0x06030FB3 RID: 200627 RVA: 0x00DAB1B0 File Offset: 0x00DA93B0
		private void OnSkillButtonVisibleRefresh(ESkillButtonType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				this.GamepadData.RefreshButtonData();
				this.RefreshAllBattleSkillItems();
				return;
			}
			SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(buttonType);
			if (skillButtonDataByButton != null)
			{
				this.RefreshMainSkillItemBySkillButtonData(battleSkillItemByButtonType, skillButtonDataByButton);
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (switchBattleSkillItemByButtonType != null)
			{
				if (switchBattleSkillItemByButtonType.SrcBehaviorButtonData != null)
				{
					switchBattleSkillItemByButtonType.RefreshByBehaviorButtonData(switchBattleSkillItemByButtonType.SrcBehaviorButtonData);
					return;
				}
				if (switchBattleSkillItemByButtonType.BehaviorButtonData != null)
				{
					switchBattleSkillItemByButtonType.RefreshByBehaviorButtonData(switchBattleSkillItemByButtonType.BehaviorButtonData);
				}
			}
		}

		// Token: 0x06030FB4 RID: 200628 RVA: 0x00DAB228 File Offset: 0x00DA9428
		private void OnSkillButtonDynamicEffectRefresh(ESkillButtonType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshDynamicEffect();
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshDynamicEffect();
			}
		}

		// Token: 0x06030FB5 RID: 200629 RVA: 0x00DAB270 File Offset: 0x00DA9470
		private void OnSkillButtonCustomRefresh(ESkillButtonType buttonType, int from = -1, int param = 0)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				battleSkillItemByButtonType.RefreshCustomHdData(from, param);
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshCustomHdData(from, param);
			}
		}

		// Token: 0x06030FB6 RID: 200630 RVA: 0x00DAB2BC File Offset: 0x00DA94BC
		private void OnSkillButtonSkillIdRefresh(ESkillButtonType buttonType)
		{
			SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(buttonType);
			if (skillButtonDataByButton == null)
			{
				return;
			}
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType != null)
			{
				battleSkillItemByButtonType.Refresh(skillButtonDataByButton);
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.SrcBehaviorButtonData : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshByBehaviorButtonData(switchBattleSkillItemByButtonType.SrcBehaviorButtonData);
				return;
			}
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.BehaviorButtonData : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshByBehaviorButtonData(switchBattleSkillItemByButtonType.BehaviorButtonData);
			}
		}

		// Token: 0x06030FB7 RID: 200631 RVA: 0x00DAB328 File Offset: 0x00DA9528
		private void OnSkillButtonAttributeRefresh(ESkillButtonType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType != null)
			{
				battleSkillItemByButtonType.RefreshAttribute(true);
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshAttribute(true);
			}
		}

		// Token: 0x06030FB8 RID: 200632 RVA: 0x00DAB364 File Offset: 0x00DA9564
		private void OnSkillButtonIconPathRefresh(ESkillButtonType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType != null)
			{
				battleSkillItemByButtonType.RefreshSkillIcon();
				battleSkillItemByButtonType.RefreshSkillName();
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshSkillIcon();
				switchBattleSkillItemByButtonType.RefreshSkillName();
			}
		}

		// Token: 0x06030FB9 RID: 200633 RVA: 0x00DAB3AC File Offset: 0x00DA95AC
		private void OnSkillButtonCdRefresh(ESkillButtonType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType != null)
			{
				battleSkillItemByButtonType.RefreshSkillCoolDown();
			}
			BattleSkillGamepadItem switchBattleSkillItemByButtonType = this.GetSwitchBattleSkillItemByButtonType((int)buttonType);
			if (((switchBattleSkillItemByButtonType != null) ? switchBattleSkillItemByButtonType.GetSkillButtonData() : null) != null)
			{
				switchBattleSkillItemByButtonType.RefreshSkillCoolDown();
			}
		}

		// Token: 0x06030FBA RID: 200634 RVA: 0x00DAB3E8 File Offset: 0x00DA95E8
		private void OnPauseGame(int flag)
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.PauseGame(flag);
			}
		}

		// Token: 0x06030FBB RID: 200635 RVA: 0x00DAB43C File Offset: 0x00DA963C
		private void OnBehaviorButtonEnableRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshEnable(false);
		}

		// Token: 0x06030FBC RID: 200636 RVA: 0x00DAB450 File Offset: 0x00DA9650
		private void OnBehaviorButtonVisibleRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshVisible();
		}

		// Token: 0x06030FBD RID: 200637 RVA: 0x00DAB464 File Offset: 0x00DA9664
		private void OnBehaviorButtonSkillIdRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.BehaviorButtonData : null) != null)
			{
				battleSkillItemByButtonType.RefreshByBehaviorButtonData(battleSkillItemByButtonType.BehaviorButtonData);
			}
		}

		// Token: 0x06030FBE RID: 200638 RVA: 0x00DAB493 File Offset: 0x00DA9693
		private void OnBehaviorButtonIconPathRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillIcon();
		}

		// Token: 0x06030FBF RID: 200639 RVA: 0x00DAB4A6 File Offset: 0x00DA96A6
		private void OnBehaviorButtonDynamicEffectRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshDynamicEffect();
		}

		// Token: 0x06030FC0 RID: 200640 RVA: 0x00DAB4BC File Offset: 0x00DA96BC
		private void OnChangedTimeScale()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.RefreshTimeDilation();
			}
		}

		// Token: 0x06030FC1 RID: 200641 RVA: 0x00DAB50C File Offset: 0x00DA970C
		private void OnCharSkillCdPauseStateChanged(bool b)
		{
			this.OnChangedTimeScale();
		}

		// Token: 0x06030FC2 RID: 200642 RVA: 0x00DAB514 File Offset: 0x00DA9714
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			if (Info.Instance.IsInGamepad())
			{
				base.SetVisible(EBattleUiVisibleReason.Gamepad, true);
				this.RefreshAllBattleSkillItems();
				return;
			}
			base.SetVisible(EBattleUiVisibleReason.Gamepad, false);
			SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
			if (gamepadData == null)
			{
				return;
			}
			gamepadData.ClearInputAxis();
		}

		// Token: 0x06030FC3 RID: 200643 RVA: 0x00DAB549 File Offset: 0x00DA9749
		private void OnInputCombineButton(bool isPress)
		{
			this.RefreshAllBattleSkillItems();
			this.RefreshCombineItem();
			this.PlayCombineItemAnim(isPress);
			this.RefreshRouletteItem();
		}

		// Token: 0x06030FC4 RID: 200644 RVA: 0x00DAB564 File Offset: 0x00DA9764
		private void OnInputMotorcycleCombineButton(bool isPress)
		{
			this.RefreshAllBattleSkillItems();
			this.RefreshCombineItem();
			this.PlayCombineItemAnim(isPress);
			this.RefreshRouletteItem();
			this.RefreshDpadKeyItemEnable();
		}

		// Token: 0x06030FC5 RID: 200645 RVA: 0x00DAB585 File Offset: 0x00DA9785
		private void RefreshCombineItem()
		{
			BattleSkillCombineItem combineItem = this.CombineItem;
			if (combineItem == null)
			{
				return;
			}
			combineItem.SetVisible(!this.GamepadData.GetIsPressCombineButton());
		}

		// Token: 0x06030FC6 RID: 200646 RVA: 0x00DAB5A5 File Offset: 0x00DA97A5
		private void RefreshRouletteItem()
		{
			BattleSkillRouletteItem rouletteItem = this.RouletteItem;
			if (rouletteItem == null)
			{
				return;
			}
			rouletteItem.RefreshVisible();
		}

		// Token: 0x06030FC7 RID: 200647 RVA: 0x00DAB5B8 File Offset: 0x00DA97B8
		private void PlayCombineItemAnim(bool isPress)
		{
			if (isPress)
			{
				for (int i = 0; i < 4; i++)
				{
					if (this.GamepadData.MainSkillCombineButtonTypeList[i] != 0)
					{
						this.BattleSkillItemList[i].PlayPressCombineButtonSeq();
					}
				}
				for (int j = 8; j < 12; j++)
				{
					int num = (j >= this.GamepadData.DpadSkillCombineButtonTypeList.Length) ? 0 : this.GamepadData.DpadSkillCombineButtonTypeList[j];
					int num2 = (j >= this.GamepadData.DpadSkillButtonTypeList.Length) ? 0 : this.GamepadData.DpadSkillButtonTypeList[j];
					if (num != num2)
					{
						BattleSkillGamepadItem battleSkillGamepadItem = (j < this.BattleSkillItemList.Count) ? this.BattleSkillItemList[j] : null;
						if (battleSkillGamepadItem != null)
						{
							battleSkillGamepadItem.PlayPressCombineButtonSeq();
						}
					}
				}
				this.TweenAnimPlayer.StopTweenAnim(21);
				this.TweenAnimPlayer.PlayTweenAnim(22);
				return;
			}
			for (int k = 0; k < 4; k++)
			{
				this.BattleSkillItemList[k].PlayReleaseCombineButtonSeq();
			}
			this.TweenAnimPlayer.StopTweenAnim(22);
			this.TweenAnimPlayer.PlayTweenAnim(21);
		}

		// Token: 0x06030FC8 RID: 200648 RVA: 0x00DAB6C6 File Offset: 0x00DA98C6
		private void OnChatScrollViewVisibleChanged()
		{
			this.RefreshDpadPosition();
		}

		// Token: 0x06030FC9 RID: 200649 RVA: 0x00DAB6CE File Offset: 0x00DA98CE
		private void RefreshDpadPosition()
		{
			if (BattleUiModel.Instance.ChatScrollViewVisible)
			{
				UUIItem item = base.GetItem(10);
				if (item == null)
				{
					return;
				}
				item.SetAnchorOffsetX(593f);
				return;
			}
			else
			{
				UUIItem item2 = base.GetItem(10);
				if (item2 == null)
				{
					return;
				}
				item2.SetAnchorOffsetX(393f);
				return;
			}
		}

		// Token: 0x06030FCA RID: 200650 RVA: 0x00DAB70C File Offset: 0x00DA990C
		private void OnSwitchInteractStateChanged()
		{
			EGamepadSwitchInteractState state = this.GamepadData.SwitchInteractData.State;
			if (state == EGamepadSwitchInteractState.Explore)
			{
				BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(104);
				if (battleSkillItemByButtonType != null && battleSkillItemByButtonType.BehaviorButtonData != null)
				{
					battleSkillItemByButtonType.RefreshByBehaviorButtonData(battleSkillItemByButtonType.BehaviorButtonData);
				}
				this.RefreshExploreSkillItem();
				return;
			}
			if (state == EGamepadSwitchInteractState.Interact)
			{
				BattleSkillGamepadItem battleSkillItemByButtonType2 = this.GetBattleSkillItemByButtonType(104);
				if (battleSkillItemByButtonType2 != null && battleSkillItemByButtonType2.SrcBehaviorButtonData != null)
				{
					battleSkillItemByButtonType2.RefreshByBehaviorButtonData(battleSkillItemByButtonType2.SrcBehaviorButtonData);
				}
				this.RefreshExploreSkillItem();
				return;
			}
			if (state == EGamepadSwitchInteractState.Switching)
			{
				BattleSkillGamepadItem battleSkillItemByButtonType3 = this.GetBattleSkillItemByButtonType(104);
				if (battleSkillItemByButtonType3 == null)
				{
					return;
				}
				battleSkillItemByButtonType3.PlaySwitchCd();
			}
		}

		// Token: 0x06030FCB RID: 200651 RVA: 0x00DAB798 File Offset: 0x00DA9998
		private void RefreshExploreSkillItem()
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(7);
			if (battleSkillItemByButtonType != null && battleSkillItemByButtonType.IsSecondButton)
			{
				SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(ESkillButtonType.幻象1);
				this.RefreshMainSkillItemBySkillButtonData(battleSkillItemByButtonType, skillButtonDataByButton);
			}
		}

		// Token: 0x06030FCC RID: 200652 RVA: 0x00DAB7CC File Offset: 0x00DA99CC
		private void OnGamepadDataChanged()
		{
			InputDistributeController.Instance.UnBindActions(this.GamepadData.GetAllActionNameList(), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.UnBindAxes(this.GamepadData.GetAllAxisNameList(), new TInputHandle<float>(this.OnInputAxis));
			if (this.GamepadData.GamepadDataType == ESkillButtonGamepadDataType.Motorcycle)
			{
				EventSystem.Instance.Remove(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputMotorcycleCombineButton));
			}
			else
			{
				EventSystem.Instance.Remove(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
			}
			this.GamepadData = SkillButtonUiModel.Instance.GamepadData;
			this.RefreshGamepadData();
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.GamepadData = this.GamepadData;
			}
			this.RefreshDpadKeyItemEnable();
			this.AxisInputCacheMap.Clear();
			InputDistributeController.Instance.BindActions(this.GamepadData.GetAllActionNameList(), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			InputDistributeController.Instance.BindAxes(this.GamepadData.GetAllAxisNameList(), new TInputHandle<float>(this.OnInputAxis));
			if (this.GamepadData.GamepadDataType == ESkillButtonGamepadDataType.Motorcycle)
			{
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputMotorcycleCombineButton));
				return;
			}
			EventSystem.Instance.Add<bool>(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
		}

		// Token: 0x06030FCD RID: 200653 RVA: 0x00DAB95C File Offset: 0x00DA9B5C
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (this.GamepadData.GamepadDataType == ESkillButtonGamepadDataType.Normal)
			{
				if (actionName == "攻击")
				{
					return;
				}
				bool bForcePlayClickEffect = false;
				int buttonType;
				if (actionName == "手柄主攻击")
				{
					buttonType = 4;
				}
				else if (actionName == "手柄副攻击")
				{
					if (!this.GamepadData.IsAim())
					{
						return;
					}
					buttonType = 11;
					bForcePlayClickEffect = true;
				}
				else
				{
					buttonType = this.GamepadData.GetButtonTypeByActionName(actionName);
				}
				BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonType);
				if (battleSkillItemByButtonType == null)
				{
					return;
				}
				battleSkillItemByButtonType.OnInputAction(bForcePlayClickEffect);
				return;
			}
			else
			{
				int buttonTypeByActionName = this.GamepadData.GetButtonTypeByActionName(actionName);
				BattleSkillGamepadItem battleSkillItemByButtonType2 = this.GetBattleSkillItemByButtonType(buttonTypeByActionName);
				if (battleSkillItemByButtonType2 == null)
				{
					return;
				}
				battleSkillItemByButtonType2.OnInputAction(false);
				return;
			}
		}

		// Token: 0x06030FCE RID: 200654 RVA: 0x00DAB9FC File Offset: 0x00DA9BFC
		private void OnInputAxis(string axisName, float value, InputIdentification inputIdentification)
		{
			if (value == 0f)
			{
				this.AxisInputCacheMap[axisName] = value;
				return;
			}
			float valueOrDefault = this.AxisInputCacheMap.GetValueOrDefault(axisName, 0f);
			if (valueOrDefault > 0f && value > 0f)
			{
				return;
			}
			if (valueOrDefault < 0f && value < 0f)
			{
				return;
			}
			this.AxisInputCacheMap[axisName] = value;
			int buttonTypeByAxisName = this.GamepadData.GetButtonTypeByAxisName(axisName, value);
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(buttonTypeByAxisName);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.OnInputAction(false);
		}

		// Token: 0x06030FCF RID: 200655 RVA: 0x00DABA80 File Offset: 0x00DA9C80
		private void OnInputMoveForward(string axisName, float value, InputIdentification inputIdentification)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.GamepadData.CacheInputAxis(EInputAxis.MoveForward, value);
			}
		}

		// Token: 0x06030FD0 RID: 200656 RVA: 0x00DABA9F File Offset: 0x00DA9C9F
		private void OnInputMoveRight(string axisName, float value, InputIdentification inputIdentification)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.GamepadData.CacheInputAxis(EInputAxis.MoveRight, value);
			}
		}

		// Token: 0x06030FD1 RID: 200657 RVA: 0x00DABABE File Offset: 0x00DA9CBE
		private void OnViewDone(EUiViewName viewName, UiViewBase uiViewBase)
		{
			if (viewName != EUiViewName.InteractionHintView)
			{
				return;
			}
			this.RefreshInteractButton();
		}

		// Token: 0x06030FD2 RID: 200658 RVA: 0x00DABAD4 File Offset: 0x00DA9CD4
		private void OnCloseView(EUiViewName viewName, int i)
		{
			if (viewName != EUiViewName.InteractionHintView)
			{
				return;
			}
			this.RefreshInteractButton();
		}

		// Token: 0x06030FD3 RID: 200659 RVA: 0x00DABAEC File Offset: 0x00DA9CEC
		private void RefreshInteractButton()
		{
			this.GamepadData.RefreshInteractBehaviorData();
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(104);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			if (!battleSkillItemByButtonType.IsMainButton)
			{
				battleSkillItemByButtonType.RefreshVisible();
			}
			battleSkillItemByButtonType.RefreshEnable(false);
		}

		// Token: 0x06030FD4 RID: 200660 RVA: 0x00DABB28 File Offset: 0x00DA9D28
		private void InitLevelSequencePlayer()
		{
			this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			this.TweenAnimPlayer.InitTweenAnim(21, base.GetItem(21), false);
			this.TweenAnimPlayer.InitTweenAnim(22, base.GetItem(22), false);
			this.DpadLevelSequencePlayer = new LevelSequencePlayer(base.GetItem(10));
		}

		// Token: 0x06030FD5 RID: 200661 RVA: 0x00DABB80 File Offset: 0x00DA9D80
		public void RefreshDpadKeyItemEnable()
		{
			SkillButtonUiGamepadDataBase gamepadData = this.GamepadData;
			if (gamepadData == null || gamepadData.GamepadDataType != ESkillButtonGamepadDataType.Motorcycle)
			{
				for (int i = 0; i < 4; i++)
				{
					this.DpadItem.SetArrowEnable(i, true, false);
				}
				return;
			}
			SkillButtonUiMotorcycleGamepadData skillButtonUiMotorcycleGamepadData = this.GamepadData as SkillButtonUiMotorcycleGamepadData;
			if (skillButtonUiMotorcycleGamepadData != null && skillButtonUiMotorcycleGamepadData.GetIsPressCombineButton())
			{
				for (int j = 0; j < 4; j++)
				{
					string item = skillButtonUiMotorcycleGamepadData.ButtonKeyList[j + 4];
					if (skillButtonUiMotorcycleGamepadData.MusicSubKeyList.Contains(item))
					{
						this.DpadItem.SetArrowEnable(j, false, false);
					}
					else
					{
						this.DpadItem.SetArrowEnable(j, true, false);
					}
				}
				return;
			}
			for (int k = 0; k < 4; k++)
			{
				this.DpadItem.SetArrowEnable(k, true, false);
			}
		}

		// Token: 0x04019FAF RID: 106415
		private const int MAIN_KEY_NUM = 8;

		// Token: 0x04019FB0 RID: 106416
		private const int MAIN_HALF_NUM = 4;

		// Token: 0x04019FB1 RID: 106417
		private const int LEFT_KEY_NUM = 4;

		// Token: 0x04019FB2 RID: 106418
		private const int SUB_KEY_NUM = 4;

		// Token: 0x04019FB3 RID: 106419
		private const int LEFT_KEY_START_INDEX = 8;

		// Token: 0x04019FB4 RID: 106420
		private const int SUB_KEY_START_INDEX = 12;

		// Token: 0x04019FB5 RID: 106421
		private const int SUB_KEY_END_INDEX = 16;

		// Token: 0x04019FB6 RID: 106422
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshAllBattleSkillItemObject = Stat.Create("[GamepadSkillButton]RefreshAllBattleSkillItem", "", "");

		// Token: 0x04019FB7 RID: 106423
		[StaticVariableRuleIgnore]
		private static readonly Stat OnInputCombineButtonObject = Stat.Create("[GamepadSkillButton]OnInputCombineButton", "", "");

		// Token: 0x04019FB8 RID: 106424
		[Nullable(2)]
		private BattleSkillCombineItem CombineItem;

		// Token: 0x04019FB9 RID: 106425
		[Nullable(2)]
		private BattleSkillDpadItem DpadItem;

		// Token: 0x04019FBA RID: 106426
		private readonly List<BattleSkillGamepadItem> BattleSkillItemList = new List<BattleSkillGamepadItem>();

		// Token: 0x04019FBB RID: 106427
		[Nullable(2)]
		private BattleSkillRouletteItem RouletteItem;

		// Token: 0x04019FBC RID: 106428
		[Nullable(2)]
		private BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x04019FBD RID: 106429
		[Nullable(2)]
		private LevelSequencePlayer DpadLevelSequencePlayer;

		// Token: 0x04019FBE RID: 106430
		private bool ExistDpadSkillItem;

		// Token: 0x04019FBF RID: 106431
		[Nullable(2)]
		private SkillButtonUiGamepadDataBase GamepadData;

		// Token: 0x04019FC0 RID: 106432
		private readonly Dictionary<string, float> AxisInputCacheMap = new Dictionary<string, float>();

		// Token: 0x0200A8BB RID: 43195
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040341EC RID: 213484
			SkillItemY,
			// Token: 0x040341ED RID: 213485
			SkillItemX,
			// Token: 0x040341EE RID: 213486
			SkillItemA,
			// Token: 0x040341EF RID: 213487
			SkillItemB,
			// Token: 0x040341F0 RID: 213488
			SkillItemSecondContainer,
			// Token: 0x040341F1 RID: 213489
			SkillItemSecondY,
			// Token: 0x040341F2 RID: 213490
			SkillItemSecondX,
			// Token: 0x040341F3 RID: 213491
			SkillItemSecondA,
			// Token: 0x040341F4 RID: 213492
			SkillItemSecondB,
			// Token: 0x040341F5 RID: 213493
			CombineItem,
			// Token: 0x040341F6 RID: 213494
			SkillItemDPadContainer,
			// Token: 0x040341F7 RID: 213495
			SkillItemUp,
			// Token: 0x040341F8 RID: 213496
			SkillItemLeft,
			// Token: 0x040341F9 RID: 213497
			SkillItemDown,
			// Token: 0x040341FA RID: 213498
			SkillItemRight,
			// Token: 0x040341FB RID: 213499
			DPadItem,
			// Token: 0x040341FC RID: 213500
			SkillItemSub1,
			// Token: 0x040341FD RID: 213501
			SkillItemSub2,
			// Token: 0x040341FE RID: 213502
			SkillItemSub3,
			// Token: 0x040341FF RID: 213503
			SkillItemSub4,
			// Token: 0x04034200 RID: 213504
			RouletteItem,
			// Token: 0x04034201 RID: 213505
			SecondShow,
			// Token: 0x04034202 RID: 213506
			SecondHide
		}
	}
}
