using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001D1 RID: 465
	[NullableContext(2)]
	public interface ISendLogReason
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000C6F RID: 3183
		// (set) Token: 0x06000C70 RID: 3184
		ELauncherLogUploadReason Reason { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000C71 RID: 3185
		// (set) Token: 0x06000C72 RID: 3186
		string Info { get; set; }
	}
}
