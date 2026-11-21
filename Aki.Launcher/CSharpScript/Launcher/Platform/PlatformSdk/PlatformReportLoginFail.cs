using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200015F RID: 351
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportLoginFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A92 RID: 2706 RVA: 0x000470DA File Offset: 0x000452DA
		public PlatformReportLoginFail()
		{
			this.event_id = 60133;
			this.event_name = "login_fail";
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0004710E File Offset: 0x0004530E
		public static PlatformReportLoginFail Create(bool mailLogin, string code, string msg)
		{
			return new PlatformReportLoginFail
			{
				account_type = (mailLogin ? 23 : 22),
				code = code,
				msg = msg
			};
		}

		// Token: 0x04000674 RID: 1652
		public string code = "";

		// Token: 0x04000675 RID: 1653
		public string msg = "";

		// Token: 0x04000676 RID: 1654
		public int account_type;
	}
}
