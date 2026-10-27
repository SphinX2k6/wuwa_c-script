using System;

// Token: 0x020016EE RID: 5870
public enum EPropertyIndex
{
	// Token: 0x04004BD0 RID: 19408
	Invalid,
	// Token: 0x04004BD1 RID: 19409
	Lv,
	// Token: 0x04004BD2 RID: 19410
	LifeMax,
	// Token: 0x04004BD3 RID: 19411
	Life,
	// Token: 0x04004BD4 RID: 19412
	Sheild,
	// Token: 0x04004BD5 RID: 19413
	SheildDamageChange,
	// Token: 0x04004BD6 RID: 19414
	SheildDamageReduce,
	// Token: 0x04004BD7 RID: 19415
	Atk,
	// Token: 0x04004BD8 RID: 19416
	Crit,
	// Token: 0x04004BD9 RID: 19417
	CritDamage,
	// Token: 0x04004BDA RID: 19418
	Def,
	// Token: 0x04004BDB RID: 19419
	EnergyEfficiency,
	// Token: 0x04004BDC RID: 19420
	CDReduse,
	// Token: 0x04004BDD RID: 19421
	ReactionEfficiency,
	// Token: 0x04004BDE RID: 19422
	DamageChangeNormalSkill,
	// Token: 0x04004BDF RID: 19423
	DamageChange,
	// Token: 0x04004BE0 RID: 19424
	DamageReduce,
	// Token: 0x04004BE1 RID: 19425
	DamageChangeAuto,
	// Token: 0x04004BE2 RID: 19426
	DamageChangeCast,
	// Token: 0x04004BE3 RID: 19427
	DamageChangeUltra,
	// Token: 0x04004BE4 RID: 19428
	DamageChangeQTE,
	// Token: 0x04004BE5 RID: 19429
	DamageChangePhys,
	// Token: 0x04004BE6 RID: 19430
	DamageChangeElement1,
	// Token: 0x04004BE7 RID: 19431
	DamageChangeElement2,
	// Token: 0x04004BE8 RID: 19432
	DamageChangeElement3,
	// Token: 0x04004BE9 RID: 19433
	DamageChangeElement4,
	// Token: 0x04004BEA RID: 19434
	DamageChangeElement5,
	// Token: 0x04004BEB RID: 19435
	DamageChangeElement6,
	// Token: 0x04004BEC RID: 19436
	DamageResistancePhys,
	// Token: 0x04004BED RID: 19437
	DamageResistanceElement1,
	// Token: 0x04004BEE RID: 19438
	DamageResistanceElement2,
	// Token: 0x04004BEF RID: 19439
	DamageResistanceElement3,
	// Token: 0x04004BF0 RID: 19440
	DamageResistanceElement4,
	// Token: 0x04004BF1 RID: 19441
	DamageResistanceElement5,
	// Token: 0x04004BF2 RID: 19442
	DamageResistanceElement6,
	// Token: 0x04004BF3 RID: 19443
	HealChange,
	// Token: 0x04004BF4 RID: 19444
	HealedChange,
	// Token: 0x04004BF5 RID: 19445
	DamageReducePhys,
	// Token: 0x04004BF6 RID: 19446
	DamageReduceElement1,
	// Token: 0x04004BF7 RID: 19447
	DamageReduceElement2,
	// Token: 0x04004BF8 RID: 19448
	DamageReduceElement3,
	// Token: 0x04004BF9 RID: 19449
	DamageReduceElement4,
	// Token: 0x04004BFA RID: 19450
	DamageReduceElement5,
	// Token: 0x04004BFB RID: 19451
	DamageReduceElement6,
	// Token: 0x04004BFC RID: 19452
	SpecialEnergy5Max,
	// Token: 0x04004BFD RID: 19453
	SpecialEnergy5,
	// Token: 0x04004BFE RID: 19454
	ReactionChange3,
	// Token: 0x04004BFF RID: 19455
	ReactionChange4,
	// Token: 0x04004C00 RID: 19456
	ReactionChange5,
	// Token: 0x04004C01 RID: 19457
	ReactionChange6,
	// Token: 0x04004C02 RID: 19458
	ReactionChange7,
	// Token: 0x04004C03 RID: 19459
	ReactionChange8,
	// Token: 0x04004C04 RID: 19460
	ReactionChange9,
	// Token: 0x04004C05 RID: 19461
	ReactionChange10,
	// Token: 0x04004C06 RID: 19462
	ReactionChange11,
	// Token: 0x04004C07 RID: 19463
	ReactionChange12,
	// Token: 0x04004C08 RID: 19464
	ReactionChange13,
	// Token: 0x04004C09 RID: 19465
	ReactionChange14,
	// Token: 0x04004C0A RID: 19466
	ReactionChange15,
	// Token: 0x04004C0B RID: 19467
	EnergyMax,
	// Token: 0x04004C0C RID: 19468
	Energy,
	// Token: 0x04004C0D RID: 19469
	SpecialEnergy1Max,
	// Token: 0x04004C0E RID: 19470
	SpecialEnergy1,
	// Token: 0x04004C0F RID: 19471
	SpecialEnergy2Max,
	// Token: 0x04004C10 RID: 19472
	SpecialEnergy2,
	// Token: 0x04004C11 RID: 19473
	SpecialEnergy3Max,
	// Token: 0x04004C12 RID: 19474
	SpecialEnergy3,
	// Token: 0x04004C13 RID: 19475
	SpecialEnergy4Max,
	// Token: 0x04004C14 RID: 19476
	SpecialEnergy4,
	// Token: 0x04004C15 RID: 19477
	StrengthMax,
	// Token: 0x04004C16 RID: 19478
	Strength,
	// Token: 0x04004C17 RID: 19479
	StrengthRecover,
	// Token: 0x04004C18 RID: 19480
	StrengthPunishTime,
	// Token: 0x04004C19 RID: 19481
	StrengthRun,
	// Token: 0x04004C1A RID: 19482
	StrengthSwim,
	// Token: 0x04004C1B RID: 19483
	StrengthFastSwim,
	// Token: 0x04004C1C RID: 19484
	StrengthClimb,
	// Token: 0x04004C1D RID: 19485
	StrengthFastClimb,
	// Token: 0x04004C1E RID: 19486
	HardnessMax,
	// Token: 0x04004C1F RID: 19487
	Hardness,
	// Token: 0x04004C20 RID: 19488
	HardnessRecover,
	// Token: 0x04004C21 RID: 19489
	HardnessPunishTime,
	// Token: 0x04004C22 RID: 19490
	HardnessChange,
	// Token: 0x04004C23 RID: 19491
	HardnessReduce,
	// Token: 0x04004C24 RID: 19492
	ToughMax,
	// Token: 0x04004C25 RID: 19493
	Tough,
	// Token: 0x04004C26 RID: 19494
	ToughRecover,
	// Token: 0x04004C27 RID: 19495
	ToughChange,
	// Token: 0x04004C28 RID: 19496
	ToughReduce,
	// Token: 0x04004C29 RID: 19497
	ElementPower1,
	// Token: 0x04004C2A RID: 19498
	ElementPower2,
	// Token: 0x04004C2B RID: 19499
	ElementPower3,
	// Token: 0x04004C2C RID: 19500
	ElementPower4,
	// Token: 0x04004C2D RID: 19501
	ElementPower5,
	// Token: 0x04004C2E RID: 19502
	ElementPower6,
	// Token: 0x04004C2F RID: 19503
	SpecialDamageChange,
	// Token: 0x04004C30 RID: 19504
	StrengthFastClimbCost,
	// Token: 0x04004C31 RID: 19505
	ElementPropertyType,
	// Token: 0x04004C32 RID: 19506
	WeakTime,
	// Token: 0x04004C33 RID: 19507
	IgnoreDefRate,
	// Token: 0x04004C34 RID: 19508
	IgnoreDamageResistancePhys,
	// Token: 0x04004C35 RID: 19509
	IgnoreDamageResistanceElement1,
	// Token: 0x04004C36 RID: 19510
	IgnoreDamageResistanceElement2,
	// Token: 0x04004C37 RID: 19511
	IgnoreDamageResistanceElement3,
	// Token: 0x04004C38 RID: 19512
	IgnoreDamageResistanceElement4,
	// Token: 0x04004C39 RID: 19513
	IgnoreDamageResistanceElement5,
	// Token: 0x04004C3A RID: 19514
	IgnoreDamageResistanceElement6,
	// Token: 0x04004C3B RID: 19515
	SkillToughRatio,
	// Token: 0x04004C3C RID: 19516
	StrengthClimbJump,
	// Token: 0x04004C3D RID: 19517
	StrengthGliding,
	// Token: 0x04004C3E RID: 19518
	Mass,
	// Token: 0x04004C3F RID: 19519
	BrakingFrictionFactor,
	// Token: 0x04004C40 RID: 19520
	GravityScale,
	// Token: 0x04004C41 RID: 19521
	SpeedRatio,
	// Token: 0x04004C42 RID: 19522
	DamageChangePhantom,
	// Token: 0x04004C43 RID: 19523
	AutoAttackSpeed,
	// Token: 0x04004C44 RID: 19524
	CastAttackSpeed,
	// Token: 0x04004C45 RID: 19525
	RageMax = 127,
	// Token: 0x04004C46 RID: 19526
	Rage,
	// Token: 0x04004C47 RID: 19527
	RageRecover,
	// Token: 0x04004C48 RID: 19528
	RagePunishTime,
	// Token: 0x04004C49 RID: 19529
	RageChange,
	// Token: 0x04004C4A RID: 19530
	RageReduce,
	// Token: 0x04004C4B RID: 19531
	ToughRecoverDelayTime,
	// Token: 0x04004C4C RID: 19532
	GreenLv = 10001,
	// Token: 0x04004C4D RID: 19533
	GreenLifeMax,
	// Token: 0x04004C4E RID: 19534
	GreenLife,
	// Token: 0x04004C4F RID: 19535
	GreenSheild,
	// Token: 0x04004C50 RID: 19536
	GreenSheildDamageChange,
	// Token: 0x04004C51 RID: 19537
	GreenSheildDamageReduce,
	// Token: 0x04004C52 RID: 19538
	GreenAtk,
	// Token: 0x04004C53 RID: 19539
	GreenCrit,
	// Token: 0x04004C54 RID: 19540
	GreenCritDamage,
	// Token: 0x04004C55 RID: 19541
	GreenDef,
	// Token: 0x04004C56 RID: 19542
	GreenEnergyEfficiency,
	// Token: 0x04004C57 RID: 19543
	GreenCDReduse,
	// Token: 0x04004C58 RID: 19544
	GreenReactionEfficiency,
	// Token: 0x04004C59 RID: 19545
	GreenDamageChangeNormalSkill,
	// Token: 0x04004C5A RID: 19546
	GreenDamageChange,
	// Token: 0x04004C5B RID: 19547
	GreenDamageReduce,
	// Token: 0x04004C5C RID: 19548
	GreenDamageChangeAuto,
	// Token: 0x04004C5D RID: 19549
	GreenDamageChangeCast,
	// Token: 0x04004C5E RID: 19550
	GreenDamageChangeUltra,
	// Token: 0x04004C5F RID: 19551
	GreenDamageChangeQTE,
	// Token: 0x04004C60 RID: 19552
	GreenDamageChangePhys,
	// Token: 0x04004C61 RID: 19553
	GreenDamageChangeElement1,
	// Token: 0x04004C62 RID: 19554
	GreenDamageChangeElement2,
	// Token: 0x04004C63 RID: 19555
	GreenDamageChangeElement3,
	// Token: 0x04004C64 RID: 19556
	GreenDamageChangeElement4,
	// Token: 0x04004C65 RID: 19557
	GreenDamageChangeElement5,
	// Token: 0x04004C66 RID: 19558
	GreenDamageChangeElement6,
	// Token: 0x04004C67 RID: 19559
	GreenDamageResistancePhys,
	// Token: 0x04004C68 RID: 19560
	GreenDamageResistanceElement1,
	// Token: 0x04004C69 RID: 19561
	GreenDamageResistanceElement2,
	// Token: 0x04004C6A RID: 19562
	GreenDamageResistanceElement3,
	// Token: 0x04004C6B RID: 19563
	GreenDamageResistanceElement4,
	// Token: 0x04004C6C RID: 19564
	GreenDamageResistanceElement5,
	// Token: 0x04004C6D RID: 19565
	GreenDamageResistanceElement6,
	// Token: 0x04004C6E RID: 19566
	GreenHealChange,
	// Token: 0x04004C6F RID: 19567
	GreenHealedChange,
	// Token: 0x04004C70 RID: 19568
	GreenDamageReducePhys,
	// Token: 0x04004C71 RID: 19569
	GreenDamageReduceElement1,
	// Token: 0x04004C72 RID: 19570
	GreenDamageReduceElement2,
	// Token: 0x04004C73 RID: 19571
	GreenDamageReduceElement3,
	// Token: 0x04004C74 RID: 19572
	GreenDamageReduceElement4,
	// Token: 0x04004C75 RID: 19573
	GreenDamageReduceElement5,
	// Token: 0x04004C76 RID: 19574
	GreenDamageReduceElement6,
	// Token: 0x04004C77 RID: 19575
	GreenSpecialEnergy5Max,
	// Token: 0x04004C78 RID: 19576
	GreenSpecialEnergy5,
	// Token: 0x04004C79 RID: 19577
	GreenReactionChange3,
	// Token: 0x04004C7A RID: 19578
	GreenReactionChange4,
	// Token: 0x04004C7B RID: 19579
	GreenReactionChange5,
	// Token: 0x04004C7C RID: 19580
	GreenReactionChange6,
	// Token: 0x04004C7D RID: 19581
	GreenReactionChange7,
	// Token: 0x04004C7E RID: 19582
	GreenReactionChange8,
	// Token: 0x04004C7F RID: 19583
	GreenReactionChange9,
	// Token: 0x04004C80 RID: 19584
	GreenReactionChange10,
	// Token: 0x04004C81 RID: 19585
	GreenReactionChange11,
	// Token: 0x04004C82 RID: 19586
	GreenReactionChange12,
	// Token: 0x04004C83 RID: 19587
	GreenReactionChange13,
	// Token: 0x04004C84 RID: 19588
	GreenReactionChange14,
	// Token: 0x04004C85 RID: 19589
	GreenReactionChange15,
	// Token: 0x04004C86 RID: 19590
	GreenEnergyMax,
	// Token: 0x04004C87 RID: 19591
	GreenEnergy,
	// Token: 0x04004C88 RID: 19592
	GreenSpecialEnergy1Max,
	// Token: 0x04004C89 RID: 19593
	GreenSpecialEnergy1,
	// Token: 0x04004C8A RID: 19594
	GreenSpecialEnergy2Max,
	// Token: 0x04004C8B RID: 19595
	GreenSpecialEnergy2,
	// Token: 0x04004C8C RID: 19596
	GreenSpecialEnergy3Max,
	// Token: 0x04004C8D RID: 19597
	GreenSpecialEnergy3,
	// Token: 0x04004C8E RID: 19598
	GreenSpecialEnergy4Max,
	// Token: 0x04004C8F RID: 19599
	GreenSpecialEnergy4,
	// Token: 0x04004C90 RID: 19600
	GreenStrengthMax,
	// Token: 0x04004C91 RID: 19601
	GreenStrength,
	// Token: 0x04004C92 RID: 19602
	GreenStrengthRecover,
	// Token: 0x04004C93 RID: 19603
	GreenStrengthPunishTime,
	// Token: 0x04004C94 RID: 19604
	GreenStrengthRun,
	// Token: 0x04004C95 RID: 19605
	GreenStrengthSwim,
	// Token: 0x04004C96 RID: 19606
	GreenStrengthFastSwim,
	// Token: 0x04004C97 RID: 19607
	GreenStrengthClimb,
	// Token: 0x04004C98 RID: 19608
	GreenStrengthFastClimb,
	// Token: 0x04004C99 RID: 19609
	GreenHardnessMax,
	// Token: 0x04004C9A RID: 19610
	GreenHardness,
	// Token: 0x04004C9B RID: 19611
	GreenHardnessRecover,
	// Token: 0x04004C9C RID: 19612
	GreenHardnessPunishTime,
	// Token: 0x04004C9D RID: 19613
	GreenHardnessChange,
	// Token: 0x04004C9E RID: 19614
	GreenHardnessReduce,
	// Token: 0x04004C9F RID: 19615
	GreenToughMax,
	// Token: 0x04004CA0 RID: 19616
	GreenTough,
	// Token: 0x04004CA1 RID: 19617
	GreenToughRecover,
	// Token: 0x04004CA2 RID: 19618
	GreenToughChange,
	// Token: 0x04004CA3 RID: 19619
	GreenToughReduce,
	// Token: 0x04004CA4 RID: 19620
	GreenElementPower1,
	// Token: 0x04004CA5 RID: 19621
	GreenElementPower2,
	// Token: 0x04004CA6 RID: 19622
	GreenElementPower3,
	// Token: 0x04004CA7 RID: 19623
	GreenElementPower4,
	// Token: 0x04004CA8 RID: 19624
	GreenElementPower5,
	// Token: 0x04004CA9 RID: 19625
	GreenElementPower6,
	// Token: 0x04004CAA RID: 19626
	GreenSpecialDamageChange,
	// Token: 0x04004CAB RID: 19627
	GreenStrengthFastClimbCost,
	// Token: 0x04004CAC RID: 19628
	GreenElementPropertyType,
	// Token: 0x04004CAD RID: 19629
	GreenWeakTime,
	// Token: 0x04004CAE RID: 19630
	GreenIgnoreDefRate,
	// Token: 0x04004CAF RID: 19631
	GreenIgnoreDamageResistancePhys,
	// Token: 0x04004CB0 RID: 19632
	GreenIgnoreDamageResistanceElement1,
	// Token: 0x04004CB1 RID: 19633
	GreenIgnoreDamageResistanceElement2,
	// Token: 0x04004CB2 RID: 19634
	GreenIgnoreDamageResistanceElement3,
	// Token: 0x04004CB3 RID: 19635
	GreenIgnoreDamageResistanceElement4,
	// Token: 0x04004CB4 RID: 19636
	GreenIgnoreDamageResistanceElement5,
	// Token: 0x04004CB5 RID: 19637
	GreenIgnoreDamageResistanceElement6,
	// Token: 0x04004CB6 RID: 19638
	GreenSkillToughRatio,
	// Token: 0x04004CB7 RID: 19639
	GreenStrengthClimbJump,
	// Token: 0x04004CB8 RID: 19640
	GreenStrengthGliding,
	// Token: 0x04004CB9 RID: 19641
	GreenMass,
	// Token: 0x04004CBA RID: 19642
	GreenBrakingFrictionFactor,
	// Token: 0x04004CBB RID: 19643
	GreenGravityScale,
	// Token: 0x04004CBC RID: 19644
	GreenSpeedRatio,
	// Token: 0x04004CBD RID: 19645
	GreenDamageChangePhantom,
	// Token: 0x04004CBE RID: 19646
	GreenAutoAttackSpeed,
	// Token: 0x04004CBF RID: 19647
	GreenCastAttackSpeed,
	// Token: 0x04004CC0 RID: 19648
	GreenRageMax = 10127,
	// Token: 0x04004CC1 RID: 19649
	GreenRage,
	// Token: 0x04004CC2 RID: 19650
	GreenRageRecover,
	// Token: 0x04004CC3 RID: 19651
	GreenRagePunishTime,
	// Token: 0x04004CC4 RID: 19652
	GreenRageChange,
	// Token: 0x04004CC5 RID: 19653
	GreenRageReduce,
	// Token: 0x04004CC6 RID: 19654
	GreenToughRecoverDelayTime
}
