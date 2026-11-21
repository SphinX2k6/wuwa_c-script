using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.GPUNPC.BP.CrowdAi;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.SunSpirit
{
	// Token: 0x020031DC RID: 12764
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/SunSpirit/BP_SunSpiritConfig.BP_SunSpiritConfig_C")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class BP_SunSpiritConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FB0E RID: 129806 RVA: 0x00933819 File Offset: 0x00931A19
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_SunSpiritConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/SunSpirit/BP_SunSpiritConfig.BP_SunSpiritConfig_C");
			}
			return BP_SunSpiritConfig_C._ClassPtr;
		}

		// Token: 0x0601FB0F RID: 129807 RVA: 0x00933840 File Offset: 0x00931A40
		public BP_SunSpiritConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_SunSpiritConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FB10 RID: 129808 RVA: 0x00933868 File Offset: 0x00931A68
		public BP_SunSpiritConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_SunSpiritConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003AEA RID: 15082
		// (get) Token: 0x0601FB11 RID: 129809 RVA: 0x0093389B File Offset: 0x00931A9B
		// (set) Token: 0x0601FB12 RID: 129810 RVA: 0x009338AF File Offset: 0x00931AAF
		[Nullable(2)]
		public unsafe BP_CrowdAiConfig_C CrowdAiConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_CrowdAiConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_SunSpiritConfig_C.__PropertyOffset_CrowdAiConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_SunSpiritConfig_C.__PropertyOffset_CrowdAiConfig, value);
			}
		}

		// Token: 0x17003AEB RID: 15083
		// (get) Token: 0x0601FB13 RID: 129811 RVA: 0x009338C4 File Offset: 0x00931AC4
		// (set) Token: 0x0601FB14 RID: 129812 RVA: 0x009338D4 File Offset: 0x00931AD4
		public unsafe int CrowdAiSystemIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CrowdAiSystemIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CrowdAiSystemIndex) = value;
			}
		}

		// Token: 0x17003AEC RID: 15084
		// (get) Token: 0x0601FB15 RID: 129813 RVA: 0x009338E5 File Offset: 0x00931AE5
		// (set) Token: 0x0601FB16 RID: 129814 RVA: 0x009338F5 File Offset: 0x00931AF5
		public unsafe float AroundPlayerPosQueryRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_AroundPlayerPosQueryRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_AroundPlayerPosQueryRadius) = value;
			}
		}

		// Token: 0x17003AED RID: 15085
		// (get) Token: 0x0601FB17 RID: 129815 RVA: 0x00933906 File Offset: 0x00931B06
		// (set) Token: 0x0601FB18 RID: 129816 RVA: 0x00933916 File Offset: 0x00931B16
		public unsafe float AroundPlayerPosQueryBoidRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_AroundPlayerPosQueryBoidRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_AroundPlayerPosQueryBoidRadius) = value;
			}
		}

		// Token: 0x17003AEE RID: 15086
		// (get) Token: 0x0601FB19 RID: 129817 RVA: 0x00933927 File Offset: 0x00931B27
		// (set) Token: 0x0601FB1A RID: 129818 RVA: 0x00933937 File Offset: 0x00931B37
		public unsafe int AroundPlayerPosQueryMaxTryCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_AroundPlayerPosQueryMaxTryCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_AroundPlayerPosQueryMaxTryCount) = value;
			}
		}

		// Token: 0x17003AEF RID: 15087
		// (get) Token: 0x0601FB1B RID: 129819 RVA: 0x00933948 File Offset: 0x00931B48
		// (set) Token: 0x0601FB1C RID: 129820 RVA: 0x00933958 File Offset: 0x00931B58
		public unsafe float FlyingEffectMaxDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectMaxDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectMaxDist) = value;
			}
		}

		// Token: 0x17003AF0 RID: 15088
		// (get) Token: 0x0601FB1D RID: 129821 RVA: 0x00933969 File Offset: 0x00931B69
		// (set) Token: 0x0601FB1E RID: 129822 RVA: 0x00933979 File Offset: 0x00931B79
		public unsafe float FlyingEffectMinDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectMinDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectMinDist) = value;
			}
		}

		// Token: 0x17003AF1 RID: 15089
		// (get) Token: 0x0601FB1F RID: 129823 RVA: 0x0093398A File Offset: 0x00931B8A
		// (set) Token: 0x0601FB20 RID: 129824 RVA: 0x0093399A File Offset: 0x00931B9A
		public unsafe float FlyingEffectUpdateFailMaxTimeSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectUpdateFailMaxTimeSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectUpdateFailMaxTimeSec) = value;
			}
		}

		// Token: 0x17003AF2 RID: 15090
		// (get) Token: 0x0601FB21 RID: 129825 RVA: 0x009339AB File Offset: 0x00931BAB
		// (set) Token: 0x0601FB22 RID: 129826 RVA: 0x009339BB File Offset: 0x00931BBB
		public unsafe int FlyingEffectUpdateFailMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectUpdateFailMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectUpdateFailMaxCount) = value;
			}
		}

		// Token: 0x17003AF3 RID: 15091
		// (get) Token: 0x0601FB23 RID: 129827 RVA: 0x009339CC File Offset: 0x00931BCC
		// (set) Token: 0x0601FB24 RID: 129828 RVA: 0x009339DC File Offset: 0x00931BDC
		public unsafe float FlyingEffectMaxFlyingDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectMaxFlyingDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectMaxFlyingDuration) = value;
			}
		}

		// Token: 0x17003AF4 RID: 15092
		// (get) Token: 0x0601FB25 RID: 129829 RVA: 0x009339ED File Offset: 0x00931BED
		// (set) Token: 0x0601FB26 RID: 129830 RVA: 0x00933A02 File Offset: 0x00931C02
		public TSoftObjectPtr<UEffectModelBase> FlyingEffectDa
		{
			get
			{
				return new TSoftObjectPtr<UEffectModelBase>(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectDa, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyingEffectDa, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003AF5 RID: 15093
		// (get) Token: 0x0601FB27 RID: 129831 RVA: 0x00933A27 File Offset: 0x00931C27
		// (set) Token: 0x0601FB28 RID: 129832 RVA: 0x00933A37 File Offset: 0x00931C37
		public unsafe bool FlyFromPlayerToGearInOrderFromMinToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearInOrderFromMinToMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearInOrderFromMinToMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AF6 RID: 15094
		// (get) Token: 0x0601FB29 RID: 129833 RVA: 0x00933A48 File Offset: 0x00931C48
		// (set) Token: 0x0601FB2A RID: 129834 RVA: 0x00933A58 File Offset: 0x00931C58
		public unsafe float FlyFromPlayerToGearDelayInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearDelayInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearDelayInterval) = value;
			}
		}

		// Token: 0x17003AF7 RID: 15095
		// (get) Token: 0x0601FB2B RID: 129835 RVA: 0x00933A69 File Offset: 0x00931C69
		// (set) Token: 0x0601FB2C RID: 129836 RVA: 0x00933A79 File Offset: 0x00931C79
		public unsafe float FlyFromPlayerToGearWaitTimeBeforeFly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearWaitTimeBeforeFly);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearWaitTimeBeforeFly) = value;
			}
		}

		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0601FB2D RID: 129837 RVA: 0x00933A8A File Offset: 0x00931C8A
		// (set) Token: 0x0601FB2E RID: 129838 RVA: 0x00933A9A File Offset: 0x00931C9A
		public unsafe float FlyFromPlayerToGearSpeedForCalc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearSpeedForCalc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearSpeedForCalc) = value;
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0601FB2F RID: 129839 RVA: 0x00933AAB File Offset: 0x00931CAB
		// (set) Token: 0x0601FB30 RID: 129840 RVA: 0x00933ABB File Offset: 0x00931CBB
		public unsafe float FlyFromPlayerToGearDefaultDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearDefaultDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromPlayerToGearDefaultDuration) = value;
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0601FB31 RID: 129841 RVA: 0x00933ACC File Offset: 0x00931CCC
		// (set) Token: 0x0601FB32 RID: 129842 RVA: 0x00933ADC File Offset: 0x00931CDC
		public unsafe bool FlyFromGearToPlayerInOrderFromMinToMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerInOrderFromMinToMax) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerInOrderFromMinToMax) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003AFB RID: 15099
		// (get) Token: 0x0601FB33 RID: 129843 RVA: 0x00933AED File Offset: 0x00931CED
		// (set) Token: 0x0601FB34 RID: 129844 RVA: 0x00933AFD File Offset: 0x00931CFD
		public unsafe float FlyFromGearToPlayerDelayInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerDelayInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerDelayInterval) = value;
			}
		}

		// Token: 0x17003AFC RID: 15100
		// (get) Token: 0x0601FB35 RID: 129845 RVA: 0x00933B0E File Offset: 0x00931D0E
		// (set) Token: 0x0601FB36 RID: 129846 RVA: 0x00933B1E File Offset: 0x00931D1E
		public unsafe float FlyFromGearToPlayerWaitTimeBeforeFly
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerWaitTimeBeforeFly);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerWaitTimeBeforeFly) = value;
			}
		}

		// Token: 0x17003AFD RID: 15101
		// (get) Token: 0x0601FB37 RID: 129847 RVA: 0x00933B2F File Offset: 0x00931D2F
		// (set) Token: 0x0601FB38 RID: 129848 RVA: 0x00933B3F File Offset: 0x00931D3F
		public unsafe float FlyFromGearToPlayerSpeedForCalc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerSpeedForCalc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerSpeedForCalc) = value;
			}
		}

		// Token: 0x17003AFE RID: 15102
		// (get) Token: 0x0601FB39 RID: 129849 RVA: 0x00933B50 File Offset: 0x00931D50
		// (set) Token: 0x0601FB3A RID: 129850 RVA: 0x00933B60 File Offset: 0x00931D60
		public unsafe float FlyFromGearToPlayerDefaultDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerDefaultDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerDefaultDuration) = value;
			}
		}

		// Token: 0x17003AFF RID: 15103
		// (get) Token: 0x0601FB3B RID: 129851 RVA: 0x00933B71 File Offset: 0x00931D71
		// (set) Token: 0x0601FB3C RID: 129852 RVA: 0x00933B81 File Offset: 0x00931D81
		public unsafe float FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc) = value;
			}
		}

		// Token: 0x17003B00 RID: 15104
		// (get) Token: 0x0601FB3D RID: 129853 RVA: 0x00933B92 File Offset: 0x00931D92
		// (set) Token: 0x0601FB3E RID: 129854 RVA: 0x00933BA6 File Offset: 0x00931DA6
		public unsafe FVector2D LauncherHintUiAnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_LauncherHintUiAnchorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_LauncherHintUiAnchorOffset) = value;
			}
		}

		// Token: 0x17003B01 RID: 15105
		// (get) Token: 0x0601FB3F RID: 129855 RVA: 0x00933BBB File Offset: 0x00931DBB
		// (set) Token: 0x0601FB40 RID: 129856 RVA: 0x00933BCF File Offset: 0x00931DCF
		public unsafe FVector2D LauncherHintUiPosLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_LauncherHintUiPosLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_LauncherHintUiPosLerpSpeed) = value;
			}
		}

		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0601FB41 RID: 129857 RVA: 0x00933BE4 File Offset: 0x00931DE4
		// (set) Token: 0x0601FB42 RID: 129858 RVA: 0x00933BF8 File Offset: 0x00931DF8
		public unsafe FVector2D CharacterHintUiAnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CharacterHintUiAnchorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CharacterHintUiAnchorOffset) = value;
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0601FB43 RID: 129859 RVA: 0x00933C0D File Offset: 0x00931E0D
		// (set) Token: 0x0601FB44 RID: 129860 RVA: 0x00933C21 File Offset: 0x00931E21
		public unsafe FVector2D CharacterHintUiPosLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CharacterHintUiPosLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CharacterHintUiPosLerpSpeed) = value;
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0601FB45 RID: 129861 RVA: 0x00933C36 File Offset: 0x00931E36
		// (set) Token: 0x0601FB46 RID: 129862 RVA: 0x00933C46 File Offset: 0x00931E46
		public unsafe float CharacterHintUiShowDurationWhenUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CharacterHintUiShowDurationWhenUpdate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_SunSpiritConfig_C.__PropertyOffset_CharacterHintUiShowDurationWhenUpdate) = value;
			}
		}

		// Token: 0x0601FB47 RID: 129863 RVA: 0x00933C57 File Offset: 0x00931E57
		protected BP_SunSpiritConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011013 RID: 69651
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/SunSpirit/BP_SunSpiritConfig.BP_SunSpiritConfig_C";

		// Token: 0x04011014 RID: 69652
		private static IntPtr _ClassPtr;

		// Token: 0x04011015 RID: 69653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011016 RID: 69654
		internal static int __PropertyOffset_CrowdAiConfig;

		// Token: 0x04011017 RID: 69655
		internal static int __PropertyOffset_CrowdAiSystemIndex;

		// Token: 0x04011018 RID: 69656
		internal static int __PropertyOffset_AroundPlayerPosQueryRadius;

		// Token: 0x04011019 RID: 69657
		internal static int __PropertyOffset_AroundPlayerPosQueryBoidRadius;

		// Token: 0x0401101A RID: 69658
		internal static int __PropertyOffset_AroundPlayerPosQueryMaxTryCount;

		// Token: 0x0401101B RID: 69659
		internal static int __PropertyOffset_FlyingEffectMaxDist;

		// Token: 0x0401101C RID: 69660
		internal static int __PropertyOffset_FlyingEffectMinDist;

		// Token: 0x0401101D RID: 69661
		internal static int __PropertyOffset_FlyingEffectUpdateFailMaxTimeSec;

		// Token: 0x0401101E RID: 69662
		internal static int __PropertyOffset_FlyingEffectUpdateFailMaxCount;

		// Token: 0x0401101F RID: 69663
		internal static int __PropertyOffset_FlyingEffectMaxFlyingDuration;

		// Token: 0x04011020 RID: 69664
		internal static int __PropertyOffset_FlyingEffectDa;

		// Token: 0x04011021 RID: 69665
		internal static int __PropertyOffset_FlyFromPlayerToGearInOrderFromMinToMax;

		// Token: 0x04011022 RID: 69666
		internal static int __PropertyOffset_FlyFromPlayerToGearDelayInterval;

		// Token: 0x04011023 RID: 69667
		internal static int __PropertyOffset_FlyFromPlayerToGearWaitTimeBeforeFly;

		// Token: 0x04011024 RID: 69668
		internal static int __PropertyOffset_FlyFromPlayerToGearSpeedForCalc;

		// Token: 0x04011025 RID: 69669
		internal static int __PropertyOffset_FlyFromPlayerToGearDefaultDuration;

		// Token: 0x04011026 RID: 69670
		internal static int __PropertyOffset_FlyFromGearToPlayerInOrderFromMinToMax;

		// Token: 0x04011027 RID: 69671
		internal static int __PropertyOffset_FlyFromGearToPlayerDelayInterval;

		// Token: 0x04011028 RID: 69672
		internal static int __PropertyOffset_FlyFromGearToPlayerWaitTimeBeforeFly;

		// Token: 0x04011029 RID: 69673
		internal static int __PropertyOffset_FlyFromGearToPlayerSpeedForCalc;

		// Token: 0x0401102A RID: 69674
		internal static int __PropertyOffset_FlyFromGearToPlayerDefaultDuration;

		// Token: 0x0401102B RID: 69675
		internal static int __PropertyOffset_FlyFromGearToPlayerMaxOffsetForReQueryTargetLoc;

		// Token: 0x0401102C RID: 69676
		internal static int __PropertyOffset_LauncherHintUiAnchorOffset;

		// Token: 0x0401102D RID: 69677
		internal static int __PropertyOffset_LauncherHintUiPosLerpSpeed;

		// Token: 0x0401102E RID: 69678
		internal static int __PropertyOffset_CharacterHintUiAnchorOffset;

		// Token: 0x0401102F RID: 69679
		internal static int __PropertyOffset_CharacterHintUiPosLerpSpeed;

		// Token: 0x04011030 RID: 69680
		internal static int __PropertyOffset_CharacterHintUiShowDurationWhenUpdate;
	}
}
