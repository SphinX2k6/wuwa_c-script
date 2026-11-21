using System;
using System.Runtime.CompilerServices;

// Token: 0x02001E8D RID: 7821
public class AssemblyGridData
{
	// Token: 0x060134F3 RID: 79091 RVA: 0x005A34F5 File Offset: 0x005A16F5
	public AssemblyGridData()
	{
		this.Id = 0;
		this.Index = -1;
		this.GridType = ERouletteGridType.Explore;
		this.Name = "";
		this.State = EAssemblyGridState.UnEquip;
		this.SortId = 0;
		this.RelativeIndex = 0;
	}

	// Token: 0x0400A570 RID: 42352
	public int Id;

	// Token: 0x0400A571 RID: 42353
	public int Index;

	// Token: 0x0400A572 RID: 42354
	public ERouletteGridType GridType;

	// Token: 0x0400A573 RID: 42355
	[Nullable(1)]
	public string Name;

	// Token: 0x0400A574 RID: 42356
	public EAssemblyGridState State;

	// Token: 0x0400A575 RID: 42357
	public int SortId;

	// Token: 0x0400A576 RID: 42358
	public int RelativeIndex;
}
