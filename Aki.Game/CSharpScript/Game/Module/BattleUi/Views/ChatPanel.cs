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
	// Token: 0x02005CBA RID: 23738
	[NullableContext(2)]
	[Nullable(0)]
	public class ChatPanel : BattleChildViewPanel
	{
		// Token: 0x0603BFE1 RID: 245729 RVA: 0x00E57718 File Offset: 0x00E55918
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

		// Token: 0x0603BFE2 RID: 245730 RVA: 0x00E579C0 File Offset: 0x00E55BC0
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

		// Token: 0x0603BFE3 RID: 245731 RVA: 0x00E57A50 File Offset: 0x00E55C50
		public override UniTask InitializeAsync()
		{
			ChatPanel.<InitializeAsync>d__14 <InitializeAsync>d__;
			<InitializeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitializeAsync>d__.<>4__this = this;
			<InitializeAsync>d__.<>1__state = -1;
			<InitializeAsync>d__.<>t__builder.Start<ChatPanel.<InitializeAsync>d__14>(ref <InitializeAsync>d__);
			return <InitializeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFE4 RID: 245732 RVA: 0x00E57A93 File Offset: 0x00E55C93
		[NullableContext(1)]
		private ChatRowDynamicItem CreateNodeGrid(ChatRowData data, UUIItem uiItem, int index)
		{
			return new ChatRowDynamicItem();
		}

		// Token: 0x0603BFE5 RID: 245733 RVA: 0x00E57A9A File Offset: 0x00E55C9A
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Emit(EEventName.OnRefreshChatRedDot);
		}

		// Token: 0x0603BFE6 RID: 245734 RVA: 0x00E57AAC File Offset: 0x00E55CAC
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

		// Token: 0x0603BFE7 RID: 245735 RVA: 0x00E57AD5 File Offset: 0x00E55CD5
		protected override void OnAfterDestroy()
		{
			base.OnAfterDestroy();
			BattleUiModel.Instance.ChatScrollViewVisible = false;
		}

		// Token: 0x0603BFE8 RID: 245736 RVA: 0x00E57AE8 File Offset: 0x00E55CE8
		private UniTask NewRouletteItem()
		{
			ChatPanel.<NewRouletteItem>d__19 <NewRouletteItem>d__;
			<NewRouletteItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<NewRouletteItem>d__.<>4__this = this;
			<NewRouletteItem>d__.<>1__state = -1;
			<NewRouletteItem>d__.<>t__builder.Start<ChatPanel.<NewRouletteItem>d__19>(ref <NewRouletteItem>d__);
			return <NewRouletteItem>d__.<>t__builder.Task;
		}

		// Token: 0x0603BFE9 RID: 245737 RVA: 0x00E57B2C File Offset: 0x00E55D2C
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

		// Token: 0x0603BFEA RID: 245738 RVA: 0x00E57BE8 File Offset: 0x00E55DE8
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

		// Token: 0x0603BFEB RID: 245739 RVA: 0x00E57C20 File Offset: 0x00E55E20
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

		// Token: 0x0603BFEC RID: 245740 RVA: 0x00E57C70 File Offset: 0x00E55E70
		private void RefreshEnvironmentKeyText()
		{
			BattleUiEnvironmentKeyData environmentKeyData = BattleUiModel.Instance.EnvironmentKeyData;
			string text = (environmentKeyData != null) ? environmentKeyData.GetCurKeyText() : null;
			if (!string.IsNullOrEmpty(text))
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(9), text, Array.Empty<object>());
			}
		}

		// Token: 0x0603BFED RID: 245741 RVA: 0x00E57CB4 File Offset: 0x00E55EB4
		private void RefreshRouletteItemVisible()
		{
			BattleSkillLeftRouletteItem rouletteItem = this.RouletteItem;
			if (rouletteItem == null)
			{
				return;
			}
			rouletteItem.RefreshVisible();
		}

		// Token: 0x0603BFEE RID: 245742 RVA: 0x00E57CC8 File Offset: 0x00E55EC8
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

		// Token: 0x0603BFEF RID: 245743 RVA: 0x00E57DBC File Offset: 0x00E55FBC
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

		// Token: 0x0603BFF0 RID: 245744 RVA: 0x00E57F5C File Offset: 0x00E5615C
		private void OnRefreshChatRowData(bool bHistory)
		{
			if (base.GetOperationType() == EOperationType.Desktop)
			{
				this.RefreshChatRowItem();
				this.RefreshAfterUpdate(bHistory);
			}
		}

		// Token: 0x0603BFF1 RID: 245745 RVA: 0x00E57F74 File Offset: 0x00E56174
		private void InputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.RefreshItemVisibleByPlatform();
		}

		// Token: 0x0603BFF2 RID: 245746 RVA: 0x00E57F7C File Offset: 0x00E5617C
		private void OnEnvironmentKeyChanged()
		{
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			this.RefreshEnvironmentKeyVisible();
			this.RefreshEnvironmentKeyText();
		}

		// Token: 0x0603BFF3 RID: 245747 RVA: 0x00E57F97 File Offset: 0x00E56197
		private void OnInputCombineButton(bool isPress)
		{
			this.RefreshRouletteItemVisible();
		}

		// Token: 0x0603BFF4 RID: 245748 RVA: 0x00E57F9F File Offset: 0x00E5619F
		private void BattleUiMotorcycleStateChanged(bool isDriving)
		{
			this.RefreshRouletteItemVisible();
		}

		// Token: 0x0603BFF5 RID: 245749 RVA: 0x00E57FA7 File Offset: 0x00E561A7
		private void OnClickChatButton()
		{
			if (UiManager.Instance.IsViewShow(EUiViewName.ChatView))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.ChatView, null, null);
		}

		// Token: 0x0603BFF6 RID: 245750 RVA: 0x00E57FCC File Offset: 0x00E561CC
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

		// Token: 0x0603BFF7 RID: 245751 RVA: 0x00E5808D File Offset: 0x00E5628D
		private void OnInputMainCombineAction(InputDistributeDefine.EActionType actionType)
		{
			this.IsPressMainCombineAction = (actionType == InputDistributeDefine.EActionType.Press);
			this.RefreshEnvironmentKeyVisible();
		}

		// Token: 0x0603BFF8 RID: 245752 RVA: 0x00E5809F File Offset: 0x00E5629F
		private bool CheckInTower()
		{
			return TowerModel.Instance.CheckInTower();
		}

		// Token: 0x0603BFF9 RID: 245753 RVA: 0x00E580AB File Offset: 0x00E562AB
		private bool CheckInRogue()
		{
			return RoguelikeModel.Instance.CheckInRoguelike() || WeeklyRogueModel.Instance.CheckIsInWeeklyRogue();
		}

		// Token: 0x0603BFFA RID: 245754 RVA: 0x00E580C5 File Offset: 0x00E562C5
		private bool CheckInRogueRes()
		{
			return MapRogueController.Instance.CheckInMapRogueInstance();
		}

		// Token: 0x0603BFFB RID: 245755 RVA: 0x00E580D1 File Offset: 0x00E562D1
		private bool CheckInMorale()
		{
			return MoraleBattleModel.Instance.IsMoraleActive();
		}

		// Token: 0x0603BFFC RID: 245756 RVA: 0x00E580DD File Offset: 0x00E562DD
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

		// Token: 0x0603BFFD RID: 245757 RVA: 0x00E5810B File Offset: 0x00E5630B
		private void OpenDungeonGuideView()
		{
			InstanceDungeonGuideController.StartReplayGuide();
		}

		// Token: 0x0603BFFE RID: 245758 RVA: 0x00E58114 File Offset: 0x00E56314
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

		// Token: 0x0603BFFF RID: 245759 RVA: 0x00E5817A File Offset: 0x00E5637A
		private static void OpenSilentInfoView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleSilentAreaInfoView);
		}

		// Token: 0x0603C000 RID: 245760 RVA: 0x00E5818C File Offset: 0x00E5638C
		private static void OpenTowerDefenseInfoView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleTowerDefenseInfoView);
		}

		// Token: 0x0603C001 RID: 245761 RVA: 0x00E5819E File Offset: 0x00E5639E
		private static void OpenShipTowerBuffView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleShipTowerBuffInfo);
		}

		// Token: 0x0603C002 RID: 245762 RVA: 0x00E581B0 File Offset: 0x00E563B0
		private static void OpenMoraleBuffView()
		{
			EventSystem.Instance.Emit(EEventName.BattleUiToggleMoraleBuffInfo);
		}

		// Token: 0x0603C003 RID: 245763 RVA: 0x00E581C2 File Offset: 0x00E563C2
		private static void OpenRogueResSummaryView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.RogueBattleSummary))
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RogueBattleSummary, null, null);
		}

		// Token: 0x0603C004 RID: 245764 RVA: 0x00E581E7 File Offset: 0x00E563E7
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

		// Token: 0x0603C005 RID: 245765 RVA: 0x00E58214 File Offset: 0x00E56414
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

		// Token: 0x0603C006 RID: 245766 RVA: 0x00E5826C File Offset: 0x00E5646C
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

		// Token: 0x0603C007 RID: 245767 RVA: 0x00E582A9 File Offset: 0x00E564A9
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

		// Token: 0x0603C008 RID: 245768 RVA: 0x00E582E8 File Offset: 0x00E564E8
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

		// Token: 0x0603C009 RID: 245769 RVA: 0x00E58388 File Offset: 0x00E56588
		public void DelayScroll(float delayTime)
		{
			this.RemoveScrollDelay();
			if (base.GetOperationType() != EOperationType.Desktop)
			{
				return;
			}
			this.ScrollDelayId = TimerSystem.GameplayTimeInstance.Delay(new TTimerAction(this.OnSetScrollProgressDelay), delayTime, null, null, true, 1f);
		}

		// Token: 0x0603C00A RID: 245770 RVA: 0x00E583BF File Offset: 0x00E565BF
		private void RemoveScrollDelay()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.ScrollDelayId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ScrollDelayId);
			}
			this.ScrollDelayId = null;
		}

		// Token: 0x0603C00B RID: 245771 RVA: 0x00E583EB File Offset: 0x00E565EB
		private void RemoveChatViewTimeDown()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.ChatViewTimeDownId))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.ChatViewTimeDownId);
			}
			this.ChatViewTimeDownId = null;
		}

		// Token: 0x0603C00C RID: 245772 RVA: 0x00E58417 File Offset: 0x00E56617
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

		// Token: 0x0603C00D RID: 245773 RVA: 0x00E5844C File Offset: 0x00E5664C
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

		// Token: 0x0603C00E RID: 245774 RVA: 0x00E584E0 File Offset: 0x00E566E0
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

		// Token: 0x0603C00F RID: 245775 RVA: 0x00E58522 File Offset: 0x00E56722
		private void SetChatScrollViewRootVisible(bool bVisible)
		{
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(bVisible);
			}
			BattleUiModel.Instance.ChatScrollViewVisible = bVisible;
		}

		// Token: 0x0401F4DF RID: 128223
		private TimerHandle ChatViewTimeDownId;

		// Token: 0x0401F4E0 RID: 128224
		private int ChatViewTimeDown;

		// Token: 0x0401F4E1 RID: 128225
		private TimerHandle ScrollDelayId;

		// Token: 0x0401F4E2 RID: 128226
		private bool IsPressMainCombineAction;

		// Token: 0x0401F4E3 RID: 128227
		private CommonKeyItem EnvironmentKeyItem;

		// Token: 0x0401F4E4 RID: 128228
		private BattleSkillLeftRouletteItem RouletteItem;

		// Token: 0x0401F4E5 RID: 128229
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F4E6 RID: 128230
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private DynamicScrollView<ChatRowDynamicItem, ChatRowDynamicItemSize, ChatRowData> ChatLoopScrollView;

		// Token: 0x0401F4E7 RID: 128231
		private ChatRowDynamicItemSize ChatBaseItem;

		// Token: 0x0401F4E8 RID: 128232
		[Nullable(1)]
		private readonly List<ChatRowData> ActualChatDataList = new List<ChatRowData>();

		// Token: 0x0200BEA7 RID: 48807
		[NullableContext(0)]
		private enum EDesktopChildType
		{
			// Token: 0x040397E5 RID: 235493
			ChatButton,
			// Token: 0x040397E6 RID: 235494
			ChatScrollView,
			// Token: 0x040397E7 RID: 235495
			ChatRowItemContent,
			// Token: 0x040397E8 RID: 235496
			PanelChatScrollViewRoot,
			// Token: 0x040397E9 RID: 235497
			ChatItem,
			// Token: 0x040397EA RID: 235498
			ChatKeyItem,
			// Token: 0x040397EB RID: 235499
			KeyItemGroup,
			// Token: 0x040397EC RID: 235500
			EnvironmentKeyItemContainer,
			// Token: 0x040397ED RID: 235501
			EnvironmentKeyItem,
			// Token: 0x040397EE RID: 235502
			EnvironmentKeyItemText,
			// Token: 0x040397EF RID: 235503
			RouletteItem,
			// Token: 0x040397F0 RID: 235504
			PanelChatItem
		}

		// Token: 0x0200BEA8 RID: 48808
		[NullableContext(0)]
		private enum EPadChildType
		{
			// Token: 0x040397F2 RID: 235506
			ChatButton,
			// Token: 0x040397F3 RID: 235507
			RedDotItem,
			// Token: 0x040397F4 RID: 235508
			ChatPadItem
		}
	}
}
