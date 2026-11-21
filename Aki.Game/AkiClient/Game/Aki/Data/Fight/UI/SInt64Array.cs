using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x020031FA RID: 12794
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SInt64Array.SInt64Array")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SInt64Array : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FD48 RID: 130376 RVA: 0x00936DC1 File Offset: 0x00934FC1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SInt64Array._ScriptStructPtr != 0) ? SInt64Array._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SInt64Array.SInt64Array", ref SInt64Array._ScriptStructPtr);
		}

		// Token: 0x17003BB3 RID: 15283
		// (get) Token: 0x0601FD49 RID: 130377 RVA: 0x00936DE8 File Offset: 0x00934FE8
		// (set) Token: 0x0601FD4A RID: 130378 RVA: 0x00936E2B File Offset: 0x0093502B
		public TArray<long> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<long> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<long>(base.NativePtr + (IntPtr)SInt64Array.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x0601FD4B RID: 130379 RVA: 0x00936E39 File Offset: 0x00935039
		public SInt64Array()
		{
		}

		// Token: 0x0601FD4C RID: 130380 RVA: 0x00936E41 File Offset: 0x00935041
		protected override IntPtr GetUStructPtr()
		{
			return SInt64Array.StaticStruct();
		}

		// Token: 0x0601FD4D RID: 130381 RVA: 0x00936E4D File Offset: 0x0093504D
		[NullableContext(2)]
		public SInt64Array(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FD4E RID: 130382 RVA: 0x00936E57 File Offset: 0x00935057
		public SInt64Array(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FD4F RID: 130383 RVA: 0x00936E62 File Offset: 0x00935062
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SInt64Array(Pointer, false, true);
		}

		// Token: 0x0601FD50 RID: 130384 RVA: 0x00936E6C File Offset: 0x0093506C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SInt64Array(Pointer, MemoryOwner);
		}

		// Token: 0x04011177 RID: 70007
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SInt64Array.SInt64Array";

		// Token: 0x04011178 RID: 70008
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011179 RID: 70009
		internal static int __PropertyOffset_Value;

		// Token: 0x0401117A RID: 70010
		[Nullable(2)]
		private TArray<long> _Value;
	}
}
