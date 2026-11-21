using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x0200009B RID: 155
	[NullableContext(1)]
	[Nullable(0)]
	public class RevertVersionInfo : IRevertVersionInfo
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00032B8C File Offset: 0x00030D8C
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x00032B94 File Offset: 0x00030D94
		public bool NeedRevert { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00032B9D File Offset: 0x00030D9D
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00032BA5 File Offset: 0x00030DA5
		public HashSet<string> Paks { get; set; } = new HashSet<string>();

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00032BAE File Offset: 0x00030DAE
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00032BB6 File Offset: 0x00030DB6
		public HashSet<string> Files { get; set; } = new HashSet<string>();
	}
}
