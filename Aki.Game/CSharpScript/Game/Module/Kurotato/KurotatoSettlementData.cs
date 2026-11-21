using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046E6 RID: 18150
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoSettlementData : IKurotatoSettlementData
	{
		// Token: 0x17005C0A RID: 23562
		// (get) Token: 0x0602D981 RID: 186753 RVA: 0x00CBEE81 File Offset: 0x00CBD081
		// (set) Token: 0x0602D982 RID: 186754 RVA: 0x00CBEE89 File Offset: 0x00CBD089
		public bool IsPass { get; set; }

		// Token: 0x17005C0B RID: 23563
		// (get) Token: 0x0602D983 RID: 186755 RVA: 0x00CBEE92 File Offset: 0x00CBD092
		// (set) Token: 0x0602D984 RID: 186756 RVA: 0x00CBEE9A File Offset: 0x00CBD09A
		public long CompletionTime { get; set; }

		// Token: 0x17005C0C RID: 23564
		// (get) Token: 0x0602D985 RID: 186757 RVA: 0x00CBEEA3 File Offset: 0x00CBD0A3
		// (set) Token: 0x0602D986 RID: 186758 RVA: 0x00CBEEAB File Offset: 0x00CBD0AB
		public List<KurotatoItemData> ItemPanelData { get; set; }

		// Token: 0x17005C0D RID: 23565
		// (get) Token: 0x0602D987 RID: 186759 RVA: 0x00CBEEB4 File Offset: 0x00CBD0B4
		// (set) Token: 0x0602D988 RID: 186760 RVA: 0x00CBEEBC File Offset: 0x00CBD0BC
		public List<KurotatoWeaponData> WeaponPanelData { get; set; }

		// Token: 0x17005C0E RID: 23566
		// (get) Token: 0x0602D989 RID: 186761 RVA: 0x00CBEEC5 File Offset: 0x00CBD0C5
		// (set) Token: 0x0602D98A RID: 186762 RVA: 0x00CBEECD File Offset: 0x00CBD0CD
		public int PassWaveCount { get; set; }

		// Token: 0x17005C0F RID: 23567
		// (get) Token: 0x0602D98B RID: 186763 RVA: 0x00CBEED6 File Offset: 0x00CBD0D6
		// (set) Token: 0x0602D98C RID: 186764 RVA: 0x00CBEEDE File Offset: 0x00CBD0DE
		public int CumulativeKills { get; set; }

		// Token: 0x17005C10 RID: 23568
		// (get) Token: 0x0602D98D RID: 186765 RVA: 0x00CBEEE7 File Offset: 0x00CBD0E7
		// (set) Token: 0x0602D98E RID: 186766 RVA: 0x00CBEEEF File Offset: 0x00CBD0EF
		public Dictionary<int, int> PropertyMap { get; set; }

		// Token: 0x17005C11 RID: 23569
		// (get) Token: 0x0602D98F RID: 186767 RVA: 0x00CBEEF8 File Offset: 0x00CBD0F8
		// (set) Token: 0x0602D990 RID: 186768 RVA: 0x00CBEF00 File Offset: 0x00CBD100
		public List<int> UnlockWeapons { get; set; }

		// Token: 0x17005C12 RID: 23570
		// (get) Token: 0x0602D991 RID: 186769 RVA: 0x00CBEF09 File Offset: 0x00CBD109
		// (set) Token: 0x0602D992 RID: 186770 RVA: 0x00CBEF11 File Offset: 0x00CBD111
		public List<int> UnlockItems { get; set; }

		// Token: 0x17005C13 RID: 23571
		// (get) Token: 0x0602D993 RID: 186771 RVA: 0x00CBEF1A File Offset: 0x00CBD11A
		// (set) Token: 0x0602D994 RID: 186772 RVA: 0x00CBEF22 File Offset: 0x00CBD122
		public List<int> UnlockRoles { get; set; }
	}
}
