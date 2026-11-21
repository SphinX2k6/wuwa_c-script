using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031F9 RID: 12793
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SGameplayTagArray.SGameplayTagArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SGameplayTagArray : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD3F RID: 130367 RVA: 0x00936D10 File Offset: 0x00934F10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayTagArray._ScriptStructPtr != 0) ? SGameplayTagArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SGameplayTagArray.SGameplayTagArray", ref SGameplayTagArray._ScriptStructPtr);
		}

		// Token: 0x17003BB2 RID: 15282
		// (get) Token: 0x0601FD40 RID: 130368 RVA: 0x00936D34 File Offset: 0x00934F34
		// (set) Token: 0x0601FD41 RID: 130369 RVA: 0x00936D77 File Offset: 0x00934F77
		public TArray<FGameplayTag> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SGameplayTagArray.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x0601FD42 RID: 130370 RVA: 0x00936D85 File Offset: 0x00934F85
		public SGameplayTagArray()
		{
		}

		// Token: 0x0601FD43 RID: 130371 RVA: 0x00936D8D File Offset: 0x00934F8D
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayTagArray.StaticStruct();
		}

		// Token: 0x0601FD44 RID: 130372 RVA: 0x00936D99 File Offset: 0x00934F99
		[NullableContext(2)]
		public SGameplayTagArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD45 RID: 130373 RVA: 0x00936DA3 File Offset: 0x00934FA3
		public SGameplayTagArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD46 RID: 130374 RVA: 0x00936DAE File Offset: 0x00934FAE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayTagArray(Pointer, false, true);
		}

		// Token: 0x0601FD47 RID: 130375 RVA: 0x00936DB8 File Offset: 0x00934FB8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayTagArray(Pointer, MemoryOwner);
		}

		// Token: 0x04011173 RID: 70003
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SGameplayTagArray.SGameplayTagArray";

		// Token: 0x04011174 RID: 70004
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011175 RID: 70005
		internal static int __PropertyOffset_Value;

		// Token: 0x04011176 RID: 70006
		[Nullable(2)]
		private TArray<FGameplayTag> _Value;
	}
}
