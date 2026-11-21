using System;
using System.Runtime.CompilerServices;

// Token: 0x020012B2 RID: 4786
[NullableContext(1)]
[Nullable(0)]
public class HandBookEntry
{
	// Token: 0x0600BDAA RID: 48554 RVA: 0x0037FFF0 File Offset: 0x0037E1F0
	public HandBookEntry(int id, string createTime, int num, bool isRead, uint createTimeStampSecond)
	{
		this.Id = id;
		this.CreateTime = createTime;
		this.Num = num;
		this.IsRead = isRead;
		this.CreateTimeStampSecond = createTimeStampSecond;
	}

	// Token: 0x04006D0B RID: 27915
	public int Id;

	// Token: 0x04006D0C RID: 27916
	public string CreateTime;

	// Token: 0x04006D0D RID: 27917
	public uint CreateTimeStampSecond;

	// Token: 0x04006D0E RID: 27918
	public int Num;

	// Token: 0x04006D0F RID: 27919
	public bool IsRead;
}
