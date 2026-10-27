using System;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02005496 RID: 21654
	public interface ITileNum
	{
		// Token: 0x17008490 RID: 33936
		// (get) Token: 0x0603752B RID: 226603
		// (set) Token: 0x0603752C RID: 226604
		int MaxX { get; set; }

		// Token: 0x17008491 RID: 33937
		// (get) Token: 0x0603752D RID: 226605
		// (set) Token: 0x0603752E RID: 226606
		int MinX { get; set; }

		// Token: 0x17008492 RID: 33938
		// (get) Token: 0x0603752F RID: 226607
		// (set) Token: 0x06037530 RID: 226608
		int MaxY { get; set; }

		// Token: 0x17008493 RID: 33939
		// (get) Token: 0x06037531 RID: 226609
		// (set) Token: 0x06037532 RID: 226610
		int MinY { get; set; }
	}
}
