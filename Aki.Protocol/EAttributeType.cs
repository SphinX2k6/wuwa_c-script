using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200157F RID: 5503
	public enum EAttributeType
	{
		// Token: 0x0400A6D6 RID: 42710
		[OriginalName("EAttributeType_None")]
		None,
		// Token: 0x0400A6D7 RID: 42711
		[OriginalName("Lv")]
		Lv,
		// Token: 0x0400A6D8 RID: 42712
		[OriginalName("LifeMax")]
		LifeMax,
		// Token: 0x0400A6D9 RID: 42713
		[OriginalName("Life")]
		Life,
		// Token: 0x0400A6DA RID: 42714
		[OriginalName("Sheild")]
		Sheild,
		// Token: 0x0400A6DB RID: 42715
		[OriginalName("SheildDamageChange")]
		SheildDamageChange,
		// Token: 0x0400A6DC RID: 42716
		[OriginalName("SheildDamageReduce")]
		SheildDamageReduce,
		// Token: 0x0400A6DD RID: 42717
		[OriginalName("Atk")]
		Atk,
		// Token: 0x0400A6DE RID: 42718
		[OriginalName("Crit")]
		Crit,
		// Token: 0x0400A6DF RID: 42719
		[OriginalName("CritDamage")]
		CritDamage,
		// Token: 0x0400A6E0 RID: 42720
		[OriginalName("Def")]
		Def,
		// Token: 0x0400A6E1 RID: 42721
		[OriginalName("EnergyEfficiency")]
		EnergyEfficiency,
		// Token: 0x0400A6E2 RID: 42722
		[OriginalName("CdReduse")]
		CdReduse,
		// Token: 0x0400A6E3 RID: 42723
		[OriginalName("ElementEfficiency")]
		ElementEfficiency,
		// Token: 0x0400A6E4 RID: 42724
		[OriginalName("DamageChangeNormalSkill")]
		DamageChangeNormalSkill,
		// Token: 0x0400A6E5 RID: 42725
		[OriginalName("DamageChange")]
		DamageChange,
		// Token: 0x0400A6E6 RID: 42726
		[OriginalName("DamageReduce")]
		DamageReduce,
		// Token: 0x0400A6E7 RID: 42727
		[OriginalName("DamageChangeAuto")]
		DamageChangeAuto,
		// Token: 0x0400A6E8 RID: 42728
		[OriginalName("DamageChangeCast")]
		DamageChangeCast,
		// Token: 0x0400A6E9 RID: 42729
		[OriginalName("DamageChangeUltra")]
		DamageChangeUltra,
		// Token: 0x0400A6EA RID: 42730
		[OriginalName("DamageChangeQte")]
		DamageChangeQte,
		// Token: 0x0400A6EB RID: 42731
		[OriginalName("DamageChangePhys")]
		DamageChangePhys,
		// Token: 0x0400A6EC RID: 42732
		[OriginalName("DamageChangeElement1")]
		DamageChangeElement1,
		// Token: 0x0400A6ED RID: 42733
		[OriginalName("DamageChangeElement2")]
		DamageChangeElement2,
		// Token: 0x0400A6EE RID: 42734
		[OriginalName("DamageChangeElement3")]
		DamageChangeElement3,
		// Token: 0x0400A6EF RID: 42735
		[OriginalName("DamageChangeElement4")]
		DamageChangeElement4,
		// Token: 0x0400A6F0 RID: 42736
		[OriginalName("DamageChangeElement5")]
		DamageChangeElement5,
		// Token: 0x0400A6F1 RID: 42737
		[OriginalName("DamageChangeElement6")]
		DamageChangeElement6,
		// Token: 0x0400A6F2 RID: 42738
		[OriginalName("DamageResistancePhys")]
		DamageResistancePhys,
		// Token: 0x0400A6F3 RID: 42739
		[OriginalName("DamageResistanceElement1")]
		DamageResistanceElement1,
		// Token: 0x0400A6F4 RID: 42740
		[OriginalName("DamageResistanceElement2")]
		DamageResistanceElement2,
		// Token: 0x0400A6F5 RID: 42741
		[OriginalName("DamageResistanceElement3")]
		DamageResistanceElement3,
		// Token: 0x0400A6F6 RID: 42742
		[OriginalName("DamageResistanceElement4")]
		DamageResistanceElement4,
		// Token: 0x0400A6F7 RID: 42743
		[OriginalName("DamageResistanceElement5")]
		DamageResistanceElement5,
		// Token: 0x0400A6F8 RID: 42744
		[OriginalName("DamageResistanceElement6")]
		DamageResistanceElement6,
		// Token: 0x0400A6F9 RID: 42745
		[OriginalName("HealChange")]
		HealChange,
		// Token: 0x0400A6FA RID: 42746
		[OriginalName("HealedChange")]
		HealedChange,
		// Token: 0x0400A6FB RID: 42747
		[OriginalName("DamageReducePhys")]
		DamageReducePhys,
		// Token: 0x0400A6FC RID: 42748
		[OriginalName("DamageReduceElement1")]
		DamageReduceElement1,
		// Token: 0x0400A6FD RID: 42749
		[OriginalName("DamageReduceElement2")]
		DamageReduceElement2,
		// Token: 0x0400A6FE RID: 42750
		[OriginalName("DamageReduceElement3")]
		DamageReduceElement3,
		// Token: 0x0400A6FF RID: 42751
		[OriginalName("DamageReduceElement4")]
		DamageReduceElement4,
		// Token: 0x0400A700 RID: 42752
		[OriginalName("DamageReduceElement5")]
		DamageReduceElement5,
		// Token: 0x0400A701 RID: 42753
		[OriginalName("DamageReduceElement6")]
		DamageReduceElement6,
		// Token: 0x0400A702 RID: 42754
		[OriginalName("SpecialEnergy5Max")]
		SpecialEnergy5Max,
		// Token: 0x0400A703 RID: 42755
		[OriginalName("SpecialEnergy5")]
		SpecialEnergy5,
		// Token: 0x0400A704 RID: 42756
		[OriginalName("ReactionChange3")]
		ReactionChange3,
		// Token: 0x0400A705 RID: 42757
		[OriginalName("ReactionChange4")]
		ReactionChange4,
		// Token: 0x0400A706 RID: 42758
		[OriginalName("ReactionChange5")]
		ReactionChange5,
		// Token: 0x0400A707 RID: 42759
		[OriginalName("ReactionChange6")]
		ReactionChange6,
		// Token: 0x0400A708 RID: 42760
		[OriginalName("ReactionChange7")]
		ReactionChange7,
		// Token: 0x0400A709 RID: 42761
		[OriginalName("ReactionChange8")]
		ReactionChange8,
		// Token: 0x0400A70A RID: 42762
		[OriginalName("ReactionChange9")]
		ReactionChange9,
		// Token: 0x0400A70B RID: 42763
		[OriginalName("ReactionChange10")]
		ReactionChange10,
		// Token: 0x0400A70C RID: 42764
		[OriginalName("ReactionChange11")]
		ReactionChange11,
		// Token: 0x0400A70D RID: 42765
		[OriginalName("ReactionChange12")]
		ReactionChange12,
		// Token: 0x0400A70E RID: 42766
		[OriginalName("ReactionChange13")]
		ReactionChange13,
		// Token: 0x0400A70F RID: 42767
		[OriginalName("ReactionChange14")]
		ReactionChange14,
		// Token: 0x0400A710 RID: 42768
		[OriginalName("ReactionChange15")]
		ReactionChange15,
		// Token: 0x0400A711 RID: 42769
		[OriginalName("EnergyMax")]
		EnergyMax,
		// Token: 0x0400A712 RID: 42770
		[OriginalName("Energy")]
		Energy,
		// Token: 0x0400A713 RID: 42771
		[OriginalName("SpecialEnergy1Max")]
		SpecialEnergy1Max,
		// Token: 0x0400A714 RID: 42772
		[OriginalName("SpecialEnergy1")]
		SpecialEnergy1,
		// Token: 0x0400A715 RID: 42773
		[OriginalName("SpecialEnergy2Max")]
		SpecialEnergy2Max,
		// Token: 0x0400A716 RID: 42774
		[OriginalName("SpecialEnergy2")]
		SpecialEnergy2,
		// Token: 0x0400A717 RID: 42775
		[OriginalName("SpecialEnergy3Max")]
		SpecialEnergy3Max,
		// Token: 0x0400A718 RID: 42776
		[OriginalName("SpecialEnergy3")]
		SpecialEnergy3,
		// Token: 0x0400A719 RID: 42777
		[OriginalName("SpecialEnergy4Max")]
		SpecialEnergy4Max,
		// Token: 0x0400A71A RID: 42778
		[OriginalName("SpecialEnergy4")]
		SpecialEnergy4,
		// Token: 0x0400A71B RID: 42779
		[OriginalName("StrengthMax")]
		StrengthMax,
		// Token: 0x0400A71C RID: 42780
		[OriginalName("Strength")]
		Strength,
		// Token: 0x0400A71D RID: 42781
		[OriginalName("StrengthRecover")]
		StrengthRecover,
		// Token: 0x0400A71E RID: 42782
		[OriginalName("StrengthPunishTime")]
		StrengthPunishTime,
		// Token: 0x0400A71F RID: 42783
		[OriginalName("StrengthRun")]
		StrengthRun,
		// Token: 0x0400A720 RID: 42784
		[OriginalName("StrengthSwim")]
		StrengthSwim,
		// Token: 0x0400A721 RID: 42785
		[OriginalName("StrengthFastSwim")]
		StrengthFastSwim,
		// Token: 0x0400A722 RID: 42786
		[OriginalName("ElementEnergyMax")]
		ElementEnergyMax,
		// Token: 0x0400A723 RID: 42787
		[OriginalName("ElementEnergy")]
		ElementEnergy,
		// Token: 0x0400A724 RID: 42788
		[OriginalName("HardnessMax")]
		HardnessMax,
		// Token: 0x0400A725 RID: 42789
		[OriginalName("Hardness")]
		Hardness,
		// Token: 0x0400A726 RID: 42790
		[OriginalName("HardnessRecover")]
		HardnessRecover,
		// Token: 0x0400A727 RID: 42791
		[OriginalName("HardnessPunishTime")]
		HardnessPunishTime,
		// Token: 0x0400A728 RID: 42792
		[OriginalName("HardnessChange")]
		HardnessChange,
		// Token: 0x0400A729 RID: 42793
		[OriginalName("HardnessReduce")]
		HardnessReduce,
		// Token: 0x0400A72A RID: 42794
		[OriginalName("ToughMax")]
		ToughMax,
		// Token: 0x0400A72B RID: 42795
		[OriginalName("Tough")]
		Tough,
		// Token: 0x0400A72C RID: 42796
		[OriginalName("ToughRecover")]
		ToughRecover,
		// Token: 0x0400A72D RID: 42797
		[OriginalName("ToughChange")]
		ToughChange,
		// Token: 0x0400A72E RID: 42798
		[OriginalName("ToughReduce")]
		ToughReduce,
		// Token: 0x0400A72F RID: 42799
		[OriginalName("ElementPower1")]
		ElementPower1,
		// Token: 0x0400A730 RID: 42800
		[OriginalName("ElementPower2")]
		ElementPower2,
		// Token: 0x0400A731 RID: 42801
		[OriginalName("ElementPower3")]
		ElementPower3,
		// Token: 0x0400A732 RID: 42802
		[OriginalName("ElementPower4")]
		ElementPower4,
		// Token: 0x0400A733 RID: 42803
		[OriginalName("ElementPower5")]
		ElementPower5,
		// Token: 0x0400A734 RID: 42804
		[OriginalName("ElementPower6")]
		ElementPower6,
		// Token: 0x0400A735 RID: 42805
		[OriginalName("SpecialDamageChange")]
		SpecialDamageChange,
		// Token: 0x0400A736 RID: 42806
		[OriginalName("StrengthFastClimbCost")]
		StrengthFastClimbCost,
		// Token: 0x0400A737 RID: 42807
		[OriginalName("ElementPropertyType")]
		ElementPropertyType,
		// Token: 0x0400A738 RID: 42808
		[OriginalName("WeakTime")]
		WeakTime,
		// Token: 0x0400A739 RID: 42809
		[OriginalName("IgnoreDefRate")]
		IgnoreDefRate,
		// Token: 0x0400A73A RID: 42810
		[OriginalName("IgnoreDamageResistancePhys")]
		IgnoreDamageResistancePhys,
		// Token: 0x0400A73B RID: 42811
		[OriginalName("IgnoreDamageResistanceElement1")]
		IgnoreDamageResistanceElement1,
		// Token: 0x0400A73C RID: 42812
		[OriginalName("IgnoreDamageResistanceElement2")]
		IgnoreDamageResistanceElement2,
		// Token: 0x0400A73D RID: 42813
		[OriginalName("IgnoreDamageResistanceElement3")]
		IgnoreDamageResistanceElement3,
		// Token: 0x0400A73E RID: 42814
		[OriginalName("IgnoreDamageResistanceElement4")]
		IgnoreDamageResistanceElement4,
		// Token: 0x0400A73F RID: 42815
		[OriginalName("IgnoreDamageResistanceElement5")]
		IgnoreDamageResistanceElement5,
		// Token: 0x0400A740 RID: 42816
		[OriginalName("IgnoreDamageResistanceElement6")]
		IgnoreDamageResistanceElement6,
		// Token: 0x0400A741 RID: 42817
		[OriginalName("SkillToughRatio")]
		SkillToughRatio,
		// Token: 0x0400A742 RID: 42818
		[OriginalName("StrengthClimbJump")]
		StrengthClimbJump,
		// Token: 0x0400A743 RID: 42819
		[OriginalName("StrengthGliding")]
		StrengthGliding,
		// Token: 0x0400A744 RID: 42820
		[OriginalName("Mass")]
		Mass,
		// Token: 0x0400A745 RID: 42821
		[OriginalName("BrakingFrictionFactor")]
		BrakingFrictionFactor,
		// Token: 0x0400A746 RID: 42822
		[OriginalName("GravityScale")]
		GravityScale,
		// Token: 0x0400A747 RID: 42823
		[OriginalName("SpeedRatio")]
		SpeedRatio,
		// Token: 0x0400A748 RID: 42824
		[OriginalName("DamageChangePhantom")]
		DamageChangePhantom,
		// Token: 0x0400A749 RID: 42825
		[OriginalName("AutoAttackSpeed")]
		AutoAttackSpeed,
		// Token: 0x0400A74A RID: 42826
		[OriginalName("CastAttackSpeed")]
		CastAttackSpeed,
		// Token: 0x0400A74B RID: 42827
		[OriginalName("StatusBuildUp1Max")]
		StatusBuildUp1Max,
		// Token: 0x0400A74C RID: 42828
		[OriginalName("StatusBuildUp1")]
		StatusBuildUp1,
		// Token: 0x0400A74D RID: 42829
		[OriginalName("StatusBuildUp2Max")]
		StatusBuildUp2Max,
		// Token: 0x0400A74E RID: 42830
		[OriginalName("StatusBuildUp2")]
		StatusBuildUp2,
		// Token: 0x0400A74F RID: 42831
		[OriginalName("StatusBuildUp3Max")]
		StatusBuildUp3Max,
		// Token: 0x0400A750 RID: 42832
		[OriginalName("StatusBuildUp3")]
		StatusBuildUp3,
		// Token: 0x0400A751 RID: 42833
		[OriginalName("StatusBuildUp4Max")]
		StatusBuildUp4Max,
		// Token: 0x0400A752 RID: 42834
		[OriginalName("StatusBuildUp4")]
		StatusBuildUp4,
		// Token: 0x0400A753 RID: 42835
		[OriginalName("StatusBuildUp5Max")]
		StatusBuildUp5Max,
		// Token: 0x0400A754 RID: 42836
		[OriginalName("StatusBuildUp5")]
		StatusBuildUp5,
		// Token: 0x0400A755 RID: 42837
		[OriginalName("RageMax")]
		RageMax,
		// Token: 0x0400A756 RID: 42838
		[OriginalName("Rage")]
		Rage,
		// Token: 0x0400A757 RID: 42839
		[OriginalName("RageRecover")]
		RageRecover,
		// Token: 0x0400A758 RID: 42840
		[OriginalName("RagePunishTime")]
		RagePunishTime,
		// Token: 0x0400A759 RID: 42841
		[OriginalName("RageChange")]
		RageChange,
		// Token: 0x0400A75A RID: 42842
		[OriginalName("RageReduce")]
		RageReduce,
		// Token: 0x0400A75B RID: 42843
		[OriginalName("ToughRecoverDelayTime")]
		ToughRecoverDelayTime,
		// Token: 0x0400A75C RID: 42844
		[OriginalName("Jump")]
		Jump,
		// Token: 0x0400A75D RID: 42845
		[OriginalName("ParalysisTimeMax")]
		ParalysisTimeMax,
		// Token: 0x0400A75E RID: 42846
		[OriginalName("ParalysisTime")]
		ParalysisTime,
		// Token: 0x0400A75F RID: 42847
		[OriginalName("ParalysisTimeRecover")]
		ParalysisTimeRecover,
		// Token: 0x0400A760 RID: 42848
		[OriginalName("WeaknessBuildUp")]
		WeaknessBuildUp,
		// Token: 0x0400A761 RID: 42849
		[OriginalName("WeaknessBuildUpMax")]
		WeaknessBuildUpMax,
		// Token: 0x0400A762 RID: 42850
		[OriginalName("WeaknessTotalBonus")]
		WeaknessTotalBonus,
		// Token: 0x0400A763 RID: 42851
		[OriginalName("BreakWeaknessRatio")]
		BreakWeaknessRatio,
		// Token: 0x0400A764 RID: 42852
		[OriginalName("WeaknessMastery")]
		WeaknessMastery,
		// Token: 0x0400A765 RID: 42853
		[OriginalName("EAttributeType_MAX")]
		Max
	}
}
