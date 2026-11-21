using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053F8 RID: 21496
	public class IAttributeComponentT
	{
		// Token: 0x17009831 RID: 38961
		// (get) Token: 0x060219C1 RID: 137665 RVA: 0x004A27B3 File Offset: 0x004A09B3
		// (set) Token: 0x060219C2 RID: 137666 RVA: 0x004A27BB File Offset: 0x004A09BB
		public bool Disabled { get; set; }

		// Token: 0x17009832 RID: 38962
		// (get) Token: 0x060219C3 RID: 137667 RVA: 0x004A27C4 File Offset: 0x004A09C4
		// (set) Token: 0x060219C4 RID: 137668 RVA: 0x004A27CC File Offset: 0x004A09CC
		public int PropertyId { get; set; }

		// Token: 0x17009833 RID: 38963
		// (get) Token: 0x060219C5 RID: 137669 RVA: 0x004A27D5 File Offset: 0x004A09D5
		// (set) Token: 0x060219C6 RID: 137670 RVA: 0x004A27DD File Offset: 0x004A09DD
		public int MonsterPropExtraRateId { get; set; }

		// Token: 0x17009834 RID: 38964
		// (get) Token: 0x060219C7 RID: 137671 RVA: 0x004A27E6 File Offset: 0x004A09E6
		// (set) Token: 0x060219C8 RID: 137672 RVA: 0x004A27EE File Offset: 0x004A09EE
		public int MonsterPropGrowthId { get; set; }

		// Token: 0x17009835 RID: 38965
		// (get) Token: 0x060219C9 RID: 137673 RVA: 0x004A27F7 File Offset: 0x004A09F7
		// (set) Token: 0x060219CA RID: 137674 RVA: 0x004A27FF File Offset: 0x004A09FF
		public int Level { get; set; }

		// Token: 0x17009836 RID: 38966
		// (get) Token: 0x060219CB RID: 137675 RVA: 0x004A2808 File Offset: 0x004A0A08
		// (set) Token: 0x060219CC RID: 137676 RVA: 0x004A2810 File Offset: 0x004A0A10
		public int MoraleLevel { get; set; }

		// Token: 0x17009837 RID: 38967
		// (get) Token: 0x060219CD RID: 137677 RVA: 0x004A2819 File Offset: 0x004A0A19
		// (set) Token: 0x060219CE RID: 137678 RVA: 0x004A2821 File Offset: 0x004A0A21
		public int HonamiStoryMonsterGrowth { get; set; }

		// Token: 0x17009838 RID: 38968
		// (get) Token: 0x060219CF RID: 137679 RVA: 0x004A282A File Offset: 0x004A0A2A
		// (set) Token: 0x060219D0 RID: 137680 RVA: 0x004A2832 File Offset: 0x004A0A32
		public int FlagChallengeMonsterLevel { get; set; }

		// Token: 0x17009839 RID: 38969
		// (get) Token: 0x060219D1 RID: 137681 RVA: 0x004A283B File Offset: 0x004A0A3B
		// (set) Token: 0x060219D2 RID: 137682 RVA: 0x004A2843 File Offset: 0x004A0A43
		public int RageModeId { get; set; }

		// Token: 0x1700983A RID: 38970
		// (get) Token: 0x060219D3 RID: 137683 RVA: 0x004A284C File Offset: 0x004A0A4C
		// (set) Token: 0x060219D4 RID: 137684 RVA: 0x004A2854 File Offset: 0x004A0A54
		public int HardnessModeId { get; set; }

		// Token: 0x1700983B RID: 38971
		// (get) Token: 0x060219D5 RID: 137685 RVA: 0x004A285D File Offset: 0x004A0A5D
		// (set) Token: 0x060219D6 RID: 137686 RVA: 0x004A2865 File Offset: 0x004A0A65
		public int WorldLevelBonusId { get; set; }

		// Token: 0x1700983C RID: 38972
		// (get) Token: 0x060219D7 RID: 137687 RVA: 0x004A286E File Offset: 0x004A0A6E
		// (set) Token: 0x060219D8 RID: 137688 RVA: 0x004A2876 File Offset: 0x004A0A76
		public bool IgnoreFightMusic { get; set; }

		// Token: 0x1700983D RID: 38973
		// (get) Token: 0x060219D9 RID: 137689 RVA: 0x004A287F File Offset: 0x004A0A7F
		// (set) Token: 0x060219DA RID: 137690 RVA: 0x004A2887 File Offset: 0x004A0A87
		public IFightMusicsSwitchByTagListT FightMusics { get; set; }

		// Token: 0x1700983E RID: 38974
		// (get) Token: 0x060219DB RID: 137691 RVA: 0x004A2890 File Offset: 0x004A0A90
		// (set) Token: 0x060219DC RID: 137692 RVA: 0x004A2898 File Offset: 0x004A0A98
		public string FightMusic { get; set; }

		// Token: 0x1700983F RID: 38975
		// (get) Token: 0x060219DD RID: 137693 RVA: 0x004A28A1 File Offset: 0x004A0AA1
		// (set) Token: 0x060219DE RID: 137694 RVA: 0x004A28A9 File Offset: 0x004A0AA9
		public bool FightMusicBanRadioMusic { get; set; }

		// Token: 0x17009840 RID: 38976
		// (get) Token: 0x060219DF RID: 137695 RVA: 0x004A28B2 File Offset: 0x004A0AB2
		// (set) Token: 0x060219E0 RID: 137696 RVA: 0x004A28BA File Offset: 0x004A0ABA
		public List<long> AppendBuffIds { get; set; }

		// Token: 0x17009841 RID: 38977
		// (get) Token: 0x060219E1 RID: 137697 RVA: 0x004A28C3 File Offset: 0x004A0AC3
		// (set) Token: 0x060219E2 RID: 137698 RVA: 0x004A28CB File Offset: 0x004A0ACB
		public TWorldLevelBonusUnion WorldLevelBonusType { get; set; }

		// Token: 0x17009842 RID: 38978
		// (get) Token: 0x060219E3 RID: 137699 RVA: 0x004A28D4 File Offset: 0x004A0AD4
		// (set) Token: 0x060219E4 RID: 137700 RVA: 0x004A28DC File Offset: 0x004A0ADC
		public byte NullMask { get; set; }

		// Token: 0x060219E5 RID: 137701 RVA: 0x004A28E8 File Offset: 0x004A0AE8
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
