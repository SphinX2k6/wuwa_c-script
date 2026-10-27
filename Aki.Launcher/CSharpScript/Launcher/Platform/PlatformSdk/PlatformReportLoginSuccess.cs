using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200015A RID: 346
	public class PlatformReportLoginSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A5C RID: 2652 RVA: 0x00044C88 File Offset: 0x00042E88
		public PlatformReportLoginSuccess()
		{
			this.event_id = 60132;
			this.event_name = "login_succ";
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00044CA6 File Offset: 0x00042EA6
		[NullableContext(1)]
		public static PlatformReportLoginSuccess Create(bool mailLogin, bool isregister)
		{
			return new PlatformReportLoginSuccess
			{
				account_type = (mailLogin ? 23 : 22),
				isregister = ((isregister > false) ? 1 : 0)
			};
		}

		// Token: 0x04000637 RID: 1591
		public int account_type;

		// Token: 0x04000638 RID: 1592
		public int isregister;
	}
}
