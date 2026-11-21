using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x0200300A RID: 12298
	[NullableContext(1)]
	[Nullable(0)]
	public class EncircleArgs : IEncircleArgs
	{
		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x0601D2EF RID: 119535 RVA: 0x008E911B File Offset: 0x008E731B
		// (set) Token: 0x0601D2F0 RID: 119536 RVA: 0x008E9123 File Offset: 0x008E7323
		public Dictionary<int, IHexData> Hexes { get; set; }

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x0601D2F1 RID: 119537 RVA: 0x008E912C File Offset: 0x008E732C
		// (set) Token: 0x0601D2F2 RID: 119538 RVA: 0x008E9134 File Offset: 0x008E7334
		public int Height { get; set; }

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x0601D2F3 RID: 119539 RVA: 0x008E913D File Offset: 0x008E733D
		// (set) Token: 0x0601D2F4 RID: 119540 RVA: 0x008E9145 File Offset: 0x008E7345
		public int Width { get; set; }
	}
}
