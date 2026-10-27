using System;
using Aki.TDConfigMgr.Quest;

// Token: 0x02001D65 RID: 7525
public class ParallelSelectNode : LogicNodeBase
{
	// Token: 0x0600E4F7 RID: 58615 RVA: 0x0035EFB4 File Offset: 0x0035D1B4
	public ParallelSelectNode(int nodeId) : base(nodeId)
	{
	}

	// Token: 0x1700124D RID: 4685
	// (get) Token: 0x0600E4F8 RID: 58616 RVA: 0x0035EFBD File Offset: 0x0035D1BD
	public override EBtNode NodeType
	{
		get
		{
			return EBtNode.ParallelSelect;
		}
	}
}
