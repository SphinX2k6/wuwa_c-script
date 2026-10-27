using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.UI
{
	// Token: 0x02003F55 RID: 16213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Fight/UI/SIntArray.SIntArray")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class SIntArray : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602947C RID: 169084 RVA: 0x009C038C File Offset: 0x009BE58C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SIntArray._ScriptStructPtr != 0) ? SIntArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/UI/SIntArray.SIntArray", ref SIntArray._ScriptStructPtr);
		}

		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x0602947D RID: 169085 RVA: 0x009C03B0 File Offset: 0x009BE5B0
		// (set) Token: 0x0602947E RID: 169086 RVA: 0x009C03F3 File Offset: 0x009BE5F3
		public TArray<int> IntArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IntArray) == null)
				{
					result = (this._IntArray = new TArray<int>(base.NativePtr + (IntPtr)SIntArray.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.IntArray.CopyAssign(value);
			}
		}

		// Token: 0x0602947F RID: 169087 RVA: 0x009C0401 File Offset: 0x009BE601
		public SIntArray()
		{
		}

		// Token: 0x06029480 RID: 169088 RVA: 0x009C0409 File Offset: 0x009BE609
		public SIntArray(TArray<int> IntArray)
		{
			this.IntArray = IntArray;
		}

		// Token: 0x06029481 RID: 169089 RVA: 0x009C0418 File Offset: 0x009BE618
		protected override IntPtr GetUStructPtr()
		{
			return SIntArray.StaticStruct();
		}

		// Token: 0x06029482 RID: 169090 RVA: 0x009C0424 File Offset: 0x009BE624
		[NullableContext(2)]
		public SIntArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029483 RID: 169091 RVA: 0x009C042E File Offset: 0x009BE62E
		public SIntArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029484 RID: 169092 RVA: 0x009C0439 File Offset: 0x009BE639
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SIntArray(Pointer, false, true);
		}

		// Token: 0x06029485 RID: 169093 RVA: 0x009C0443 File Offset: 0x009BE643
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SIntArray(Pointer, MemoryOwner);
		}

		// Token: 0x04015263 RID: 86627
		public const string __ObjectPath = "/Game/Aki/Data/Fight/UI/SIntArray.SIntArray";

		// Token: 0x04015264 RID: 86628
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015265 RID: 86629
		internal static int __PropertyOffset_0;

		// Token: 0x04015266 RID: 86630
		[Nullable(2)]
		private TArray<int> _IntArray;
	}
}
