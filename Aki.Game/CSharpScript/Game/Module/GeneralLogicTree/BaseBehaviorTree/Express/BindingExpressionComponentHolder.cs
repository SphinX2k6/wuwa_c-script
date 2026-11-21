using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using UnrealEngine;

namespace CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express
{
	// Token: 0x020049C7 RID: 18887
	[NullableContext(1)]
	[Nullable(0)]
	public class BindingExpressionComponentHolder
	{
		// Token: 0x0602F4A3 RID: 193699 RVA: 0x00D30CD8 File Offset: 0x00D2EED8
		public BindingExpressionComponentHolder(Blackboard Blackboard)
		{
		}

		// Token: 0x0602F4A4 RID: 193700 RVA: 0x00D30D3F File Offset: 0x00D2EF3F
		public void Init()
		{
			this.WatchingList.Clear();
			this.AddEvents();
			this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "BindingExpressionComponentHolder", ETickingGroup.TG_PrePhysics, false, 0, false);
		}

		// Token: 0x0602F4A5 RID: 193701 RVA: 0x00D30D78 File Offset: 0x00D2EF78
		public void Destroy()
		{
			this.BindingExpressions.Clear();
			this.WatchingList.Clear();
			this.BindingMapTrackDataCache.Clear();
			this.DefaultMapTrackMarkIds.Clear();
			this.DefaultMapTrackData.Clear();
			this.DefaultTrackPosCache.Clear();
			this.LevelPlayIdToQuestNodeId.Clear();
			this.RemoveEvents();
			if (this.Ticker != null)
			{
				TickSystem.Instance.Remove(this.Ticker.Id);
				this.Ticker = null;
			}
			Dictionary<int, HashSet<int>> everBoundLevelPlayIds = LevelPlayModel.Instance.EverBoundLevelPlayIds;
			HashSet<int> hashSet;
			if (everBoundLevelPlayIds != null && everBoundLevelPlayIds.TryGetValue(this.<Blackboard>P.TreeConfigId, out hashSet))
			{
				hashSet.Clear();
			}
		}

		// Token: 0x0602F4A6 RID: 193702 RVA: 0x00D30E28 File Offset: 0x00D2F028
		public void AddBindingExpression(int nodeId, int levelPlayConfigId)
		{
			this.LevelPlayIdToQuestNodeId[levelPlayConfigId] = nodeId;
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, levelPlayConfigId);
			bool flag;
			if (behaviorTreeByConfigId == null)
			{
				flag = true;
			}
			else
			{
				BehaviorTreeExpressionComponent expression = behaviorTreeByConfigId.Expression;
				flag = !((expression != null) ? new bool?(expression.IsValid) : null).GetValueOrDefault();
			}
			if (flag)
			{
				return;
			}
			Dictionary<int, HashSet<int>> everBoundLevelPlayIds = LevelPlayModel.Instance.EverBoundLevelPlayIds;
			if (everBoundLevelPlayIds != null)
			{
				HashSet<int> hashSet;
				if (!everBoundLevelPlayIds.TryGetValue(this.<Blackboard>P.TreeConfigId, out hashSet))
				{
					hashSet = (everBoundLevelPlayIds[this.<Blackboard>P.TreeConfigId] = new HashSet<int>());
				}
				hashSet.Add(levelPlayConfigId);
			}
			behaviorTreeByConfigId.SetTrack(false, ESetTrackReason.None);
			behaviorTreeByConfigId.Expression.BoundParentTreeId = new long?(this.<Blackboard>P.TreeIncId);
			behaviorTreeByConfigId.Expression.BoundParentNodeId = new int?(nodeId);
			this.BindingExpressions[levelPlayConfigId] = behaviorTreeByConfigId.Expression;
			if (this.CurFocusLevelPlayId == levelPlayConfigId)
			{
				this.RefreshTrack();
			}
		}

		// Token: 0x0602F4A7 RID: 193703 RVA: 0x00D30F1C File Offset: 0x00D2F11C
		public void RemoveBindingExpression(int levelPlayConfigId)
		{
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(levelPlayConfigId, out behaviorTreeExpressionComponent))
			{
				behaviorTreeExpressionComponent.BoundParentTreeId = null;
				behaviorTreeExpressionComponent.BoundParentNodeId = null;
			}
			this.BindingExpressions.Remove(levelPlayConfigId);
			this.BindingMapTrackDataCache.Remove(levelPlayConfigId);
			if (this.CurFocusLevelPlayId == levelPlayConfigId)
			{
				this.RefreshTrack();
			}
		}

		// Token: 0x0602F4A8 RID: 193704 RVA: 0x00D30F80 File Offset: 0x00D2F180
		public void AddWatchingLevelPlay(int levelPlayConfigId)
		{
			this.WatchingList.Add(levelPlayConfigId);
		}

		// Token: 0x0602F4A9 RID: 193705 RVA: 0x00D30F8F File Offset: 0x00D2F18F
		public void RemoveWatchingLevelPlay(int levelPlayConfigId)
		{
			this.WatchingList.Remove(levelPlayConfigId);
		}

		// Token: 0x0602F4AA RID: 193706 RVA: 0x00D30FA0 File Offset: 0x00D2F1A0
		public void EnableTrack(bool value, ESetTrackReason reason = ESetTrackReason.None, BindingExpressionComponentHolder.EUpdateTrackType type = BindingExpressionComponentHolder.EUpdateTrackType.Text | BindingExpressionComponentHolder.EUpdateTrackType.TrackMark)
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.<Blackboard>P.TreeIncId), false);
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent = (behaviorTree != null) ? behaviorTree.Expression : null;
			if (behaviorTreeExpressionComponent != null)
			{
				behaviorTreeExpressionComponent.ForceSetAllMapMarksVisible(!this.IsValid());
			}
			if (!this.IsBinding())
			{
				return;
			}
			foreach (KeyValuePair<int, BehaviorTreeExpressionComponent> keyValuePair in this.BindingExpressions)
			{
				int num;
				BehaviorTreeExpressionComponent behaviorTreeExpressionComponent2;
				keyValuePair.Deconstruct(out num, out behaviorTreeExpressionComponent2);
				int num2 = num;
				behaviorTreeExpressionComponent2.EnableTrack(value && num2 == this.CurFocusLevelPlayId, reason, true);
			}
			if ((type & BindingExpressionComponentHolder.EUpdateTrackType.Text) != (BindingExpressionComponentHolder.EUpdateTrackType)0)
			{
				this.EnableTrackForText(value, reason);
			}
			if ((type & BindingExpressionComponentHolder.EUpdateTrackType.TrackMark) != (BindingExpressionComponentHolder.EUpdateTrackType)0)
			{
				this.EnableTrackForTrackMark(value, reason);
			}
		}

		// Token: 0x0602F4AB RID: 193707 RVA: 0x00D31070 File Offset: 0x00D2F270
		public bool IsValid()
		{
			foreach (int levelPlayConfigId in this.BindingExpressions.Keys)
			{
				if (this.IsBindingValid(levelPlayConfigId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602F4AC RID: 193708 RVA: 0x00D310D4 File Offset: 0x00D2F2D4
		public bool IsBinding()
		{
			foreach (BehaviorTreeExpressionComponent behaviorTreeExpressionComponent in this.BindingExpressions.Values)
			{
				if (behaviorTreeExpressionComponent != null && behaviorTreeExpressionComponent.IsValid)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0602F4AD RID: 193709 RVA: 0x00D3113C File Offset: 0x00D2F33C
		public void OnBindingNodeTextUpdate()
		{
			this.IsTrackTextDirty = true;
		}

		// Token: 0x0602F4AE RID: 193710 RVA: 0x00D31145 File Offset: 0x00D2F345
		public void OnBindingNodeTrackMarkUpdate()
		{
			this.IsTrackMarkDirty = true;
		}

		// Token: 0x0602F4AF RID: 193711 RVA: 0x00D3114E File Offset: 0x00D2F34E
		public BehaviorTreeViewShowData GetShowData(bool bTrackText)
		{
			return this.BuildBehaviorTreeViewShowData(true);
		}

		// Token: 0x0602F4B0 RID: 193712 RVA: 0x00D31157 File Offset: 0x00D2F357
		public int GetNodeIdByLevelPlayConfigId(int levelPlayConfigId)
		{
			return this.LevelPlayIdToQuestNodeId.GetValueOrDefault(levelPlayConfigId, 0);
		}

		// Token: 0x0602F4B1 RID: 193713 RVA: 0x00D31166 File Offset: 0x00D2F366
		public int GetCurFocusLevelPlayId()
		{
			return this.CurFocusLevelPlayId;
		}

		// Token: 0x0602F4B2 RID: 193714 RVA: 0x00D31170 File Offset: 0x00D2F370
		private bool IsBindingValid(int levelPlayConfigId)
		{
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (!this.BindingExpressions.TryGetValue(levelPlayConfigId, out behaviorTreeExpressionComponent) || !behaviorTreeExpressionComponent.IsValid)
			{
				return false;
			}
			int valueOrDefault = this.LevelPlayIdToQuestNodeId.GetValueOrDefault(levelPlayConfigId, 0);
			BehaviorNodeBase node = this.<Blackboard>P.GetNode(new int?(valueOrDefault));
			object obj;
			if (node == null)
			{
				obj = null;
			}
			else
			{
				ITrackTarget trackTarget = node.TrackTarget;
				obj = ((trackTarget != null) ? trackTarget.TrackType : null);
			}
			ITrackLevelPlay trackLevelPlay = obj as ITrackLevelPlay;
			global::LevelPlayInfo levelPlayInfo = LevelPlayModel.Instance.GetLevelPlayInfo(levelPlayConfigId);
			return (levelPlayInfo != null && levelPlayInfo.IsInTrackRange()) || ((trackLevelPlay != null) ? trackLevelPlay.TrackSwitchRule : null).GetValueOrDefault() != ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
		}

		// Token: 0x0602F4B3 RID: 193715 RVA: 0x00D31214 File Offset: 0x00D2F414
		private void AddEvents()
		{
			EventSystem.Instance.Add<long>(EEventName.OnCreateBehaviorTree, new Action<long>(this.OnTreeCreate));
			EventSystem.Instance.Add<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnTreeRemove));
			EventSystem.Instance.Add<int>(EEventName.OnEnterLevelPlayNotify, new Action<int>(this.OnEnterLevelPlayRange));
			EventSystem.Instance.Add<int>(EEventName.OnLeaveLevelPlayNotify, new Action<int>(this.OnLeaveLevelPlayRange));
		}

		// Token: 0x0602F4B4 RID: 193716 RVA: 0x00D31294 File Offset: 0x00D2F494
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<long>(EEventName.OnCreateBehaviorTree, new Action<long>(this.OnTreeCreate));
			EventSystem.Instance.Remove<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnTreeRemove));
			EventSystem.Instance.Remove<int>(EEventName.OnEnterLevelPlayNotify, new Action<int>(this.OnEnterLevelPlayRange));
			EventSystem.Instance.Remove<int>(EEventName.OnLeaveLevelPlayNotify, new Action<int>(this.OnLeaveLevelPlayRange));
		}

		// Token: 0x0602F4B5 RID: 193717 RVA: 0x00D31314 File Offset: 0x00D2F514
		private void EnableTrackForText(bool enable, ESetTrackReason reason)
		{
			ETreeTextExpressReason p = ETreeTextExpressReason.None;
			if (reason == ESetTrackReason.QuestFinished)
			{
				p = ETreeTextExpressReason.QuestFinished;
			}
			bool flag = this.<Blackboard>P.ContainTag(EBehaviorTreeTag.SkipMissionPanelAnim) || AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
			if (enable)
			{
				BehaviorTreeViewShowData behaviorTreeViewShowData = this.BuildBehaviorTreeViewShowData(true);
				if (behaviorTreeViewShowData.MainStepInfo == null && (behaviorTreeViewShowData.SubStepInfos == null || behaviorTreeViewShowData.SubStepInfos.Count == 0))
				{
					return;
				}
				if (this.IsTextExpressing)
				{
					EventSystem.Instance.Emit<BehaviorTreeViewShowData, bool>(EEventName.GeneralLogicTreeUpdateShowTrackText, behaviorTreeViewShowData, flag);
					return;
				}
				EventSystem.Instance.Emit<BehaviorTreeViewShowData, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeStartShowTrackText, behaviorTreeViewShowData, p, flag);
				this.IsTextExpressing = true;
				return;
			}
			else
			{
				if (!this.IsTextExpressing)
				{
					return;
				}
				EventSystem.Instance.Emit<long, ETreeTextExpressReason, bool>(EEventName.GeneralLogicTreeEndShowTrackText, this.<Blackboard>P.TreeIncId, p, flag);
				this.IsTextExpressing = false;
				return;
			}
		}

		// Token: 0x0602F4B6 RID: 193718 RVA: 0x00D313D8 File Offset: 0x00D2F5D8
		private void EnableTrackForTrackMark(bool enable, ESetTrackReason reason)
		{
			if (enable)
			{
				foreach (ITrackData data in this.BuildTrackData())
				{
					TrackController.Instance.StartTrack(data, true);
				}
			}
		}

		// Token: 0x0602F4B7 RID: 193719 RVA: 0x00D31434 File Offset: 0x00D2F634
		private BehaviorTreeViewShowData BuildBehaviorTreeViewShowData(bool bTrackText = true)
		{
			BehaviorTreeViewShowData behaviorTreeViewShowData = this.<Blackboard>P.CreateOriginalShowData(bTrackText);
			BtType btType = behaviorTreeViewShowData.BtType;
			long id = behaviorTreeViewShowData.Id;
			int treeConfigId = behaviorTreeViewShowData.TreeConfigId;
			long value = 0L;
			int trackIconConfigId = behaviorTreeViewShowData.TrackIconConfigId;
			string titleTextKey = behaviorTreeViewShowData.TitleTextKey;
			bool flag = behaviorTreeViewShowData.IsInChallenge;
			int num = behaviorTreeViewShowData.ShowPriority;
			BehaviorTreeStepTextInfo mainStepInfo = behaviorTreeViewShowData.MainStepInfo;
			List<BehaviorTreeStepTextInfo> subStepText = new List<BehaviorTreeStepTextInfo>();
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				BehaviorTreeViewShowData behaviorTreeViewShowData2 = behaviorTreeExpressionComponent.CreateShowData();
				if (behaviorTreeViewShowData2.MainStepInfo == null)
				{
					List<BehaviorTreeStepTextInfo> subStepInfos = behaviorTreeViewShowData2.SubStepInfos;
					if (((subStepInfos != null) ? subStepInfos.Count : 0) <= 0)
					{
						goto IL_E1;
					}
				}
				btType = behaviorTreeViewShowData2.BtType;
				id = behaviorTreeViewShowData2.Id;
				treeConfigId = behaviorTreeViewShowData2.TreeConfigId;
				flag = (behaviorTreeViewShowData2.IsInChallenge || flag);
				num = Math.Max(behaviorTreeViewShowData2.ShowPriority, num);
				mainStepInfo = behaviorTreeViewShowData2.MainStepInfo;
				subStepText = (behaviorTreeViewShowData2.SubStepInfos ?? new List<BehaviorTreeStepTextInfo>());
				IL_E1:
				value = behaviorTreeViewShowData.Id;
			}
			return BehaviorTreeViewShowData.Create(btType, id, treeConfigId, flag, trackIconConfigId, num, titleTextKey, mainStepInfo, subStepText, new long?(value));
		}

		// Token: 0x0602F4B8 RID: 193720 RVA: 0x00D31548 File Offset: 0x00D2F748
		private List<ITrackData> BuildTrackData()
		{
			string questMarkIconPathByQuestId = QuestUtil.Instance.GetQuestMarkIconPathByQuestId(this.<Blackboard>P.TreeConfigId);
			List<ITrackData> list = new List<ITrackData>();
			foreach (int num in this.BindingExpressions.Keys)
			{
				Dictionary<int, List<ITrackData>> dictionary;
				if (this.IsBindingValid(num) && num == this.CurFocusLevelPlayId && this.BindingMapTrackDataCache.TryGetValue(num, out dictionary))
				{
					foreach (List<ITrackData> list2 in dictionary.Values)
					{
						foreach (ITrackData trackData in list2)
						{
							if (!trackData.WeakTrack.GetValueOrDefault())
							{
								trackData.IconPath = questMarkIconPathByQuestId;
							}
							list.Add(trackData);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0602F4B9 RID: 193721 RVA: 0x00D3167C File Offset: 0x00D2F87C
		private void RefreshTrack()
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.<Blackboard>P.TreeIncId), false);
			if (behaviorTree == null)
			{
				return;
			}
			if (this.<Blackboard>P.IsTracking)
			{
				behaviorTree.SetTrack(false, ESetTrackReason.None);
				behaviorTree.SetTrack(true, ESetTrackReason.None);
			}
		}

		// Token: 0x0602F4BA RID: 193722 RVA: 0x00D316C8 File Offset: 0x00D2F8C8
		private void OnTreeCreate(long treeIncId)
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null || behaviorTree.BtType != BtType.LevelPlay)
			{
				return;
			}
			if (this.WatchingList.Contains(behaviorTree.TreeConfigId))
			{
				if (!this.WatchingList.Contains(this.CurFocusLevelPlayId))
				{
					this.CurFocusLevelPlayId = behaviorTree.TreeConfigId;
				}
				int valueOrDefault = this.LevelPlayIdToQuestNodeId.GetValueOrDefault(behaviorTree.TreeConfigId, 0);
				this.AddBindingExpression(valueOrDefault, behaviorTree.TreeConfigId);
			}
		}

		// Token: 0x0602F4BB RID: 193723 RVA: 0x00D31750 File Offset: 0x00D2F950
		private void OnTreeRemove(long treeIncId, ETreeRemoveReason eTreeRemoveReason)
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(treeIncId), false);
			if (behaviorTree == null || behaviorTree.BtType != BtType.LevelPlay)
			{
				return;
			}
			if (this.WatchingList.Contains(behaviorTree.TreeConfigId))
			{
				if (behaviorTree.GetBlackBoard().GetCurrentActiveChildQuestNode(true) == null)
				{
					bool p = this.<Blackboard>P.ContainTag(EBehaviorTreeTag.SkipMissionPanelAnim) || AutoRunModel.Instance.GetAutoRunMode() > EAutoRunMode.Disabled;
					BehaviorTreeViewShowData p2 = this.BuildBehaviorTreeViewShowData(true);
					EventSystem.Instance.Emit<BehaviorTreeViewShowData, bool>(EEventName.GeneralLogicTreeUpdateShowTrackText, p2, p);
				}
				this.RemoveBindingExpression(behaviorTree.TreeConfigId);
			}
		}

		// Token: 0x0602F4BC RID: 193724 RVA: 0x00D317EC File Offset: 0x00D2F9EC
		private void OnEnterLevelPlayRange(int levelPlayId)
		{
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, levelPlayId);
			if (behaviorTreeByConfigId == null || behaviorTreeByConfigId.BtType != BtType.LevelPlay)
			{
				return;
			}
			if (this.WatchingList.Contains(behaviorTreeByConfigId.TreeConfigId))
			{
				if (!this.WatchingList.Contains(this.CurFocusLevelPlayId))
				{
					this.CurFocusLevelPlayId = behaviorTreeByConfigId.TreeConfigId;
				}
				int valueOrDefault = this.LevelPlayIdToQuestNodeId.GetValueOrDefault(behaviorTreeByConfigId.TreeConfigId, 0);
				this.AddBindingExpression(valueOrDefault, behaviorTreeByConfigId.TreeConfigId);
			}
		}

		// Token: 0x0602F4BD RID: 193725 RVA: 0x00D31870 File Offset: 0x00D2FA70
		private void OnLeaveLevelPlayRange(int levelPlayId)
		{
			BaseBehaviorTree behaviorTreeByConfigId = GeneralLogicTreeModel.Instance.GetBehaviorTreeByConfigId(BtType.LevelPlay, levelPlayId);
			if (behaviorTreeByConfigId == null || behaviorTreeByConfigId.BtType != BtType.LevelPlay)
			{
				return;
			}
			if (this.WatchingList.Contains(behaviorTreeByConfigId.TreeConfigId))
			{
				this.RemoveBindingExpression(behaviorTreeByConfigId.TreeConfigId);
			}
		}

		// Token: 0x0602F4BE RID: 193726 RVA: 0x00D318BE File Offset: 0x00D2FABE
		private void OnTick(float deltaTime)
		{
			this.TickFocusExpression(deltaTime);
			this.TickTrackUpdate(deltaTime);
		}

		// Token: 0x0602F4BF RID: 193727 RVA: 0x00D318D0 File Offset: 0x00D2FAD0
		private void TickTrackUpdate(float deltaTime)
		{
			if (!this.IsValid())
			{
				return;
			}
			this.TickTime += deltaTime;
			if (this.TickTime < 100f)
			{
				return;
			}
			this.TickTime = 0f;
			BindingExpressionComponentHolder.EUpdateTrackType eupdateTrackType = (BindingExpressionComponentHolder.EUpdateTrackType)0;
			eupdateTrackType |= (this.IsTrackTextDirty ? BindingExpressionComponentHolder.EUpdateTrackType.Text : ((BindingExpressionComponentHolder.EUpdateTrackType)0));
			eupdateTrackType |= (this.IsTrackMarkDirty ? BindingExpressionComponentHolder.EUpdateTrackType.TrackMark : ((BindingExpressionComponentHolder.EUpdateTrackType)0));
			if (eupdateTrackType != (BindingExpressionComponentHolder.EUpdateTrackType)0 && this.<Blackboard>P.IsTracking)
			{
				this.IsTrackTextDirty = false;
				this.IsTrackMarkDirty = false;
				this.EnableTrack(true, ESetTrackReason.None, eupdateTrackType);
			}
		}

		// Token: 0x0602F4C0 RID: 193728 RVA: 0x00D31954 File Offset: 0x00D2FB54
		private void TickFocusExpression(float deltaTime)
		{
			int curFocusLevelPlayId = this.CurFocusLevelPlayId;
			int trackBoundLevelPlayId = LevelPlayModel.Instance.GetTrackBoundLevelPlayId();
			if (curFocusLevelPlayId == trackBoundLevelPlayId)
			{
				return;
			}
			this.CurFocusLevelPlayId = trackBoundLevelPlayId;
			if (this.CurFocusLevelPlayId == 0 || curFocusLevelPlayId == 0)
			{
				this.RefreshTrack();
				return;
			}
			if (!this.IsBindingValid(trackBoundLevelPlayId))
			{
				return;
			}
			if (this.<Blackboard>P.IsTracking)
			{
				this.EnableTrack(true, ESetTrackReason.None, BindingExpressionComponentHolder.EUpdateTrackType.Text | BindingExpressionComponentHolder.EUpdateTrackType.TrackMark);
			}
		}

		// Token: 0x0602F4C1 RID: 193729 RVA: 0x00D319B4 File Offset: 0x00D2FBB4
		public double GetTrackDistance()
		{
			BehaviorNodeBase curTrackNode = this.GetCurTrackNode();
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				return behaviorTreeExpressionComponent.GetTrackDistance((curTrackNode != null) ? curTrackNode.NodeId : 0);
			}
			return 0.0;
		}

		// Token: 0x0602F4C2 RID: 193730 RVA: 0x00D319FC File Offset: 0x00D2FBFC
		public int GetDefaultMark()
		{
			BehaviorNodeBase curTrackNode = this.GetCurTrackNode();
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				return behaviorTreeExpressionComponent.GetDefaultMark((curTrackNode != null) ? curTrackNode.NodeId : 0).GetValueOrDefault();
			}
			return 0;
		}

		// Token: 0x0602F4C3 RID: 193731 RVA: 0x00D31A44 File Offset: 0x00D2FC44
		public double GetRangeMarkSize()
		{
			BehaviorNodeBase curTrackNode = this.GetCurTrackNode();
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				return behaviorTreeExpressionComponent.GetRangeMarkSize((curTrackNode != null) ? curTrackNode.NodeId : 0);
			}
			return 0.0;
		}

		// Token: 0x0602F4C4 RID: 193732 RVA: 0x00D31A8C File Offset: 0x00D2FC8C
		public double GetRangeMarkShowDis()
		{
			BehaviorNodeBase curTrackNode = this.GetCurTrackNode();
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				return behaviorTreeExpressionComponent.GetRangeMarkShowDis((curTrackNode != null) ? curTrackNode.NodeId : 0).GetValueOrDefault();
			}
			return 0.0;
		}

		// Token: 0x0602F4C5 RID: 193733 RVA: 0x00D31ADC File Offset: 0x00D2FCDC
		[NullableContext(2)]
		public global::Vector GetNodeTrackPosition()
		{
			BehaviorNodeBase curTrackNode = this.GetCurTrackNode();
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				return behaviorTreeExpressionComponent.GetNodeTrackPosition((curTrackNode != null) ? curTrackNode.NodeId : 0);
			}
			return null;
		}

		// Token: 0x0602F4C6 RID: 193734 RVA: 0x00D31B1C File Offset: 0x00D2FD1C
		[NullableContext(2)]
		private BehaviorNodeBase GetCurTrackNode()
		{
			BehaviorTreeViewShowData behaviorTreeViewShowData = this.BuildBehaviorTreeViewShowData(true);
			GeneralLogicTreeController instance = GeneralLogicTreeController.Instance;
			BehaviorTreeStepTextInfo mainStepInfo = behaviorTreeViewShowData.MainStepInfo;
			int titleTrackNodeId = instance.GetTitleTrackNodeId((mainStepInfo != null) ? mainStepInfo.QuestScheduleType : null);
			BehaviorTreeExpressionComponent behaviorTreeExpressionComponent;
			if (!this.BindingExpressions.TryGetValue(this.CurFocusLevelPlayId, out behaviorTreeExpressionComponent))
			{
				return null;
			}
			if (titleTrackNodeId != 0)
			{
				return behaviorTreeExpressionComponent.GetBlackBoard().GetNode(new int?(titleTrackNodeId));
			}
			return behaviorTreeExpressionComponent.GetBlackBoard().GetCurrentActiveChildQuestNode(true);
		}

		// Token: 0x04019148 RID: 102728
		[CompilerGenerated]
		private Blackboard <Blackboard>P = Blackboard;

		// Token: 0x04019149 RID: 102729
		private const int TICK_INTERVAL = 100;

		// Token: 0x0401914A RID: 102730
		private readonly Dictionary<int, BehaviorTreeExpressionComponent> BindingExpressions = new Dictionary<int, BehaviorTreeExpressionComponent>();

		// Token: 0x0401914B RID: 102731
		private readonly HashSet<int> WatchingList = new HashSet<int>();

		// Token: 0x0401914C RID: 102732
		private readonly Dictionary<int, int> DefaultMapTrackMarkIds = new Dictionary<int, int>();

		// Token: 0x0401914D RID: 102733
		private readonly Dictionary<int, List<ITrackData>> DefaultMapTrackData = new Dictionary<int, List<ITrackData>>();

		// Token: 0x0401914E RID: 102734
		private readonly Dictionary<int, global::Vector> DefaultTrackPosCache = new Dictionary<int, global::Vector>();

		// Token: 0x0401914F RID: 102735
		private readonly Dictionary<int, int> LevelPlayIdToQuestNodeId = new Dictionary<int, int>();

		// Token: 0x04019150 RID: 102736
		public readonly Dictionary<int, Dictionary<int, List<ITrackData>>> BindingMapTrackDataCache = new Dictionary<int, Dictionary<int, List<ITrackData>>>();

		// Token: 0x04019151 RID: 102737
		private bool IsTextExpressing;

		// Token: 0x04019152 RID: 102738
		private bool IsTrackTextDirty;

		// Token: 0x04019153 RID: 102739
		private bool IsTrackMarkDirty;

		// Token: 0x04019154 RID: 102740
		private float TickTime;

		// Token: 0x04019155 RID: 102741
		[Nullable(2)]
		private Ticker Ticker;

		// Token: 0x04019156 RID: 102742
		private int CurFocusLevelPlayId;

		// Token: 0x0200A648 RID: 42568
		[NullableContext(0)]
		[Flags]
		public enum EUpdateTrackType
		{
			// Token: 0x0403368C RID: 210572
			Text = 1,
			// Token: 0x0403368D RID: 210573
			TrackMark = 2
		}
	}
}
