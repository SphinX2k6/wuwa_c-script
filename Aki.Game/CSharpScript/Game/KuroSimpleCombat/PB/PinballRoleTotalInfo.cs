using System;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006FC3 RID: 28611
	public class PinballRoleTotalInfo : IPinballRoleTotalInfo
	{
		// Token: 0x17009B88 RID: 39816
		// (get) Token: 0x060458F9 RID: 284921 RVA: 0x011443DC File Offset: 0x011425DC
		// (set) Token: 0x060458FA RID: 284922 RVA: 0x011443E4 File Offset: 0x011425E4
		public float Damage { get; set; }

		// Token: 0x17009B89 RID: 39817
		// (get) Token: 0x060458FB RID: 284923 RVA: 0x011443ED File Offset: 0x011425ED
		// (set) Token: 0x060458FC RID: 284924 RVA: 0x011443F5 File Offset: 0x011425F5
		public int SkillTimes { get; set; }

		// Token: 0x17009B8A RID: 39818
		// (get) Token: 0x060458FD RID: 284925 RVA: 0x011443FE File Offset: 0x011425FE
		// (set) Token: 0x060458FE RID: 284926 RVA: 0x01144406 File Offset: 0x01142606
		public float DropCostHp { get; set; }

		// Token: 0x17009B8B RID: 39819
		// (get) Token: 0x060458FF RID: 284927 RVA: 0x0114440F File Offset: 0x0114260F
		// (set) Token: 0x06045900 RID: 284928 RVA: 0x01144417 File Offset: 0x01142617
		public float HitCostHp { get; set; }

		// Token: 0x17009B8C RID: 39820
		// (get) Token: 0x06045901 RID: 284929 RVA: 0x01144420 File Offset: 0x01142620
		// (set) Token: 0x06045902 RID: 284930 RVA: 0x01144428 File Offset: 0x01142628
		public int DieTimes { get; set; }

		// Token: 0x17009B8D RID: 39821
		// (get) Token: 0x06045903 RID: 284931 RVA: 0x01144431 File Offset: 0x01142631
		// (set) Token: 0x06045904 RID: 284932 RVA: 0x01144439 File Offset: 0x01142639
		public int ReviveTimes { get; set; }
	}
}
