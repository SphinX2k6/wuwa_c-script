using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002445 RID: 9285
[NullableContext(1)]
[Nullable(0)]
public class VisionEquipGroupData
{
	// Token: 0x060129E9 RID: 76265 RVA: 0x00498459 File Offset: 0x00496659
	public VisionEquipGroupData()
	{
		this.Name = "";
		this.IncIdList = new List<int>();
	}

	// Token: 0x060129EA RID: 76266 RVA: 0x00498477 File Offset: 0x00496677
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x060129EB RID: 76267 RVA: 0x0049847F File Offset: 0x0049667F
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x060129EC RID: 76268 RVA: 0x00498487 File Offset: 0x00496687
	public int[] GetVisionUniqueIdList()
	{
		return this.IncIdList.ToArray();
	}

	// Token: 0x060129ED RID: 76269 RVA: 0x00498494 File Offset: 0x00496694
	public void Phrase(int index, PhantomEquipGroupInfo data)
	{
		this.Index = index;
		this.Name = data.Name;
		this.IncIdList = ((data.IncId != null) ? new List<int>(data.IncId) : new List<int>());
	}

	// Token: 0x04008C55 RID: 35925
	private int Index;

	// Token: 0x04008C56 RID: 35926
	private string Name;

	// Token: 0x04008C57 RID: 35927
	private List<int> IncIdList;
}
