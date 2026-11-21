using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004AE9 RID: 19177
	public class RewardData : IRewardData
	{
		// Token: 0x17006052 RID: 24658
		// (get) Token: 0x0602FF84 RID: 196484 RVA: 0x00D61E4E File Offset: 0x00D6004E
		// (set) Token: 0x0602FF85 RID: 196485 RVA: 0x00D61E56 File Offset: 0x00D60056
		public int RewardId { get; set; }

		// Token: 0x17006053 RID: 24659
		// (get) Token: 0x0602FF86 RID: 196486 RVA: 0x00D61E5F File Offset: 0x00D6005F
		// (set) Token: 0x0602FF87 RID: 196487 RVA: 0x00D61E67 File Offset: 0x00D60067
		public int Count { get; set; }

		// Token: 0x17006054 RID: 24660
		// (get) Token: 0x0602FF88 RID: 196488 RVA: 0x00D61E70 File Offset: 0x00D60070
		// (set) Token: 0x0602FF89 RID: 196489 RVA: 0x00D61E78 File Offset: 0x00D60078
		public bool IsGet { get; set; }
	}
}
