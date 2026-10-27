using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;

// Token: 0x0200209F RID: 8351
[NullableContext(1)]
[Nullable(0)]
public class LoginPlayerInfo : JsonObjBase
{
	// Token: 0x040079D9 RID: 31193
	public int Code;

	// Token: 0x040079DA RID: 31194
	public int SdkLoginCode;

	// Token: 0x040079DB RID: 31195
	public string UserId = string.Empty;

	// Token: 0x040079DC RID: 31196
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<UserRegionInfo> UserInfos;

	// Token: 0x040079DD RID: 31197
	public string RecommendRegion = string.Empty;
}
