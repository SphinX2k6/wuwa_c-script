using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CF RID: 463
	public class LoginModel : ILoginModel
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x0004DE76 File Offset: 0x0004C076
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x0004DE7E File Offset: 0x0004C07E
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Func<string> GetSdkLoginConfigUid { [return: Nullable(new byte[]
		{
			1,
			2
		})] get; [param: Nullable(new byte[]
		{
			1,
			2
		})] set; }
	}
}
