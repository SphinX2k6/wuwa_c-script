using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedCloth
{
	// Token: 0x02003CD5 RID: 15573
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/S_BatchedClothColArrStruct.S_BatchedClothColArrStruct")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class S_BatchedClothColArrStruct : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024EFE RID: 151294 RVA: 0x0094CAA4 File Offset: 0x0094ACA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (S_BatchedClothColArrStruct._ScriptStructPtr != 0) ? S_BatchedClothColArrStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/S_BatchedClothColArrStruct.S_BatchedClothColArrStruct", ref S_BatchedClothColArrStruct._ScriptStructPtr);
		}

		// Token: 0x170049EE RID: 18926
		// (get) Token: 0x06024EFF RID: 151295 RVA: 0x0094CAC8 File Offset: 0x0094ACC8
		// (set) Token: 0x06024F00 RID: 151296 RVA: 0x0094CB0B File Offset: 0x0094AD0B
		public TArray<S_BatchedClothColStruct> BaseStaticMeshActorArr
		{
			get
			{
				base.FastCheckIsValid();
				TArray<S_BatchedClothColStruct> result;
				if ((result = this._BaseStaticMeshActorArr) == null)
				{
					result = (this._BaseStaticMeshActorArr = new TArray<S_BatchedClothColStruct>(base.NativePtr + (IntPtr)S_BatchedClothColArrStruct.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BaseStaticMeshActorArr.CopyAssign(value);
			}
		}

		// Token: 0x06024F01 RID: 151297 RVA: 0x0094CB19 File Offset: 0x0094AD19
		public S_BatchedClothColArrStruct()
		{
		}

		// Token: 0x06024F02 RID: 151298 RVA: 0x0094CB21 File Offset: 0x0094AD21
		public S_BatchedClothColArrStruct(TArray<S_BatchedClothColStruct> BaseStaticMeshActorArr)
		{
			this.BaseStaticMeshActorArr = BaseStaticMeshActorArr;
		}

		// Token: 0x06024F03 RID: 151299 RVA: 0x0094CB30 File Offset: 0x0094AD30
		protected override IntPtr GetUStructPtr()
		{
			return S_BatchedClothColArrStruct.StaticStruct();
		}

		// Token: 0x06024F04 RID: 151300 RVA: 0x0094CB3C File Offset: 0x0094AD3C
		[NullableContext(2)]
		public S_BatchedClothColArrStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024F05 RID: 151301 RVA: 0x0094CB46 File Offset: 0x0094AD46
		public S_BatchedClothColArrStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024F06 RID: 151302 RVA: 0x0094CB51 File Offset: 0x0094AD51
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new S_BatchedClothColArrStruct(Pointer, false, true);
		}

		// Token: 0x06024F07 RID: 151303 RVA: 0x0094CB5B File Offset: 0x0094AD5B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new S_BatchedClothColArrStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040125E2 RID: 75234
		public const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/S_BatchedClothColArrStruct.S_BatchedClothColArrStruct";

		// Token: 0x040125E3 RID: 75235
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040125E4 RID: 75236
		internal static int __PropertyOffset_0;

		// Token: 0x040125E5 RID: 75237
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<S_BatchedClothColStruct> _BaseStaticMeshActorArr;
	}
}
