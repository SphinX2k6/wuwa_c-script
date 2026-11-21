using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Server
{
	// Token: 0x02000111 RID: 273
	[NullableContext(1)]
	[Nullable(0)]
	public class LoginPlayerInfo
	{
		// Token: 0x04000530 RID: 1328
		public int Code;

		// Token: 0x04000531 RID: 1329
		public int SdkLoginCode;

		// Token: 0x04000532 RID: 1330
		public string UserId = "";

		// Token: 0x04000533 RID: 1331
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UserRegionInfo> UserInfos;

		// Token: 0x04000534 RID: 1332
		public string RecommendRegion = "";
	}
}
