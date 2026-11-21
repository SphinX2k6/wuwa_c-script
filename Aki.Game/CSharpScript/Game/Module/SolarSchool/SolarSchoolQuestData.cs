using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058D8 RID: 22744
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolQuestData : SolarSchoolRecordBase
	{
		// Token: 0x17006B6E RID: 27502
		// (get) Token: 0x06038055 RID: 229461 RVA: 0x00FA9147 File Offset: 0x00FA7347
		// (set) Token: 0x06038056 RID: 229462 RVA: 0x00FA914F File Offset: 0x00FA734F
		[Nullable(2)]
		public IReadOnlyList<int> LastPresentedInfoQuestIds { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x06038057 RID: 229463 RVA: 0x00FA9158 File Offset: 0x00FA7358
		public IReadOnlyList<int> GetInfoQuestIds()
		{
			List<int> showingQuestIdList = this.GetShowingQuestIdList();
			List<int> list = new List<int>();
			int num = 0;
			while (num < showingQuestIdList.Count && num < 2)
			{
				list.Add(showingQuestIdList[num]);
				num++;
			}
			return list;
		}

		// Token: 0x06038058 RID: 229464 RVA: 0x00FA9195 File Offset: 0x00FA7395
		public void CachePresentedInfoQuestIds(IReadOnlyList<int> questIds)
		{
			this.LastPresentedInfoQuestIds = new List<int>(questIds);
		}

		// Token: 0x06038059 RID: 229465 RVA: 0x00FA91A4 File Offset: 0x00FA73A4
		public void ResetInfoPresentation()
		{
			this.LastPresentedInfoQuestIds = null;
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in this.QuestMap.Values)
			{
				solarSchoolSingleQuestData.ConsumePendingSuccess();
			}
		}

		// Token: 0x0603805A RID: 229466 RVA: 0x00FA9204 File Offset: 0x00FA7404
		public bool IsQuestActive(int questId)
		{
			return this.ActiveQuestSet.Contains(questId);
		}

		// Token: 0x0603805B RID: 229467 RVA: 0x00FA9212 File Offset: 0x00FA7412
		public void SetQuestActive(int questId, bool notify = true)
		{
			bool flag = this.ActiveQuestSet.Add(questId);
			SolarSchoolSingleQuestData questData = this.GetQuestData(questId);
			if (questData != null)
			{
				questData.SetUnlocked(true);
			}
			if (flag && notify)
			{
				EventSystem.Instance.Emit<int>(EEventName.SolarSchoolQuestUnlocked, questId);
			}
		}

		// Token: 0x0603805C RID: 229468 RVA: 0x00FA9248 File Offset: 0x00FA7448
		public void SetQuestInactive(int questId)
		{
			this.ActiveQuestSet.Remove(questId);
			SolarSchoolSingleQuestData questData = this.GetQuestData(questId);
			if (questData == null)
			{
				return;
			}
			questData.SetUnlocked(false);
		}

		// Token: 0x0603805D RID: 229469 RVA: 0x00FA9269 File Offset: 0x00FA7469
		public IReadOnlyCollection<int> GetActiveQuests()
		{
			return this.ActiveQuestSet;
		}

		// Token: 0x0603805E RID: 229470 RVA: 0x00FA9274 File Offset: 0x00FA7474
		public List<int> GetShowingQuestIdList()
		{
			List<int> list = new List<int>();
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in this.QuestMap.Values)
			{
				if (solarSchoolSingleQuestData.IsAvailableShow && solarSchoolSingleQuestData.IsTree)
				{
					list.Add(solarSchoolSingleQuestData.QuestId);
				}
			}
			this.SortByShowPriority(list);
			return list;
		}

		// Token: 0x0603805F RID: 229471 RVA: 0x00FA92F0 File Offset: 0x00FA74F0
		public List<int> GetUnfinishedShowingQuestIdList()
		{
			List<int> list = new List<int>();
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in this.QuestMap.Values)
			{
				if (solarSchoolSingleQuestData.IsAvailableShow && !solarSchoolSingleQuestData.ProgressRewarded && solarSchoolSingleQuestData.IsTree)
				{
					list.Add(solarSchoolSingleQuestData.QuestId);
				}
			}
			this.SortByShowPriority(list);
			return list;
		}

		// Token: 0x06038060 RID: 229472 RVA: 0x00FA9374 File Offset: 0x00FA7574
		private void SortByShowPriority(List<int> questIdList)
		{
			questIdList.Sort(delegate(int a, int b)
			{
				SolarSchoolSingleQuestData questData = this.GetQuestData(a);
				bool flag = questData != null && questData.QuestType == ESolarSchoolQuestShowType.Important;
				SolarSchoolSingleQuestData questData2 = this.GetQuestData(b);
				bool value = questData2 != null && questData2.QuestType == ESolarSchoolQuestShowType.Important;
				int num = flag.CompareTo(value);
				if (num != 0)
				{
					return num;
				}
				num = this.GetShowRank(a).CompareTo(this.GetShowRank(b));
				if (num != 0)
				{
					return num;
				}
				SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(a);
				int value2 = (quest != null) ? quest.GetValueOrDefault().Sort : 0;
				quest = SolarSchoolConfig.Instance.GetQuest(b);
				num = ((quest != null) ? quest.GetValueOrDefault().Sort : 0).CompareTo(value2);
				if (num == 0)
				{
					return a.CompareTo(b);
				}
				return num;
			});
		}

		// Token: 0x06038061 RID: 229473 RVA: 0x00FA9388 File Offset: 0x00FA7588
		private int GetShowRank(int questId)
		{
			SolarSchoolSingleQuestData questData = this.GetQuestData(questId);
			if (questData == null)
			{
				return int.MaxValue;
			}
			if (questData.CanClaimProgressReward())
			{
				return 0;
			}
			if (!questData.ProgressRewarded)
			{
				return 1;
			}
			return 2;
		}

		// Token: 0x06038062 RID: 229474 RVA: 0x00FA93BC File Offset: 0x00FA75BC
		protected override void OnInit(int activityId)
		{
			Dictionary<int, List<int>> childMap = this.BuildChildMap(activityId);
			foreach (SolarSchoolQuest solarSchoolQuest in SolarSchoolConfig.Instance.GetQuestListByActivityId(activityId))
			{
				if (!this.QuestMap.ContainsKey(solarSchoolQuest.Id))
				{
					this.QuestMap[solarSchoolQuest.Id] = new SolarSchoolSingleQuestData(solarSchoolQuest.Id);
				}
				this.QuestMap[solarSchoolQuest.Id].BuildNodes(childMap, this.NodeIndex);
			}
		}

		// Token: 0x06038063 RID: 229475 RVA: 0x00FA9460 File Offset: 0x00FA7660
		private Dictionary<int, List<int>> BuildChildMap(int activityId)
		{
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (SolarSchoolQuestNode solarSchoolQuestNode in SolarSchoolConfig.Instance.GetQuestNodeListByActivityId(activityId))
			{
				if (solarSchoolQuestNode.PreNodeId != 0)
				{
					List<int> list;
					if (!dictionary.TryGetValue(solarSchoolQuestNode.PreNodeId, out list))
					{
						list = new List<int>();
						dictionary[solarSchoolQuestNode.PreNodeId] = list;
					}
					list.Add(solarSchoolQuestNode.Id);
				}
			}
			return dictionary;
		}

		// Token: 0x06038064 RID: 229476 RVA: 0x00FA94F0 File Offset: 0x00FA76F0
		[NullableContext(2)]
		public SolarSchoolSingleQuestData GetQuestData(int questId)
		{
			return this.QuestMap.GetValueOrDefault(questId);
		}

		// Token: 0x06038065 RID: 229477 RVA: 0x00FA94FE File Offset: 0x00FA76FE
		public IReadOnlyCollection<SolarSchoolSingleQuestData> GetQuestDataList()
		{
			return this.QuestMap.Values;
		}

		// Token: 0x06038066 RID: 229478 RVA: 0x00FA950B File Offset: 0x00FA770B
		[NullableContext(2)]
		public SolarSchoolQuestNodeData GetNodeData(int nodeId)
		{
			return this.NodeIndex.GetValueOrDefault(nodeId);
		}

		// Token: 0x06038067 RID: 229479 RVA: 0x00FA951C File Offset: 0x00FA771C
		public void RefreshAllState()
		{
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.DayIndex;
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in this.QuestMap.Values)
			{
				if (solarSchoolSingleQuestData.WillExpireAt(dayIndex))
				{
					this.TryClaimProgressReward(solarSchoolSingleQuestData.QuestId);
				}
				solarSchoolSingleQuestData.RefreshState(dayIndex);
			}
		}

		// Token: 0x06038068 RID: 229480 RVA: 0x00FA959C File Offset: 0x00FA779C
		public bool TryClaimProgressReward(int questId)
		{
			SolarSchoolSingleQuestData questData = this.GetQuestData(questId);
			if (questData == null || !questData.CanClaimProgressReward())
			{
				return false;
			}
			int itemRewardGroupId = questData.ItemRewardGroupId;
			if (itemRewardGroupId <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 任务进度已满但没配总奖励，检查 SolarSchoolQuest.RewardItem";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", questId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (!SolarSchoolRewardCenter.Instance.TryGiveReward(itemRewardGroupId))
			{
				return false;
			}
			questData.MarkProgressRewarded();
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolQuestRewardClaimed, questId);
			return true;
		}

		// Token: 0x06038069 RID: 229481 RVA: 0x00FA9621 File Offset: 0x00FA7821
		public IReadOnlyList<int> GetPendingNodes()
		{
			return this.PendingNodeList;
		}

		// Token: 0x0603806A RID: 229482 RVA: 0x00FA9629 File Offset: 0x00FA7829
		public bool IsNodePending(int nodeId)
		{
			return this.PendingNodeList.Contains(nodeId);
		}

		// Token: 0x0603806B RID: 229483 RVA: 0x00FA9637 File Offset: 0x00FA7837
		public void AddPendingNode(int nodeId)
		{
			if (!this.PendingNodeList.Contains(nodeId))
			{
				this.PendingNodeList.Add(nodeId);
			}
		}

		// Token: 0x0603806C RID: 229484 RVA: 0x00FA9653 File Offset: 0x00FA7853
		public void RemovePendingNode(int nodeId)
		{
			this.PendingNodeList.Remove(nodeId);
		}

		// Token: 0x0603806D RID: 229485 RVA: 0x00FA9662 File Offset: 0x00FA7862
		public bool IsLocationTriggeredToday(int locationId)
		{
			return this.TriggeredTodayLocationSet.Contains(locationId);
		}

		// Token: 0x0603806E RID: 229486 RVA: 0x00FA9670 File Offset: 0x00FA7870
		public void MarkLocationTriggeredToday(int locationId)
		{
			this.TriggeredTodayLocationSet.Add(locationId);
		}

		// Token: 0x0603806F RID: 229487 RVA: 0x00FA967F File Offset: 0x00FA787F
		public void ClearDaily()
		{
			this.TriggeredTodayLocationSet.Clear();
		}

		// Token: 0x06038070 RID: 229488 RVA: 0x00FA968C File Offset: 0x00FA788C
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolQuestDataPb solarSchoolQuestDataPb = SolarSchoolQuestDataPb.Create();
			foreach (int questId in this.ActiveQuestSet)
			{
				SolarSchoolOneQuestPb solarSchoolOneQuestPb = SolarSchoolOneQuestPb.Create();
				solarSchoolOneQuestPb.QuestId = questId;
				SolarSchoolSingleQuestData questData = this.GetQuestData(questId);
				if (questData != null)
				{
					foreach (SolarSchoolQuestRewardData solarSchoolQuestRewardData in questData.GetRewardList())
					{
						SolarSchoolOneQuestRewardPb solarSchoolOneQuestRewardPb = SolarSchoolOneQuestRewardPb.Create();
						solarSchoolOneQuestRewardPb.QuestRewardId = solarSchoolQuestRewardData.QuestRewardId;
						solarSchoolOneQuestRewardPb.Progress = solarSchoolQuestRewardData.GetSaveProgress();
						solarSchoolOneQuestRewardPb.Rewarded = solarSchoolQuestRewardData.Rewarded;
						solarSchoolOneQuestPb.QuestReward.Add(solarSchoolOneQuestRewardPb);
					}
				}
				solarSchoolQuestDataPb.QuestList.Add(solarSchoolOneQuestPb);
			}
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in this.QuestMap.Values)
			{
				if (solarSchoolSingleQuestData.ProgressRewarded)
				{
					SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(solarSchoolSingleQuestData.QuestId);
					if (quest != null)
					{
						solarSchoolQuestDataPb.RewardedSolarSchoolQuestBit = SolarSchoolUtils.SetSaveBit(solarSchoolQuestDataPb.RewardedSolarSchoolQuestBit, quest.Value.BitFlag);
					}
				}
				foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in solarSchoolSingleQuestData.GetNodeList())
				{
					if (solarSchoolQuestNodeData.Completed)
					{
						SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(solarSchoolQuestNodeData.NodeId);
						if (questNode != null)
						{
							SolarSchoolUtils.SetSaveBit(solarSchoolQuestDataPb.CompletedNodeBit, questNode.Value.BitFlag);
						}
					}
				}
			}
			solarSchoolQuestDataPb.PendingNodeId.AddRange(this.PendingNodeList);
			gameData.Quest = solarSchoolQuestDataPb;
		}

		// Token: 0x06038071 RID: 229489 RVA: 0x00FA98A8 File Offset: 0x00FA7AA8
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.LastPresentedInfoQuestIds = null;
			this.ActiveQuestSet.Clear();
			this.PendingNodeList.Clear();
			this.TriggeredTodayLocationSet.Clear();
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in this.NodeIndex.Values)
			{
				solarSchoolQuestNodeData.ResetProgress();
			}
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData in this.QuestMap.Values)
			{
				solarSchoolSingleQuestData.SetUnlocked(false);
				solarSchoolSingleQuestData.ResetAllRewardProgress();
			}
			if (gameData.Quest == null)
			{
				return;
			}
			foreach (SolarSchoolOneQuestPb solarSchoolOneQuestPb in gameData.Quest.QuestList)
			{
				SolarSchoolSingleQuestData questData = this.GetQuestData(solarSchoolOneQuestPb.QuestId);
				if (questData == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 任务存档找不到对应任务，跳过奖励还原";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", solarSchoolOneQuestPb.QuestId);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.SetQuestActive(solarSchoolOneQuestPb.QuestId, false);
					foreach (SolarSchoolOneQuestRewardPb solarSchoolOneQuestRewardPb in solarSchoolOneQuestPb.QuestReward)
					{
						questData.RestoreReward(solarSchoolOneQuestRewardPb.QuestRewardId, solarSchoolOneQuestRewardPb.Rewarded, solarSchoolOneQuestRewardPb.Progress);
					}
				}
			}
			foreach (SolarSchoolSingleQuestData solarSchoolSingleQuestData2 in this.QuestMap.Values)
			{
				SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(solarSchoolSingleQuestData2.QuestId);
				if (quest != null)
				{
					solarSchoolSingleQuestData2.ProgressRewarded = SolarSchoolUtils.GetSaveBit(gameData.Quest.RewardedSolarSchoolQuestBit, quest.Value.BitFlag);
				}
			}
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData2 in this.NodeIndex.Values)
			{
				SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(solarSchoolQuestNodeData2.NodeId);
				if (questNode != null)
				{
					solarSchoolQuestNodeData2.RestoreCompleted(SolarSchoolUtils.GetSaveBit(gameData.Quest.CompletedNodeBit, questNode.Value.BitFlag));
				}
			}
			this.PendingNodeList.AddRange(gameData.Quest.PendingNodeId);
		}

		// Token: 0x0401D898 RID: 120984
		private readonly HashSet<int> ActiveQuestSet = new HashSet<int>();

		// Token: 0x0401D899 RID: 120985
		private readonly Dictionary<int, SolarSchoolSingleQuestData> QuestMap = new Dictionary<int, SolarSchoolSingleQuestData>();

		// Token: 0x0401D89A RID: 120986
		private readonly Dictionary<int, SolarSchoolQuestNodeData> NodeIndex = new Dictionary<int, SolarSchoolQuestNodeData>();

		// Token: 0x0401D89B RID: 120987
		private readonly List<int> PendingNodeList = new List<int>();

		// Token: 0x0401D89C RID: 120988
		private readonly HashSet<int> TriggeredTodayLocationSet = new HashSet<int>();
	}
}
