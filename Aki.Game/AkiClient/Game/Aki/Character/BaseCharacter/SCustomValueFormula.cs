using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004309 RID: 17161
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCustomValueFormula.SCustomValueFormula")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 33)]
	public class SCustomValueFormula : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C619 RID: 181785 RVA: 0x00A1E8BD File Offset: 0x00A1CABD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCustomValueFormula._ScriptStructPtr != 0) ? SCustomValueFormula._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCustomValueFormula.SCustomValueFormula", ref SCustomValueFormula._ScriptStructPtr);
		}

		// Token: 0x17006F02 RID: 28418
		// (get) Token: 0x0602C61A RID: 181786 RVA: 0x00A1E8E1 File Offset: 0x00A1CAE1
		// (set) Token: 0x0602C61B RID: 181787 RVA: 0x00A1E8F5 File Offset: 0x00A1CAF5
		public unsafe string Condition
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006F03 RID: 28419
		// (get) Token: 0x0602C61C RID: 181788 RVA: 0x00A1E90A File Offset: 0x00A1CB0A
		// (set) Token: 0x0602C61D RID: 181789 RVA: 0x00A1E91E File Offset: 0x00A1CB1E
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006F04 RID: 28420
		// (get) Token: 0x0602C61E RID: 181790 RVA: 0x00A1E933 File Offset: 0x00A1CB33
		// (set) Token: 0x0602C61F RID: 181791 RVA: 0x00A1E943 File Offset: 0x00A1CB43
		public unsafe bool IsContinueFormula
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueFormula.__PropertyOffset_2) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueFormula.__PropertyOffset_2) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C620 RID: 181792 RVA: 0x00A1E954 File Offset: 0x00A1CB54
		public SCustomValueFormula()
		{
		}

		// Token: 0x0602C621 RID: 181793 RVA: 0x00A1E95C File Offset: 0x00A1CB5C
		public SCustomValueFormula(string Condition, string Value, bool IsContinueFormula)
		{
			this.Condition = Condition;
			this.Value = Value;
			this.IsContinueFormula = IsContinueFormula;
		}

		// Token: 0x0602C622 RID: 181794 RVA: 0x00A1E979 File Offset: 0x00A1CB79
		protected override IntPtr GetUStructPtr()
		{
			return SCustomValueFormula.StaticStruct();
		}

		// Token: 0x0602C623 RID: 181795 RVA: 0x00A1E985 File Offset: 0x00A1CB85
		[NullableContext(2)]
		public SCustomValueFormula(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C624 RID: 181796 RVA: 0x00A1E98F File Offset: 0x00A1CB8F
		public SCustomValueFormula(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C625 RID: 181797 RVA: 0x00A1E99A File Offset: 0x00A1CB9A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCustomValueFormula(Pointer, false, true);
		}

		// Token: 0x0602C626 RID: 181798 RVA: 0x00A1E9A4 File Offset: 0x00A1CBA4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCustomValueFormula(Pointer, MemoryOwner);
		}

		// Token: 0x0401766E RID: 95854
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCustomValueFormula.SCustomValueFormula";

		// Token: 0x0401766F RID: 95855
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017670 RID: 95856
		internal static int __PropertyOffset_0;

		// Token: 0x04017671 RID: 95857
		internal static int __PropertyOffset_1;

		// Token: 0x04017672 RID: 95858
		internal static int __PropertyOffset_2;
	}
}
