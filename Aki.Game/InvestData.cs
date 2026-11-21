using System;

// Token: 0x020007D7 RID: 2007
public class InvestData : IInvestData
{
	// Token: 0x17000BBC RID: 3004
	// (get) Token: 0x06005B8F RID: 23439 RVA: 0x001D8FD2 File Offset: 0x001D71D2
	// (set) Token: 0x06005B90 RID: 23440 RVA: 0x001D8FDA File Offset: 0x001D71DA
	public int SuccessProbability { get; set; }

	// Token: 0x17000BBD RID: 3005
	// (get) Token: 0x06005B91 RID: 23441 RVA: 0x001D8FE3 File Offset: 0x001D71E3
	// (set) Token: 0x06005B92 RID: 23442 RVA: 0x001D8FEB File Offset: 0x001D71EB
	public int Ratio { get; set; }
}
