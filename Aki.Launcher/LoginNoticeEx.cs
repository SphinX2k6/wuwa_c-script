using System;
using System.Runtime.CompilerServices;

// Token: 0x0200000B RID: 11
[NullableContext(1)]
[Nullable(0)]
public class LoginNoticeEx
{
	// Token: 0x0400003F RID: 63
	public string title = string.Empty;

	// Token: 0x04000040 RID: 64
	public string content = string.Empty;

	// Token: 0x04000041 RID: 65
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] whiteList;

	// Token: 0x04000042 RID: 66
	public double startTimeMs;

	// Token: 0x04000043 RID: 67
	public double endTimeMs;
}
