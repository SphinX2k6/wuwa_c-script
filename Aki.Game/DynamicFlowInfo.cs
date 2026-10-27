using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001D54 RID: 7508
public class DynamicFlowInfo
{
	// Token: 0x0600E412 RID: 58386 RVA: 0x003594C4 File Offset: 0x003576C4
	public DynamicFlowInfo()
	{
		this.DynamicFlowNpcList = new List<int>();
	}

	// Token: 0x0600E413 RID: 58387 RVA: 0x003594D7 File Offset: 0x003576D7
	public void Dispose()
	{
		this.ClearDynamicFlowNpcList();
	}

	// Token: 0x0600E414 RID: 58388 RVA: 0x003594DF File Offset: 0x003576DF
	public void AddDynamicFlowNpc(int npcPbDataId)
	{
		this.DynamicFlowNpcList.Add(npcPbDataId);
	}

	// Token: 0x0600E415 RID: 58389 RVA: 0x003594F0 File Offset: 0x003576F0
	public void ClearDynamicFlowNpcList()
	{
		foreach (int pbDataId in this.DynamicFlowNpcList)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(pbDataId);
			if (entityByPbDataId != null)
			{
				NpcFlowComponent component = entityByPbDataId.Entity.GetComponent<NpcFlowComponent>();
				if (component != null)
				{
					component.PlayDynamicFlowEnd();
				}
			}
		}
		this.DynamicFlowNpcList.Clear();
	}

	// Token: 0x04006928 RID: 26920
	[Nullable(2)]
	private readonly List<int> DynamicFlowNpcList;
}
