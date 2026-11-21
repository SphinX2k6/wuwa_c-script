using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003361 RID: 13153
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SReplaceEffect.SReplaceEffect")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SReplaceEffect : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021563 RID: 136547 RVA: 0x0095E5DD File Offset: 0x0095C7DD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReplaceEffect._ScriptStructPtr != 0) ? SReplaceEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SReplaceEffect.SReplaceEffect", ref SReplaceEffect._ScriptStructPtr);
		}

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x06021564 RID: 136548 RVA: 0x0095E601 File Offset: 0x0095C801
		// (set) Token: 0x06021565 RID: 136549 RVA: 0x0095E620 File Offset: 0x0095C820
		public TSoftObjectPtr<UObject> OldEffect
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_OldEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_OldEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x06021566 RID: 136550 RVA: 0x0095E645 File Offset: 0x0095C845
		// (set) Token: 0x06021567 RID: 136551 RVA: 0x0095E664 File Offset: 0x0095C864
		public TSoftObjectPtr<UObject> NewEffect
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_NewEffect, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceEffect.__PropertyOffset_NewEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021568 RID: 136552 RVA: 0x0095E689 File Offset: 0x0095C889
		public SReplaceEffect()
		{
		}

		// Token: 0x06021569 RID: 136553 RVA: 0x0095E691 File Offset: 0x0095C891
		protected override IntPtr GetUStructPtr()
		{
			return SReplaceEffect.StaticStruct();
		}

		// Token: 0x0602156A RID: 136554 RVA: 0x0095E69D File Offset: 0x0095C89D
		[NullableContext(2)]
		public SReplaceEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602156B RID: 136555 RVA: 0x0095E6A7 File Offset: 0x0095C8A7
		public SReplaceEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602156C RID: 136556 RVA: 0x0095E6B2 File Offset: 0x0095C8B2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReplaceEffect(Pointer, false, true);
		}

		// Token: 0x0602156D RID: 136557 RVA: 0x0095E6BC File Offset: 0x0095C8BC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReplaceEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04012389 RID: 74633
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SReplaceEffect.SReplaceEffect";

		// Token: 0x0401238A RID: 74634
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401238B RID: 74635
		internal static int __PropertyOffset_OldEffect;

		// Token: 0x0401238C RID: 74636
		internal static int __PropertyOffset_NewEffect;
	}
}
