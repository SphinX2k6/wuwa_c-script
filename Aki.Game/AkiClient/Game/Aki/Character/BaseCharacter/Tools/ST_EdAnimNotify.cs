using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Tools
{
	// Token: 0x02004347 RID: 17223
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Tools/ST_EdAnimNotify.ST_EdAnimNotify")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class ST_EdAnimNotify : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602CA96 RID: 182934 RVA: 0x00A253C0 File Offset: 0x00A235C0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (ST_EdAnimNotify._ScriptStructPtr != 0) ? ST_EdAnimNotify._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/Tools/ST_EdAnimNotify.ST_EdAnimNotify", ref ST_EdAnimNotify._ScriptStructPtr);
		}

		// Token: 0x17007061 RID: 28769
		// (get) Token: 0x0602CA97 RID: 182935 RVA: 0x00A253E4 File Offset: 0x00A235E4
		// (set) Token: 0x0602CA98 RID: 182936 RVA: 0x00A253F8 File Offset: 0x00A235F8
		public unsafe FGameplayTag tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ST_EdAnimNotify.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ST_EdAnimNotify.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x0602CA99 RID: 182937 RVA: 0x00A2540D File Offset: 0x00A2360D
		public ST_EdAnimNotify()
		{
		}

		// Token: 0x0602CA9A RID: 182938 RVA: 0x00A25415 File Offset: 0x00A23615
		public ST_EdAnimNotify(FGameplayTag tag)
		{
			this.tag = tag;
		}

		// Token: 0x0602CA9B RID: 182939 RVA: 0x00A25424 File Offset: 0x00A23624
		protected override IntPtr GetUStructPtr()
		{
			return ST_EdAnimNotify.StaticStruct();
		}

		// Token: 0x0602CA9C RID: 182940 RVA: 0x00A25430 File Offset: 0x00A23630
		[NullableContext(2)]
		public ST_EdAnimNotify(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602CA9D RID: 182941 RVA: 0x00A2543A File Offset: 0x00A2363A
		public ST_EdAnimNotify(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602CA9E RID: 182942 RVA: 0x00A25445 File Offset: 0x00A23645
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new ST_EdAnimNotify(Pointer, false, true);
		}

		// Token: 0x0602CA9F RID: 182943 RVA: 0x00A2544F File Offset: 0x00A2364F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new ST_EdAnimNotify(Pointer, MemoryOwner);
		}

		// Token: 0x040178BD RID: 96445
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Tools/ST_EdAnimNotify.ST_EdAnimNotify";

		// Token: 0x040178BE RID: 96446
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040178BF RID: 96447
		internal static int __PropertyOffset_0;
	}
}
