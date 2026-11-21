using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C9 RID: 457
	public interface ILoginModel
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000C53 RID: 3155
		// (set) Token: 0x06000C54 RID: 3156
		[Nullable(new byte[]
		{
			1,
			2
		})]
		Func<string> GetSdkLoginConfigUid { [return: Nullable(new byte[]
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
