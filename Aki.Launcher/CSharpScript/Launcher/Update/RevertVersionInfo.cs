using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Update
{
	// Token: 0x02000098 RID: 152
	[NullableContext(1)]
	[Nullable(0)]
	public class RevertVersionInfo : IRevertVersionInfo
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00031624 File Offset: 0x0002F824
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x0003162C File Offset: 0x0002F82C
		public bool NeedRevert { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00031635 File Offset: 0x0002F835
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x0003163D File Offset: 0x0002F83D
		public HashSet<string> Paks { get; set; } = new HashSet<string>();

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00031646 File Offset: 0x0002F846
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x0003164E File Offset: 0x0002F84E
		public HashSet<string> Files { get; set; } = new HashSet<string>();
	}
}
