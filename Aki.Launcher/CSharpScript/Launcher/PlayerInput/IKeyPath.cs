using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x0200011E RID: 286
	[NullableContext(1)]
	public interface IKeyPath
	{
		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000926 RID: 2342
		// (set) Token: 0x06000927 RID: 2343
		[Nullable(2)]
		string XBox { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000928 RID: 2344
		// (set) Token: 0x06000929 RID: 2345
		string Ps { get; set; }
	}
}
