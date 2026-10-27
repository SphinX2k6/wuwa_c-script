using System;
using System.Runtime.CompilerServices;

// Token: 0x02002912 RID: 10514
public class AssemblyGridData
{
	// Token: 0x06015AEF RID: 88815 RVA: 0x00578601 File Offset: 0x00576801
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

	// Token: 0x0400A185 RID: 41349
	public int Id;

	// Token: 0x0400A186 RID: 41350
	public int Index;

	// Token: 0x0400A187 RID: 41351
	public ERouletteGridType GridType;

	// Token: 0x0400A188 RID: 41352
	[Nullable(1)]
	public string Name;

	// Token: 0x0400A189 RID: 41353
	public EAssemblyGridState State;

	// Token: 0x0400A18A RID: 41354
	public int SortId;

	// Token: 0x0400A18B RID: 41355
	public int RelativeIndex;
}
