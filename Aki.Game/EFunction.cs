using System;

// Token: 0x02000DC9 RID: 3529
public enum EFunction
{
	// Token: 0x040024D3 RID: 9427
	MASTERVOLUMEFUNCTION = 1,
	// Token: 0x040024D4 RID: 9428
	VOICEVOLUMEFUNCTION,
	// Token: 0x040024D5 RID: 9429
	MUSICVOLUMEFUNCTION,
	// Token: 0x040024D6 RID: 9430
	SFXVOLUMEFUNCTION,
	// Token: 0x040024D7 RID: 9431
	AMBVOLUMEFUNCTION = 69,
	// Token: 0x040024D8 RID: 9432
	UIVOLUMEFUNCTION,
	// Token: 0x040024D9 RID: 9433
	DOLBYATOMS = 76,
	// Token: 0x040024DA RID: 9434
	IMAGEQUALITY = 10,
	// Token: 0x040024DB RID: 9435
	DISPLAYMODE = 5,
	// Token: 0x040024DC RID: 9436
	RESOURCESTANDARD = 20070,
	// Token: 0x040024DD RID: 9437
	RESOLUTION = 6,
	// Token: 0x040024DE RID: 9438
	BRIGHTNESS,
	// Token: 0x040024DF RID: 9439
	HIGHESTFPS = 11,
	// Token: 0x040024E0 RID: 9440
	SHADOWQUALITY = 54,
	// Token: 0x040024E1 RID: 9441
	NIAGARAQUALITY,
	// Token: 0x040024E2 RID: 9442
	IMAGEDETAIL,
	// Token: 0x040024E3 RID: 9443
	ANTIALISING,
	// Token: 0x040024E4 RID: 9444
	SCENEAO,
	// Token: 0x040024E5 RID: 9445
	NPCDENSITY = 79,
	// Token: 0x040024E6 RID: 9446
	NVIDIADLSS = 81,
	// Token: 0x040024E7 RID: 9447
	NVIDIADLSSFG,
	// Token: 0x040024E8 RID: 9448
	NVIDIADLSSQUALITY = 831,
	// Token: 0x040024E9 RID: 9449
	NVIDIADLSSSHARPNESS = 84,
	// Token: 0x040024EA RID: 9450
	NVIDIAREFLEX,
	// Token: 0x040024EB RID: 9451
	HDR = 20305,
	// Token: 0x040024EC RID: 9452
	FSR = 87,
	// Token: 0x040024ED RID: 9453
	XESS = 125,
	// Token: 0x040024EE RID: 9454
	XESS_QUALITY,
	// Token: 0x040024EF RID: 9455
	XESS2 = 20310,
	// Token: 0x040024F0 RID: 9456
	XESS2_FG = 20341,
	// Token: 0x040024F1 RID: 9457
	XESS2_QUALITY = 20340,
	// Token: 0x040024F2 RID: 9458
	FSR3 = 20350,
	// Token: 0x040024F3 RID: 9459
	FSR3_FG = 20352,
	// Token: 0x040024F4 RID: 9460
	FSR3_QUALITY = 20351,
	// Token: 0x040024F5 RID: 9461
	METALFX = 127,
	// Token: 0x040024F6 RID: 9462
	IRX,
	// Token: 0x040024F7 RID: 9463
	BLOOM = 132,
	// Token: 0x040024F8 RID: 9464
	VOLUMEFOG = 63,
	// Token: 0x040024F9 RID: 9465
	VOLUMELIGHT,
	// Token: 0x040024FA RID: 9466
	MOTIONBLUR,
	// Token: 0x040024FB RID: 9467
	PCVSYNC,
	// Token: 0x040024FC RID: 9468
	MOBILERESOLUTION,
	// Token: 0x040024FD RID: 9469
	SUPERRESOLUTION,
	// Token: 0x040024FE RID: 9470
	LOADINGRANGESCALELEVEL = 20611,
	// Token: 0x040024FF RID: 9471
	TEXTLANGUAGE = 51,
	// Token: 0x04002500 RID: 9472
	VOICELANGUAGE,
	// Token: 0x04002501 RID: 9473
	VOICEPACKMANAGER,
	// Token: 0x04002502 RID: 9474
	VOICEROLECUSTOM = 40101,
	// Token: 0x04002503 RID: 9475
	ADVICESETTING = 59,
	// Token: 0x04002504 RID: 9476
	GENDERSETTING = 88,
	// Token: 0x04002505 RID: 9477
	HorizontalViewSensitivity,
	// Token: 0x04002506 RID: 9478
	VerticalViewSensitivity,
	// Token: 0x04002507 RID: 9479
	AimHorizontalViewSensitivity,
	// Token: 0x04002508 RID: 9480
	AimVerticalViewSensitivity,
	// Token: 0x04002509 RID: 9481
	CameraShakeStrength,
	// Token: 0x0400250A RID: 9482
	MobileHorizontalViewSensitivity,
	// Token: 0x0400250B RID: 9483
	MobileVerticalViewSensitivity,
	// Token: 0x0400250C RID: 9484
	MobileAimHorizontalViewSensitivity,
	// Token: 0x0400250D RID: 9485
	MobileAimVerticalViewSensitivity,
	// Token: 0x0400250E RID: 9486
	CommonSpringArmLength = 99,
	// Token: 0x0400250F RID: 9487
	FightSpringArmLength,
	// Token: 0x04002510 RID: 9488
	ResetFocusEnable,
	// Token: 0x04002511 RID: 9489
	IsSidestepCameraEnable,
	// Token: 0x04002512 RID: 9490
	IsSoftLockCameraEnable,
	// Token: 0x04002513 RID: 9491
	JoystickShakeStrength,
	// Token: 0x04002514 RID: 9492
	JoystickShakeType,
	// Token: 0x04002515 RID: 9493
	WalkOrRunRate,
	// Token: 0x04002516 RID: 9494
	LogUpload,
	// Token: 0x04002517 RID: 9495
	JoystickMode,
	// Token: 0x04002518 RID: 9496
	MobileButtonCustom = 86,
	// Token: 0x04002519 RID: 9497
	SkillButtonMode = 109,
	// Token: 0x0400251A RID: 9498
	CdKey = 112,
	// Token: 0x0400251B RID: 9499
	UserCenterDomestic,
	// Token: 0x0400251C RID: 9500
	TermsOfUseDomestic,
	// Token: 0x0400251D RID: 9501
	PrivacyPolicyDomestic,
	// Token: 0x0400251E RID: 9502
	ChildrenPrivacy,
	// Token: 0x0400251F RID: 9503
	ThirdPartyInfo,
	// Token: 0x04002520 RID: 9504
	TermsOfUseOverSeas,
	// Token: 0x04002521 RID: 9505
	PrivacyPolicyOverSeas,
	// Token: 0x04002522 RID: 9506
	PrivacyPolicySetting,
	// Token: 0x04002523 RID: 9507
	License = 146,
	// Token: 0x04002524 RID: 9508
	UserCenterOverseas = 123,
	// Token: 0x04002525 RID: 9509
	PushMode = 121,
	// Token: 0x04002526 RID: 9510
	AimAssist,
	// Token: 0x04002527 RID: 9511
	KeyboardLockEnemyMode = 129,
	// Token: 0x04002528 RID: 9512
	HorizontalViewRevert,
	// Token: 0x04002529 RID: 9513
	VerticalViewRevert,
	// Token: 0x0400252A RID: 9514
	SkillLockEnemyMode = 133,
	// Token: 0x0400252B RID: 9515
	GamepadLockEnemyMode,
	// Token: 0x0400252C RID: 9516
	EnemyHitDisplayMode,
	// Token: 0x0400252D RID: 9517
	PlayStationOnly,
	// Token: 0x0400252E RID: 9518
	MobileGamepadMode,
	// Token: 0x0400252F RID: 9519
	BackendVolume = 10107,
	// Token: 0x04002530 RID: 9520
	SkinDamageMode = 20031,
	// Token: 0x04002531 RID: 9521
	AutoAdjustImageQuality = 145,
	// Token: 0x04002532 RID: 9522
	ShowDamage = 20023,
	// Token: 0x04002533 RID: 9523
	DynamicBones,
	// Token: 0x04002534 RID: 9524
	FlowAdaptation,
	// Token: 0x04002535 RID: 9525
	UIPureMode = 51101,
	// Token: 0x04002536 RID: 9526
	FlyControlMode = 60207,
	// Token: 0x04002537 RID: 9527
	RayTracing = 20026,
	// Token: 0x04002538 RID: 9528
	RayTracedReflection,
	// Token: 0x04002539 RID: 9529
	RayTracedGI,
	// Token: 0x0400253A RID: 9530
	RayTracedShadow,
	// Token: 0x0400253B RID: 9531
	TeammateFx,
	// Token: 0x0400253C RID: 9532
	Saturation = 20204,
	// Token: 0x0400253D RID: 9533
	Contrast,
	// Token: 0x0400253E RID: 9534
	Filter,
	// Token: 0x0400253F RID: 9535
	AdrenoFME = 20032,
	// Token: 0x04002540 RID: 9536
	BasicGraphicSetting = 20203,
	// Token: 0x04002541 RID: 9537
	Vulkan = 20360,
	// Token: 0x04002542 RID: 9538
	ResDownLoad = 55113,
	// Token: 0x04002543 RID: 9539
	ResClear,
	// Token: 0x04002544 RID: 9540
	VersionCheck = 51506,
	// Token: 0x04002545 RID: 9541
	AutoRun = 60208,
	// Token: 0x04002546 RID: 9542
	AutoSprint,
	// Token: 0x04002547 RID: 9543
	ShowOtherName = 51102,
	// Token: 0x04002548 RID: 9544
	WaterInteract = 20033,
	// Token: 0x04002549 RID: 9545
	VegetationDither,
	// Token: 0x0400254A RID: 9546
	VegetationDensity,
	// Token: 0x0400254B RID: 9547
	ImageDisplayMode = 20216,
	// Token: 0x0400254C RID: 9548
	EyeProtection = 20210,
	// Token: 0x0400254D RID: 9549
	EyeProtectionMode,
	// Token: 0x0400254E RID: 9550
	EyeProtectionTemp,
	// Token: 0x0400254F RID: 9551
	EyeProtectionStrength,
	// Token: 0x04002550 RID: 9552
	EyeProtectionBrightness,
	// Token: 0x04002551 RID: 9553
	EyeProtectionTexture,
	// Token: 0x04002552 RID: 9554
	AutoExposure = 20610,
	// Token: 0x04002553 RID: 9555
	HarmonySuperResolution = 20301,
	// Token: 0x04002554 RID: 9556
	HarmonyRayTracingBoost,
	// Token: 0x04002555 RID: 9557
	HarmonyRayTracingBoostAdvanced,
	// Token: 0x04002556 RID: 9558
	AdjustiveGamePadTrigger = 60210,
	// Token: 0x04002557 RID: 9559
	MotorMobileButtonCustom = 30201,
	// Token: 0x04002558 RID: 9560
	MotorIsDynamicJoystick,
	// Token: 0x04002559 RID: 9561
	MotorMobileButtonLayout = 30200,
	// Token: 0x0400255A RID: 9562
	MotorAutoAcceleratorSettingEnable = 60301,
	// Token: 0x0400255B RID: 9563
	MotorAutoLongPressSpeedUp,
	// Token: 0x0400255C RID: 9564
	MotorDriftAcceleratorSettingEnable,
	// Token: 0x0400255D RID: 9565
	MotorDriftModel = 60305,
	// Token: 0x0400255E RID: 9566
	MotorHudVisible = 51103,
	// Token: 0x0400255F RID: 9567
	SubTitleOption,
	// Token: 0x04002560 RID: 9568
	DeviceInfo = 201006,
	// Token: 0x04002561 RID: 9569
	UiBrightness = 20306,
	// Token: 0x04002562 RID: 9570
	PeakBrightness,
	// Token: 0x04002563 RID: 9571
	MotorFlyControlMode = 60304,
	// Token: 0x04002564 RID: 9572
	AnisoLevel = 20004,
	// Token: 0x04002565 RID: 9573
	GamepadLeftStickDeadZone = 60235,
	// Token: 0x04002566 RID: 9574
	GamepadRightStickDeadZone = 60240,
	// Token: 0x04002567 RID: 9575
	GamepadLeftTriggerDeadZone = 60245,
	// Token: 0x04002568 RID: 9576
	GamepadRightTriggerDeadZone = 60250,
	// Token: 0x04002569 RID: 9577
	XboxOnly = 511360
}
