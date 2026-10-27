using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x0200570E RID: 22286
	[NullableContext(1)]
	public interface IKurotatoSettlementData
	{
		// Token: 0x17008838 RID: 34872
		// (get) Token: 0x06038A5D RID: 232029
		// (set) Token: 0x06038A5E RID: 232030
		bool IsPass { get; set; }

		// Token: 0x17008839 RID: 34873
		// (get) Token: 0x06038A5F RID: 232031
		// (set) Token: 0x06038A60 RID: 232032
		long CompletionTime { get; set; }

		// Token: 0x1700883A RID: 34874
		// (get) Token: 0x06038A61 RID: 232033
		// (set) Token: 0x06038A62 RID: 232034
		List<KurotatoItemData> ItemPanelData { get; set; }

		// Token: 0x1700883B RID: 34875
		// (get) Token: 0x06038A63 RID: 232035
		// (set) Token: 0x06038A64 RID: 232036
		List<KurotatoWeaponData> WeaponPanelData { get; set; }

		// Token: 0x1700883C RID: 34876
		// (get) Token: 0x06038A65 RID: 232037
		// (set) Token: 0x06038A66 RID: 232038
		int PassWaveCount { get; set; }

		// Token: 0x1700883D RID: 34877
		// (get) Token: 0x06038A67 RID: 232039
		// (set) Token: 0x06038A68 RID: 232040
		int CumulativeKills { get; set; }

		// Token: 0x1700883E RID: 34878
		// (get) Token: 0x06038A69 RID: 232041
		// (set) Token: 0x06038A6A RID: 232042
		Dictionary<int, int> PropertyMap { get; set; }

		// Token: 0x1700883F RID: 34879
		// (get) Token: 0x06038A6B RID: 232043
		// (set) Token: 0x06038A6C RID: 232044
		List<int> UnlockWeapons { get; set; }

		// Token: 0x17008840 RID: 34880
		// (get) Token: 0x06038A6D RID: 232045
		// (set) Token: 0x06038A6E RID: 232046
		List<int> UnlockItems { get; set; }

		// Token: 0x17008841 RID: 34881
		// (get) Token: 0x06038A6F RID: 232047
		// (set) Token: 0x06038A70 RID: 232048
		List<int> UnlockRoles { get; set; }
	}
}
