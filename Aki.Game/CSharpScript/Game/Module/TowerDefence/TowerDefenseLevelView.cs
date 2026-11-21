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
	// Token: 0x02003AF9 RID: 15097
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseLevelView : UiTickViewBase
	{
		// Token: 0x06026C52 RID: 158802 RVA: 0x00AD8909 File Offset: 0x00AD6B09
		public TowerDefenseLevelView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026C53 RID: 158803 RVA: 0x00AD8920 File Offset: 0x00AD6B20
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

		// Token: 0x06026C54 RID: 158804 RVA: 0x00AD8A0D File Offset: 0x00AD6C0D
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Add(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06026C55 RID: 158805 RVA: 0x00AD8A47 File Offset: 0x00AD6C47
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
			EventSystem.Instance.Remove(EEventName.OnMatchingBegin, new Action(this.OnMatchingBegin));
		}

		// Token: 0x06026C56 RID: 158806 RVA: 0x00AD8A84 File Offset: 0x00AD6C84
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseLevelView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseLevelView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026C57 RID: 158807 RVA: 0x00AD8AC7 File Offset: 0x00AD6CC7
		private void OnClickBackBtn()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026C58 RID: 158808 RVA: 0x00AD8AD0 File Offset: 0x00AD6CD0
		protected override void OnBeforeShow()
		{
			TowerDefenseRewardEntranceItem pointsEntrance = this.PointsEntrance;
			if (pointsEntrance == null)
			{
				return;
			}
			pointsEntrance.RefreshItem();
		}

		// Token: 0x06026C59 RID: 158809 RVA: 0x00AD8AE4 File Offset: 0x00AD6CE4
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

		// Token: 0x06026C5A RID: 158810 RVA: 0x00AD8B60 File Offset: 0x00AD6D60
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

		// Token: 0x06026C5B RID: 158811 RVA: 0x00AD8BCC File Offset: 0x00AD6DCC
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

		// Token: 0x06026C5C RID: 158812 RVA: 0x00AD8CF2 File Offset: 0x00AD6EF2
		private void BeginMatching()
		{
			this.MatchingCountDownItem.SetMatchingTime(0);
			this.MatchingCountDownItem.StartTimer();
		}

		// Token: 0x06026C5D RID: 158813 RVA: 0x00AD8D0C File Offset: 0x00AD6F0C
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

		// Token: 0x06026C5E RID: 158814 RVA: 0x00AD8D68 File Offset: 0x00AD6F68
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

		// Token: 0x06026C5F RID: 158815 RVA: 0x00AD8DC8 File Offset: 0x00AD6FC8
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

		// Token: 0x06026C60 RID: 158816 RVA: 0x00AD8F40 File Offset: 0x00AD7140
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

		// Token: 0x06026C61 RID: 158817 RVA: 0x00AD8FC4 File Offset: 0x00AD71C4
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

		// Token: 0x06026C62 RID: 158818 RVA: 0x00AD90E0 File Offset: 0x00AD72E0
		private bool IsStageSelected(int stageId)
		{
			return stageId == this.CurrentStageId;
		}

		// Token: 0x06026C63 RID: 158819 RVA: 0x00AD90EC File Offset: 0x00AD72EC
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

		// Token: 0x06026C64 RID: 158820 RVA: 0x00AD9164 File Offset: 0x00AD7364
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

		// Token: 0x0401534D RID: 86861
		private const int MATCHING_ITEM_OFFSET = -98;

		// Token: 0x0401534E RID: 86862
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TabComponentWithCaptionItem<CommonTabItemBase> Caption;

		// Token: 0x0401534F RID: 86863
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TowerDefenseLevelItem, TowerDefenseGroupData> LevelScroll;

		// Token: 0x04015350 RID: 86864
		[Nullable(2)]
		private TowerDefenseLevelDetailPanel DetailPanel;

		// Token: 0x04015351 RID: 86865
		[Nullable(2)]
		private TowerDefenseRewardEntranceItem PointsEntrance;

		// Token: 0x04015352 RID: 86866
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04015353 RID: 86867
		[Nullable(2)]
		private InstanceDungeonMatchingCountDown MatchingCountDownItem;

		// Token: 0x04015354 RID: 86868
		private int CurrentStageId;

		// Token: 0x04015355 RID: 86869
		private string CurrentBgPath = "";

		// Token: 0x020096F1 RID: 38641
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F1C4 RID: 192964
			public const int BgTex = 0;

			// Token: 0x0402F1C5 RID: 192965
			public const int CaptionItem = 1;

			// Token: 0x0402F1C6 RID: 192966
			public const int LevelScroll = 2;

			// Token: 0x0402F1C7 RID: 192967
			public const int LevelItem = 3;

			// Token: 0x0402F1C8 RID: 192968
			public const int PointsItem = 4;

			// Token: 0x0402F1C9 RID: 192969
			public const int LevelDetailPnl = 5;
		}
	}
}
