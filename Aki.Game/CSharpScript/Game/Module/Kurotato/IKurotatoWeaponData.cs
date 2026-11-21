using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046BA RID: 18106
	public interface IKurotatoWeaponData
	{
		// Token: 0x17005B76 RID: 23414
		// (get) Token: 0x0602D848 RID: 186440
		// (set) Token: 0x0602D849 RID: 186441
		int WeaponId { get; set; }

		// Token: 0x17005B77 RID: 23415
		// (get) Token: 0x0602D84A RID: 186442
		// (set) Token: 0x0602D84B RID: 186443
		int IncId { get; set; }

		// Token: 0x17005B78 RID: 23416
		// (get) Token: 0x0602D84C RID: 186444
		// (set) Token: 0x0602D84D RID: 186445
		int SellPrice { get; set; }

		// Token: 0x17005B79 RID: 23417
		// (get) Token: 0x0602D84E RID: 186446
		// (set) Token: 0x0602D84F RID: 186447
		int PreWaveDealtDamage { get; set; }
	}
}
