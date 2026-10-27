using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020056E3 RID: 22243
	public interface IKurotatoWeaponData
	{
		// Token: 0x170087AE RID: 34734
		// (get) Token: 0x06038938 RID: 231736
		// (set) Token: 0x06038939 RID: 231737
		int WeaponId { get; set; }

		// Token: 0x170087AF RID: 34735
		// (get) Token: 0x0603893A RID: 231738
		// (set) Token: 0x0603893B RID: 231739
		int IncId { get; set; }

		// Token: 0x170087B0 RID: 34736
		// (get) Token: 0x0603893C RID: 231740
		// (set) Token: 0x0603893D RID: 231741
		int SellPrice { get; set; }

		// Token: 0x170087B1 RID: 34737
		// (get) Token: 0x0603893E RID: 231742
		// (set) Token: 0x0603893F RID: 231743
		int PreWaveDealtDamage { get; set; }
	}
}
