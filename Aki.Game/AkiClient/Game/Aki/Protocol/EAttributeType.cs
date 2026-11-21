using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Protocol
{
	// Token: 0x02003146 RID: 12614
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Protocol/EAttributeType.EAttributeType")]
	public enum EAttributeType : byte
	{
		// Token: 0x04010882 RID: 67714
		EAttributeType_None,
		// Token: 0x04010883 RID: 67715
		Lv,
		// Token: 0x04010884 RID: 67716
		LifeMax,
		// Token: 0x04010885 RID: 67717
		Life,
		// Token: 0x04010886 RID: 67718
		Sheild,
		// Token: 0x04010887 RID: 67719
		SheildDamageChange,
		// Token: 0x04010888 RID: 67720
		SheildDamageReduce,
		// Token: 0x04010889 RID: 67721
		Atk,
		// Token: 0x0401088A RID: 67722
		Crit,
		// Token: 0x0401088B RID: 67723
		CritDamage,
		// Token: 0x0401088C RID: 67724
		Def,
		// Token: 0x0401088D RID: 67725
		EnergyEfficiency,
		// Token: 0x0401088E RID: 67726
		CDReduse,
		// Token: 0x0401088F RID: 67727
		ReactionEfficiency,
		// Token: 0x04010890 RID: 67728
		DamageChangeNormalSkill,
		// Token: 0x04010891 RID: 67729
		DamageChange,
		// Token: 0x04010892 RID: 67730
		DamageReduce,
		// Token: 0x04010893 RID: 67731
		DamageChangeAuto,
		// Token: 0x04010894 RID: 67732
		DamageChangeCast,
		// Token: 0x04010895 RID: 67733
		DamageChangeUltra,
		// Token: 0x04010896 RID: 67734
		DamageChangeQTE,
		// Token: 0x04010897 RID: 67735
		DamageChangePhys,
		// Token: 0x04010898 RID: 67736
		DamageChangeElement1,
		// Token: 0x04010899 RID: 67737
		DamageChangeElement2,
		// Token: 0x0401089A RID: 67738
		DamageChangeElement3,
		// Token: 0x0401089B RID: 67739
		DamageChangeElement4,
		// Token: 0x0401089C RID: 67740
		DamageChangeElement5,
		// Token: 0x0401089D RID: 67741
		DamageChangeElement6,
		// Token: 0x0401089E RID: 67742
		DamageResistancePhys,
		// Token: 0x0401089F RID: 67743
		DamageResistanceElement1,
		// Token: 0x040108A0 RID: 67744
		DamageResistanceElement2,
		// Token: 0x040108A1 RID: 67745
		DamageResistanceElement3,
		// Token: 0x040108A2 RID: 67746
		DamageResistanceElement4,
		// Token: 0x040108A3 RID: 67747
		DamageResistanceElement5,
		// Token: 0x040108A4 RID: 67748
		DamageResistanceElement6,
		// Token: 0x040108A5 RID: 67749
		HealChange,
		// Token: 0x040108A6 RID: 67750
		HealedChange,
		// Token: 0x040108A7 RID: 67751
		DamageReducePhys,
		// Token: 0x040108A8 RID: 67752
		DamageReduceElement1,
		// Token: 0x040108A9 RID: 67753
		DamageReduceElement2,
		// Token: 0x040108AA RID: 67754
		DamageReduceElement3,
		// Token: 0x040108AB RID: 67755
		DamageReduceElement4,
		// Token: 0x040108AC RID: 67756
		DamageReduceElement5,
		// Token: 0x040108AD RID: 67757
		DamageReduceElement6,
		// Token: 0x040108AE RID: 67758
		ReactionChange1,
		// Token: 0x040108AF RID: 67759
		ReactionChange2,
		// Token: 0x040108B0 RID: 67760
		ReactionChange3,
		// Token: 0x040108B1 RID: 67761
		ReactionChange4,
		// Token: 0x040108B2 RID: 67762
		ReactionChange5,
		// Token: 0x040108B3 RID: 67763
		ReactionChange6,
		// Token: 0x040108B4 RID: 67764
		ReactionChange7,
		// Token: 0x040108B5 RID: 67765
		ReactionChange8,
		// Token: 0x040108B6 RID: 67766
		ReactionChange9,
		// Token: 0x040108B7 RID: 67767
		ReactionChange10,
		// Token: 0x040108B8 RID: 67768
		ReactionChange11,
		// Token: 0x040108B9 RID: 67769
		ReactionChange12,
		// Token: 0x040108BA RID: 67770
		ReactionChange13,
		// Token: 0x040108BB RID: 67771
		ReactionChange14,
		// Token: 0x040108BC RID: 67772
		ReactionChange15,
		// Token: 0x040108BD RID: 67773
		EnergyMax,
		// Token: 0x040108BE RID: 67774
		Energy,
		// Token: 0x040108BF RID: 67775
		SpecialEnergy1Max,
		// Token: 0x040108C0 RID: 67776
		SpecialEnergy1,
		// Token: 0x040108C1 RID: 67777
		SpecialEnergy2Max,
		// Token: 0x040108C2 RID: 67778
		SpecialEnergy2,
		// Token: 0x040108C3 RID: 67779
		SpecialEnergy3Max,
		// Token: 0x040108C4 RID: 67780
		SpecialEnergy3,
		// Token: 0x040108C5 RID: 67781
		SpecialEnergy4Max,
		// Token: 0x040108C6 RID: 67782
		SpecialEnergy4,
		// Token: 0x040108C7 RID: 67783
		StrengthMax,
		// Token: 0x040108C8 RID: 67784
		Strength,
		// Token: 0x040108C9 RID: 67785
		StrengthRecover,
		// Token: 0x040108CA RID: 67786
		StrengthPunishTime,
		// Token: 0x040108CB RID: 67787
		StrengthRun,
		// Token: 0x040108CC RID: 67788
		StrengthSwim,
		// Token: 0x040108CD RID: 67789
		StrengthFastSwim,
		// Token: 0x040108CE RID: 67790
		StrengthClimb,
		// Token: 0x040108CF RID: 67791
		StrengthFastClimb,
		// Token: 0x040108D0 RID: 67792
		HardnessMax,
		// Token: 0x040108D1 RID: 67793
		Hardness,
		// Token: 0x040108D2 RID: 67794
		HardnessRecover,
		// Token: 0x040108D3 RID: 67795
		HardnessPunishTime,
		// Token: 0x040108D4 RID: 67796
		HardnessChange,
		// Token: 0x040108D5 RID: 67797
		HardnessReduce,
		// Token: 0x040108D6 RID: 67798
		ToughMax,
		// Token: 0x040108D7 RID: 67799
		Tough,
		// Token: 0x040108D8 RID: 67800
		ToughRecover,
		// Token: 0x040108D9 RID: 67801
		ToughChange,
		// Token: 0x040108DA RID: 67802
		ToughReduce,
		// Token: 0x040108DB RID: 67803
		ElementPower1,
		// Token: 0x040108DC RID: 67804
		ElementPower2,
		// Token: 0x040108DD RID: 67805
		ElementPower3,
		// Token: 0x040108DE RID: 67806
		ElementPower4,
		// Token: 0x040108DF RID: 67807
		ElementPower5,
		// Token: 0x040108E0 RID: 67808
		ElementPower6,
		// Token: 0x040108E1 RID: 67809
		SpecialDamageChange,
		// Token: 0x040108E2 RID: 67810
		StrengthFastClimbCost,
		// Token: 0x040108E3 RID: 67811
		ElementPropertyType,
		// Token: 0x040108E4 RID: 67812
		WeakTime,
		// Token: 0x040108E5 RID: 67813
		IgnoreDefRate,
		// Token: 0x040108E6 RID: 67814
		IgnoreDamageResistancePhys,
		// Token: 0x040108E7 RID: 67815
		IgnoreDamageResistanceElement1,
		// Token: 0x040108E8 RID: 67816
		IgnoreDamageResistanceElement2,
		// Token: 0x040108E9 RID: 67817
		IgnoreDamageResistanceElement3,
		// Token: 0x040108EA RID: 67818
		IgnoreDamageResistanceElement4,
		// Token: 0x040108EB RID: 67819
		IgnoreDamageResistanceElement5,
		// Token: 0x040108EC RID: 67820
		IgnoreDamageResistanceElement6,
		// Token: 0x040108ED RID: 67821
		SkillToughRatio,
		// Token: 0x040108EE RID: 67822
		StrengthClimbJump,
		// Token: 0x040108EF RID: 67823
		StrengthGliding,
		// Token: 0x040108F0 RID: 67824
		Mass,
		// Token: 0x040108F1 RID: 67825
		BrakingFrictionFactor,
		// Token: 0x040108F2 RID: 67826
		GravityScale,
		// Token: 0x040108F3 RID: 67827
		SpeedRatio,
		// Token: 0x040108F4 RID: 67828
		DamageChangePhantom,
		// Token: 0x040108F5 RID: 67829
		AutoAttackSpeed,
		// Token: 0x040108F6 RID: 67830
		CastAttackSpeed,
		// Token: 0x040108F7 RID: 67831
		StatusBuildUp1Max,
		// Token: 0x040108F8 RID: 67832
		StatusBuildUp1,
		// Token: 0x040108F9 RID: 67833
		StatusBuildUp2Max,
		// Token: 0x040108FA RID: 67834
		StatusBuildUp2,
		// Token: 0x040108FB RID: 67835
		StatusBuildUp3Max,
		// Token: 0x040108FC RID: 67836
		StatusBuildUp3,
		// Token: 0x040108FD RID: 67837
		StatusBuildUp4Max,
		// Token: 0x040108FE RID: 67838
		StatusBuildUp4,
		// Token: 0x040108FF RID: 67839
		StatusBuildUp5Max,
		// Token: 0x04010900 RID: 67840
		StatusBuildUp5,
		// Token: 0x04010901 RID: 67841
		RageMax,
		// Token: 0x04010902 RID: 67842
		Rage,
		// Token: 0x04010903 RID: 67843
		RageRecover,
		// Token: 0x04010904 RID: 67844
		RagePunishTime,
		// Token: 0x04010905 RID: 67845
		RageChange,
		// Token: 0x04010906 RID: 67846
		RageReduce,
		// Token: 0x04010907 RID: 67847
		ToughRecoverDelayTime,
		// Token: 0x04010908 RID: 67848
		Jump,
		// Token: 0x04010909 RID: 67849
		ParalysisTimeMax,
		// Token: 0x0401090A RID: 67850
		ParalysisTime,
		// Token: 0x0401090B RID: 67851
		ParalysisTimeRecover,
		// Token: 0x0401090C RID: 67852
		WeaknessBuildUp,
		// Token: 0x0401090D RID: 67853
		WeaknessBuildUpMax,
		// Token: 0x0401090E RID: 67854
		WeaknessTotalBonus,
		// Token: 0x0401090F RID: 67855
		BreakWeaknessRatio,
		// Token: 0x04010910 RID: 67856
		WeaknessMastery,
		// Token: 0x04010911 RID: 67857
		EAttributeType_MAX
	}
}
