using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CE RID: 462
	[NullableContext(2)]
	[Nullable(0)]
	public class SendLogReason : ISendLogReason
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0004B67B File Offset: 0x0004987B
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0004B683 File Offset: 0x00049883
		public ELauncherLogUploadReason Reason { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0004B68C File Offset: 0x0004988C
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x0004B694 File Offset: 0x00049894
		public string Info { get; set; }
	}
}
