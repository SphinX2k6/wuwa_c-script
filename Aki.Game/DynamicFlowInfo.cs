using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001216 RID: 4630
public class DynamicFlowInfo
{
	// Token: 0x0600B82F RID: 47151 RVA: 0x00364F98 File Offset: 0x00363198
	public DynamicFlowInfo()
	{
		this.DynamicFlowNpcList = new List<int>();
	}

	// Token: 0x0600B830 RID: 47152 RVA: 0x00364FAB File Offset: 0x003631AB
	public void Dispose()
	{
		this.ClearDynamicFlowNpcList();
	}

	// Token: 0x0600B831 RID: 47153 RVA: 0x00364FB3 File Offset: 0x003631B3
	public void AddDynamicFlowNpc(int npcPbDataId)
	{
		this.DynamicFlowNpcList.Add(npcPbDataId);
	}

	// Token: 0x0600B832 RID: 47154 RVA: 0x00364FC4 File Offset: 0x003631C4
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

	// Token: 0x04006A08 RID: 27144
	[Nullable(2)]
	private readonly List<int> DynamicFlowNpcList;
}
