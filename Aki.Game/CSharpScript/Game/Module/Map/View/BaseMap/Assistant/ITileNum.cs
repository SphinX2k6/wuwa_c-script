using System;

namespace CSharpScript.Game.Module.Map.View.BaseMap.Assistant
{
	// Token: 0x02004479 RID: 17529
	public interface ITileNum
	{
		// Token: 0x1700585C RID: 22620
		// (get) Token: 0x0602C481 RID: 181377
		// (set) Token: 0x0602C482 RID: 181378
		int MaxX { get; set; }

		// Token: 0x1700585D RID: 22621
		// (get) Token: 0x0602C483 RID: 181379
		// (set) Token: 0x0602C484 RID: 181380
		int MinX { get; set; }

		// Token: 0x1700585E RID: 22622
		// (get) Token: 0x0602C485 RID: 181381
		// (set) Token: 0x0602C486 RID: 181382
		int MaxY { get; set; }

		// Token: 0x1700585F RID: 22623
		// (get) Token: 0x0602C487 RID: 181383
		// (set) Token: 0x0602C488 RID: 181384
		int MinY { get; set; }
	}
}
