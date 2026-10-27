using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C4 RID: 21956
	[NullableContext(1)]
	public interface INodeConstructor
	{
		// Token: 0x170086DE RID: 34526
		// (get) Token: 0x06037F72 RID: 229234
		// (set) Token: 0x06037F73 RID: 229235
		int GridId { get; set; }

		// Token: 0x170086DF RID: 34527
		// (get) Token: 0x06037F74 RID: 229236
		// (set) Token: 0x06037F75 RID: 229237
		IPos Position { get; set; }

		// Token: 0x170086E0 RID: 34528
		// (get) Token: 0x06037F76 RID: 229238
		// (set) Token: 0x06037F77 RID: 229239
		int Cost { get; set; }

		// Token: 0x170086E1 RID: 34529
		// (get) Token: 0x06037F78 RID: 229240
		// (set) Token: 0x06037F79 RID: 229241
		bool Walkable { get; set; }
	}
}
