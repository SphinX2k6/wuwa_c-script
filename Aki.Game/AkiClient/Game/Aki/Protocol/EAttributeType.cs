using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace AkiClient.Game.Aki.Protocol
{
	// Token: 0x02003E42 RID: 15938
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Game/Aki/Protocol/EAttributeType.EAttributeType")]
	public enum EAttributeType : byte
	{
		// Token: 0x04014581 RID: 83329
		EAttributeType_None,
		// Token: 0x04014582 RID: 83330
		Lv,
		// Token: 0x04014583 RID: 83331
		LifeMax,
		// Token: 0x04014584 RID: 83332
		Life,
		// Token: 0x04014585 RID: 83333
		Sheild,
		// Token: 0x04014586 RID: 83334
		SheildDamageChange,
		// Token: 0x04014587 RID: 83335
		SheildDamageReduce,
		// Token: 0x04014588 RID: 83336
		Atk,
		// Token: 0x04014589 RID: 83337
		Crit,
		// Token: 0x0401458A RID: 83338
		CritDamage,
		// Token: 0x0401458B RID: 83339
		Def,
		// Token: 0x0401458C RID: 83340
		EnergyEfficiency,
		// Token: 0x0401458D RID: 83341
		CDReduse,
		// Token: 0x0401458E RID: 83342
		ReactionEfficiency,
		// Token: 0x0401458F RID: 83343
		DamageChangeNormalSkill,
		// Token: 0x04014590 RID: 83344
		DamageChange,
		// Token: 0x04014591 RID: 83345
		DamageReduce,
		// Token: 0x04014592 RID: 83346
		DamageChangeAuto,
		// Token: 0x04014593 RID: 83347
		DamageChangeCast,
		// Token: 0x04014594 RID: 83348
		DamageChangeUltra,
		// Token: 0x04014595 RID: 83349
		DamageChangeQTE,
		// Token: 0x04014596 RID: 83350
		DamageChangePhys,
		// Token: 0x04014597 RID: 83351
		DamageChangeElement1,
		// Token: 0x04014598 RID: 83352
		DamageChangeElement2,
		// Token: 0x04014599 RID: 83353
		DamageChangeElement3,
		// Token: 0x0401459A RID: 83354
		DamageChangeElement4,
		// Token: 0x0401459B RID: 83355
		DamageChangeElement5,
		// Token: 0x0401459C RID: 83356
		DamageChangeElement6,
		// Token: 0x0401459D RID: 83357
		DamageResistancePhys,
		// Token: 0x0401459E RID: 83358
		DamageResistanceElement1,
		// Token: 0x0401459F RID: 83359
		DamageResistanceElement2,
		// Token: 0x040145A0 RID: 83360
		DamageResistanceElement3,
		// Token: 0x040145A1 RID: 83361
		DamageResistanceElement4,
		// Token: 0x040145A2 RID: 83362
		DamageResistanceElement5,
		// Token: 0x040145A3 RID: 83363
		DamageResistanceElement6,
		// Token: 0x040145A4 RID: 83364
		HealChange,
		// Token: 0x040145A5 RID: 83365
		HealedChange,
		// Token: 0x040145A6 RID: 83366
		DamageReducePhys,
		// Token: 0x040145A7 RID: 83367
		DamageReduceElement1,
		// Token: 0x040145A8 RID: 83368
		DamageReduceElement2,
		// Token: 0x040145A9 RID: 83369
		DamageReduceElement3,
		// Token: 0x040145AA RID: 83370
		DamageReduceElement4,
		// Token: 0x040145AB RID: 83371
		DamageReduceElement5,
		// Token: 0x040145AC RID: 83372
		DamageReduceElement6,
		// Token: 0x040145AD RID: 83373
		ReactionChange1,
		// Token: 0x040145AE RID: 83374
		ReactionChange2,
		// Token: 0x040145AF RID: 83375
		ReactionChange3,
		// Token: 0x040145B0 RID: 83376
		ReactionChange4,
		// Token: 0x040145B1 RID: 83377
		ReactionChange5,
		// Token: 0x040145B2 RID: 83378
		ReactionChange6,
		// Token: 0x040145B3 RID: 83379
		ReactionChange7,
		// Token: 0x040145B4 RID: 83380
		ReactionChange8,
		// Token: 0x040145B5 RID: 83381
		ReactionChange9,
		// Token: 0x040145B6 RID: 83382
		ReactionChange10,
		// Token: 0x040145B7 RID: 83383
		ReactionChange11,
		// Token: 0x040145B8 RID: 83384
		ReactionChange12,
		// Token: 0x040145B9 RID: 83385
		ReactionChange13,
		// Token: 0x040145BA RID: 83386
		ReactionChange14,
		// Token: 0x040145BB RID: 83387
		ReactionChange15,
		// Token: 0x040145BC RID: 83388
		EnergyMax,
		// Token: 0x040145BD RID: 83389
		Energy,
		// Token: 0x040145BE RID: 83390
		SpecialEnergy1Max,
		// Token: 0x040145BF RID: 83391
		SpecialEnergy1,
		// Token: 0x040145C0 RID: 83392
		SpecialEnergy2Max,
		// Token: 0x040145C1 RID: 83393
		SpecialEnergy2,
		// Token: 0x040145C2 RID: 83394
		SpecialEnergy3Max,
		// Token: 0x040145C3 RID: 83395
		SpecialEnergy3,
		// Token: 0x040145C4 RID: 83396
		SpecialEnergy4Max,
		// Token: 0x040145C5 RID: 83397
		SpecialEnergy4,
		// Token: 0x040145C6 RID: 83398
		StrengthMax,
		// Token: 0x040145C7 RID: 83399
		Strength,
		// Token: 0x040145C8 RID: 83400
		StrengthRecover,
		// Token: 0x040145C9 RID: 83401
		StrengthPunishTime,
		// Token: 0x040145CA RID: 83402
		StrengthRun,
		// Token: 0x040145CB RID: 83403
		StrengthSwim,
		// Token: 0x040145CC RID: 83404
		StrengthFastSwim,
		// Token: 0x040145CD RID: 83405
		StrengthClimb,
		// Token: 0x040145CE RID: 83406
		StrengthFastClimb,
		// Token: 0x040145CF RID: 83407
		HardnessMax,
		// Token: 0x040145D0 RID: 83408
		Hardness,
		// Token: 0x040145D1 RID: 83409
		HardnessRecover,
		// Token: 0x040145D2 RID: 83410
		HardnessPunishTime,
		// Token: 0x040145D3 RID: 83411
		HardnessChange,
		// Token: 0x040145D4 RID: 83412
		HardnessReduce,
		// Token: 0x040145D5 RID: 83413
		ToughMax,
		// Token: 0x040145D6 RID: 83414
		Tough,
		// Token: 0x040145D7 RID: 83415
		ToughRecover,
		// Token: 0x040145D8 RID: 83416
		ToughChange,
		// Token: 0x040145D9 RID: 83417
		ToughReduce,
		// Token: 0x040145DA RID: 83418
		ElementPower1,
		// Token: 0x040145DB RID: 83419
		ElementPower2,
		// Token: 0x040145DC RID: 83420
		ElementPower3,
		// Token: 0x040145DD RID: 83421
		ElementPower4,
		// Token: 0x040145DE RID: 83422
		ElementPower5,
		// Token: 0x040145DF RID: 83423
		ElementPower6,
		// Token: 0x040145E0 RID: 83424
		SpecialDamageChange,
		// Token: 0x040145E1 RID: 83425
		StrengthFastClimbCost,
		// Token: 0x040145E2 RID: 83426
		ElementPropertyType,
		// Token: 0x040145E3 RID: 83427
		WeakTime,
		// Token: 0x040145E4 RID: 83428
		IgnoreDefRate,
		// Token: 0x040145E5 RID: 83429
		IgnoreDamageResistancePhys,
		// Token: 0x040145E6 RID: 83430
		IgnoreDamageResistanceElement1,
		// Token: 0x040145E7 RID: 83431
		IgnoreDamageResistanceElement2,
		// Token: 0x040145E8 RID: 83432
		IgnoreDamageResistanceElement3,
		// Token: 0x040145E9 RID: 83433
		IgnoreDamageResistanceElement4,
		// Token: 0x040145EA RID: 83434
		IgnoreDamageResistanceElement5,
		// Token: 0x040145EB RID: 83435
		IgnoreDamageResistanceElement6,
		// Token: 0x040145EC RID: 83436
		SkillToughRatio,
		// Token: 0x040145ED RID: 83437
		StrengthClimbJump,
		// Token: 0x040145EE RID: 83438
		StrengthGliding,
		// Token: 0x040145EF RID: 83439
		Mass,
		// Token: 0x040145F0 RID: 83440
		BrakingFrictionFactor,
		// Token: 0x040145F1 RID: 83441
		GravityScale,
		// Token: 0x040145F2 RID: 83442
		SpeedRatio,
		// Token: 0x040145F3 RID: 83443
		DamageChangePhantom,
		// Token: 0x040145F4 RID: 83444
		AutoAttackSpeed,
		// Token: 0x040145F5 RID: 83445
		CastAttackSpeed,
		// Token: 0x040145F6 RID: 83446
		StatusBuildUp1Max,
		// Token: 0x040145F7 RID: 83447
		StatusBuildUp1,
		// Token: 0x040145F8 RID: 83448
		StatusBuildUp2Max,
		// Token: 0x040145F9 RID: 83449
		StatusBuildUp2,
		// Token: 0x040145FA RID: 83450
		StatusBuildUp3Max,
		// Token: 0x040145FB RID: 83451
		StatusBuildUp3,
		// Token: 0x040145FC RID: 83452
		StatusBuildUp4Max,
		// Token: 0x040145FD RID: 83453
		StatusBuildUp4,
		// Token: 0x040145FE RID: 83454
		StatusBuildUp5Max,
		// Token: 0x040145FF RID: 83455
		StatusBuildUp5,
		// Token: 0x04014600 RID: 83456
		RageMax,
		// Token: 0x04014601 RID: 83457
		Rage,
		// Token: 0x04014602 RID: 83458
		RageRecover,
		// Token: 0x04014603 RID: 83459
		RagePunishTime,
		// Token: 0x04014604 RID: 83460
		RageChange,
		// Token: 0x04014605 RID: 83461
		RageReduce,
		// Token: 0x04014606 RID: 83462
		ToughRecoverDelayTime,
		// Token: 0x04014607 RID: 83463
		Jump,
		// Token: 0x04014608 RID: 83464
		ParalysisTimeMax,
		// Token: 0x04014609 RID: 83465
		ParalysisTime,
		// Token: 0x0401460A RID: 83466
		ParalysisTimeRecover,
		// Token: 0x0401460B RID: 83467
		WeaknessBuildUp,
		// Token: 0x0401460C RID: 83468
		WeaknessBuildUpMax,
		// Token: 0x0401460D RID: 83469
		WeaknessTotalBonus,
		// Token: 0x0401460E RID: 83470
		BreakWeaknessRatio,
		// Token: 0x0401460F RID: 83471
		WeaknessMastery,
		// Token: 0x04014610 RID: 83472
		EAttributeType_MAX
	}
}
