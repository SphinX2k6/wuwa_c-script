using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree;

// Token: 0x02001D63 RID: 7523
[NullableContext(1)]
[Nullable(0)]
public abstract class BehaviorNodeBase : BehaviorTreeTagContainer
{
	// Token: 0x0600E4D4 RID: 58580 RVA: 0x0035E48B File Offset: 0x0035C68B
	protected BehaviorNodeBase(int nodeId)
	{
	}

	// Token: 0x1700123F RID: 4671
	// (get) Token: 0x0600E4D5 RID: 58581
	public abstract EBtNode NodeType { get; }

	// Token: 0x17001240 RID: 4672
	// (get) Token: 0x0600E4D6 RID: 58582 RVA: 0x0035E49A File Offset: 0x0035C69A
	public ENodeTrackTextRule TrackTextRule
	{
		get
		{
			return this.TrackTextRuleInner;
		}
	}

	// Token: 0x17001241 RID: 4673
	// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x0035E4A2 File Offset: 0x0035C6A2
	public long TreeIncId
	{
		get
		{
			return this.InnerTreeIncId;
		}
	}

	// Token: 0x17001242 RID: 4674
	// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x0035E4AA File Offset: 0x0035C6AA
	public int TreeConfigId
	{
		get
		{
			return this.InnerTreeConfigId;
		}
	}

	// Token: 0x17001243 RID: 4675
	// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x0035E4B2 File Offset: 0x0035C6B2
	public int NodeId
	{
		get
		{
			return this.InnerNodeId;
		}
	}

	// Token: 0x17001244 RID: 4676
	// (get) Token: 0x0600E4DA RID: 58586 RVA: 0x0035E4BA File Offset: 0x0035C6BA
	public NodeStatus Status
	{
		get
		{
			return this.InnerStatus;
		}
	}

	// Token: 0x17001245 RID: 4677
	// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x0035E4C2 File Offset: 0x0035C6C2
	public bool IsProcessing
	{
		get
		{
			return this.Status == NodeStatus.Activated || this.Status == NodeStatus.Completing;
		}
	}

	// Token: 0x17001246 RID: 4678
	// (get) Token: 0x0600E4DC RID: 58588 RVA: 0x0035E4D8 File Offset: 0x0035C6D8
	public bool IsSuccess
	{
		get
		{
			return this.Status == NodeStatus.CompletedSuccess;
		}
	}

	// Token: 0x17001247 RID: 4679
	// (get) Token: 0x0600E4DD RID: 58589 RVA: 0x0035E4E3 File Offset: 0x0035C6E3
	public bool IsFailure
	{
		get
		{
			return this.Status == NodeStatus.CompletedFailed || this.Status == NodeStatus.Destroy;
		}
	}

	// Token: 0x0600E4DE RID: 58590 RVA: 0x0035E4FC File Offset: 0x0035C6FC
	public virtual void Init(Blackboard blackboard, ENodeStatusUpdateReason reason, global::NodeInfo data, IBtNode config, BtType btType)
	{
		this.Blackboard = blackboard;
		this.InnerTreeIncId = blackboard.TreeIncId;
		this.InnerTreeConfigId = blackboard.TreeConfigId;
		this.BtType = btType;
		this.Context = this.CreateContext(null, this.InnerNodeId);
		if (!this.OnCreate(config))
		{
			return;
		}
		this.UpdateStatus(reason, data.Info.Status);
	}

	// Token: 0x0600E4DF RID: 58591 RVA: 0x0035E568 File Offset: 0x0035C768
	public void Destroy()
	{
		this.OnDestroy();
		GeneralLogicTreeContext context = this.Context;
		if (context != null)
		{
			context.Release();
		}
		this.Context = null;
		this.Blackboard = null;
		this.TrackTextConfig = null;
		this.MultiTrackText = null;
	}

	// Token: 0x0600E4E0 RID: 58592 RVA: 0x0035E5A0 File Offset: 0x0035C7A0
	public void UpdateStatus(ENodeStatusUpdateReason reason, NodeStatus status)
	{
		NodeStatus innerStatus = this.InnerStatus;
		this.InnerStatus = status;
		if (innerStatus == this.InnerStatus)
		{
			return;
		}
		switch (this.InnerStatus)
		{
		case NodeStatus.Activated:
			this.OnNodeActive();
			break;
		case NodeStatus.CompletedSuccess:
			this.OnNodeDeActive(true);
			break;
		case NodeStatus.CompletedFailed:
			this.OnNodeDeActive(false);
			break;
		case NodeStatus.Destroy:
			this.OnNodeDeActive(false);
			break;
		}
		if (reason <= ENodeStatusUpdateReason.Recover)
		{
			EventSystem.Instance.Emit<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(EEventName.OnLogicTreeNodeStatusChange, this.Context, innerStatus, this.InnerStatus, reason);
			EventSystem.Instance.EmitWithTarget<GeneralContext, NodeStatus, NodeStatus, ENodeStatusUpdateReason>(this.Blackboard, EEventName.OnLogicTreeNodeStatusChange, this.Context, innerStatus, this.InnerStatus, reason);
		}
	}

	// Token: 0x0600E4E1 RID: 58593 RVA: 0x0035E658 File Offset: 0x0035C858
	[NullableContext(2)]
	public void UpdateProgress(ChildQuestNodeProgress progress)
	{
		if (progress == null)
		{
			return;
		}
		if (!this.OnUpdateProgress(progress))
		{
			return;
		}
		EventSystem.Instance.Emit<GeneralContext, ChildQuestNodeProgress>(EEventName.OnLogicTreeNodeProgressChange, this.Context, progress);
		EventSystem.Instance.EmitWithTarget<GeneralContext, ChildQuestNodeProgress>(this.Blackboard, EEventName.OnLogicTreeNodeProgressChange, this.Context, progress);
	}

	// Token: 0x0600E4E2 RID: 58594 RVA: 0x0035E6A7 File Offset: 0x0035C8A7
	protected virtual bool OnUpdateProgress(ChildQuestNodeProgress data)
	{
		return false;
	}

	// Token: 0x0600E4E3 RID: 58595 RVA: 0x0035E6AA File Offset: 0x0035C8AA
	public virtual string GetProgress()
	{
		return "0";
	}

	// Token: 0x0600E4E4 RID: 58596 RVA: 0x0035E6B1 File Offset: 0x0035C8B1
	public virtual string GetProgressMax()
	{
		return "0";
	}

	// Token: 0x0600E4E5 RID: 58597 RVA: 0x0035E6B8 File Offset: 0x0035C8B8
	[return: Nullable(2)]
	public virtual string GetCustomTrackText(string textTemplate)
	{
		return null;
	}

	// Token: 0x0600E4E6 RID: 58598 RVA: 0x0035E6BB File Offset: 0x0035C8BB
	protected GeneralLogicTreeContext CreateContext(GameCtxType? contextType, int nodeId)
	{
		return GeneralLogicTreeContext.Create(this.BtType, this.TreeIncId, this.TreeConfigId, nodeId, contextType);
	}

	// Token: 0x0600E4E7 RID: 58599 RVA: 0x0035E6D6 File Offset: 0x0035C8D6
	protected virtual bool OnCreate(IBtNode config)
	{
		return true;
	}

	// Token: 0x0600E4E8 RID: 58600 RVA: 0x0035E6D9 File Offset: 0x0035C8D9
	protected virtual void OnNodeActive()
	{
	}

	// Token: 0x0600E4E9 RID: 58601 RVA: 0x0035E6DB File Offset: 0x0035C8DB
	protected virtual void OnNodeDeActive(bool success)
	{
	}

	// Token: 0x0600E4EA RID: 58602 RVA: 0x0035E6DD File Offset: 0x0035C8DD
	protected virtual void OnDestroy()
	{
		if (this.IsProcessing)
		{
			this.UpdateStatus(ENodeStatusUpdateReason.NodeDestroy, NodeStatus.Destroy);
		}
	}

	// Token: 0x04006986 RID: 27014
	protected BtType BtType;

	// Token: 0x04006987 RID: 27015
	[Nullable(2)]
	protected GeneralLogicTreeContext Context;

	// Token: 0x04006988 RID: 27016
	protected long InnerTreeIncId;

	// Token: 0x04006989 RID: 27017
	protected int InnerTreeConfigId;

	// Token: 0x0400698A RID: 27018
	protected int InnerNodeId = nodeId;

	// Token: 0x0400698B RID: 27019
	protected NodeStatus InnerStatus;

	// Token: 0x0400698C RID: 27020
	[Nullable(2)]
	protected Blackboard Blackboard;

	// Token: 0x0400698D RID: 27021
	[Nullable(2)]
	public ITrackTarget TrackTarget;

	// Token: 0x0400698E RID: 27022
	public bool ShowTipBeforeEnterActions;

	// Token: 0x0400698F RID: 27023
	[Nullable(2)]
	public string TrackTextConfig;

	// Token: 0x04006990 RID: 27024
	[Nullable(2)]
	public string MultiTrackText;

	// Token: 0x04006991 RID: 27025
	public ENavigationStyle NavigationStyle;

	// Token: 0x04006992 RID: 27026
	protected ENodeTrackTextRule TrackTextRuleInner;
}
