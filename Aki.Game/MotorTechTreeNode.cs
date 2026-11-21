using System;
using System.Runtime.CompilerServices;

// Token: 0x0200173A RID: 5946
[NullableContext(1)]
[Nullable(0)]
public class MotorTechTreeNode
{
	// Token: 0x0600E6DC RID: 59100 RVA: 0x0043AD70 File Offset: 0x00438F70
	public MotorTechTreeNode(int nodeId, int treeType, int[] preNodeIds)
	{
		this.NodeId = nodeId;
		this.TreeType = treeType;
		this.PreNodeIds = preNodeIds;
	}

	// Token: 0x170015FF RID: 5631
	// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x0043AD94 File Offset: 0x00438F94
	// (set) Token: 0x0600E6DE RID: 59102 RVA: 0x0043AD9C File Offset: 0x00438F9C
	public int NodeId { get; set; }

	// Token: 0x17001600 RID: 5632
	// (get) Token: 0x0600E6DF RID: 59103 RVA: 0x0043ADA5 File Offset: 0x00438FA5
	// (set) Token: 0x0600E6E0 RID: 59104 RVA: 0x0043ADAD File Offset: 0x00438FAD
	public int TreeType { get; set; }

	// Token: 0x17001601 RID: 5633
	// (get) Token: 0x0600E6E1 RID: 59105 RVA: 0x0043ADB6 File Offset: 0x00438FB6
	// (set) Token: 0x0600E6E2 RID: 59106 RVA: 0x0043ADBE File Offset: 0x00438FBE
	public int[] PreNodeIds { get; set; }

	// Token: 0x17001602 RID: 5634
	// (get) Token: 0x0600E6E3 RID: 59107 RVA: 0x0043ADC7 File Offset: 0x00438FC7
	// (set) Token: 0x0600E6E4 RID: 59108 RVA: 0x0043ADCF File Offset: 0x00438FCF
	public int NodeLevel { get; set; }

	// Token: 0x17001603 RID: 5635
	// (get) Token: 0x0600E6E5 RID: 59109 RVA: 0x0043ADD8 File Offset: 0x00438FD8
	// (set) Token: 0x0600E6E6 RID: 59110 RVA: 0x0043ADE0 File Offset: 0x00438FE0
	public int CurrentValue { get; set; }

	// Token: 0x17001604 RID: 5636
	// (get) Token: 0x0600E6E7 RID: 59111 RVA: 0x0043ADE9 File Offset: 0x00438FE9
	// (set) Token: 0x0600E6E8 RID: 59112 RVA: 0x0043ADF1 File Offset: 0x00438FF1
	public int TargetValue { get; set; }

	// Token: 0x17001605 RID: 5637
	// (get) Token: 0x0600E6E9 RID: 59113 RVA: 0x0043ADFA File Offset: 0x00438FFA
	// (set) Token: 0x0600E6EA RID: 59114 RVA: 0x0043AE02 File Offset: 0x00439002
	public EMotorTechTreeNodeStatus Status { get; set; } = EMotorTechTreeNodeStatus.Lock;
}
