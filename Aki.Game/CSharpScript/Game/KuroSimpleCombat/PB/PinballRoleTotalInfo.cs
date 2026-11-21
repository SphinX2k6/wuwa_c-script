using System;

namespace CSharpScript.Game.KuroSimpleCombat.PB
{
	// Token: 0x02006144 RID: 24900
	public class PinballRoleTotalInfo : IPinballRoleTotalInfo
	{
		// Token: 0x170070C8 RID: 28872
		// (get) Token: 0x0603BAA9 RID: 244393 RVA: 0x010EE1B4 File Offset: 0x010EC3B4
		// (set) Token: 0x0603BAAA RID: 244394 RVA: 0x010EE1BC File Offset: 0x010EC3BC
		public float Damage { get; set; }

		// Token: 0x170070C9 RID: 28873
		// (get) Token: 0x0603BAAB RID: 244395 RVA: 0x010EE1C5 File Offset: 0x010EC3C5
		// (set) Token: 0x0603BAAC RID: 244396 RVA: 0x010EE1CD File Offset: 0x010EC3CD
		public int SkillTimes { get; set; }

		// Token: 0x170070CA RID: 28874
		// (get) Token: 0x0603BAAD RID: 244397 RVA: 0x010EE1D6 File Offset: 0x010EC3D6
		// (set) Token: 0x0603BAAE RID: 244398 RVA: 0x010EE1DE File Offset: 0x010EC3DE
		public float DropCostHp { get; set; }

		// Token: 0x170070CB RID: 28875
		// (get) Token: 0x0603BAAF RID: 244399 RVA: 0x010EE1E7 File Offset: 0x010EC3E7
		// (set) Token: 0x0603BAB0 RID: 244400 RVA: 0x010EE1EF File Offset: 0x010EC3EF
		public float HitCostHp { get; set; }

		// Token: 0x170070CC RID: 28876
		// (get) Token: 0x0603BAB1 RID: 244401 RVA: 0x010EE1F8 File Offset: 0x010EC3F8
		// (set) Token: 0x0603BAB2 RID: 244402 RVA: 0x010EE200 File Offset: 0x010EC400
		public int DieTimes { get; set; }

		// Token: 0x170070CD RID: 28877
		// (get) Token: 0x0603BAB3 RID: 244403 RVA: 0x010EE209 File Offset: 0x010EC409
		// (set) Token: 0x0603BAB4 RID: 244404 RVA: 0x010EE211 File Offset: 0x010EC411
		public int ReviveTimes { get; set; }
	}
}
