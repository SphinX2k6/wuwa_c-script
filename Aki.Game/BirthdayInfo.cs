using System;

// Token: 0x02001706 RID: 5894
public class BirthdayInfo
{
	// Token: 0x0600A90D RID: 43277 RVA: 0x002609EF File Offset: 0x0025EBEF
	public BirthdayInfo(BirthdayDefine.ETriggerType triggerType, int year, int? roleId = null)
	{
		this.TriggerType = triggerType;
		this.Year = year;
		this.RoleId = roleId;
	}

	// Token: 0x04004D17 RID: 19735
	public BirthdayDefine.ETriggerType TriggerType;

	// Token: 0x04004D18 RID: 19736
	public int Year;

	// Token: 0x04004D19 RID: 19737
	public int? RoleId;
}
