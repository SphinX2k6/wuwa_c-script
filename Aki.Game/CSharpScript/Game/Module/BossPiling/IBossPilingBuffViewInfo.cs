using System;

namespace CSharpScript.Game.Module.BossPiling
{
	// Token: 0x02004BE3 RID: 19427
	public interface IBossPilingBuffViewInfo
	{
		// Token: 0x17006167 RID: 24935
		// (get) Token: 0x060307D5 RID: 198613
		// (set) Token: 0x060307D6 RID: 198614
		int LevelId { get; set; }

		// Token: 0x17006168 RID: 24936
		// (get) Token: 0x060307D7 RID: 198615
		// (set) Token: 0x060307D8 RID: 198616
		bool InGame { get; set; }
	}
}
