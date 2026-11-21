using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004598 RID: 17816
	[NullableContext(1)]
	[Nullable(0)]
	public class GridsConstructor : IGridsConstructor
	{
		// Token: 0x17005A9F RID: 23199
		// (get) Token: 0x0602CE66 RID: 183910 RVA: 0x00C90142 File Offset: 0x00C8E342
		// (set) Token: 0x0602CE67 RID: 183911 RVA: 0x00C9014A File Offset: 0x00C8E34A
		public List<IPathNode> Matrix { get; set; }

		// Token: 0x17005AA0 RID: 23200
		// (get) Token: 0x0602CE68 RID: 183912 RVA: 0x00C90153 File Offset: 0x00C8E353
		// (set) Token: 0x0602CE69 RID: 183913 RVA: 0x00C9015B File Offset: 0x00C8E35B
		public int Width { get; set; }

		// Token: 0x17005AA1 RID: 23201
		// (get) Token: 0x0602CE6A RID: 183914 RVA: 0x00C90164 File Offset: 0x00C8E364
		// (set) Token: 0x0602CE6B RID: 183915 RVA: 0x00C9016C File Offset: 0x00C8E36C
		public int Height { get; set; }
	}
}
