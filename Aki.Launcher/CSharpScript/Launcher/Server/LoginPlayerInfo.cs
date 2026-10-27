using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Server
{
	// Token: 0x0200010D RID: 269
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginPlayerInfo
	{
		// Token: 0x040004F5 RID: 1269
		public int Code;

		// Token: 0x040004F6 RID: 1270
		public int SdkLoginCode;

		// Token: 0x040004F7 RID: 1271
		public string UserId = "";

		// Token: 0x040004F8 RID: 1272
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UserRegionInfo> UserInfos;

		// Token: 0x040004F9 RID: 1273
		public string RecommendRegion = "";
	}
}
