using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F25 RID: 24357
	public class ISkillDamageT
	{
		// Token: 0x1700B437 RID: 46135
		// (get) Token: 0x06028E50 RID: 167504 RVA: 0x0059675A File Offset: 0x0059495A
		// (set) Token: 0x06028E51 RID: 167505 RVA: 0x00596762 File Offset: 0x00594962
		public int DefaultValue { get; set; }

		// Token: 0x1700B438 RID: 46136
		// (get) Token: 0x06028E52 RID: 167506 RVA: 0x0059676B File Offset: 0x0059496B
		// (set) Token: 0x06028E53 RID: 167507 RVA: 0x00596773 File Offset: 0x00594973
		public int NormalAttack { get; set; }

		// Token: 0x1700B439 RID: 46137
		// (get) Token: 0x06028E54 RID: 167508 RVA: 0x0059677C File Offset: 0x0059497C
		// (set) Token: 0x06028E55 RID: 167509 RVA: 0x00596784 File Offset: 0x00594984
		public int AccumulatorAttack { get; set; }

		// Token: 0x1700B43A RID: 46138
		// (get) Token: 0x06028E56 RID: 167510 RVA: 0x0059678D File Offset: 0x0059498D
		// (set) Token: 0x06028E57 RID: 167511 RVA: 0x00596795 File Offset: 0x00594995
		public int SuperSkill { get; set; }

		// Token: 0x1700B43B RID: 46139
		// (get) Token: 0x06028E58 RID: 167512 RVA: 0x0059679E File Offset: 0x0059499E
		// (set) Token: 0x06028E59 RID: 167513 RVA: 0x005967A6 File Offset: 0x005949A6
		public int QteAttack { get; set; }

		// Token: 0x1700B43C RID: 46140
		// (get) Token: 0x06028E5A RID: 167514 RVA: 0x005967AF File Offset: 0x005949AF
		// (set) Token: 0x06028E5B RID: 167515 RVA: 0x005967B7 File Offset: 0x005949B7
		public int NormalSkill { get; set; }

		// Token: 0x1700B43D RID: 46141
		// (get) Token: 0x06028E5C RID: 167516 RVA: 0x005967C0 File Offset: 0x005949C0
		// (set) Token: 0x06028E5D RID: 167517 RVA: 0x005967C8 File Offset: 0x005949C8
		public int FightVersion { get; set; }

		// Token: 0x1700B43E RID: 46142
		// (get) Token: 0x06028E5E RID: 167518 RVA: 0x005967D1 File Offset: 0x005949D1
		// (set) Token: 0x06028E5F RID: 167519 RVA: 0x005967D9 File Offset: 0x005949D9
		public int ExploreVersion { get; set; }

		// Token: 0x1700B43F RID: 46143
		// (get) Token: 0x06028E60 RID: 167520 RVA: 0x005967E2 File Offset: 0x005949E2
		// (set) Token: 0x06028E61 RID: 167521 RVA: 0x005967EA File Offset: 0x005949EA
		public int GearOrEnvironment { get; set; }

		// Token: 0x1700B440 RID: 46144
		// (get) Token: 0x06028E62 RID: 167522 RVA: 0x005967F3 File Offset: 0x005949F3
		// (set) Token: 0x06028E63 RID: 167523 RVA: 0x005967FB File Offset: 0x005949FB
		public int DamageOverTime { get; set; }

		// Token: 0x1700B441 RID: 46145
		// (get) Token: 0x06028E64 RID: 167524 RVA: 0x00596804 File Offset: 0x00594A04
		// (set) Token: 0x06028E65 RID: 167525 RVA: 0x0059680C File Offset: 0x00594A0C
		public ushort NullMask { get; set; }

		// Token: 0x06028E66 RID: 167526 RVA: 0x00596818 File Offset: 0x00594A18
		public ISkillDamageT()
		{
			this.DefaultValue = 0;
			this.NormalAttack = 0;
			this.AccumulatorAttack = 0;
			this.SuperSkill = 0;
			this.QteAttack = 0;
			this.NormalSkill = 0;
			this.FightVersion = 0;
			this.ExploreVersion = 0;
			this.GearOrEnvironment = 0;
			this.DamageOverTime = 0;
			this.NullMask = 0;
		}
	}
}
