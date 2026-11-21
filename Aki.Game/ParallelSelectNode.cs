using System;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001227 RID: 4647
public class ParallelSelectNode : LogicNodeBase
{
	// Token: 0x0600B915 RID: 47381 RVA: 0x0036AC08 File Offset: 0x00368E08
	public ParallelSelectNode(int nodeId) : base(nodeId)
	{
	}

	// Token: 0x17001277 RID: 4727
	// (get) Token: 0x0600B916 RID: 47382 RVA: 0x0036AC11 File Offset: 0x00368E11
	public override EBtNode NodeType
	{
		get
		{
			return EBtNode.ParallelSelect;
		}
	}
}
