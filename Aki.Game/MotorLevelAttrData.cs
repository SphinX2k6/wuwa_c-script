using System;

// Token: 0x02001730 RID: 5936
public class MotorLevelAttrData : IMotorLevelAttrData
{
	// Token: 0x170015EB RID: 5611
	// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x0043AC8C File Offset: 0x00438E8C
	// (set) Token: 0x0600E6B2 RID: 59058 RVA: 0x0043AC94 File Offset: 0x00438E94
	public int AttrId { get; set; }

	// Token: 0x170015EC RID: 5612
	// (get) Token: 0x0600E6B3 RID: 59059 RVA: 0x0043AC9D File Offset: 0x00438E9D
	// (set) Token: 0x0600E6B4 RID: 59060 RVA: 0x0043ACA5 File Offset: 0x00438EA5
	public int Level { get; set; }

	// Token: 0x170015ED RID: 5613
	// (get) Token: 0x0600E6B5 RID: 59061 RVA: 0x0043ACAE File Offset: 0x00438EAE
	// (set) Token: 0x0600E6B6 RID: 59062 RVA: 0x0043ACB6 File Offset: 0x00438EB6
	public bool IsShowBg { get; set; }

	// Token: 0x170015EE RID: 5614
	// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x0043ACBF File Offset: 0x00438EBF
	// (set) Token: 0x0600E6B8 RID: 59064 RVA: 0x0043ACC7 File Offset: 0x00438EC7
	public bool IsSpecial { get; set; }
}
