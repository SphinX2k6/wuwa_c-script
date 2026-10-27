using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000094 RID: 148
	[NullableContext(1)]
	public interface IRevertVersionInfo
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600053A RID: 1338
		// (set) Token: 0x0600053B RID: 1339
		bool NeedRevert { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600053C RID: 1340
		// (set) Token: 0x0600053D RID: 1341
		HashSet<string> Paks { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600053E RID: 1342
		// (set) Token: 0x0600053F RID: 1343
		HashSet<string> Files { get; set; }
	}
}
