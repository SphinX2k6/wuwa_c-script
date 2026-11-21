using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.GeneralLogicTree.Define;
using CSharpScript.Game.Module.Sheriff;
using UnrealEngine;

// Token: 0x02001215 RID: 4629
[NullableContext(1)]
[Nullable(0)]
public class BaseBehaviorTree
{
	// Token: 0x17001259 RID: 4697
	// (get) Token: 0x0600B7D6 RID: 47062 RVA: 0x003634AF File Offset: 0x003616AF
	public BtType BtType
	{
		get
		{
			return this.BlackBoard.BtType;
		}
	}

	// Token: 0x1700125A RID: 4698
	// (get) Token: 0x0600B7D7 RID: 47063 RVA: 0x003634BC File Offset: 0x003616BC
	public long TreeIncId
	{
		get
		{
			return this.BlackBoard.TreeIncId;
		}
	}

	// Token: 0x1700125B RID: 4699
	// (get) Token: 0x0600B7D8 RID: 47064 RVA: 0x003634C9 File Offset: 0x003616C9
	public int TreeConfigId
	{
		get
		{
			return this.BlackBoard.TreeConfigId;
		}
	}

	// Token: 0x1700125C RID: 4700
	// (get) Token: 0x0600B7D9 RID: 47065 RVA: 0x003634D6 File Offset: 0x003616D6
	public int DungeonId
	{
		get
		{
			return this.BlackBoard.DungeonId;
		}
	}

	// Token: 0x1700125D RID: 4701
	// (get) Token: 0x0600B7DA RID: 47066 RVA: 0x003634E3 File Offset: 0x003616E3
	public int FailNodeId
	{
		get
		{
			return this.InnerFailNodeId;
		}
	}

	// Token: 0x0600B7DB RID: 47067 RVA: 0x003634EB File Offset: 0x003616EB
	public void ClearFailNodeId()
	{
		this.InnerFailNodeId = 0;
	}

	// Token: 0x0600B7DC RID: 47068 RVA: 0x003634F4 File Offset: 0x003616F4
	public BaseBehaviorTree(long id, int configId, BtType btType, int dungeonId, int taskMarkTableId, string onlineType, int showPriority, bool? bNewQuest = null, bool? bDisableExpression = null)
	{
		this.BlackBoard.Init(btType, id, configId, dungeonId, taskMarkTableId, onlineType, showPriority, bDisableExpression.GetValueOrDefault());
		if (bNewQuest.GetValueOrDefault())
		{
			this.BlackBoard.AddTag(EBehaviorTreeTag.NewQuest, "");
		}
	}

	// Token: 0x0600B7DD RID: 47069 RVA: 0x00363560 File Offset: 0x00361760
	public void InitTree(TreeInfo treeInfo, bool bSleep = false)
	{
		this.InitComponents();
		this.SetSleep(bSleep);
		this.Recover(treeInfo);
		this.OnAddEvent();
	}

	// Token: 0x0600B7DE RID: 47070 RVA: 0x0036357C File Offset: 0x0036177C
	public void Destroy()
	{
		this.OnRemoveEvent();
		ForceClosedRestrictionComponentHolder forceClosedRestrictionHolder = this.ForceClosedRestrictionHolder;
		if (forceClosedRestrictionHolder != null)
		{
			forceClosedRestrictionHolder.Destroy();
		}
		this.BlackBoard.Dispose();
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression != null)
		{
			expression.Dispose();
		}
		DynamicFlowInfo flowInfo = this.FlowInfo;
		if (flowInfo != null)
		{
			flowInfo.Dispose();
		}
		BehaviorTreeTimerCenter timerCenter = this.TimerCenter;
		if (timerCenter != null)
		{
			timerCenter.Dispose();
		}
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if (bindingExpressionHolder == null)
		{
			return;
		}
		bindingExpressionHolder.Destroy();
	}

	// Token: 0x0600B7DF RID: 47071 RVA: 0x003635F0 File Offset: 0x003617F0
	[return: Nullable(2)]
	protected BehaviorNodeBase CreateNode(ENodeStatusUpdateReason reason, global::NodeInfo data)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingCreateNode data2 = new BtPendingCreateNode
			{
				Reason = reason,
				NodeInfo = data
			};
			this.AddToPendingProcessList(data2);
			return null;
		}
		if (data == null)
		{
			return null;
		}
		IBtNode nodeConfig = this.BlackBoard.GetNodeConfig(data.NodeId);
		if (nodeConfig == null)
		{
			return null;
		}
		BehaviorNodeBase behaviorNodeBase = NodeTypeDefine.NewNodeObj(nodeConfig);
		if (behaviorNodeBase == null)
		{
			return null;
		}
		this.BlackBoard.AddNode(data.NodeId, behaviorNodeBase);
		this.BlackBoard.AddNodeToStatusGroup(behaviorNodeBase, data.Info.Status);
		behaviorNodeBase.Init(this.BlackBoard, reason, data, nodeConfig, this.BtType);
		ForceClosedRestrictionComponentHolder forceClosedRestrictionHolder = this.ForceClosedRestrictionHolder;
		if (forceClosedRestrictionHolder != null)
		{
			forceClosedRestrictionHolder.RefreshNode();
		}
		return behaviorNodeBase;
	}

	// Token: 0x0600B7E0 RID: 47072 RVA: 0x0036369F File Offset: 0x0036189F
	private void AddToPendingProcessList(BehaviorTreePendingProcess data)
	{
		this.PendingProcess.Push(data);
	}

	// Token: 0x0600B7E1 RID: 47073 RVA: 0x003636B0 File Offset: 0x003618B0
	private void InitComponents()
	{
		this.FlowInfo = new DynamicFlowInfo();
		this.TimerCenter = new BehaviorTreeTimerCenter(this.TreeIncId, this.BlackBoard);
		this.Suspend = new BehaviorTreeSuspendComponent(this.TreeIncId, this.BlackBoard);
		this.ForceClosedRestrictionHolder = new ForceClosedRestrictionComponentHolder(this.BlackBoard);
		this.ForceClosedRestrictionHolder.Init();
		if (!this.BlackBoard.NoExpression)
		{
			this.Expression = new BehaviorTreeExpressionComponent(this.BlackBoard);
			this.Expression.Init();
			this.BindingExpressionHolder = new BindingExpressionComponentHolder(this.BlackBoard);
			this.BindingExpressionHolder.Init();
		}
	}

	// Token: 0x0600B7E2 RID: 47074 RVA: 0x00363758 File Offset: 0x00361958
	[NullableContext(2)]
	public void Recover(TreeInfo treeInfo)
	{
		if (treeInfo == null)
		{
			return;
		}
		this.RecoverNodes(treeInfo.Nodes);
		this.RecoverTimers(treeInfo.TimerInfos);
		this.RecoverVars(treeInfo.Vars);
		this.UpdateOccupations(treeInfo.SuspendNodeId, treeInfo.SuspendType, treeInfo.OccupationInfo);
		PerformController.Instance.RecoverTreeInfo(treeInfo.CharacterLookAtInfos);
	}

	// Token: 0x0600B7E3 RID: 47075 RVA: 0x003637B8 File Offset: 0x003619B8
	private void RecoverNodes(IDictionary<int, Aki.Protocol.NodeInfo> nodes)
	{
		foreach (int num in nodes.Keys)
		{
			global::NodeInfo nodeInfo = new global::NodeInfo
			{
				Info = nodes[num],
				NodeId = num
			};
			if (this.GetNode(nodeInfo.NodeId) != null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "创建节点时：节点已存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("节点Id", nodeInfo.NodeId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			else
			{
				this.CreateNode(ENodeStatusUpdateReason.Recover, nodeInfo);
			}
		}
	}

	// Token: 0x0600B7E4 RID: 47076 RVA: 0x00363864 File Offset: 0x00361A64
	private void RecoverTimers(IList<TimerInfoPb> timerInfos)
	{
		foreach (TimerInfoPb timerInfo in timerInfos)
		{
			this.UpdateTimer(timerInfo);
		}
	}

	// Token: 0x0600B7E5 RID: 47077 RVA: 0x003638AC File Offset: 0x00361AAC
	private void RecoverVars(IDictionary<string, VarDefinePb> vars)
	{
		foreach (string text in vars.Keys)
		{
			VarDefinePb varDefine = vars[text];
			this.BlackBoard.UpdateTreeVar(text, varDefine);
		}
	}

	// Token: 0x0600B7E6 RID: 47078 RVA: 0x00363908 File Offset: 0x00361B08
	private void OnAddEvent()
	{
		EventSystem.Instance.AddWithTarget(this.BlackBoard, EEventName.GeneralLogicTreeRollbackWaitingUpdate, new Action(this.OnGeneralLogicTreeRollbackWaitingUpdate));
	}

	// Token: 0x0600B7E7 RID: 47079 RVA: 0x0036392C File Offset: 0x00361B2C
	private void OnRemoveEvent()
	{
		if (EventSystem.Instance.Has<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange)))
		{
			EventSystem.Instance.Remove<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
		}
		if (EventSystem.Instance.HasWithTarget(this.BlackBoard, EEventName.GeneralLogicTreeRollbackWaitingUpdate, new Action(this.OnGeneralLogicTreeRollbackWaitingUpdate)))
		{
			EventSystem.Instance.RemoveWithTarget(this.BlackBoard, EEventName.GeneralLogicTreeRollbackWaitingUpdate, new Action(this.OnGeneralLogicTreeRollbackWaitingUpdate));
		}
	}

	// Token: 0x0600B7E8 RID: 47080 RVA: 0x003639B8 File Offset: 0x00361BB8
	public void SetSleep(bool value)
	{
		this.BlackBoard.IsSleeping = value;
		if (value)
		{
			return;
		}
		if (this.PendingProcess.Size == 0)
		{
			return;
		}
		for (BehaviorTreePendingProcess behaviorTreePendingProcess = this.PendingProcess.Pop(); behaviorTreePendingProcess != null; behaviorTreePendingProcess = ((this.PendingProcess.Size > 0) ? this.PendingProcess.Pop() : null))
		{
			BtPendingCreateNode btPendingCreateNode = behaviorTreePendingProcess as BtPendingCreateNode;
			if (btPendingCreateNode == null)
			{
				BtPendingUpdateNodeStatus btPendingUpdateNodeStatus = behaviorTreePendingProcess as BtPendingUpdateNodeStatus;
				if (btPendingUpdateNodeStatus == null)
				{
					BtPendingUpdateNodeProgress btPendingUpdateNodeProgress = behaviorTreePendingProcess as BtPendingUpdateNodeProgress;
					if (btPendingUpdateNodeProgress == null)
					{
						BtPendingUpdateChildQuestNodeStatus btPendingUpdateChildQuestNodeStatus = behaviorTreePendingProcess as BtPendingUpdateChildQuestNodeStatus;
						if (btPendingUpdateChildQuestNodeStatus == null)
						{
							BtPendingUpdateSetTrack btPendingUpdateSetTrack = behaviorTreePendingProcess as BtPendingUpdateSetTrack;
							if (btPendingUpdateSetTrack == null)
							{
								BtPendingDoAction btPendingDoAction = behaviorTreePendingProcess as BtPendingDoAction;
								if (btPendingDoAction == null)
								{
									BtPendingUpdateUpdateTimer btPendingUpdateUpdateTimer = behaviorTreePendingProcess as BtPendingUpdateUpdateTimer;
									if (btPendingUpdateUpdateTimer == null)
									{
										BtPendingUpdateOccupations btPendingUpdateOccupations = behaviorTreePendingProcess as BtPendingUpdateOccupations;
										if (btPendingUpdateOccupations == null)
										{
											BtPendingUpdateTreeVars btPendingUpdateTreeVars = behaviorTreePendingProcess as BtPendingUpdateTreeVars;
											if (btPendingUpdateTreeVars != null)
											{
												this.UpdateTreeVars(btPendingUpdateTreeVars.Notify);
											}
										}
										else
										{
											this.UpdateOccupations(btPendingUpdateOccupations.SuspendNodeId, btPendingUpdateOccupations.SuspendType, btPendingUpdateOccupations.OccupationInfo);
										}
									}
									else
									{
										this.UpdateTimer(btPendingUpdateUpdateTimer.TimerInfo);
									}
								}
								else
								{
									this.DoAction(btPendingDoAction.Context, btPendingDoAction.NodeId, btPendingDoAction.PlayerId, btPendingDoAction.SessionId, btPendingDoAction.StartIndex, btPendingDoAction.EndIndex, btPendingDoAction.NeedFinishReq);
								}
							}
							else
							{
								this.SetTrack(btPendingUpdateSetTrack.Value, ESetTrackReason.None);
							}
						}
						else
						{
							this.UpdateChildQuestNodeState(btPendingUpdateChildQuestNodeStatus.NodeId, btPendingUpdateChildQuestNodeStatus.NodeStatus, btPendingUpdateChildQuestNodeStatus.Reason);
						}
					}
					else
					{
						this.UpdateNodeProgress(btPendingUpdateNodeProgress.NodeId, btPendingUpdateNodeProgress.NodeInfo);
					}
				}
				else
				{
					this.UpdateNodeState(btPendingUpdateNodeStatus.Reason, btPendingUpdateNodeStatus.NodeId, btPendingUpdateNodeStatus.NodeStatus);
				}
			}
			else
			{
				this.CreateNode(btPendingCreateNode.Reason, btPendingCreateNode.NodeInfo);
			}
		}
	}

	// Token: 0x0600B7E9 RID: 47081 RVA: 0x00363B88 File Offset: 0x00361D88
	public void UpdateNodeState(ENodeStatusUpdateReason reason, int nodeId, NodeStatus nodeStatus)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateNodeStatus data = new BtPendingUpdateNodeStatus
			{
				Reason = reason,
				NodeId = nodeId,
				NodeStatus = nodeStatus
			};
			this.AddToPendingProcessList(data);
			return;
		}
		BehaviorNodeBase node = this.GetNode(nodeId);
		if (node == null)
		{
			global::NodeInfo data2 = new global::NodeInfo
			{
				NodeId = nodeId,
				Info = new Aki.Protocol.NodeInfo
				{
					Status = nodeStatus
				}
			};
			this.CreateNode(reason, data2);
			return;
		}
		this.BlackBoard.UpdateNodeInStatusGroup(node, node.Status, nodeStatus);
		node.UpdateStatus(reason, nodeStatus);
		ForceClosedRestrictionComponentHolder forceClosedRestrictionHolder = this.ForceClosedRestrictionHolder;
		if (forceClosedRestrictionHolder == null)
		{
			return;
		}
		forceClosedRestrictionHolder.RefreshNode();
	}

	// Token: 0x0600B7EA RID: 47082 RVA: 0x00363C24 File Offset: 0x00361E24
	[NullableContext(2)]
	public void UpdateNodeProgress(int nodeId, ChildQuestNodeProgress data)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateNodeProgress data2 = new BtPendingUpdateNodeProgress
			{
				NodeId = nodeId,
				NodeInfo = data
			};
			this.AddToPendingProcessList(data2);
			return;
		}
		if (data == null)
		{
			return;
		}
		BehaviorNodeBase node = this.GetNode(nodeId);
		if (node == null)
		{
			return;
		}
		node.UpdateProgress(data);
	}

	// Token: 0x0600B7EB RID: 47083 RVA: 0x00363C74 File Offset: 0x00361E74
	public void UpdateChildQuestNodeState(int nodeId, ChildQuestNodeStatus nodeStatus, ENodeStatusUpdateReason reason)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateChildQuestNodeStatus data = new BtPendingUpdateChildQuestNodeStatus
			{
				NodeId = nodeId,
				NodeStatus = nodeStatus,
				Reason = reason
			};
			this.AddToPendingProcessList(data);
			return;
		}
		ChildQuestNodeBase childQuestNodeBase = this.GetNode(nodeId) as ChildQuestNodeBase;
		if (childQuestNodeBase == null)
		{
			return;
		}
		childQuestNodeBase.UpdateChildQuestStatus(nodeStatus, reason);
	}

	// Token: 0x0600B7EC RID: 47084 RVA: 0x00363CCA File Offset: 0x00361ECA
	[NullableContext(2)]
	public BehaviorNodeBase GetNode(int nodeId)
	{
		return this.BlackBoard.GetNode(new int?(nodeId));
	}

	// Token: 0x0600B7ED RID: 47085 RVA: 0x00363CDD File Offset: 0x00361EDD
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, BehaviorNodeBase> GetNodesByGroupId(ENodeGroup group)
	{
		return this.BlackBoard.GetNodesByGroupId(group);
	}

	// Token: 0x0600B7EE RID: 47086 RVA: 0x00363CEB File Offset: 0x00361EEB
	[return: Nullable(2)]
	public VarDefinePb GetTreeVarByKey(string key)
	{
		return this.BlackBoard.GetTreeVar(key);
	}

	// Token: 0x0600B7EF RID: 47087 RVA: 0x00363CF9 File Offset: 0x00361EF9
	public void AddTreeVarUpdateDelegate(string key, TTreeVarUpdateDelegate delegat)
	{
		this.BlackBoard.AddTreeVarUpdateDelegate(key, delegat);
	}

	// Token: 0x0600B7F0 RID: 47088 RVA: 0x00363D08 File Offset: 0x00361F08
	public void RemoveTreeVarUpdateDelegate(string key, TTreeVarUpdateDelegate @delegate)
	{
		this.BlackBoard.RemoveTreeVarUpdateDelegate(key, @delegate);
	}

	// Token: 0x0600B7F1 RID: 47089 RVA: 0x00363D18 File Offset: 0x00361F18
	public bool CheckCanGiveUp()
	{
		if (!CreatureModel.Instance.IsMyWorld())
		{
			return false;
		}
		QuestFailedBehaviorNode processingCanGiveupFailedNode = this.GetProcessingCanGiveupFailedNode();
		if (processingCanGiveupFailedNode == null)
		{
			return false;
		}
		if (!processingCanGiveupFailedNode.CanGiveUp.GetValueOrDefault())
		{
			return false;
		}
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return false;
		}
		bool result = true;
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ChildQuest && behaviorNodeBase is ChildQuestNodeBase && !((ChildQuestNodeBase)behaviorNodeBase).CanGiveUp)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600B7F2 RID: 47090 RVA: 0x00363DC4 File Offset: 0x00361FC4
	[NullableContext(2)]
	public QuestFailedBehaviorNode GetProcessingCanGiveupFailedNode()
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return null;
		}
		QuestFailedBehaviorNode result = null;
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			QuestFailedBehaviorNode questFailedBehaviorNode = behaviorNodeBase as QuestFailedBehaviorNode;
			if (questFailedBehaviorNode != null && questFailedBehaviorNode.CanGiveUp.GetValueOrDefault())
			{
				result = questFailedBehaviorNode;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600B7F3 RID: 47091 RVA: 0x00363E3C File Offset: 0x0036203C
	[NullableContext(2)]
	public QuestFailedBehaviorNode GetProcessingFailedNode()
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return null;
		}
		QuestFailedBehaviorNode result = null;
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.QuestFailed)
			{
				result = (behaviorNodeBase as QuestFailedBehaviorNode);
				break;
			}
		}
		return result;
	}

	// Token: 0x0600B7F4 RID: 47092 RVA: 0x00363EAC File Offset: 0x003620AC
	[NullableContext(2)]
	public BehaviorNodeBase GetCurrentActiveChildQuestNode(bool bIgnoreNoTrackExpression = true)
	{
		return this.BlackBoard.GetCurrentActiveChildQuestNode(bIgnoreNoTrackExpression);
	}

	// Token: 0x0600B7F5 RID: 47093 RVA: 0x00363EBA File Offset: 0x003620BA
	[NullableContext(2)]
	public List<int> GetActiveChildQuestNodesId()
	{
		return this.BlackBoard.GetActiveChildQuestNodesId();
	}

	// Token: 0x0600B7F6 RID: 47094 RVA: 0x00363EC7 File Offset: 0x003620C7
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<BehaviorNodeBase> GetCurrentActiveChildQuestNodes()
	{
		return this.BlackBoard.GetActiveChildQuestNodes();
	}

	// Token: 0x0600B7F7 RID: 47095 RVA: 0x00363ED4 File Offset: 0x003620D4
	public List<BehaviorNodeBase> GetCurrentActiveLogicNodes()
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.BlackBoard.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return new List<BehaviorNodeBase>();
		}
		List<BehaviorNodeBase> list = new List<BehaviorNodeBase>();
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ConditionSelector || behaviorNodeBase.NodeType == EBtNode.ParallelSelect || behaviorNodeBase.NodeType == EBtNode.Select || behaviorNodeBase.NodeType == EBtNode.Sequence)
			{
				list.Add(behaviorNodeBase);
			}
		}
		return list;
	}

	// Token: 0x0600B7F8 RID: 47096 RVA: 0x00363F6C File Offset: 0x0036216C
	[NullableContext(2)]
	public IReadOnlyList<int> GetCurrentCorrelativeEntities()
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return null;
		}
		this.CurrentCorrelativeEntities.Clear();
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ChildQuest)
			{
				ChildQuestNodeBase childQuestNodeBase = behaviorNodeBase as ChildQuestNodeBase;
				if (childQuestNodeBase != null)
				{
					List<int> correlativeEntities = childQuestNodeBase.GetCorrelativeEntities();
					if (correlativeEntities != null)
					{
						this.CurrentCorrelativeEntities.AddRange(correlativeEntities);
					}
				}
			}
		}
		return this.CurrentCorrelativeEntities;
	}

	// Token: 0x0600B7F9 RID: 47097 RVA: 0x00364004 File Offset: 0x00362204
	public bool ContainTag(EBehaviorTreeTag tag)
	{
		return this.BlackBoard.ContainTag(tag);
	}

	// Token: 0x0600B7FA RID: 47098 RVA: 0x00364012 File Offset: 0x00362212
	public Blackboard GetBlackBoard()
	{
		return this.BlackBoard;
	}

	// Token: 0x0600B7FB RID: 47099 RVA: 0x0036401A File Offset: 0x0036221A
	public void AddDynamicFlowNpc(int npcPbDataId)
	{
		this.FlowInfo.AddDynamicFlowNpc(npcPbDataId);
	}

	// Token: 0x0600B7FC RID: 47100 RVA: 0x00364028 File Offset: 0x00362228
	public void PrepareRollback(FailReason? reason = null, int? failNodeId = null)
	{
		this.SetRollbackWaiting(true);
		this.InnerFailNodeId = failNodeId.GetValueOrDefault();
		foreach (int sessionId in this.BlackBoard.GetCurrentExecuteActions())
		{
			LevelGeneralController.Instance.StopActionsExecute(sessionId);
		}
		int playerId = CreatureModel.Instance.GetPlayerId();
		ETeamLivingState groupLivingState = SceneTeamModel.Instance.GetGroupLivingState(playerId, ETeamGroupType.Battle);
		if (reason.GetValueOrDefault() == FailReason.CharacterDieFail && groupLivingState == ETeamLivingState.Dead)
		{
			EventSystem.Instance.Add<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			return;
		}
		this.TryRollback(reason);
	}

	// Token: 0x0600B7FD RID: 47101 RVA: 0x003640DC File Offset: 0x003622DC
	public void StopCurrentActions()
	{
		foreach (int sessionId in this.BlackBoard.GetCurrentExecuteActions())
		{
			LevelGeneralController.Instance.StopActionsExecute(sessionId);
		}
	}

	// Token: 0x0600B7FE RID: 47102 RVA: 0x00364134 File Offset: 0x00362334
	public unsafe void ExecuteTreeGuaranteeActions(ETreeRemoveReason removeReason = ETreeRemoveReason.TreeDestroy)
	{
		List<GuaranteeActionInfo> guaranteeActions = this.BlackBoard.GetGuaranteeActions(true);
		if (guaranteeActions.Count == 0)
		{
			return;
		}
		GuaranteeContext context = (removeReason == ETreeRemoveReason.TreeRollback) ? GuaranteeContext.Create(null, EGuaranteeReason.TreeRollback) : GuaranteeContext.Create(null, EGuaranteeReason.TreeDestroy);
		GuaranteeController.Instance.ExecuteActions(guaranteeActions, context);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.LevelEvent;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "树保底行为已全部完成";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("treeIncId", this.BlackBoard.TreeConfigId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("保底行为列表", guaranteeActions);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600B7FF RID: 47103 RVA: 0x003641EA File Offset: 0x003623EA
	private void OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState state, ETeamLivingState oldState)
	{
		if (isMyTeam && groupType == ETeamGroupType.Battle && state == ETeamLivingState.Alive)
		{
			EventSystem.Instance.Remove<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			this.TryRollback(new FailReason?(FailReason.CharacterDieFail));
		}
	}

	// Token: 0x0600B800 RID: 47104 RVA: 0x00364220 File Offset: 0x00362420
	private void OnGeneralLogicTreeRollbackWaitingUpdate()
	{
		this.TryRollback(null);
	}

	// Token: 0x0600B801 RID: 47105 RVA: 0x0036423C File Offset: 0x0036243C
	private void TryRollback(FailReason? reason = null)
	{
		if (this.BlackBoard.ContainTag(EBehaviorTreeTag.RollbackWaiting))
		{
			GeneralLogicTreeController.Instance.RequestRollback(this.TreeIncId, reason);
		}
	}

	// Token: 0x0600B802 RID: 47106 RVA: 0x00364260 File Offset: 0x00362460
	public void SetRollbackWaiting(bool value)
	{
		if (value && !this.BlackBoard.ContainTag(EBehaviorTreeTag.RollbackWaiting))
		{
			this.BlackBoard.AddTag(EBehaviorTreeTag.RollbackWaiting, "");
			return;
		}
		if (!value && this.BlackBoard.ContainTag(EBehaviorTreeTag.RollbackWaiting))
		{
			this.BlackBoard.RemoveTag(EBehaviorTreeTag.RollbackWaiting, "");
		}
	}

	// Token: 0x0600B803 RID: 47107 RVA: 0x003642B2 File Offset: 0x003624B2
	public bool IsTracking()
	{
		return this.BlackBoard.IsTracking;
	}

	// Token: 0x0600B804 RID: 47108 RVA: 0x003642C0 File Offset: 0x003624C0
	public unsafe void SetTrack(bool value, ESetTrackReason reason = ESetTrackReason.None)
	{
		if (value && this.BlackBoard.IsSuspend())
		{
			return;
		}
		if (this.BlackBoard.NoExpression)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "没有表现的行为树设置了追踪";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("btType", this.BtType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("treeConfigId", this.TreeConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("treeIncId", this.TreeIncId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateSetTrack data = new BtPendingUpdateSetTrack
			{
				Value = value
			};
			this.AddToPendingProcessList(data);
			return;
		}
		if (this.BlackBoard.IsTracking == value)
		{
			return;
		}
		this.BlackBoard.IsTracking = value;
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if ((bindingExpressionHolder != null && bindingExpressionHolder.IsValid()) || !value)
		{
			BindingExpressionComponentHolder bindingExpressionHolder2 = this.BindingExpressionHolder;
			if (bindingExpressionHolder2 != null)
			{
				bindingExpressionHolder2.EnableTrack(value, reason, BindingExpressionComponentHolder.EUpdateTrackType.Text | BindingExpressionComponentHolder.EUpdateTrackType.TrackMark);
			}
		}
		BindingExpressionComponentHolder bindingExpressionHolder3 = this.BindingExpressionHolder;
		if (bindingExpressionHolder3 == null || !bindingExpressionHolder3.IsValid() || !value)
		{
			this.Expression.UpdateLevelPlayConditionalMarks();
			this.Expression.EnableTrack(value, reason, false);
		}
		EventSystem.Instance.Emit<BtType, long?>(EEventName.OnLogicTreeTrackUpdate, this.BtType, new long?(this.TreeIncId));
	}

	// Token: 0x0600B805 RID: 47109 RVA: 0x00364437 File Offset: 0x00362637
	public void SetMapMarkResident(bool bResident)
	{
		this.BlackBoard.SetMapMarkResident(bResident);
	}

	// Token: 0x0600B806 RID: 47110 RVA: 0x00364445 File Offset: 0x00362645
	public bool GetMapMarkResident()
	{
		return this.BlackBoard.GetMapMarkResident();
	}

	// Token: 0x0600B807 RID: 47111 RVA: 0x00364452 File Offset: 0x00362652
	public void SetUseInnerTrackIconId(bool bUseInner)
	{
		this.BlackBoard.SetUseInnerTrackIconId(bUseInner);
	}

	// Token: 0x0600B808 RID: 47112 RVA: 0x00364460 File Offset: 0x00362660
	public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return;
		}
		expression.StartTextExpress(reason);
	}

	// Token: 0x0600B809 RID: 47113 RVA: 0x00364473 File Offset: 0x00362673
	public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return;
		}
		expression.EndTextExpress(reason);
	}

	// Token: 0x0600B80A RID: 47114 RVA: 0x00364486 File Offset: 0x00362686
	[NullableContext(2)]
	public SilentAreaShowInfo GetSilentAreaShowInfo()
	{
		return this.BlackBoard.GetSilentAreaShowInfo();
	}

	// Token: 0x0600B80B RID: 47115 RVA: 0x00364493 File Offset: 0x00362693
	[NullableContext(2)]
	public ModifyTrackAreaConfig GetModifyTrackAreaConfig()
	{
		return this.BlackBoard.GetModifyTrackAreaConfig();
	}

	// Token: 0x0600B80C RID: 47116 RVA: 0x003644A0 File Offset: 0x003626A0
	public int GetTrackIconId()
	{
		return this.BlackBoard.TaskMarkTableId;
	}

	// Token: 0x0600B80D RID: 47117 RVA: 0x003644AD File Offset: 0x003626AD
	public bool CheckCanShow()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		return expression != null && expression.CheckCanShow(null);
	}

	// Token: 0x0600B80E RID: 47118 RVA: 0x003644C1 File Offset: 0x003626C1
	public bool CanShowTrackExpression()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		return expression != null && expression.CheckCanShowTrackExpression();
	}

	// Token: 0x0600B80F RID: 47119 RVA: 0x003644D4 File Offset: 0x003626D4
	[NullableContext(2)]
	public global::Vector GetNodeTrackPosition(int nodeId)
	{
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if (bindingExpressionHolder != null && bindingExpressionHolder.IsValid())
		{
			return this.BindingExpressionHolder.GetNodeTrackPosition();
		}
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return null;
		}
		return expression.GetNodeTrackPosition(nodeId);
	}

	// Token: 0x0600B810 RID: 47120 RVA: 0x00364508 File Offset: 0x00362708
	public int GetClosestMapMarkId()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return 0;
		}
		return expression.GetClosestMapMarkId();
	}

	// Token: 0x0600B811 RID: 47121 RVA: 0x0036451C File Offset: 0x0036271C
	public int? GetTrackAreaInfo(int nodeId)
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return null;
		}
		return expression.GetTrackAreaInfo(nodeId);
	}

	// Token: 0x0600B812 RID: 47122 RVA: 0x00364543 File Offset: 0x00362743
	public double GetTrackDistance(int nodeId)
	{
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if (bindingExpressionHolder != null && bindingExpressionHolder.IsValid())
		{
			return this.BindingExpressionHolder.GetTrackDistance();
		}
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return 0.0;
		}
		return expression.GetTrackDistance(nodeId);
	}

	// Token: 0x0600B813 RID: 47123 RVA: 0x00364580 File Offset: 0x00362780
	public int? GetDefaultMark(int nodeId)
	{
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if (bindingExpressionHolder != null && bindingExpressionHolder.IsValid())
		{
			return new int?(this.BindingExpressionHolder.GetDefaultMark());
		}
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return null;
		}
		return expression.GetDefaultMark(nodeId);
	}

	// Token: 0x0600B814 RID: 47124 RVA: 0x003645CC File Offset: 0x003627CC
	public bool IsInTrackRange()
	{
		return this.BlackBoard.ContainTag(EBehaviorTreeTag.InTrackRange);
	}

	// Token: 0x0600B815 RID: 47125 RVA: 0x003645DB File Offset: 0x003627DB
	public bool IsRangeTrack(int nodeId)
	{
		return this.GetRangeMarkSize(nodeId) != 0.0;
	}

	// Token: 0x0600B816 RID: 47126 RVA: 0x003645F2 File Offset: 0x003627F2
	public double GetRangeMarkSize(int nodeId)
	{
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if (bindingExpressionHolder != null && bindingExpressionHolder.IsValid())
		{
			return this.BindingExpressionHolder.GetRangeMarkSize();
		}
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return 0.0;
		}
		return expression.GetRangeMarkSize(nodeId);
	}

	// Token: 0x0600B817 RID: 47127 RVA: 0x00364630 File Offset: 0x00362830
	public double GetRangeMarkShowDis(int nodeId)
	{
		BindingExpressionComponentHolder bindingExpressionHolder = this.BindingExpressionHolder;
		if (bindingExpressionHolder != null && bindingExpressionHolder.IsValid())
		{
			return this.BindingExpressionHolder.GetRangeMarkShowDis();
		}
		BehaviorTreeExpressionComponent expression = this.Expression;
		return ((expression != null) ? expression.GetRangeMarkShowDis(nodeId) : null).GetValueOrDefault();
	}

	// Token: 0x0600B818 RID: 47128 RVA: 0x00364680 File Offset: 0x00362880
	public double GetGuideLineHideDistance(int nodeId)
	{
		if (!this.IsInTrackRange())
		{
			return 0.0;
		}
		return this.GetRangeMarkSize(nodeId);
	}

	// Token: 0x0600B819 RID: 47129 RVA: 0x0036469C File Offset: 0x0036289C
	public EActiveNodeShortcutShow GetCurrentNodeShortcutShow()
	{
		if (this.BlackBoard.ContainTag(EBehaviorTreeTag.CanCommunicateAgain))
		{
			return EActiveNodeShortcutShow.Communicate;
		}
		if (this.BlackBoard.ContainTag(EBehaviorTreeTag.CanChallengeAgain))
		{
			return EActiveNodeShortcutShow.ChallengeAgain;
		}
		if (this.CheckCanGiveUp())
		{
			return EActiveNodeShortcutShow.GiveUp;
		}
		ITrackCustomBoard currentNodeCustomTrackBoard = this.GetCurrentNodeCustomTrackBoard();
		if (((currentNodeCustomTrackBoard != null) ? currentNodeCustomTrackBoard.TrackPhoneMessageBoard : null) != null)
		{
			return EActiveNodeShortcutShow.PhoneMessage;
		}
		if (FastReturnUtil.Resolve(this) != null)
		{
			return EActiveNodeShortcutShow.FastReturn;
		}
		if (((currentNodeCustomTrackBoard != null) ? currentNodeCustomTrackBoard.TrackQuestBranchBoard : null) != null)
		{
			return EActiveNodeShortcutShow.QuestMultiLineView;
		}
		if (((currentNodeCustomTrackBoard != null) ? currentNodeCustomTrackBoard.SheriffAnomalyProgressBoard : null) != null)
		{
			return EActiveNodeShortcutShow.SheriffAnomalyProgress;
		}
		if (((currentNodeCustomTrackBoard != null) ? currentNodeCustomTrackBoard.SheriffReasoningBoard : null) != null)
		{
			return EActiveNodeShortcutShow.SheriffReasoningBoard;
		}
		if (SheriffModel.Instance.IsShortcutShowMainBoard(this))
		{
			return EActiveNodeShortcutShow.SheriffMainBoard;
		}
		if (((currentNodeCustomTrackBoard != null) ? currentNodeCustomTrackBoard.SheriffClueDetailBoard : null) != null)
		{
			return EActiveNodeShortcutShow.SheriffClueDetail;
		}
		return EActiveNodeShortcutShow.None;
	}

	// Token: 0x0600B81A RID: 47130 RVA: 0x00364748 File Offset: 0x00362948
	public string GetGiveUpText()
	{
		QuestFailedBehaviorNode processingCanGiveupFailedNode = this.GetProcessingCanGiveupFailedNode();
		if (processingCanGiveupFailedNode == null || string.IsNullOrEmpty(processingCanGiveupFailedNode.GiveUpText))
		{
			return "";
		}
		return PublicUtil.Instance.GetConfigTextByKey(processingCanGiveupFailedNode.GiveUpText);
	}

	// Token: 0x0600B81B RID: 47131 RVA: 0x00364782 File Offset: 0x00362982
	public void CreateMapMarks()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return;
		}
		expression.CreateMapMarks();
	}

	// Token: 0x0600B81C RID: 47132 RVA: 0x00364794 File Offset: 0x00362994
	[NullableContext(2)]
	public ITrackCustomBoard GetCurrentNodeCustomTrackBoard()
	{
		List<BehaviorNodeBase> currentActiveChildQuestNodes = this.GetCurrentActiveChildQuestNodes();
		if (currentActiveChildQuestNodes == null || currentActiveChildQuestNodes.Count == 0)
		{
			return null;
		}
		ITrackCustomBoard trackCustomBoard = null;
		ECustomTrackBoardPriority ecustomTrackBoardPriority = ECustomTrackBoardPriority.Undefined;
		foreach (BehaviorNodeBase behaviorNodeBase in currentActiveChildQuestNodes)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ChildQuest)
			{
				ChildQuestNodeBase childQuestNodeBase = behaviorNodeBase as ChildQuestNodeBase;
				if (childQuestNodeBase != null && childQuestNodeBase.TrackCustomBoard != null)
				{
					ECustomTrackBoardPriority nodeCustomTrackBoardPriority = this.GetNodeCustomTrackBoardPriority(behaviorNodeBase);
					trackCustomBoard = ((nodeCustomTrackBoardPriority > ecustomTrackBoardPriority) ? childQuestNodeBase.TrackCustomBoard : trackCustomBoard);
					ecustomTrackBoardPriority = ((nodeCustomTrackBoardPriority > ecustomTrackBoardPriority) ? nodeCustomTrackBoardPriority : ecustomTrackBoardPriority);
				}
			}
		}
		return trackCustomBoard;
	}

	// Token: 0x0600B81D RID: 47133 RVA: 0x0036483C File Offset: 0x00362A3C
	public ECustomTrackBoardPriority GetNodeCustomTrackBoardPriority(BehaviorNodeBase node)
	{
		if (node.NodeType != EBtNode.ChildQuest)
		{
			return ECustomTrackBoardPriority.Undefined;
		}
		ChildQuestNodeBase childQuestNodeBase = node as ChildQuestNodeBase;
		if (childQuestNodeBase == null)
		{
			return ECustomTrackBoardPriority.Undefined;
		}
		ITrackCustomBoard trackCustomBoard = childQuestNodeBase.TrackCustomBoard;
		if (((trackCustomBoard != null) ? trackCustomBoard.TrackReturnDungeon : null) != null)
		{
			return ECustomTrackBoardPriority.FastReturnDungeon;
		}
		ITrackCustomBoard trackCustomBoard2 = childQuestNodeBase.TrackCustomBoard;
		if (((trackCustomBoard2 != null) ? trackCustomBoard2.TrackPhoneMessageBoard : null) != null)
		{
			return ECustomTrackBoardPriority.PhoneMessage;
		}
		ITrackCustomBoard trackCustomBoard3 = childQuestNodeBase.TrackCustomBoard;
		if (((trackCustomBoard3 != null) ? trackCustomBoard3.SheriffAnomalyProgressBoard : null) != null)
		{
			return ECustomTrackBoardPriority.SheriffAnomalyProgress;
		}
		ITrackCustomBoard trackCustomBoard4 = childQuestNodeBase.TrackCustomBoard;
		if (((trackCustomBoard4 != null) ? trackCustomBoard4.SheriffReasoningBoard : null) != null)
		{
			return ECustomTrackBoardPriority.SheriffReasoning;
		}
		ITrackCustomBoard trackCustomBoard5 = childQuestNodeBase.TrackCustomBoard;
		if (((trackCustomBoard5 != null) ? trackCustomBoard5.SheriffClueDetailBoard : null) != null)
		{
			return ECustomTrackBoardPriority.SheriffClueDetail;
		}
		return ECustomTrackBoardPriority.Default;
	}

	// Token: 0x0600B81E RID: 47134 RVA: 0x003648D0 File Offset: 0x00362AD0
	public unsafe void DoAction(GameCtxPb context, int nodeId, int playerId, int sessionId, int startIndex, int endIndex, bool needFinishReq)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingDoAction data = new BtPendingDoAction
			{
				Context = context,
				NodeId = nodeId,
				PlayerId = playerId,
				SessionId = sessionId,
				StartIndex = startIndex,
				EndIndex = endIndex,
				NeedFinishReq = needFinishReq
			};
			this.AddToPendingProcessList(data);
			return;
		}
		IBtNode nodeConfig = this.BlackBoard.GetNodeConfig(nodeId);
		if (nodeConfig == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "服务器推送执行行为时，没有找到节点配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("context", context);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("treeConfigId", this.TreeConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("nodeId", nodeId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		List<ActionInfo> list = null;
		GameCtxType ctxType = context.CtxType;
		if (ctxType <= GameCtxType.CompositionConditionEnterAction)
		{
			switch (ctxType)
			{
			case GameCtxType.ChildQuestNodeEnterAction:
				if (nodeConfig.Type == EBtNode.ChildQuest)
				{
					IChildQuestBtNode childQuestBtNode = nodeConfig as IChildQuestBtNode;
					if (childQuestBtNode != null)
					{
						list = childQuestBtNode.EnterActions;
					}
				}
				break;
			case GameCtxType.ChildQuestNodeFinishAction:
				if (nodeConfig.Type == EBtNode.ChildQuest)
				{
					IChildQuestBtNode childQuestBtNode2 = nodeConfig as IChildQuestBtNode;
					if (childQuestBtNode2 != null)
					{
						list = childQuestBtNode2.FinishActions;
					}
				}
				break;
			case GameCtxType.SuccessNodeAction:
				if (nodeConfig.Type == EBtNode.QuestSucceed)
				{
					IQuestSucceedBtNode questSucceedBtNode = nodeConfig as IQuestSucceedBtNode;
					if (questSucceedBtNode != null)
					{
						list = questSucceedBtNode.FinishActions;
					}
				}
				break;
			case GameCtxType.FailedNodeAction:
				if (nodeConfig.Type == EBtNode.QuestFailed)
				{
					IQuestFailedBtNode questFailedBtNode = nodeConfig as IQuestFailedBtNode;
					if (questFailedBtNode != null)
					{
						list = questFailedBtNode.FinishActions;
					}
				}
				break;
			case GameCtxType.CompositionEnterAction:
				if (nodeConfig.Type == EBtNode.ConditionSelector || nodeConfig.Type == EBtNode.ParallelSelect || nodeConfig.Type == EBtNode.Select || nodeConfig.Type == EBtNode.Sequence)
				{
					ILogicBtNode logicBtNode = nodeConfig as ILogicBtNode;
					if (logicBtNode != null)
					{
						ISaveConfig saveConfig = logicBtNode.SaveConfig;
						list = ((saveConfig != null) ? saveConfig.EnterActions : null);
					}
				}
				break;
			case GameCtxType.EntityConditionListeningAction:
			case GameCtxType.PlayFlowChildQuestNode:
			case GameCtxType.HandInItemChildQuestNode:
			case GameCtxType.DoInteractChildQuestNode:
				break;
			case GameCtxType.ActionGroupNodeAction:
				if (nodeConfig.Type == EBtNode.Action)
				{
					IActionBtNode actionBtNode = nodeConfig as IActionBtNode;
					if (actionBtNode != null)
					{
						list = actionBtNode.Actions;
					}
				}
				break;
			default:
				if (ctxType == GameCtxType.CompositionConditionEnterAction)
				{
					if (nodeConfig.Type == EBtNode.ConditionSelector || nodeConfig.Type == EBtNode.ParallelSelect || nodeConfig.Type == EBtNode.Select || nodeConfig.Type == EBtNode.Sequence)
					{
						ILogicBtNode logicBtNode2 = nodeConfig as ILogicBtNode;
						if (logicBtNode2 != null)
						{
							int conditionIndex = context.CompositionConditionEnterAction.ConditionIndex;
							ISaveConfig saveConfig2 = logicBtNode2.SaveConfig;
							object obj;
							if (saveConfig2 == null)
							{
								obj = null;
							}
							else
							{
								List<IInitConditionActions> initConditionActions = saveConfig2.InitConditionActions;
								obj = ((initConditionActions != null) ? initConditionActions.GetValueOrDefault(conditionIndex) : null);
							}
							object obj2 = obj;
							list = ((obj2 != null) ? obj2.Action : null);
						}
					}
				}
				break;
			}
		}
		else if (ctxType != GameCtxType.ChildQuestNodeStuckCheckAction)
		{
			if (ctxType == GameCtxType.RollBlockGamePlayActionCtx)
			{
				if (nodeConfig.Type == EBtNode.ChildQuest)
				{
					IChildQuestBtNode childQuestBtNode3 = nodeConfig as IChildQuestBtNode;
					if (childQuestBtNode3 != null && childQuestBtNode3.Condition.Type == EChildQuest.FinishRollBlock)
					{
						IFinishRollBlock finishRollBlock = childQuestBtNode3.Condition as IFinishRollBlock;
						if (finishRollBlock != null)
						{
							RollBlockGamePlayActionCtxPb rollBlockGamePlayActionCtxPb = context.RollBlockGamePlayActionCtxPb;
							if (rollBlockGamePlayActionCtxPb != null && rollBlockGamePlayActionCtxPb.Type == RollBlockGameActionType.RbEnter)
							{
								list = finishRollBlock.EnterActions;
							}
							else
							{
								RollBlockGamePlayActionCtxPb rollBlockGamePlayActionCtxPb2 = context.RollBlockGamePlayActionCtxPb;
								if (rollBlockGamePlayActionCtxPb2 != null && rollBlockGamePlayActionCtxPb2.Type == RollBlockGameActionType.RbMidWayExit)
								{
									list = finishRollBlock.ExitActions;
								}
								else
								{
									RollBlockGamePlayActionCtxPb rollBlockGamePlayActionCtxPb3 = context.RollBlockGamePlayActionCtxPb;
									if (rollBlockGamePlayActionCtxPb3 != null && rollBlockGamePlayActionCtxPb3.Type == RollBlockGameActionType.RbPass)
									{
										list = finishRollBlock.CompleteActions;
									}
								}
							}
						}
					}
				}
			}
		}
		else if (nodeConfig.Type == EBtNode.ChildQuest)
		{
			IChildQuestBtNode childQuestBtNode4 = nodeConfig as IChildQuestBtNode;
			if (childQuestBtNode4 != null)
			{
				list = childQuestBtNode4.StuckCheck[context.StuckCheckCtxPb.Index].Actions;
			}
		}
		if (list == null || list.Count == 0)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module2 = ELogModule.GeneralLogicTree;
			ELogAuthor author2 = ELogAuthor.YSQ;
			string message2 = "服务器推送执行行为时，没有找到行为配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("contextType", context.CtxType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("treeConfigId", this.TreeConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("nodeId", nodeId);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		this.BlackBoard.AddCurrentExecuteActions(sessionId);
		LevelGeneralController.Instance.ExecuteActionsByServerNotify(list, GeneralLogicTreeContext.Create(this.BtType, this.TreeIncId, this.TreeConfigId, nodeId, new GameCtxType?(context.CtxType)), playerId, sessionId, startIndex, endIndex, needFinishReq, delegate(ELevelEventState _)
		{
			this.BlackBoard.RemoveCurrentExecuteActions(sessionId);
		});
	}

	// Token: 0x0600B81F RID: 47135 RVA: 0x00364D9C File Offset: 0x00362F9C
	public void UpdateTimer(TimerInfoPb timerInfo)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateUpdateTimer data = new BtPendingUpdateUpdateTimer
			{
				TimerInfo = timerInfo
			};
			this.AddToPendingProcessList(data);
			return;
		}
		this.TimerCenter.UpdateTimerInfo(timerInfo);
		EventSystem.Instance.Emit<long>(EEventName.OnGeneralLogicTreeTimerUpdate, this.TreeIncId);
	}

	// Token: 0x0600B820 RID: 47136 RVA: 0x00364DF0 File Offset: 0x00362FF0
	public double GetChallengeRemainTime(ETimerType? timerType = null)
	{
		ETimerType value = timerType.GetValueOrDefault();
		if (timerType == null)
		{
			value = ETimerType.CountDownChallenge;
			timerType = new ETimerType?(value);
		}
		return this.TimerCenter.GetRemainTime(timerType);
	}

	// Token: 0x0600B821 RID: 47137 RVA: 0x00364E24 File Offset: 0x00363024
	public bool HasRunningTimers([Nullable(new byte[]
	{
		2,
		1
	})] List<string> includes = null, [Nullable(new byte[]
	{
		2,
		1
	})] List<string> excludes = null)
	{
		return this.TimerCenter.HasRunningTimers(includes, excludes);
	}

	// Token: 0x0600B822 RID: 47138 RVA: 0x00364E34 File Offset: 0x00363034
	public void UpdateTreeVars(BtVarUpdateNotify notify)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateTreeVars data = new BtPendingUpdateTreeVars
			{
				Notify = notify
			};
			this.AddToPendingProcessList(data);
			return;
		}
		this.BlackBoard.UpdateTreeVar(notify.VarName, notify.VarDefine);
		EventSystem.Instance.Emit<long>(EEventName.GeneralLogicTreeViewForceRefresh, this.TreeIncId);
	}

	// Token: 0x0600B823 RID: 47139 RVA: 0x00364E90 File Offset: 0x00363090
	public bool IsSuspend()
	{
		return this.BlackBoard.IsSuspend();
	}

	// Token: 0x0600B824 RID: 47140 RVA: 0x00364E9D File Offset: 0x0036309D
	public EBehaviorTreeSuspendType GetSuspendType()
	{
		return this.Suspend.GetSuspendType();
	}

	// Token: 0x0600B825 RID: 47141 RVA: 0x00364EAA File Offset: 0x003630AA
	[NullableContext(2)]
	public string GetSuspendText()
	{
		return this.Suspend.GetSuspendText();
	}

	// Token: 0x0600B826 RID: 47142 RVA: 0x00364EB7 File Offset: 0x003630B7
	public IReadOnlyList<IOccupationInfo> GetOccupations()
	{
		return this.Suspend.GetOccupations();
	}

	// Token: 0x0600B827 RID: 47143 RVA: 0x00364EC4 File Offset: 0x003630C4
	public void UpdateOccupations(int suspendNodeId, int suspendType, IReadOnlyList<OccupationPbInfo> occupationInfo)
	{
		if (this.BlackBoard.IsSleeping)
		{
			BtPendingUpdateOccupations data = new BtPendingUpdateOccupations
			{
				SuspendNodeId = suspendNodeId,
				SuspendType = suspendType,
				OccupationInfo = occupationInfo
			};
			this.AddToPendingProcessList(data);
			return;
		}
		this.Suspend.UpdateOccupations(suspendNodeId, suspendType, occupationInfo);
		if (suspendType == 0)
		{
			ForceClosedRestrictionComponentHolder forceClosedRestrictionHolder = this.ForceClosedRestrictionHolder;
			if (forceClosedRestrictionHolder == null)
			{
				return;
			}
			forceClosedRestrictionHolder.OnCancelSuspend();
			return;
		}
		else
		{
			ForceClosedRestrictionComponentHolder forceClosedRestrictionHolder2 = this.ForceClosedRestrictionHolder;
			if (forceClosedRestrictionHolder2 == null)
			{
				return;
			}
			forceClosedRestrictionHolder2.OnSuspend();
			return;
		}
	}

	// Token: 0x0600B828 RID: 47144 RVA: 0x00364F33 File Offset: 0x00363133
	public bool HasRefOccupiedEntity()
	{
		return this.BlackBoard.HasRefOccupiedEntity();
	}

	// Token: 0x0600B829 RID: 47145 RVA: 0x00364F40 File Offset: 0x00363140
	[NullableContext(2)]
	public string GetRefOccupiedEntityText()
	{
		return this.BlackBoard.GetRefOccupiedEntityText();
	}

	// Token: 0x0600B82A RID: 47146 RVA: 0x00364F4D File Offset: 0x0036314D
	[NullableContext(2)]
	public IBtNode GetNodeConfig(int nodeId)
	{
		return this.BlackBoard.GetNodeConfig(nodeId);
	}

	// Token: 0x0600B82B RID: 47147 RVA: 0x00364F5B File Offset: 0x0036315B
	public void AddGuaranteeActionInfo(string instigatorName, int nodeId, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode)
	{
		this.BlackBoard.AddGuaranteeActionInfo(instigatorName, nodeId, targetActionInfo, compareMode);
	}

	// Token: 0x0600B82C RID: 47148 RVA: 0x00364F6D File Offset: 0x0036316D
	[return: Nullable(2)]
	public GuaranteeActionInfo PopGuaranteeActionInfo(string instigatorName, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode = EActionFilterMode.SameAction)
	{
		return this.BlackBoard.PopGuaranteeActionInfo(instigatorName, targetActionInfo, compareMode);
	}

	// Token: 0x0600B82D RID: 47149 RVA: 0x00364F7D File Offset: 0x0036317D
	public void ClearGuaranteeActions(int nodeId = 0)
	{
		this.BlackBoard.ClearGuaranteeActions(nodeId);
	}

	// Token: 0x0600B82E RID: 47150 RVA: 0x00364F8B File Offset: 0x0036318B
	public int GetRollbackPoint()
	{
		return this.BlackBoard.RollbackPoint;
	}

	// Token: 0x040069FD RID: 27133
	protected readonly Blackboard BlackBoard = new Blackboard();

	// Token: 0x040069FE RID: 27134
	[Nullable(2)]
	protected DynamicFlowInfo FlowInfo;

	// Token: 0x040069FF RID: 27135
	[Nullable(2)]
	public BehaviorTreeExpressionComponent Expression;

	// Token: 0x04006A00 RID: 27136
	[Nullable(2)]
	public BindingExpressionComponentHolder BindingExpressionHolder;

	// Token: 0x04006A01 RID: 27137
	[Nullable(2)]
	public ForceClosedRestrictionComponentHolder ForceClosedRestrictionHolder;

	// Token: 0x04006A02 RID: 27138
	[Nullable(2)]
	protected BehaviorTreeTimerCenter TimerCenter;

	// Token: 0x04006A03 RID: 27139
	[Nullable(2)]
	protected BehaviorTreeSuspendComponent Suspend;

	// Token: 0x04006A04 RID: 27140
	private readonly List<int> CurrentCorrelativeEntities = new List<int>();

	// Token: 0x04006A05 RID: 27141
	private readonly Queue<BehaviorTreePendingProcess> PendingProcess = new Queue<BehaviorTreePendingProcess>(4);

	// Token: 0x04006A06 RID: 27142
	protected int InnerFailNodeId;

	// Token: 0x04006A07 RID: 27143
	public bool IsPendingDestroy;
}
