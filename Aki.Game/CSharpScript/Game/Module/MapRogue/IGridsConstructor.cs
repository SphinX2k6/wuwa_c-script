using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C1 RID: 21953
	[NullableContext(1)]
	public interface IGridsConstructor
	{
		// Token: 0x170086D5 RID: 34517
		// (get) Token: 0x06037F62 RID: 229218
		// (set) Token: 0x06037F63 RID: 229219
		List<IPathNode> Matrix { get; set; }

		// Token: 0x170086D6 RID: 34518
		// (get) Token: 0x06037F64 RID: 229220
		// (set) Token: 0x06037F65 RID: 229221
		int Width { get; set; }

		// Token: 0x170086D7 RID: 34519
		// (get) Token: 0x06037F66 RID: 229222
		// (set) Token: 0x06037F67 RID: 229223
		int Height { get; set; }
	}
}
