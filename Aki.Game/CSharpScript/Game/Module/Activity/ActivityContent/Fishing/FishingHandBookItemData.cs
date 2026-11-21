using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005582 RID: 21890
	[NullableContext(1)]
	[Nullable(0)]
	public class FishingHandBookItemData : IFishingHandBookItemData
	{
		// Token: 0x17006956 RID: 26966
		// (get) Token: 0x06036406 RID: 222214 RVA: 0x00F20C4D File Offset: 0x00F1EE4D
		// (set) Token: 0x06036407 RID: 222215 RVA: 0x00F20C55 File Offset: 0x00F1EE55
		public int Id { get; set; }

		// Token: 0x17006957 RID: 26967
		// (get) Token: 0x06036408 RID: 222216 RVA: 0x00F20C5E File Offset: 0x00F1EE5E
		// (set) Token: 0x06036409 RID: 222217 RVA: 0x00F20C66 File Offset: 0x00F1EE66
		public int Type { get; set; }

		// Token: 0x17006958 RID: 26968
		// (get) Token: 0x0603640A RID: 222218 RVA: 0x00F20C6F File Offset: 0x00F1EE6F
		// (set) Token: 0x0603640B RID: 222219 RVA: 0x00F20C77 File Offset: 0x00F1EE77
		public int Time { get; set; }

		// Token: 0x17006959 RID: 26969
		// (get) Token: 0x0603640C RID: 222220 RVA: 0x00F20C80 File Offset: 0x00F1EE80
		// (set) Token: 0x0603640D RID: 222221 RVA: 0x00F20C88 File Offset: 0x00F1EE88
		public List<int> Tech { get; set; }

		// Token: 0x1700695A RID: 26970
		// (get) Token: 0x0603640E RID: 222222 RVA: 0x00F20C91 File Offset: 0x00F1EE91
		// (set) Token: 0x0603640F RID: 222223 RVA: 0x00F20C99 File Offset: 0x00F1EE99
		public List<int> Area { get; set; }

		// Token: 0x1700695B RID: 26971
		// (get) Token: 0x06036410 RID: 222224 RVA: 0x00F20CA2 File Offset: 0x00F1EEA2
		// (set) Token: 0x06036411 RID: 222225 RVA: 0x00F20CAA File Offset: 0x00F1EEAA
		public int HandBookId { get; set; }

		// Token: 0x06036412 RID: 222226 RVA: 0x00F20CB3 File Offset: 0x00F1EEB3
		public FishingHandBookItemData()
		{
			this.Tech = new List<int>();
			this.Area = new List<int>();
		}
	}
}
