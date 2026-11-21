using System;

namespace CSharpScript.Game.Common
{
	// Token: 0x02006408 RID: 25608
	public enum ELocalStorageGlobalKey
	{
		// Token: 0x04020F51 RID: 134993
		GameQualitySetting,
		// Token: 0x04020F52 RID: 134994
		LoginFailCount,
		// Token: 0x04020F53 RID: 134995
		NextLoginTime,
		// Token: 0x04020F54 RID: 134996
		ResetLoginFailCountTime,
		// Token: 0x04020F55 RID: 134997
		SingleMapId,
		// Token: 0x04020F56 RID: 134998
		MultiMapId,
		// Token: 0x04020F57 RID: 134999
		LoginSex,
		// Token: 0x04020F58 RID: 135000
		SelectBoxActive,
		// Token: 0x04020F59 RID: 135001
		SkipPlot,
		// Token: 0x04020F5A RID: 135002
		FirstOpenShop,
		// Token: 0x04020F5B RID: 135003
		LoginDebugServerIp,
		// Token: 0x04020F5C RID: 135004
		PlayMenuInfo,
		// Token: 0x04020F5D RID: 135005
		MenuData,
		// Token: 0x04020F5E RID: 135006
		Account,
		// Token: 0x04020F5F RID: 135007
		GmHistory,
		// Token: 0x04020F60 RID: 135008
		LocalGameTimeData,
		// Token: 0x04020F61 RID: 135009
		PackageAudio,
		// Token: 0x04020F62 RID: 135010
		RecentlyAccountList,
		// Token: 0x04020F63 RID: 135011
		RecentlyLoginUID,
		// Token: 0x04020F64 RID: 135012
		SubDownLoadClearLastWorldDoneUid,
		// Token: 0x04020F65 RID: 135013
		LastTimeUploadStamp,
		// Token: 0x04020F66 RID: 135014
		SdkLastTimeLoginData,
		// Token: 0x04020F67 RID: 135015
		SdkLevelData,
		// Token: 0x04020F68 RID: 135016
		RequestPhotoPermissionMinTime,
		// Token: 0x04020F69 RID: 135017
		PhotoAndShareShowPlayerName,
		// Token: 0x04020F6A RID: 135018
		CombineAction,
		// Token: 0x04020F6B RID: 135019
		GameQualityLevel,
		// Token: 0x04020F6C RID: 135020
		CustomFrameRate,
		// Token: 0x04020F6D RID: 135021
		ShadowQuality,
		// Token: 0x04020F6E RID: 135022
		NiagaraQuality,
		// Token: 0x04020F6F RID: 135023
		ImageDetail,
		// Token: 0x04020F70 RID: 135024
		Brightness,
		// Token: 0x04020F71 RID: 135025
		AntiAliasing,
		// Token: 0x04020F72 RID: 135026
		SceneAo,
		// Token: 0x04020F73 RID: 135027
		VolumeFog,
		// Token: 0x04020F74 RID: 135028
		VolumeLight,
		// Token: 0x04020F75 RID: 135029
		MotionBlur,
		// Token: 0x04020F76 RID: 135030
		StreamLevel,
		// Token: 0x04020F77 RID: 135031
		PcVsync,
		// Token: 0x04020F78 RID: 135032
		MobileResolution,
		// Token: 0x04020F79 RID: 135033
		SuperResolution,
		// Token: 0x04020F7A RID: 135034
		PcResolutionWidth,
		// Token: 0x04020F7B RID: 135035
		PcResolutionHeight,
		// Token: 0x04020F7C RID: 135036
		PcWindowMode,
		// Token: 0x04020F7D RID: 135037
		NvidiaSuperSamplingEnable,
		// Token: 0x04020F7E RID: 135038
		NvidiaSuperSamplingFrameGenerate,
		// Token: 0x04020F7F RID: 135039
		NvidiaSuperSamplingMode,
		// Token: 0x04020F80 RID: 135040
		NvidiaSuperSamplingQuality,
		// Token: 0x04020F81 RID: 135041
		NvidiaSuperSamplingSharpness,
		// Token: 0x04020F82 RID: 135042
		NvidiaReflex,
		// Token: 0x04020F83 RID: 135043
		Hdr,
		// Token: 0x04020F84 RID: 135044
		FsrEnable,
		// Token: 0x04020F85 RID: 135045
		HorizontalViewSensitivity,
		// Token: 0x04020F86 RID: 135046
		VerticalViewSensitivity,
		// Token: 0x04020F87 RID: 135047
		AimHorizontalViewSensitivity,
		// Token: 0x04020F88 RID: 135048
		AimVerticalViewSensitivity,
		// Token: 0x04020F89 RID: 135049
		CameraShakeStrength,
		// Token: 0x04020F8A RID: 135050
		MobileHorizontalViewSensitivity,
		// Token: 0x04020F8B RID: 135051
		MobileVerticalViewSensitivity,
		// Token: 0x04020F8C RID: 135052
		MobileAimHorizontalViewSensitivity,
		// Token: 0x04020F8D RID: 135053
		MobileAimVerticalViewSensitivity,
		// Token: 0x04020F8E RID: 135054
		MobileCameraShakeStrength,
		// Token: 0x04020F8F RID: 135055
		CommonSpringArmLength,
		// Token: 0x04020F90 RID: 135056
		FightSpringArmLength,
		// Token: 0x04020F91 RID: 135057
		IsResetFocusEnable,
		// Token: 0x04020F92 RID: 135058
		IsSidestepCameraEnable,
		// Token: 0x04020F93 RID: 135059
		IsSoftLockCameraEnable,
		// Token: 0x04020F94 RID: 135060
		JoystickShakeStrength,
		// Token: 0x04020F95 RID: 135061
		JoystickShakeType,
		// Token: 0x04020F96 RID: 135062
		WalkOrRunRate,
		// Token: 0x04020F97 RID: 135063
		JoystickMode,
		// Token: 0x04020F98 RID: 135064
		IsAutoSwitchSkillButtonMode,
		// Token: 0x04020F99 RID: 135065
		AimAssistEnable,
		// Token: 0x04020F9A RID: 135066
		XessEnable,
		// Token: 0x04020F9B RID: 135067
		XessQuality,
		// Token: 0x04020F9C RID: 135068
		Xess2Enable,
		// Token: 0x04020F9D RID: 135069
		Xess2Fg,
		// Token: 0x04020F9E RID: 135070
		Xess2Quality,
		// Token: 0x04020F9F RID: 135071
		Fsr3Enable,
		// Token: 0x04020FA0 RID: 135072
		Fsr3Fg,
		// Token: 0x04020FA1 RID: 135073
		Fsr3Quality,
		// Token: 0x04020FA2 RID: 135074
		MetalFxEnable,
		// Token: 0x04020FA3 RID: 135075
		IrxEnable,
		// Token: 0x04020FA4 RID: 135076
		BloomEnable,
		// Token: 0x04020FA5 RID: 135077
		NpcDensity,
		// Token: 0x04020FA6 RID: 135078
		KeyboardLockEnemyMode,
		// Token: 0x04020FA7 RID: 135079
		HorizontalViewRevert,
		// Token: 0x04020FA8 RID: 135080
		VerticalViewRevert,
		// Token: 0x04020FA9 RID: 135081
		SkillLockEnemyMode,
		// Token: 0x04020FAA RID: 135082
		GamepadLockEnemyMode,
		// Token: 0x04020FAB RID: 135083
		EnemyHitDisplayMode,
		// Token: 0x04020FAC RID: 135084
		RepairEnemyHitDisplayMode,
		// Token: 0x04020FAD RID: 135085
		GamepadRouletteSelectConfig,
		// Token: 0x04020FAE RID: 135086
		IsConvertViewSensitivity,
		// Token: 0x04020FAF RID: 135087
		IsConvertAllViewSensitivity,
		// Token: 0x04020FB0 RID: 135088
		MasterVolume,
		// Token: 0x04020FB1 RID: 135089
		VoiceVolume,
		// Token: 0x04020FB2 RID: 135090
		MusicVolume,
		// Token: 0x04020FB3 RID: 135091
		SFXVolume,
		// Token: 0x04020FB4 RID: 135092
		AMBVolume,
		// Token: 0x04020FB5 RID: 135093
		UIVolume,
		// Token: 0x04020FB6 RID: 135094
		PcResolutionIndex,
		// Token: 0x04020FB7 RID: 135095
		TextLanguage,
		// Token: 0x04020FB8 RID: 135096
		VoiceLanguage,
		// Token: 0x04020FB9 RID: 135097
		AdviceSetting,
		// Token: 0x04020FBA RID: 135098
		GenderSetting,
		// Token: 0x04020FBB RID: 135099
		ImageQuality,
		// Token: 0x04020FBC RID: 135100
		HasLocalGameSettings,
		// Token: 0x04020FBD RID: 135101
		IsConvertOldMenuData,
		// Token: 0x04020FBE RID: 135102
		LastReviewTime,
		// Token: 0x04020FBF RID: 135103
		IsConvertInputActionSort,
		// Token: 0x04020FC0 RID: 135104
		OpenReviewTimeList,
		// Token: 0x04020FC1 RID: 135105
		AutoAdjustImageQuality,
		// Token: 0x04020FC2 RID: 135106
		IsConvertInput,
		// Token: 0x04020FC3 RID: 135107
		IsSavedKeyMappings,
		// Token: 0x04020FC4 RID: 135108
		GamepadOperationPreferences,
		// Token: 0x04020FC5 RID: 135109
		ShowDamage,
		// Token: 0x04020FC6 RID: 135110
		DynamicBones,
		// Token: 0x04020FC7 RID: 135111
		IsCustomImageQuality,
		// Token: 0x04020FC8 RID: 135112
		DolbyAtmos,
		// Token: 0x04020FC9 RID: 135113
		IsFinishRecommendQuality,
		// Token: 0x04020FCA RID: 135114
		FlowAdaptation,
		// Token: 0x04020FCB RID: 135115
		FlyControlMode,
		// Token: 0x04020FCC RID: 135116
		IsShowFinishedPlayPointMark,
		// Token: 0x04020FCD RID: 135117
		IsShowCustomMark,
		// Token: 0x04020FCE RID: 135118
		JoystickClickMultiplier,
		// Token: 0x04020FCF RID: 135119
		AreaStoryProgress,
		// Token: 0x04020FD0 RID: 135120
		RayTracing,
		// Token: 0x04020FD1 RID: 135121
		RayTracedReflection,
		// Token: 0x04020FD2 RID: 135122
		RayTracedGI,
		// Token: 0x04020FD3 RID: 135123
		RayTracedShadow,
		// Token: 0x04020FD4 RID: 135124
		TeammateFx,
		// Token: 0x04020FD5 RID: 135125
		Saturation,
		// Token: 0x04020FD6 RID: 135126
		Contrast,
		// Token: 0x04020FD7 RID: 135127
		SaturationNew,
		// Token: 0x04020FD8 RID: 135128
		ContrastNew,
		// Token: 0x04020FD9 RID: 135129
		IconPercentAreaStory,
		// Token: 0x04020FDA RID: 135130
		IconPercentAreaShow,
		// Token: 0x04020FDB RID: 135131
		AreaExplorePlayState,
		// Token: 0x04020FDC RID: 135132
		ShowNoteIdMap,
		// Token: 0x04020FDD RID: 135133
		SkinDamageMode,
		// Token: 0x04020FDE RID: 135134
		HasRefreshNvidiaDlssQuality,
		// Token: 0x04020FDF RID: 135135
		HasRefreshNvidiaDlssFrameGenerate,
		// Token: 0x04020FE0 RID: 135136
		AfmeSince2Dot3,
		// Token: 0x04020FE1 RID: 135137
		AutoRun,
		// Token: 0x04020FE2 RID: 135138
		AutoSprint,
		// Token: 0x04020FE3 RID: 135139
		Vulkan,
		// Token: 0x04020FE4 RID: 135140
		VulkanChangeFlag,
		// Token: 0x04020FE5 RID: 135141
		PreDownloadVersionRecord,
		// Token: 0x04020FE6 RID: 135142
		IsLastGamePadPlayStation,
		// Token: 0x04020FE7 RID: 135143
		LastGamepadEnum,
		// Token: 0x04020FE8 RID: 135144
		HasResetBrightness,
		// Token: 0x04020FE9 RID: 135145
		ShowOtherName,
		// Token: 0x04020FEA RID: 135146
		WaterInteract,
		// Token: 0x04020FEB RID: 135147
		ImageDisplayMode,
		// Token: 0x04020FEC RID: 135148
		EyeProtection,
		// Token: 0x04020FED RID: 135149
		EyeProtectionMode,
		// Token: 0x04020FEE RID: 135150
		EyeProtectionTemp,
		// Token: 0x04020FEF RID: 135151
		EyeProtectionStrength,
		// Token: 0x04020FF0 RID: 135152
		EyeProtectionBrightness,
		// Token: 0x04020FF1 RID: 135153
		EyeProtectionTexture,
		// Token: 0x04020FF2 RID: 135154
		FilterSettingId,
		// Token: 0x04020FF3 RID: 135155
		FilterSettingValues,
		// Token: 0x04020FF4 RID: 135156
		VegetationDensity,
		// Token: 0x04020FF5 RID: 135157
		VegetationDither,
		// Token: 0x04020FF6 RID: 135158
		AutoExposure,
		// Token: 0x04020FF7 RID: 135159
		HarmonyRayTracingBoost,
		// Token: 0x04020FF8 RID: 135160
		HarmonyRayTracingBoostAdvanced,
		// Token: 0x04020FF9 RID: 135161
		HarmonySuperResolution,
		// Token: 0x04020FFA RID: 135162
		ParallelPackageVersion,
		// Token: 0x04020FFB RID: 135163
		AdjustiveGamePadTrigger,
		// Token: 0x04020FFC RID: 135164
		BackendVolume,
		// Token: 0x04020FFD RID: 135165
		NewPlayerSupportForbidStartView,
		// Token: 0x04020FFE RID: 135166
		MotorAutoAcceleratorSettingEnable,
		// Token: 0x04020FFF RID: 135167
		MotorAutoLongPressSpeedUp,
		// Token: 0x04021000 RID: 135168
		MotorIsDynamicJoystick,
		// Token: 0x04021001 RID: 135169
		MotorMobileButtonLayout,
		// Token: 0x04021002 RID: 135170
		MotorDriftAcceleratorSettingEnable,
		// Token: 0x04021003 RID: 135171
		MotorHudVisible,
		// Token: 0x04021004 RID: 135172
		MotorDriftModel,
		// Token: 0x04021005 RID: 135173
		SubTitleOption,
		// Token: 0x04021006 RID: 135174
		ShowPlotDebugInfo,
		// Token: 0x04021007 RID: 135175
		UiBrightness,
		// Token: 0x04021008 RID: 135176
		PeakBrightness,
		// Token: 0x04021009 RID: 135177
		LoadingRangeScaleLevel,
		// Token: 0x0402100A RID: 135178
		HasResetMobileShadowQuality,
		// Token: 0x0402100B RID: 135179
		MotorFlyControlMode,
		// Token: 0x0402100C RID: 135180
		IsUsingQualityPreset,
		// Token: 0x0402100D RID: 135181
		AnisoLevel,
		// Token: 0x0402100E RID: 135182
		PhotographSetupOption,
		// Token: 0x0402100F RID: 135183
		FightPhotographSetupOption,
		// Token: 0x04021010 RID: 135184
		GamepadLeftStickDeadZone,
		// Token: 0x04021011 RID: 135185
		GamepadRightStickDeadZone,
		// Token: 0x04021012 RID: 135186
		GamepadLeftTriggerDeadZone,
		// Token: 0x04021013 RID: 135187
		GamepadRightTriggerDeadZone,
		// Token: 0x04021014 RID: 135188
		RoleLangCustomNeedCover,
		// Token: 0x04021015 RID: 135189
		RenderDistanceSliderLevel,
		// Token: 0x04021016 RID: 135190
		LoginDebugAccountLoginMode,
		// Token: 0x04021017 RID: 135191
		PssrEnable,
		// Token: 0x04021018 RID: 135192
		VulkanRefreshRevision
	}
}
