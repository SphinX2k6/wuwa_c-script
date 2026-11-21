using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A7B RID: 19067
	[NullableContext(1)]
	public interface IDreamLinkRewardGridData
	{
		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x0602FB7A RID: 195450
		// (set) Token: 0x0602FB7B RID: 195451
		int RewardId { get; set; }

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x0602FB7C RID: 195452
		// (set) Token: 0x0602FB7D RID: 195453
		TItem Item { get; set; }

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x0602FB7E RID: 195454
		// (set) Token: 0x0602FB7F RID: 195455
		EActivityTaskState Status { get; set; }

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x0602FB80 RID: 195456
		// (set) Token: 0x0602FB81 RID: 195457
		Action ReceiveDelegate { get; set; }
	}
}
