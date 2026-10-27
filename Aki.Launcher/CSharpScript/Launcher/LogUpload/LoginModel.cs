using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001CB RID: 459
	public class LoginModel : ILoginModel
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0004B662 File Offset: 0x00049862
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0004B66A File Offset: 0x0004986A
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
