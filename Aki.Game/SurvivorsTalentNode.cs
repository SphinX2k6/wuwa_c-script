using System;
using System.Runtime.CompilerServices;

// Token: 0x02002038 RID: 8248
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTalentNode
{
	// Token: 0x060146BA RID: 83642 RVA: 0x005F5F09 File Offset: 0x005F4109
	public SurvivorsTalentNode(int nodeId, int areaId, int[] preNodeIds, int effectId, int indexId, int indexSortId)
	{
		this.NodeId = nodeId;
		this.AreaId = areaId;
		this.PreNodeIds = preNodeIds;
		this.EffectId = effectId;
		this.IndexId = indexId;
		this.IndexSortId = indexSortId;
	}

	// Token: 0x0400AD33 RID: 44339
	public int NodeId;

	// Token: 0x0400AD34 RID: 44340
	public int AreaId;

	// Token: 0x0400AD35 RID: 44341
	public int[] PreNodeIds;

	// Token: 0x0400AD36 RID: 44342
	public int EffectId;

	// Token: 0x0400AD37 RID: 44343
	public int IndexId;

	// Token: 0x0400AD38 RID: 44344
	public int IndexSortId;

	// Token: 0x0400AD39 RID: 44345
	public ESurvivorsTalentNodeStatus Status = ESurvivorsTalentNodeStatus.Lock;
}
