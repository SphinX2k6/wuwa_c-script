using System;

// Token: 0x02000BBE RID: 3006
public class BirthdayInfo
{
	// Token: 0x06007CED RID: 31981 RVA: 0x0026AE0B File Offset: 0x0026900B
	public BirthdayInfo(BirthdayDefine.ETriggerType triggerType, int year, int? roleId = null)
	{
		this.TriggerType = triggerType;
		this.Year = year;
		this.RoleId = roleId;
	}

	// Token: 0x04004DBE RID: 19902
	public BirthdayDefine.ETriggerType TriggerType;

	// Token: 0x04004DBF RID: 19903
	public int Year;

	// Token: 0x04004DC0 RID: 19904
	public int? RoleId;
}
