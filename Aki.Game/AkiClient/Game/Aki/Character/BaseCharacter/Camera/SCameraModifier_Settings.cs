using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C7 RID: 17351
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings.SCameraModifier_Settings")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 360)]
	public class SCameraModifier_Settings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CE32 RID: 183858 RVA: 0x00A2B7B9 File Offset: 0x00A299B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Settings._ScriptStructPtr != 0) ? SCameraModifier_Settings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings.SCameraModifier_Settings", ref SCameraModifier_Settings._ScriptStructPtr);
		}

		// Token: 0x17007157 RID: 29015
		// (get) Token: 0x0602CE33 RID: 183859 RVA: 0x00A2B7DD File Offset: 0x00A299DD
		// (set) Token: 0x0602CE34 RID: 183860 RVA: 0x00A2B7ED File Offset: 0x00A299ED
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007158 RID: 29016
		// (get) Token: 0x0602CE35 RID: 183861 RVA: 0x00A2B7FE File Offset: 0x00A299FE
		// (set) Token: 0x0602CE36 RID: 183862 RVA: 0x00A2B80E File Offset: 0x00A29A0E
		public unsafe bool IsModifiedArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007159 RID: 29017
		// (get) Token: 0x0602CE37 RID: 183863 RVA: 0x00A2B81F File Offset: 0x00A29A1F
		// (set) Token: 0x0602CE38 RID: 183864 RVA: 0x00A2B82F File Offset: 0x00A29A2F
		public unsafe float ArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700715A RID: 29018
		// (get) Token: 0x0602CE39 RID: 183865 RVA: 0x00A2B840 File Offset: 0x00A29A40
		// (set) Token: 0x0602CE3A RID: 183866 RVA: 0x00A2B850 File Offset: 0x00A29A50
		public unsafe float ArmLengthAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700715B RID: 29019
		// (get) Token: 0x0602CE3B RID: 183867 RVA: 0x00A2B861 File Offset: 0x00A29A61
		// (set) Token: 0x0602CE3C RID: 183868 RVA: 0x00A2B871 File Offset: 0x00A29A71
		public unsafe bool IsModifiedArmRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700715C RID: 29020
		// (get) Token: 0x0602CE3D RID: 183869 RVA: 0x00A2B882 File Offset: 0x00A29A82
		// (set) Token: 0x0602CE3E RID: 183870 RVA: 0x00A2B892 File Offset: 0x00A29A92
		public unsafe bool IsModifiedArmRotationRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700715D RID: 29021
		// (get) Token: 0x0602CE3F RID: 183871 RVA: 0x00A2B8A3 File Offset: 0x00A29AA3
		// (set) Token: 0x0602CE40 RID: 183872 RVA: 0x00A2B8B3 File Offset: 0x00A29AB3
		public unsafe bool IsModifiedArmRotationPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700715E RID: 29022
		// (get) Token: 0x0602CE41 RID: 183873 RVA: 0x00A2B8C4 File Offset: 0x00A29AC4
		// (set) Token: 0x0602CE42 RID: 183874 RVA: 0x00A2B8D4 File Offset: 0x00A29AD4
		public unsafe bool IsModifiedArmRotationYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700715F RID: 29023
		// (get) Token: 0x0602CE43 RID: 183875 RVA: 0x00A2B8E5 File Offset: 0x00A29AE5
		// (set) Token: 0x0602CE44 RID: 183876 RVA: 0x00A2B8F9 File Offset: 0x00A29AF9
		public unsafe TEnumAsByte<ECameraModifyParamType> ArmRotationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17007160 RID: 29024
		// (get) Token: 0x0602CE45 RID: 183877 RVA: 0x00A2B90E File Offset: 0x00A29B0E
		// (set) Token: 0x0602CE46 RID: 183878 RVA: 0x00A2B922 File Offset: 0x00A29B22
		public unsafe FRotator ArmRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17007161 RID: 29025
		// (get) Token: 0x0602CE47 RID: 183879 RVA: 0x00A2B937 File Offset: 0x00A29B37
		// (set) Token: 0x0602CE48 RID: 183880 RVA: 0x00A2B94B File Offset: 0x00A29B4B
		[Nullable(2)]
		public unsafe UCurveVector ArmRotationCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_10);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17007162 RID: 29026
		// (get) Token: 0x0602CE49 RID: 183881 RVA: 0x00A2B960 File Offset: 0x00A29B60
		// (set) Token: 0x0602CE4A RID: 183882 RVA: 0x00A2B974 File Offset: 0x00A29B74
		public unsafe TEnumAsByte<ECameraModifyParamType> ArmRotationAdditionalType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x17007163 RID: 29027
		// (get) Token: 0x0602CE4B RID: 183883 RVA: 0x00A2B989 File Offset: 0x00A29B89
		// (set) Token: 0x0602CE4C RID: 183884 RVA: 0x00A2B99D File Offset: 0x00A29B9D
		public unsafe FRotator ArmRotationAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17007164 RID: 29028
		// (get) Token: 0x0602CE4D RID: 183885 RVA: 0x00A2B9B2 File Offset: 0x00A29BB2
		// (set) Token: 0x0602CE4E RID: 183886 RVA: 0x00A2B9C6 File Offset: 0x00A29BC6
		[Nullable(2)]
		public unsafe UCurveVector ArmRotationAdditionalCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_13);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17007165 RID: 29029
		// (get) Token: 0x0602CE4F RID: 183887 RVA: 0x00A2B9DB File Offset: 0x00A29BDB
		// (set) Token: 0x0602CE50 RID: 183888 RVA: 0x00A2B9EB File Offset: 0x00A29BEB
		public unsafe bool IsModifiedCameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_14) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_14) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007166 RID: 29030
		// (get) Token: 0x0602CE51 RID: 183889 RVA: 0x00A2B9FC File Offset: 0x00A29BFC
		// (set) Token: 0x0602CE52 RID: 183890 RVA: 0x00A2BA0C File Offset: 0x00A29C0C
		public unsafe bool IsModifiedCameraOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_15) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_15) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007167 RID: 29031
		// (get) Token: 0x0602CE53 RID: 183891 RVA: 0x00A2BA1D File Offset: 0x00A29C1D
		// (set) Token: 0x0602CE54 RID: 183892 RVA: 0x00A2BA2D File Offset: 0x00A29C2D
		public unsafe bool IsModifiedCameraOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007168 RID: 29032
		// (get) Token: 0x0602CE55 RID: 183893 RVA: 0x00A2BA3E File Offset: 0x00A29C3E
		// (set) Token: 0x0602CE56 RID: 183894 RVA: 0x00A2BA4E File Offset: 0x00A29C4E
		public unsafe bool IsModifiedCameraOffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_17) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_17) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007169 RID: 29033
		// (get) Token: 0x0602CE57 RID: 183895 RVA: 0x00A2BA5F File Offset: 0x00A29C5F
		// (set) Token: 0x0602CE58 RID: 183896 RVA: 0x00A2BA73 File Offset: 0x00A29C73
		public unsafe TEnumAsByte<ECameraModifyParamType> CameraOffsetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x1700716A RID: 29034
		// (get) Token: 0x0602CE59 RID: 183897 RVA: 0x00A2BA88 File Offset: 0x00A29C88
		// (set) Token: 0x0602CE5A RID: 183898 RVA: 0x00A2BA9C File Offset: 0x00A29C9C
		public unsafe FVector CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x1700716B RID: 29035
		// (get) Token: 0x0602CE5B RID: 183899 RVA: 0x00A2BAB1 File Offset: 0x00A29CB1
		// (set) Token: 0x0602CE5C RID: 183900 RVA: 0x00A2BAC5 File Offset: 0x00A29CC5
		[Nullable(2)]
		public unsafe UCurveVector CameraOffsetCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_20);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_20, value);
			}
		}

		// Token: 0x1700716C RID: 29036
		// (get) Token: 0x0602CE5D RID: 183901 RVA: 0x00A2BADA File Offset: 0x00A29CDA
		// (set) Token: 0x0602CE5E RID: 183902 RVA: 0x00A2BAEE File Offset: 0x00A29CEE
		public unsafe TEnumAsByte<ECameraModifyParamType> CameraOffsetAdditionalType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_21);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_21) = value;
			}
		}

		// Token: 0x1700716D RID: 29037
		// (get) Token: 0x0602CE5F RID: 183903 RVA: 0x00A2BB03 File Offset: 0x00A29D03
		// (set) Token: 0x0602CE60 RID: 183904 RVA: 0x00A2BB17 File Offset: 0x00A29D17
		public unsafe FVector CameraOffsetAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_22);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_22) = value;
			}
		}

		// Token: 0x1700716E RID: 29038
		// (get) Token: 0x0602CE61 RID: 183905 RVA: 0x00A2BB2C File Offset: 0x00A29D2C
		// (set) Token: 0x0602CE62 RID: 183906 RVA: 0x00A2BB40 File Offset: 0x00A29D40
		[Nullable(2)]
		public unsafe UCurveVector CameraOffsetAdditionalCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_23);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_23, value);
			}
		}

		// Token: 0x1700716F RID: 29039
		// (get) Token: 0x0602CE63 RID: 183907 RVA: 0x00A2BB55 File Offset: 0x00A29D55
		// (set) Token: 0x0602CE64 RID: 183908 RVA: 0x00A2BB65 File Offset: 0x00A29D65
		public unsafe bool IsModifiedCameraFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_24) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_24) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007170 RID: 29040
		// (get) Token: 0x0602CE65 RID: 183909 RVA: 0x00A2BB76 File Offset: 0x00A29D76
		// (set) Token: 0x0602CE66 RID: 183910 RVA: 0x00A2BB86 File Offset: 0x00A29D86
		public unsafe bool StopModifyOnMontageEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_25) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_25) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007171 RID: 29041
		// (get) Token: 0x0602CE67 RID: 183911 RVA: 0x00A2BB97 File Offset: 0x00A29D97
		// (set) Token: 0x0602CE68 RID: 183912 RVA: 0x00A2BBA7 File Offset: 0x00A29DA7
		public unsafe float CameraFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_26);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_26) = value;
			}
		}

		// Token: 0x17007172 RID: 29042
		// (get) Token: 0x0602CE69 RID: 183913 RVA: 0x00A2BBB8 File Offset: 0x00A29DB8
		// (set) Token: 0x0602CE6A RID: 183914 RVA: 0x00A2BBC8 File Offset: 0x00A29DC8
		public unsafe bool OverrideCameraInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_27) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_27) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007173 RID: 29043
		// (get) Token: 0x0602CE6B RID: 183915 RVA: 0x00A2BBD9 File Offset: 0x00A29DD9
		// (set) Token: 0x0602CE6C RID: 183916 RVA: 0x00A2BBE9 File Offset: 0x00A29DE9
		public unsafe bool ResetFinalArmRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_28) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_28) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007174 RID: 29044
		// (get) Token: 0x0602CE6D RID: 183917 RVA: 0x00A2BBFA File Offset: 0x00A29DFA
		// (set) Token: 0x0602CE6E RID: 183918 RVA: 0x00A2BC0A File Offset: 0x00A29E0A
		public unsafe bool IsResetFinalArmRotationToSpecificPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_29) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_29) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007175 RID: 29045
		// (get) Token: 0x0602CE6F RID: 183919 RVA: 0x00A2BC1B File Offset: 0x00A29E1B
		// (set) Token: 0x0602CE70 RID: 183920 RVA: 0x00A2BC2B File Offset: 0x00A29E2B
		public unsafe float ResetFinalArmRotationToSpecificPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_30);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_30) = value;
			}
		}

		// Token: 0x17007176 RID: 29046
		// (get) Token: 0x0602CE71 RID: 183921 RVA: 0x00A2BC3C File Offset: 0x00A29E3C
		// (set) Token: 0x0602CE72 RID: 183922 RVA: 0x00A2BC4C File Offset: 0x00A29E4C
		public unsafe bool IsResetFinalArmRotationToSpecificYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_31) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_31) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007177 RID: 29047
		// (get) Token: 0x0602CE73 RID: 183923 RVA: 0x00A2BC5D File Offset: 0x00A29E5D
		// (set) Token: 0x0602CE74 RID: 183924 RVA: 0x00A2BC6D File Offset: 0x00A29E6D
		public unsafe float ResetFinalArmRotationToSpecificYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_32);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_32) = value;
			}
		}

		// Token: 0x17007178 RID: 29048
		// (get) Token: 0x0602CE75 RID: 183925 RVA: 0x00A2BC7E File Offset: 0x00A29E7E
		// (set) Token: 0x0602CE76 RID: 183926 RVA: 0x00A2BC8E File Offset: 0x00A29E8E
		public unsafe bool ResetFinalArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_33) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_33) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007179 RID: 29049
		// (get) Token: 0x0602CE77 RID: 183927 RVA: 0x00A2BC9F File Offset: 0x00A29E9F
		// (set) Token: 0x0602CE78 RID: 183928 RVA: 0x00A2BCAF File Offset: 0x00A29EAF
		public unsafe bool IsResetFinalArmLengthToSpecificValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_34) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_34) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700717A RID: 29050
		// (get) Token: 0x0602CE79 RID: 183929 RVA: 0x00A2BCC0 File Offset: 0x00A29EC0
		// (set) Token: 0x0602CE7A RID: 183930 RVA: 0x00A2BCD0 File Offset: 0x00A29ED0
		public unsafe float ResetFinalArmLengthToSpecificValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_35);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_35) = value;
			}
		}

		// Token: 0x1700717B RID: 29051
		// (get) Token: 0x0602CE7B RID: 183931 RVA: 0x00A2BCE1 File Offset: 0x00A29EE1
		// (set) Token: 0x0602CE7C RID: 183932 RVA: 0x00A2BCF1 File Offset: 0x00A29EF1
		public unsafe bool IsResetFinalArmLengthToDynamicValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_36) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_36) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700717C RID: 29052
		// (get) Token: 0x0602CE7D RID: 183933 RVA: 0x00A2BD04 File Offset: 0x00A29F04
		// (set) Token: 0x0602CE7E RID: 183934 RVA: 0x00A2BD47 File Offset: 0x00A29F47
		[Nullable(1)]
		public TArray<SCameraModifier_Settings_ArmLengthDynamicValue> ResetFinalArmLengthToDynamicValue
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<SCameraModifier_Settings_ArmLengthDynamicValue> result;
				if ((result = this._ResetFinalArmLengthToDynamicValue) == null)
				{
					result = (this._ResetFinalArmLengthToDynamicValue = new TArray<SCameraModifier_Settings_ArmLengthDynamicValue>(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_37, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ResetFinalArmLengthToDynamicValue.CopyAssign(value);
			}
		}

		// Token: 0x1700717D RID: 29053
		// (get) Token: 0x0602CE7F RID: 183935 RVA: 0x00A2BD55 File Offset: 0x00A29F55
		// (set) Token: 0x0602CE80 RID: 183936 RVA: 0x00A2BD65 File Offset: 0x00A29F65
		public unsafe bool IsLockInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_38) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_38) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700717E RID: 29054
		// (get) Token: 0x0602CE81 RID: 183937 RVA: 0x00A2BD76 File Offset: 0x00A29F76
		// (set) Token: 0x0602CE82 RID: 183938 RVA: 0x00A2BD86 File Offset: 0x00A29F86
		public unsafe bool IsLerpArmLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_39) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_39) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700717F RID: 29055
		// (get) Token: 0x0602CE83 RID: 183939 RVA: 0x00A2BD97 File Offset: 0x00A29F97
		// (set) Token: 0x0602CE84 RID: 183940 RVA: 0x00A2BDA7 File Offset: 0x00A29FA7
		public unsafe bool IsSwitchModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_40) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_40) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007180 RID: 29056
		// (get) Token: 0x0602CE85 RID: 183941 RVA: 0x00A2BDB8 File Offset: 0x00A29FB8
		// (set) Token: 0x0602CE86 RID: 183942 RVA: 0x00A2BDC8 File Offset: 0x00A29FC8
		public unsafe bool IsForcePlayModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_41) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_41) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007181 RID: 29057
		// (get) Token: 0x0602CE87 RID: 183943 RVA: 0x00A2BDD9 File Offset: 0x00A29FD9
		// (set) Token: 0x0602CE88 RID: 183944 RVA: 0x00A2BDE9 File Offset: 0x00A29FE9
		public unsafe bool StopModifyOnZoomInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_42) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_42) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007182 RID: 29058
		// (get) Token: 0x0602CE89 RID: 183945 RVA: 0x00A2BDFC File Offset: 0x00A29FFC
		// (set) Token: 0x0602CE8A RID: 183946 RVA: 0x00A2BE3F File Offset: 0x00A2A03F
		[Nullable(1)]
		public SCameraModifier_SettingsAdditional ModifySettingsAdditional
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				SCameraModifier_SettingsAdditional result;
				if ((result = this._ModifySettingsAdditional) == null)
				{
					result = (this._ModifySettingsAdditional = new SCameraModifier_SettingsAdditional(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_43, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_SettingsAdditional.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_43, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0602CE8B RID: 183947 RVA: 0x00A2BE60 File Offset: 0x00A2A060
		public SCameraModifier_Settings()
		{
		}

		// Token: 0x0602CE8C RID: 183948 RVA: 0x00A2BE68 File Offset: 0x00A2A068
		[NullableContext(1)]
		public SCameraModifier_Settings(int Priority, bool IsModifiedArmLength, float ArmLength, float ArmLengthAdditional, bool IsModifiedArmRotation, bool IsModifiedArmRotationRoll, bool IsModifiedArmRotationPitch, bool IsModifiedArmRotationYaw, [Nullable(0)] TEnumAsByte<ECameraModifyParamType> ArmRotationType, FRotator ArmRotation, UCurveVector ArmRotationCurve, [Nullable(0)] TEnumAsByte<ECameraModifyParamType> ArmRotationAdditionalType, FRotator ArmRotationAdditional, UCurveVector ArmRotationAdditionalCurve, bool IsModifiedCameraOffset, bool IsModifiedCameraOffsetX, bool IsModifiedCameraOffsetY, bool IsModifiedCameraOffsetZ, [Nullable(0)] TEnumAsByte<ECameraModifyParamType> CameraOffsetType, FVector CameraOffset, UCurveVector CameraOffsetCurve, [Nullable(0)] TEnumAsByte<ECameraModifyParamType> CameraOffsetAdditionalType, FVector CameraOffsetAdditional, UCurveVector CameraOffsetAdditionalCurve, bool IsModifiedCameraFov, bool StopModifyOnMontageEnd, float CameraFov, bool OverrideCameraInput, bool ResetFinalArmRotation, bool IsResetFinalArmRotationToSpecificPitch, float ResetFinalArmRotationToSpecificPitch, bool IsResetFinalArmRotationToSpecificYaw, float ResetFinalArmRotationToSpecificYaw, bool ResetFinalArmLength, bool IsResetFinalArmLengthToSpecificValue, float ResetFinalArmLengthToSpecificValue, bool IsResetFinalArmLengthToDynamicValue, TArray<SCameraModifier_Settings_ArmLengthDynamicValue> ResetFinalArmLengthToDynamicValue, bool IsLockInput, bool IsLerpArmLocation, bool IsSwitchModifier, bool IsForcePlayModify, bool StopModifyOnZoomInput, SCameraModifier_SettingsAdditional ModifySettingsAdditional)
		{
			this.Priority = Priority;
			this.IsModifiedArmLength = IsModifiedArmLength;
			this.ArmLength = ArmLength;
			this.ArmLengthAdditional = ArmLengthAdditional;
			this.IsModifiedArmRotation = IsModifiedArmRotation;
			this.IsModifiedArmRotationRoll = IsModifiedArmRotationRoll;
			this.IsModifiedArmRotationPitch = IsModifiedArmRotationPitch;
			this.IsModifiedArmRotationYaw = IsModifiedArmRotationYaw;
			this.ArmRotationType = ArmRotationType;
			this.ArmRotation = ArmRotation;
			this.ArmRotationCurve = ArmRotationCurve;
			this.ArmRotationAdditionalType = ArmRotationAdditionalType;
			this.ArmRotationAdditional = ArmRotationAdditional;
			this.ArmRotationAdditionalCurve = ArmRotationAdditionalCurve;
			this.IsModifiedCameraOffset = IsModifiedCameraOffset;
			this.IsModifiedCameraOffsetX = IsModifiedCameraOffsetX;
			this.IsModifiedCameraOffsetY = IsModifiedCameraOffsetY;
			this.IsModifiedCameraOffsetZ = IsModifiedCameraOffsetZ;
			this.CameraOffsetType = CameraOffsetType;
			this.CameraOffset = CameraOffset;
			this.CameraOffsetCurve = CameraOffsetCurve;
			this.CameraOffsetAdditionalType = CameraOffsetAdditionalType;
			this.CameraOffsetAdditional = CameraOffsetAdditional;
			this.CameraOffsetAdditionalCurve = CameraOffsetAdditionalCurve;
			this.IsModifiedCameraFov = IsModifiedCameraFov;
			this.StopModifyOnMontageEnd = StopModifyOnMontageEnd;
			this.CameraFov = CameraFov;
			this.OverrideCameraInput = OverrideCameraInput;
			this.ResetFinalArmRotation = ResetFinalArmRotation;
			this.IsResetFinalArmRotationToSpecificPitch = IsResetFinalArmRotationToSpecificPitch;
			this.ResetFinalArmRotationToSpecificPitch = ResetFinalArmRotationToSpecificPitch;
			this.IsResetFinalArmRotationToSpecificYaw = IsResetFinalArmRotationToSpecificYaw;
			this.ResetFinalArmRotationToSpecificYaw = ResetFinalArmRotationToSpecificYaw;
			this.ResetFinalArmLength = ResetFinalArmLength;
			this.IsResetFinalArmLengthToSpecificValue = IsResetFinalArmLengthToSpecificValue;
			this.ResetFinalArmLengthToSpecificValue = ResetFinalArmLengthToSpecificValue;
			this.IsResetFinalArmLengthToDynamicValue = IsResetFinalArmLengthToDynamicValue;
			this.ResetFinalArmLengthToDynamicValue = ResetFinalArmLengthToDynamicValue;
			this.IsLockInput = IsLockInput;
			this.IsLerpArmLocation = IsLerpArmLocation;
			this.IsSwitchModifier = IsSwitchModifier;
			this.IsForcePlayModify = IsForcePlayModify;
			this.StopModifyOnZoomInput = StopModifyOnZoomInput;
			this.ModifySettingsAdditional = ModifySettingsAdditional;
		}

		// Token: 0x0602CE8D RID: 183949 RVA: 0x00A2BFD8 File Offset: 0x00A2A1D8
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_Settings.StaticStruct();
		}

		// Token: 0x0602CE8E RID: 183950 RVA: 0x00A2BFE4 File Offset: 0x00A2A1E4
		[NullableContext(2)]
		public SCameraModifier_Settings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CE8F RID: 183951 RVA: 0x00A2BFEE File Offset: 0x00A2A1EE
		public SCameraModifier_Settings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CE90 RID: 183952 RVA: 0x00A2BFF9 File Offset: 0x00A2A1F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_Settings(Pointer, false, true);
		}

		// Token: 0x0602CE91 RID: 183953 RVA: 0x00A2C003 File Offset: 0x00A2A203
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_Settings(Pointer, MemoryOwner);
		}

		// Token: 0x04017D1F RID: 97567
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings.SCameraModifier_Settings";

		// Token: 0x04017D20 RID: 97568
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D21 RID: 97569
		internal static int __PropertyOffset_0;

		// Token: 0x04017D22 RID: 97570
		internal static int __PropertyOffset_1;

		// Token: 0x04017D23 RID: 97571
		internal static int __PropertyOffset_2;

		// Token: 0x04017D24 RID: 97572
		internal static int __PropertyOffset_3;

		// Token: 0x04017D25 RID: 97573
		internal static int __PropertyOffset_4;

		// Token: 0x04017D26 RID: 97574
		internal static int __PropertyOffset_5;

		// Token: 0x04017D27 RID: 97575
		internal static int __PropertyOffset_6;

		// Token: 0x04017D28 RID: 97576
		internal static int __PropertyOffset_7;

		// Token: 0x04017D29 RID: 97577
		internal static int __PropertyOffset_8;

		// Token: 0x04017D2A RID: 97578
		internal static int __PropertyOffset_9;

		// Token: 0x04017D2B RID: 97579
		internal static int __PropertyOffset_10;

		// Token: 0x04017D2C RID: 97580
		internal static int __PropertyOffset_11;

		// Token: 0x04017D2D RID: 97581
		internal static int __PropertyOffset_12;

		// Token: 0x04017D2E RID: 97582
		internal static int __PropertyOffset_13;

		// Token: 0x04017D2F RID: 97583
		internal static int __PropertyOffset_14;

		// Token: 0x04017D30 RID: 97584
		internal static int __PropertyOffset_15;

		// Token: 0x04017D31 RID: 97585
		internal static int __PropertyOffset_16;

		// Token: 0x04017D32 RID: 97586
		internal static int __PropertyOffset_17;

		// Token: 0x04017D33 RID: 97587
		internal static int __PropertyOffset_18;

		// Token: 0x04017D34 RID: 97588
		internal static int __PropertyOffset_19;

		// Token: 0x04017D35 RID: 97589
		internal static int __PropertyOffset_20;

		// Token: 0x04017D36 RID: 97590
		internal static int __PropertyOffset_21;

		// Token: 0x04017D37 RID: 97591
		internal static int __PropertyOffset_22;

		// Token: 0x04017D38 RID: 97592
		internal static int __PropertyOffset_23;

		// Token: 0x04017D39 RID: 97593
		internal static int __PropertyOffset_24;

		// Token: 0x04017D3A RID: 97594
		internal static int __PropertyOffset_25;

		// Token: 0x04017D3B RID: 97595
		internal static int __PropertyOffset_26;

		// Token: 0x04017D3C RID: 97596
		internal static int __PropertyOffset_27;

		// Token: 0x04017D3D RID: 97597
		internal static int __PropertyOffset_28;

		// Token: 0x04017D3E RID: 97598
		internal static int __PropertyOffset_29;

		// Token: 0x04017D3F RID: 97599
		internal static int __PropertyOffset_30;

		// Token: 0x04017D40 RID: 97600
		internal static int __PropertyOffset_31;

		// Token: 0x04017D41 RID: 97601
		internal static int __PropertyOffset_32;

		// Token: 0x04017D42 RID: 97602
		internal static int __PropertyOffset_33;

		// Token: 0x04017D43 RID: 97603
		internal static int __PropertyOffset_34;

		// Token: 0x04017D44 RID: 97604
		internal static int __PropertyOffset_35;

		// Token: 0x04017D45 RID: 97605
		internal static int __PropertyOffset_36;

		// Token: 0x04017D46 RID: 97606
		internal static int __PropertyOffset_37;

		// Token: 0x04017D47 RID: 97607
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraModifier_Settings_ArmLengthDynamicValue> _ResetFinalArmLengthToDynamicValue;

		// Token: 0x04017D48 RID: 97608
		internal static int __PropertyOffset_38;

		// Token: 0x04017D49 RID: 97609
		internal static int __PropertyOffset_39;

		// Token: 0x04017D4A RID: 97610
		internal static int __PropertyOffset_40;

		// Token: 0x04017D4B RID: 97611
		internal static int __PropertyOffset_41;

		// Token: 0x04017D4C RID: 97612
		internal static int __PropertyOffset_42;

		// Token: 0x04017D4D RID: 97613
		internal static int __PropertyOffset_43;

		// Token: 0x04017D4E RID: 97614
		[Nullable(2)]
		private SCameraModifier_SettingsAdditional _ModifySettingsAdditional;
	}
}
