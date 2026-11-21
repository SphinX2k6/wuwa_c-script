using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.PlayerInput
{
	// Token: 0x02000122 RID: 290
	[NullableContext(1)]
	public interface IKeyPath
	{
		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600095A RID: 2394
		// (set) Token: 0x0600095B RID: 2395
		[Nullable(2)]
		string XBox { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600095C RID: 2396
		// (set) Token: 0x0600095D RID: 2397
		string Ps { get; set; }
	}
}
