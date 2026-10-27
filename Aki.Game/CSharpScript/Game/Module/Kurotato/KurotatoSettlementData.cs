using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x0200570F RID: 22287
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSettlementData : IKurotatoSettlementData
	{
		// Token: 0x17008842 RID: 34882
		// (get) Token: 0x06038A71 RID: 232049 RVA: 0x00D70899 File Offset: 0x00D6EA99
		// (set) Token: 0x06038A72 RID: 232050 RVA: 0x00D708A1 File Offset: 0x00D6EAA1
		public bool IsPass { get; set; }

		// Token: 0x17008843 RID: 34883
		// (get) Token: 0x06038A73 RID: 232051 RVA: 0x00D708AA File Offset: 0x00D6EAAA
		// (set) Token: 0x06038A74 RID: 232052 RVA: 0x00D708B2 File Offset: 0x00D6EAB2
		public long CompletionTime { get; set; }

		// Token: 0x17008844 RID: 34884
		// (get) Token: 0x06038A75 RID: 232053 RVA: 0x00D708BB File Offset: 0x00D6EABB
		// (set) Token: 0x06038A76 RID: 232054 RVA: 0x00D708C3 File Offset: 0x00D6EAC3
		public List<KurotatoItemData> ItemPanelData { get; set; }

		// Token: 0x17008845 RID: 34885
		// (get) Token: 0x06038A77 RID: 232055 RVA: 0x00D708CC File Offset: 0x00D6EACC
		// (set) Token: 0x06038A78 RID: 232056 RVA: 0x00D708D4 File Offset: 0x00D6EAD4
		public List<KurotatoWeaponData> WeaponPanelData { get; set; }

		// Token: 0x17008846 RID: 34886
		// (get) Token: 0x06038A79 RID: 232057 RVA: 0x00D708DD File Offset: 0x00D6EADD
		// (set) Token: 0x06038A7A RID: 232058 RVA: 0x00D708E5 File Offset: 0x00D6EAE5
		public int PassWaveCount { get; set; }

		// Token: 0x17008847 RID: 34887
		// (get) Token: 0x06038A7B RID: 232059 RVA: 0x00D708EE File Offset: 0x00D6EAEE
		// (set) Token: 0x06038A7C RID: 232060 RVA: 0x00D708F6 File Offset: 0x00D6EAF6
		public int CumulativeKills { get; set; }

		// Token: 0x17008848 RID: 34888
		// (get) Token: 0x06038A7D RID: 232061 RVA: 0x00D708FF File Offset: 0x00D6EAFF
		// (set) Token: 0x06038A7E RID: 232062 RVA: 0x00D70907 File Offset: 0x00D6EB07
		public Dictionary<int, int> PropertyMap { get; set; }

		// Token: 0x17008849 RID: 34889
		// (get) Token: 0x06038A7F RID: 232063 RVA: 0x00D70910 File Offset: 0x00D6EB10
		// (set) Token: 0x06038A80 RID: 232064 RVA: 0x00D70918 File Offset: 0x00D6EB18
		public List<int> UnlockWeapons { get; set; }

		// Token: 0x1700884A RID: 34890
		// (get) Token: 0x06038A81 RID: 232065 RVA: 0x00D70921 File Offset: 0x00D6EB21
		// (set) Token: 0x06038A82 RID: 232066 RVA: 0x00D70929 File Offset: 0x00D6EB29
		public List<int> UnlockItems { get; set; }

		// Token: 0x1700884B RID: 34891
		// (get) Token: 0x06038A83 RID: 232067 RVA: 0x00D70932 File Offset: 0x00D6EB32
		// (set) Token: 0x06038A84 RID: 232068 RVA: 0x00D7093A File Offset: 0x00D6EB3A
		public List<int> UnlockRoles { get; set; }
	}
}
