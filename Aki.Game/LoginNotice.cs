using System;
using System.Runtime.CompilerServices;

// Token: 0x0200209A RID: 8346
[NullableContext(1)]
[Nullable(0)]
public class LoginNotice
{
	// Token: 0x060106FD RID: 67325 RVA: 0x00403F10 File Offset: 0x00402110
	public void Phrase(LoginNoticeEx ex)
	{
		this.WhiteLists = ex.whiteList;
		this.BeginTime = ex.startTimeMs / 1000.0;
		this.EndTime = ex.endTimeMs / 1000.0;
		this.Title = ex.title;
		this.content = ex.content;
	}

	// Token: 0x0400797A RID: 31098
	public string Id = string.Empty;

	// Token: 0x0400797B RID: 31099
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] WhiteLists;

	// Token: 0x0400797C RID: 31100
	public double ModifyTime;

	// Token: 0x0400797D RID: 31101
	public double BeginTime;

	// Token: 0x0400797E RID: 31102
	public double EndTime;

	// Token: 0x0400797F RID: 31103
	public string Title = string.Empty;

	// Token: 0x04007980 RID: 31104
	public string content = string.Empty;
}
