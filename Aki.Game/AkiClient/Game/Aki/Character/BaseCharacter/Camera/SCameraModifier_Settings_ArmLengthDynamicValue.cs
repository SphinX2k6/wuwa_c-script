using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x020043C9 RID: 17353
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings_ArmLengthDynamicValue.SCameraModifier_Settings_ArmLengthDynamicValue")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class SCameraModifier_Settings_ArmLengthDynamicValue : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CEBC RID: 183996 RVA: 0x00A2C4EC File Offset: 0x00A2A6EC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCameraModifier_Settings_ArmLengthDynamicValue._ScriptStructPtr != 0) ? SCameraModifier_Settings_ArmLengthDynamicValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings_ArmLengthDynamicValue.SCameraModifier_Settings_ArmLengthDynamicValue", ref SCameraModifier_Settings_ArmLengthDynamicValue._ScriptStructPtr);
		}

		// Token: 0x17007194 RID: 29076
		// (get) Token: 0x0602CEBD RID: 183997 RVA: 0x00A2C510 File Offset: 0x00A2A710
		// (set) Token: 0x0602CEBE RID: 183998 RVA: 0x00A2C524 File Offset: 0x00A2A724
		public unsafe TEnumAsByte<ECameraModifier_Settings_ArmLengthDynamicValueType> ArmLengthDynamicValueType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17007195 RID: 29077
		// (get) Token: 0x0602CEBF RID: 183999 RVA: 0x00A2C539 File Offset: 0x00A2A739
		// (set) Token: 0x0602CEC0 RID: 184000 RVA: 0x00A2C549 File Offset: 0x00A2A749
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17007196 RID: 29078
		// (get) Token: 0x0602CEC1 RID: 184001 RVA: 0x00A2C55A File Offset: 0x00A2A75A
		// (set) Token: 0x0602CEC2 RID: 184002 RVA: 0x00A2C56A File Offset: 0x00A2A76A
		public unsafe int ArmLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCameraModifier_Settings_ArmLengthDynamicValue.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602CEC3 RID: 184003 RVA: 0x00A2C57B File Offset: 0x00A2A77B
		public SCameraModifier_Settings_ArmLengthDynamicValue()
		{
		}

		// Token: 0x0602CEC4 RID: 184004 RVA: 0x00A2C583 File Offset: 0x00A2A783
		public SCameraModifier_Settings_ArmLengthDynamicValue(TEnumAsByte<ECameraModifier_Settings_ArmLengthDynamicValueType> ArmLengthDynamicValueType, int SkillId, int ArmLength)
		{
			this.ArmLengthDynamicValueType = ArmLengthDynamicValueType;
			this.SkillId = SkillId;
			this.ArmLength = ArmLength;
		}

		// Token: 0x0602CEC5 RID: 184005 RVA: 0x00A2C5A0 File Offset: 0x00A2A7A0
		protected override IntPtr GetUStructPtr()
		{
			return SCameraModifier_Settings_ArmLengthDynamicValue.StaticStruct();
		}

		// Token: 0x0602CEC6 RID: 184006 RVA: 0x00A2C5AC File Offset: 0x00A2A7AC
		[NullableContext(2)]
		public SCameraModifier_Settings_ArmLengthDynamicValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CEC7 RID: 184007 RVA: 0x00A2C5B6 File Offset: 0x00A2A7B6
		public SCameraModifier_Settings_ArmLengthDynamicValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CEC8 RID: 184008 RVA: 0x00A2C5C1 File Offset: 0x00A2A7C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCameraModifier_Settings_ArmLengthDynamicValue(Pointer, false, true);
		}

		// Token: 0x0602CEC9 RID: 184009 RVA: 0x00A2C5CB File Offset: 0x00A2A7CB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCameraModifier_Settings_ArmLengthDynamicValue(Pointer, MemoryOwner);
		}

		// Token: 0x04017D68 RID: 97640
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/SCameraModifier_Settings_ArmLengthDynamicValue.SCameraModifier_Settings_ArmLengthDynamicValue";

		// Token: 0x04017D69 RID: 97641
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017D6A RID: 97642
		internal static int __PropertyOffset_0;

		// Token: 0x04017D6B RID: 97643
		internal static int __PropertyOffset_1;

		// Token: 0x04017D6C RID: 97644
		internal static int __PropertyOffset_2;
	}
}
