using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.LogUpload
{
	// Token: 0x020001C3 RID: 451
	[NullableContext(1)]
	public interface ILocalStorage
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000C18 RID: 3096
		// (set) Token: 0x06000C19 RID: 3097
		Func<int?> GetRecentlyLoginUid { get; set; }
	}
}
