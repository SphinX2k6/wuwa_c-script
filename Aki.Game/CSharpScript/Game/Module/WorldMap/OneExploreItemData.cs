using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047A8 RID: 18344
	public class OneExploreItemData : IOneExploreItemData
	{
		// Token: 0x17007830 RID: 30768
		// (get) Token: 0x0602FFB8 RID: 196536 RVA: 0x00B1B82F File Offset: 0x00B19A2F
		// (set) Token: 0x0602FFB9 RID: 196537 RVA: 0x00B1B837 File Offset: 0x00B19A37
		public int ExploreProgressId { get; set; }

		// Token: 0x17007831 RID: 30769
		// (get) Token: 0x0602FFBA RID: 196538 RVA: 0x00B1B840 File Offset: 0x00B19A40
		// (set) Token: 0x0602FFBB RID: 196539 RVA: 0x00B1B848 File Offset: 0x00B19A48
		public float ExplorePercent { get; set; }
	}
}
