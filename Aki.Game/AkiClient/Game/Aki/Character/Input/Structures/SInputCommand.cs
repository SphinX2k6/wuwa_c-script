using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x0200425B RID: 16987
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/sInputCommand.SInputCommand")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SInputCommand : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C05D RID: 180317 RVA: 0x00A1210A File Offset: 0x00A1030A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputCommand._ScriptStructPtr != 0) ? SInputCommand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/sInputCommand.SInputCommand", ref SInputCommand._ScriptStructPtr);
		}

		// Token: 0x17006D59 RID: 27993
		// (get) Token: 0x0602C05E RID: 180318 RVA: 0x00A1212E File Offset: 0x00A1032E
		// (set) Token: 0x0602C05F RID: 180319 RVA: 0x00A12142 File Offset: 0x00A10342
		public unsafe TEnumAsByte<ECommandType> CommandType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006D5A RID: 27994
		// (get) Token: 0x0602C060 RID: 180320 RVA: 0x00A12157 File Offset: 0x00A10357
		// (set) Token: 0x0602C061 RID: 180321 RVA: 0x00A12167 File Offset: 0x00A10367
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006D5B RID: 27995
		// (get) Token: 0x0602C062 RID: 180322 RVA: 0x00A12178 File Offset: 0x00A10378
		// (set) Token: 0x0602C063 RID: 180323 RVA: 0x00A1218C File Offset: 0x00A1038C
		public unsafe FGameplayTag TagValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602C064 RID: 180324 RVA: 0x00A121A1 File Offset: 0x00A103A1
		public SInputCommand()
		{
		}

		// Token: 0x0602C065 RID: 180325 RVA: 0x00A121A9 File Offset: 0x00A103A9
		public SInputCommand(TEnumAsByte<ECommandType> CommandType, int IntValue, FGameplayTag TagValue)
		{
			this.CommandType = CommandType;
			this.IntValue = IntValue;
			this.TagValue = TagValue;
		}

		// Token: 0x0602C066 RID: 180326 RVA: 0x00A121C6 File Offset: 0x00A103C6
		protected override IntPtr GetUStructPtr()
		{
			return SInputCommand.StaticStruct();
		}

		// Token: 0x0602C067 RID: 180327 RVA: 0x00A121D2 File Offset: 0x00A103D2
		[NullableContext(2)]
		public SInputCommand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C068 RID: 180328 RVA: 0x00A121DC File Offset: 0x00A103DC
		public SInputCommand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C069 RID: 180329 RVA: 0x00A121E7 File Offset: 0x00A103E7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputCommand(Pointer, false, true);
		}

		// Token: 0x0602C06A RID: 180330 RVA: 0x00A121F1 File Offset: 0x00A103F1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputCommand(Pointer, MemoryOwner);
		}

		// Token: 0x04016FF5 RID: 94197
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/sInputCommand.SInputCommand";

		// Token: 0x04016FF6 RID: 94198
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016FF7 RID: 94199
		internal static int __PropertyOffset_0;

		// Token: 0x04016FF8 RID: 94200
		internal static int __PropertyOffset_1;

		// Token: 0x04016FF9 RID: 94201
		internal static int __PropertyOffset_2;
	}
}
