using System;

// Token: 0x020016C3 RID: 5827
public class AdviceSelectItemData
{
	// Token: 0x0600A675 RID: 42613 RVA: 0x00253F89 File Offset: 0x00252189
	public AdviceSelectItemData(EAdviceSelectItemEnum index)
	{
		this.Index = index;
	}

	// Token: 0x0600A676 RID: 42614 RVA: 0x00253F98 File Offset: 0x00252198
	public EAdviceSelectItemEnum GetIndex()
	{
		return this.Index;
	}

	// Token: 0x04004B28 RID: 19240
	private readonly EAdviceSelectItemEnum Index;
}
