using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F8D RID: 16269
	public class ISyncBlockGroupT
	{
		// Token: 0x17006E1B RID: 28187
		// (get) Token: 0x060162D9 RID: 90841 RVA: 0x0032E298 File Offset: 0x0032C498
		// (set) Token: 0x060162DA RID: 90842 RVA: 0x0032E2A0 File Offset: 0x0032C4A0
		public string Name { get; set; }

		// Token: 0x17006E1C RID: 28188
		// (get) Token: 0x060162DB RID: 90843 RVA: 0x0032E2A9 File Offset: 0x0032C4A9
		// (set) Token: 0x060162DC RID: 90844 RVA: 0x0032E2B1 File Offset: 0x0032C4B1
		public List<ISyncBlockT> SyncBlocks { get; set; }

		// Token: 0x060162DD RID: 90845 RVA: 0x0032E2BA File Offset: 0x0032C4BA
		public ISyncBlockGroupT()
		{
			this.Name = null;
			this.SyncBlocks = null;
		}
	}
}
