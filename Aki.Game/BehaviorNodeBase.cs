using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.GeneralLogicTree.BaseBehaviorTree;

// Token: 0x02001225 RID: 4645
[NullableContext(1)]
[Nullable(0)]
public abstract class BehaviorNodeBase : BehaviorTreeTagContainer
{
	// Token: 0x0600B8F2 RID: 47346 RVA: 0x0036A087 File Offset: 0x00368287
	protected BehaviorNodeBase(int nodeId)
	{
	}

	// Token: 0x17001269 RID: 4713
	// (get) Token: 0x0600B8F3 RID: 47347
	public abstract EBtNode NodeType { get; }

	// Token: 0x1700126A RID: 4714
	// (get) Token: 0x0600B8F4 RID: 47348 RVA: 0x0036A096 File Offset: 0x00368296
	public ENodeTrackTextRule TrackTextRule
	{
		get
		{
			return this.TrackTextRuleInner;
		}
	}

	// Token: 0x1700126B RID: 4715
	// (get) Token: 0x0600B8F5 RID: 47349 RVA: 0x0036A09E File Offset: 0x0036829E
	public long TreeIncId
	{
		get
		{
			return this.InnerTreeIncId;
		}
	}

	// Token: 0x1700126C RID: 4716
	// (get) Token: 0x0600B8F6 RID: 47350 RVA: 0x0036A0A6 File Offset: 0x003682A6
	public int TreeConfigId
	{
		get
		{
			return this.InnerTreeConfigId;
		}
	}

	// Token: 0x1700126D RID: 4717
	// (get) Token: 0x0600B8F7 RID: 47351 RVA: 0x0036A0AE File Offset: 0x003682AE
	public int NodeId
	{
		get
		{
			return this.InnerNodeId;
		}
	}

	// Token: 0x1700126E RID: 4718
	// (get) Token: 0x0600B8F8 RID: 47352 RVA: 0x0036A0B6 File Offset: 0x003682B6
	public NodeStatus Status
	{
		get
		{
			return this.InnerStatus;
		}
	}

	// Token: 0x1700126F RID: 4719
	// (get) Token: 0x0600B8F9 RID: 47353 RVA: 0x0036A0BE File Offset: 0x003682BE
	public bool IsProcessing
	{
		get
		{
			return this.Status == NodeStatus.Activated || this.Status == NodeStatus.Completing;
		}
	}

	// Token: 0x17001270 RID: 4720
	// (get) Token: 0x0600B8FA RID: 47354 RVA: 0x0036A0D4 File Offset: 0x003682D4
	public bool IsSuccess
	{
		get
		{
			return this.Status == NodeStatus.CompletedSuccess;
		}
	}

	// Token: 0x17001271 RID: 4721
	// (get) Token: 0x0600B8FB RID: 47355 RVA: 0x0036A0DF File Offset: 0x003682DF
	public bool IsFailure
	{
		get
		{
			return this.Status == NodeStatus.CompletedFailed || this.Status == NodeStatus.Destroy;
		}
	}

	// Token: 0x0600B8FC RID: 47356 RVA: 0x0036A0F8 File Offset: 0x003682F8
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

	// Token: 0x0600B8FD RID: 47357 RVA: 0x0036A164 File Offset: 0x00368364
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

	// Token: 0x0600B8FE RID: 47358 RVA: 0x0036A19C File Offset: 0x0036839C
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

	// Token: 0x0600B8FF RID: 47359 RVA: 0x0036A254 File Offset: 0x00368454
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

	// Token: 0x0600B900 RID: 47360 RVA: 0x0036A2A3 File Offset: 0x003684A3
	protected virtual bool OnUpdateProgress(ChildQuestNodeProgress data)
	{
		return false;
	}

	// Token: 0x0600B901 RID: 47361 RVA: 0x0036A2A6 File Offset: 0x003684A6
	public virtual string GetProgress()
	{
		return "0";
	}

	// Token: 0x0600B902 RID: 47362 RVA: 0x0036A2AD File Offset: 0x003684AD
	public virtual string GetProgressMax()
	{
		return "0";
	}

	// Token: 0x0600B903 RID: 47363 RVA: 0x0036A2B4 File Offset: 0x003684B4
	[return: Nullable(2)]
	public virtual string GetCustomTrackText(string textTemplate)
	{
		return null;
	}

	// Token: 0x0600B904 RID: 47364 RVA: 0x0036A2B7 File Offset: 0x003684B7
	protected GeneralLogicTreeContext CreateContext(GameCtxType? contextType, int nodeId)
	{
		return GeneralLogicTreeContext.Create(this.BtType, this.TreeIncId, this.TreeConfigId, nodeId, contextType);
	}

	// Token: 0x0600B905 RID: 47365 RVA: 0x0036A2D2 File Offset: 0x003684D2
	protected virtual bool OnCreate(IBtNode config)
	{
		return true;
	}

	// Token: 0x0600B906 RID: 47366 RVA: 0x0036A2D5 File Offset: 0x003684D5
	protected virtual void OnNodeActive()
	{
	}

	// Token: 0x0600B907 RID: 47367 RVA: 0x0036A2D7 File Offset: 0x003684D7
	protected virtual void OnNodeDeActive(bool success)
	{
	}

	// Token: 0x0600B908 RID: 47368 RVA: 0x0036A2D9 File Offset: 0x003684D9
	protected virtual void OnDestroy()
	{
		if (this.IsProcessing)
		{
			this.UpdateStatus(ENodeStatusUpdateReason.NodeDestroy, NodeStatus.Destroy);
		}
	}

	// Token: 0x04006A66 RID: 27238
	protected BtType BtType;

	// Token: 0x04006A67 RID: 27239
	[Nullable(2)]
	protected GeneralLogicTreeContext Context;

	// Token: 0x04006A68 RID: 27240
	protected long InnerTreeIncId;

	// Token: 0x04006A69 RID: 27241
	protected int InnerTreeConfigId;

	// Token: 0x04006A6A RID: 27242
	protected int InnerNodeId = nodeId;

	// Token: 0x04006A6B RID: 27243
	protected NodeStatus InnerStatus;

	// Token: 0x04006A6C RID: 27244
	[Nullable(2)]
	protected Blackboard Blackboard;

	// Token: 0x04006A6D RID: 27245
	[Nullable(2)]
	public ITrackTarget TrackTarget;

	// Token: 0x04006A6E RID: 27246
	public bool ShowTipBeforeEnterActions;

	// Token: 0x04006A6F RID: 27247
	[Nullable(2)]
	public string TrackTextConfig;

	// Token: 0x04006A70 RID: 27248
	[Nullable(2)]
	public string MultiTrackText;

	// Token: 0x04006A71 RID: 27249
	public ENavigationStyle NavigationStyle;

	// Token: 0x04006A72 RID: 27250
	protected ENodeTrackTextRule TrackTextRuleInner;
}
