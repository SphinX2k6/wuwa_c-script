using System;
using System.Runtime.CompilerServices;

// Token: 0x02002ABC RID: 10940
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsTalentNode
{
	// Token: 0x06016C89 RID: 93321 RVA: 0x005C93B5 File Offset: 0x005C75B5
	public SurvivorsTalentNode(int nodeId, int areaId, int[] preNodeIds, int effectId, int indexId, int indexSortId)
	{
		this.NodeId = nodeId;
		this.AreaId = areaId;
		this.PreNodeIds = preNodeIds;
		this.EffectId = effectId;
		this.IndexId = indexId;
		this.IndexSortId = indexSortId;
	}

	// Token: 0x0400A92D RID: 43309
	public int NodeId;

	// Token: 0x0400A92E RID: 43310
	public int AreaId;

	// Token: 0x0400A92F RID: 43311
	public int[] PreNodeIds;

	// Token: 0x0400A930 RID: 43312
	public int EffectId;

	// Token: 0x0400A931 RID: 43313
	public int IndexId;

	// Token: 0x0400A932 RID: 43314
	public int IndexSortId;

	// Token: 0x0400A933 RID: 43315
	public ESurvivorsTalentNodeStatus Status = ESurvivorsTalentNodeStatus.Lock;
}
