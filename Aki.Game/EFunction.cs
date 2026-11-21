using System;

// Token: 0x0200027B RID: 635
public enum EFunction
{
	// Token: 0x04002555 RID: 9557
	MASTERVOLUMEFUNCTION = 1,
	// Token: 0x04002556 RID: 9558
	VOICEVOLUMEFUNCTION,
	// Token: 0x04002557 RID: 9559
	MUSICVOLUMEFUNCTION,
	// Token: 0x04002558 RID: 9560
	SFXVOLUMEFUNCTION,
	// Token: 0x04002559 RID: 9561
	AMBVOLUMEFUNCTION = 69,
	// Token: 0x0400255A RID: 9562
	UIVOLUMEFUNCTION,
	// Token: 0x0400255B RID: 9563
	DOLBYATOMS = 76,
	// Token: 0x0400255C RID: 9564
	IMAGEQUALITY = 10,
	// Token: 0x0400255D RID: 9565
	DISPLAYMODE = 5,
	// Token: 0x0400255E RID: 9566
	RESOURCESTANDARD = 20070,
	// Token: 0x0400255F RID: 9567
	RESOLUTION = 6,
	// Token: 0x04002560 RID: 9568
	BRIGHTNESS,
	// Token: 0x04002561 RID: 9569
	HIGHESTFPS = 11,
	// Token: 0x04002562 RID: 9570
	SHADOWQUALITY = 54,
	// Token: 0x04002563 RID: 9571
	NIAGARAQUALITY,
	// Token: 0x04002564 RID: 9572
	IMAGEDETAIL,
	// Token: 0x04002565 RID: 9573
	ANTIALISING,
	// Token: 0x04002566 RID: 9574
	SCENEAO,
	// Token: 0x04002567 RID: 9575
	NPCDENSITY = 79,
	// Token: 0x04002568 RID: 9576
	NVIDIADLSS = 81,
	// Token: 0x04002569 RID: 9577
	NVIDIADLSSFG,
	// Token: 0x0400256A RID: 9578
	NVIDIADLSSQUALITY = 831,
	// Token: 0x0400256B RID: 9579
	NVIDIADLSSSHARPNESS = 84,
	// Token: 0x0400256C RID: 9580
	NVIDIAREFLEX,
	// Token: 0x0400256D RID: 9581
	HDR = 20305,
	// Token: 0x0400256E RID: 9582
	FSR = 87,
	// Token: 0x0400256F RID: 9583
	XESS = 125,
	// Token: 0x04002570 RID: 9584
	XESS_QUALITY,
	// Token: 0x04002571 RID: 9585
	XESS2 = 20310,
	// Token: 0x04002572 RID: 9586
	XESS2_FG = 20341,
	// Token: 0x04002573 RID: 9587
	XESS2_QUALITY = 20340,
	// Token: 0x04002574 RID: 9588
	FSR3 = 20350,
	// Token: 0x04002575 RID: 9589
	FSR3_FG = 20352,
	// Token: 0x04002576 RID: 9590
	FSR3_QUALITY = 20351,
	// Token: 0x04002577 RID: 9591
	PSSR = 20308,
	// Token: 0x04002578 RID: 9592
	METALFX = 127,
	// Token: 0x04002579 RID: 9593
	IRX,
	// Token: 0x0400257A RID: 9594
	BLOOM = 132,
	// Token: 0x0400257B RID: 9595
	VOLUMEFOG = 63,
	// Token: 0x0400257C RID: 9596
	VOLUMELIGHT,
	// Token: 0x0400257D RID: 9597
	MOTIONBLUR,
	// Token: 0x0400257E RID: 9598
	PCVSYNC,
	// Token: 0x0400257F RID: 9599
	MOBILERESOLUTION,
	// Token: 0x04002580 RID: 9600
	SUPERRESOLUTION,
	// Token: 0x04002581 RID: 9601
	LOADINGRANGESCALELEVEL = 20611,
	// Token: 0x04002582 RID: 9602
	TEXTLANGUAGE = 51,
	// Token: 0x04002583 RID: 9603
	VOICELANGUAGE,
	// Token: 0x04002584 RID: 9604
	VOICEPACKMANAGER,
	// Token: 0x04002585 RID: 9605
	VOICEROLECUSTOM = 40101,
	// Token: 0x04002586 RID: 9606
	ADVICESETTING = 59,
	// Token: 0x04002587 RID: 9607
	GENDERSETTING = 88,
	// Token: 0x04002588 RID: 9608
	HorizontalViewSensitivity,
	// Token: 0x04002589 RID: 9609
	VerticalViewSensitivity,
	// Token: 0x0400258A RID: 9610
	AimHorizontalViewSensitivity,
	// Token: 0x0400258B RID: 9611
	AimVerticalViewSensitivity,
	// Token: 0x0400258C RID: 9612
	CameraShakeStrength,
	// Token: 0x0400258D RID: 9613
	MobileHorizontalViewSensitivity,
	// Token: 0x0400258E RID: 9614
	MobileVerticalViewSensitivity,
	// Token: 0x0400258F RID: 9615
	MobileAimHorizontalViewSensitivity,
	// Token: 0x04002590 RID: 9616
	MobileAimVerticalViewSensitivity,
	// Token: 0x04002591 RID: 9617
	CommonSpringArmLength = 99,
	// Token: 0x04002592 RID: 9618
	FightSpringArmLength,
	// Token: 0x04002593 RID: 9619
	ResetFocusEnable,
	// Token: 0x04002594 RID: 9620
	IsSidestepCameraEnable,
	// Token: 0x04002595 RID: 9621
	IsSoftLockCameraEnable,
	// Token: 0x04002596 RID: 9622
	JoystickShakeStrength,
	// Token: 0x04002597 RID: 9623
	JoystickShakeType,
	// Token: 0x04002598 RID: 9624
	WalkOrRunRate,
	// Token: 0x04002599 RID: 9625
	LogUpload,
	// Token: 0x0400259A RID: 9626
	JoystickMode,
	// Token: 0x0400259B RID: 9627
	MobileButtonCustom = 86,
	// Token: 0x0400259C RID: 9628
	SkillButtonMode = 109,
	// Token: 0x0400259D RID: 9629
	CdKey = 112,
	// Token: 0x0400259E RID: 9630
	UserCenterDomestic,
	// Token: 0x0400259F RID: 9631
	TermsOfUseDomestic,
	// Token: 0x040025A0 RID: 9632
	PrivacyPolicyDomestic,
	// Token: 0x040025A1 RID: 9633
	ChildrenPrivacy,
	// Token: 0x040025A2 RID: 9634
	ThirdPartyInfo,
	// Token: 0x040025A3 RID: 9635
	TermsOfUseOverSeas,
	// Token: 0x040025A4 RID: 9636
	PrivacyPolicyOverSeas,
	// Token: 0x040025A5 RID: 9637
	PrivacyPolicySetting,
	// Token: 0x040025A6 RID: 9638
	License = 146,
	// Token: 0x040025A7 RID: 9639
	UserCenterOverseas = 123,
	// Token: 0x040025A8 RID: 9640
	PushMode = 121,
	// Token: 0x040025A9 RID: 9641
	AimAssist,
	// Token: 0x040025AA RID: 9642
	KeyboardLockEnemyMode = 129,
	// Token: 0x040025AB RID: 9643
	HorizontalViewRevert,
	// Token: 0x040025AC RID: 9644
	VerticalViewRevert,
	// Token: 0x040025AD RID: 9645
	SkillLockEnemyMode = 133,
	// Token: 0x040025AE RID: 9646
	GamepadLockEnemyMode,
	// Token: 0x040025AF RID: 9647
	EnemyHitDisplayMode,
	// Token: 0x040025B0 RID: 9648
	PlayStationOnly,
	// Token: 0x040025B1 RID: 9649
	MobileGamepadMode,
	// Token: 0x040025B2 RID: 9650
	BackendVolume = 10107,
	// Token: 0x040025B3 RID: 9651
	SkinDamageMode = 20031,
	// Token: 0x040025B4 RID: 9652
	AutoAdjustImageQuality = 145,
	// Token: 0x040025B5 RID: 9653
	ShowDamage = 20023,
	// Token: 0x040025B6 RID: 9654
	DynamicBones,
	// Token: 0x040025B7 RID: 9655
	FlowAdaptation,
	// Token: 0x040025B8 RID: 9656
	UIPureMode = 51101,
	// Token: 0x040025B9 RID: 9657
	FlyControlMode = 60207,
	// Token: 0x040025BA RID: 9658
	RayTracing = 20026,
	// Token: 0x040025BB RID: 9659
	RayTracedReflection,
	// Token: 0x040025BC RID: 9660
	RayTracedGI,
	// Token: 0x040025BD RID: 9661
	RayTracedShadow,
	// Token: 0x040025BE RID: 9662
	TeammateFx,
	// Token: 0x040025BF RID: 9663
	Saturation = 20204,
	// Token: 0x040025C0 RID: 9664
	Contrast,
	// Token: 0x040025C1 RID: 9665
	Filter,
	// Token: 0x040025C2 RID: 9666
	AdrenoFME = 20032,
	// Token: 0x040025C3 RID: 9667
	BasicGraphicSetting = 20203,
	// Token: 0x040025C4 RID: 9668
	Vulkan = 20360,
	// Token: 0x040025C5 RID: 9669
	ResDownLoad = 55113,
	// Token: 0x040025C6 RID: 9670
	ResClear,
	// Token: 0x040025C7 RID: 9671
	VersionCheck = 51506,
	// Token: 0x040025C8 RID: 9672
	AutoRun = 60208,
	// Token: 0x040025C9 RID: 9673
	AutoSprint,
	// Token: 0x040025CA RID: 9674
	ShowOtherName = 51102,
	// Token: 0x040025CB RID: 9675
	WaterInteract = 20033,
	// Token: 0x040025CC RID: 9676
	VegetationDither,
	// Token: 0x040025CD RID: 9677
	VegetationDensity,
	// Token: 0x040025CE RID: 9678
	ImageDisplayMode = 20216,
	// Token: 0x040025CF RID: 9679
	EyeProtection = 20210,
	// Token: 0x040025D0 RID: 9680
	EyeProtectionMode,
	// Token: 0x040025D1 RID: 9681
	EyeProtectionTemp,
	// Token: 0x040025D2 RID: 9682
	EyeProtectionStrength,
	// Token: 0x040025D3 RID: 9683
	EyeProtectionBrightness,
	// Token: 0x040025D4 RID: 9684
	EyeProtectionTexture,
	// Token: 0x040025D5 RID: 9685
	AutoExposure = 20610,
	// Token: 0x040025D6 RID: 9686
	HarmonySuperResolution = 20301,
	// Token: 0x040025D7 RID: 9687
	HarmonyRayTracingBoost,
	// Token: 0x040025D8 RID: 9688
	HarmonyRayTracingBoostAdvanced,
	// Token: 0x040025D9 RID: 9689
	AdjustiveGamePadTrigger = 60210,
	// Token: 0x040025DA RID: 9690
	MotorMobileButtonCustom = 30201,
	// Token: 0x040025DB RID: 9691
	MotorIsDynamicJoystick,
	// Token: 0x040025DC RID: 9692
	MotorMobileButtonLayout = 30200,
	// Token: 0x040025DD RID: 9693
	MotorAutoAcceleratorSettingEnable = 60301,
	// Token: 0x040025DE RID: 9694
	MotorAutoLongPressSpeedUp,
	// Token: 0x040025DF RID: 9695
	MotorDriftAcceleratorSettingEnable,
	// Token: 0x040025E0 RID: 9696
	MotorDriftModel = 60305,
	// Token: 0x040025E1 RID: 9697
	MotorHudVisible = 51103,
	// Token: 0x040025E2 RID: 9698
	SubTitleOption,
	// Token: 0x040025E3 RID: 9699
	DeviceInfo = 201006,
	// Token: 0x040025E4 RID: 9700
	UiBrightness = 20306,
	// Token: 0x040025E5 RID: 9701
	PeakBrightness,
	// Token: 0x040025E6 RID: 9702
	MotorFlyControlMode = 60304,
	// Token: 0x040025E7 RID: 9703
	AnisoLevel = 20004,
	// Token: 0x040025E8 RID: 9704
	GamepadLeftStickDeadZone = 60235,
	// Token: 0x040025E9 RID: 9705
	GamepadRightStickDeadZone = 60240,
	// Token: 0x040025EA RID: 9706
	GamepadLeftTriggerDeadZone = 60245,
	// Token: 0x040025EB RID: 9707
	GamepadRightTriggerDeadZone = 60250,
	// Token: 0x040025EC RID: 9708
	XboxOnly = 511360
}
