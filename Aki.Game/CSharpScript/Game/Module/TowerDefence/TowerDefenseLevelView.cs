using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B51 RID: 19281
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseLevelView : UiTickViewBase
	{
		// Token: 0x06031EC2 RID: 204482 RVA: 0x00B9489D File Offset: 0x00B92A9D
		public TowerDefenseLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031EC3 RID: 204483 RVA: 0x00B948B4 File Offset: 0x00B92AB4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031EC4 RID: 204484 RVA: 0x00B949A1 File Offset: 0x00B92BA1
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06031EC5 RID: 204485 RVA: 0x00B949DB File Offset: 0x00B92BDB
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06031EC6 RID: 204486 RVA: 0x00B94A18 File Offset: 0x00B92C18
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseLevelView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseLevelView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031EC7 RID: 204487 RVA: 0x00B94A5B File Offset: 0x00B92C5B
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031EC8 RID: 204488 RVA: 0x00B94A64 File Offset: 0x00B92C64
		protected override void OnBeforeShow()
		{
			TowerDefenseRewardEntranceItem pointsEntrance = this.PointsEntrance;
			if (pointsEntrance == null)
			{
				return;
			}
			pointsEntrance.RefreshItem();
		}

		// Token: 0x06031EC9 RID: 204489 RVA: 0x00B94A78 File Offset: 0x00B92C78
		protected override void OnAfterShow()
		{
			this.MatchingCountDownItem.BindOnClickBtnCancelMatching(delegate
			{
				InstanceDungeonEntranceController.Instance.CancelMatchRequest();
			});
			this.MatchingCountDownItem.BindOnAfterCloseAnimation(delegate(string sequenceName)
			{
				if (sequenceName == "Close")
				{
					InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
					if (matchingCountDownItem2 == null)
					{
						return;
					}
					matchingCountDownItem2.SetUiActive(false);
				}
			});
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem != null)
				{
					matchingCountDownItem.PlayAnimation("Start");
				}
				this.MatchingCountDownItem.StartTimer();
			}
		}

		// Token: 0x06031ECA RID: 204490 RVA: 0x00B94AF4 File Offset: 0x00B92CF4
		private void OnMatchingBegin()
		{
			TowerDefenseLevelDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.RefreshChallengeBtnMatchingState();
			}
			InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
			if (matchingCountDownItem != null)
			{
				matchingCountDownItem.PlayAnimation("Start");
			}
			InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
			if (matchingCountDownItem2 != null)
			{
				matchingCountDownItem2.BindOnStopTimer(() => InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.Matching);
			}
			this.BeginMatching();
		}

		// Token: 0x06031ECB RID: 204491 RVA: 0x00B94B60 File Offset: 0x00B92D60
		private void OnMatchingChange()
		{
			TowerDefenseLevelDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.RefreshChallengeBtnMatchingState();
			}
			switch (InstanceDungeonEntranceModel.Instance.GetMatchingState())
			{
			case EInstanceMatchState.Default:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem = this.MatchingCountDownItem;
				if (matchingCountDownItem == null)
				{
					return;
				}
				matchingCountDownItem.PlayAnimation("Close");
				return;
			}
			case EInstanceMatchState.Matching:
			{
				ScrollingTipsController.Instance.ShowTipsById("MatchingOtherCancel", Array.Empty<object>());
				InstanceDungeonMatchingCountDown matchingCountDownItem2 = this.MatchingCountDownItem;
				if (matchingCountDownItem2 != null)
				{
					matchingCountDownItem2.PlayAnimation("Start");
				}
				this.BeginMatching();
				return;
			}
			case EInstanceMatchState.MatchConfirm:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem3 = this.MatchingCountDownItem;
				if (matchingCountDownItem3 != null)
				{
					matchingCountDownItem3.PlayAnimation("Finish");
				}
				UiManager.Instance.OpenView(EUiViewName.OnlineInstanceMatchTips, null, null);
				return;
			}
			case EInstanceMatchState.Waiting:
				break;
			case EInstanceMatchState.ConfirmToReady:
			{
				InstanceDungeonMatchingCountDown matchingCountDownItem4 = this.MatchingCountDownItem;
				if (matchingCountDownItem4 != null)
				{
					matchingCountDownItem4.SetUiActive(false);
				}
				BattleTeamModel.Instance.Context.SetMultiEntry(true);
				if (UiManager.Instance.IsViewOpen(EUiViewName.InstanceDungeonMonsterPreView))
				{
					UiManager.Instance.CloseView(EUiViewName.InstanceDungeonMonsterPreView, null);
				}
				FormationController.Instance.OpenBattleTeamView(InstanceDungeonEntranceModel.Instance.GetMatchingId(), true, true, false, null);
				EventSystem.Instance.Emit(EEventName.OnEnterTeam);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06031ECC RID: 204492 RVA: 0x00B94C86 File Offset: 0x00B92E86
		private void BeginMatching()
		{
			this.MatchingCountDownItem.SetMatchingTime(0);
			this.MatchingCountDownItem.StartTimer();
		}

		// Token: 0x06031ECD RID: 204493 RVA: 0x00B94CA0 File Offset: 0x00B92EA0
		protected override void OnBeforeDestroy()
		{
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() == EInstanceMatchState.Matching)
			{
				ScrollingTipsController.Instance.ShowTipsById("MatchingBackground", Array.Empty<object>());
			}
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = 0;
			TowerDefenseController.Instance.SetIsUiFlowOpen(false);
			this.MatchingCountDownItem = null;
		}

		// Token: 0x06031ECE RID: 204494 RVA: 0x00B94CFC File Offset: 0x00B92EFC
		protected override void OnTick(float delta)
		{
			if (this.LevelScroll == null)
			{
				return;
			}
			foreach (TowerDefenseLevelItem towerDefenseLevelItem in this.LevelScroll.GetScrollItemList())
			{
				towerDefenseLevelItem.RefreshOnTick();
			}
		}

		// Token: 0x06031ECF RID: 204495 RVA: 0x00B94D5C File Offset: 0x00B92F5C
		private List<TowerDefenseGroupData> BuildGroupDataList()
		{
			List<ITowerDefenseParsedStageMessage> stageListCache = TowerDefenseModel.Instance.PhantomMessageCache.StageListCache;
			if (stageListCache == null)
			{
				return new List<TowerDefenseGroupData>();
			}
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (ITowerDefenseParsedStageMessage towerDefenseParsedStageMessage in stageListCache)
			{
				TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(towerDefenseParsedStageMessage.Id);
				if (towerDefenseConfigById != null)
				{
					List<int> list;
					if (!dictionary.TryGetValue(towerDefenseConfigById.Value.GroupId, out list))
					{
						list = new List<int>();
						dictionary[towerDefenseConfigById.Value.GroupId] = list;
					}
					list.Add(towerDefenseParsedStageMessage.Id);
				}
			}
			List<TowerDefenseGroupData> list2 = new List<TowerDefenseGroupData>();
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int num;
				List<int> list3;
				keyValuePair.Deconstruct(out num, out list3);
				int groupId = num;
				List<int> list4 = list3;
				list4.Sort(new Comparison<int>(this.CompareSubLevel));
				list2.Add(new TowerDefenseGroupData
				{
					GroupId = groupId,
					SubStageIds = list4,
					OnClickSubLevel = new Action<int>(this.OnClickSubLevel),
					IsSelectedGetter = new Func<int, bool>(this.IsStageSelected)
				});
			}
			return list2;
		}

		// Token: 0x06031ED0 RID: 204496 RVA: 0x00B94ED4 File Offset: 0x00B930D4
		private int CompareSubLevel(int a, int b)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(a);
			TowerDefenceInstance? towerDefenseConfigById2 = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(b);
			if (towerDefenseConfigById.Value.Difficulty != towerDefenseConfigById2.Value.Difficulty)
			{
				return towerDefenseConfigById.Value.Difficulty - towerDefenseConfigById2.Value.Difficulty;
			}
			return towerDefenseConfigById.Value.SortId - towerDefenseConfigById2.Value.SortId;
		}

		// Token: 0x06031ED1 RID: 204497 RVA: 0x00B94F58 File Offset: 0x00B93158
		private void OnClickSubLevel(int stageId)
		{
			if (stageId <= 0 || stageId == this.CurrentStageId)
			{
				return;
			}
			this.CurrentStageId = stageId;
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(stageId);
			int num = (towerDefenseConfigById != null) ? towerDefenseConfigById.Value.InstanceId : 0;
			InstanceDungeonEntranceModel.Instance.SelectInstanceId = num;
			TowerDefenseModel.Instance.SetLevelHasClickByInstanceId(num);
			if (this.LevelScroll != null)
			{
				foreach (TowerDefenseLevelItem towerDefenseLevelItem in this.LevelScroll.GetScrollItemList())
				{
					towerDefenseLevelItem.RefreshSelectionVisual();
					towerDefenseLevelItem.RefreshRedDot();
				}
			}
			TowerDefenseLevelDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.SetUiActive(true);
			}
			TowerDefenseLevelDetailPanel detailPanel2 = this.DetailPanel;
			if (detailPanel2 != null)
			{
				detailPanel2.RefreshItem(num);
			}
			this.RefreshBackground(stageId);
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.StopSequenceByKey("Switch", false, false);
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
		}

		// Token: 0x06031ED2 RID: 204498 RVA: 0x00B95074 File Offset: 0x00B93274
		private bool IsStageSelected(int stageId)
		{
			return stageId == this.CurrentStageId;
		}

		// Token: 0x06031ED3 RID: 204499 RVA: 0x00B95080 File Offset: 0x00B93280
		private void RefreshBackground(int stageId)
		{
			TowerDefenceInstance? towerDefenseConfigById = InstanceDungeonConfig.Instance.GetTowerDefenseConfigById(stageId);
			string text = (towerDefenseConfigById != null) ? (towerDefenseConfigById.Value.BgPath ?? "") : "";
			if (string.IsNullOrEmpty(text) || text == this.CurrentBgPath)
			{
				return;
			}
			this.CurrentBgPath = text;
			base.SetTextureByPath(text, base.GetTexture(0), null, null);
		}

		// Token: 0x06031ED4 RID: 204500 RVA: 0x00B950F8 File Offset: 0x00B932F8
		private void ScrollToTargetGroup(List<TowerDefenseGroupData> groups)
		{
			if (this.CurrentStageId <= 0)
			{
				return;
			}
			int num = groups.FindIndex((TowerDefenseGroupData group) => group.SubStageIds.Contains(this.CurrentStageId));
			if (num < 0)
			{
				return;
			}
			GenericScrollViewNew<TowerDefenseLevelItem, TowerDefenseGroupData> levelScroll = this.LevelScroll;
			UUIItem uuiitem = (levelScroll != null) ? levelScroll.GetItemByIndex(num) : null;
			if (uuiitem != null)
			{
				base.GetScrollViewWithScrollbar(2).ScrollToTopLater(uuiitem, false);
			}
		}

		// Token: 0x0401A9FB RID: 109051
		private const int MATCHING_ITEM_OFFSET = -98;

		// Token: 0x0401A9FC RID: 109052
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItemBase> Caption;

		// Token: 0x0401A9FD RID: 109053
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TowerDefenseLevelItem, TowerDefenseGroupData> LevelScroll;

		// Token: 0x0401A9FE RID: 109054
		[Nullable(2)]
		private TowerDefenseLevelDetailPanel DetailPanel;

		// Token: 0x0401A9FF RID: 109055
		[Nullable(2)]
		private TowerDefenseRewardEntranceItem PointsEntrance;

		// Token: 0x0401AA00 RID: 109056
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401AA01 RID: 109057
		[Nullable(2)]
		private InstanceDungeonMatchingCountDown MatchingCountDownItem;

		// Token: 0x0401AA02 RID: 109058
		private int CurrentStageId;

		// Token: 0x0401AA03 RID: 109059
		private string CurrentBgPath = "";

		// Token: 0x0200ACD1 RID: 44241
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04034814 RID: 215060
			public const int BgTex = 0;

			// Token: 0x04034815 RID: 215061
			public const int CaptionItem = 1;

			// Token: 0x04034816 RID: 215062
			public const int LevelScroll = 2;

			// Token: 0x04034817 RID: 215063
			public const int LevelItem = 3;

			// Token: 0x04034818 RID: 215064
			public const int PointsItem = 4;

			// Token: 0x04034819 RID: 215065
			public const int LevelDetailPnl = 5;
		}
	}
}
