using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x02001576 RID: 5494
[NullableContext(1)]
[Nullable(0)]
public class LoginPlayerInfo : JsonObjBase
{
	// Token: 0x04007AD7 RID: 31447
	public int Code;

	// Token: 0x04007AD8 RID: 31448
	public int SdkLoginCode;

	// Token: 0x04007AD9 RID: 31449
	public string UserId = string.Empty;

	// Token: 0x04007ADA RID: 31450
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UserRegionInfo> UserInfos;

	// Token: 0x04007ADB RID: 31451
	public string RecommendRegion = string.Empty;
}
