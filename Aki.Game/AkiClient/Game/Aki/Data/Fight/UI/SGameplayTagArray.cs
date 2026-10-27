using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F53 RID: 16211
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SGameplayTagArray.SGameplayTagArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SGameplayTagArray : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029468 RID: 169064 RVA: 0x009C0209 File Offset: 0x009BE409
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SGameplayTagArray._ScriptStructPtr != 0) ? SGameplayTagArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SGameplayTagArray.SGameplayTagArray", ref SGameplayTagArray._ScriptStructPtr);
		}

		// Token: 0x17006268 RID: 25192
		// (get) Token: 0x06029469 RID: 169065 RVA: 0x009C0230 File Offset: 0x009BE430
		// (set) Token: 0x0602946A RID: 169066 RVA: 0x009C0273 File Offset: 0x009BE473
		public TArray<FGameplayTag> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)SGameplayTagArray.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x0602946B RID: 169067 RVA: 0x009C0281 File Offset: 0x009BE481
		public SGameplayTagArray()
		{
		}

		// Token: 0x0602946C RID: 169068 RVA: 0x009C0289 File Offset: 0x009BE489
		public SGameplayTagArray(TArray<FGameplayTag> Value)
		{
			this.Value = Value;
		}

		// Token: 0x0602946D RID: 169069 RVA: 0x009C0298 File Offset: 0x009BE498
		protected override IntPtr GetUStructPtr()
		{
			return SGameplayTagArray.StaticStruct();
		}

		// Token: 0x0602946E RID: 169070 RVA: 0x009C02A4 File Offset: 0x009BE4A4
		[NullableContext(2)]
		public SGameplayTagArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602946F RID: 169071 RVA: 0x009C02AE File Offset: 0x009BE4AE
		public SGameplayTagArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029470 RID: 169072 RVA: 0x009C02B9 File Offset: 0x009BE4B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SGameplayTagArray(Pointer, false, true);
		}

		// Token: 0x06029471 RID: 169073 RVA: 0x009C02C3 File Offset: 0x009BE4C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SGameplayTagArray(Pointer, MemoryOwner);
		}

		// Token: 0x0401525B RID: 86619
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SGameplayTagArray.SGameplayTagArray";

		// Token: 0x0401525C RID: 86620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401525D RID: 86621
		internal static int __PropertyOffset_0;

		// Token: 0x0401525E RID: 86622
		[Nullable(2)]
		private TArray<FGameplayTag> _Value;
	}
}
