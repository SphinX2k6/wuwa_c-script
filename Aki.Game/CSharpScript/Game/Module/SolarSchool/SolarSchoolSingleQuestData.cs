using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E3 RID: 22755
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolSingleQuestData
	{
		// Token: 0x06038143 RID: 229699 RVA: 0x00FAD0D4 File Offset: 0x00FAB2D4
		public SolarSchoolSingleQuestData(int questId)
		{
			this.QuestId = questId;
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(this.QuestId);
			if (quest == null)
			{
				return;
			}
			this.LogicType = quest.Value.LogicNodeType;
			this.QuestType = quest.Value.ShowType;
			this.UnlockConditionGroupId = quest.Value.PreConditionGroupId;
			this.ShowConditionGroupId = quest.Value.ShowConditionGroupId;
			this.BuildRewards(quest.Value);
		}

		// Token: 0x17006B8A RID: 27530
		// (get) Token: 0x06038144 RID: 229700 RVA: 0x00FAD180 File Offset: 0x00FAB380
		public ESolarSchoolQuestLogicType LogicType { get; }

		// Token: 0x17006B8B RID: 27531
		// (get) Token: 0x06038145 RID: 229701 RVA: 0x00FAD188 File Offset: 0x00FAB388
		public ESolarSchoolQuestShowType QuestType { get; }

		// Token: 0x17006B8C RID: 27532
		// (get) Token: 0x06038146 RID: 229702 RVA: 0x00FAD190 File Offset: 0x00FAB390
		public int QuestId { get; }

		// Token: 0x17006B8D RID: 27533
		// (get) Token: 0x06038147 RID: 229703 RVA: 0x00FAD198 File Offset: 0x00FAB398
		public int UnlockConditionGroupId { get; }

		// Token: 0x17006B8E RID: 27534
		// (get) Token: 0x06038148 RID: 229704 RVA: 0x00FAD1A0 File Offset: 0x00FAB3A0
		public int ShowConditionGroupId { get; }

		// Token: 0x17006B8F RID: 27535
		// (get) Token: 0x06038149 RID: 229705 RVA: 0x00FAD1A8 File Offset: 0x00FAB3A8
		public bool IsShowing
		{
			get
			{
				return this.ShowConditionGroupId <= 0 || ActivityConditionCenter.Instance.CheckGroup(this.ShowConditionGroupId);
			}
		}

		// Token: 0x17006B90 RID: 27536
		// (get) Token: 0x0603814A RID: 229706 RVA: 0x00FAD1C5 File Offset: 0x00FAB3C5
		// (set) Token: 0x0603814B RID: 229707 RVA: 0x00FAD1CD File Offset: 0x00FAB3CD
		public bool IsUnlocked { get; private set; }

		// Token: 0x17006B91 RID: 27537
		// (get) Token: 0x0603814C RID: 229708 RVA: 0x00FAD1D6 File Offset: 0x00FAB3D6
		public bool QuestFirstShow
		{
			get
			{
				return this.HasLocalRecord(ESolarSchoolLocalRecordType.QuestFirstShow);
			}
		}

		// Token: 0x17006B92 RID: 27538
		// (get) Token: 0x0603814D RID: 229709 RVA: 0x00FAD1DF File Offset: 0x00FAB3DF
		public bool QuestFirstUnlock
		{
			get
			{
				return this.HasLocalRecord(ESolarSchoolLocalRecordType.QuestFirstUnlock);
			}
		}

		// Token: 0x17006B93 RID: 27539
		// (get) Token: 0x0603814E RID: 229710 RVA: 0x00FAD1E8 File Offset: 0x00FAB3E8
		public bool QuestUnlockRedDot
		{
			get
			{
				return this.HasLocalRecord(ESolarSchoolLocalRecordType.QuestUnlockRedDot);
			}
		}

		// Token: 0x17006B94 RID: 27540
		// (get) Token: 0x0603814F RID: 229711 RVA: 0x00FAD1F1 File Offset: 0x00FAB3F1
		public bool ShouldShowQuestUnlockRedDot
		{
			get
			{
				return this.IsTree && this.InShowTime && this.IsUnlocked && this.IsShowing && !this.QuestUnlockRedDot;
			}
		}

		// Token: 0x17006B95 RID: 27541
		// (get) Token: 0x06038150 RID: 229712 RVA: 0x00FAD21E File Offset: 0x00FAB41E
		// (set) Token: 0x06038151 RID: 229713 RVA: 0x00FAD226 File Offset: 0x00FAB426
		public bool InShowTime { get; private set; }

		// Token: 0x17006B96 RID: 27542
		// (get) Token: 0x06038152 RID: 229714 RVA: 0x00FAD22F File Offset: 0x00FAB42F
		// (set) Token: 0x06038153 RID: 229715 RVA: 0x00FAD237 File Offset: 0x00FAB437
		public bool IsExpired { get; private set; }

		// Token: 0x17006B97 RID: 27543
		// (get) Token: 0x06038154 RID: 229716 RVA: 0x00FAD240 File Offset: 0x00FAB440
		// (set) Token: 0x06038155 RID: 229717 RVA: 0x00FAD248 File Offset: 0x00FAB448
		public bool ProgressRewarded { get; set; }

		// Token: 0x17006B98 RID: 27544
		// (get) Token: 0x06038156 RID: 229718 RVA: 0x00FAD251 File Offset: 0x00FAB451
		// (set) Token: 0x06038157 RID: 229719 RVA: 0x00FAD259 File Offset: 0x00FAB459
		public bool PendingSuccess { get; private set; }

		// Token: 0x06038158 RID: 229720 RVA: 0x00FAD262 File Offset: 0x00FAB462
		public bool ConsumePendingSuccess()
		{
			bool pendingSuccess = this.PendingSuccess;
			this.PendingSuccess = false;
			return pendingSuccess;
		}

		// Token: 0x06038159 RID: 229721 RVA: 0x00FAD271 File Offset: 0x00FAB471
		public void SetUnlocked(bool unlocked)
		{
			this.IsUnlocked = unlocked;
		}

		// Token: 0x0603815A RID: 229722 RVA: 0x00FAD27A File Offset: 0x00FAB47A
		public bool MarkQuestFirstShow()
		{
			return this.MarkLocalRecord(ESolarSchoolLocalRecordType.QuestFirstShow);
		}

		// Token: 0x0603815B RID: 229723 RVA: 0x00FAD283 File Offset: 0x00FAB483
		public bool MarkQuestFirstUnlock()
		{
			return this.MarkLocalRecord(ESolarSchoolLocalRecordType.QuestFirstUnlock);
		}

		// Token: 0x0603815C RID: 229724 RVA: 0x00FAD28C File Offset: 0x00FAB48C
		public bool MarkQuestUnlockRedDot()
		{
			if (this.QuestUnlockRedDot)
			{
				return true;
			}
			if (!this.MarkLocalRecord(ESolarSchoolLocalRecordType.QuestUnlockRedDot))
			{
				return false;
			}
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolQuestUnlockRedDotChanged, this.QuestId);
			return true;
		}

		// Token: 0x0603815D RID: 229725 RVA: 0x00FAD2BA File Offset: 0x00FAB4BA
		private bool HasLocalRecord(ESolarSchoolLocalRecordType recordType)
		{
			return SolarSchoolGamePlayModel.Instance.HasLocalRecord(recordType, this.QuestId);
		}

		// Token: 0x0603815E RID: 229726 RVA: 0x00FAD2CD File Offset: 0x00FAB4CD
		private bool MarkLocalRecord(ESolarSchoolLocalRecordType recordType)
		{
			return SolarSchoolGamePlayModel.Instance.MarkLocalRecord(recordType, this.QuestId);
		}

		// Token: 0x17006B99 RID: 27545
		// (get) Token: 0x0603815F RID: 229727 RVA: 0x00FAD2E0 File Offset: 0x00FAB4E0
		public bool IsTree
		{
			get
			{
				return this.LogicType == ESolarSchoolQuestLogicType.Tree;
			}
		}

		// Token: 0x17006B9A RID: 27546
		// (get) Token: 0x06038160 RID: 229728 RVA: 0x00FAD2EB File Offset: 0x00FAB4EB
		public bool IsAvailableShow
		{
			get
			{
				return this.IsUnlocked && this.InShowTime && this.IsShowing;
			}
		}

		// Token: 0x06038161 RID: 229729 RVA: 0x00FAD305 File Offset: 0x00FAB505
		[NullableContext(2)]
		public SolarSchoolQuestRewardData GetReward(int questRewardId)
		{
			return this.RewardMap.GetValueOrDefault(questRewardId);
		}

		// Token: 0x06038162 RID: 229730 RVA: 0x00FAD313 File Offset: 0x00FAB513
		public IReadOnlyCollection<SolarSchoolQuestRewardData> GetRewardList()
		{
			return this.RewardMap.Values;
		}

		// Token: 0x06038163 RID: 229731 RVA: 0x00FAD320 File Offset: 0x00FAB520
		public bool IsRewardFinished(int questRewardId)
		{
			SolarSchoolQuestRewardData reward = this.GetReward(questRewardId);
			return reward != null && reward.Rewarded;
		}

		// Token: 0x06038164 RID: 229732 RVA: 0x00FAD334 File Offset: 0x00FAB534
		private bool TryMarkRewardFinished(int questRewardId)
		{
			SolarSchoolQuestRewardData reward = this.GetReward(questRewardId);
			if (reward == null || reward.Rewarded)
			{
				return false;
			}
			reward.MarkRewarded();
			return true;
		}

		// Token: 0x06038165 RID: 229733 RVA: 0x00FAD360 File Offset: 0x00FAB560
		public int GetRewardProgress()
		{
			if (this.ProgressRewarded)
			{
				return this.GetTargetProgress();
			}
			int num = 0;
			foreach (SolarSchoolQuestRewardData solarSchoolQuestRewardData in this.RewardMap.Values)
			{
				if (solarSchoolQuestRewardData.Rewarded)
				{
					SolarSchoolQuestReward? solarSchoolQuestReward;
					num += ((SolarSchoolConfig.Instance.GetQuestReward(solarSchoolQuestRewardData.QuestRewardId) != null) ? solarSchoolQuestReward.GetValueOrDefault().RewardProgress : 0);
				}
			}
			return Math.Min(num, this.GetTargetProgress());
		}

		// Token: 0x06038166 RID: 229734 RVA: 0x00FAD408 File Offset: 0x00FAB608
		public int GetTargetProgress()
		{
			if (SolarSchoolConfig.Instance.GetQuest(this.QuestId) == null)
			{
				return 0;
			}
			SolarSchoolQuest? solarSchoolQuest;
			return solarSchoolQuest.GetValueOrDefault().TargetProgress;
		}

		// Token: 0x17006B9B RID: 27547
		// (get) Token: 0x06038167 RID: 229735 RVA: 0x00FAD440 File Offset: 0x00FAB640
		public int ItemRewardGroupId
		{
			get
			{
				if (SolarSchoolConfig.Instance.GetQuest(this.QuestId) == null)
				{
					return 0;
				}
				SolarSchoolQuest? solarSchoolQuest;
				return solarSchoolQuest.GetValueOrDefault().RewardItem;
			}
		}

		// Token: 0x06038168 RID: 229736 RVA: 0x00FAD478 File Offset: 0x00FAB678
		public bool IsItemRewardUnlocked()
		{
			return this.GetRewardProgress() >= this.GetTargetProgress();
		}

		// Token: 0x06038169 RID: 229737 RVA: 0x00FAD48B File Offset: 0x00FAB68B
		public bool CanClaimProgressReward()
		{
			return this.QuestType != ESolarSchoolQuestShowType.Important && this.IsTree && (this.InShowTime && this.IsUnlocked && !this.ProgressRewarded) && this.IsItemRewardUnlocked();
		}

		// Token: 0x0603816A RID: 229738 RVA: 0x00FAD4C0 File Offset: 0x00FAB6C0
		public void MarkProgressRewarded()
		{
			if (this.ProgressRewarded)
			{
				return;
			}
			this.ProgressRewarded = true;
			this.PendingSuccess = true;
		}

		// Token: 0x0603816B RID: 229739 RVA: 0x00FAD4DC File Offset: 0x00FAB6DC
		public unsafe void RestoreReward(int questRewardId, bool rewarded, int progress)
		{
			SolarSchoolQuestRewardData solarSchoolQuestRewardData;
			if (!this.RewardMap.TryGetValue(questRewardId, out solarSchoolQuestRewardData))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 奖励进度存档找不到对应奖励行，跳过";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", this.QuestId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("questRewardId", questRewardId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			solarSchoolQuestRewardData.Restore(rewarded, progress);
		}

		// Token: 0x0603816C RID: 229740 RVA: 0x00FAD568 File Offset: 0x00FAB768
		public int RebuildRewardListeners()
		{
			int num = 0;
			foreach (SolarSchoolQuestRewardData solarSchoolQuestRewardData in this.RewardMap.Values)
			{
				if (!solarSchoolQuestRewardData.Rewarded && !solarSchoolQuestRewardData.IsListening() && this.TryStartRewardListening(solarSchoolQuestRewardData))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x0603816D RID: 229741 RVA: 0x00FAD5DC File Offset: 0x00FAB7DC
		public void StopRewardListeners()
		{
			foreach (SolarSchoolQuestRewardData solarSchoolQuestRewardData in this.RewardMap.Values)
			{
				solarSchoolQuestRewardData.StopListening();
			}
		}

		// Token: 0x0603816E RID: 229742 RVA: 0x00FAD634 File Offset: 0x00FAB834
		public void ResetAllRewardProgress()
		{
			foreach (SolarSchoolQuestRewardData solarSchoolQuestRewardData in this.RewardMap.Values)
			{
				solarSchoolQuestRewardData.ResetProgress();
			}
			this.ProgressRewarded = false;
			this.PendingSuccess = false;
		}

		// Token: 0x0603816F RID: 229743 RVA: 0x00FAD698 File Offset: 0x00FAB898
		private bool TryStartRewardListening(SolarSchoolQuestRewardData reward)
		{
			return reward.TryStartListening(delegate
			{
				this.OnRewardReached(reward);
			});
		}

		// Token: 0x06038170 RID: 229744 RVA: 0x00FAD6D0 File Offset: 0x00FAB8D0
		private unsafe void OnRewardReached(SolarSchoolQuestRewardData reward)
		{
			reward.StopListening();
			bool flag = this.IsItemRewardUnlocked();
			if (!this.TryMarkRewardFinished(reward.QuestRewardId))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 任务奖励条件达成";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("questId", this.QuestId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("questRewardId", reward.QuestRewardId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("conditionId", reward.ConditionId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("进度", this.GetRewardProgress());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("目标", this.GetTargetProgress());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolQuestProgressChanged, this.QuestId);
			SolarSchoolQuestReward? solarSchoolQuestReward;
			SolarSchoolGamePlayModel.Instance.EnqueueRewardTip(ESolarSchoolRewardTipType.QuestRewardDone, reward.QuestRewardId, (SolarSchoolConfig.Instance.GetQuestReward(reward.QuestRewardId) != null) ? solarSchoolQuestReward.GetValueOrDefault().RewardProgress : 0);
			if (!flag && this.CanClaimProgressReward())
			{
				SolarSchoolController.Instance.EnqueueCompleteQuest(this.QuestId);
				SolarSchoolGamePlayModel.Instance.EnqueueQuestDoneTip(this.QuestId);
				SolarSchoolGamePlayModel.Instance.LogReporter.ReportQuest(this.QuestId, ESolarSchoolQuestLogResultType.Complete);
			}
		}

		// Token: 0x06038171 RID: 229745 RVA: 0x00FAD85D File Offset: 0x00FABA5D
		public IReadOnlyCollection<SolarSchoolQuestNodeData> GetNodeList()
		{
			return this.NodeMap.Values;
		}

		// Token: 0x06038172 RID: 229746 RVA: 0x00FAD86A File Offset: 0x00FABA6A
		[NullableContext(2)]
		public SolarSchoolQuestNodeData GetNode(int nodeId)
		{
			return this.NodeMap.GetValueOrDefault(nodeId);
		}

		// Token: 0x06038173 RID: 229747 RVA: 0x00FAD878 File Offset: 0x00FABA78
		public unsafe void BuildNodes(IReadOnlyDictionary<int, List<int>> childMap, Dictionary<int, SolarSchoolQuestNodeData> nodeIndex)
		{
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(this.QuestId);
			if (quest == null)
			{
				return;
			}
			Queue<int> queue = new Queue<int>(4);
			foreach (int element in quest.Value.GetQuestNodeListArray())
			{
				queue.Push(element);
			}
			while (queue.Size > 0)
			{
				int num = queue.Pop();
				if (!this.NodeMap.ContainsKey(num))
				{
					SolarSchoolQuestNodeData solarSchoolQuestNodeData;
					if (nodeIndex.TryGetValue(num, out solarSchoolQuestNodeData))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.LRC;
						string message = "[SolarSchool] QuestNode 归属重复：同一节点被多个 Quest 引用，只归先建的那个";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("questId", this.QuestId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("已归属questId", solarSchoolQuestNodeData.QuestId);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					else if (SolarSchoolConfig.Instance.GetQuestNode(num) == null)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.SolarSchool;
						ELogAuthor author2 = ELogAuthor.LRC;
						string message2 = "[SolarSchool] QuestNode 配表缺失，跳过";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("nodeId", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("questId", this.QuestId);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
					}
					else
					{
						SolarSchoolQuestNodeData value = new SolarSchoolQuestNodeData(num, this.QuestId);
						this.NodeMap[num] = value;
						nodeIndex[num] = value;
						List<int> list;
						if (childMap.TryGetValue(num, out list))
						{
							foreach (int element2 in list)
							{
								queue.Push(element2);
							}
						}
					}
				}
			}
		}

		// Token: 0x06038174 RID: 229748 RVA: 0x00FADA9C File Offset: 0x00FABC9C
		public int RebuildNodeListeners()
		{
			int num = 0;
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in this.NodeMap.Values)
			{
				if (!solarSchoolQuestNodeData.Completed && !solarSchoolQuestNodeData.IsPending)
				{
					int preNodeId = solarSchoolQuestNodeData.PreNodeId;
					if (preNodeId != 0)
					{
						SolarSchoolQuestNodeData node = this.GetNode(preNodeId);
						if (node == null || !node.Completed)
						{
							continue;
						}
					}
					if (this.TryStartNodeListening(solarSchoolQuestNodeData))
					{
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06038175 RID: 229749 RVA: 0x00FADB2C File Offset: 0x00FABD2C
		public void StopNodeListeners()
		{
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in this.NodeMap.Values)
			{
				solarSchoolQuestNodeData.StopListening();
			}
		}

		// Token: 0x06038176 RID: 229750 RVA: 0x00FADB84 File Offset: 0x00FABD84
		public void ResetAllNodeProgress()
		{
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in this.NodeMap.Values)
			{
				solarSchoolQuestNodeData.ResetProgress();
				questData.RemovePendingNode(solarSchoolQuestNodeData.NodeId);
			}
		}

		// Token: 0x06038177 RID: 229751 RVA: 0x00FADBF4 File Offset: 0x00FABDF4
		public void ClearPendingNodes()
		{
			SolarSchoolQuestData questData = SolarSchoolGamePlayModel.Instance.QuestData;
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in this.NodeMap.Values)
			{
				if (!solarSchoolQuestNodeData.IsActionRunning)
				{
					questData.RemovePendingNode(solarSchoolQuestNodeData.NodeId);
				}
			}
		}

		// Token: 0x06038178 RID: 229752 RVA: 0x00FADC64 File Offset: 0x00FABE64
		public void StartNextNodeListeners(int preNodeId)
		{
			foreach (SolarSchoolQuestNodeData solarSchoolQuestNodeData in this.NodeMap.Values)
			{
				if (solarSchoolQuestNodeData.PreNodeId == preNodeId)
				{
					this.TryStartNodeListening(solarSchoolQuestNodeData);
				}
			}
		}

		// Token: 0x06038179 RID: 229753 RVA: 0x00FADCC8 File Offset: 0x00FABEC8
		private bool TryStartNodeListening(SolarSchoolQuestNodeData node)
		{
			return node.TryStartListening(delegate
			{
				this.OnNodeHit(node);
			});
		}

		// Token: 0x0603817A RID: 229754 RVA: 0x00FADD00 File Offset: 0x00FABF00
		private unsafe void OnNodeHit(SolarSchoolQuestNodeData node)
		{
			node.StopListening();
			SolarSchoolGamePlayModel.Instance.QuestData.AddPendingNode(node.NodeId);
			SolarSchoolQuestNode? questNode = SolarSchoolConfig.Instance.GetQuestNode(node.NodeId);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] QuestNode 命中 → 进 pending";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("nodeId", node.NodeId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("questId", this.QuestId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("actionId", (questNode != null) ? questNode.GetValueOrDefault().ActionId : 0);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("timing", node.TriggerTiming);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("triggerParam", (questNode != null) ? questNode.GetValueOrDefault().TriggerParam : 0);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			SolarSchoolQuestCenter.Instance.TryDeliverPending();
		}

		// Token: 0x0603817B RID: 229755 RVA: 0x00FADE40 File Offset: 0x00FAC040
		private void BuildRewards(SolarSchoolQuest quest)
		{
			foreach (int num in quest.GetQuestRewardListArray())
			{
				if (!this.RewardMap.ContainsKey(num))
				{
					this.RewardMap[num] = new SolarSchoolQuestRewardData(num);
				}
			}
		}

		// Token: 0x0603817C RID: 229756 RVA: 0x00FADE88 File Offset: 0x00FAC088
		public void RefreshState(int dayIndex)
		{
			bool shouldShowQuestUnlockRedDot = this.ShouldShowQuestUnlockRedDot;
			this.RefreshTimeState(dayIndex);
			if (!this.StateRefreshed || shouldShowQuestUnlockRedDot != this.ShouldShowQuestUnlockRedDot)
			{
				this.StateRefreshed = true;
				EventSystem.Instance.Emit<int>(EEventName.SolarSchoolQuestUnlockRedDotChanged, this.QuestId);
			}
		}

		// Token: 0x0603817D RID: 229757 RVA: 0x00FADED4 File Offset: 0x00FAC0D4
		private void RefreshTimeState(int dayIndex)
		{
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(this.QuestId);
			if (quest == null)
			{
				this.InShowTime = false;
				this.IsExpired = false;
				return;
			}
			this.InShowTime = ((quest.Value.StartDayIndex <= 0 || dayIndex >= quest.Value.StartDayIndex) && (quest.Value.EndDayIndex <= 0 || dayIndex <= quest.Value.EndDayIndex));
			this.IsExpired = this.WillExpireAt(dayIndex);
		}

		// Token: 0x0603817E RID: 229758 RVA: 0x00FADF70 File Offset: 0x00FAC170
		public bool WillExpireAt(int dayIndex)
		{
			SolarSchoolQuest? quest = SolarSchoolConfig.Instance.GetQuest(this.QuestId);
			return quest != null && quest.Value.EndDayIndex > 0 && dayIndex > quest.Value.EndDayIndex;
		}

		// Token: 0x0401D8C8 RID: 121032
		private readonly Dictionary<int, SolarSchoolQuestRewardData> RewardMap = new Dictionary<int, SolarSchoolQuestRewardData>();

		// Token: 0x0401D8C9 RID: 121033
		private readonly Dictionary<int, SolarSchoolQuestNodeData> NodeMap = new Dictionary<int, SolarSchoolQuestNodeData>();

		// Token: 0x0401D8D2 RID: 121042
		private bool StateRefreshed;
	}
}
