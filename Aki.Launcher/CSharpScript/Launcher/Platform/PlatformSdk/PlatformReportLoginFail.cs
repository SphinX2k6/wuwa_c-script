using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200015B RID: 347
	[NullableContext(1)]
	[Nullable(0)]
	public class PlatformReportLoginFail : PlatformSdkReportBaseData
	{
		// Token: 0x06000A5E RID: 2654 RVA: 0x00044CC6 File Offset: 0x00042EC6
		public PlatformReportLoginFail()
		{
			this.event_id = 60133;
			this.event_name = "login_fail";
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00044CFA File Offset: 0x00042EFA
		public static PlatformReportLoginFail Create(bool mailLogin, string code, string msg)
		{
			return new PlatformReportLoginFail
			{
				account_type = (mailLogin ? 23 : 22),
				code = code,
				msg = msg
			};
		}

		// Token: 0x04000639 RID: 1593
		public string code = "";

		// Token: 0x0400063A RID: 1594
		public string msg = "";

		// Token: 0x0400063B RID: 1595
		public int account_type;
	}
}
