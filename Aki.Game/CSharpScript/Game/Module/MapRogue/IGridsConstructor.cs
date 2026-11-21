using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004597 RID: 17815
	[NullableContext(1)]
	public interface IGridsConstructor
	{
		// Token: 0x17005A9C RID: 23196
		// (get) Token: 0x0602CE60 RID: 183904
		// (set) Token: 0x0602CE61 RID: 183905
		List<IPathNode> Matrix { get; set; }

		// Token: 0x17005A9D RID: 23197
		// (get) Token: 0x0602CE62 RID: 183906
		// (set) Token: 0x0602CE63 RID: 183907
		int Width { get; set; }

		// Token: 0x17005A9E RID: 23198
		// (get) Token: 0x0602CE64 RID: 183908
		// (set) Token: 0x0602CE65 RID: 183909
		int Height { get; set; }
	}
}
