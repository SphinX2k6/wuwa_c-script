using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C2 RID: 21954
	[NullableContext(1)]
	[Nullable(0)]
	public class GridsConstructor : IGridsConstructor
	{
		// Token: 0x170086D8 RID: 34520
		// (get) Token: 0x06037F68 RID: 229224 RVA: 0x00D423FA File Offset: 0x00D405FA
		// (set) Token: 0x06037F69 RID: 229225 RVA: 0x00D42402 File Offset: 0x00D40602
		public List<IPathNode> Matrix { get; set; }

		// Token: 0x170086D9 RID: 34521
		// (get) Token: 0x06037F6A RID: 229226 RVA: 0x00D4240B File Offset: 0x00D4060B
		// (set) Token: 0x06037F6B RID: 229227 RVA: 0x00D42413 File Offset: 0x00D40613
		public int Width { get; set; }

		// Token: 0x170086DA RID: 34522
		// (get) Token: 0x06037F6C RID: 229228 RVA: 0x00D4241C File Offset: 0x00D4061C
		// (set) Token: 0x06037F6D RID: 229229 RVA: 0x00D42424 File Offset: 0x00D40624
		public int Height { get; set; }
	}
}
