using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C5 RID: 17349
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Condition.SCameraModifier_Condition")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class SCameraModifier_Condition : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CDFD RID: 183805 RVA: 0x00A2B205 File Offset: 0x00A29405
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Condition._ScriptStructPtr != 0) ? SCameraModifier_Condition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Condition.SCameraModifier_Condition", ref SCameraModifier_Condition._ScriptStructPtr);
		}

		// Token: 0x17007144 RID: 28996
		// (get) Token: 0x0602CDFE RID: 183806 RVA: 0x00A2B229 File Offset: 0x00A29429
		// (set) Token: 0x0602CDFF RID: 183807 RVA: 0x00A2B23D File Offset: 0x00A2943D
		public unsafe TEnumAsByte<ECameraModifyConditionType> ConditionType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007145 RID: 28997
		// (get) Token: 0x0602CE00 RID: 183808 RVA: 0x00A2B252 File Offset: 0x00A29452
		// (set) Token: 0x0602CE01 RID: 183809 RVA: 0x00A2B262 File Offset: 0x00A29462
		public unsafe bool AnyTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_1) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_1) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007146 RID: 28998
		// (get) Token: 0x0602CE02 RID: 183810 RVA: 0x00A2B274 File Offset: 0x00A29474
		// (set) Token: 0x0602CE03 RID: 183811 RVA: 0x00A2B2B7 File Offset: 0x00A294B7
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
					result = (this._TagToCheck = new FGameplayTagContainer(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_2, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007147 RID: 28999
		// (get) Token: 0x0602CE04 RID: 183812 RVA: 0x00A2B2D8 File Offset: 0x00A294D8
		// (set) Token: 0x0602CE05 RID: 183813 RVA: 0x00A2B2E8 File Offset: 0x00A294E8
		public unsafe float ArmLengthMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17007148 RID: 29000
		// (get) Token: 0x0602CE06 RID: 183814 RVA: 0x00A2B2F9 File Offset: 0x00A294F9
		// (set) Token: 0x0602CE07 RID: 183815 RVA: 0x00A2B309 File Offset: 0x00A29509
		public unsafe float ArmLengthMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17007149 RID: 29001
		// (get) Token: 0x0602CE08 RID: 183816 RVA: 0x00A2B31A File Offset: 0x00A2951A
		// (set) Token: 0x0602CE09 RID: 183817 RVA: 0x00A2B32A File Offset: 0x00A2952A
		public unsafe float LockTargetDeltaZMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x1700714A RID: 29002
		// (get) Token: 0x0602CE0A RID: 183818 RVA: 0x00A2B33B File Offset: 0x00A2953B
		// (set) Token: 0x0602CE0B RID: 183819 RVA: 0x00A2B34B File Offset: 0x00A2954B
		public unsafe float LockTargetDeltaZMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700714B RID: 29003
		// (get) Token: 0x0602CE0C RID: 183820 RVA: 0x00A2B35C File Offset: 0x00A2955C
		// (set) Token: 0x0602CE0D RID: 183821 RVA: 0x00A2B36C File Offset: 0x00A2956C
		public unsafe float LockTargetDeltaYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700714C RID: 29004
		// (get) Token: 0x0602CE0E RID: 183822 RVA: 0x00A2B37D File Offset: 0x00A2957D
		// (set) Token: 0x0602CE0F RID: 183823 RVA: 0x00A2B38D File Offset: 0x00A2958D
		public unsafe float LockTargetDeltaYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x1700714D RID: 29005
		// (get) Token: 0x0602CE10 RID: 183824 RVA: 0x00A2B39E File Offset: 0x00A2959E
		// (set) Token: 0x0602CE11 RID: 183825 RVA: 0x00A2B3AE File Offset: 0x00A295AE
		public unsafe float LockTargetDeltaPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700714E RID: 29006
		// (get) Token: 0x0602CE12 RID: 183826 RVA: 0x00A2B3BF File Offset: 0x00A295BF
		// (set) Token: 0x0602CE13 RID: 183827 RVA: 0x00A2B3CF File Offset: 0x00A295CF
		public unsafe float LockTargetDeltaPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x1700714F RID: 29007
		// (get) Token: 0x0602CE14 RID: 183828 RVA: 0x00A2B3E0 File Offset: 0x00A295E0
		// (set) Token: 0x0602CE15 RID: 183829 RVA: 0x00A2B3F0 File Offset: 0x00A295F0
		public unsafe bool Reverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_11) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_11) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007150 RID: 29008
		// (get) Token: 0x0602CE16 RID: 183830 RVA: 0x00A2B401 File Offset: 0x00A29601
		// (set) Token: 0x0602CE17 RID: 183831 RVA: 0x00A2B411 File Offset: 0x00A29611
		public unsafe float MinLockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17007151 RID: 29009
		// (get) Token: 0x0602CE18 RID: 183832 RVA: 0x00A2B422 File Offset: 0x00A29622
		// (set) Token: 0x0602CE19 RID: 183833 RVA: 0x00A2B432 File Offset: 0x00A29632
		public unsafe float MaxLockDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17007152 RID: 29010
		// (get) Token: 0x0602CE1A RID: 183834 RVA: 0x00A2B443 File Offset: 0x00A29643
		// (set) Token: 0x0602CE1B RID: 183835 RVA: 0x00A2B457 File Offset: 0x00A29657
		public unsafe FName CameraTraceSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17007153 RID: 29011
		// (get) Token: 0x0602CE1C RID: 183836 RVA: 0x00A2B46C File Offset: 0x00A2966C
		// (set) Token: 0x0602CE1D RID: 183837 RVA: 0x00A2B47C File Offset: 0x00A2967C
		public unsafe float CameraTraceRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17007154 RID: 29012
		// (get) Token: 0x0602CE1E RID: 183838 RVA: 0x00A2B48D File Offset: 0x00A2968D
		// (set) Token: 0x0602CE1F RID: 183839 RVA: 0x00A2B4A1 File Offset: 0x00A296A1
		public unsafe FVector CameraTraceOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_16);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_16) = value;
			}
		}

		// Token: 0x17007155 RID: 29013
		// (get) Token: 0x0602CE20 RID: 183840 RVA: 0x00A2B4B6 File Offset: 0x00A296B6
		// (set) Token: 0x0602CE21 RID: 183841 RVA: 0x00A2B4C6 File Offset: 0x00A296C6
		public unsafe float CharacterDeltaYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17007156 RID: 29014
		// (get) Token: 0x0602CE22 RID: 183842 RVA: 0x00A2B4D7 File Offset: 0x00A296D7
		// (set) Token: 0x0602CE23 RID: 183843 RVA: 0x00A2B4E7 File Offset: 0x00A296E7
		public unsafe float CharacterDeltaYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Condition.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x0602CE24 RID: 183844 RVA: 0x00A2B4F8 File Offset: 0x00A296F8
		public SCameraModifier_Condition()
		{
		}

		// Token: 0x0602CE25 RID: 183845 RVA: 0x00A2B500 File Offset: 0x00A29700
		public SCameraModifier_Condition(TEnumAsByte<ECameraModifyConditionType> ConditionType, bool AnyTag, [Nullable(1)] FGameplayTagContainer TagToCheck, float ArmLengthMin, float ArmLengthMax, float LockTargetDeltaZMin, float LockTargetDeltaZMax, float LockTargetDeltaYawMin, float LockTargetDeltaYawMax, float LockTargetDeltaPitchMin, float LockTargetDeltaPitchMax, bool Reverse, float MinLockDistance, float MaxLockDistance, FName CameraTraceSocket, float CameraTraceRadius, FVector CameraTraceOffset, float CharacterDeltaYawMin, float CharacterDeltaYawMax)
		{
			this.ConditionType = ConditionType;
			this.AnyTag = AnyTag;
			this.TagToCheck = TagToCheck;
			this.ArmLengthMin = ArmLengthMin;
			this.ArmLengthMax = ArmLengthMax;
			this.LockTargetDeltaZMin = LockTargetDeltaZMin;
			this.LockTargetDeltaZMax = LockTargetDeltaZMax;
			this.LockTargetDeltaYawMin = LockTargetDeltaYawMin;
			this.LockTargetDeltaYawMax = LockTargetDeltaYawMax;
			this.LockTargetDeltaPitchMin = LockTargetDeltaPitchMin;
			this.LockTargetDeltaPitchMax = LockTargetDeltaPitchMax;
			this.Reverse = Reverse;
			this.MinLockDistance = MinLockDistance;
			this.MaxLockDistance = MaxLockDistance;
			this.CameraTraceSocket = CameraTraceSocket;
			this.CameraTraceRadius = CameraTraceRadius;
			this.CameraTraceOffset = CameraTraceOffset;
			this.CharacterDeltaYawMin = CharacterDeltaYawMin;
			this.CharacterDeltaYawMax = CharacterDeltaYawMax;
		}

		// Token: 0x0602CE26 RID: 183846 RVA: 0x00A2B5A8 File Offset: 0x00A297A8
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_Condition.StaticStruct();
		}

		// Token: 0x0602CE27 RID: 183847 RVA: 0x00A2B5B4 File Offset: 0x00A297B4
		[NullableContext(2)]
		public SCameraModifier_Condition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CE28 RID: 183848 RVA: 0x00A2B5BE File Offset: 0x00A297BE
		public SCameraModifier_Condition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CE29 RID: 183849 RVA: 0x00A2B5C9 File Offset: 0x00A297C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_Condition(Pointer, false, true);
		}

		// Token: 0x0602CE2A RID: 183850 RVA: 0x00A2B5D3 File Offset: 0x00A297D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_Condition(Pointer, MemoryOwner);
		}

		// Token: 0x04017CFE RID: 97534
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Condition.SCameraModifier_Condition";

		// Token: 0x04017CFF RID: 97535
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D00 RID: 97536
		internal static int __PropertyOffset_0;

		// Token: 0x04017D01 RID: 97537
		internal static int __PropertyOffset_1;

		// Token: 0x04017D02 RID: 97538
		internal static int __PropertyOffset_2;

		// Token: 0x04017D03 RID: 97539
		[Nullable(2)]
		private FGameplayTagContainer _TagToCheck;

		// Token: 0x04017D04 RID: 97540
		internal static int __PropertyOffset_3;

		// Token: 0x04017D05 RID: 97541
		internal static int __PropertyOffset_4;

		// Token: 0x04017D06 RID: 97542
		internal static int __PropertyOffset_5;

		// Token: 0x04017D07 RID: 97543
		internal static int __PropertyOffset_6;

		// Token: 0x04017D08 RID: 97544
		internal static int __PropertyOffset_7;

		// Token: 0x04017D09 RID: 97545
		internal static int __PropertyOffset_8;

		// Token: 0x04017D0A RID: 97546
		internal static int __PropertyOffset_9;

		// Token: 0x04017D0B RID: 97547
		internal static int __PropertyOffset_10;

		// Token: 0x04017D0C RID: 97548
		internal static int __PropertyOffset_11;

		// Token: 0x04017D0D RID: 97549
		internal static int __PropertyOffset_12;

		// Token: 0x04017D0E RID: 97550
		internal static int __PropertyOffset_13;

		// Token: 0x04017D0F RID: 97551
		internal static int __PropertyOffset_14;

		// Token: 0x04017D10 RID: 97552
		internal static int __PropertyOffset_15;

		// Token: 0x04017D11 RID: 97553
		internal static int __PropertyOffset_16;

		// Token: 0x04017D12 RID: 97554
		internal static int __PropertyOffset_17;

		// Token: 0x04017D13 RID: 97555
		internal static int __PropertyOffset_18;
	}
}
