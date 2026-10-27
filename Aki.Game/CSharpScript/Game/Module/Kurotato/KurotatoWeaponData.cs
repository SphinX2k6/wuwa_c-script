using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056E4 RID: 22244
	public class KurotatoWeaponData : IKurotatoWeaponData
	{
		// Token: 0x170087B2 RID: 34738
		// (get) Token: 0x06038940 RID: 231744 RVA: 0x00D7037C File Offset: 0x00D6E57C
		// (set) Token: 0x06038941 RID: 231745 RVA: 0x00D70384 File Offset: 0x00D6E584
		public int WeaponId { get; set; }

		// Token: 0x170087B3 RID: 34739
		// (get) Token: 0x06038942 RID: 231746 RVA: 0x00D7038D File Offset: 0x00D6E58D
		// (set) Token: 0x06038943 RID: 231747 RVA: 0x00D70395 File Offset: 0x00D6E595
		public int IncId { get; set; }

		// Token: 0x170087B4 RID: 34740
		// (get) Token: 0x06038944 RID: 231748 RVA: 0x00D7039E File Offset: 0x00D6E59E
		// (set) Token: 0x06038945 RID: 231749 RVA: 0x00D703A6 File Offset: 0x00D6E5A6
		public int SellPrice { get; set; }

		// Token: 0x170087B5 RID: 34741
		// (get) Token: 0x06038946 RID: 231750 RVA: 0x00D703AF File Offset: 0x00D6E5AF
		// (set) Token: 0x06038947 RID: 231751 RVA: 0x00D703B7 File Offset: 0x00D6E5B7
		public int PreWaveDealtDamage { get; set; }
	}
}
