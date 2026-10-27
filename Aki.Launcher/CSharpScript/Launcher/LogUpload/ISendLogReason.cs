using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CD RID: 461
	[NullableContext(2)]
	public interface ISendLogReason
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000C38 RID: 3128
		// (set) Token: 0x06000C39 RID: 3129
		ELauncherLogUploadReason Reason { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000C3A RID: 3130
		// (set) Token: 0x06000C3B RID: 3131
		string Info { get; set; }
	}
}
