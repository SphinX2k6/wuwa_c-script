using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005572 RID: 21874
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapNavigateState : IWorldMapNavigateState
	{
		// Token: 0x17008622 RID: 34338
		// (get) Token: 0x06037C3A RID: 228410 RVA: 0x00D39031 File Offset: 0x00D37231
		// (set) Token: 0x06037C3B RID: 228411 RVA: 0x00D39039 File Offset: 0x00D37239
		public int StateId { get; set; }

		// Token: 0x17008623 RID: 34339
		// (get) Token: 0x06037C3C RID: 228412 RVA: 0x00D39042 File Offset: 0x00D37242
		// (set) Token: 0x06037C3D RID: 228413 RVA: 0x00D3904A File Offset: 0x00D3724A
		public int SortIndex { get; set; }

		// Token: 0x17008624 RID: 34340
		// (get) Token: 0x06037C3E RID: 228414 RVA: 0x00D39053 File Offset: 0x00D37253
		// (set) Token: 0x06037C3F RID: 228415 RVA: 0x00D3905B File Offset: 0x00D3725B
		public List<IWorldMapNavigate> AreaNavigateList { get; set; } = new List<IWorldMapNavigate>();
	}
}
