using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x0200192A RID: 6442
[NullableContext(1)]
[Nullable(0)]
public class VisionEquipGroupData
{
	// Token: 0x0600FE9F RID: 65183 RVA: 0x004A5A25 File Offset: 0x004A3C25
	public VisionEquipGroupData()
	{
		this.Name = "";
		this.IncIdList = new List<int>();
	}

	// Token: 0x0600FEA0 RID: 65184 RVA: 0x004A5A43 File Offset: 0x004A3C43
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x0600FEA1 RID: 65185 RVA: 0x004A5A4B File Offset: 0x004A3C4B
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x0600FEA2 RID: 65186 RVA: 0x004A5A53 File Offset: 0x004A3C53
	public int[] GetVisionUniqueIdList()
	{
		return this.IncIdList.ToArray();
	}

	// Token: 0x0600FEA3 RID: 65187 RVA: 0x004A5A60 File Offset: 0x004A3C60
	public void Phrase(int index, PhantomEquipGroupInfo data)
	{
		this.Index = index;
		this.Name = data.Name;
		this.IncIdList = ((data.IncId != null) ? new List<int>(data.IncId) : new List<int>());
	}

	// Token: 0x04008D9C RID: 36252
	private int Index;

	// Token: 0x04008D9D RID: 36253
	private string Name;

	// Token: 0x04008D9E RID: 36254
	private List<int> IncIdList;
}
