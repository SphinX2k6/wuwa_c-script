using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003362 RID: 13154
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SReplaceMontage.SReplaceMontage")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class SReplaceMontage : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602156E RID: 136558 RVA: 0x0095E6C5 File Offset: 0x0095C8C5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SReplaceMontage._ScriptStructPtr != 0) ? SReplaceMontage._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SReplaceMontage.SReplaceMontage", ref SReplaceMontage._ScriptStructPtr);
		}

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x0602156F RID: 136559 RVA: 0x0095E6E9 File Offset: 0x0095C8E9
		// (set) Token: 0x06021570 RID: 136560 RVA: 0x0095E708 File Offset: 0x0095C908
		public TSoftObjectPtr<UAnimMontage> OldMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_OldMontage, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_OldMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x06021571 RID: 136561 RVA: 0x0095E72D File Offset: 0x0095C92D
		// (set) Token: 0x06021572 RID: 136562 RVA: 0x0095E74C File Offset: 0x0095C94C
		public TSoftObjectPtr<UAnimMontage> NewMontage
		{
			get
			{
				return new TSoftObjectPtr<UAnimMontage>(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_NewMontage, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)SReplaceMontage.__PropertyOffset_NewMontage, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x06021573 RID: 136563 RVA: 0x0095E771 File Offset: 0x0095C971
		public SReplaceMontage()
		{
		}

		// Token: 0x06021574 RID: 136564 RVA: 0x0095E779 File Offset: 0x0095C979
		protected override IntPtr GetUStructPtr()
		{
			return SReplaceMontage.StaticStruct();
		}

		// Token: 0x06021575 RID: 136565 RVA: 0x0095E785 File Offset: 0x0095C985
		[NullableContext(2)]
		public SReplaceMontage(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021576 RID: 136566 RVA: 0x0095E78F File Offset: 0x0095C98F
		public SReplaceMontage(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021577 RID: 136567 RVA: 0x0095E79A File Offset: 0x0095C99A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SReplaceMontage(Pointer, false, true);
		}

		// Token: 0x06021578 RID: 136568 RVA: 0x0095E7A4 File Offset: 0x0095C9A4
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SReplaceMontage(Pointer, MemoryOwner);
		}

		// Token: 0x0401238D RID: 74637
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SReplaceMontage.SReplaceMontage";

		// Token: 0x0401238E RID: 74638
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401238F RID: 74639
		internal static int __PropertyOffset_OldMontage;

		// Token: 0x04012390 RID: 74640
		internal static int __PropertyOffset_NewMontage;
	}
}
