using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015F5 RID: 5621
	public enum EAttributeType
	{
		// Token: 0x0400AB63 RID: 43875
		[OriginalName("EAttributeType_None")]
		None,
		// Token: 0x0400AB64 RID: 43876
		[OriginalName("Lv")]
		Lv,
		// Token: 0x0400AB65 RID: 43877
		[OriginalName("LifeMax")]
		LifeMax,
		// Token: 0x0400AB66 RID: 43878
		[OriginalName("Life")]
		Life,
		// Token: 0x0400AB67 RID: 43879
		[OriginalName("Sheild")]
		Sheild,
		// Token: 0x0400AB68 RID: 43880
		[OriginalName("SheildDamageChange")]
		SheildDamageChange,
		// Token: 0x0400AB69 RID: 43881
		[OriginalName("SheildDamageReduce")]
		SheildDamageReduce,
		// Token: 0x0400AB6A RID: 43882
		[OriginalName("Atk")]
		Atk,
		// Token: 0x0400AB6B RID: 43883
		[OriginalName("Crit")]
		Crit,
		// Token: 0x0400AB6C RID: 43884
		[OriginalName("CritDamage")]
		CritDamage,
		// Token: 0x0400AB6D RID: 43885
		[OriginalName("Def")]
		Def,
		// Token: 0x0400AB6E RID: 43886
		[OriginalName("EnergyEfficiency")]
		EnergyEfficiency,
		// Token: 0x0400AB6F RID: 43887
		[OriginalName("CdReduse")]
		CdReduse,
		// Token: 0x0400AB70 RID: 43888
		[OriginalName("ElementEfficiency")]
		ElementEfficiency,
		// Token: 0x0400AB71 RID: 43889
		[OriginalName("DamageChangeNormalSkill")]
		DamageChangeNormalSkill,
		// Token: 0x0400AB72 RID: 43890
		[OriginalName("DamageChange")]
		DamageChange,
		// Token: 0x0400AB73 RID: 43891
		[OriginalName("DamageReduce")]
		DamageReduce,
		// Token: 0x0400AB74 RID: 43892
		[OriginalName("DamageChangeAuto")]
		DamageChangeAuto,
		// Token: 0x0400AB75 RID: 43893
		[OriginalName("DamageChangeCast")]
		DamageChangeCast,
		// Token: 0x0400AB76 RID: 43894
		[OriginalName("DamageChangeUltra")]
		DamageChangeUltra,
		// Token: 0x0400AB77 RID: 43895
		[OriginalName("DamageChangeQte")]
		DamageChangeQte,
		// Token: 0x0400AB78 RID: 43896
		[OriginalName("DamageChangePhys")]
		DamageChangePhys,
		// Token: 0x0400AB79 RID: 43897
		[OriginalName("DamageChangeElement1")]
		DamageChangeElement1,
		// Token: 0x0400AB7A RID: 43898
		[OriginalName("DamageChangeElement2")]
		DamageChangeElement2,
		// Token: 0x0400AB7B RID: 43899
		[OriginalName("DamageChangeElement3")]
		DamageChangeElement3,
		// Token: 0x0400AB7C RID: 43900
		[OriginalName("DamageChangeElement4")]
		DamageChangeElement4,
		// Token: 0x0400AB7D RID: 43901
		[OriginalName("DamageChangeElement5")]
		DamageChangeElement5,
		// Token: 0x0400AB7E RID: 43902
		[OriginalName("DamageChangeElement6")]
		DamageChangeElement6,
		// Token: 0x0400AB7F RID: 43903
		[OriginalName("DamageResistancePhys")]
		DamageResistancePhys,
		// Token: 0x0400AB80 RID: 43904
		[OriginalName("DamageResistanceElement1")]
		DamageResistanceElement1,
		// Token: 0x0400AB81 RID: 43905
		[OriginalName("DamageResistanceElement2")]
		DamageResistanceElement2,
		// Token: 0x0400AB82 RID: 43906
		[OriginalName("DamageResistanceElement3")]
		DamageResistanceElement3,
		// Token: 0x0400AB83 RID: 43907
		[OriginalName("DamageResistanceElement4")]
		DamageResistanceElement4,
		// Token: 0x0400AB84 RID: 43908
		[OriginalName("DamageResistanceElement5")]
		DamageResistanceElement5,
		// Token: 0x0400AB85 RID: 43909
		[OriginalName("DamageResistanceElement6")]
		DamageResistanceElement6,
		// Token: 0x0400AB86 RID: 43910
		[OriginalName("HealChange")]
		HealChange,
		// Token: 0x0400AB87 RID: 43911
		[OriginalName("HealedChange")]
		HealedChange,
		// Token: 0x0400AB88 RID: 43912
		[OriginalName("DamageReducePhys")]
		DamageReducePhys,
		// Token: 0x0400AB89 RID: 43913
		[OriginalName("DamageReduceElement1")]
		DamageReduceElement1,
		// Token: 0x0400AB8A RID: 43914
		[OriginalName("DamageReduceElement2")]
		DamageReduceElement2,
		// Token: 0x0400AB8B RID: 43915
		[OriginalName("DamageReduceElement3")]
		DamageReduceElement3,
		// Token: 0x0400AB8C RID: 43916
		[OriginalName("DamageReduceElement4")]
		DamageReduceElement4,
		// Token: 0x0400AB8D RID: 43917
		[OriginalName("DamageReduceElement5")]
		DamageReduceElement5,
		// Token: 0x0400AB8E RID: 43918
		[OriginalName("DamageReduceElement6")]
		DamageReduceElement6,
		// Token: 0x0400AB8F RID: 43919
		[OriginalName("SpecialEnergy5Max")]
		SpecialEnergy5Max,
		// Token: 0x0400AB90 RID: 43920
		[OriginalName("SpecialEnergy5")]
		SpecialEnergy5,
		// Token: 0x0400AB91 RID: 43921
		[OriginalName("ReactionChange3")]
		ReactionChange3,
		// Token: 0x0400AB92 RID: 43922
		[OriginalName("ReactionChange4")]
		ReactionChange4,
		// Token: 0x0400AB93 RID: 43923
		[OriginalName("ReactionChange5")]
		ReactionChange5,
		// Token: 0x0400AB94 RID: 43924
		[OriginalName("ReactionChange6")]
		ReactionChange6,
		// Token: 0x0400AB95 RID: 43925
		[OriginalName("ReactionChange7")]
		ReactionChange7,
		// Token: 0x0400AB96 RID: 43926
		[OriginalName("ReactionChange8")]
		ReactionChange8,
		// Token: 0x0400AB97 RID: 43927
		[OriginalName("ReactionChange9")]
		ReactionChange9,
		// Token: 0x0400AB98 RID: 43928
		[OriginalName("ReactionChange10")]
		ReactionChange10,
		// Token: 0x0400AB99 RID: 43929
		[OriginalName("ReactionChange11")]
		ReactionChange11,
		// Token: 0x0400AB9A RID: 43930
		[OriginalName("ReactionChange12")]
		ReactionChange12,
		// Token: 0x0400AB9B RID: 43931
		[OriginalName("ReactionChange13")]
		ReactionChange13,
		// Token: 0x0400AB9C RID: 43932
		[OriginalName("ReactionChange14")]
		ReactionChange14,
		// Token: 0x0400AB9D RID: 43933
		[OriginalName("ReactionChange15")]
		ReactionChange15,
		// Token: 0x0400AB9E RID: 43934
		[OriginalName("EnergyMax")]
		EnergyMax,
		// Token: 0x0400AB9F RID: 43935
		[OriginalName("Energy")]
		Energy,
		// Token: 0x0400ABA0 RID: 43936
		[OriginalName("SpecialEnergy1Max")]
		SpecialEnergy1Max,
		// Token: 0x0400ABA1 RID: 43937
		[OriginalName("SpecialEnergy1")]
		SpecialEnergy1,
		// Token: 0x0400ABA2 RID: 43938
		[OriginalName("SpecialEnergy2Max")]
		SpecialEnergy2Max,
		// Token: 0x0400ABA3 RID: 43939
		[OriginalName("SpecialEnergy2")]
		SpecialEnergy2,
		// Token: 0x0400ABA4 RID: 43940
		[OriginalName("SpecialEnergy3Max")]
		SpecialEnergy3Max,
		// Token: 0x0400ABA5 RID: 43941
		[OriginalName("SpecialEnergy3")]
		SpecialEnergy3,
		// Token: 0x0400ABA6 RID: 43942
		[OriginalName("SpecialEnergy4Max")]
		SpecialEnergy4Max,
		// Token: 0x0400ABA7 RID: 43943
		[OriginalName("SpecialEnergy4")]
		SpecialEnergy4,
		// Token: 0x0400ABA8 RID: 43944
		[OriginalName("StrengthMax")]
		StrengthMax,
		// Token: 0x0400ABA9 RID: 43945
		[OriginalName("Strength")]
		Strength,
		// Token: 0x0400ABAA RID: 43946
		[OriginalName("StrengthRecover")]
		StrengthRecover,
		// Token: 0x0400ABAB RID: 43947
		[OriginalName("StrengthPunishTime")]
		StrengthPunishTime,
		// Token: 0x0400ABAC RID: 43948
		[OriginalName("StrengthRun")]
		StrengthRun,
		// Token: 0x0400ABAD RID: 43949
		[OriginalName("StrengthSwim")]
		StrengthSwim,
		// Token: 0x0400ABAE RID: 43950
		[OriginalName("StrengthFastSwim")]
		StrengthFastSwim,
		// Token: 0x0400ABAF RID: 43951
		[OriginalName("ElementEnergyMax")]
		ElementEnergyMax,
		// Token: 0x0400ABB0 RID: 43952
		[OriginalName("ElementEnergy")]
		ElementEnergy,
		// Token: 0x0400ABB1 RID: 43953
		[OriginalName("HardnessMax")]
		HardnessMax,
		// Token: 0x0400ABB2 RID: 43954
		[OriginalName("Hardness")]
		Hardness,
		// Token: 0x0400ABB3 RID: 43955
		[OriginalName("HardnessRecover")]
		HardnessRecover,
		// Token: 0x0400ABB4 RID: 43956
		[OriginalName("HardnessPunishTime")]
		HardnessPunishTime,
		// Token: 0x0400ABB5 RID: 43957
		[OriginalName("HardnessChange")]
		HardnessChange,
		// Token: 0x0400ABB6 RID: 43958
		[OriginalName("HardnessReduce")]
		HardnessReduce,
		// Token: 0x0400ABB7 RID: 43959
		[OriginalName("ToughMax")]
		ToughMax,
		// Token: 0x0400ABB8 RID: 43960
		[OriginalName("Tough")]
		Tough,
		// Token: 0x0400ABB9 RID: 43961
		[OriginalName("ToughRecover")]
		ToughRecover,
		// Token: 0x0400ABBA RID: 43962
		[OriginalName("ToughChange")]
		ToughChange,
		// Token: 0x0400ABBB RID: 43963
		[OriginalName("ToughReduce")]
		ToughReduce,
		// Token: 0x0400ABBC RID: 43964
		[OriginalName("ElementPower1")]
		ElementPower1,
		// Token: 0x0400ABBD RID: 43965
		[OriginalName("ElementPower2")]
		ElementPower2,
		// Token: 0x0400ABBE RID: 43966
		[OriginalName("ElementPower3")]
		ElementPower3,
		// Token: 0x0400ABBF RID: 43967
		[OriginalName("ElementPower4")]
		ElementPower4,
		// Token: 0x0400ABC0 RID: 43968
		[OriginalName("ElementPower5")]
		ElementPower5,
		// Token: 0x0400ABC1 RID: 43969
		[OriginalName("ElementPower6")]
		ElementPower6,
		// Token: 0x0400ABC2 RID: 43970
		[OriginalName("SpecialDamageChange")]
		SpecialDamageChange,
		// Token: 0x0400ABC3 RID: 43971
		[OriginalName("StrengthFastClimbCost")]
		StrengthFastClimbCost,
		// Token: 0x0400ABC4 RID: 43972
		[OriginalName("ElementPropertyType")]
		ElementPropertyType,
		// Token: 0x0400ABC5 RID: 43973
		[OriginalName("WeakTime")]
		WeakTime,
		// Token: 0x0400ABC6 RID: 43974
		[OriginalName("IgnoreDefRate")]
		IgnoreDefRate,
		// Token: 0x0400ABC7 RID: 43975
		[OriginalName("IgnoreDamageResistancePhys")]
		IgnoreDamageResistancePhys,
		// Token: 0x0400ABC8 RID: 43976
		[OriginalName("IgnoreDamageResistanceElement1")]
		IgnoreDamageResistanceElement1,
		// Token: 0x0400ABC9 RID: 43977
		[OriginalName("IgnoreDamageResistanceElement2")]
		IgnoreDamageResistanceElement2,
		// Token: 0x0400ABCA RID: 43978
		[OriginalName("IgnoreDamageResistanceElement3")]
		IgnoreDamageResistanceElement3,
		// Token: 0x0400ABCB RID: 43979
		[OriginalName("IgnoreDamageResistanceElement4")]
		IgnoreDamageResistanceElement4,
		// Token: 0x0400ABCC RID: 43980
		[OriginalName("IgnoreDamageResistanceElement5")]
		IgnoreDamageResistanceElement5,
		// Token: 0x0400ABCD RID: 43981
		[OriginalName("IgnoreDamageResistanceElement6")]
		IgnoreDamageResistanceElement6,
		// Token: 0x0400ABCE RID: 43982
		[OriginalName("SkillToughRatio")]
		SkillToughRatio,
		// Token: 0x0400ABCF RID: 43983
		[OriginalName("StrengthClimbJump")]
		StrengthClimbJump,
		// Token: 0x0400ABD0 RID: 43984
		[OriginalName("StrengthGliding")]
		StrengthGliding,
		// Token: 0x0400ABD1 RID: 43985
		[OriginalName("Mass")]
		Mass,
		// Token: 0x0400ABD2 RID: 43986
		[OriginalName("BrakingFrictionFactor")]
		BrakingFrictionFactor,
		// Token: 0x0400ABD3 RID: 43987
		[OriginalName("GravityScale")]
		GravityScale,
		// Token: 0x0400ABD4 RID: 43988
		[OriginalName("SpeedRatio")]
		SpeedRatio,
		// Token: 0x0400ABD5 RID: 43989
		[OriginalName("DamageChangePhantom")]
		DamageChangePhantom,
		// Token: 0x0400ABD6 RID: 43990
		[OriginalName("AutoAttackSpeed")]
		AutoAttackSpeed,
		// Token: 0x0400ABD7 RID: 43991
		[OriginalName("CastAttackSpeed")]
		CastAttackSpeed,
		// Token: 0x0400ABD8 RID: 43992
		[OriginalName("StatusBuildUp1Max")]
		StatusBuildUp1Max,
		// Token: 0x0400ABD9 RID: 43993
		[OriginalName("StatusBuildUp1")]
		StatusBuildUp1,
		// Token: 0x0400ABDA RID: 43994
		[OriginalName("StatusBuildUp2Max")]
		StatusBuildUp2Max,
		// Token: 0x0400ABDB RID: 43995
		[OriginalName("StatusBuildUp2")]
		StatusBuildUp2,
		// Token: 0x0400ABDC RID: 43996
		[OriginalName("StatusBuildUp3Max")]
		StatusBuildUp3Max,
		// Token: 0x0400ABDD RID: 43997
		[OriginalName("StatusBuildUp3")]
		StatusBuildUp3,
		// Token: 0x0400ABDE RID: 43998
		[OriginalName("StatusBuildUp4Max")]
		StatusBuildUp4Max,
		// Token: 0x0400ABDF RID: 43999
		[OriginalName("StatusBuildUp4")]
		StatusBuildUp4,
		// Token: 0x0400ABE0 RID: 44000
		[OriginalName("StatusBuildUp5Max")]
		StatusBuildUp5Max,
		// Token: 0x0400ABE1 RID: 44001
		[OriginalName("StatusBuildUp5")]
		StatusBuildUp5,
		// Token: 0x0400ABE2 RID: 44002
		[OriginalName("RageMax")]
		RageMax,
		// Token: 0x0400ABE3 RID: 44003
		[OriginalName("Rage")]
		Rage,
		// Token: 0x0400ABE4 RID: 44004
		[OriginalName("RageRecover")]
		RageRecover,
		// Token: 0x0400ABE5 RID: 44005
		[OriginalName("RagePunishTime")]
		RagePunishTime,
		// Token: 0x0400ABE6 RID: 44006
		[OriginalName("RageChange")]
		RageChange,
		// Token: 0x0400ABE7 RID: 44007
		[OriginalName("RageReduce")]
		RageReduce,
		// Token: 0x0400ABE8 RID: 44008
		[OriginalName("ToughRecoverDelayTime")]
		ToughRecoverDelayTime,
		// Token: 0x0400ABE9 RID: 44009
		[OriginalName("Jump")]
		Jump,
		// Token: 0x0400ABEA RID: 44010
		[OriginalName("ParalysisTimeMax")]
		ParalysisTimeMax,
		// Token: 0x0400ABEB RID: 44011
		[OriginalName("ParalysisTime")]
		ParalysisTime,
		// Token: 0x0400ABEC RID: 44012
		[OriginalName("ParalysisTimeRecover")]
		ParalysisTimeRecover,
		// Token: 0x0400ABED RID: 44013
		[OriginalName("WeaknessBuildUp")]
		WeaknessBuildUp,
		// Token: 0x0400ABEE RID: 44014
		[OriginalName("WeaknessBuildUpMax")]
		WeaknessBuildUpMax,
		// Token: 0x0400ABEF RID: 44015
		[OriginalName("WeaknessTotalBonus")]
		WeaknessTotalBonus,
		// Token: 0x0400ABF0 RID: 44016
		[OriginalName("BreakWeaknessRatio")]
		BreakWeaknessRatio,
		// Token: 0x0400ABF1 RID: 44017
		[OriginalName("WeaknessMastery")]
		WeaknessMastery,
		// Token: 0x0400ABF2 RID: 44018
		[OriginalName("EAttributeType_MAX")]
		Max
	}
}
