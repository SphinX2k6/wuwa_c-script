using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F54 RID: 16212
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SInt64Array.SInt64Array")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SInt64Array : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029472 RID: 169074 RVA: 0x009C02CC File Offset: 0x009BE4CC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInt64Array._ScriptStructPtr != 0) ? SInt64Array._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SInt64Array.SInt64Array", ref SInt64Array._ScriptStructPtr);
		}

		// Token: 0x17006269 RID: 25193
		// (get) Token: 0x06029473 RID: 169075 RVA: 0x009C02F0 File Offset: 0x009BE4F0
		// (set) Token: 0x06029474 RID: 169076 RVA: 0x009C0333 File Offset: 0x009BE533
		public TArray<long> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<long>(base.NativePtr + (IntPtr)SInt64Array.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x06029475 RID: 169077 RVA: 0x009C0341 File Offset: 0x009BE541
		public SInt64Array()
		{
		}

		// Token: 0x06029476 RID: 169078 RVA: 0x009C0349 File Offset: 0x009BE549
		public SInt64Array(TArray<long> Value)
		{
			this.Value = Value;
		}

		// Token: 0x06029477 RID: 169079 RVA: 0x009C0358 File Offset: 0x009BE558
		protected override IntPtr GetUStructPtr()
		{
			return SInt64Array.StaticStruct();
		}

		// Token: 0x06029478 RID: 169080 RVA: 0x009C0364 File Offset: 0x009BE564
		[NullableContext(2)]
		public SInt64Array(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029479 RID: 169081 RVA: 0x009C036E File Offset: 0x009BE56E
		public SInt64Array(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602947A RID: 169082 RVA: 0x009C0379 File Offset: 0x009BE579
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInt64Array(Pointer, false, true);
		}

		// Token: 0x0602947B RID: 169083 RVA: 0x009C0383 File Offset: 0x009BE583
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInt64Array(Pointer, MemoryOwner);
		}

		// Token: 0x0401525F RID: 86623
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SInt64Array.SInt64Array";

		// Token: 0x04015260 RID: 86624
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015261 RID: 86625
		internal static int __PropertyOffset_0;

		// Token: 0x04015262 RID: 86626
		[Nullable(2)]
		private TArray<long> _Value;
	}
}
