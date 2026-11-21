using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020033E4 RID: 13284
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings_ArmLengthDynamicValue.SCameraModifier_Settings_ArmLengthDynamicValue")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class SCameraModifier_Settings_ArmLengthDynamicValue : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021ABF RID: 137919 RVA: 0x00966C0C File Offset: 0x00964E0C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Settings_ArmLengthDynamicValue._ScriptStructPtr != 0) ? SCameraModifier_Settings_ArmLengthDynamicValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings_ArmLengthDynamicValue.SCameraModifier_Settings_ArmLengthDynamicValue", ref SCameraModifier_Settings_ArmLengthDynamicValue._ScriptStructPtr);
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x06021AC0 RID: 137920 RVA: 0x00966C30 File Offset: 0x00964E30
		// (set) Token: 0x06021AC1 RID: 137921 RVA: 0x00966C44 File Offset: 0x00964E44
		public unsafe TEnumAsByte<ECameraModifier_Settings_ArmLengthDynamicValueType> ArmLengthDynamicValueType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_ArmLengthDynamicValueType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_ArmLengthDynamicValueType) = value;
			}
		}

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x06021AC2 RID: 137922 RVA: 0x00966C59 File Offset: 0x00964E59
		// (set) Token: 0x06021AC3 RID: 137923 RVA: 0x00966C69 File Offset: 0x00964E69
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x06021AC4 RID: 137924 RVA: 0x00966C7A File Offset: 0x00964E7A
		// (set) Token: 0x06021AC5 RID: 137925 RVA: 0x00966C8A File Offset: 0x00964E8A
		public unsafe int ArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_ArmLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_ArmLength) = value;
			}
		}

		// Token: 0x06021AC6 RID: 137926 RVA: 0x00966C9B File Offset: 0x00964E9B
		public SCameraModifier_Settings_ArmLengthDynamicValue()
		{
		}

		// Token: 0x06021AC7 RID: 137927 RVA: 0x00966CA3 File Offset: 0x00964EA3
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_Settings_ArmLengthDynamicValue.StaticStruct();
		}

		// Token: 0x06021AC8 RID: 137928 RVA: 0x00966CAF File Offset: 0x00964EAF
		[NullableContext(2)]
		public SCameraModifier_Settings_ArmLengthDynamicValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021AC9 RID: 137929 RVA: 0x00966CB9 File Offset: 0x00964EB9
		public SCameraModifier_Settings_ArmLengthDynamicValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021ACA RID: 137930 RVA: 0x00966CC4 File Offset: 0x00964EC4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_Settings_ArmLengthDynamicValue(Pointer, false, true);
		}

		// Token: 0x06021ACB RID: 137931 RVA: 0x00966CCE File Offset: 0x00964ECE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_Settings_ArmLengthDynamicValue(Pointer, MemoryOwner);
		}

		// Token: 0x040128D0 RID: 75984
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings_ArmLengthDynamicValue.SCameraModifier_Settings_ArmLengthDynamicValue";

		// Token: 0x040128D1 RID: 75985
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040128D2 RID: 75986
		internal static int __PropertyOffset_ArmLengthDynamicValueType;

		// Token: 0x040128D3 RID: 75987
		internal static int __PropertyOffset_SkillId;

		// Token: 0x040128D4 RID: 75988
		internal static int __PropertyOffset_ArmLength;
	}
}
