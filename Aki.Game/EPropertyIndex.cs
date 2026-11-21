using System;

// Token: 0x02000BA6 RID: 2982
public enum EPropertyIndex
{
	// Token: 0x04004C77 RID: 19575
	Invalid,
	// Token: 0x04004C78 RID: 19576
	Lv,
	// Token: 0x04004C79 RID: 19577
	LifeMax,
	// Token: 0x04004C7A RID: 19578
	Life,
	// Token: 0x04004C7B RID: 19579
	Sheild,
	// Token: 0x04004C7C RID: 19580
	SheildDamageChange,
	// Token: 0x04004C7D RID: 19581
	SheildDamageReduce,
	// Token: 0x04004C7E RID: 19582
	Atk,
	// Token: 0x04004C7F RID: 19583
	Crit,
	// Token: 0x04004C80 RID: 19584
	CritDamage,
	// Token: 0x04004C81 RID: 19585
	Def,
	// Token: 0x04004C82 RID: 19586
	EnergyEfficiency,
	// Token: 0x04004C83 RID: 19587
	CDReduse,
	// Token: 0x04004C84 RID: 19588
	ReactionEfficiency,
	// Token: 0x04004C85 RID: 19589
	DamageChangeNormalSkill,
	// Token: 0x04004C86 RID: 19590
	DamageChange,
	// Token: 0x04004C87 RID: 19591
	DamageReduce,
	// Token: 0x04004C88 RID: 19592
	DamageChangeAuto,
	// Token: 0x04004C89 RID: 19593
	DamageChangeCast,
	// Token: 0x04004C8A RID: 19594
	DamageChangeUltra,
	// Token: 0x04004C8B RID: 19595
	DamageChangeQTE,
	// Token: 0x04004C8C RID: 19596
	DamageChangePhys,
	// Token: 0x04004C8D RID: 19597
	DamageChangeElement1,
	// Token: 0x04004C8E RID: 19598
	DamageChangeElement2,
	// Token: 0x04004C8F RID: 19599
	DamageChangeElement3,
	// Token: 0x04004C90 RID: 19600
	DamageChangeElement4,
	// Token: 0x04004C91 RID: 19601
	DamageChangeElement5,
	// Token: 0x04004C92 RID: 19602
	DamageChangeElement6,
	// Token: 0x04004C93 RID: 19603
	DamageResistancePhys,
	// Token: 0x04004C94 RID: 19604
	DamageResistanceElement1,
	// Token: 0x04004C95 RID: 19605
	DamageResistanceElement2,
	// Token: 0x04004C96 RID: 19606
	DamageResistanceElement3,
	// Token: 0x04004C97 RID: 19607
	DamageResistanceElement4,
	// Token: 0x04004C98 RID: 19608
	DamageResistanceElement5,
	// Token: 0x04004C99 RID: 19609
	DamageResistanceElement6,
	// Token: 0x04004C9A RID: 19610
	HealChange,
	// Token: 0x04004C9B RID: 19611
	HealedChange,
	// Token: 0x04004C9C RID: 19612
	DamageReducePhys,
	// Token: 0x04004C9D RID: 19613
	DamageReduceElement1,
	// Token: 0x04004C9E RID: 19614
	DamageReduceElement2,
	// Token: 0x04004C9F RID: 19615
	DamageReduceElement3,
	// Token: 0x04004CA0 RID: 19616
	DamageReduceElement4,
	// Token: 0x04004CA1 RID: 19617
	DamageReduceElement5,
	// Token: 0x04004CA2 RID: 19618
	DamageReduceElement6,
	// Token: 0x04004CA3 RID: 19619
	SpecialEnergy5Max,
	// Token: 0x04004CA4 RID: 19620
	SpecialEnergy5,
	// Token: 0x04004CA5 RID: 19621
	ReactionChange3,
	// Token: 0x04004CA6 RID: 19622
	ReactionChange4,
	// Token: 0x04004CA7 RID: 19623
	ReactionChange5,
	// Token: 0x04004CA8 RID: 19624
	ReactionChange6,
	// Token: 0x04004CA9 RID: 19625
	ReactionChange7,
	// Token: 0x04004CAA RID: 19626
	ReactionChange8,
	// Token: 0x04004CAB RID: 19627
	ReactionChange9,
	// Token: 0x04004CAC RID: 19628
	ReactionChange10,
	// Token: 0x04004CAD RID: 19629
	ReactionChange11,
	// Token: 0x04004CAE RID: 19630
	ReactionChange12,
	// Token: 0x04004CAF RID: 19631
	ReactionChange13,
	// Token: 0x04004CB0 RID: 19632
	ReactionChange14,
	// Token: 0x04004CB1 RID: 19633
	ReactionChange15,
	// Token: 0x04004CB2 RID: 19634
	EnergyMax,
	// Token: 0x04004CB3 RID: 19635
	Energy,
	// Token: 0x04004CB4 RID: 19636
	SpecialEnergy1Max,
	// Token: 0x04004CB5 RID: 19637
	SpecialEnergy1,
	// Token: 0x04004CB6 RID: 19638
	SpecialEnergy2Max,
	// Token: 0x04004CB7 RID: 19639
	SpecialEnergy2,
	// Token: 0x04004CB8 RID: 19640
	SpecialEnergy3Max,
	// Token: 0x04004CB9 RID: 19641
	SpecialEnergy3,
	// Token: 0x04004CBA RID: 19642
	SpecialEnergy4Max,
	// Token: 0x04004CBB RID: 19643
	SpecialEnergy4,
	// Token: 0x04004CBC RID: 19644
	StrengthMax,
	// Token: 0x04004CBD RID: 19645
	Strength,
	// Token: 0x04004CBE RID: 19646
	StrengthRecover,
	// Token: 0x04004CBF RID: 19647
	StrengthPunishTime,
	// Token: 0x04004CC0 RID: 19648
	StrengthRun,
	// Token: 0x04004CC1 RID: 19649
	StrengthSwim,
	// Token: 0x04004CC2 RID: 19650
	StrengthFastSwim,
	// Token: 0x04004CC3 RID: 19651
	StrengthClimb,
	// Token: 0x04004CC4 RID: 19652
	StrengthFastClimb,
	// Token: 0x04004CC5 RID: 19653
	HardnessMax,
	// Token: 0x04004CC6 RID: 19654
	Hardness,
	// Token: 0x04004CC7 RID: 19655
	HardnessRecover,
	// Token: 0x04004CC8 RID: 19656
	HardnessPunishTime,
	// Token: 0x04004CC9 RID: 19657
	HardnessChange,
	// Token: 0x04004CCA RID: 19658
	HardnessReduce,
	// Token: 0x04004CCB RID: 19659
	ToughMax,
	// Token: 0x04004CCC RID: 19660
	Tough,
	// Token: 0x04004CCD RID: 19661
	ToughRecover,
	// Token: 0x04004CCE RID: 19662
	ToughChange,
	// Token: 0x04004CCF RID: 19663
	ToughReduce,
	// Token: 0x04004CD0 RID: 19664
	ElementPower1,
	// Token: 0x04004CD1 RID: 19665
	ElementPower2,
	// Token: 0x04004CD2 RID: 19666
	ElementPower3,
	// Token: 0x04004CD3 RID: 19667
	ElementPower4,
	// Token: 0x04004CD4 RID: 19668
	ElementPower5,
	// Token: 0x04004CD5 RID: 19669
	ElementPower6,
	// Token: 0x04004CD6 RID: 19670
	SpecialDamageChange,
	// Token: 0x04004CD7 RID: 19671
	StrengthFastClimbCost,
	// Token: 0x04004CD8 RID: 19672
	ElementPropertyType,
	// Token: 0x04004CD9 RID: 19673
	WeakTime,
	// Token: 0x04004CDA RID: 19674
	IgnoreDefRate,
	// Token: 0x04004CDB RID: 19675
	IgnoreDamageResistancePhys,
	// Token: 0x04004CDC RID: 19676
	IgnoreDamageResistanceElement1,
	// Token: 0x04004CDD RID: 19677
	IgnoreDamageResistanceElement2,
	// Token: 0x04004CDE RID: 19678
	IgnoreDamageResistanceElement3,
	// Token: 0x04004CDF RID: 19679
	IgnoreDamageResistanceElement4,
	// Token: 0x04004CE0 RID: 19680
	IgnoreDamageResistanceElement5,
	// Token: 0x04004CE1 RID: 19681
	IgnoreDamageResistanceElement6,
	// Token: 0x04004CE2 RID: 19682
	SkillToughRatio,
	// Token: 0x04004CE3 RID: 19683
	StrengthClimbJump,
	// Token: 0x04004CE4 RID: 19684
	StrengthGliding,
	// Token: 0x04004CE5 RID: 19685
	Mass,
	// Token: 0x04004CE6 RID: 19686
	BrakingFrictionFactor,
	// Token: 0x04004CE7 RID: 19687
	GravityScale,
	// Token: 0x04004CE8 RID: 19688
	SpeedRatio,
	// Token: 0x04004CE9 RID: 19689
	DamageChangePhantom,
	// Token: 0x04004CEA RID: 19690
	AutoAttackSpeed,
	// Token: 0x04004CEB RID: 19691
	CastAttackSpeed,
	// Token: 0x04004CEC RID: 19692
	RageMax = 127,
	// Token: 0x04004CED RID: 19693
	Rage,
	// Token: 0x04004CEE RID: 19694
	RageRecover,
	// Token: 0x04004CEF RID: 19695
	RagePunishTime,
	// Token: 0x04004CF0 RID: 19696
	RageChange,
	// Token: 0x04004CF1 RID: 19697
	RageReduce,
	// Token: 0x04004CF2 RID: 19698
	ToughRecoverDelayTime,
	// Token: 0x04004CF3 RID: 19699
	GreenLv = 10001,
	// Token: 0x04004CF4 RID: 19700
	GreenLifeMax,
	// Token: 0x04004CF5 RID: 19701
	GreenLife,
	// Token: 0x04004CF6 RID: 19702
	GreenSheild,
	// Token: 0x04004CF7 RID: 19703
	GreenSheildDamageChange,
	// Token: 0x04004CF8 RID: 19704
	GreenSheildDamageReduce,
	// Token: 0x04004CF9 RID: 19705
	GreenAtk,
	// Token: 0x04004CFA RID: 19706
	GreenCrit,
	// Token: 0x04004CFB RID: 19707
	GreenCritDamage,
	// Token: 0x04004CFC RID: 19708
	GreenDef,
	// Token: 0x04004CFD RID: 19709
	GreenEnergyEfficiency,
	// Token: 0x04004CFE RID: 19710
	GreenCDReduse,
	// Token: 0x04004CFF RID: 19711
	GreenReactionEfficiency,
	// Token: 0x04004D00 RID: 19712
	GreenDamageChangeNormalSkill,
	// Token: 0x04004D01 RID: 19713
	GreenDamageChange,
	// Token: 0x04004D02 RID: 19714
	GreenDamageReduce,
	// Token: 0x04004D03 RID: 19715
	GreenDamageChangeAuto,
	// Token: 0x04004D04 RID: 19716
	GreenDamageChangeCast,
	// Token: 0x04004D05 RID: 19717
	GreenDamageChangeUltra,
	// Token: 0x04004D06 RID: 19718
	GreenDamageChangeQTE,
	// Token: 0x04004D07 RID: 19719
	GreenDamageChangePhys,
	// Token: 0x04004D08 RID: 19720
	GreenDamageChangeElement1,
	// Token: 0x04004D09 RID: 19721
	GreenDamageChangeElement2,
	// Token: 0x04004D0A RID: 19722
	GreenDamageChangeElement3,
	// Token: 0x04004D0B RID: 19723
	GreenDamageChangeElement4,
	// Token: 0x04004D0C RID: 19724
	GreenDamageChangeElement5,
	// Token: 0x04004D0D RID: 19725
	GreenDamageChangeElement6,
	// Token: 0x04004D0E RID: 19726
	GreenDamageResistancePhys,
	// Token: 0x04004D0F RID: 19727
	GreenDamageResistanceElement1,
	// Token: 0x04004D10 RID: 19728
	GreenDamageResistanceElement2,
	// Token: 0x04004D11 RID: 19729
	GreenDamageResistanceElement3,
	// Token: 0x04004D12 RID: 19730
	GreenDamageResistanceElement4,
	// Token: 0x04004D13 RID: 19731
	GreenDamageResistanceElement5,
	// Token: 0x04004D14 RID: 19732
	GreenDamageResistanceElement6,
	// Token: 0x04004D15 RID: 19733
	GreenHealChange,
	// Token: 0x04004D16 RID: 19734
	GreenHealedChange,
	// Token: 0x04004D17 RID: 19735
	GreenDamageReducePhys,
	// Token: 0x04004D18 RID: 19736
	GreenDamageReduceElement1,
	// Token: 0x04004D19 RID: 19737
	GreenDamageReduceElement2,
	// Token: 0x04004D1A RID: 19738
	GreenDamageReduceElement3,
	// Token: 0x04004D1B RID: 19739
	GreenDamageReduceElement4,
	// Token: 0x04004D1C RID: 19740
	GreenDamageReduceElement5,
	// Token: 0x04004D1D RID: 19741
	GreenDamageReduceElement6,
	// Token: 0x04004D1E RID: 19742
	GreenSpecialEnergy5Max,
	// Token: 0x04004D1F RID: 19743
	GreenSpecialEnergy5,
	// Token: 0x04004D20 RID: 19744
	GreenReactionChange3,
	// Token: 0x04004D21 RID: 19745
	GreenReactionChange4,
	// Token: 0x04004D22 RID: 19746
	GreenReactionChange5,
	// Token: 0x04004D23 RID: 19747
	GreenReactionChange6,
	// Token: 0x04004D24 RID: 19748
	GreenReactionChange7,
	// Token: 0x04004D25 RID: 19749
	GreenReactionChange8,
	// Token: 0x04004D26 RID: 19750
	GreenReactionChange9,
	// Token: 0x04004D27 RID: 19751
	GreenReactionChange10,
	// Token: 0x04004D28 RID: 19752
	GreenReactionChange11,
	// Token: 0x04004D29 RID: 19753
	GreenReactionChange12,
	// Token: 0x04004D2A RID: 19754
	GreenReactionChange13,
	// Token: 0x04004D2B RID: 19755
	GreenReactionChange14,
	// Token: 0x04004D2C RID: 19756
	GreenReactionChange15,
	// Token: 0x04004D2D RID: 19757
	GreenEnergyMax,
	// Token: 0x04004D2E RID: 19758
	GreenEnergy,
	// Token: 0x04004D2F RID: 19759
	GreenSpecialEnergy1Max,
	// Token: 0x04004D30 RID: 19760
	GreenSpecialEnergy1,
	// Token: 0x04004D31 RID: 19761
	GreenSpecialEnergy2Max,
	// Token: 0x04004D32 RID: 19762
	GreenSpecialEnergy2,
	// Token: 0x04004D33 RID: 19763
	GreenSpecialEnergy3Max,
	// Token: 0x04004D34 RID: 19764
	GreenSpecialEnergy3,
	// Token: 0x04004D35 RID: 19765
	GreenSpecialEnergy4Max,
	// Token: 0x04004D36 RID: 19766
	GreenSpecialEnergy4,
	// Token: 0x04004D37 RID: 19767
	GreenStrengthMax,
	// Token: 0x04004D38 RID: 19768
	GreenStrength,
	// Token: 0x04004D39 RID: 19769
	GreenStrengthRecover,
	// Token: 0x04004D3A RID: 19770
	GreenStrengthPunishTime,
	// Token: 0x04004D3B RID: 19771
	GreenStrengthRun,
	// Token: 0x04004D3C RID: 19772
	GreenStrengthSwim,
	// Token: 0x04004D3D RID: 19773
	GreenStrengthFastSwim,
	// Token: 0x04004D3E RID: 19774
	GreenStrengthClimb,
	// Token: 0x04004D3F RID: 19775
	GreenStrengthFastClimb,
	// Token: 0x04004D40 RID: 19776
	GreenHardnessMax,
	// Token: 0x04004D41 RID: 19777
	GreenHardness,
	// Token: 0x04004D42 RID: 19778
	GreenHardnessRecover,
	// Token: 0x04004D43 RID: 19779
	GreenHardnessPunishTime,
	// Token: 0x04004D44 RID: 19780
	GreenHardnessChange,
	// Token: 0x04004D45 RID: 19781
	GreenHardnessReduce,
	// Token: 0x04004D46 RID: 19782
	GreenToughMax,
	// Token: 0x04004D47 RID: 19783
	GreenTough,
	// Token: 0x04004D48 RID: 19784
	GreenToughRecover,
	// Token: 0x04004D49 RID: 19785
	GreenToughChange,
	// Token: 0x04004D4A RID: 19786
	GreenToughReduce,
	// Token: 0x04004D4B RID: 19787
	GreenElementPower1,
	// Token: 0x04004D4C RID: 19788
	GreenElementPower2,
	// Token: 0x04004D4D RID: 19789
	GreenElementPower3,
	// Token: 0x04004D4E RID: 19790
	GreenElementPower4,
	// Token: 0x04004D4F RID: 19791
	GreenElementPower5,
	// Token: 0x04004D50 RID: 19792
	GreenElementPower6,
	// Token: 0x04004D51 RID: 19793
	GreenSpecialDamageChange,
	// Token: 0x04004D52 RID: 19794
	GreenStrengthFastClimbCost,
	// Token: 0x04004D53 RID: 19795
	GreenElementPropertyType,
	// Token: 0x04004D54 RID: 19796
	GreenWeakTime,
	// Token: 0x04004D55 RID: 19797
	GreenIgnoreDefRate,
	// Token: 0x04004D56 RID: 19798
	GreenIgnoreDamageResistancePhys,
	// Token: 0x04004D57 RID: 19799
	GreenIgnoreDamageResistanceElement1,
	// Token: 0x04004D58 RID: 19800
	GreenIgnoreDamageResistanceElement2,
	// Token: 0x04004D59 RID: 19801
	GreenIgnoreDamageResistanceElement3,
	// Token: 0x04004D5A RID: 19802
	GreenIgnoreDamageResistanceElement4,
	// Token: 0x04004D5B RID: 19803
	GreenIgnoreDamageResistanceElement5,
	// Token: 0x04004D5C RID: 19804
	GreenIgnoreDamageResistanceElement6,
	// Token: 0x04004D5D RID: 19805
	GreenSkillToughRatio,
	// Token: 0x04004D5E RID: 19806
	GreenStrengthClimbJump,
	// Token: 0x04004D5F RID: 19807
	GreenStrengthGliding,
	// Token: 0x04004D60 RID: 19808
	GreenMass,
	// Token: 0x04004D61 RID: 19809
	GreenBrakingFrictionFactor,
	// Token: 0x04004D62 RID: 19810
	GreenGravityScale,
	// Token: 0x04004D63 RID: 19811
	GreenSpeedRatio,
	// Token: 0x04004D64 RID: 19812
	GreenDamageChangePhantom,
	// Token: 0x04004D65 RID: 19813
	GreenAutoAttackSpeed,
	// Token: 0x04004D66 RID: 19814
	GreenCastAttackSpeed,
	// Token: 0x04004D67 RID: 19815
	GreenRageMax = 10127,
	// Token: 0x04004D68 RID: 19816
	GreenRage,
	// Token: 0x04004D69 RID: 19817
	GreenRageRecover,
	// Token: 0x04004D6A RID: 19818
	GreenRagePunishTime,
	// Token: 0x04004D6B RID: 19819
	GreenRageChange,
	// Token: 0x04004D6C RID: 19820
	GreenRageReduce,
	// Token: 0x04004D6D RID: 19821
	GreenToughRecoverDelayTime
}
