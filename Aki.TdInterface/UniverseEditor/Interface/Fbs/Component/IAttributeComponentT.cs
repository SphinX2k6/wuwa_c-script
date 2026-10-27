using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EC9 RID: 20169
	public class IAttributeComponentT
	{
		// Token: 0x170090BE RID: 37054
		// (get) Token: 0x0601FC7D RID: 130173 RVA: 0x0046C9E3 File Offset: 0x0046ABE3
		// (set) Token: 0x0601FC7E RID: 130174 RVA: 0x0046C9EB File Offset: 0x0046ABEB
		public bool Disabled { get; set; }

		// Token: 0x170090BF RID: 37055
		// (get) Token: 0x0601FC7F RID: 130175 RVA: 0x0046C9F4 File Offset: 0x0046ABF4
		// (set) Token: 0x0601FC80 RID: 130176 RVA: 0x0046C9FC File Offset: 0x0046ABFC
		public int PropertyId { get; set; }

		// Token: 0x170090C0 RID: 37056
		// (get) Token: 0x0601FC81 RID: 130177 RVA: 0x0046CA05 File Offset: 0x0046AC05
		// (set) Token: 0x0601FC82 RID: 130178 RVA: 0x0046CA0D File Offset: 0x0046AC0D
		public int MonsterPropExtraRateId { get; set; }

		// Token: 0x170090C1 RID: 37057
		// (get) Token: 0x0601FC83 RID: 130179 RVA: 0x0046CA16 File Offset: 0x0046AC16
		// (set) Token: 0x0601FC84 RID: 130180 RVA: 0x0046CA1E File Offset: 0x0046AC1E
		public int MonsterPropGrowthId { get; set; }

		// Token: 0x170090C2 RID: 37058
		// (get) Token: 0x0601FC85 RID: 130181 RVA: 0x0046CA27 File Offset: 0x0046AC27
		// (set) Token: 0x0601FC86 RID: 130182 RVA: 0x0046CA2F File Offset: 0x0046AC2F
		public int Level { get; set; }

		// Token: 0x170090C3 RID: 37059
		// (get) Token: 0x0601FC87 RID: 130183 RVA: 0x0046CA38 File Offset: 0x0046AC38
		// (set) Token: 0x0601FC88 RID: 130184 RVA: 0x0046CA40 File Offset: 0x0046AC40
		public int MoraleLevel { get; set; }

		// Token: 0x170090C4 RID: 37060
		// (get) Token: 0x0601FC89 RID: 130185 RVA: 0x0046CA49 File Offset: 0x0046AC49
		// (set) Token: 0x0601FC8A RID: 130186 RVA: 0x0046CA51 File Offset: 0x0046AC51
		public int HonamiStoryMonsterGrowth { get; set; }

		// Token: 0x170090C5 RID: 37061
		// (get) Token: 0x0601FC8B RID: 130187 RVA: 0x0046CA5A File Offset: 0x0046AC5A
		// (set) Token: 0x0601FC8C RID: 130188 RVA: 0x0046CA62 File Offset: 0x0046AC62
		public int FlagChallengeMonsterLevel { get; set; }

		// Token: 0x170090C6 RID: 37062
		// (get) Token: 0x0601FC8D RID: 130189 RVA: 0x0046CA6B File Offset: 0x0046AC6B
		// (set) Token: 0x0601FC8E RID: 130190 RVA: 0x0046CA73 File Offset: 0x0046AC73
		public int RageModeId { get; set; }

		// Token: 0x170090C7 RID: 37063
		// (get) Token: 0x0601FC8F RID: 130191 RVA: 0x0046CA7C File Offset: 0x0046AC7C
		// (set) Token: 0x0601FC90 RID: 130192 RVA: 0x0046CA84 File Offset: 0x0046AC84
		public int HardnessModeId { get; set; }

		// Token: 0x170090C8 RID: 37064
		// (get) Token: 0x0601FC91 RID: 130193 RVA: 0x0046CA8D File Offset: 0x0046AC8D
		// (set) Token: 0x0601FC92 RID: 130194 RVA: 0x0046CA95 File Offset: 0x0046AC95
		public int WorldLevelBonusId { get; set; }

		// Token: 0x170090C9 RID: 37065
		// (get) Token: 0x0601FC93 RID: 130195 RVA: 0x0046CA9E File Offset: 0x0046AC9E
		// (set) Token: 0x0601FC94 RID: 130196 RVA: 0x0046CAA6 File Offset: 0x0046ACA6
		public bool IgnoreFightMusic { get; set; }

		// Token: 0x170090CA RID: 37066
		// (get) Token: 0x0601FC95 RID: 130197 RVA: 0x0046CAAF File Offset: 0x0046ACAF
		// (set) Token: 0x0601FC96 RID: 130198 RVA: 0x0046CAB7 File Offset: 0x0046ACB7
		public IFightMusicsSwitchByTagListT FightMusics { get; set; }

		// Token: 0x170090CB RID: 37067
		// (get) Token: 0x0601FC97 RID: 130199 RVA: 0x0046CAC0 File Offset: 0x0046ACC0
		// (set) Token: 0x0601FC98 RID: 130200 RVA: 0x0046CAC8 File Offset: 0x0046ACC8
		public string FightMusic { get; set; }

		// Token: 0x170090CC RID: 37068
		// (get) Token: 0x0601FC99 RID: 130201 RVA: 0x0046CAD1 File Offset: 0x0046ACD1
		// (set) Token: 0x0601FC9A RID: 130202 RVA: 0x0046CAD9 File Offset: 0x0046ACD9
		public bool FightMusicBanRadioMusic { get; set; }

		// Token: 0x170090CD RID: 37069
		// (get) Token: 0x0601FC9B RID: 130203 RVA: 0x0046CAE2 File Offset: 0x0046ACE2
		// (set) Token: 0x0601FC9C RID: 130204 RVA: 0x0046CAEA File Offset: 0x0046ACEA
		public List<long> AppendBuffIds { get; set; }

		// Token: 0x170090CE RID: 37070
		// (get) Token: 0x0601FC9D RID: 130205 RVA: 0x0046CAF3 File Offset: 0x0046ACF3
		// (set) Token: 0x0601FC9E RID: 130206 RVA: 0x0046CAFB File Offset: 0x0046ACFB
		public TWorldLevelBonusUnion WorldLevelBonusType { get; set; }

		// Token: 0x170090CF RID: 37071
		// (get) Token: 0x0601FC9F RID: 130207 RVA: 0x0046CB04 File Offset: 0x0046AD04
		// (set) Token: 0x0601FCA0 RID: 130208 RVA: 0x0046CB0C File Offset: 0x0046AD0C
		public byte NullMask { get; set; }

		// Token: 0x0601FCA1 RID: 130209 RVA: 0x0046CB18 File Offset: 0x0046AD18
		public IAttributeComponentT()
		{
			this.Disabled = false;
			this.PropertyId = 0;
			this.MonsterPropExtraRateId = 0;
			this.MonsterPropGrowthId = 0;
			this.Level = 0;
			this.MoraleLevel = 0;
			this.HonamiStoryMonsterGrowth = 0;
			this.FlagChallengeMonsterLevel = 0;
			this.RageModeId = 0;
			this.HardnessModeId = 0;
			this.WorldLevelBonusId = 0;
			this.IgnoreFightMusic = false;
			this.FightMusics = null;
			this.FightMusic = null;
			this.FightMusicBanRadioMusic = false;
			this.AppendBuffIds = null;
			this.WorldLevelBonusType = null;
			this.NullMask = 0;
		}
	}
}
