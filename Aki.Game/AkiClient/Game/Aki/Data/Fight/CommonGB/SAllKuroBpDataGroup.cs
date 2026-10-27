using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Fight.CommonGB
{
	// Token: 0x02003F7F RID: 16255
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Fight/CommonGB/SAllKuroBpDataGroup.SAllKuroBpDataGroup")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class SAllKuroBpDataGroup : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060297EC RID: 169964 RVA: 0x009C593D File Offset: 0x009C3B3D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAllKuroBpDataGroup._ScriptStructPtr != 0) ? SAllKuroBpDataGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/CommonGB/SAllKuroBpDataGroup.SAllKuroBpDataGroup", ref SAllKuroBpDataGroup._ScriptStructPtr);
		}

		// Token: 0x1700639E RID: 25502
		// (get) Token: 0x060297ED RID: 169965 RVA: 0x009C5961 File Offset: 0x009C3B61
		// (set) Token: 0x060297EE RID: 169966 RVA: 0x009C5975 File Offset: 0x009C3B75
		[Nullable(2)]
		public unsafe UKuroBpDataAssetGroup DataRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroBpDataAssetGroup>(base.NativePtr / (IntPtr)sizeof(void*) + SAllKuroBpDataGroup.__PropertyOffset_0);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + SAllKuroBpDataGroup.__PropertyOffset_0, value);
			}
		}

		// Token: 0x060297EF RID: 169967 RVA: 0x009C598A File Offset: 0x009C3B8A
		public SAllKuroBpDataGroup()
		{
		}

		// Token: 0x060297F0 RID: 169968 RVA: 0x009C5992 File Offset: 0x009C3B92
		[NullableContext(1)]
		public SAllKuroBpDataGroup(UKuroBpDataAssetGroup DataRef)
		{
			this.DataRef = DataRef;
		}

		// Token: 0x060297F1 RID: 169969 RVA: 0x009C59A1 File Offset: 0x009C3BA1
		protected override IntPtr GetUStructPtr()
		{
			return SAllKuroBpDataGroup.StaticStruct();
		}

		// Token: 0x060297F2 RID: 169970 RVA: 0x009C59AD File Offset: 0x009C3BAD
		[NullableContext(2)]
		public SAllKuroBpDataGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060297F3 RID: 169971 RVA: 0x009C59B7 File Offset: 0x009C3BB7
		public SAllKuroBpDataGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060297F4 RID: 169972 RVA: 0x009C59C2 File Offset: 0x009C3BC2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SAllKuroBpDataGroup(Pointer, false, true);
		}

		// Token: 0x060297F5 RID: 169973 RVA: 0x009C59CC File Offset: 0x009C3BCC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SAllKuroBpDataGroup(Pointer, MemoryOwner);
		}

		// Token: 0x04015457 RID: 87127
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/CommonGB/SAllKuroBpDataGroup.SAllKuroBpDataGroup";

		// Token: 0x04015458 RID: 87128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015459 RID: 87129
		internal static int __PropertyOffset_0;
	}
}
