using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005639 RID: 22073
	public class INpcPerformOnMonsterClosebyT
	{
		// Token: 0x1700A384 RID: 41860
		// (get) Token: 0x06024AFB RID: 150267 RVA: 0x0051054F File Offset: 0x0050E74F
		// (set) Token: 0x06024AFC RID: 150268 RVA: 0x00510557 File Offset: 0x0050E757
		public float Range { get; set; }

		// Token: 0x1700A385 RID: 41861
		// (get) Token: 0x06024AFD RID: 150269 RVA: 0x00510560 File Offset: 0x0050E760
		// (set) Token: 0x06024AFE RID: 150270 RVA: 0x00510568 File Offset: 0x0050E768
		public IMontageIdT Montage { get; set; }

		// Token: 0x1700A386 RID: 41862
		// (get) Token: 0x06024AFF RID: 150271 RVA: 0x00510571 File Offset: 0x0050E771
		// (set) Token: 0x06024B00 RID: 150272 RVA: 0x00510579 File Offset: 0x0050E779
		public IBubbleIndexT Bubble { get; set; }

		// Token: 0x1700A387 RID: 41863
		// (get) Token: 0x06024B01 RID: 150273 RVA: 0x00510582 File Offset: 0x0050E782
		// (set) Token: 0x06024B02 RID: 150274 RVA: 0x0051058A File Offset: 0x0050E78A
		public int BubbleRate { get; set; }

		// Token: 0x06024B03 RID: 150275 RVA: 0x00510593 File Offset: 0x0050E793
		public INpcPerformOnMonsterClosebyT()
		{
			this.Range = 0f;
			this.Montage = null;
			this.Bubble = null;
			this.BubbleRate = 0;
		}
	}
}
