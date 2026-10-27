using System;
using System.Runtime.CompilerServices;

// Token: 0x02002256 RID: 8790
[NullableContext(1)]
[Nullable(0)]
public class MotorTechTreeNode
{
	// Token: 0x06011246 RID: 70214 RVA: 0x0042E1D0 File Offset: 0x0042C3D0
	public MotorTechTreeNode(int nodeId, int treeType, int[] preNodeIds)
	{
		this.NodeId = nodeId;
		this.TreeType = treeType;
		this.PreNodeIds = preNodeIds;
	}

	// Token: 0x170015C8 RID: 5576
	// (get) Token: 0x06011247 RID: 70215 RVA: 0x0042E1F4 File Offset: 0x0042C3F4
	// (set) Token: 0x06011248 RID: 70216 RVA: 0x0042E1FC File Offset: 0x0042C3FC
	public int NodeId { get; set; }

	// Token: 0x170015C9 RID: 5577
	// (get) Token: 0x06011249 RID: 70217 RVA: 0x0042E205 File Offset: 0x0042C405
	// (set) Token: 0x0601124A RID: 70218 RVA: 0x0042E20D File Offset: 0x0042C40D
	public int TreeType { get; set; }

	// Token: 0x170015CA RID: 5578
	// (get) Token: 0x0601124B RID: 70219 RVA: 0x0042E216 File Offset: 0x0042C416
	// (set) Token: 0x0601124C RID: 70220 RVA: 0x0042E21E File Offset: 0x0042C41E
	public int[] PreNodeIds { get; set; }

	// Token: 0x170015CB RID: 5579
	// (get) Token: 0x0601124D RID: 70221 RVA: 0x0042E227 File Offset: 0x0042C427
	// (set) Token: 0x0601124E RID: 70222 RVA: 0x0042E22F File Offset: 0x0042C42F
	public int NodeLevel { get; set; }

	// Token: 0x170015CC RID: 5580
	// (get) Token: 0x0601124F RID: 70223 RVA: 0x0042E238 File Offset: 0x0042C438
	// (set) Token: 0x06011250 RID: 70224 RVA: 0x0042E240 File Offset: 0x0042C440
	public int CurrentValue { get; set; }

	// Token: 0x170015CD RID: 5581
	// (get) Token: 0x06011251 RID: 70225 RVA: 0x0042E249 File Offset: 0x0042C449
	// (set) Token: 0x06011252 RID: 70226 RVA: 0x0042E251 File Offset: 0x0042C451
	public int TargetValue { get; set; }

	// Token: 0x170015CE RID: 5582
	// (get) Token: 0x06011253 RID: 70227 RVA: 0x0042E25A File Offset: 0x0042C45A
	// (set) Token: 0x06011254 RID: 70228 RVA: 0x0042E262 File Offset: 0x0042C462
	public EMotorTechTreeNodeStatus Status { get; set; } = EMotorTechTreeNodeStatus.Lock;
}
