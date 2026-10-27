using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A9F RID: 23199
	[NullableContext(1)]
	public interface IDreamLinkRewardGridData
	{
		// Token: 0x17008C0C RID: 35852
		// (get) Token: 0x0603AC31 RID: 240689
		// (set) Token: 0x0603AC32 RID: 240690
		int RewardId { get; set; }

		// Token: 0x17008C0D RID: 35853
		// (get) Token: 0x0603AC33 RID: 240691
		// (set) Token: 0x0603AC34 RID: 240692
		TItem Item { get; set; }

		// Token: 0x17008C0E RID: 35854
		// (get) Token: 0x0603AC35 RID: 240693
		// (set) Token: 0x0603AC36 RID: 240694
		EActivityTaskState Status { get; set; }

		// Token: 0x17008C0F RID: 35855
		// (get) Token: 0x0603AC37 RID: 240695
		// (set) Token: 0x0603AC38 RID: 240696
		Action ReceiveDelegate { get; set; }
	}
}
