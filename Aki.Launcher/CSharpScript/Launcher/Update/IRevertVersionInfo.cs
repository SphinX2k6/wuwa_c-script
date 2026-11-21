using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000097 RID: 151
	[NullableContext(1)]
	public interface IRevertVersionInfo
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000551 RID: 1361
		// (set) Token: 0x06000552 RID: 1362
		bool NeedRevert { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000553 RID: 1363
		// (set) Token: 0x06000554 RID: 1364
		HashSet<string> Paks { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000555 RID: 1365
		// (set) Token: 0x06000556 RID: 1366
		HashSet<string> Files { get; set; }
	}
}
