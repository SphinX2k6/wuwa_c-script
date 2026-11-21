using System;
using System.Runtime.CompilerServices;

// Token: 0x02001571 RID: 5489
[NullableContext(1)]
[Nullable(0)]
public class LoginNotice
{
	// Token: 0x0600DB6B RID: 56171 RVA: 0x004104E0 File Offset: 0x0040E6E0
	public void Phrase(global::LoginNoticeEx ex)
	{
		this.WhiteLists = ex.whiteList;
		this.BeginTime = ex.startTimeMs / 1000.0;
		this.EndTime = ex.endTimeMs / 1000.0;
		this.Title = ex.title;
		this.content = ex.content;
	}

	// Token: 0x04007A78 RID: 31352
	public string Id = string.Empty;

	// Token: 0x04007A79 RID: 31353
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] WhiteLists;

	// Token: 0x04007A7A RID: 31354
	public double ModifyTime;

	// Token: 0x04007A7B RID: 31355
	public double BeginTime;

	// Token: 0x04007A7C RID: 31356
	public double EndTime;

	// Token: 0x04007A7D RID: 31357
	public string Title = string.Empty;

	// Token: 0x04007A7E RID: 31358
	public string content = string.Empty;
}
