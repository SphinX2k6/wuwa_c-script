using System;
using System.Runtime.CompilerServices;

// Token: 0x02001DF0 RID: 7664
[NullableContext(1)]
[Nullable(0)]
public class HandBookEntry
{
	// Token: 0x0600E98B RID: 59787 RVA: 0x003742E8 File Offset: 0x003724E8
	public HandBookEntry(int id, string createTime, int num, bool isRead, uint createTimeStampSecond)
	{
		this.Id = id;
		this.CreateTime = createTime;
		this.Num = num;
		this.IsRead = isRead;
		this.CreateTimeStampSecond = createTimeStampSecond;
	}

	// Token: 0x04006C2A RID: 27690
	public int Id;

	// Token: 0x04006C2B RID: 27691
	public string CreateTime;

	// Token: 0x04006C2C RID: 27692
	public uint CreateTimeStampSecond;

	// Token: 0x04006C2D RID: 27693
	public int Num;

	// Token: 0x04006C2E RID: 27694
	public bool IsRead;
}
