using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200015E RID: 350
	public class PlatformReportLoginSuccess : PlatformSdkReportBaseData
	{
		// Token: 0x06000A90 RID: 2704 RVA: 0x0004709C File Offset: 0x0004529C
		public PlatformReportLoginSuccess()
		{
			this.event_id = 60132;
			this.event_name = "login_succ";
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x000470BA File Offset: 0x000452BA
		[NullableContext(1)]
		public static PlatformReportLoginSuccess Create(bool mailLogin, bool isregister)
		{
			return new PlatformReportLoginSuccess
			{
				account_type = (mailLogin ? 23 : 22),
				isregister = ((isregister > false) ? 1 : 0)
			};
		}

		// Token: 0x04000672 RID: 1650
		public int account_type;

		// Token: 0x04000673 RID: 1651
		public int isregister;
	}
}
