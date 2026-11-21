using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A7C RID: 19068
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRewardGridData : IDreamLinkRewardGridData
	{
		// Token: 0x17005FDE RID: 24542
		// (get) Token: 0x0602FB82 RID: 195458 RVA: 0x00D4F6D6 File Offset: 0x00D4D8D6
		// (set) Token: 0x0602FB83 RID: 195459 RVA: 0x00D4F6DE File Offset: 0x00D4D8DE
		public int RewardId { get; set; }

		// Token: 0x17005FDF RID: 24543
		// (get) Token: 0x0602FB84 RID: 195460 RVA: 0x00D4F6E7 File Offset: 0x00D4D8E7
		// (set) Token: 0x0602FB85 RID: 195461 RVA: 0x00D4F6EF File Offset: 0x00D4D8EF
		public TItem Item { get; set; }

		// Token: 0x17005FE0 RID: 24544
		// (get) Token: 0x0602FB86 RID: 195462 RVA: 0x00D4F6F8 File Offset: 0x00D4D8F8
		// (set) Token: 0x0602FB87 RID: 195463 RVA: 0x00D4F700 File Offset: 0x00D4D900
		public EActivityTaskState Status { get; set; }

		// Token: 0x17005FE1 RID: 24545
		// (get) Token: 0x0602FB88 RID: 195464 RVA: 0x00D4F709 File Offset: 0x00D4D909
		// (set) Token: 0x0602FB89 RID: 195465 RVA: 0x00D4F711 File Offset: 0x00D4D911
		public Action ReceiveDelegate { get; set; }
	}
}
