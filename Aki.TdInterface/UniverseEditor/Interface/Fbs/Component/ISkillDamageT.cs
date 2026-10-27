using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005918 RID: 22808
	public class ISkillDamageT
	{
		// Token: 0x1700AB03 RID: 43779
		// (get) Token: 0x060268E6 RID: 157926 RVA: 0x0054FAEE File Offset: 0x0054DCEE
		// (set) Token: 0x060268E7 RID: 157927 RVA: 0x0054FAF6 File Offset: 0x0054DCF6
		public int DefaultValue { get; set; }

		// Token: 0x1700AB04 RID: 43780
		// (get) Token: 0x060268E8 RID: 157928 RVA: 0x0054FAFF File Offset: 0x0054DCFF
		// (set) Token: 0x060268E9 RID: 157929 RVA: 0x0054FB07 File Offset: 0x0054DD07
		public int NormalAttack { get; set; }

		// Token: 0x1700AB05 RID: 43781
		// (get) Token: 0x060268EA RID: 157930 RVA: 0x0054FB10 File Offset: 0x0054DD10
		// (set) Token: 0x060268EB RID: 157931 RVA: 0x0054FB18 File Offset: 0x0054DD18
		public int AccumulatorAttack { get; set; }

		// Token: 0x1700AB06 RID: 43782
		// (get) Token: 0x060268EC RID: 157932 RVA: 0x0054FB21 File Offset: 0x0054DD21
		// (set) Token: 0x060268ED RID: 157933 RVA: 0x0054FB29 File Offset: 0x0054DD29
		public int SuperSkill { get; set; }

		// Token: 0x1700AB07 RID: 43783
		// (get) Token: 0x060268EE RID: 157934 RVA: 0x0054FB32 File Offset: 0x0054DD32
		// (set) Token: 0x060268EF RID: 157935 RVA: 0x0054FB3A File Offset: 0x0054DD3A
		public int QteAttack { get; set; }

		// Token: 0x1700AB08 RID: 43784
		// (get) Token: 0x060268F0 RID: 157936 RVA: 0x0054FB43 File Offset: 0x0054DD43
		// (set) Token: 0x060268F1 RID: 157937 RVA: 0x0054FB4B File Offset: 0x0054DD4B
		public int NormalSkill { get; set; }

		// Token: 0x1700AB09 RID: 43785
		// (get) Token: 0x060268F2 RID: 157938 RVA: 0x0054FB54 File Offset: 0x0054DD54
		// (set) Token: 0x060268F3 RID: 157939 RVA: 0x0054FB5C File Offset: 0x0054DD5C
		public int FightVersion { get; set; }

		// Token: 0x1700AB0A RID: 43786
		// (get) Token: 0x060268F4 RID: 157940 RVA: 0x0054FB65 File Offset: 0x0054DD65
		// (set) Token: 0x060268F5 RID: 157941 RVA: 0x0054FB6D File Offset: 0x0054DD6D
		public int ExploreVersion { get; set; }

		// Token: 0x1700AB0B RID: 43787
		// (get) Token: 0x060268F6 RID: 157942 RVA: 0x0054FB76 File Offset: 0x0054DD76
		// (set) Token: 0x060268F7 RID: 157943 RVA: 0x0054FB7E File Offset: 0x0054DD7E
		public int GearOrEnvironment { get; set; }

		// Token: 0x1700AB0C RID: 43788
		// (get) Token: 0x060268F8 RID: 157944 RVA: 0x0054FB87 File Offset: 0x0054DD87
		// (set) Token: 0x060268F9 RID: 157945 RVA: 0x0054FB8F File Offset: 0x0054DD8F
		public int DamageOverTime { get; set; }

		// Token: 0x1700AB0D RID: 43789
		// (get) Token: 0x060268FA RID: 157946 RVA: 0x0054FB98 File Offset: 0x0054DD98
		// (set) Token: 0x060268FB RID: 157947 RVA: 0x0054FBA0 File Offset: 0x0054DDA0
		public ushort NullMask { get; set; }

		// Token: 0x060268FC RID: 157948 RVA: 0x0054FBAC File Offset: 0x0054DDAC
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
