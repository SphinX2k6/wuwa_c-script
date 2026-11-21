using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

// Token: 0x02001256 RID: 4694
[NullableContext(2)]
[Nullable(0)]
public abstract class LogicTreeContainer
{
	// Token: 0x17001282 RID: 4738
	// (get) Token: 0x0600B9E8 RID: 47592
	public abstract int Id { get; }

	// Token: 0x17001283 RID: 4739
	// (get) Token: 0x0600B9E9 RID: 47593
	public abstract bool IsInteractValid { get; }

	// Token: 0x17001284 RID: 4740
	// (get) Token: 0x0600B9EA RID: 47594
	[Nullable(1)]
	public abstract string Name { [NullableContext(1)] get; }

	// Token: 0x17001285 RID: 4741
	// (get) Token: 0x0600B9EB RID: 47595 RVA: 0x0036E42A File Offset: 0x0036C62A
	public BaseBehaviorTree Tree
	{
		get
		{
			if (this.BehaviorTree == null)
			{
				return null;
			}
			return this.BehaviorTree;
		}
	}

	// Token: 0x17001286 RID: 4742
	// (get) Token: 0x0600B9EC RID: 47596 RVA: 0x0036E43C File Offset: 0x0036C63C
	public long? TreeId
	{
		get
		{
			BaseBehaviorTree tree = this.Tree;
			if (tree == null)
			{
				return null;
			}
			return new long?(tree.TreeIncId);
		}
	}

	// Token: 0x17001287 RID: 4743
	// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x0036E468 File Offset: 0x0036C668
	public int? TreeConfigId
	{
		get
		{
			BaseBehaviorTree tree = this.Tree;
			if (tree == null)
			{
				return null;
			}
			return new int?(tree.TreeConfigId);
		}
	}

	// Token: 0x0600B9EE RID: 47598 RVA: 0x0036E493 File Offset: 0x0036C693
	public virtual void Destroy()
	{
		this.TearDownBehaviorTree();
	}

	// Token: 0x17001288 RID: 4744
	// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x0036E49B File Offset: 0x0036C69B
	public bool IsBelongPlayer
	{
		get
		{
			return this.IsBelongPlayerInternal;
		}
	}

	// Token: 0x0600B9F0 RID: 47600 RVA: 0x0036E4A3 File Offset: 0x0036C6A3
	[NullableContext(1)]
	public virtual void SetUpBehaviorTree(BaseBehaviorTree behaviorTree)
	{
		this.BehaviorTree = behaviorTree;
		if (behaviorTree != null)
		{
			this.IsBelongPlayerInternal = true;
		}
	}

	// Token: 0x0600B9F1 RID: 47601 RVA: 0x0036E4B8 File Offset: 0x0036C6B8
	private void TearDownBehaviorTree()
	{
		if (this.BehaviorTree == null)
		{
			return;
		}
		EventSystem.Instance.Emit<long, int?>(EEventName.TearDownGeneralLogicTree, this.TreeId.Value, this.TreeConfigId);
		this.BehaviorTree = null;
	}

	// Token: 0x0600B9F2 RID: 47602 RVA: 0x0036E4F9 File Offset: 0x0036C6F9
	public BehaviorNodeBase GetNode(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetNode(nodeId);
	}

	// Token: 0x0600B9F3 RID: 47603 RVA: 0x0036E50D File Offset: 0x0036C70D
	public BehaviorNodeBase GetCurrentActiveChildQuestNode()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentActiveChildQuestNode(true);
	}

	// Token: 0x0600B9F4 RID: 47604 RVA: 0x0036E521 File Offset: 0x0036C721
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<BehaviorNodeBase> GetCurrentActiveChildQuestNodes()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentActiveChildQuestNodes();
	}

	// Token: 0x0600B9F5 RID: 47605 RVA: 0x0036E534 File Offset: 0x0036C734
	public List<int> GetActiveChildQuestNodesId()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetActiveChildQuestNodesId();
	}

	// Token: 0x0600B9F6 RID: 47606 RVA: 0x0036E547 File Offset: 0x0036C747
	public IReadOnlyList<int> GetCurrentCorrelativeEntities()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentCorrelativeEntities();
	}

	// Token: 0x0600B9F7 RID: 47607 RVA: 0x0036E55A File Offset: 0x0036C75A
	public ITrackCustomBoard GetCurrentTrackCustomBoard()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentNodeCustomTrackBoard();
	}

	// Token: 0x0600B9F8 RID: 47608 RVA: 0x0036E56D File Offset: 0x0036C76D
	public virtual void SetTrack(bool value, ESetTrackReason reason = ESetTrackReason.None)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return;
		}
		tree.SetTrack(value, reason);
	}

	// Token: 0x0600B9F9 RID: 47609 RVA: 0x0036E581 File Offset: 0x0036C781
	public Vector GetNodeTrackPosition(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetNodeTrackPosition(nodeId);
	}

	// Token: 0x0600B9FA RID: 47610 RVA: 0x0036E598 File Offset: 0x0036C798
	public double? GetTrackDistance(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return new double?(tree.GetTrackDistance(nodeId));
	}

	// Token: 0x0600B9FB RID: 47611 RVA: 0x0036E5C4 File Offset: 0x0036C7C4
	public int? GetDefaultMark(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetDefaultMark(nodeId);
	}

	// Token: 0x0600B9FC RID: 47612 RVA: 0x0036E5EC File Offset: 0x0036C7EC
	public double? GetGuideLineHideDistance(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return new double?(tree.GetGuideLineHideDistance(nodeId));
	}

	// Token: 0x0600B9FD RID: 47613 RVA: 0x0036E618 File Offset: 0x0036C818
	public virtual bool IsInTrackRange()
	{
		return this.Tree.IsInTrackRange();
	}

	// Token: 0x0600B9FE RID: 47614 RVA: 0x0036E625 File Offset: 0x0036C825
	public bool IsRangeTrack(int nodeId)
	{
		return this.Tree.IsRangeTrack(nodeId);
	}

	// Token: 0x0600B9FF RID: 47615 RVA: 0x0036E633 File Offset: 0x0036C833
	public void CreateMapMarks()
	{
		this.Tree.CreateMapMarks();
	}

	// Token: 0x0600BA00 RID: 47616 RVA: 0x0036E640 File Offset: 0x0036C840
	public virtual int GetUiPriority()
	{
		return 0;
	}

	// Token: 0x0600BA01 RID: 47617 RVA: 0x0036E643 File Offset: 0x0036C843
	public virtual bool CanShowInUiPanel()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.CheckCanShow();
	}

	// Token: 0x0600BA02 RID: 47618 RVA: 0x0036E656 File Offset: 0x0036C856
	public bool CanShowTrackExpression()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.CanShowTrackExpression();
	}

	// Token: 0x0600BA03 RID: 47619 RVA: 0x0036E669 File Offset: 0x0036C869
	public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return;
		}
		tree.StartTextExpress(reason);
	}

	// Token: 0x0600BA04 RID: 47620 RVA: 0x0036E67C File Offset: 0x0036C87C
	public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return;
		}
		tree.EndTextExpress(reason);
	}

	// Token: 0x0600BA05 RID: 47621 RVA: 0x0036E68F File Offset: 0x0036C88F
	public bool IsSuspend()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.IsSuspend();
	}

	// Token: 0x0600BA06 RID: 47622 RVA: 0x0036E6A2 File Offset: 0x0036C8A2
	public EBehaviorTreeSuspendType GetSuspendType()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return EBehaviorTreeSuspendType.None;
		}
		return tree.GetSuspendType();
	}

	// Token: 0x0600BA07 RID: 47623 RVA: 0x0036E6B5 File Offset: 0x0036C8B5
	public string GetSuspendText()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetSuspendText();
	}

	// Token: 0x0600BA08 RID: 47624 RVA: 0x0036E6C8 File Offset: 0x0036C8C8
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public IReadOnlyList<IOccupationInfo> GetOccupations()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetOccupations();
	}

	// Token: 0x0600BA09 RID: 47625 RVA: 0x0036E6DB File Offset: 0x0036C8DB
	public bool HasRefOccupiedEntity()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.HasRefOccupiedEntity();
	}

	// Token: 0x0600BA0A RID: 47626 RVA: 0x0036E6EE File Offset: 0x0036C8EE
	public string GetRefOccupiedEntityText()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetRefOccupiedEntityText();
	}

	// Token: 0x0600BA0B RID: 47627 RVA: 0x0036E701 File Offset: 0x0036C901
	public bool HasBehaviorTree()
	{
		return this.BehaviorTree != null;
	}

	// Token: 0x0600BA0C RID: 47628 RVA: 0x0036E70C File Offset: 0x0036C90C
	public bool CanShowGuideLine()
	{
		List<BehaviorNodeBase> currentActiveChildQuestNodes = this.GetCurrentActiveChildQuestNodes();
		if (currentActiveChildQuestNodes == null)
		{
			return false;
		}
		using (List<BehaviorNodeBase>.Enumerator enumerator = currentActiveChildQuestNodes.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ContainTag(EBehaviorTreeTag.ShowNavigation))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600BA0D RID: 47629 RVA: 0x0036E770 File Offset: 0x0036C970
	public bool IsAlwaysShowGuideLine()
	{
		List<BehaviorNodeBase> currentActiveChildQuestNodes = this.GetCurrentActiveChildQuestNodes();
		if (currentActiveChildQuestNodes == null)
		{
			return false;
		}
		using (List<BehaviorNodeBase>.Enumerator enumerator = currentActiveChildQuestNodes.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.ContainTag(EBehaviorTreeTag.AlwaysShowNavigation))
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600BA0E RID: 47630 RVA: 0x0036E7D4 File Offset: 0x0036C9D4
	public BehaviorNodeBase GetShowGuideLineNode()
	{
		List<BehaviorNodeBase> currentActiveChildQuestNodes = this.GetCurrentActiveChildQuestNodes();
		if (currentActiveChildQuestNodes == null)
		{
			return null;
		}
		foreach (BehaviorNodeBase behaviorNodeBase in currentActiveChildQuestNodes)
		{
			if (behaviorNodeBase.ContainTag(EBehaviorTreeTag.ShowNavigation))
			{
				return behaviorNodeBase;
			}
		}
		return null;
	}

	// Token: 0x04006B3D RID: 27453
	protected BaseBehaviorTree BehaviorTree;

	// Token: 0x04006B3E RID: 27454
	private bool IsBelongPlayerInternal;
}
