using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E0 RID: 13280
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Condition.SCameraModifier_Condition")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class SCameraModifier_Condition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021A03 RID: 137731 RVA: 0x00965BD4 File Offset: 0x00963DD4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Condition._ScriptStructPtr != 0) ? SCameraModifier_Condition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Condition.SCameraModifier_Condition", ref SCameraModifier_Condition._ScriptStructPtr);
		}

		// Token: 0x17004544 RID: 17732
		// (get) Token: 0x06021A04 RID: 137732 RVA: 0x00965BF8 File Offset: 0x00963DF8
		// (set) Token: 0x06021A05 RID: 137733 RVA: 0x00965C0C File Offset: 0x00963E0C
		public unsafe TEnumAsByte<ECameraModifyConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_ConditionType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_ConditionType) = value;
			}
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x06021A06 RID: 137734 RVA: 0x00965C21 File Offset: 0x00963E21
		// (set) Token: 0x06021A07 RID: 137735 RVA: 0x00965C31 File Offset: 0x00963E31
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_AnyTag) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_AnyTag) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x06021A08 RID: 137736 RVA: 0x00965C44 File Offset: 0x00963E44
		// (set) Token: 0x06021A09 RID: 137737 RVA: 0x00965C87 File Offset: 0x00963E87
		[Nullable(1)]
		public FGameplayTagContainer TagToCheck
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TagToCheck) == null)
				{
					result = (this._TagToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_TagToCheck, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_TagToCheck, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x06021A0A RID: 137738 RVA: 0x00965CA8 File Offset: 0x00963EA8
		// (set) Token: 0x06021A0B RID: 137739 RVA: 0x00965CB8 File Offset: 0x00963EB8
		public unsafe float ArmLengthMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_ArmLengthMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_ArmLengthMin) = value;
			}
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x06021A0C RID: 137740 RVA: 0x00965CC9 File Offset: 0x00963EC9
		// (set) Token: 0x06021A0D RID: 137741 RVA: 0x00965CD9 File Offset: 0x00963ED9
		public unsafe float ArmLengthMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_ArmLengthMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_ArmLengthMax) = value;
			}
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x06021A0E RID: 137742 RVA: 0x00965CEA File Offset: 0x00963EEA
		// (set) Token: 0x06021A0F RID: 137743 RVA: 0x00965CFA File Offset: 0x00963EFA
		public unsafe float LockTargetDeltaZMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaZMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaZMin) = value;
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x06021A10 RID: 137744 RVA: 0x00965D0B File Offset: 0x00963F0B
		// (set) Token: 0x06021A11 RID: 137745 RVA: 0x00965D1B File Offset: 0x00963F1B
		public unsafe float LockTargetDeltaZMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaZMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaZMax) = value;
			}
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x06021A12 RID: 137746 RVA: 0x00965D2C File Offset: 0x00963F2C
		// (set) Token: 0x06021A13 RID: 137747 RVA: 0x00965D3C File Offset: 0x00963F3C
		public unsafe float LockTargetDeltaYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaYawMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaYawMin) = value;
			}
		}

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x06021A14 RID: 137748 RVA: 0x00965D4D File Offset: 0x00963F4D
		// (set) Token: 0x06021A15 RID: 137749 RVA: 0x00965D5D File Offset: 0x00963F5D
		public unsafe float LockTargetDeltaYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaYawMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaYawMax) = value;
			}
		}

		// Token: 0x1700454D RID: 17741
		// (get) Token: 0x06021A16 RID: 137750 RVA: 0x00965D6E File Offset: 0x00963F6E
		// (set) Token: 0x06021A17 RID: 137751 RVA: 0x00965D7E File Offset: 0x00963F7E
		public unsafe float LockTargetDeltaPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaPitchMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaPitchMin) = value;
			}
		}

		// Token: 0x1700454E RID: 17742
		// (get) Token: 0x06021A18 RID: 137752 RVA: 0x00965D8F File Offset: 0x00963F8F
		// (set) Token: 0x06021A19 RID: 137753 RVA: 0x00965D9F File Offset: 0x00963F9F
		public unsafe float LockTargetDeltaPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaPitchMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_LockTargetDeltaPitchMax) = value;
			}
		}

		// Token: 0x1700454F RID: 17743
		// (get) Token: 0x06021A1A RID: 137754 RVA: 0x00965DB0 File Offset: 0x00963FB0
		// (set) Token: 0x06021A1B RID: 137755 RVA: 0x00965DC0 File Offset: 0x00963FC0
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_Reverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_Reverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004550 RID: 17744
		// (get) Token: 0x06021A1C RID: 137756 RVA: 0x00965DD1 File Offset: 0x00963FD1
		// (set) Token: 0x06021A1D RID: 137757 RVA: 0x00965DE1 File Offset: 0x00963FE1
		public unsafe float MinLockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_MinLockDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_MinLockDistance) = value;
			}
		}

		// Token: 0x17004551 RID: 17745
		// (get) Token: 0x06021A1E RID: 137758 RVA: 0x00965DF2 File Offset: 0x00963FF2
		// (set) Token: 0x06021A1F RID: 137759 RVA: 0x00965E02 File Offset: 0x00964002
		public unsafe float MaxLockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_MaxLockDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_MaxLockDistance) = value;
			}
		}

		// Token: 0x17004552 RID: 17746
		// (get) Token: 0x06021A20 RID: 137760 RVA: 0x00965E13 File Offset: 0x00964013
		// (set) Token: 0x06021A21 RID: 137761 RVA: 0x00965E27 File Offset: 0x00964027
		public unsafe FName CameraTraceSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CameraTraceSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CameraTraceSocket) = value;
			}
		}

		// Token: 0x17004553 RID: 17747
		// (get) Token: 0x06021A22 RID: 137762 RVA: 0x00965E3C File Offset: 0x0096403C
		// (set) Token: 0x06021A23 RID: 137763 RVA: 0x00965E4C File Offset: 0x0096404C
		public unsafe float CameraTraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CameraTraceRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CameraTraceRadius) = value;
			}
		}

		// Token: 0x17004554 RID: 17748
		// (get) Token: 0x06021A24 RID: 137764 RVA: 0x00965E5D File Offset: 0x0096405D
		// (set) Token: 0x06021A25 RID: 137765 RVA: 0x00965E71 File Offset: 0x00964071
		public unsafe FVector CameraTraceOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CameraTraceOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CameraTraceOffset) = value;
			}
		}

		// Token: 0x17004555 RID: 17749
		// (get) Token: 0x06021A26 RID: 137766 RVA: 0x00965E86 File Offset: 0x00964086
		// (set) Token: 0x06021A27 RID: 137767 RVA: 0x00965E96 File Offset: 0x00964096
		public unsafe float CharacterDeltaYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CharacterDeltaYawMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CharacterDeltaYawMin) = value;
			}
		}

		// Token: 0x17004556 RID: 17750
		// (get) Token: 0x06021A28 RID: 137768 RVA: 0x00965EA7 File Offset: 0x009640A7
		// (set) Token: 0x06021A29 RID: 137769 RVA: 0x00965EB7 File Offset: 0x009640B7
		public unsafe float CharacterDeltaYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CharacterDeltaYawMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_CharacterDeltaYawMax) = value;
			}
		}

		// Token: 0x06021A2A RID: 137770 RVA: 0x00965EC8 File Offset: 0x009640C8
		public SCameraModifier_Condition()
		{
		}

		// Token: 0x06021A2B RID: 137771 RVA: 0x00965ED0 File Offset: 0x009640D0
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_Condition.StaticStruct();
		}

		// Token: 0x06021A2C RID: 137772 RVA: 0x00965EDC File Offset: 0x009640DC
		[NullableContext(2)]
		public SCameraModifier_Condition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021A2D RID: 137773 RVA: 0x00965EE6 File Offset: 0x009640E6
		public SCameraModifier_Condition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021A2E RID: 137774 RVA: 0x00965EF1 File Offset: 0x009640F1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_Condition(Pointer, false, true);
		}

		// Token: 0x06021A2F RID: 137775 RVA: 0x00965EFB File Offset: 0x009640FB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_Condition(Pointer, MemoryOwner);
		}

		// Token: 0x04012866 RID: 75878
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Condition.SCameraModifier_Condition";

		// Token: 0x04012867 RID: 75879
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012868 RID: 75880
		internal static int __PropertyOffset_ConditionType;

		// Token: 0x04012869 RID: 75881
		internal static int __PropertyOffset_AnyTag;

		// Token: 0x0401286A RID: 75882
		internal static int __PropertyOffset_TagToCheck;

		// Token: 0x0401286B RID: 75883
		[Nullable(2)]
		private FGameplayTagContainer _TagToCheck;

		// Token: 0x0401286C RID: 75884
		internal static int __PropertyOffset_ArmLengthMin;

		// Token: 0x0401286D RID: 75885
		internal static int __PropertyOffset_ArmLengthMax;

		// Token: 0x0401286E RID: 75886
		internal static int __PropertyOffset_LockTargetDeltaZMin;

		// Token: 0x0401286F RID: 75887
		internal static int __PropertyOffset_LockTargetDeltaZMax;

		// Token: 0x04012870 RID: 75888
		internal static int __PropertyOffset_LockTargetDeltaYawMin;

		// Token: 0x04012871 RID: 75889
		internal static int __PropertyOffset_LockTargetDeltaYawMax;

		// Token: 0x04012872 RID: 75890
		internal static int __PropertyOffset_LockTargetDeltaPitchMin;

		// Token: 0x04012873 RID: 75891
		internal static int __PropertyOffset_LockTargetDeltaPitchMax;

		// Token: 0x04012874 RID: 75892
		internal static int __PropertyOffset_Reverse;

		// Token: 0x04012875 RID: 75893
		internal static int __PropertyOffset_MinLockDistance;

		// Token: 0x04012876 RID: 75894
		internal static int __PropertyOffset_MaxLockDistance;

		// Token: 0x04012877 RID: 75895
		internal static int __PropertyOffset_CameraTraceSocket;

		// Token: 0x04012878 RID: 75896
		internal static int __PropertyOffset_CameraTraceRadius;

		// Token: 0x04012879 RID: 75897
		internal static int __PropertyOffset_CameraTraceOffset;

		// Token: 0x0401287A RID: 75898
		internal static int __PropertyOffset_CharacterDeltaYawMin;

		// Token: 0x0401287B RID: 75899
		internal static int __PropertyOffset_CharacterDeltaYawMax;
	}
}
