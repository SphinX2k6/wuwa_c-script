using System;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036D9 RID: 14041
	public class OneExploreItemData : IOneExploreItemData
	{
		// Token: 0x17004AEC RID: 19180
		// (get) Token: 0x06024785 RID: 149381 RVA: 0x00A4B7CB File Offset: 0x00A499CB
		// (set) Token: 0x06024786 RID: 149382 RVA: 0x00A4B7D3 File Offset: 0x00A499D3
		public int ExploreProgressId { get; set; }

		// Token: 0x17004AED RID: 19181
		// (get) Token: 0x06024787 RID: 149383 RVA: 0x00A4B7DC File Offset: 0x00A499DC
		// (set) Token: 0x06024788 RID: 149384 RVA: 0x00A4B7E4 File Offset: 0x00A499E4
		public float ExplorePercent { get; set; }
	}
}
