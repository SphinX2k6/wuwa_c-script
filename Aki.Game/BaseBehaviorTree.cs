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

// Token: 0x02001D53 RID: 7507
[NullableContext(1)]
[Nullable(0)]
public class BaseBehaviorTree
{
	// Token: 0x1700122F RID: 4655
	// (get) Token: 0x0600E3B9 RID: 58297 RVA: 0x00357A3F File Offset: 0x00355C3F
	public BtType BtType
	{
		get
		{
			return this.BlackBoard.BtType;
		}
	}

	// Token: 0x17001230 RID: 4656
	// (get) Token: 0x0600E3BA RID: 58298 RVA: 0x00357A4C File Offset: 0x00355C4C
	public long TreeIncId
	{
		get
		{
			return this.BlackBoard.TreeIncId;
		}
	}

	// Token: 0x17001231 RID: 4657
	// (get) Token: 0x0600E3BB RID: 58299 RVA: 0x00357A59 File Offset: 0x00355C59
	public int TreeConfigId
	{
		get
		{
			return this.BlackBoard.TreeConfigId;
		}
	}

	// Token: 0x17001232 RID: 4658
	// (get) Token: 0x0600E3BC RID: 58300 RVA: 0x00357A66 File Offset: 0x00355C66
	public int DungeonId
	{
		get
		{
			return this.BlackBoard.DungeonId;
		}
	}

	// Token: 0x17001233 RID: 4659
	// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x00357A73 File Offset: 0x00355C73
	public int FailNodeId
	{
		get
		{
			return this.InnerFailNodeId;
		}
	}

	// Token: 0x0600E3BE RID: 58302 RVA: 0x00357A7B File Offset: 0x00355C7B
	public void ClearFailNodeId()
	{
		this.InnerFailNodeId = 0;
	}

	// Token: 0x0600E3BF RID: 58303 RVA: 0x00357A84 File Offset: 0x00355C84
	public BaseBehaviorTree(long id, int configId, BtType btType, int dungeonId, int taskMarkTableId, string onlineType, int showPriority, bool? bNewQuest = null, bool? bDisableExpression = null)
	{
		this.BlackBoard.Init(btType, id, configId, dungeonId, taskMarkTableId, onlineType, showPriority, bDisableExpression.GetValueOrDefault());
		if (bNewQuest.GetValueOrDefault())
		{
			this.BlackBoard.AddTag(EBehaviorTreeTag.NewQuest, "");
		}
	}

	// Token: 0x0600E3C0 RID: 58304 RVA: 0x00357AF0 File Offset: 0x00355CF0
	public void InitTree(TreeInfo treeInfo, bool bSleep = false)
	{
		this.InitComponents();
		this.SetSleep(bSleep);
		this.Recover(treeInfo);
		this.OnAddEvent();
	}

	// Token: 0x0600E3C1 RID: 58305 RVA: 0x00357B0C File Offset: 0x00355D0C
	public void Destroy()
	{
		this.OnRemoveEvent();
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

	// Token: 0x0600E3C2 RID: 58306 RVA: 0x00357B70 File Offset: 0x00355D70
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
		return behaviorNodeBase;
	}

	// Token: 0x0600E3C3 RID: 58307 RVA: 0x00357C0E File Offset: 0x00355E0E
	private void AddToPendingProcessList(BehaviorTreePendingProcess data)
	{
		this.PendingProcess.Push(data);
	}

	// Token: 0x0600E3C4 RID: 58308 RVA: 0x00357C1C File Offset: 0x00355E1C
	private void InitComponents()
	{
		this.FlowInfo = new DynamicFlowInfo();
		this.TimerCenter = new BehaviorTreeTimerCenter(this.TreeIncId, this.BlackBoard);
		this.Suspend = new BehaviorTreeSuspendComponent(this.TreeIncId, this.BlackBoard);
		if (!this.BlackBoard.NoExpression)
		{
			this.Expression = new BehaviorTreeExpressionComponent(this.BlackBoard);
			this.Expression.Init();
			this.BindingExpressionHolder = new BindingExpressionComponentHolder(this.BlackBoard);
			this.BindingExpressionHolder.Init();
		}
	}

	// Token: 0x0600E3C5 RID: 58309 RVA: 0x00357CA8 File Offset: 0x00355EA8
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

	// Token: 0x0600E3C6 RID: 58310 RVA: 0x00357D08 File Offset: 0x00355F08
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

	// Token: 0x0600E3C7 RID: 58311 RVA: 0x00357DB4 File Offset: 0x00355FB4
	private void RecoverTimers(IList<TimerInfoPb> timerInfos)
	{
		foreach (TimerInfoPb timerInfo in timerInfos)
		{
			this.UpdateTimer(timerInfo);
		}
	}

	// Token: 0x0600E3C8 RID: 58312 RVA: 0x00357DFC File Offset: 0x00355FFC
	private void RecoverVars(IDictionary<string, VarDefinePb> vars)
	{
		foreach (string text in vars.Keys)
		{
			VarDefinePb varDefine = vars[text];
			this.BlackBoard.UpdateTreeVar(text, varDefine);
		}
	}

	// Token: 0x0600E3C9 RID: 58313 RVA: 0x00357E58 File Offset: 0x00356058
	private void OnAddEvent()
	{
		EventSystem.Instance.AddWithTarget(this.BlackBoard, EEventName.GeneralLogicTreeRollbackWaitingUpdate, new Action(this.OnGeneralLogicTreeRollbackWaitingUpdate));
	}

	// Token: 0x0600E3CA RID: 58314 RVA: 0x00357E7C File Offset: 0x0035607C
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

	// Token: 0x0600E3CB RID: 58315 RVA: 0x00357F08 File Offset: 0x00356108
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

	// Token: 0x0600E3CC RID: 58316 RVA: 0x003580D8 File Offset: 0x003562D8
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
		if (node != null)
		{
			this.BlackBoard.UpdateNodeInStatusGroup(node, node.Status, nodeStatus);
			node.UpdateStatus(reason, nodeStatus);
			return;
		}
		global::NodeInfo data2 = new global::NodeInfo
		{
			NodeId = nodeId,
			Info = new Aki.Protocol.NodeInfo
			{
				Status = nodeStatus
			}
		};
		this.CreateNode(reason, data2);
	}

	// Token: 0x0600E3CD RID: 58317 RVA: 0x00358164 File Offset: 0x00356364
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

	// Token: 0x0600E3CE RID: 58318 RVA: 0x003581B4 File Offset: 0x003563B4
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

	// Token: 0x0600E3CF RID: 58319 RVA: 0x0035820A File Offset: 0x0035640A
	[NullableContext(2)]
	public BehaviorNodeBase GetNode(int nodeId)
	{
		return this.BlackBoard.GetNode(new int?(nodeId));
	}

	// Token: 0x0600E3D0 RID: 58320 RVA: 0x0035821D File Offset: 0x0035641D
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, BehaviorNodeBase> GetNodesByGroupId(ENodeGroup group)
	{
		return this.BlackBoard.GetNodesByGroupId(group);
	}

	// Token: 0x0600E3D1 RID: 58321 RVA: 0x0035822B File Offset: 0x0035642B
	[return: Nullable(2)]
	public VarDefinePb GetTreeVarByKey(string key)
	{
		return this.BlackBoard.GetTreeVar(key);
	}

	// Token: 0x0600E3D2 RID: 58322 RVA: 0x00358239 File Offset: 0x00356439
	public void AddTreeVarUpdateDelegate(string key, TTreeVarUpdateDelegate delegat)
	{
		this.BlackBoard.AddTreeVarUpdateDelegate(key, delegat);
	}

	// Token: 0x0600E3D3 RID: 58323 RVA: 0x00358248 File Offset: 0x00356448
	public void RemoveTreeVarUpdateDelegate(string key, TTreeVarUpdateDelegate @delegate)
	{
		this.BlackBoard.RemoveTreeVarUpdateDelegate(key, @delegate);
	}

	// Token: 0x0600E3D4 RID: 58324 RVA: 0x00358258 File Offset: 0x00356458
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

	// Token: 0x0600E3D5 RID: 58325 RVA: 0x00358304 File Offset: 0x00356504
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

	// Token: 0x0600E3D6 RID: 58326 RVA: 0x0035837C File Offset: 0x0035657C
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

	// Token: 0x0600E3D7 RID: 58327 RVA: 0x003583EC File Offset: 0x003565EC
	[NullableContext(2)]
	public BehaviorNodeBase GetCurrentActiveChildQuestNode(bool bIgnoreNoTrackExpression = true)
	{
		return this.BlackBoard.GetCurrentActiveChildQuestNode(bIgnoreNoTrackExpression);
	}

	// Token: 0x0600E3D8 RID: 58328 RVA: 0x003583FA File Offset: 0x003565FA
	[NullableContext(2)]
	public List<int> GetActiveChildQuestNodesId()
	{
		return this.BlackBoard.GetActiveChildQuestNodesId();
	}

	// Token: 0x0600E3D9 RID: 58329 RVA: 0x00358407 File Offset: 0x00356607
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<BehaviorNodeBase> GetCurrentActiveChildQuestNodes()
	{
		return this.BlackBoard.GetActiveChildQuestNodes();
	}

	// Token: 0x0600E3DA RID: 58330 RVA: 0x00358414 File Offset: 0x00356614
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

	// Token: 0x0600E3DB RID: 58331 RVA: 0x003584AC File Offset: 0x003566AC
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

	// Token: 0x0600E3DC RID: 58332 RVA: 0x00358544 File Offset: 0x00356744
	public bool ContainTag(EBehaviorTreeTag tag)
	{
		return this.BlackBoard.ContainTag(tag);
	}

	// Token: 0x0600E3DD RID: 58333 RVA: 0x00358552 File Offset: 0x00356752
	public Blackboard GetBlackBoard()
	{
		return this.BlackBoard;
	}

	// Token: 0x0600E3DE RID: 58334 RVA: 0x0035855A File Offset: 0x0035675A
	public void AddDynamicFlowNpc(int npcPbDataId)
	{
		this.FlowInfo.AddDynamicFlowNpc(npcPbDataId);
	}

	// Token: 0x0600E3DF RID: 58335 RVA: 0x00358568 File Offset: 0x00356768
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

	// Token: 0x0600E3E0 RID: 58336 RVA: 0x0035861C File Offset: 0x0035681C
	public void StopCurrentActions()
	{
		foreach (int sessionId in this.BlackBoard.GetCurrentExecuteActions())
		{
			LevelGeneralController.Instance.StopActionsExecute(sessionId);
		}
	}

	// Token: 0x0600E3E1 RID: 58337 RVA: 0x00358674 File Offset: 0x00356874
	public unsafe void ExecuteTreeGuaranteeActions(ETreeRemoveReason removeReason = ETreeRemoveReason.TreeDestroy)
	{
		List<GuaranteeActionInfo> guaranteeActions = this.BlackBoard.GetGuaranteeActions();
		if (guaranteeActions.Count == 0)
		{
			return;
		}
		List<GuaranteeActionInfo> list = new List<GuaranteeActionInfo>(guaranteeActions);
		list.Reverse();
		GuaranteeContext context = (removeReason == ETreeRemoveReason.TreeRollback) ? GuaranteeContext.Create(null, EGuaranteeReason.TreeRollback) : GuaranteeContext.Create(null, EGuaranteeReason.TreeDestroy);
		GuaranteeController.Instance.ExecuteActions(list, context);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.LevelEvent;
		ELogAuthor author = ELogAuthor.ZYL;
		string message = "树保底行为已全部完成";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("treeIncId", this.BlackBoard.TreeConfigId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("保底行为列表", list);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0600E3E2 RID: 58338 RVA: 0x00358738 File Offset: 0x00356938
	private void OnTeamLivingStateChange(bool isMyTeam, ETeamGroupType groupType, ETeamLivingState state, ETeamLivingState oldState)
	{
		if (isMyTeam && groupType == ETeamGroupType.Battle && state == ETeamLivingState.Alive)
		{
			EventSystem.Instance.Remove<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(EEventName.OnTeamLivingStateChange, new Action<bool, ETeamGroupType, ETeamLivingState, ETeamLivingState>(this.OnTeamLivingStateChange));
			this.TryRollback(new FailReason?(FailReason.CharacterDieFail));
		}
	}

	// Token: 0x0600E3E3 RID: 58339 RVA: 0x00358770 File Offset: 0x00356970
	private void OnGeneralLogicTreeRollbackWaitingUpdate()
	{
		this.TryRollback(null);
	}

	// Token: 0x0600E3E4 RID: 58340 RVA: 0x0035878C File Offset: 0x0035698C
	private void TryRollback(FailReason? reason = null)
	{
		if (this.BlackBoard.ContainTag(EBehaviorTreeTag.RollbackWaiting))
		{
			GeneralLogicTreeController.Instance.RequestRollback(this.TreeIncId, reason);
		}
	}

	// Token: 0x0600E3E5 RID: 58341 RVA: 0x003587B0 File Offset: 0x003569B0
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

	// Token: 0x0600E3E6 RID: 58342 RVA: 0x00358802 File Offset: 0x00356A02
	public bool IsTracking()
	{
		return this.BlackBoard.IsTracking;
	}

	// Token: 0x0600E3E7 RID: 58343 RVA: 0x00358810 File Offset: 0x00356A10
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

	// Token: 0x0600E3E8 RID: 58344 RVA: 0x00358987 File Offset: 0x00356B87
	public void SetMapMarkResident(bool bResident)
	{
		this.BlackBoard.SetMapMarkResident(bResident);
	}

	// Token: 0x0600E3E9 RID: 58345 RVA: 0x00358995 File Offset: 0x00356B95
	public bool GetMapMarkResident()
	{
		return this.BlackBoard.GetMapMarkResident();
	}

	// Token: 0x0600E3EA RID: 58346 RVA: 0x003589A2 File Offset: 0x00356BA2
	public void SetUseInnerTrackIconId(bool bUseInner)
	{
		this.BlackBoard.SetUseInnerTrackIconId(bUseInner);
	}

	// Token: 0x0600E3EB RID: 58347 RVA: 0x003589B0 File Offset: 0x00356BB0
	public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return;
		}
		expression.StartTextExpress(reason);
	}

	// Token: 0x0600E3EC RID: 58348 RVA: 0x003589C3 File Offset: 0x00356BC3
	public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return;
		}
		expression.EndTextExpress(reason);
	}

	// Token: 0x0600E3ED RID: 58349 RVA: 0x003589D6 File Offset: 0x00356BD6
	[NullableContext(2)]
	public SilentAreaShowInfo GetSilentAreaShowInfo()
	{
		return this.BlackBoard.GetSilentAreaShowInfo();
	}

	// Token: 0x0600E3EE RID: 58350 RVA: 0x003589E3 File Offset: 0x00356BE3
	[NullableContext(2)]
	public ModifyTrackAreaConfig GetModifyTrackAreaConfig()
	{
		return this.BlackBoard.GetModifyTrackAreaConfig();
	}

	// Token: 0x0600E3EF RID: 58351 RVA: 0x003589F0 File Offset: 0x00356BF0
	public int GetTrackIconId()
	{
		return this.BlackBoard.TaskMarkTableId;
	}

	// Token: 0x0600E3F0 RID: 58352 RVA: 0x003589FD File Offset: 0x00356BFD
	public bool CheckCanShow()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		return expression != null && expression.CheckCanShow(null);
	}

	// Token: 0x0600E3F1 RID: 58353 RVA: 0x00358A11 File Offset: 0x00356C11
	public bool CanShowTrackExpression()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		return expression != null && expression.CheckCanShowTrackExpression();
	}

	// Token: 0x0600E3F2 RID: 58354 RVA: 0x00358A24 File Offset: 0x00356C24
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

	// Token: 0x0600E3F3 RID: 58355 RVA: 0x00358A58 File Offset: 0x00356C58
	public int GetClosestMapMarkId()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return 0;
		}
		return expression.GetClosestMapMarkId();
	}

	// Token: 0x0600E3F4 RID: 58356 RVA: 0x00358A6C File Offset: 0x00356C6C
	public int? GetTrackAreaInfo(int nodeId)
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return null;
		}
		return expression.GetTrackAreaInfo(nodeId);
	}

	// Token: 0x0600E3F5 RID: 58357 RVA: 0x00358A93 File Offset: 0x00356C93
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

	// Token: 0x0600E3F6 RID: 58358 RVA: 0x00358AD0 File Offset: 0x00356CD0
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

	// Token: 0x0600E3F7 RID: 58359 RVA: 0x00358B1C File Offset: 0x00356D1C
	public bool IsInTrackRange()
	{
		return this.BlackBoard.ContainTag(EBehaviorTreeTag.InTrackRange);
	}

	// Token: 0x0600E3F8 RID: 58360 RVA: 0x00358B2B File Offset: 0x00356D2B
	public bool IsRangeTrack(int nodeId)
	{
		return this.GetRangeMarkSize(nodeId) != 0.0;
	}

	// Token: 0x0600E3F9 RID: 58361 RVA: 0x00358B42 File Offset: 0x00356D42
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

	// Token: 0x0600E3FA RID: 58362 RVA: 0x00358B80 File Offset: 0x00356D80
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

	// Token: 0x0600E3FB RID: 58363 RVA: 0x00358BD0 File Offset: 0x00356DD0
	public double GetGuideLineHideDistance(int nodeId)
	{
		if (!this.IsInTrackRange())
		{
			return 0.0;
		}
		return this.GetRangeMarkSize(nodeId);
	}

	// Token: 0x0600E3FC RID: 58364 RVA: 0x00358BEC File Offset: 0x00356DEC
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

	// Token: 0x0600E3FD RID: 58365 RVA: 0x00358C98 File Offset: 0x00356E98
	public string GetGiveUpText()
	{
		QuestFailedBehaviorNode processingCanGiveupFailedNode = this.GetProcessingCanGiveupFailedNode();
		if (processingCanGiveupFailedNode == null || string.IsNullOrEmpty(processingCanGiveupFailedNode.GiveUpText))
		{
			return "";
		}
		return PublicUtil.Instance.GetConfigTextByKey(processingCanGiveupFailedNode.GiveUpText);
	}

	// Token: 0x0600E3FE RID: 58366 RVA: 0x00358CD2 File Offset: 0x00356ED2
	public void CreateMapMarks()
	{
		BehaviorTreeExpressionComponent expression = this.Expression;
		if (expression == null)
		{
			return;
		}
		expression.CreateMapMarks();
	}

	// Token: 0x0600E3FF RID: 58367 RVA: 0x00358CE4 File Offset: 0x00356EE4
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

	// Token: 0x0600E400 RID: 58368 RVA: 0x00358D8C File Offset: 0x00356F8C
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

	// Token: 0x0600E401 RID: 58369 RVA: 0x00358E20 File Offset: 0x00357020
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

	// Token: 0x0600E402 RID: 58370 RVA: 0x003592EC File Offset: 0x003574EC
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

	// Token: 0x0600E403 RID: 58371 RVA: 0x00359340 File Offset: 0x00357540
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

	// Token: 0x0600E404 RID: 58372 RVA: 0x00359374 File Offset: 0x00357574
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

	// Token: 0x0600E405 RID: 58373 RVA: 0x00359384 File Offset: 0x00357584
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

	// Token: 0x0600E406 RID: 58374 RVA: 0x003593E0 File Offset: 0x003575E0
	public bool IsSuspend()
	{
		return this.BlackBoard.IsSuspend();
	}

	// Token: 0x0600E407 RID: 58375 RVA: 0x003593ED File Offset: 0x003575ED
	public EBehaviorTreeSuspendType GetSuspendType()
	{
		return this.Suspend.GetSuspendType();
	}

	// Token: 0x0600E408 RID: 58376 RVA: 0x003593FA File Offset: 0x003575FA
	[NullableContext(2)]
	public string GetSuspendText()
	{
		return this.Suspend.GetSuspendText();
	}

	// Token: 0x0600E409 RID: 58377 RVA: 0x00359407 File Offset: 0x00357607
	public IReadOnlyList<IOccupationInfo> GetOccupations()
	{
		return this.Suspend.GetOccupations();
	}

	// Token: 0x0600E40A RID: 58378 RVA: 0x00359414 File Offset: 0x00357614
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
	}

	// Token: 0x0600E40B RID: 58379 RVA: 0x0035945F File Offset: 0x0035765F
	public bool HasRefOccupiedEntity()
	{
		return this.BlackBoard.HasRefOccupiedEntity();
	}

	// Token: 0x0600E40C RID: 58380 RVA: 0x0035946C File Offset: 0x0035766C
	[NullableContext(2)]
	public string GetRefOccupiedEntityText()
	{
		return this.BlackBoard.GetRefOccupiedEntityText();
	}

	// Token: 0x0600E40D RID: 58381 RVA: 0x00359479 File Offset: 0x00357679
	[NullableContext(2)]
	public IBtNode GetNodeConfig(int nodeId)
	{
		return this.BlackBoard.GetNodeConfig(nodeId);
	}

	// Token: 0x0600E40E RID: 58382 RVA: 0x00359487 File Offset: 0x00357687
	public void AddGuaranteeActionInfo(string instigatorName, int nodeId, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode)
	{
		this.BlackBoard.AddGuaranteeActionInfo(instigatorName, nodeId, targetActionInfo, compareMode);
	}

	// Token: 0x0600E40F RID: 58383 RVA: 0x00359499 File Offset: 0x00357699
	[return: Nullable(2)]
	public GuaranteeActionInfo PopGuaranteeActionInfo(string instigatorName, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode = EActionFilterMode.SameAction)
	{
		return this.BlackBoard.PopGuaranteeActionInfo(instigatorName, targetActionInfo, compareMode);
	}

	// Token: 0x0600E410 RID: 58384 RVA: 0x003594A9 File Offset: 0x003576A9
	public void ClearGuaranteeActions(int nodeId = 0)
	{
		this.BlackBoard.ClearGuaranteeActions(nodeId);
	}

	// Token: 0x0600E411 RID: 58385 RVA: 0x003594B7 File Offset: 0x003576B7
	public int GetRollbackPoint()
	{
		return this.BlackBoard.RollbackPoint;
	}

	// Token: 0x0400691E RID: 26910
	protected readonly Blackboard BlackBoard = new Blackboard();

	// Token: 0x0400691F RID: 26911
	[Nullable(2)]
	protected DynamicFlowInfo FlowInfo;

	// Token: 0x04006920 RID: 26912
	[Nullable(2)]
	public BehaviorTreeExpressionComponent Expression;

	// Token: 0x04006921 RID: 26913
	[Nullable(2)]
	public BindingExpressionComponentHolder BindingExpressionHolder;

	// Token: 0x04006922 RID: 26914
	[Nullable(2)]
	protected BehaviorTreeTimerCenter TimerCenter;

	// Token: 0x04006923 RID: 26915
	[Nullable(2)]
	protected BehaviorTreeSuspendComponent Suspend;

	// Token: 0x04006924 RID: 26916
	private readonly List<int> CurrentCorrelativeEntities = new List<int>();

	// Token: 0x04006925 RID: 26917
	private readonly Queue<BehaviorTreePendingProcess> PendingProcess = new Queue<BehaviorTreePendingProcess>(4);

	// Token: 0x04006926 RID: 26918
	protected int InnerFailNodeId;

	// Token: 0x04006927 RID: 26919
	public bool IsPendingDestroy;
}
