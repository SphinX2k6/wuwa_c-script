using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001D2 RID: 466
	[NullableContext(2)]
	[Nullable(0)]
	public class SendLogReason : ISendLogReason
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x0004DE8F File Offset: 0x0004C08F
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x0004DE97 File Offset: 0x0004C097
		public ELauncherLogUploadReason Reason { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x0004DEA0 File Offset: 0x0004C0A0
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
		public string Info { get; set; }
	}
}
