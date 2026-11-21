using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.LevelGamePlay.Guarantee.GuaranteeActions;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree.Express;
using CSharpScript.Game.Module.GeneralLogicTree.BehaviorNode.ChildQuestNode;
using CSharpScript.Game.Module.Map.MapDefine;
using UnrealEngine;

// Token: 0x02001219 RID: 4633
[NullableContext(1)]
[Nullable(0)]
public class Blackboard : BehaviorTreeTagContainer
{
	// Token: 0x1700125E RID: 4702
	// (get) Token: 0x0600B841 RID: 47169 RVA: 0x003652D4 File Offset: 0x003634D4
	public int TaskMarkTableId
	{
		get
		{
			if (this.IsTrackBoundToParent)
			{
				BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(this.BoundParentTreeId, false);
				if (behaviorTree != null)
				{
					return behaviorTree.GetBlackBoard().TaskMarkTableId;
				}
			}
			if (this.UseInnerTrackIconId)
			{
				return this.TaskMarkTableIdInner;
			}
			if (this.BtType == BtType.Quest || this.BtType == BtType.Recall)
			{
				return this.TaskMarkTableIdInner;
			}
			if (!this.IsChallengeUi())
			{
				return this.TaskMarkTableIdInner;
			}
			return 9;
		}
	}

	// Token: 0x1700125F RID: 4703
	// (get) Token: 0x0600B842 RID: 47170 RVA: 0x00365343 File Offset: 0x00363543
	public bool IsTrackBoundToParent
	{
		get
		{
			return this.BoundParentTreeId != null;
		}
	}

	// Token: 0x17001260 RID: 4704
	// (get) Token: 0x0600B843 RID: 47171 RVA: 0x00365350 File Offset: 0x00363550
	[Nullable(2)]
	public ITrackLevelPlay BoundTrackLevelPlayConfig
	{
		[NullableContext(2)]
		get
		{
			if (!this.IsTrackBoundToParent)
			{
				return null;
			}
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(this.BoundParentTreeId, false);
			if (behaviorTree == null)
			{
				return null;
			}
			BehaviorNodeBase node = behaviorTree.GetBlackBoard().GetNode(this.BoundParentNodeId);
			if (node == null)
			{
				return null;
			}
			ITrackTarget trackTarget = node.TrackTarget;
			return ((trackTarget != null) ? trackTarget.TrackType : null) as ITrackLevelPlay;
		}
	}

	// Token: 0x17001261 RID: 4705
	// (get) Token: 0x0600B844 RID: 47172 RVA: 0x003653AC File Offset: 0x003635AC
	public bool IsBindingLevelPlayTrack
	{
		get
		{
			BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.TreeIncId), false);
			bool? flag;
			if (behaviorTree == null)
			{
				flag = null;
			}
			else
			{
				BindingExpressionComponentHolder bindingExpressionHolder = behaviorTree.BindingExpressionHolder;
				flag = ((bindingExpressionHolder != null) ? new bool?(bindingExpressionHolder.IsValid()) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}
	}

	// Token: 0x17001262 RID: 4706
	// (get) Token: 0x0600B845 RID: 47173 RVA: 0x00365404 File Offset: 0x00363604
	// (set) Token: 0x0600B846 RID: 47174 RVA: 0x0036540C File Offset: 0x0036360C
	public int DungeonId
	{
		get
		{
			return this.CurrentDungeonId;
		}
		set
		{
			this.CurrentDungeonId = ((value != 0) ? value : this.OriginalDungeonId);
		}
	}

	// Token: 0x17001263 RID: 4707
	// (get) Token: 0x0600B847 RID: 47175 RVA: 0x00365420 File Offset: 0x00363620
	// (set) Token: 0x0600B848 RID: 47176 RVA: 0x00365428 File Offset: 0x00363628
	public int ChangeDungeonIdNodeId
	{
		get
		{
			return this.ChangeCurrentDungeonIdNodeId;
		}
		set
		{
			this.ChangeCurrentDungeonIdNodeId = value;
		}
	}

	// Token: 0x17001264 RID: 4708
	// (get) Token: 0x0600B849 RID: 47177 RVA: 0x00365434 File Offset: 0x00363634
	public bool IsOccupied
	{
		get
		{
			GeneralLogicTreeModel instance = GeneralLogicTreeModel.Instance;
			return instance.IsExpressionInOccupying() && !instance.IsExpressionOccupyingByTree(this.TreeIncId);
		}
	}

	// Token: 0x0600B84A RID: 47178 RVA: 0x00365460 File Offset: 0x00363660
	public void Init(BtType btType, long treeIncId, int treeConfigId, int dungeonId, int taskMarkTableId, string onlineType, int showPriority, bool bNoExpression)
	{
		this.BtType = btType;
		this.TreeIncId = treeIncId;
		this.TreeConfigId = treeConfigId;
		this.OriginalDungeonId = dungeonId;
		this.CurrentDungeonId = dungeonId;
		this.OnlineType = onlineType;
		this.ShowPriority = showPriority;
		this.NoExpression = bNoExpression;
		this.TaskMarkTableIdInner = taskMarkTableId;
		switch (this.BtType)
		{
		case BtType.Quest:
		case BtType.Recall:
			this.TrackSource = ETrackSource.Quest;
			return;
		case BtType.LevelPlay:
			this.TrackSource = ETrackSource.SceneGameplay;
			return;
		case BtType.Inst:
			this.TrackSource = ETrackSource.Instance;
			break;
		case BtType.InstDecision:
			break;
		default:
			return;
		}
	}

	// Token: 0x0600B84B RID: 47179 RVA: 0x003654F0 File Offset: 0x003636F0
	public void Dispose()
	{
		this.ClearNodes();
		this.TreeVars.Clear();
		this.TreeVarsUpdateDelegate.Clear();
		this.RefOccupationIds.Clear();
		this.GuaranteeActions.Clear();
		this.GuaranteeActionsGroupByNodeId.Clear();
		this.CurrentExecuteActionsId.Clear();
	}

	// Token: 0x0600B84C RID: 47180 RVA: 0x00365545 File Offset: 0x00363745
	public void AddNode(int nodeId, BehaviorNodeBase node)
	{
		this.Nodes[nodeId] = node;
	}

	// Token: 0x0600B84D RID: 47181 RVA: 0x00365554 File Offset: 0x00363754
	public void AddNodeToStatusGroup(BehaviorNodeBase node, NodeStatus newStatus)
	{
		ENodeGroup groupIdByStatus = this.GetGroupIdByStatus(newStatus);
		Dictionary<int, BehaviorNodeBase> dictionary;
		if (!this.NodesGroupByStatus.TryGetValue((int)groupIdByStatus, out dictionary))
		{
			dictionary = (this.NodesGroupByStatus[(int)groupIdByStatus] = new Dictionary<int, BehaviorNodeBase>());
		}
		dictionary[node.NodeId] = node;
	}

	// Token: 0x0600B84E RID: 47182 RVA: 0x0036559C File Offset: 0x0036379C
	public void AddTreeVarUpdateDelegate(string varName, TTreeVarUpdateDelegate @delegate)
	{
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (!this.TreeVarsUpdateDelegate.TryGetValue(varName, out hashSet))
		{
			hashSet = (this.TreeVarsUpdateDelegate[varName] = new HashSet<TTreeVarUpdateDelegate>());
		}
		hashSet.Add(@delegate);
	}

	// Token: 0x0600B84F RID: 47183 RVA: 0x003655D4 File Offset: 0x003637D4
	public void RemoveTreeVarUpdateDelegate(string varName, TTreeVarUpdateDelegate @delegate)
	{
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (this.TreeVarsUpdateDelegate.TryGetValue(varName, out hashSet))
		{
			hashSet.Remove(@delegate);
		}
	}

	// Token: 0x0600B850 RID: 47184 RVA: 0x003655FC File Offset: 0x003637FC
	public void UpdateTreeVar(string varName, VarDefinePb varDefine)
	{
		VarDefinePb valueOrDefault = this.TreeVars.GetValueOrDefault(varName);
		this.TreeVars[varName] = varDefine;
		HashSet<TTreeVarUpdateDelegate> hashSet;
		if (this.TreeVarsUpdateDelegate.TryGetValue(varName, out hashSet))
		{
			foreach (TTreeVarUpdateDelegate ttreeVarUpdateDelegate in hashSet)
			{
				ttreeVarUpdateDelegate(valueOrDefault, varDefine);
			}
		}
	}

	// Token: 0x0600B851 RID: 47185 RVA: 0x00365674 File Offset: 0x00363874
	[return: Nullable(2)]
	public VarDefinePb GetTreeVar(string varName)
	{
		return this.TreeVars.GetValueOrDefault(varName);
	}

	// Token: 0x0600B852 RID: 47186 RVA: 0x00365684 File Offset: 0x00363884
	public void UpdateNodeInStatusGroup(BehaviorNodeBase node, NodeStatus oldStatus, NodeStatus newStatus)
	{
		if (oldStatus == newStatus)
		{
			return;
		}
		ENodeGroup groupIdByStatus = this.GetGroupIdByStatus(oldStatus);
		Dictionary<int, BehaviorNodeBase> dictionary;
		if (this.NodesGroupByStatus.TryGetValue((int)groupIdByStatus, out dictionary))
		{
			dictionary.Remove(node.NodeId);
		}
		this.AddNodeToStatusGroup(node, newStatus);
	}

	// Token: 0x0600B853 RID: 47187 RVA: 0x003656C3 File Offset: 0x003638C3
	public IReadOnlyDictionary<int, BehaviorNodeBase> GetAllNodes()
	{
		return this.Nodes;
	}

	// Token: 0x0600B854 RID: 47188 RVA: 0x003656CB File Offset: 0x003638CB
	[NullableContext(2)]
	public BehaviorNodeBase GetNode(int? nodeId)
	{
		if (nodeId == null)
		{
			return null;
		}
		return this.Nodes.GetValueOrDefault(nodeId.Value);
	}

	// Token: 0x0600B855 RID: 47189 RVA: 0x003656EA File Offset: 0x003638EA
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, BehaviorNodeBase> GetNodesByGroupId(ENodeGroup group)
	{
		return this.NodesGroupByStatus.GetValueOrDefault((int)group);
	}

	// Token: 0x0600B856 RID: 47190 RVA: 0x003656F8 File Offset: 0x003638F8
	[NullableContext(2)]
	public BehaviorNodeBase GetCurrentActiveChildQuestNode(bool bIgnoreNoTrackExpression = true)
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return null;
		}
		BehaviorNodeBase result = null;
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ChildQuest && (!behaviorNodeBase.ContainTag(EBehaviorTreeTag.HideTrackExpression) || !bIgnoreNoTrackExpression))
			{
				result = behaviorNodeBase;
			}
		}
		return result;
	}

	// Token: 0x0600B857 RID: 47191 RVA: 0x0036576C File Offset: 0x0036396C
	[NullableContext(2)]
	public List<int> GetActiveChildQuestNodesId()
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return null;
		}
		List<int> list = new List<int>();
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ChildQuest)
			{
				list.Add(behaviorNodeBase.NodeId);
			}
		}
		return list;
	}

	// Token: 0x0600B858 RID: 47192 RVA: 0x003657E4 File Offset: 0x003639E4
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<BehaviorNodeBase> GetActiveChildQuestNodes()
	{
		Dictionary<int, BehaviorNodeBase> nodesByGroupId = this.GetNodesByGroupId(ENodeGroup.IsProcessing);
		if (nodesByGroupId == null)
		{
			return null;
		}
		List<BehaviorNodeBase> list = new List<BehaviorNodeBase>();
		foreach (BehaviorNodeBase behaviorNodeBase in nodesByGroupId.Values)
		{
			if (behaviorNodeBase.NodeType == EBtNode.ChildQuest)
			{
				list.Add(behaviorNodeBase);
			}
		}
		return list;
	}

	// Token: 0x0600B859 RID: 47193 RVA: 0x00365858 File Offset: 0x00363A58
	private void ClearNodes()
	{
		foreach (BehaviorNodeBase behaviorNodeBase in this.Nodes.Values)
		{
			behaviorNodeBase.Destroy();
		}
		this.Nodes.Clear();
		this.NodesGroupByStatus.Clear();
	}

	// Token: 0x0600B85A RID: 47194 RVA: 0x003658C4 File Offset: 0x00363AC4
	public ENodeGroup GetGroupIdByStatus(NodeStatus status)
	{
		ENodeGroup result = ENodeGroup.NotActive;
		switch (status)
		{
		case NodeStatus.Activated:
		case NodeStatus.Completing:
			result = ENodeGroup.IsProcessing;
			break;
		case NodeStatus.CompletedSuccess:
			result = ENodeGroup.IsSuccess;
			break;
		case NodeStatus.CompletedFailed:
		case NodeStatus.Destroy:
			result = ENodeGroup.IsFailure;
			break;
		case NodeStatus.Suspend:
			result = ENodeGroup.Suspend;
			break;
		}
		return result;
	}

	// Token: 0x0600B85B RID: 47195 RVA: 0x0036590C File Offset: 0x00363B0C
	[NullableContext(2)]
	public unsafe IBtNode GetNodeConfig(int nodeId)
	{
		IBtNode nodeConfig = GeneralLogicTreeUtil.Instance.GetNodeConfig(this.BtType, this.TreeConfigId, nodeId);
		if (nodeConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "找不到节点配置";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("行为树类型", GeneralLogicTreeDefine.btTypeLogString[this.BtType]);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("行为树Id", this.TreeConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("节点Id", nodeId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		return nodeConfig;
	}

	// Token: 0x0600B85C RID: 47196 RVA: 0x003659C2 File Offset: 0x00363BC2
	public void SetMapMarkResident(bool bResident)
	{
		this.MapMarkResident = bResident;
	}

	// Token: 0x0600B85D RID: 47197 RVA: 0x003659CB File Offset: 0x00363BCB
	public bool GetMapMarkResident()
	{
		return this.MapMarkResident;
	}

	// Token: 0x0600B85E RID: 47198 RVA: 0x003659D3 File Offset: 0x00363BD3
	public void SetUseInnerTrackIconId(bool bResident)
	{
		this.UseInnerTrackIconId = bResident;
	}

	// Token: 0x0600B85F RID: 47199 RVA: 0x003659DC File Offset: 0x00363BDC
	public bool IsSuspend()
	{
		return base.ContainTag(EBehaviorTreeTag.Suspending);
	}

	// Token: 0x0600B860 RID: 47200 RVA: 0x003659E8 File Offset: 0x00363BE8
	public int? GetCurrentCommunicateId()
	{
		BehaviorNodeBase currentActiveChildQuestNode = this.GetCurrentActiveChildQuestNode(true);
		ChildQuestNodeBase childQuestNodeBase = currentActiveChildQuestNode as ChildQuestNodeBase;
		if (childQuestNodeBase == null || childQuestNodeBase.ChildQuestType != EChildQuest.ReceiveTelecom)
		{
			return null;
		}
		CommunicateNode communicateNode = currentActiveChildQuestNode as CommunicateNode;
		if (communicateNode == null)
		{
			return null;
		}
		return new int?(communicateNode.CommunicateId);
	}

	// Token: 0x0600B861 RID: 47201 RVA: 0x00365A39 File Offset: 0x00363C39
	public bool IsChallengeUi()
	{
		return base.ContainTag(EBehaviorTreeTag.ChallengeUi);
	}

	// Token: 0x0600B862 RID: 47202 RVA: 0x00365A43 File Offset: 0x00363C43
	public bool IsCustomUi()
	{
		return base.ContainTag(EBehaviorTreeTag.CustomUi);
	}

	// Token: 0x0600B863 RID: 47203 RVA: 0x00365A50 File Offset: 0x00363C50
	public BehaviorTreeViewShowData CreateShowData(bool bTrackText = true)
	{
		if (!base.ContainTag(EBehaviorTreeTag.BindingLevelPlayTrack))
		{
			return this.CreateOriginalShowData(bTrackText);
		}
		BaseBehaviorTree behaviorTree = GeneralLogicTreeModel.Instance.GetBehaviorTree(new long?(this.TreeIncId), false);
		bool flag;
		if (behaviorTree == null)
		{
			flag = true;
		}
		else
		{
			BindingExpressionComponentHolder bindingExpressionHolder = behaviorTree.BindingExpressionHolder;
			flag = !((bindingExpressionHolder != null) ? new bool?(bindingExpressionHolder.IsValid()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			return this.CreateOriginalShowData(bTrackText);
		}
		return behaviorTree.BindingExpressionHolder.GetShowData(bTrackText);
	}

	// Token: 0x0600B864 RID: 47204 RVA: 0x00365ACC File Offset: 0x00363CCC
	public BehaviorTreeViewShowData CreateOriginalShowData(bool bTrackText = true)
	{
		string text;
		if (this.BtType != BtType.Quest && this.BtType != BtType.Recall)
		{
			text = null;
		}
		else
		{
			global::Quest quest = QuestNewModel.Instance.GetQuest(this.TreeConfigId);
			text = ((quest != null) ? quest.NameKey : null);
		}
		string titleTextKey = text;
		if (!bTrackText)
		{
			return BehaviorTreeViewShowData.Create(this.BtType, this.TreeIncId, this.TreeConfigId, this.IsChallengeUi(), this.TaskMarkTableId, this.ShowPriority, titleTextKey, this.UiTrackTextInfo.MainTitle, this.UiTrackTextInfo.SubTitles, this.BoundParentTreeId);
		}
		BehaviorTreeStepTextInfo behaviorTreeStepTextInfo = null;
		BehaviorTreeStepTextInfo mainTitle = this.UiTrackTextInfo.MainTitle;
		if (mainTitle != null && !this.IsTrackTextNeedHide(mainTitle) && !StringUtils.IsBlank(PublicUtil.Instance.GetConfigTextByKey(mainTitle.TidTitle)))
		{
			behaviorTreeStepTextInfo = mainTitle;
		}
		List<BehaviorTreeStepTextInfo> list = null;
		if (this.UiTrackTextInfo.SubTitles.Count > 0)
		{
			list = new List<BehaviorTreeStepTextInfo>();
			foreach (BehaviorTreeStepTextInfo behaviorTreeStepTextInfo2 in this.UiTrackTextInfo.SubTitles)
			{
				if (!this.IsTrackTextNeedHide(behaviorTreeStepTextInfo2))
				{
					if (!StringUtils.IsBlank(PublicUtil.Instance.GetConfigTextByKey(behaviorTreeStepTextInfo2.TidTitle)))
					{
						list.Add(behaviorTreeStepTextInfo2);
					}
					else if (behaviorTreeStepTextInfo2.ConditionText != null)
					{
						foreach (IConditionText conditionText in behaviorTreeStepTextInfo2.ConditionText)
						{
							if (!StringUtils.IsBlank(PublicUtil.Instance.GetConfigTextByKey(conditionText.TidTitle)))
							{
								list.Add(behaviorTreeStepTextInfo2);
								break;
							}
						}
					}
				}
			}
			if (list.Count == 1 && behaviorTreeStepTextInfo == null)
			{
				behaviorTreeStepTextInfo = list[0];
				list.Clear();
			}
		}
		return BehaviorTreeViewShowData.Create(this.BtType, this.TreeIncId, this.TreeConfigId, this.IsChallengeUi(), this.TaskMarkTableId, this.ShowPriority, titleTextKey, behaviorTreeStepTextInfo, list, this.BoundParentTreeId);
	}

	// Token: 0x0600B865 RID: 47205 RVA: 0x00365CD8 File Offset: 0x00363ED8
	private bool IsTrackTextNeedHide(BehaviorTreeStepTextInfo treeTextInfo)
	{
		IQuestScheduleType questScheduleType = treeTextInfo.QuestScheduleType;
		if (questScheduleType != null && questScheduleType.Type == EQuestScheduleType.ChildQuestCompleted)
		{
			BehaviorNodeBase node = this.GetNode(new int?(((IQuestScheduleChildQuestCompleted)treeTextInfo.QuestScheduleType).ChildQuestId));
			return node != null && node.ContainTag(EBehaviorTreeTag.HideTrackExpression);
		}
		return false;
	}

	// Token: 0x0600B866 RID: 47206 RVA: 0x00365D26 File Offset: 0x00363F26
	[NullableContext(2)]
	public SilentAreaShowInfo GetSilentAreaShowInfo()
	{
		if (this.SilentAreaShowInfo.Count == 0)
		{
			return null;
		}
		return this.SilentAreaShowInfo[0];
	}

	// Token: 0x0600B867 RID: 47207 RVA: 0x00365D43 File Offset: 0x00363F43
	public override void AddTag(EBehaviorTreeTag tag, string reason = "")
	{
		base.AddTag(tag, reason);
		EventSystem.Instance.Emit<EBehaviorTreeTag>(EEventName.GeneralLogicTreeAddTag, tag);
	}

	// Token: 0x0600B868 RID: 47208 RVA: 0x00365D5E File Offset: 0x00363F5E
	public override void RemoveTag(EBehaviorTreeTag tag, string reason = "")
	{
		base.RemoveTag(tag, reason);
		EventSystem.Instance.Emit<EBehaviorTreeTag>(EEventName.GeneralLogicTreeRemoveTag, tag);
	}

	// Token: 0x0600B869 RID: 47209 RVA: 0x00365D7C File Offset: 0x00363F7C
	public void AddSilentShowInfo(int nodeId, IInformationViewType showInfo)
	{
		int num = this.SilentAreaShowInfo.FindIndex((SilentAreaShowInfo value) => value.SourceOfAdd == nodeId);
		if (num < 0)
		{
			this.SilentAreaShowInfo.Add(new SilentAreaShowInfo(nodeId, showInfo));
			return;
		}
		this.SilentAreaShowInfo[num].ShowInfo = showInfo;
	}

	// Token: 0x0600B86A RID: 47210 RVA: 0x00365DDC File Offset: 0x00363FDC
	public void RemoveSilentShowInfo(int nodeId)
	{
		int num = this.SilentAreaShowInfo.FindIndex((SilentAreaShowInfo value) => value.SourceOfAdd == nodeId);
		if (num < 0)
		{
			return;
		}
		this.SilentAreaShowInfo.RemoveAt(num);
	}

	// Token: 0x0600B86B RID: 47211 RVA: 0x00365E20 File Offset: 0x00364020
	public void AddModifyTrackAreaConfig(int nodeId, ITrackAreaText modifyTrackAreaConfig)
	{
		int num = this.ModifyTrackAreaConfig.FindIndex((ModifyTrackAreaConfig value) => value.SourceOfAdd == nodeId);
		if (num < 0)
		{
			this.ModifyTrackAreaConfig.Add(new ModifyTrackAreaConfig(nodeId, modifyTrackAreaConfig));
			return;
		}
		this.ModifyTrackAreaConfig[num].TrackConfig = modifyTrackAreaConfig;
	}

	// Token: 0x0600B86C RID: 47212 RVA: 0x00365E80 File Offset: 0x00364080
	public void RemoveModifyTrackAreaConfig(int nodeId)
	{
		int num = this.ModifyTrackAreaConfig.FindIndex((ModifyTrackAreaConfig value) => value.SourceOfAdd == nodeId);
		if (num < 0)
		{
			return;
		}
		this.ModifyTrackAreaConfig.RemoveAt(num);
	}

	// Token: 0x0600B86D RID: 47213 RVA: 0x00365EC3 File Offset: 0x003640C3
	[NullableContext(2)]
	public ModifyTrackAreaConfig GetModifyTrackAreaConfig()
	{
		if (this.ModifyTrackAreaConfig.Count == 0)
		{
			return null;
		}
		List<ModifyTrackAreaConfig> modifyTrackAreaConfig = this.ModifyTrackAreaConfig;
		return modifyTrackAreaConfig[modifyTrackAreaConfig.Count - 1];
	}

	// Token: 0x0600B86E RID: 47214 RVA: 0x00365EE7 File Offset: 0x003640E7
	public bool IsNeedScaledTrackMark(int nodeId)
	{
		return base.ContainTag(EBehaviorTreeTag.CustomUi) && this.UiTrackTextInfo.IsSubTitle(nodeId);
	}

	// Token: 0x0600B86F RID: 47215 RVA: 0x00365F04 File Offset: 0x00364104
	public void AddRefOccupationId(int nodeId, string occupationId)
	{
		List<int> list;
		if (!this.RefOccupationIds.TryGetValue(occupationId, out list))
		{
			list = (this.RefOccupationIds[occupationId] = new List<int>());
		}
		list.Add(nodeId);
	}

	// Token: 0x0600B870 RID: 47216 RVA: 0x00365F3C File Offset: 0x0036413C
	public void RemoveRefOccupationId(int nodeId, string occupationId)
	{
		List<int> list;
		if (this.RefOccupationIds.TryGetValue(occupationId, out list))
		{
			int num = list.IndexOf(nodeId);
			if (num < 0)
			{
				return;
			}
			list.RemoveAt(num);
			if (list.Count == 0)
			{
				this.RefOccupationIds.Remove(occupationId);
			}
		}
	}

	// Token: 0x0600B871 RID: 47217 RVA: 0x00365F84 File Offset: 0x00364184
	public bool HasRefOccupiedEntity()
	{
		if (this.BtType == BtType.Inst)
		{
			return false;
		}
		GeneralLogicTreeModel instance = GeneralLogicTreeModel.Instance;
		foreach (string resource in this.RefOccupationIds.Keys)
		{
			if (instance.IsOccupationExist(resource))
			{
				long? occupationTreeId = instance.GetOccupationTreeId(resource);
				long treeIncId = this.TreeIncId;
				if (!(occupationTreeId.GetValueOrDefault() == treeIncId & occupationTreeId != null))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600B872 RID: 47218 RVA: 0x00366020 File Offset: 0x00364220
	[NullableContext(2)]
	public string GetRefOccupiedEntityText()
	{
		if (!this.HasRefOccupiedEntity())
		{
			return null;
		}
		using (Dictionary<string, List<int>>.KeyCollection.Enumerator enumerator = this.RefOccupationIds.Keys.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				string text = enumerator.Current;
				string occupationQuestName = GeneralLogicTreeModel.Instance.GetOccupationQuestName(text);
				string textById = TextConfig.Instance.GetTextById("QuestResourcesIsOccupied");
				TArray<string> tarray = new TArray<string>();
				string occupationResourceName = QuestNewConfig.Instance.GetOccupationResourceName(text);
				tarray.Add(occupationResourceName);
				tarray.Add(occupationQuestName);
				return UKuroStaticLibrary.KuroFormatText(textById, tarray);
			}
		}
		return null;
	}

	// Token: 0x0600B873 RID: 47219 RVA: 0x003660C8 File Offset: 0x003642C8
	public bool HasSpecRefOccupiedEntity(IReadOnlyList<string> specRefOccupationIds)
	{
		foreach (string resource in specRefOccupationIds)
		{
			if (GeneralLogicTreeModel.Instance.IsOccupationExist(resource))
			{
				long? occupationTreeId = GeneralLogicTreeModel.Instance.GetOccupationTreeId(resource);
				long treeIncId = this.TreeIncId;
				if (!(occupationTreeId.GetValueOrDefault() == treeIncId & occupationTreeId != null))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600B874 RID: 47220 RVA: 0x00366148 File Offset: 0x00364348
	[return: Nullable(2)]
	public string GetSpecRefOccupiedEntityText(IReadOnlyList<string> specRefOccupationIds)
	{
		if (!this.HasSpecRefOccupiedEntity(specRefOccupationIds))
		{
			return null;
		}
		using (IEnumerator<string> enumerator = specRefOccupationIds.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				string text = enumerator.Current;
				string occupationQuestName = GeneralLogicTreeModel.Instance.GetOccupationQuestName(text);
				string textById = TextConfig.Instance.GetTextById("QuestResourcesIsOccupiedInfo");
				TArray<string> tarray = new TArray<string>();
				string occupationResourceName = QuestNewConfig.Instance.GetOccupationResourceName(text);
				tarray.Add(occupationResourceName);
				tarray.Add(occupationQuestName);
				return UKuroStaticLibrary.KuroFormatText(textById, tarray);
			}
		}
		return null;
	}

	// Token: 0x0600B875 RID: 47221 RVA: 0x003661E0 File Offset: 0x003643E0
	public unsafe void AddGuaranteeActionInfo(string instigatorName, int nodeId, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode)
	{
		if (!this.HasGuaranteeActionInfo(targetActionInfo, compareMode))
		{
			LinkedListNode<ValueTuple<int, GuaranteeActionInfo>> item = this.GuaranteeActions.AddLast(new ValueTuple<int, GuaranteeActionInfo>(nodeId, targetActionInfo));
			List<LinkedListNode<ValueTuple<int, GuaranteeActionInfo>>> list;
			if (!this.GuaranteeActionsGroupByNodeId.TryGetValue(nodeId, out list))
			{
				list = (this.GuaranteeActionsGroupByNodeId[nodeId] = new List<LinkedListNode<ValueTuple<int, GuaranteeActionInfo>>>());
			}
			list.Add(item);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.GeneralLogicTree;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "GeneralLogicTree:添加保底行为：" + targetActionInfo.Name.ToString();
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发行为", instigatorName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionInfo", targetActionInfo);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("treeConfigId", this.TreeConfigId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x0600B876 RID: 47222 RVA: 0x003662C8 File Offset: 0x003644C8
	private bool HasGuaranteeActionInfo(GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode)
	{
		if (compareMode == EActionFilterMode.Never)
		{
			return false;
		}
		foreach (ValueTuple<int, GuaranteeActionInfo> valueTuple in this.GuaranteeActions)
		{
			GuaranteeActionInfo item = valueTuple.Item2;
			if (compareMode == EActionFilterMode.SameName)
			{
				if (item.Name == targetActionInfo.Name)
				{
					return true;
				}
			}
			else if (GuaranteeActionCenter.Instance.IsSameAction(item, targetActionInfo))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600B877 RID: 47223 RVA: 0x0036634C File Offset: 0x0036454C
	[return: Nullable(2)]
	public unsafe GuaranteeActionInfo PopGuaranteeActionInfo(string instigatorName, GuaranteeActionInfo targetActionInfo, EActionFilterMode compareMode = EActionFilterMode.SameAction)
	{
		if (compareMode == EActionFilterMode.Never)
		{
			return null;
		}
		for (LinkedListNode<ValueTuple<int, GuaranteeActionInfo>> linkedListNode = this.GuaranteeActions.Last; linkedListNode != null; linkedListNode = linkedListNode.Previous)
		{
			GuaranteeActionInfo item = linkedListNode.Value.Item2;
			if (item.Name == targetActionInfo.Name && (compareMode != EActionFilterMode.SameAction || GuaranteeActionCenter.Instance.IsSameAction(item, targetActionInfo)))
			{
				this.GuaranteeActions.Remove(linkedListNode);
				List<LinkedListNode<ValueTuple<int, GuaranteeActionInfo>>> list;
				if (this.GuaranteeActionsGroupByNodeId.TryGetValue(linkedListNode.Value.Item1, out list))
				{
					list.Remove(linkedListNode);
					if (list.Count == 0)
					{
						this.GuaranteeActionsGroupByNodeId.Remove(linkedListNode.Value.Item1);
					}
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.GeneralLogicTree;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "GeneralLogicTree:移除保底行为：" + targetActionInfo.Name.ToString();
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("触发行为", instigatorName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ActionInfo", targetActionInfo);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("treeConfigId", this.TreeConfigId);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return item;
			}
		}
		return null;
	}

	// Token: 0x0600B878 RID: 47224 RVA: 0x0036648C File Offset: 0x0036468C
	private void GuaranteeActionOnClear(GuaranteeActionInfo guaranteeAction)
	{
		GuaranteeActionBase guaranteeAction2 = GuaranteeActionCenter.Instance.GetGuaranteeAction(guaranteeAction.Name);
		if (guaranteeAction2 != null)
		{
			guaranteeAction2.Clear(guaranteeAction.Params, GeneralLogicTreeContext.Create(this.BtType, this.TreeIncId, this.TreeConfigId, 0, null));
		}
	}

	// Token: 0x0600B879 RID: 47225 RVA: 0x003664DC File Offset: 0x003646DC
	public void ClearGuaranteeActions(int nodeId = 0)
	{
		if (nodeId == 0)
		{
			List<GuaranteeActionInfo> guaranteeActions = this.GetGuaranteeActions(false);
			this.GuaranteeActions.Clear();
			this.GuaranteeActionsGroupByNodeId.Clear();
			foreach (GuaranteeActionInfo guaranteeAction in guaranteeActions)
			{
				this.GuaranteeActionOnClear(guaranteeAction);
			}
			return;
		}
		List<LinkedListNode<ValueTuple<int, GuaranteeActionInfo>>> list;
		if (!this.GuaranteeActionsGroupByNodeId.Remove(nodeId, out list))
		{
			return;
		}
		foreach (LinkedListNode<ValueTuple<int, GuaranteeActionInfo>> node in list)
		{
			this.GuaranteeActions.Remove(node);
		}
		for (int i = list.Count - 1; i >= 0; i--)
		{
			this.GuaranteeActionOnClear(list[i].Value.Item2);
		}
	}

	// Token: 0x0600B87A RID: 47226 RVA: 0x003665D4 File Offset: 0x003647D4
	public List<GuaranteeActionInfo> GetGuaranteeActions(bool reverse = false)
	{
		List<GuaranteeActionInfo> list = new List<GuaranteeActionInfo>(this.GuaranteeActions.Count);
		for (LinkedListNode<ValueTuple<int, GuaranteeActionInfo>> linkedListNode = reverse ? this.GuaranteeActions.Last : this.GuaranteeActions.First; linkedListNode != null; linkedListNode = (reverse ? linkedListNode.Previous : linkedListNode.Next))
		{
			list.Add(linkedListNode.Value.Item2);
		}
		return list;
	}

	// Token: 0x0600B87B RID: 47227 RVA: 0x00366637 File Offset: 0x00364837
	public void AddCurrentExecuteActions(int sessionId)
	{
		this.CurrentExecuteActionsId.Add(sessionId);
	}

	// Token: 0x0600B87C RID: 47228 RVA: 0x00366646 File Offset: 0x00364846
	public void RemoveCurrentExecuteActions(int sessionId)
	{
		this.CurrentExecuteActionsId.Remove(sessionId);
	}

	// Token: 0x0600B87D RID: 47229 RVA: 0x00366655 File Offset: 0x00364855
	public IReadOnlySet<int> GetCurrentExecuteActions()
	{
		return this.CurrentExecuteActionsId;
	}

	// Token: 0x04006A0B RID: 27147
	private int OriginalDungeonId;

	// Token: 0x04006A0C RID: 27148
	private int TaskMarkTableIdInner;

	// Token: 0x04006A0D RID: 27149
	public readonly EMarkType MarkType = EMarkType.Quest;

	// Token: 0x04006A0E RID: 27150
	public ETrackSource TrackSource;

	// Token: 0x04006A0F RID: 27151
	public bool MapMarkResident;

	// Token: 0x04006A10 RID: 27152
	public bool UseInnerTrackIconId;

	// Token: 0x04006A11 RID: 27153
	public string OnlineType = "";

	// Token: 0x04006A12 RID: 27154
	private int ShowPriority;

	// Token: 0x04006A13 RID: 27155
	protected int CurrentDungeonId;

	// Token: 0x04006A14 RID: 27156
	protected int ChangeCurrentDungeonIdNodeId;

	// Token: 0x04006A15 RID: 27157
	public bool IsTracking;

	// Token: 0x04006A16 RID: 27158
	public bool IsSleeping;

	// Token: 0x04006A17 RID: 27159
	public BtType BtType;

	// Token: 0x04006A18 RID: 27160
	public long TreeIncId;

	// Token: 0x04006A19 RID: 27161
	public int TreeConfigId;

	// Token: 0x04006A1A RID: 27162
	public long? BoundParentTreeId;

	// Token: 0x04006A1B RID: 27163
	public int? BoundParentNodeId;

	// Token: 0x04006A1C RID: 27164
	[TupleElementNames(new string[]
	{
		"NodeId",
		"ActionInfo"
	})]
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly System.Collections.Generic.LinkedList<ValueTuple<int, GuaranteeActionInfo>> GuaranteeActions = new System.Collections.Generic.LinkedList<ValueTuple<int, GuaranteeActionInfo>>();

	// Token: 0x04006A1D RID: 27165
	[TupleElementNames(new string[]
	{
		"NodeId",
		"ActionInfo"
	})]
	[Nullable(new byte[]
	{
		1,
		1,
		1,
		0,
		1
	})]
	private readonly Dictionary<int, List<LinkedListNode<ValueTuple<int, GuaranteeActionInfo>>>> GuaranteeActionsGroupByNodeId = new Dictionary<int, List<LinkedListNode<ValueTuple<int, GuaranteeActionInfo>>>>();

	// Token: 0x04006A1E RID: 27166
	private readonly HashSet<int> CurrentExecuteActionsId = new HashSet<int>();

	// Token: 0x04006A1F RID: 27167
	private readonly Dictionary<int, BehaviorNodeBase> Nodes = new Dictionary<int, BehaviorNodeBase>();

	// Token: 0x04006A20 RID: 27168
	private readonly Dictionary<int, Dictionary<int, BehaviorNodeBase>> NodesGroupByStatus = new Dictionary<int, Dictionary<int, BehaviorNodeBase>>();

	// Token: 0x04006A21 RID: 27169
	private readonly Dictionary<string, VarDefinePb> TreeVars = new Dictionary<string, VarDefinePb>();

	// Token: 0x04006A22 RID: 27170
	private readonly Dictionary<string, HashSet<TTreeVarUpdateDelegate>> TreeVarsUpdateDelegate = new Dictionary<string, HashSet<TTreeVarUpdateDelegate>>();

	// Token: 0x04006A23 RID: 27171
	private readonly Dictionary<string, List<int>> RefOccupationIds = new Dictionary<string, List<int>>();

	// Token: 0x04006A24 RID: 27172
	public readonly TreeTrackTextExpressionInfo UiTrackTextInfo = new TreeTrackTextExpressionInfo();

	// Token: 0x04006A25 RID: 27173
	public readonly List<SilentAreaShowInfo> SilentAreaShowInfo = new List<SilentAreaShowInfo>();

	// Token: 0x04006A26 RID: 27174
	public readonly List<ModifyTrackAreaConfig> ModifyTrackAreaConfig = new List<ModifyTrackAreaConfig>();

	// Token: 0x04006A27 RID: 27175
	public int RollbackPoint;

	// Token: 0x04006A28 RID: 27176
	public bool NoExpression;

	// Token: 0x04006A29 RID: 27177
	public ETrackViewMode TrackViewModel;
}
