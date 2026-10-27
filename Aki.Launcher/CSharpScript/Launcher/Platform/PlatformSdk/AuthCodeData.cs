using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x02000197 RID: 407
	[NullableContext(1)]
	[Nullable(0)]
	public class AuthCodeData
	{
		// Token: 0x06000AF9 RID: 2809 RVA: 0x00046487 File Offset: 0x00044687
		public AuthCodeData(string authCode, int issuerId)
		{
			this.AuthCode = authCode;
			this.IssuerId = issuerId;
		}

		// Token: 0x040006EA RID: 1770
		public readonly string AuthCode;

		// Token: 0x040006EB RID: 1771
		public readonly int IssuerId;
	}
}
