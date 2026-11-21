using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C7 RID: 455
	[NullableContext(1)]
	public interface ILocalStorage
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000C4F RID: 3151
		// (set) Token: 0x06000C50 RID: 3152
		Func<int?> GetRecentlyLoginUid { get; set; }
	}
}
