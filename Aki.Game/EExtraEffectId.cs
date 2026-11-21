using System;

// Token: 0x02002453 RID: 9299
public enum EExtraEffectId
{
	// Token: 0x0400C47F RID: 50303
	ModifySnapshotBeforeCalculation = 1,
	// Token: 0x0400C480 RID: 50304
	AddBuff,
	// Token: 0x0400C481 RID: 50305
	AddBullet,
	// Token: 0x0400C482 RID: 50306
	ModifyLife,
	// Token: 0x0400C483 RID: 50307
	PeriodicExtraEffect,
	// Token: 0x0400C484 RID: 50308
	AttributeEventEffect,
	// Token: 0x0400C485 RID: 50309
	SkillLimitCount,
	// Token: 0x0400C486 RID: 50310
	LevelBuff,
	// Token: 0x0400C487 RID: 50311
	DamageAugment,
	// Token: 0x0400C488 RID: 50312
	Control,
	// Token: 0x0400C489 RID: 50313
	ApplyShield,
	// Token: 0x0400C48A RID: 50314
	DamageModify,
	// Token: 0x0400C48B RID: 50315
	ReduceCd,
	// Token: 0x0400C48C RID: 50316
	LockValue,
	// Token: 0x0400C48D RID: 50317
	LockUpperBound,
	// Token: 0x0400C48E RID: 50318
	LockLowerBound,
	// Token: 0x0400C48F RID: 50319
	SetTimeScale,
	// Token: 0x0400C490 RID: 50320
	ShareDamage,
	// Token: 0x0400C491 RID: 50321
	DamageAccumulation,
	// Token: 0x0400C492 RID: 50322
	DamageImmune,
	// Token: 0x0400C493 RID: 50323
	RemoveBuff,
	// Token: 0x0400C494 RID: 50324
	DamageFilter,
	// Token: 0x0400C495 RID: 50325
	AddBuffToAdjacentRole = 24,
	// Token: 0x0400C496 RID: 50326
	AddBuffOnChangeTeam,
	// Token: 0x0400C497 RID: 50327
	ExtendBuffDuration,
	// Token: 0x0400C498 RID: 50328
	ReplaceSnapshotBeforeCalculation,
	// Token: 0x0400C499 RID: 50329
	AddBuffInstantByStackCount,
	// Token: 0x0400C49A RID: 50330
	AddBulletInstantByStackCount,
	// Token: 0x0400C49B RID: 50331
	PhantomAssist,
	// Token: 0x0400C49C RID: 50332
	SetFormationAttributeRate,
	// Token: 0x0400C49D RID: 50333
	ModifyFormationAttributeIncreaseRate,
	// Token: 0x0400C49E RID: 50334
	ModifyFormationAttributeDecreaseRate,
	// Token: 0x0400C49F RID: 50335
	ModifyFormationAttribute,
	// Token: 0x0400C4A0 RID: 50336
	AddPassiveSkill,
	// Token: 0x0400C4A1 RID: 50337
	Frozen,
	// Token: 0x0400C4A2 RID: 50338
	DamageAmplifyOnHit,
	// Token: 0x0400C4A3 RID: 50339
	DamageAmplifyOnBeHit,
	// Token: 0x0400C4A4 RID: 50340
	AddBuffToVision = 41,
	// Token: 0x0400C4A5 RID: 50341
	RemoveSelfByTag = 43,
	// Token: 0x0400C4A6 RID: 50342
	ModifyToughReduce,
	// Token: 0x0400C4A7 RID: 50343
	ShieldCovertAttribute,
	// Token: 0x0400C4A8 RID: 50344
	ShieldModifySnapshot,
	// Token: 0x0400C4A9 RID: 50345
	ModifyCd = 49,
	// Token: 0x0400C4AA RID: 50346
	FormationLockUpperBound,
	// Token: 0x0400C4AB RID: 50347
	FormationLockLowerBound,
	// Token: 0x0400C4AC RID: 50348
	QteExecution,
	// Token: 0x0400C4AD RID: 50349
	BindBuffToTeam,
	// Token: 0x0400C4AE RID: 50350
	AttributeConvert = 55,
	// Token: 0x0400C4AF RID: 50351
	GetBuffByStackCountOnRemoved = 57,
	// Token: 0x0400C4B0 RID: 50352
	PeriodAddBuffToAdjacentEntity,
	// Token: 0x0400C4B1 RID: 50353
	DestroyBullet,
	// Token: 0x0400C4B2 RID: 50354
	ModifyBuffDurationOrPeriod,
	// Token: 0x0400C4B3 RID: 50355
	ModifyFormationAttributeMax = 62,
	// Token: 0x0400C4B4 RID: 50356
	ModifyDamageElement,
	// Token: 0x0400C4B5 RID: 50357
	ConvertBuffToAnother = 65,
	// Token: 0x0400C4B6 RID: 50358
	InvokePeriod = 67,
	// Token: 0x0400C4B7 RID: 50359
	ModifyBuffDurationOrPeriodByInstigator,
	// Token: 0x0400C4B8 RID: 50360
	StartBattleQte,
	// Token: 0x0400C4B9 RID: 50361
	ModifyBuffStack,
	// Token: 0x0400C4BA RID: 50362
	AddSkillLimitCount,
	// Token: 0x0400C4BB RID: 50363
	AdditionBulletSize,
	// Token: 0x0400C4BC RID: 50364
	AdditionBulletDuration,
	// Token: 0x0400C4BD RID: 50365
	AdditionBulletInterval,
	// Token: 0x0400C4BE RID: 50366
	AddBulletInstantByTagStackCount,
	// Token: 0x0400C4BF RID: 50367
	AddBattleFlag,
	// Token: 0x0400C4C0 RID: 50368
	DamageTransferRecipients,
	// Token: 0x0400C4C1 RID: 50369
	ChangeBuffStackCount = 79,
	// Token: 0x0400C4C2 RID: 50370
	BuffCopy,
	// Token: 0x0400C4C3 RID: 50371
	BuffOverStackCompensation,
	// Token: 0x0400C4C4 RID: 50372
	BuffTransfer,
	// Token: 0x0400C4C5 RID: 50373
	SetForeverTimeScale,
	// Token: 0x0400C4C6 RID: 50374
	[Obsolete]
	ModifyFuLuoLuoSpecialEnergy,
	// Token: 0x0400C4C7 RID: 50375
	SyncTimeScaleEffect,
	// Token: 0x0400C4C8 RID: 50376
	SpecialEnergyModifier = 87,
	// Token: 0x0400C4C9 RID: 50377
	ModifySlotSpecialEnergy,
	// Token: 0x0400C4CA RID: 50378
	SyncGameplayCue,
	// Token: 0x0400C4CB RID: 50379
	ModifyTeamMemberBuff,
	// Token: 0x0400C4CC RID: 50380
	BindBuffToVehicle,
	// Token: 0x0400C4CD RID: 50381
	AddSkillLevel = 93,
	// Token: 0x0400C4CE RID: 50382
	ModifySquadProp = 96,
	// Token: 0x0400C4CF RID: 50383
	ReviveExecution = 101,
	// Token: 0x0400C4D0 RID: 50384
	AddEnergy,
	// Token: 0x0400C4D1 RID: 50385
	ModifyBuffTimeScale,
	// Token: 0x0400C4D2 RID: 50386
	RemoveBuffByFilter,
	// Token: 0x0400C4D3 RID: 50387
	BuffMapper = 106,
	// Token: 0x0400C4D4 RID: 50388
	DynamicModifyBuffStack = 108,
	// Token: 0x0400C4D5 RID: 50389
	AdjacentBuffStackToEffect = 123,
	// Token: 0x0400C4D6 RID: 50390
	ReplaceBuffOnAdd = 129,
	// Token: 0x0400C4D7 RID: 50391
	SyncMaxStackFromAnotherBuff,
	// Token: 0x0400C4D8 RID: 50392
	ReplaceAbnormalCue,
	// Token: 0x0400C4D9 RID: 50393
	ModifyPassiveSkillProbability,
	// Token: 0x0400C4DA RID: 50394
	RecordAndRestoreState = 134,
	// Token: 0x0400C4DB RID: 50395
	BindBuffStackToProp = 137,
	// Token: 0x0400C4DC RID: 50396
	AbnormalWind = 1001,
	// Token: 0x0400C4DD RID: 50397
	AbnormalThunder,
	// Token: 0x0400C4DE RID: 50398
	AbnormalIce,
	// Token: 0x0400C4DF RID: 50399
	AbnormalFire,
	// Token: 0x0400C4E0 RID: 50400
	AbnormalLight,
	// Token: 0x0400C4E1 RID: 50401
	AbnormalDark,
	// Token: 0x0400C4E2 RID: 50402
	PreventReduceStack = 1101,
	// Token: 0x0400C4E3 RID: 50403
	ConvertAbnormalLight
}
