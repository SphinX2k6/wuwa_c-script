using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.Input.Structures
{
	// Token: 0x020032CF RID: 13007
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/Input/Structures/sInputCommand.SInputCommand")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class SInputCommand : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020F46 RID: 134982 RVA: 0x0095371E File Offset: 0x0095191E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInputCommand._ScriptStructPtr != 0) ? SInputCommand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/Input/Structures/sInputCommand.SInputCommand", ref SInputCommand._ScriptStructPtr);
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x06020F47 RID: 134983 RVA: 0x00953742 File Offset: 0x00951942
		// (set) Token: 0x06020F48 RID: 134984 RVA: 0x00953756 File Offset: 0x00951956
		public unsafe TEnumAsByte<ECommandType> CommandType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_CommandType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_CommandType) = value;
			}
		}

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x06020F49 RID: 134985 RVA: 0x0095376B File Offset: 0x0095196B
		// (set) Token: 0x06020F4A RID: 134986 RVA: 0x0095377B File Offset: 0x0095197B
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x06020F4B RID: 134987 RVA: 0x0095378C File Offset: 0x0095198C
		// (set) Token: 0x06020F4C RID: 134988 RVA: 0x009537A0 File Offset: 0x009519A0
		public unsafe FGameplayTag TagValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_TagValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SInputCommand.__PropertyOffset_TagValue) = value;
			}
		}

		// Token: 0x06020F4D RID: 134989 RVA: 0x009537B5 File Offset: 0x009519B5
		public SInputCommand()
		{
		}

		// Token: 0x06020F4E RID: 134990 RVA: 0x009537BD File Offset: 0x009519BD
		protected override IntPtr GetUStructPtr()
		{
			return SInputCommand.StaticStruct();
		}

		// Token: 0x06020F4F RID: 134991 RVA: 0x009537C9 File Offset: 0x009519C9
		[NullableContext(2)]
		public SInputCommand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020F50 RID: 134992 RVA: 0x009537D3 File Offset: 0x009519D3
		public SInputCommand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020F51 RID: 134993 RVA: 0x009537DE File Offset: 0x009519DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInputCommand(Pointer, false, true);
		}

		// Token: 0x06020F52 RID: 134994 RVA: 0x009537E8 File Offset: 0x009519E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInputCommand(Pointer, MemoryOwner);
		}

		// Token: 0x04011DA3 RID: 73123
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/Input/Structures/sInputCommand.SInputCommand";

		// Token: 0x04011DA4 RID: 73124
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011DA5 RID: 73125
		internal static int __PropertyOffset_CommandType;

		// Token: 0x04011DA6 RID: 73126
		internal static int __PropertyOffset_IntValue;

		// Token: 0x04011DA7 RID: 73127
		internal static int __PropertyOffset_TagValue;
	}
}
