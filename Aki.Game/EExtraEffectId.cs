using System;

// Token: 0x02002F00 RID: 12032
public enum EExtraEffectId
{
	// Token: 0x0400C0DE RID: 49374
	ModifySnapshotBeforeCalculation = 1,
	// Token: 0x0400C0DF RID: 49375
	AddBuff,
	// Token: 0x0400C0E0 RID: 49376
	AddBullet,
	// Token: 0x0400C0E1 RID: 49377
	ModifyLife,
	// Token: 0x0400C0E2 RID: 49378
	PeriodicExtraEffect,
	// Token: 0x0400C0E3 RID: 49379
	AttributeEventEffect,
	// Token: 0x0400C0E4 RID: 49380
	SkillLimitCount,
	// Token: 0x0400C0E5 RID: 49381
	LevelBuff,
	// Token: 0x0400C0E6 RID: 49382
	DamageAugment,
	// Token: 0x0400C0E7 RID: 49383
	Control,
	// Token: 0x0400C0E8 RID: 49384
	ApplyShield,
	// Token: 0x0400C0E9 RID: 49385
	DamageModify,
	// Token: 0x0400C0EA RID: 49386
	ReduceCd,
	// Token: 0x0400C0EB RID: 49387
	LockValue,
	// Token: 0x0400C0EC RID: 49388
	LockUpperBound,
	// Token: 0x0400C0ED RID: 49389
	LockLowerBound,
	// Token: 0x0400C0EE RID: 49390
	SetTimeScale,
	// Token: 0x0400C0EF RID: 49391
	ShareDamage,
	// Token: 0x0400C0F0 RID: 49392
	DamageAccumulation,
	// Token: 0x0400C0F1 RID: 49393
	DamageImmune,
	// Token: 0x0400C0F2 RID: 49394
	RemoveBuff,
	// Token: 0x0400C0F3 RID: 49395
	DamageFilter,
	// Token: 0x0400C0F4 RID: 49396
	AddBuffToAdjacentRole = 24,
	// Token: 0x0400C0F5 RID: 49397
	AddBuffOnChangeTeam,
	// Token: 0x0400C0F6 RID: 49398
	ExtendBuffDuration,
	// Token: 0x0400C0F7 RID: 49399
	ReplaceSnapshotBeforeCalculation,
	// Token: 0x0400C0F8 RID: 49400
	AddBuffInstantByStackCount,
	// Token: 0x0400C0F9 RID: 49401
	AddBulletInstantByStackCount,
	// Token: 0x0400C0FA RID: 49402
	PhantomAssist,
	// Token: 0x0400C0FB RID: 49403
	SetFormationAttributeRate,
	// Token: 0x0400C0FC RID: 49404
	ModifyFormationAttributeIncreaseRate,
	// Token: 0x0400C0FD RID: 49405
	ModifyFormationAttributeDecreaseRate,
	// Token: 0x0400C0FE RID: 49406
	ModifyFormationAttribute,
	// Token: 0x0400C0FF RID: 49407
	AddPassiveSkill,
	// Token: 0x0400C100 RID: 49408
	Frozen,
	// Token: 0x0400C101 RID: 49409
	DamageAmplifyOnHit,
	// Token: 0x0400C102 RID: 49410
	DamageAmplifyOnBeHit,
	// Token: 0x0400C103 RID: 49411
	AddBuffToVision = 41,
	// Token: 0x0400C104 RID: 49412
	RemoveSelfByTag = 43,
	// Token: 0x0400C105 RID: 49413
	ModifyToughReduce,
	// Token: 0x0400C106 RID: 49414
	ShieldCovertAttribute,
	// Token: 0x0400C107 RID: 49415
	ShieldModifySnapshot,
	// Token: 0x0400C108 RID: 49416
	ModifyCd = 49,
	// Token: 0x0400C109 RID: 49417
	FormationLockUpperBound,
	// Token: 0x0400C10A RID: 49418
	FormationLockLowerBound,
	// Token: 0x0400C10B RID: 49419
	QteExecution,
	// Token: 0x0400C10C RID: 49420
	BindBuffToTeam,
	// Token: 0x0400C10D RID: 49421
	AttributeConvert = 55,
	// Token: 0x0400C10E RID: 49422
	GetBuffByStackCountOnRemoved = 57,
	// Token: 0x0400C10F RID: 49423
	PeriodAddBuffToAdjacentEntity,
	// Token: 0x0400C110 RID: 49424
	DestroyBullet,
	// Token: 0x0400C111 RID: 49425
	ModifyBuffDurationOrPeriod,
	// Token: 0x0400C112 RID: 49426
	ModifyFormationAttributeMax = 62,
	// Token: 0x0400C113 RID: 49427
	ModifyDamageElement,
	// Token: 0x0400C114 RID: 49428
	ConvertBuffToAnother = 65,
	// Token: 0x0400C115 RID: 49429
	InvokePeriod = 67,
	// Token: 0x0400C116 RID: 49430
	ModifyBuffDurationOrPeriodByInstigator,
	// Token: 0x0400C117 RID: 49431
	StartBattleQte,
	// Token: 0x0400C118 RID: 49432
	ModifyBuffStack,
	// Token: 0x0400C119 RID: 49433
	AddSkillLimitCount,
	// Token: 0x0400C11A RID: 49434
	AdditionBulletSize,
	// Token: 0x0400C11B RID: 49435
	AdditionBulletDuration,
	// Token: 0x0400C11C RID: 49436
	AdditionBulletInterval,
	// Token: 0x0400C11D RID: 49437
	AddBulletInstantByTagStackCount,
	// Token: 0x0400C11E RID: 49438
	AddBattleFlag,
	// Token: 0x0400C11F RID: 49439
	DamageTransferRecipients,
	// Token: 0x0400C120 RID: 49440
	ChangeBuffStackCount = 79,
	// Token: 0x0400C121 RID: 49441
	BuffCopy,
	// Token: 0x0400C122 RID: 49442
	BuffOverStackCompensation,
	// Token: 0x0400C123 RID: 49443
	BuffTransfer,
	// Token: 0x0400C124 RID: 49444
	SetForeverTimeScale,
	// Token: 0x0400C125 RID: 49445
	[Obsolete]
	ModifyFuLuoLuoSpecialEnergy,
	// Token: 0x0400C126 RID: 49446
	SyncTimeScaleEffect,
	// Token: 0x0400C127 RID: 49447
	SpecialEnergyModifier = 87,
	// Token: 0x0400C128 RID: 49448
	ModifySlotSpecialEnergy,
	// Token: 0x0400C129 RID: 49449
	SyncGameplayCue,
	// Token: 0x0400C12A RID: 49450
	ModifyTeamMemberBuff,
	// Token: 0x0400C12B RID: 49451
	BindBuffToVehicle,
	// Token: 0x0400C12C RID: 49452
	AddSkillLevel = 93,
	// Token: 0x0400C12D RID: 49453
	ModifySquadProp = 96,
	// Token: 0x0400C12E RID: 49454
	ReviveExecution = 101,
	// Token: 0x0400C12F RID: 49455
	AddEnergy,
	// Token: 0x0400C130 RID: 49456
	ModifyBuffTimeScale,
	// Token: 0x0400C131 RID: 49457
	RemoveBuffByFilter,
	// Token: 0x0400C132 RID: 49458
	BuffMapper = 106,
	// Token: 0x0400C133 RID: 49459
	DynamicModifyBuffStack = 108,
	// Token: 0x0400C134 RID: 49460
	AdjacentBuffStackToEffect = 123,
	// Token: 0x0400C135 RID: 49461
	ReplaceBuffOnAdd = 129,
	// Token: 0x0400C136 RID: 49462
	SyncMaxStackFromAnotherBuff,
	// Token: 0x0400C137 RID: 49463
	ReplaceAbnormalCue,
	// Token: 0x0400C138 RID: 49464
	ModifyPassiveSkillProbability,
	// Token: 0x0400C139 RID: 49465
	BindBuffStackToProp = 137,
	// Token: 0x0400C13A RID: 49466
	AbnormalWind = 1001,
	// Token: 0x0400C13B RID: 49467
	AbnormalThunder,
	// Token: 0x0400C13C RID: 49468
	AbnormalIce,
	// Token: 0x0400C13D RID: 49469
	AbnormalFire,
	// Token: 0x0400C13E RID: 49470
	AbnormalLight,
	// Token: 0x0400C13F RID: 49471
	AbnormalDark,
	// Token: 0x0400C140 RID: 49472
	PreventReduceStack = 1101,
	// Token: 0x0400C141 RID: 49473
	ConvertAbnormalLight
}
