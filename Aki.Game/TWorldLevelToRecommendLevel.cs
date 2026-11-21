using System;

// Token: 0x02001466 RID: 5222
public class TWorldLevelToRecommendLevel
{
	// Token: 0x17001372 RID: 4978
	// (get) Token: 0x0600CFC9 RID: 53193 RVA: 0x003DC047 File Offset: 0x003DA247
	// (set) Token: 0x0600CFCA RID: 53194 RVA: 0x003DC04F File Offset: 0x003DA24F
	public int Item1 { get; set; }

	// Token: 0x17001373 RID: 4979
	// (get) Token: 0x0600CFCB RID: 53195 RVA: 0x003DC058 File Offset: 0x003DA258
	// (set) Token: 0x0600CFCC RID: 53196 RVA: 0x003DC060 File Offset: 0x003DA260
	public int Item2 { get; set; }

	// Token: 0x0600CFCD RID: 53197 RVA: 0x003DC069 File Offset: 0x003DA269
	public TWorldLevelToRecommendLevel(int item1, int item2)
	{
		this.Item1 = item1;
		this.Item2 = item2;
	}
}
