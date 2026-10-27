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
	// Token: 0x020059EE RID: 23022
	[NullableContext(1)]
	[Nullable(0)]
	public class BindingExpressionComponentHolder
	{
		// Token: 0x0603A57C RID: 238972 RVA: 0x00DE146C File Offset: 0x00DDF66C
		public BindingExpressionComponentHolder(Blackboard Blackboard)
		{
		}

		// Token: 0x0603A57D RID: 238973 RVA: 0x00DE14D3 File Offset: 0x00DDF6D3
		public void Init()
		{
			this.WatchingList.Clear();
			this.AddEvents();
			this.Ticker = TickSystem.Instance.Add(new Action<float>(this.OnTick), "BindingExpressionComponentHolder", ETickingGroup.TG_PrePhysics, false, 0, false);
		}

		// Token: 0x0603A57E RID: 238974 RVA: 0x00DE150C File Offset: 0x00DDF70C
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

		// Token: 0x0603A57F RID: 238975 RVA: 0x00DE15BC File Offset: 0x00DDF7BC
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

		// Token: 0x0603A580 RID: 238976 RVA: 0x00DE16B0 File Offset: 0x00DDF8B0
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

		// Token: 0x0603A581 RID: 238977 RVA: 0x00DE1714 File Offset: 0x00DDF914
		public void AddWatchingLevelPlay(int levelPlayConfigId)
		{
			this.WatchingList.Add(levelPlayConfigId);
		}

		// Token: 0x0603A582 RID: 238978 RVA: 0x00DE1723 File Offset: 0x00DDF923
		public void RemoveWatchingLevelPlay(int levelPlayConfigId)
		{
			this.WatchingList.Remove(levelPlayConfigId);
		}

		// Token: 0x0603A583 RID: 238979 RVA: 0x00DE1734 File Offset: 0x00DDF934
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

		// Token: 0x0603A584 RID: 238980 RVA: 0x00DE1804 File Offset: 0x00DDFA04
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

		// Token: 0x0603A585 RID: 238981 RVA: 0x00DE1868 File Offset: 0x00DDFA68
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

		// Token: 0x0603A586 RID: 238982 RVA: 0x00DE18D0 File Offset: 0x00DDFAD0
		public void OnBindingNodeTextUpdate()
		{
			this.IsTrackTextDirty = true;
		}

		// Token: 0x0603A587 RID: 238983 RVA: 0x00DE18D9 File Offset: 0x00DDFAD9
		public void OnBindingNodeTrackMarkUpdate()
		{
			this.IsTrackMarkDirty = true;
		}

		// Token: 0x0603A588 RID: 238984 RVA: 0x00DE18E2 File Offset: 0x00DDFAE2
		public BehaviorTreeViewShowData GetShowData(bool bTrackText)
		{
			return this.BuildBehaviorTreeViewShowData(true);
		}

		// Token: 0x0603A589 RID: 238985 RVA: 0x00DE18EB File Offset: 0x00DDFAEB
		public int GetNodeIdByLevelPlayConfigId(int levelPlayConfigId)
		{
			return this.LevelPlayIdToQuestNodeId.GetValueOrDefault(levelPlayConfigId, 0);
		}

		// Token: 0x0603A58A RID: 238986 RVA: 0x00DE18FA File Offset: 0x00DDFAFA
		public int GetCurFocusLevelPlayId()
		{
			return this.CurFocusLevelPlayId;
		}

		// Token: 0x0603A58B RID: 238987 RVA: 0x00DE1904 File Offset: 0x00DDFB04
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

		// Token: 0x0603A58C RID: 238988 RVA: 0x00DE19A8 File Offset: 0x00DDFBA8
		private void AddEvents()
		{
			EventSystem.Instance.Add<long>(EEventName.OnCreateBehaviorTree, new Action<long>(this.OnTreeCreate));
			EventSystem.Instance.Add<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnTreeRemove));
			EventSystem.Instance.Add<int>(EEventName.OnEnterLevelPlayNotify, new Action<int>(this.OnEnterLevelPlayRange));
			EventSystem.Instance.Add<int>(EEventName.OnLeaveLevelPlayNotify, new Action<int>(this.OnLeaveLevelPlayRange));
		}

		// Token: 0x0603A58D RID: 238989 RVA: 0x00DE1A28 File Offset: 0x00DDFC28
		private void RemoveEvents()
		{
			EventSystem.Instance.Remove<long>(EEventName.OnCreateBehaviorTree, new Action<long>(this.OnTreeCreate));
			EventSystem.Instance.Remove<long, ETreeRemoveReason>(EEventName.OnGeneralLogicTreeRemove, new Action<long, ETreeRemoveReason>(this.OnTreeRemove));
			EventSystem.Instance.Remove<int>(EEventName.OnEnterLevelPlayNotify, new Action<int>(this.OnEnterLevelPlayRange));
			EventSystem.Instance.Remove<int>(EEventName.OnLeaveLevelPlayNotify, new Action<int>(this.OnLeaveLevelPlayRange));
		}

		// Token: 0x0603A58E RID: 238990 RVA: 0x00DE1AA8 File Offset: 0x00DDFCA8
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

		// Token: 0x0603A58F RID: 238991 RVA: 0x00DE1B6C File Offset: 0x00DDFD6C
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

		// Token: 0x0603A590 RID: 238992 RVA: 0x00DE1BC8 File Offset: 0x00DDFDC8
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

		// Token: 0x0603A591 RID: 238993 RVA: 0x00DE1CDC File Offset: 0x00DDFEDC
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

		// Token: 0x0603A592 RID: 238994 RVA: 0x00DE1E10 File Offset: 0x00DE0010
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

		// Token: 0x0603A593 RID: 238995 RVA: 0x00DE1E5C File Offset: 0x00DE005C
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

		// Token: 0x0603A594 RID: 238996 RVA: 0x00DE1EE4 File Offset: 0x00DE00E4
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

		// Token: 0x0603A595 RID: 238997 RVA: 0x00DE1F80 File Offset: 0x00DE0180
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

		// Token: 0x0603A596 RID: 238998 RVA: 0x00DE2004 File Offset: 0x00DE0204
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

		// Token: 0x0603A597 RID: 238999 RVA: 0x00DE2052 File Offset: 0x00DE0252
		private void OnTick(float deltaTime)
		{
			this.TickFocusExpression(deltaTime);
			this.TickTrackUpdate(deltaTime);
		}

		// Token: 0x0603A598 RID: 239000 RVA: 0x00DE2064 File Offset: 0x00DE0264
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

		// Token: 0x0603A599 RID: 239001 RVA: 0x00DE20E8 File Offset: 0x00DE02E8
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

		// Token: 0x0603A59A RID: 239002 RVA: 0x00DE2148 File Offset: 0x00DE0348
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

		// Token: 0x0603A59B RID: 239003 RVA: 0x00DE2190 File Offset: 0x00DE0390
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

		// Token: 0x0603A59C RID: 239004 RVA: 0x00DE21D8 File Offset: 0x00DE03D8
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

		// Token: 0x0603A59D RID: 239005 RVA: 0x00DE2220 File Offset: 0x00DE0420
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

		// Token: 0x0603A59E RID: 239006 RVA: 0x00DE2270 File Offset: 0x00DE0470
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

		// Token: 0x0603A59F RID: 239007 RVA: 0x00DE22B0 File Offset: 0x00DE04B0
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

		// Token: 0x0401E6A9 RID: 124585
		[CompilerGenerated]
		private Blackboard <Blackboard>P = Blackboard;

		// Token: 0x0401E6AA RID: 124586
		private const int TICK_INTERVAL = 100;

		// Token: 0x0401E6AB RID: 124587
		private readonly Dictionary<int, BehaviorTreeExpressionComponent> BindingExpressions = new Dictionary<int, BehaviorTreeExpressionComponent>();

		// Token: 0x0401E6AC RID: 124588
		private readonly HashSet<int> WatchingList = new HashSet<int>();

		// Token: 0x0401E6AD RID: 124589
		private readonly Dictionary<int, int> DefaultMapTrackMarkIds = new Dictionary<int, int>();

		// Token: 0x0401E6AE RID: 124590
		private readonly Dictionary<int, List<ITrackData>> DefaultMapTrackData = new Dictionary<int, List<ITrackData>>();

		// Token: 0x0401E6AF RID: 124591
		private readonly Dictionary<int, global::Vector> DefaultTrackPosCache = new Dictionary<int, global::Vector>();

		// Token: 0x0401E6B0 RID: 124592
		private readonly Dictionary<int, int> LevelPlayIdToQuestNodeId = new Dictionary<int, int>();

		// Token: 0x0401E6B1 RID: 124593
		public readonly Dictionary<int, Dictionary<int, List<ITrackData>>> BindingMapTrackDataCache = new Dictionary<int, Dictionary<int, List<ITrackData>>>();

		// Token: 0x0401E6B2 RID: 124594
		private bool IsTextExpressing;

		// Token: 0x0401E6B3 RID: 124595
		private bool IsTrackTextDirty;

		// Token: 0x0401E6B4 RID: 124596
		private bool IsTrackMarkDirty;

		// Token: 0x0401E6B5 RID: 124597
		private float TickTime;

		// Token: 0x0401E6B6 RID: 124598
		[Nullable(2)]
		private Ticker Ticker;

		// Token: 0x0401E6B7 RID: 124599
		private int CurFocusLevelPlayId;

		// Token: 0x0200BC3E RID: 48190
		[NullableContext(0)]
		[Flags]
		public enum EUpdateTrackType
		{
			// Token: 0x04038CBF RID: 232639
			Text = 1,
			// Token: 0x04038CC0 RID: 232640
			TrackMark = 2
		}
	}
}
