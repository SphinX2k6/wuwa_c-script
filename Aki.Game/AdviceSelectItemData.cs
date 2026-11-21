using System;

// Token: 0x02000B7B RID: 2939
public class AdviceSelectItemData
{
	// Token: 0x06007A55 RID: 31317 RVA: 0x0025E399 File Offset: 0x0025C599
	public AdviceSelectItemData(EAdviceSelectItemEnum index)
	{
		this.Index = index;
	}

	// Token: 0x06007A56 RID: 31318 RVA: 0x0025E3A8 File Offset: 0x0025C5A8
	public EAdviceSelectItemEnum GetIndex()
	{
		return this.Index;
	}

	// Token: 0x04004BCF RID: 19407
	private readonly EAdviceSelectItemEnum Index;
}
