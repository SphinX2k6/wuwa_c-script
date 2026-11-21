using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DD4 RID: 32212
	public class IVisualNovelPortraitPosPresetT
	{
		// Token: 0x1700F14E RID: 61774
		// (get) Token: 0x0603A365 RID: 238437 RVA: 0x007D88DD File Offset: 0x007D6ADD
		// (set) Token: 0x0603A366 RID: 238438 RVA: 0x007D88E5 File Offset: 0x007D6AE5
		public string Name { get; set; }

		// Token: 0x1700F14F RID: 61775
		// (get) Token: 0x0603A367 RID: 238439 RVA: 0x007D88EE File Offset: 0x007D6AEE
		// (set) Token: 0x0603A368 RID: 238440 RVA: 0x007D88F6 File Offset: 0x007D6AF6
		public int PosX { get; set; }

		// Token: 0x1700F150 RID: 61776
		// (get) Token: 0x0603A369 RID: 238441 RVA: 0x007D88FF File Offset: 0x007D6AFF
		// (set) Token: 0x0603A36A RID: 238442 RVA: 0x007D8907 File Offset: 0x007D6B07
		public int PosY { get; set; }

		// Token: 0x0603A36B RID: 238443 RVA: 0x007D8910 File Offset: 0x007D6B10
		public IVisualNovelPortraitPosPresetT()
		{
			this.Name = null;
			this.PosX = 0;
			this.PosY = 0;
		}
	}
}
