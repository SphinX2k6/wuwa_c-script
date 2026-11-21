using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.MapRogue;
using CSharpScript.Game.Module.Roguelike;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004C9C RID: 19612
	[NullableContext(2)]
	[Nullable(0)]
	public class ChatPanel : BattleChildViewPanel
	{
		// Token: 0x06030F34 RID: 200500 RVA: 0x00DA7DC0 File Offset: 0x00DA5FC0
		protected unsafe override void OnRegisterComponent()
		{
			EOperationType operationType = base.GetOperationType();
			if (operationType == EOperationType.Desktop)
			{
				int num = 11;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDynScrollViewComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				num2 = 1;
				List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
				Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
				num = 0;
				*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickChatButton));
				this.BtnBindInfo = list2;
				return;
			}
			if (operationType == EOperationType.Pad)
			{
				int num = 3;
				List<ValueTuple<int, Type>> list3 = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list3, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list3);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
				this.ComponentRegisterInfos = list3;
				num2 = 1;
				List<ValueTuple<int, Delegate>> list4 = new List<ValueTuple<int, Delegate>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list4, num2);
				Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list4);
				num = 0;
				*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickChatButton));
				this.BtnBindInfo = list4;
			}
		}

		// Token: 0x06030F35 RID: 200501 RVA: 0x00DA8068 File Offset: 0x00DA6268
		public override void InitializeTemp()
		{
			this.ChatViewTimeDown = ConfigCommonParamById.GetIntConfig("ChatViewTimeDown").Value;
			EOperationType operationType = base.GetOperationType();
			if (operationType == EOperationType.Desktop)
			{
				this.RefreshChatRowItem();
				this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(3));
			}
			if (operationType == EOperationType.Pad)
			{
				RedDotController.Instance.BindRedDot(ERedDotName.ChatView, base.GetItem(1), null, 0);
				this.LevelSequencePlayer = new LevelSequencePlayer(base.GetItem(2));
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.BindSequenceCloseEvent(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					this.SetChatScrollViewRootVisible(false);
				}
			}, false);
		}

		// Token: 0x06030F36 RID: 200502 RVA: 0x00DA80F8 File Offset: 0x00DA62F8
		public override UniTask InitializeAsync()
		{
			ChatPanel.<InitializeAsync>d__14 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<ChatPanel.<InitializeAsync>d__14>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030F37 RID: 200503 RVA: 0x00DA813B File Offset: 0x00DA633B
		[NullableContext(1)]
		private ChatRowDynamicItem CreateNodeGrid(ChatRowData data, UUIItem uiItem, int index)
		{
			return new ChatRowDynamicItem();
		}

		// Token: 0x06030F38 RID: 200504 RVA: 0x00DA8142 File Offset: 0x00DA6342
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit(EEventName.OnRefreshChatRedDot);
		}

		// Token: 0x06030F39 RID: 200505 RVA: 0x00DA8154 File Offset: 0x00DA6354
		public override void Reset()
		{
			base.Reset();
			this.RemoveScrollDelay();
			this.RemoveChatViewTimeDown();
			if (base.GetOperationType() == EOperationType.Pad)
			{
				RedDotController.Instance.UnBindRedDot(ERedDotName.ChatView);
			}
		}

		// Token: 0x06030F3A RID: 200506 RVA: 0x00DA817D File Offset: 0x00DA637D
		protected override void OnAfterDestroy()
		{
			base.OnAfterDestroy();
			BattleUiModel.Instance.ChatScrollViewVisible = false;
		}

		// Token: 0x06030F3B RID: 200507 RVA: 0x00DA8190 File Offset: 0x00DA6390
		private UniTask NewRouletteItem()
		{
			ChatPanel.<NewRouletteItem>d__19 <NewRouletteItem>d__;
			<NewRouletteItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRouletteItem>d__.<>4__this = this;
			<NewRouletteItem>d__.<>1__state = -1;
			<NewRouletteItem>d__.<>t__builder.Start<ChatPanel.<NewRouletteItem>d__19>(ref <NewRouletteItem>d__);
			return <NewRouletteItem>d__.<>t__builder.Task;
		}

		// Token: 0x06030F3C RID: 200508 RVA: 0x00DA81D4 File Offset: 0x00DA63D4
		protected override void OnShowBattleChildViewPanel(bool isFirst)
		{
			if (Info.Instance.OperationType != EOperationType.Desktop)
			{
				return;
			}
			this.RefreshChatRowItem();
			this.RefreshAfterInit();
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.TowerBuff, this.CheckInTower());
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.RogueInfo, this.CheckInRogue());
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.RogueRes, this.CheckInRogueRes());
			environmentKeyData.SetEnvironmentKeyVisible(EEnvironmentKey.MoraleAreaSum, this.CheckInMorale());
			CommonKeyItem environmentKeyItem = this.EnvironmentKeyItem;
			if (environmentKeyItem != null)
			{
				environmentKeyItem.RefreshAction("功能菜单");
			}
			this.RefreshEnvironmentKeyText();
			this.RefreshItemVisibleByPlatform();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
		}

		// Token: 0x06030F3D RID: 200509 RVA: 0x00DA8290 File Offset: 0x00DA6490
		private void RefreshItemVisibleByPlatform()
		{
			bool uiactive = Info.Instance.IsInGamepad();
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(uiactive);
			}
			this.RefreshEnvironmentKeyVisible();
			this.RefreshRouletteItemVisible();
		}

		// Token: 0x06030F3E RID: 200510 RVA: 0x00DA82C8 File Offset: 0x00DA64C8
		private void RefreshEnvironmentKeyVisible()
		{
			bool flag = Info.Instance.IsInGamepad();
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			EEnvironmentKey eenvironmentKey = (environmentKeyData != null) ? environmentKeyData.GetCurEnvironmentalKey() : EEnvironmentKey.None;
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(eenvironmentKey != EEnvironmentKey.None && this.IsPressMainCombineAction && flag);
		}

		// Token: 0x06030F3F RID: 200511 RVA: 0x00DA8318 File Offset: 0x00DA6518
		private void RefreshEnvironmentKeyText()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			string text = (environmentKeyData != null) ? environmentKeyData.GetCurKeyText() : null;
			if (!string.IsNullOrEmpty(text))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), text, Array.Empty<object>());
			}
		}

		// Token: 0x06030F40 RID: 200512 RVA: 0x00DA835C File Offset: 0x00DA655C
		private void RefreshRouletteItemVisible()
		{
			BattleSkillLeftRouletteItem rouletteItem = this.RouletteItem;
			if (rouletteItem == null)
			{
				return;
			}
			rouletteItem.RefreshVisible();
		}

		// Token: 0x06030F41 RID: 200513 RVA: 0x00DA8370 File Offset: 0x00DA6570
		protected override void AddEvents()
		{
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				EventSystem.Instance.Add(EEventName.OnRefreshChatRowData, new Action<bool>(this.OnRefreshChatRowData));
				EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
				EventSystem.Instance.Add(EEventName.BattleUiEnvironmentKeyChanged, new Action(this.OnEnvironmentKeyChanged));
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
				EventSystem.Instance.Add<bool>(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
				EventSystem.Instance.Add<bool>(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged));
				InputDistributeController.Instance.BindActions(new <>z__ReadOnlyArray<string>(new string[]
				{
					"环境特性",
					"组合主键"
				}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06030F42 RID: 200514 RVA: 0x00DA8464 File Offset: 0x00DA6664
		protected override void RemoveEvents()
		{
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				if (EventSystem.Instance.Has(EEventName.OnRefreshChatRowData, new Action<bool>(this.OnRefreshChatRowData)))
				{
					EventSystem.Instance.Remove(EEventName.OnRefreshChatRowData, new Action<bool>(this.OnRefreshChatRowData));
				}
				if (EventSystem.Instance.Has(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange)))
				{
					EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
				}
				if (EventSystem.Instance.Has(EEventName.BattleUiEnvironmentKeyChanged, new Action(this.OnEnvironmentKeyChanged)))
				{
					EventSystem.Instance.Remove(EEventName.BattleUiEnvironmentKeyChanged, new Action(this.OnEnvironmentKeyChanged));
				}
				if (EventSystem.Instance.Has(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton)))
				{
					EventSystem.Instance.Remove(EEventName.BattleUiPressCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
				}
				if (EventSystem.Instance.Has(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputCombineButton)))
				{
					EventSystem.Instance.Remove(EEventName.BattleUiPressMotorcycleCombineButtonChanged, new Action<bool>(this.OnInputCombineButton));
				}
				if (EventSystem.Instance.Has(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged)))
				{
					EventSystem.Instance.Remove(EEventName.BattleUiMotorcycleStateChanged, new Action<bool>(this.BattleUiMotorcycleStateChanged));
				}
				InputDistributeController.Instance.UnBindActions(new <>z__ReadOnlyArray<string>(new string[]
				{
					"环境特性",
					"组合主键"
				}), new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputAction));
			}
		}

		// Token: 0x06030F43 RID: 200515 RVA: 0x00DA8604 File Offset: 0x00DA6804
		private void OnRefreshChatRowData(bool bHistory)
		{
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				this.RefreshChatRowItem();
				this.RefreshAfterUpdate(bHistory);
			}
		}

		// Token: 0x06030F44 RID: 200516 RVA: 0x00DA861C File Offset: 0x00DA681C
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshItemVisibleByPlatform();
		}

		// Token: 0x06030F45 RID: 200517 RVA: 0x00DA8624 File Offset: 0x00DA6824
		private void OnEnvironmentKeyChanged()
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.RefreshEnvironmentKeyVisible();
			this.RefreshEnvironmentKeyText();
		}

		// Token: 0x06030F46 RID: 200518 RVA: 0x00DA863F File Offset: 0x00DA683F
		private void OnInputCombineButton(bool isPress)
		{
			this.RefreshRouletteItemVisible();
		}

		// Token: 0x06030F47 RID: 200519 RVA: 0x00DA8647 File Offset: 0x00DA6847
		private void BattleUiMotorcycleStateChanged(bool isDriving)
		{
			this.RefreshRouletteItemVisible();
		}

		// Token: 0x06030F48 RID: 200520 RVA: 0x00DA864F File Offset: 0x00DA684F
		private void OnClickChatButton()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.ChatView, null, null);
		}

		// Token: 0x06030F49 RID: 200521 RVA: 0x00DA8674 File Offset: 0x00DA6874
		[NullableContext(1)]
		private void OnInputAction(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionName == "环境特性")
			{
				if (!InputManager.Instance.IsAllowOpenViewByShortcutKey())
				{
					return;
				}
				if (actionType == InputDistributeDefine.EActionType.Press)
				{
					BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
					switch ((environmentKeyData != null) ? environmentKeyData.GetCurEnvironmentalKey() : EEnvironmentKey.None)
					{
					case EEnvironmentKey.SilentArea:
						ChatPanel.OpenSilentInfoView();
						return;
					case EEnvironmentKey.TowerBuff:
						this.OpenTowerBuffView();
						return;
					case EEnvironmentKey.DungeonGuide:
						this.OpenDungeonGuideView();
						return;
					case EEnvironmentKey.RogueInfo:
						this.OpenRogueInfoView();
						return;
					case EEnvironmentKey.TowerDefense:
						ChatPanel.OpenTowerDefenseInfoView();
						return;
					case EEnvironmentKey.ShipTowerBuff:
						ChatPanel.OpenShipTowerBuffView();
						return;
					case EEnvironmentKey.RogueRes:
						ChatPanel.OpenRogueResSummaryView();
						return;
					case EEnvironmentKey.MoraleBuff:
						ChatPanel.OpenMoraleBuffView();
						return;
					case EEnvironmentKey.MoraleAreaSum:
						ChatPanel.OpenMoraleAreaSumView();
						return;
					default:
						return;
					}
				}
			}
			else if (actionName == "组合主键")
			{
				this.OnInputMainCombineAction(actionType);
			}
		}

		// Token: 0x06030F4A RID: 200522 RVA: 0x00DA8735 File Offset: 0x00DA6935
		private void OnInputMainCombineAction(InputDistributeDefine.EActionType actionType)
		{
			this.IsPressMainCombineAction = (actionType == InputDistributeDefine.EActionType.Press);
			this.RefreshEnvironmentKeyVisible();
		}

		// Token: 0x06030F4B RID: 200523 RVA: 0x00DA8747 File Offset: 0x00DA6947
		private bool CheckInTower()
		{
			return TowerModel.Instance.CheckInTower();
		}

		// Token: 0x06030F4C RID: 200524 RVA: 0x00DA8753 File Offset: 0x00DA6953
		private bool CheckInRogue()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x06030F4D RID: 200525 RVA: 0x00DA876D File Offset: 0x00DA696D
		private bool CheckInRogueRes()
		{
			return MapRogueController.Instance.CheckInMapRogueInstance();
		}

		// Token: 0x06030F4E RID: 200526 RVA: 0x00DA8779 File Offset: 0x00DA6979
		private bool CheckInMorale()
		{
			return MoraleBattleModel.Instance.IsMoraleActive();
		}

		// Token: 0x06030F4F RID: 200527 RVA: 0x00DA8785 File Offset: 0x00DA6985
		private void OpenTowerBuffView()
		{
			if (!this.CheckInTower())
			{
				return;
			}
			if (UiManager.Instance.IsViewShow(EUiViewName.TowerGuideView))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.TowerGuideView, null, null);
		}

		// Token: 0x06030F50 RID: 200528 RVA: 0x00DA87B3 File Offset: 0x00DA69B3
		private void OpenDungeonGuideView()
		{
			InstanceDungeonGuideController.StartReplayGuide();
		}

		// Token: 0x06030F51 RID: 200529 RVA: 0x00DA87BC File Offset: 0x00DA69BC
		private void OpenRogueInfoView()
		{
			if (!this.CheckInRogue())
			{
				return;
			}
			EUiViewName euiViewName = WeeklyRogueModel.Instance.CheckIsInWeeklyRogue() ? EUiViewName.WeeklyRogueInfo : EUiViewName.RogueInfoView;
			if (UiManager.Instance.IsViewShow(euiViewName))
			{
				return;
			}
			if (euiViewName == EUiViewName.RogueInfoView)
			{
				RoguelikeController.Instance.OpenRogueInfoView(null, true, true, ERogueInfoViewPage.Overview);
				return;
			}
			UiManager.Instance.OpenView(euiViewName, null, null);
		}

		// Token: 0x06030F52 RID: 200530 RVA: 0x00DA8822 File Offset: 0x00DA6A22
		private static void OpenSilentInfoView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleSilentAreaInfoView);
		}

		// Token: 0x06030F53 RID: 200531 RVA: 0x00DA8834 File Offset: 0x00DA6A34
		private static void OpenTowerDefenseInfoView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleTowerDefenseInfoView);
		}

		// Token: 0x06030F54 RID: 200532 RVA: 0x00DA8846 File Offset: 0x00DA6A46
		private static void OpenShipTowerBuffView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleShipTowerBuffInfo);
		}

		// Token: 0x06030F55 RID: 200533 RVA: 0x00DA8858 File Offset: 0x00DA6A58
		private static void OpenMoraleBuffView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleMoraleBuffInfo);
		}

		// Token: 0x06030F56 RID: 200534 RVA: 0x00DA886A File Offset: 0x00DA6A6A
		private static void OpenRogueResSummaryView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.RogueBattleSummary))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RogueBattleSummary, null, null);
		}

		// Token: 0x06030F57 RID: 200535 RVA: 0x00DA888F File Offset: 0x00DA6A8F
		private static void OpenMoraleAreaSumView()
		{
			if (!MoraleModel.Instance.IsInitData)
			{
				return;
			}
			if (!MoraleBattleModel.Instance.IsMoraleActive())
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.MoraleAreaSumView, null, null);
		}

		// Token: 0x06030F58 RID: 200536 RVA: 0x00DA88BC File Offset: 0x00DA6ABC
		private void RefreshChatRowItem()
		{
			this.ActualChatDataList.Clear();
			this.BuildActualChatDataList();
			DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> chatLoopScrollView = this.ChatLoopScrollView;
			if (chatLoopScrollView != null)
			{
				chatLoopScrollView.RefreshByData(this.ActualChatDataList.ToArray(), true, true);
			}
			DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> chatLoopScrollView2 = this.ChatLoopScrollView;
			if (chatLoopScrollView2 == null)
			{
				return;
			}
			chatLoopScrollView2.BindLateUpdate(delegate(float _)
			{
				DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> chatLoopScrollView3 = this.ChatLoopScrollView;
				if (chatLoopScrollView3 != null)
				{
					chatLoopScrollView3.ScrollToItemIndex(this.ActualChatDataList.Count - 1, true, false).Forget();
				}
				DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> chatLoopScrollView4 = this.ChatLoopScrollView;
				if (chatLoopScrollView4 == null)
				{
					return;
				}
				chatLoopScrollView4.UnBindLateUpdate();
			});
		}

		// Token: 0x06030F59 RID: 200537 RVA: 0x00DA8914 File Offset: 0x00DA6B14
		private void RefreshAfterInit()
		{
			if (this.ActualChatDataList.Count <= 0)
			{
				this.SetChatScrollViewRootVisible(false);
				return;
			}
			if (ChatModel.Instance.HasOfflineMassage())
			{
				this.ActivateChatScrollView();
				this.DelayScroll(200f);
				return;
			}
			this.SetChatScrollViewRootVisible(false);
		}

		// Token: 0x06030F5A RID: 200538 RVA: 0x00DA8951 File Offset: 0x00DA6B51
		private void RefreshAfterUpdate(bool bHistory)
		{
			if (this.ActualChatDataList.Count <= 0)
			{
				this.SetChatScrollViewRootVisible(false);
				return;
			}
			this.DelayScroll(200f);
			if (!bHistory)
			{
				this.ActivateChatScrollView();
				return;
			}
			if (ChatModel.Instance.HasOfflineMassage())
			{
				this.ActivateChatScrollView();
			}
		}

		// Token: 0x06030F5B RID: 200539 RVA: 0x00DA8990 File Offset: 0x00DA6B90
		private void BuildActualChatDataList()
		{
			foreach (ChatRowData chatRowData in ChatModel.Instance.GetChatRowDataList())
			{
				if (chatRowData.ContentChatRoomType == EChatRoomType.Private)
				{
					int? targetPlayerId = chatRowData.TargetPlayerId;
					if (targetPlayerId == null)
					{
						continue;
					}
					FriendModel instance = FriendModel.Instance;
					FriendData friendById = instance.GetFriendById(targetPlayerId.Value);
					if (friendById == null || instance.HasBlockedPlayer(targetPlayerId.Value) || friendById.GetBlockBySdk())
					{
						continue;
					}
				}
				this.ActualChatDataList.Add(chatRowData);
			}
		}

		// Token: 0x06030F5C RID: 200540 RVA: 0x00DA8A30 File Offset: 0x00DA6C30
		public void DelayScroll(float delayTime)
		{
			this.RemoveScrollDelay();
			if (base.GetOperationType() != EOperationType.Desktop)
			{
				return;
			}
			this.ScrollDelayId = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnSetScrollProgressDelay), delayTime, null, null, true, 1f);
		}

		// Token: 0x06030F5D RID: 200541 RVA: 0x00DA8A67 File Offset: 0x00DA6C67
		private void RemoveScrollDelay()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.ScrollDelayId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ScrollDelayId);
			}
			this.ScrollDelayId = null;
		}

		// Token: 0x06030F5E RID: 200542 RVA: 0x00DA8A93 File Offset: 0x00DA6C93
		private void RemoveChatViewTimeDown()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.ChatViewTimeDownId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ChatViewTimeDownId);
			}
			this.ChatViewTimeDownId = null;
		}

		// Token: 0x06030F5F RID: 200543 RVA: 0x00DA8ABF File Offset: 0x00DA6CBF
		private void OnSetScrollProgressDelay(float _)
		{
			if (this.ActualChatDataList.Count <= 0)
			{
				return;
			}
			DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> chatLoopScrollView = this.ChatLoopScrollView;
			if (chatLoopScrollView == null)
			{
				return;
			}
			chatLoopScrollView.ScrollToItemIndex(this.ActualChatDataList.Count - 1, true, false).Forget();
		}

		// Token: 0x06030F60 RID: 200544 RVA: 0x00DA8AF4 File Offset: 0x00DA6CF4
		private void ActivateChatScrollView()
		{
			this.RemoveChatViewTimeDown();
			UUIItem item = base.GetItem(3);
			if (item == null || !item.bIsUIActive)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopCurrentSequence(false, false);
				}
				LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
				if (levelSequencePlayer2 != null)
				{
					levelSequencePlayer2.PlaySequencePurely("Start", false, false, null, null, false);
				}
			}
			this.SetChatScrollViewRootVisible(true);
			this.ChatViewTimeDownId = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnChatViewTimeDown), (float)this.ChatViewTimeDown, null, null, true, 1f);
		}

		// Token: 0x06030F61 RID: 200545 RVA: 0x00DA8B88 File Offset: 0x00DA6D88
		private void OnChatViewTimeDown(float _)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopCurrentSequence(false, false);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 == null)
			{
				return;
			}
			levelSequencePlayer2.PlaySequencePurely("Close", false, false, null, null, false);
		}

		// Token: 0x06030F62 RID: 200546 RVA: 0x00DA8BCA File Offset: 0x00DA6DCA
		private void SetChatScrollViewRootVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			BattleUiModel.Instance.ChatScrollViewVisible = bVisible;
		}

		// Token: 0x04019F98 RID: 106392
		private TimerHandle ChatViewTimeDownId;

		// Token: 0x04019F99 RID: 106393
		private int ChatViewTimeDown;

		// Token: 0x04019F9A RID: 106394
		private TimerHandle ScrollDelayId;

		// Token: 0x04019F9B RID: 106395
		private bool IsPressMainCombineAction;

		// Token: 0x04019F9C RID: 106396
		private CommonKeyItem EnvironmentKeyItem;

		// Token: 0x04019F9D RID: 106397
		private BattleSkillLeftRouletteItem RouletteItem;

		// Token: 0x04019F9E RID: 106398
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019F9F RID: 106399
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> ChatLoopScrollView;

		// Token: 0x04019FA0 RID: 106400
		private ChatRowDynamicItemSize ChatBaseItem;

		// Token: 0x04019FA1 RID: 106401
		[Nullable(1)]
		private readonly List<ChatRowData> ActualChatDataList = new List<ChatRowData>();

		// Token: 0x0200A8AD RID: 43181
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x040341A6 RID: 213414
			ChatButton,
			// Token: 0x040341A7 RID: 213415
			ChatScrollView,
			// Token: 0x040341A8 RID: 213416
			ChatRowItemContent,
			// Token: 0x040341A9 RID: 213417
			PanelChatScrollViewRoot,
			// Token: 0x040341AA RID: 213418
			ChatItem,
			// Token: 0x040341AB RID: 213419
			ChatKeyItem,
			// Token: 0x040341AC RID: 213420
			KeyItemGroup,
			// Token: 0x040341AD RID: 213421
			EnvironmentKeyItemContainer,
			// Token: 0x040341AE RID: 213422
			EnvironmentKeyItem,
			// Token: 0x040341AF RID: 213423
			EnvironmentKeyItemText,
			// Token: 0x040341B0 RID: 213424
			RouletteItem,
			// Token: 0x040341B1 RID: 213425
			PanelChatItem
		}

		// Token: 0x0200A8AE RID: 43182
		[NullableContext(0)]
		private enum EPadChildType
		{
			// Token: 0x040341B3 RID: 213427
			ChatButton,
			// Token: 0x040341B4 RID: 213428
			RedDotItem,
			// Token: 0x040341B5 RID: 213429
			ChatPadItem
		}
	}
}
