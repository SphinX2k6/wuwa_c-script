using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200459A RID: 17818
	[NullableContext(1)]
	public interface INodeConstructor
	{
		// Token: 0x17005AA5 RID: 23205
		// (get) Token: 0x0602CE70 RID: 183920
		// (set) Token: 0x0602CE71 RID: 183921
		int GridId { get; set; }

		// Token: 0x17005AA6 RID: 23206
		// (get) Token: 0x0602CE72 RID: 183922
		// (set) Token: 0x0602CE73 RID: 183923
		IPos Position { get; set; }

		// Token: 0x17005AA7 RID: 23207
		// (get) Token: 0x0602CE74 RID: 183924
		// (set) Token: 0x0602CE75 RID: 183925
		int Cost { get; set; }

		// Token: 0x17005AA8 RID: 23208
		// (get) Token: 0x0602CE76 RID: 183926
		// (set) Token: 0x0602CE77 RID: 183927
		bool Walkable { get; set; }
	}
}
