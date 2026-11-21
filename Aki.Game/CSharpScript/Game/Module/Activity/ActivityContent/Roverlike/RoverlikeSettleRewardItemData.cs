using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005117 RID: 20759
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSettleRewardItemData : IRoverlikeSettleRewardItemData
	{
		// Token: 0x17006561 RID: 25953
		// (get) Token: 0x06033EAC RID: 212652 RVA: 0x00E861D2 File Offset: 0x00E843D2
		// (set) Token: 0x06033EAD RID: 212653 RVA: 0x00E861DA File Offset: 0x00E843DA
		public string IconPath { get; set; } = string.Empty;

		// Token: 0x17006562 RID: 25954
		// (get) Token: 0x06033EAE RID: 212654 RVA: 0x00E861E3 File Offset: 0x00E843E3
		// (set) Token: 0x06033EAF RID: 212655 RVA: 0x00E861EB File Offset: 0x00E843EB
		public string NameTextId { get; set; } = string.Empty;

		// Token: 0x17006563 RID: 25955
		// (get) Token: 0x06033EB0 RID: 212656 RVA: 0x00E861F4 File Offset: 0x00E843F4
		// (set) Token: 0x06033EB1 RID: 212657 RVA: 0x00E861FC File Offset: 0x00E843FC
		public int Num { get; set; }
	}
}
