using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046E5 RID: 18149
	[NullableContext(1)]
	public interface IKurotatoSettlementData
	{
		// Token: 0x17005C00 RID: 23552
		// (get) Token: 0x0602D96D RID: 186733
		// (set) Token: 0x0602D96E RID: 186734
		bool IsPass { get; set; }

		// Token: 0x17005C01 RID: 23553
		// (get) Token: 0x0602D96F RID: 186735
		// (set) Token: 0x0602D970 RID: 186736
		long CompletionTime { get; set; }

		// Token: 0x17005C02 RID: 23554
		// (get) Token: 0x0602D971 RID: 186737
		// (set) Token: 0x0602D972 RID: 186738
		List<KurotatoItemData> ItemPanelData { get; set; }

		// Token: 0x17005C03 RID: 23555
		// (get) Token: 0x0602D973 RID: 186739
		// (set) Token: 0x0602D974 RID: 186740
		List<KurotatoWeaponData> WeaponPanelData { get; set; }

		// Token: 0x17005C04 RID: 23556
		// (get) Token: 0x0602D975 RID: 186741
		// (set) Token: 0x0602D976 RID: 186742
		int PassWaveCount { get; set; }

		// Token: 0x17005C05 RID: 23557
		// (get) Token: 0x0602D977 RID: 186743
		// (set) Token: 0x0602D978 RID: 186744
		int CumulativeKills { get; set; }

		// Token: 0x17005C06 RID: 23558
		// (get) Token: 0x0602D979 RID: 186745
		// (set) Token: 0x0602D97A RID: 186746
		Dictionary<int, int> PropertyMap { get; set; }

		// Token: 0x17005C07 RID: 23559
		// (get) Token: 0x0602D97B RID: 186747
		// (set) Token: 0x0602D97C RID: 186748
		List<int> UnlockWeapons { get; set; }

		// Token: 0x17005C08 RID: 23560
		// (get) Token: 0x0602D97D RID: 186749
		// (set) Token: 0x0602D97E RID: 186750
		List<int> UnlockItems { get; set; }

		// Token: 0x17005C09 RID: 23561
		// (get) Token: 0x0602D97F RID: 186751
		// (set) Token: 0x0602D980 RID: 186752
		List<int> UnlockRoles { get; set; }
	}
}
