using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200019B RID: 411
	[NullableContext(1)]
	[Nullable(0)]
	public class AuthCodeData
	{
		// Token: 0x06000B2D RID: 2861 RVA: 0x000488A7 File Offset: 0x00046AA7
		public AuthCodeData(string authCode, int issuerId)
		{
			this.AuthCode = authCode;
			this.IssuerId = issuerId;
		}

		// Token: 0x04000725 RID: 1829
		public readonly string AuthCode;

		// Token: 0x04000726 RID: 1830
		public readonly int IssuerId;
	}
}
