using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C5 RID: 453
	public interface ILoginModel
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000C1C RID: 3100
		// (set) Token: 0x06000C1D RID: 3101
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
