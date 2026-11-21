using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E2 RID: 13282
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings.SCameraModifier_Settings")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 360)]
	public class SCameraModifier_Settings : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A37 RID: 137783 RVA: 0x009660E1 File Offset: 0x009642E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Settings._ScriptStructPtr != 0) ? SCameraModifier_Settings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings.SCameraModifier_Settings", ref SCameraModifier_Settings._ScriptStructPtr);
		}

		// Token: 0x17004557 RID: 17751
		// (get) Token: 0x06021A38 RID: 137784 RVA: 0x00966105 File Offset: 0x00964305
		// (set) Token: 0x06021A39 RID: 137785 RVA: 0x00966115 File Offset: 0x00964315
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17004558 RID: 17752
		// (get) Token: 0x06021A3A RID: 137786 RVA: 0x00966126 File Offset: 0x00964326
		// (set) Token: 0x06021A3B RID: 137787 RVA: 0x00966136 File Offset: 0x00964336
		public unsafe bool IsModifiedArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmLength) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmLength) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x06021A3C RID: 137788 RVA: 0x00966147 File Offset: 0x00964347
		// (set) Token: 0x06021A3D RID: 137789 RVA: 0x00966157 File Offset: 0x00964357
		public unsafe float ArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmLength) = value;
			}
		}

		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x06021A3E RID: 137790 RVA: 0x00966168 File Offset: 0x00964368
		// (set) Token: 0x06021A3F RID: 137791 RVA: 0x00966178 File Offset: 0x00964378
		public unsafe float ArmLengthAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmLengthAdditional);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmLengthAdditional) = value;
			}
		}

		// Token: 0x1700455B RID: 17755
		// (get) Token: 0x06021A40 RID: 137792 RVA: 0x00966189 File Offset: 0x00964389
		// (set) Token: 0x06021A41 RID: 137793 RVA: 0x00966199 File Offset: 0x00964399
		public unsafe bool IsModifiedArmRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700455C RID: 17756
		// (get) Token: 0x06021A42 RID: 137794 RVA: 0x009661AA File Offset: 0x009643AA
		// (set) Token: 0x06021A43 RID: 137795 RVA: 0x009661BA File Offset: 0x009643BA
		public unsafe bool IsModifiedArmRotationRoll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotationRoll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotationRoll) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700455D RID: 17757
		// (get) Token: 0x06021A44 RID: 137796 RVA: 0x009661CB File Offset: 0x009643CB
		// (set) Token: 0x06021A45 RID: 137797 RVA: 0x009661DB File Offset: 0x009643DB
		public unsafe bool IsModifiedArmRotationPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotationPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotationPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700455E RID: 17758
		// (get) Token: 0x06021A46 RID: 137798 RVA: 0x009661EC File Offset: 0x009643EC
		// (set) Token: 0x06021A47 RID: 137799 RVA: 0x009661FC File Offset: 0x009643FC
		public unsafe bool IsModifiedArmRotationYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotationYaw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedArmRotationYaw) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700455F RID: 17759
		// (get) Token: 0x06021A48 RID: 137800 RVA: 0x0096620D File Offset: 0x0096440D
		// (set) Token: 0x06021A49 RID: 137801 RVA: 0x00966221 File Offset: 0x00964421
		public unsafe TEnumAsByte<ECameraModifyParamType> ArmRotationType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotationType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotationType) = value;
			}
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x06021A4A RID: 137802 RVA: 0x00966236 File Offset: 0x00964436
		// (set) Token: 0x06021A4B RID: 137803 RVA: 0x0096624A File Offset: 0x0096444A
		public unsafe FRotator ArmRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotation) = value;
			}
		}

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x06021A4C RID: 137804 RVA: 0x0096625F File Offset: 0x0096445F
		// (set) Token: 0x06021A4D RID: 137805 RVA: 0x00966273 File Offset: 0x00964473
		[Nullable(2)]
		public unsafe UCurveVector ArmRotationCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_ArmRotationCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_ArmRotationCurve, value);
			}
		}

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x06021A4E RID: 137806 RVA: 0x00966288 File Offset: 0x00964488
		// (set) Token: 0x06021A4F RID: 137807 RVA: 0x0096629C File Offset: 0x0096449C
		public unsafe TEnumAsByte<ECameraModifyParamType> ArmRotationAdditionalType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotationAdditionalType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotationAdditionalType) = value;
			}
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x06021A50 RID: 137808 RVA: 0x009662B1 File Offset: 0x009644B1
		// (set) Token: 0x06021A51 RID: 137809 RVA: 0x009662C5 File Offset: 0x009644C5
		public unsafe FRotator ArmRotationAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotationAdditional);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ArmRotationAdditional) = value;
			}
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x06021A52 RID: 137810 RVA: 0x009662DA File Offset: 0x009644DA
		// (set) Token: 0x06021A53 RID: 137811 RVA: 0x009662EE File Offset: 0x009644EE
		[Nullable(2)]
		public unsafe UCurveVector ArmRotationAdditionalCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_ArmRotationAdditionalCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_ArmRotationAdditionalCurve, value);
			}
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x06021A54 RID: 137812 RVA: 0x00966303 File Offset: 0x00964503
		// (set) Token: 0x06021A55 RID: 137813 RVA: 0x00966313 File Offset: 0x00964513
		public unsafe bool IsModifiedCameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x06021A56 RID: 137814 RVA: 0x00966324 File Offset: 0x00964524
		// (set) Token: 0x06021A57 RID: 137815 RVA: 0x00966334 File Offset: 0x00964534
		public unsafe bool IsModifiedCameraOffsetX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffsetX) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffsetX) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x06021A58 RID: 137816 RVA: 0x00966345 File Offset: 0x00964545
		// (set) Token: 0x06021A59 RID: 137817 RVA: 0x00966355 File Offset: 0x00964555
		public unsafe bool IsModifiedCameraOffsetY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffsetY) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffsetY) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x06021A5A RID: 137818 RVA: 0x00966366 File Offset: 0x00964566
		// (set) Token: 0x06021A5B RID: 137819 RVA: 0x00966376 File Offset: 0x00964576
		public unsafe bool IsModifiedCameraOffsetZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffsetZ) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraOffsetZ) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x06021A5C RID: 137820 RVA: 0x00966387 File Offset: 0x00964587
		// (set) Token: 0x06021A5D RID: 137821 RVA: 0x0096639B File Offset: 0x0096459B
		public unsafe TEnumAsByte<ECameraModifyParamType> CameraOffsetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffsetType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffsetType) = value;
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x06021A5E RID: 137822 RVA: 0x009663B0 File Offset: 0x009645B0
		// (set) Token: 0x06021A5F RID: 137823 RVA: 0x009663C4 File Offset: 0x009645C4
		public unsafe FVector CameraOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffset) = value;
			}
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x06021A60 RID: 137824 RVA: 0x009663D9 File Offset: 0x009645D9
		// (set) Token: 0x06021A61 RID: 137825 RVA: 0x009663ED File Offset: 0x009645ED
		[Nullable(2)]
		public unsafe UCurveVector CameraOffsetCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_CameraOffsetCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_CameraOffsetCurve, value);
			}
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x06021A62 RID: 137826 RVA: 0x00966402 File Offset: 0x00964602
		// (set) Token: 0x06021A63 RID: 137827 RVA: 0x00966416 File Offset: 0x00964616
		public unsafe TEnumAsByte<ECameraModifyParamType> CameraOffsetAdditionalType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffsetAdditionalType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffsetAdditionalType) = value;
			}
		}

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x06021A64 RID: 137828 RVA: 0x0096642B File Offset: 0x0096462B
		// (set) Token: 0x06021A65 RID: 137829 RVA: 0x0096643F File Offset: 0x0096463F
		public unsafe FVector CameraOffsetAdditional
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffsetAdditional);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraOffsetAdditional) = value;
			}
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x06021A66 RID: 137830 RVA: 0x00966454 File Offset: 0x00964654
		// (set) Token: 0x06021A67 RID: 137831 RVA: 0x00966468 File Offset: 0x00964668
		[Nullable(2)]
		public unsafe UCurveVector CameraOffsetAdditionalCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_CameraOffsetAdditionalCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SCameraModifier_Settings.__PropertyOffset_CameraOffsetAdditionalCurve, value);
			}
		}

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x06021A68 RID: 137832 RVA: 0x0096647D File Offset: 0x0096467D
		// (set) Token: 0x06021A69 RID: 137833 RVA: 0x0096648D File Offset: 0x0096468D
		public unsafe bool IsModifiedCameraFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraFov) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsModifiedCameraFov) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x06021A6A RID: 137834 RVA: 0x0096649E File Offset: 0x0096469E
		// (set) Token: 0x06021A6B RID: 137835 RVA: 0x009664AE File Offset: 0x009646AE
		public unsafe bool StopModifyOnMontageEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_StopModifyOnMontageEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_StopModifyOnMontageEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x06021A6C RID: 137836 RVA: 0x009664BF File Offset: 0x009646BF
		// (set) Token: 0x06021A6D RID: 137837 RVA: 0x009664CF File Offset: 0x009646CF
		public unsafe float CameraFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraFov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_CameraFov) = value;
			}
		}

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x06021A6E RID: 137838 RVA: 0x009664E0 File Offset: 0x009646E0
		// (set) Token: 0x06021A6F RID: 137839 RVA: 0x009664F0 File Offset: 0x009646F0
		public unsafe bool OverrideCameraInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_OverrideCameraInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_OverrideCameraInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x06021A70 RID: 137840 RVA: 0x00966501 File Offset: 0x00964701
		// (set) Token: 0x06021A71 RID: 137841 RVA: 0x00966511 File Offset: 0x00964711
		public unsafe bool ResetFinalArmRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x06021A72 RID: 137842 RVA: 0x00966522 File Offset: 0x00964722
		// (set) Token: 0x06021A73 RID: 137843 RVA: 0x00966532 File Offset: 0x00964732
		public unsafe bool IsResetFinalArmRotationToSpecificPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmRotationToSpecificPitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmRotationToSpecificPitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x06021A74 RID: 137844 RVA: 0x00966543 File Offset: 0x00964743
		// (set) Token: 0x06021A75 RID: 137845 RVA: 0x00966553 File Offset: 0x00964753
		public unsafe float ResetFinalArmRotationToSpecificPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmRotationToSpecificPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmRotationToSpecificPitch) = value;
			}
		}

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x06021A76 RID: 137846 RVA: 0x00966564 File Offset: 0x00964764
		// (set) Token: 0x06021A77 RID: 137847 RVA: 0x00966574 File Offset: 0x00964774
		public unsafe bool IsResetFinalArmRotationToSpecificYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmRotationToSpecificYaw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmRotationToSpecificYaw) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x06021A78 RID: 137848 RVA: 0x00966585 File Offset: 0x00964785
		// (set) Token: 0x06021A79 RID: 137849 RVA: 0x00966595 File Offset: 0x00964795
		public unsafe float ResetFinalArmRotationToSpecificYaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmRotationToSpecificYaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmRotationToSpecificYaw) = value;
			}
		}

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x06021A7A RID: 137850 RVA: 0x009665A6 File Offset: 0x009647A6
		// (set) Token: 0x06021A7B RID: 137851 RVA: 0x009665B6 File Offset: 0x009647B6
		public unsafe bool ResetFinalArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmLength) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmLength) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x06021A7C RID: 137852 RVA: 0x009665C7 File Offset: 0x009647C7
		// (set) Token: 0x06021A7D RID: 137853 RVA: 0x009665D7 File Offset: 0x009647D7
		public unsafe bool IsResetFinalArmLengthToSpecificValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmLengthToSpecificValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmLengthToSpecificValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x06021A7E RID: 137854 RVA: 0x009665E8 File Offset: 0x009647E8
		// (set) Token: 0x06021A7F RID: 137855 RVA: 0x009665F8 File Offset: 0x009647F8
		public unsafe float ResetFinalArmLengthToSpecificValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmLengthToSpecificValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmLengthToSpecificValue) = value;
			}
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x06021A80 RID: 137856 RVA: 0x00966609 File Offset: 0x00964809
		// (set) Token: 0x06021A81 RID: 137857 RVA: 0x00966619 File Offset: 0x00964819
		public unsafe bool IsResetFinalArmLengthToDynamicValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmLengthToDynamicValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsResetFinalArmLengthToDynamicValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x06021A82 RID: 137858 RVA: 0x0096662C File Offset: 0x0096482C
		// (set) Token: 0x06021A83 RID: 137859 RVA: 0x0096666F File Offset: 0x0096486F
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
					result = (this._ResetFinalArmLengthToDynamicValue = new TArray<SCameraModifier_Settings_ArmLengthDynamicValue>(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ResetFinalArmLengthToDynamicValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ResetFinalArmLengthToDynamicValue.CopyAssign(value);
			}
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x06021A84 RID: 137860 RVA: 0x0096667D File Offset: 0x0096487D
		// (set) Token: 0x06021A85 RID: 137861 RVA: 0x0096668D File Offset: 0x0096488D
		public unsafe bool IsLockInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsLockInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsLockInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x06021A86 RID: 137862 RVA: 0x0096669E File Offset: 0x0096489E
		// (set) Token: 0x06021A87 RID: 137863 RVA: 0x009666AE File Offset: 0x009648AE
		public unsafe bool IsLerpArmLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsLerpArmLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsLerpArmLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x06021A88 RID: 137864 RVA: 0x009666BF File Offset: 0x009648BF
		// (set) Token: 0x06021A89 RID: 137865 RVA: 0x009666CF File Offset: 0x009648CF
		public unsafe bool IsSwitchModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsSwitchModifier) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsSwitchModifier) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x06021A8A RID: 137866 RVA: 0x009666E0 File Offset: 0x009648E0
		// (set) Token: 0x06021A8B RID: 137867 RVA: 0x009666F0 File Offset: 0x009648F0
		public unsafe bool IsForcePlayModify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsForcePlayModify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_IsForcePlayModify) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x06021A8C RID: 137868 RVA: 0x00966701 File Offset: 0x00964901
		// (set) Token: 0x06021A8D RID: 137869 RVA: 0x00966711 File Offset: 0x00964911
		public unsafe bool StopModifyOnZoomInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_StopModifyOnZoomInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_StopModifyOnZoomInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x06021A8E RID: 137870 RVA: 0x00966724 File Offset: 0x00964924
		// (set) Token: 0x06021A8F RID: 137871 RVA: 0x00966767 File Offset: 0x00964967
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
					result = (this._ModifySettingsAdditional = new SCameraModifier_SettingsAdditional(base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ModifySettingsAdditional, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SCameraModifier_SettingsAdditional.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_Settings.__PropertyOffset_ModifySettingsAdditional, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021A90 RID: 137872 RVA: 0x00966788 File Offset: 0x00964988
		public SCameraModifier_Settings()
		{
		}

		// Token: 0x06021A91 RID: 137873 RVA: 0x00966790 File Offset: 0x00964990
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_Settings.StaticStruct();
		}

		// Token: 0x06021A92 RID: 137874 RVA: 0x0096679C File Offset: 0x0096499C
		[NullableContext(2)]
		public SCameraModifier_Settings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A93 RID: 137875 RVA: 0x009667A6 File Offset: 0x009649A6
		public SCameraModifier_Settings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A94 RID: 137876 RVA: 0x009667B1 File Offset: 0x009649B1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_Settings(Pointer, false, true);
		}

		// Token: 0x06021A95 RID: 137877 RVA: 0x009667BB File Offset: 0x009649BB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_Settings(Pointer, MemoryOwner);
		}

		// Token: 0x04012887 RID: 75911
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings.SCameraModifier_Settings";

		// Token: 0x04012888 RID: 75912
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012889 RID: 75913
		internal static int __PropertyOffset_Priority;

		// Token: 0x0401288A RID: 75914
		internal static int __PropertyOffset_IsModifiedArmLength;

		// Token: 0x0401288B RID: 75915
		internal static int __PropertyOffset_ArmLength;

		// Token: 0x0401288C RID: 75916
		internal static int __PropertyOffset_ArmLengthAdditional;

		// Token: 0x0401288D RID: 75917
		internal static int __PropertyOffset_IsModifiedArmRotation;

		// Token: 0x0401288E RID: 75918
		internal static int __PropertyOffset_IsModifiedArmRotationRoll;

		// Token: 0x0401288F RID: 75919
		internal static int __PropertyOffset_IsModifiedArmRotationPitch;

		// Token: 0x04012890 RID: 75920
		internal static int __PropertyOffset_IsModifiedArmRotationYaw;

		// Token: 0x04012891 RID: 75921
		internal static int __PropertyOffset_ArmRotationType;

		// Token: 0x04012892 RID: 75922
		internal static int __PropertyOffset_ArmRotation;

		// Token: 0x04012893 RID: 75923
		internal static int __PropertyOffset_ArmRotationCurve;

		// Token: 0x04012894 RID: 75924
		internal static int __PropertyOffset_ArmRotationAdditionalType;

		// Token: 0x04012895 RID: 75925
		internal static int __PropertyOffset_ArmRotationAdditional;

		// Token: 0x04012896 RID: 75926
		internal static int __PropertyOffset_ArmRotationAdditionalCurve;

		// Token: 0x04012897 RID: 75927
		internal static int __PropertyOffset_IsModifiedCameraOffset;

		// Token: 0x04012898 RID: 75928
		internal static int __PropertyOffset_IsModifiedCameraOffsetX;

		// Token: 0x04012899 RID: 75929
		internal static int __PropertyOffset_IsModifiedCameraOffsetY;

		// Token: 0x0401289A RID: 75930
		internal static int __PropertyOffset_IsModifiedCameraOffsetZ;

		// Token: 0x0401289B RID: 75931
		internal static int __PropertyOffset_CameraOffsetType;

		// Token: 0x0401289C RID: 75932
		internal static int __PropertyOffset_CameraOffset;

		// Token: 0x0401289D RID: 75933
		internal static int __PropertyOffset_CameraOffsetCurve;

		// Token: 0x0401289E RID: 75934
		internal static int __PropertyOffset_CameraOffsetAdditionalType;

		// Token: 0x0401289F RID: 75935
		internal static int __PropertyOffset_CameraOffsetAdditional;

		// Token: 0x040128A0 RID: 75936
		internal static int __PropertyOffset_CameraOffsetAdditionalCurve;

		// Token: 0x040128A1 RID: 75937
		internal static int __PropertyOffset_IsModifiedCameraFov;

		// Token: 0x040128A2 RID: 75938
		internal static int __PropertyOffset_StopModifyOnMontageEnd;

		// Token: 0x040128A3 RID: 75939
		internal static int __PropertyOffset_CameraFov;

		// Token: 0x040128A4 RID: 75940
		internal static int __PropertyOffset_OverrideCameraInput;

		// Token: 0x040128A5 RID: 75941
		internal static int __PropertyOffset_ResetFinalArmRotation;

		// Token: 0x040128A6 RID: 75942
		internal static int __PropertyOffset_IsResetFinalArmRotationToSpecificPitch;

		// Token: 0x040128A7 RID: 75943
		internal static int __PropertyOffset_ResetFinalArmRotationToSpecificPitch;

		// Token: 0x040128A8 RID: 75944
		internal static int __PropertyOffset_IsResetFinalArmRotationToSpecificYaw;

		// Token: 0x040128A9 RID: 75945
		internal static int __PropertyOffset_ResetFinalArmRotationToSpecificYaw;

		// Token: 0x040128AA RID: 75946
		internal static int __PropertyOffset_ResetFinalArmLength;

		// Token: 0x040128AB RID: 75947
		internal static int __PropertyOffset_IsResetFinalArmLengthToSpecificValue;

		// Token: 0x040128AC RID: 75948
		internal static int __PropertyOffset_ResetFinalArmLengthToSpecificValue;

		// Token: 0x040128AD RID: 75949
		internal static int __PropertyOffset_IsResetFinalArmLengthToDynamicValue;

		// Token: 0x040128AE RID: 75950
		internal static int __PropertyOffset_ResetFinalArmLengthToDynamicValue;

		// Token: 0x040128AF RID: 75951
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCameraModifier_Settings_ArmLengthDynamicValue> _ResetFinalArmLengthToDynamicValue;

		// Token: 0x040128B0 RID: 75952
		internal static int __PropertyOffset_IsLockInput;

		// Token: 0x040128B1 RID: 75953
		internal static int __PropertyOffset_IsLerpArmLocation;

		// Token: 0x040128B2 RID: 75954
		internal static int __PropertyOffset_IsSwitchModifier;

		// Token: 0x040128B3 RID: 75955
		internal static int __PropertyOffset_IsForcePlayModify;

		// Token: 0x040128B4 RID: 75956
		internal static int __PropertyOffset_StopModifyOnZoomInput;

		// Token: 0x040128B5 RID: 75957
		internal static int __PropertyOffset_ModifySettingsAdditional;

		// Token: 0x040128B6 RID: 75958
		[Nullable(2)]
		private SCameraModifier_SettingsAdditional _ModifySettingsAdditional;
	}
}
