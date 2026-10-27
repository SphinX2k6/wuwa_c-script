using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FEF RID: 24559
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisGemSnapshot : ITetrisGemSnapshot
	{
		// Token: 0x17009055 RID: 36949
		// (get) Token: 0x0603E399 RID: 254873 RVA: 0x00F05C7B File Offset: 0x00F03E7B
		// (set) Token: 0x0603E39A RID: 254874 RVA: 0x00F05C83 File Offset: 0x00F03E83
		public Dictionary<EGemType, int> CollectedGems { get; set; }

		// Token: 0x17009056 RID: 36950
		// (get) Token: 0x0603E39B RID: 254875 RVA: 0x00F05C8C File Offset: 0x00F03E8C
		// (set) Token: 0x0603E39C RID: 254876 RVA: 0x00F05C94 File Offset: 0x00F03E94
		public List<EGemType> CurrentGemBag { get; set; }

		// Token: 0x17009057 RID: 36951
		// (get) Token: 0x0603E39D RID: 254877 RVA: 0x00F05C9D File Offset: 0x00F03E9D
		// (set) Token: 0x0603E39E RID: 254878 RVA: 0x00F05CA5 File Offset: 0x00F03EA5
		public Dictionary<EGemType, int> SpawnCounts { get; set; }
	}
}
