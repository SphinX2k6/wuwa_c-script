using System;
using System.Runtime.CompilerServices;

// Token: 0x02001570 RID: 5488
[NullableContext(1)]
[Nullable(0)]
public class LoginNoticeEx
{
	// Token: 0x04007A73 RID: 31347
	public string title = string.Empty;

	// Token: 0x04007A74 RID: 31348
	public string content = string.Empty;

	// Token: 0x04007A75 RID: 31349
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] whiteList;

	// Token: 0x04007A76 RID: 31350
	public double startTimeMs;

	// Token: 0x04007A77 RID: 31351
	public double endTimeMs;
}
