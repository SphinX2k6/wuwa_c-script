using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Common.Event;

// Token: 0x02001D94 RID: 7572
[NullableContext(2)]
[Nullable(0)]
public abstract class LogicTreeContainer
{
	// Token: 0x17001258 RID: 4696
	// (get) Token: 0x0600E5CA RID: 58826
	public abstract int Id { get; }

	// Token: 0x17001259 RID: 4697
	// (get) Token: 0x0600E5CB RID: 58827
	public abstract bool IsInteractValid { get; }

	// Token: 0x1700125A RID: 4698
	// (get) Token: 0x0600E5CC RID: 58828
	[Nullable(1)]
	public abstract string Name { [NullableContext(1)] get; }

	// Token: 0x1700125B RID: 4699
	// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x003627CA File Offset: 0x003609CA
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

	// Token: 0x1700125C RID: 4700
	// (get) Token: 0x0600E5CE RID: 58830 RVA: 0x003627DC File Offset: 0x003609DC
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

	// Token: 0x1700125D RID: 4701
	// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x00362808 File Offset: 0x00360A08
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

	// Token: 0x0600E5D0 RID: 58832 RVA: 0x00362833 File Offset: 0x00360A33
	public virtual void Destroy()
	{
		this.TearDownBehaviorTree();
	}

	// Token: 0x1700125E RID: 4702
	// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x0036283B File Offset: 0x00360A3B
	public bool IsBelongPlayer
	{
		get
		{
			return this.IsBelongPlayerInternal;
		}
	}

	// Token: 0x0600E5D2 RID: 58834 RVA: 0x00362843 File Offset: 0x00360A43
	[NullableContext(1)]
	public virtual void SetUpBehaviorTree(BaseBehaviorTree behaviorTree)
	{
		this.BehaviorTree = behaviorTree;
		if (behaviorTree != null)
		{
			this.IsBelongPlayerInternal = true;
		}
	}

	// Token: 0x0600E5D3 RID: 58835 RVA: 0x00362858 File Offset: 0x00360A58
	private void TearDownBehaviorTree()
	{
		if (this.BehaviorTree == null)
		{
			return;
		}
		EventSystem.Instance.Emit<long, int?>(EEventName.TearDownGeneralLogicTree, this.TreeId.Value, this.TreeConfigId);
		this.BehaviorTree = null;
	}

	// Token: 0x0600E5D4 RID: 58836 RVA: 0x00362899 File Offset: 0x00360A99
	public BehaviorNodeBase GetNode(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetNode(nodeId);
	}

	// Token: 0x0600E5D5 RID: 58837 RVA: 0x003628AD File Offset: 0x00360AAD
	public BehaviorNodeBase GetCurrentActiveChildQuestNode()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentActiveChildQuestNode(true);
	}

	// Token: 0x0600E5D6 RID: 58838 RVA: 0x003628C1 File Offset: 0x00360AC1
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

	// Token: 0x0600E5D7 RID: 58839 RVA: 0x003628D4 File Offset: 0x00360AD4
	public List<int> GetActiveChildQuestNodesId()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetActiveChildQuestNodesId();
	}

	// Token: 0x0600E5D8 RID: 58840 RVA: 0x003628E7 File Offset: 0x00360AE7
	public IReadOnlyList<int> GetCurrentCorrelativeEntities()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentCorrelativeEntities();
	}

	// Token: 0x0600E5D9 RID: 58841 RVA: 0x003628FA File Offset: 0x00360AFA
	public ITrackCustomBoard GetCurrentTrackCustomBoard()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetCurrentNodeCustomTrackBoard();
	}

	// Token: 0x0600E5DA RID: 58842 RVA: 0x0036290D File Offset: 0x00360B0D
	public virtual void SetTrack(bool value, ESetTrackReason reason = ESetTrackReason.None)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return;
		}
		tree.SetTrack(value, reason);
	}

	// Token: 0x0600E5DB RID: 58843 RVA: 0x00362921 File Offset: 0x00360B21
	public Vector GetNodeTrackPosition(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetNodeTrackPosition(nodeId);
	}

	// Token: 0x0600E5DC RID: 58844 RVA: 0x00362938 File Offset: 0x00360B38
	public double? GetTrackDistance(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return new double?(tree.GetTrackDistance(nodeId));
	}

	// Token: 0x0600E5DD RID: 58845 RVA: 0x00362964 File Offset: 0x00360B64
	public int? GetDefaultMark(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetDefaultMark(nodeId);
	}

	// Token: 0x0600E5DE RID: 58846 RVA: 0x0036298C File Offset: 0x00360B8C
	public double? GetGuideLineHideDistance(int nodeId)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return new double?(tree.GetGuideLineHideDistance(nodeId));
	}

	// Token: 0x0600E5DF RID: 58847 RVA: 0x003629B8 File Offset: 0x00360BB8
	public virtual bool IsInTrackRange()
	{
		return this.Tree.IsInTrackRange();
	}

	// Token: 0x0600E5E0 RID: 58848 RVA: 0x003629C5 File Offset: 0x00360BC5
	public bool IsRangeTrack(int nodeId)
	{
		return this.Tree.IsRangeTrack(nodeId);
	}

	// Token: 0x0600E5E1 RID: 58849 RVA: 0x003629D3 File Offset: 0x00360BD3
	public void CreateMapMarks()
	{
		this.Tree.CreateMapMarks();
	}

	// Token: 0x0600E5E2 RID: 58850 RVA: 0x003629E0 File Offset: 0x00360BE0
	public virtual int GetUiPriority()
	{
		return 0;
	}

	// Token: 0x0600E5E3 RID: 58851 RVA: 0x003629E3 File Offset: 0x00360BE3
	public virtual bool CanShowInUiPanel()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.CheckCanShow();
	}

	// Token: 0x0600E5E4 RID: 58852 RVA: 0x003629F6 File Offset: 0x00360BF6
	public bool CanShowTrackExpression()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.CanShowTrackExpression();
	}

	// Token: 0x0600E5E5 RID: 58853 RVA: 0x00362A09 File Offset: 0x00360C09
	public void StartTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return;
		}
		tree.StartTextExpress(reason);
	}

	// Token: 0x0600E5E6 RID: 58854 RVA: 0x00362A1C File Offset: 0x00360C1C
	public void EndTextExpress(ETreeTextExpressReason reason = ETreeTextExpressReason.None)
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return;
		}
		tree.EndTextExpress(reason);
	}

	// Token: 0x0600E5E7 RID: 58855 RVA: 0x00362A2F File Offset: 0x00360C2F
	public bool IsSuspend()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.IsSuspend();
	}

	// Token: 0x0600E5E8 RID: 58856 RVA: 0x00362A42 File Offset: 0x00360C42
	public EBehaviorTreeSuspendType GetSuspendType()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return EBehaviorTreeSuspendType.None;
		}
		return tree.GetSuspendType();
	}

	// Token: 0x0600E5E9 RID: 58857 RVA: 0x00362A55 File Offset: 0x00360C55
	public string GetSuspendText()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetSuspendText();
	}

	// Token: 0x0600E5EA RID: 58858 RVA: 0x00362A68 File Offset: 0x00360C68
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

	// Token: 0x0600E5EB RID: 58859 RVA: 0x00362A7B File Offset: 0x00360C7B
	public bool HasRefOccupiedEntity()
	{
		BaseBehaviorTree tree = this.Tree;
		return tree != null && tree.HasRefOccupiedEntity();
	}

	// Token: 0x0600E5EC RID: 58860 RVA: 0x00362A8E File Offset: 0x00360C8E
	public string GetRefOccupiedEntityText()
	{
		BaseBehaviorTree tree = this.Tree;
		if (tree == null)
		{
			return null;
		}
		return tree.GetRefOccupiedEntityText();
	}

	// Token: 0x0600E5ED RID: 58861 RVA: 0x00362AA1 File Offset: 0x00360CA1
	public bool HasBehaviorTree()
	{
		return this.BehaviorTree != null;
	}

	// Token: 0x0600E5EE RID: 58862 RVA: 0x00362AAC File Offset: 0x00360CAC
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

	// Token: 0x0600E5EF RID: 58863 RVA: 0x00362B10 File Offset: 0x00360D10
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

	// Token: 0x0600E5F0 RID: 58864 RVA: 0x00362B74 File Offset: 0x00360D74
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

	// Token: 0x04006A5C RID: 27228
	protected BaseBehaviorTree BehaviorTree;

	// Token: 0x04006A5D RID: 27229
	private bool IsBelongPlayerInternal;
}
