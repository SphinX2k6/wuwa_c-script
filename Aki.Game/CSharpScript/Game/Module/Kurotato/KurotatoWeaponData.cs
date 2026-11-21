using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046BB RID: 18107
	public class KurotatoWeaponData : IKurotatoWeaponData
	{
		// Token: 0x17005B7A RID: 23418
		// (get) Token: 0x0602D850 RID: 186448 RVA: 0x00CBE964 File Offset: 0x00CBCB64
		// (set) Token: 0x0602D851 RID: 186449 RVA: 0x00CBE96C File Offset: 0x00CBCB6C
		public int WeaponId { get; set; }

		// Token: 0x17005B7B RID: 23419
		// (get) Token: 0x0602D852 RID: 186450 RVA: 0x00CBE975 File Offset: 0x00CBCB75
		// (set) Token: 0x0602D853 RID: 186451 RVA: 0x00CBE97D File Offset: 0x00CBCB7D
		public int IncId { get; set; }

		// Token: 0x17005B7C RID: 23420
		// (get) Token: 0x0602D854 RID: 186452 RVA: 0x00CBE986 File Offset: 0x00CBCB86
		// (set) Token: 0x0602D855 RID: 186453 RVA: 0x00CBE98E File Offset: 0x00CBCB8E
		public int SellPrice { get; set; }

		// Token: 0x17005B7D RID: 23421
		// (get) Token: 0x0602D856 RID: 186454 RVA: 0x00CBE997 File Offset: 0x00CBCB97
		// (set) Token: 0x0602D857 RID: 186455 RVA: 0x00CBE99F File Offset: 0x00CBCB9F
		public int PreWaveDealtDamage { get; set; }
	}
}
