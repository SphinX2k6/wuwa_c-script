using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003347 RID: 13127
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCustomValueFormula.SCustomValueFormula")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 33)]
	public class SCustomValueFormula : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021341 RID: 136001 RVA: 0x0095B940 File Offset: 0x00959B40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCustomValueFormula._ScriptStructPtr != 0) ? SCustomValueFormula._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCustomValueFormula.SCustomValueFormula", ref SCustomValueFormula._ScriptStructPtr);
		}

		// Token: 0x17004320 RID: 17184
		// (get) Token: 0x06021342 RID: 136002 RVA: 0x0095B964 File Offset: 0x00959B64
		// (set) Token: 0x06021343 RID: 136003 RVA: 0x0095B978 File Offset: 0x00959B78
		public unsafe string Condition
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_Condition)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_Condition)), value);
			}
		}

		// Token: 0x17004321 RID: 17185
		// (get) Token: 0x06021344 RID: 136004 RVA: 0x0095B98D File Offset: 0x00959B8D
		// (set) Token: 0x06021345 RID: 136005 RVA: 0x0095B9A1 File Offset: 0x00959BA1
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueFormula.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x17004322 RID: 17186
		// (get) Token: 0x06021346 RID: 136006 RVA: 0x0095B9B6 File Offset: 0x00959BB6
		// (set) Token: 0x06021347 RID: 136007 RVA: 0x0095B9C6 File Offset: 0x00959BC6
		public unsafe bool IsContinueFormula
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueFormula.__PropertyOffset_IsContinueFormula) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueFormula.__PropertyOffset_IsContinueFormula) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021348 RID: 136008 RVA: 0x0095B9D7 File Offset: 0x00959BD7
		public SCustomValueFormula()
		{
		}

		// Token: 0x06021349 RID: 136009 RVA: 0x0095B9DF File Offset: 0x00959BDF
		protected override IntPtr GetUStructPtr()
		{
			return SCustomValueFormula.StaticStruct();
		}

		// Token: 0x0602134A RID: 136010 RVA: 0x0095B9EB File Offset: 0x00959BEB
		[NullableContext(2)]
		public SCustomValueFormula(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602134B RID: 136011 RVA: 0x0095B9F5 File Offset: 0x00959BF5
		public SCustomValueFormula(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602134C RID: 136012 RVA: 0x0095BA00 File Offset: 0x00959C00
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCustomValueFormula(Pointer, false, true);
		}

		// Token: 0x0602134D RID: 136013 RVA: 0x0095BA0A File Offset: 0x00959C0A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCustomValueFormula(Pointer, MemoryOwner);
		}

		// Token: 0x04012277 RID: 74359
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCustomValueFormula.SCustomValueFormula";

		// Token: 0x04012278 RID: 74360
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012279 RID: 74361
		internal static int __PropertyOffset_Condition;

		// Token: 0x0401227A RID: 74362
		internal static int __PropertyOffset_Value;

		// Token: 0x0401227B RID: 74363
		internal static int __PropertyOffset_IsContinueFormula;
	}
}
