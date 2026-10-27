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
	// Token: 0x02005CBD RID: 23741
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadSkillButtonPanel : BattleChildViewPanel
	{
		// Token: 0x0603C042 RID: 245826 RVA: 0x00E5990C File Offset: 0x00E57B0C
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

		// Token: 0x0603C043 RID: 245827 RVA: 0x00E59C39 File Offset: 0x00E57E39
		public override void InitializeTemp()
		{
			this.GamepadData = SkillButtonUiModel.Instance.GamepadData;
		}

		// Token: 0x0603C044 RID: 245828 RVA: 0x00E59C4C File Offset: 0x00E57E4C
		public override UniTask InitializeAsync()
		{
			GamepadSkillButtonPanel.<InitializeAsync>d__21 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<GamepadSkillButtonPanel.<InitializeAsync>d__21>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603C045 RID: 245829 RVA: 0x00E59C90 File Offset: 0x00E57E90
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

		// Token: 0x0603C046 RID: 245830 RVA: 0x00E59CF0 File Offset: 0x00E57EF0
		protected override void OnAfterShow()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.RefreshEnable(true);
			}
		}

		// Token: 0x0603C047 RID: 245831 RVA: 0x00E59D44 File Offset: 0x00E57F44
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.RefreshSkillCoolDownOnShow();
			}
		}

		// Token: 0x0603C048 RID: 245832 RVA: 0x00E59D94 File Offset: 0x00E57F94
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

		// Token: 0x0603C049 RID: 245833 RVA: 0x00E59DF0 File Offset: 0x00E57FF0
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

		// Token: 0x0603C04A RID: 245834 RVA: 0x00E5A170 File Offset: 0x00E58370
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

		// Token: 0x0603C04B RID: 245835 RVA: 0x00E5A4EC File Offset: 0x00E586EC
		private void RefreshGamepadData()
		{
			base.SetVisible(EBattleUiVisibleReason.Gamepad, Info.Instance.IsInGamepad());
			this.GamepadData.RefreshInteractBehaviorData();
			this.GamepadData.RefreshAimState();
		}

		// Token: 0x0603C04C RID: 245836 RVA: 0x00E5A518 File Offset: 0x00E58718
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

		// Token: 0x0603C04D RID: 245837 RVA: 0x00E5A58C File Offset: 0x00E5878C
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

		// Token: 0x0603C04E RID: 245838 RVA: 0x00E5A5C0 File Offset: 0x00E587C0
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

		// Token: 0x0603C04F RID: 245839 RVA: 0x00E5A66E File Offset: 0x00E5886E
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

		// Token: 0x0603C050 RID: 245840 RVA: 0x00E5A69C File Offset: 0x00E5889C
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

		// Token: 0x0603C051 RID: 245841 RVA: 0x00E5A75C File Offset: 0x00E5895C
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

		// Token: 0x0603C052 RID: 245842 RVA: 0x00E5A818 File Offset: 0x00E58A18
		private void DeactivateAllBattleSkillItems()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.Deactivate();
			}
		}

		// Token: 0x0603C053 RID: 245843 RVA: 0x00E5A868 File Offset: 0x00E58A68
		public UniTask NewAllBattleSkillItems()
		{
			GamepadSkillButtonPanel.<NewAllBattleSkillItems>d__36 <NewAllBattleSkillItems>d__;
			<NewAllBattleSkillItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewAllBattleSkillItems>d__.<>4__this = this;
			<NewAllBattleSkillItems>d__.<>1__state = -1;
			<NewAllBattleSkillItems>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewAllBattleSkillItems>d__36>(ref <NewAllBattleSkillItems>d__);
			return <NewAllBattleSkillItems>d__.<>t__builder.Task;
		}

		// Token: 0x0603C054 RID: 245844 RVA: 0x00E5A8AC File Offset: 0x00E58AAC
		private UniTask NewCombineItem()
		{
			GamepadSkillButtonPanel.<NewCombineItem>d__37 <NewCombineItem>d__;
			<NewCombineItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewCombineItem>d__.<>4__this = this;
			<NewCombineItem>d__.<>1__state = -1;
			<NewCombineItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewCombineItem>d__37>(ref <NewCombineItem>d__);
			return <NewCombineItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C055 RID: 245845 RVA: 0x00E5A8F0 File Offset: 0x00E58AF0
		private UniTask NewDpadItem()
		{
			GamepadSkillButtonPanel.<NewDpadItem>d__38 <NewDpadItem>d__;
			<NewDpadItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewDpadItem>d__.<>4__this = this;
			<NewDpadItem>d__.<>1__state = -1;
			<NewDpadItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewDpadItem>d__38>(ref <NewDpadItem>d__);
			return <NewDpadItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C056 RID: 245846 RVA: 0x00E5A934 File Offset: 0x00E58B34
		private UniTask NewRouletteItem()
		{
			GamepadSkillButtonPanel.<NewRouletteItem>d__39 <NewRouletteItem>d__;
			<NewRouletteItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRouletteItem>d__.<>4__this = this;
			<NewRouletteItem>d__.<>1__state = -1;
			<NewRouletteItem>d__.<>t__builder.Start<GamepadSkillButtonPanel.<NewRouletteItem>d__39>(ref <NewRouletteItem>d__);
			return <NewRouletteItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603C057 RID: 245847 RVA: 0x00E5A978 File Offset: 0x00E58B78
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

		// Token: 0x0603C058 RID: 245848 RVA: 0x00E5A9CB File Offset: 0x00E58BCB
		[NullableContext(2)]
		private BattleSkillGamepadItem GetBattleSkillItem(int inputIndex)
		{
			if (inputIndex < 0 || inputIndex >= this.BattleSkillItemList.Count)
			{
				return null;
			}
			return this.BattleSkillItemList[inputIndex];
		}

		// Token: 0x0603C059 RID: 245849 RVA: 0x00E5A9F0 File Offset: 0x00E58BF0
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

		// Token: 0x0603C05A RID: 245850 RVA: 0x00E5AA25 File Offset: 0x00E58C25
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

		// Token: 0x0603C05B RID: 245851 RVA: 0x00E5AA53 File Offset: 0x00E58C53
		private void OnSkillButtonDataRefresh(ESkillButtonRefreshReason refreshReason)
		{
			this.RefreshAllBattleSkillItems();
		}

		// Token: 0x0603C05C RID: 245852 RVA: 0x00E5AA5B File Offset: 0x00E58C5B
		private void OnSkillButtonDataClear()
		{
			this.DeactivateAllBattleSkillItems();
		}

		// Token: 0x0603C05D RID: 245853 RVA: 0x00E5AA63 File Offset: 0x00E58C63
		private void OnSkillButtonIndexRefresh()
		{
			if (this.GamepadData.RefreshButtonData())
			{
				this.RefreshAllBattleSkillItems();
			}
		}

		// Token: 0x0603C05E RID: 245854 RVA: 0x00E5AA78 File Offset: 0x00E58C78
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

		// Token: 0x0603C05F RID: 245855 RVA: 0x00E5AAC8 File Offset: 0x00E58CC8
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

		// Token: 0x0603C060 RID: 245856 RVA: 0x00E5AB40 File Offset: 0x00E58D40
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

		// Token: 0x0603C061 RID: 245857 RVA: 0x00E5AB88 File Offset: 0x00E58D88
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

		// Token: 0x0603C062 RID: 245858 RVA: 0x00E5ABD4 File Offset: 0x00E58DD4
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

		// Token: 0x0603C063 RID: 245859 RVA: 0x00E5AC40 File Offset: 0x00E58E40
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

		// Token: 0x0603C064 RID: 245860 RVA: 0x00E5AC7C File Offset: 0x00E58E7C
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

		// Token: 0x0603C065 RID: 245861 RVA: 0x00E5ACC4 File Offset: 0x00E58EC4
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

		// Token: 0x0603C066 RID: 245862 RVA: 0x00E5AD00 File Offset: 0x00E58F00
		private void OnPauseGame(int flag)
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.PauseGame(flag);
			}
		}

		// Token: 0x0603C067 RID: 245863 RVA: 0x00E5AD54 File Offset: 0x00E58F54
		private void OnBehaviorButtonEnableRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshEnable(false);
		}

		// Token: 0x0603C068 RID: 245864 RVA: 0x00E5AD68 File Offset: 0x00E58F68
		private void OnBehaviorButtonVisibleRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshVisible();
		}

		// Token: 0x0603C069 RID: 245865 RVA: 0x00E5AD7C File Offset: 0x00E58F7C
		private void OnBehaviorButtonSkillIdRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (((battleSkillItemByButtonType != null) ? battleSkillItemByButtonType.BehaviorButtonData : null) != null)
			{
				battleSkillItemByButtonType.RefreshByBehaviorButtonData(battleSkillItemByButtonType.BehaviorButtonData);
			}
		}

		// Token: 0x0603C06A RID: 245866 RVA: 0x00E5ADAB File Offset: 0x00E58FAB
		private void OnBehaviorButtonIconPathRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshSkillIcon();
		}

		// Token: 0x0603C06B RID: 245867 RVA: 0x00E5ADBE File Offset: 0x00E58FBE
		private void OnBehaviorButtonDynamicEffectRefresh(EBehaviorType buttonType)
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType((int)buttonType);
			if (battleSkillItemByButtonType == null)
			{
				return;
			}
			battleSkillItemByButtonType.RefreshDynamicEffect();
		}

		// Token: 0x0603C06C RID: 245868 RVA: 0x00E5ADD4 File Offset: 0x00E58FD4
		private void OnChangedTimeScale()
		{
			foreach (BattleSkillGamepadItem battleSkillGamepadItem in this.BattleSkillItemList)
			{
				battleSkillGamepadItem.RefreshTimeDilation();
			}
		}

		// Token: 0x0603C06D RID: 245869 RVA: 0x00E5AE24 File Offset: 0x00E59024
		private void OnCharSkillCdPauseStateChanged(bool b)
		{
			this.OnChangedTimeScale();
		}

		// Token: 0x0603C06E RID: 245870 RVA: 0x00E5AE2C File Offset: 0x00E5902C
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

		// Token: 0x0603C06F RID: 245871 RVA: 0x00E5AE61 File Offset: 0x00E59061
		private void OnInputCombineButton(bool isPress)
		{
			this.RefreshAllBattleSkillItems();
			this.RefreshCombineItem();
			this.PlayCombineItemAnim(isPress);
			this.RefreshRouletteItem();
		}

		// Token: 0x0603C070 RID: 245872 RVA: 0x00E5AE7C File Offset: 0x00E5907C
		private void OnInputMotorcycleCombineButton(bool isPress)
		{
			this.RefreshAllBattleSkillItems();
			this.RefreshCombineItem();
			this.PlayCombineItemAnim(isPress);
			this.RefreshRouletteItem();
			this.RefreshDpadKeyItemEnable();
		}

		// Token: 0x0603C071 RID: 245873 RVA: 0x00E5AE9D File Offset: 0x00E5909D
		private void RefreshCombineItem()
		{
			BattleSkillCombineItem combineItem = this.CombineItem;
			if (combineItem == null)
			{
				return;
			}
			combineItem.SetVisible(!this.GamepadData.GetIsPressCombineButton());
		}

		// Token: 0x0603C072 RID: 245874 RVA: 0x00E5AEBD File Offset: 0x00E590BD
		private void RefreshRouletteItem()
		{
			BattleSkillRouletteItem rouletteItem = this.RouletteItem;
			if (rouletteItem == null)
			{
				return;
			}
			rouletteItem.RefreshVisible();
		}

		// Token: 0x0603C073 RID: 245875 RVA: 0x00E5AED0 File Offset: 0x00E590D0
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

		// Token: 0x0603C074 RID: 245876 RVA: 0x00E5AFDE File Offset: 0x00E591DE
		private void OnChatScrollViewVisibleChanged()
		{
			this.RefreshDpadPosition();
		}

		// Token: 0x0603C075 RID: 245877 RVA: 0x00E5AFE6 File Offset: 0x00E591E6
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

		// Token: 0x0603C076 RID: 245878 RVA: 0x00E5B024 File Offset: 0x00E59224
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

		// Token: 0x0603C077 RID: 245879 RVA: 0x00E5B0B0 File Offset: 0x00E592B0
		private void RefreshExploreSkillItem()
		{
			BattleSkillGamepadItem battleSkillItemByButtonType = this.GetBattleSkillItemByButtonType(7);
			if (battleSkillItemByButtonType != null && battleSkillItemByButtonType.IsSecondButton)
			{
				SkillButtonData skillButtonDataByButton = SkillButtonUiModel.Instance.GetSkillButtonDataByButton(ESkillButtonType.幻象1);
				this.RefreshMainSkillItemBySkillButtonData(battleSkillItemByButtonType, skillButtonDataByButton);
			}
		}

		// Token: 0x0603C078 RID: 245880 RVA: 0x00E5B0E4 File Offset: 0x00E592E4
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

		// Token: 0x0603C079 RID: 245881 RVA: 0x00E5B274 File Offset: 0x00E59474
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

		// Token: 0x0603C07A RID: 245882 RVA: 0x00E5B314 File Offset: 0x00E59514
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

		// Token: 0x0603C07B RID: 245883 RVA: 0x00E5B398 File Offset: 0x00E59598
		private void OnInputMoveForward(string axisName, float value, InputIdentification inputIdentification)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.GamepadData.CacheInputAxis(EInputAxis.MoveForward, value);
			}
		}

		// Token: 0x0603C07C RID: 245884 RVA: 0x00E5B3B7 File Offset: 0x00E595B7
		private void OnInputMoveRight(string axisName, float value, InputIdentification inputIdentification)
		{
			if (Info.Instance.IsInGamepad())
			{
				this.GamepadData.CacheInputAxis(EInputAxis.MoveRight, value);
			}
		}

		// Token: 0x0603C07D RID: 245885 RVA: 0x00E5B3D6 File Offset: 0x00E595D6
		private void OnViewDone(EUiViewName viewName, UiViewBase uiViewBase)
		{
			if (viewName != EUiViewName.InteractionHintView)
			{
				return;
			}
			this.RefreshInteractButton();
		}

		// Token: 0x0603C07E RID: 245886 RVA: 0x00E5B3EC File Offset: 0x00E595EC
		private void OnCloseView(EUiViewName viewName, int i)
		{
			if (viewName != EUiViewName.InteractionHintView)
			{
				return;
			}
			this.RefreshInteractButton();
		}

		// Token: 0x0603C07F RID: 245887 RVA: 0x00E5B404 File Offset: 0x00E59604
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

		// Token: 0x0603C080 RID: 245888 RVA: 0x00E5B440 File Offset: 0x00E59640
		private void InitLevelSequencePlayer()
		{
			this.TweenAnimPlayer = new BattleUiTweenAnimPlayer();
			this.TweenAnimPlayer.InitTweenAnim(21, base.GetItem(21), false);
			this.TweenAnimPlayer.InitTweenAnim(22, base.GetItem(22), false);
			this.DpadLevelSequencePlayer = new LevelSequencePlayer(base.GetItem(10));
		}

		// Token: 0x0603C081 RID: 245889 RVA: 0x00E5B498 File Offset: 0x00E59698
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

		// Token: 0x0401F4F6 RID: 128246
		private const int MAIN_KEY_NUM = 8;

		// Token: 0x0401F4F7 RID: 128247
		private const int MAIN_HALF_NUM = 4;

		// Token: 0x0401F4F8 RID: 128248
		private const int LEFT_KEY_NUM = 4;

		// Token: 0x0401F4F9 RID: 128249
		private const int SUB_KEY_NUM = 4;

		// Token: 0x0401F4FA RID: 128250
		private const int LEFT_KEY_START_INDEX = 8;

		// Token: 0x0401F4FB RID: 128251
		private const int SUB_KEY_START_INDEX = 12;

		// Token: 0x0401F4FC RID: 128252
		private const int SUB_KEY_END_INDEX = 16;

		// Token: 0x0401F4FD RID: 128253
		[StaticVariableRuleIgnore]
		private static readonly Stat RefreshAllBattleSkillItemObject = Stat.Create("[GamepadSkillButton]RefreshAllBattleSkillItem", "", "");

		// Token: 0x0401F4FE RID: 128254
		[StaticVariableRuleIgnore]
		private static readonly Stat OnInputCombineButtonObject = Stat.Create("[GamepadSkillButton]OnInputCombineButton", "", "");

		// Token: 0x0401F4FF RID: 128255
		[Nullable(2)]
		private BattleSkillCombineItem CombineItem;

		// Token: 0x0401F500 RID: 128256
		[Nullable(2)]
		private BattleSkillDpadItem DpadItem;

		// Token: 0x0401F501 RID: 128257
		private readonly List<BattleSkillGamepadItem> BattleSkillItemList = new List<BattleSkillGamepadItem>();

		// Token: 0x0401F502 RID: 128258
		[Nullable(2)]
		private BattleSkillRouletteItem RouletteItem;

		// Token: 0x0401F503 RID: 128259
		[Nullable(2)]
		private BattleUiTweenAnimPlayer TweenAnimPlayer;

		// Token: 0x0401F504 RID: 128260
		[Nullable(2)]
		private LevelSequencePlayer DpadLevelSequencePlayer;

		// Token: 0x0401F505 RID: 128261
		private bool ExistDpadSkillItem;

		// Token: 0x0401F506 RID: 128262
		[Nullable(2)]
		private SkillButtonUiGamepadDataBase GamepadData;

		// Token: 0x0401F507 RID: 128263
		private readonly Dictionary<string, float> AxisInputCacheMap = new Dictionary<string, float>();

		// Token: 0x0200BEB5 RID: 48821
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403982B RID: 235563
			SkillItemY,
			// Token: 0x0403982C RID: 235564
			SkillItemX,
			// Token: 0x0403982D RID: 235565
			SkillItemA,
			// Token: 0x0403982E RID: 235566
			SkillItemB,
			// Token: 0x0403982F RID: 235567
			SkillItemSecondContainer,
			// Token: 0x04039830 RID: 235568
			SkillItemSecondY,
			// Token: 0x04039831 RID: 235569
			SkillItemSecondX,
			// Token: 0x04039832 RID: 235570
			SkillItemSecondA,
			// Token: 0x04039833 RID: 235571
			SkillItemSecondB,
			// Token: 0x04039834 RID: 235572
			CombineItem,
			// Token: 0x04039835 RID: 235573
			SkillItemDPadContainer,
			// Token: 0x04039836 RID: 235574
			SkillItemUp,
			// Token: 0x04039837 RID: 235575
			SkillItemLeft,
			// Token: 0x04039838 RID: 235576
			SkillItemDown,
			// Token: 0x04039839 RID: 235577
			SkillItemRight,
			// Token: 0x0403983A RID: 235578
			DPadItem,
			// Token: 0x0403983B RID: 235579
			SkillItemSub1,
			// Token: 0x0403983C RID: 235580
			SkillItemSub2,
			// Token: 0x0403983D RID: 235581
			SkillItemSub3,
			// Token: 0x0403983E RID: 235582
			SkillItemSub4,
			// Token: 0x0403983F RID: 235583
			RouletteItem,
			// Token: 0x04039840 RID: 235584
			SecondShow,
			// Token: 0x04039841 RID: 235585
			SecondHide
		}
	}
}
