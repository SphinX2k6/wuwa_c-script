using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.BatchedCloth
{
	// Token: 0x02003CD4 RID: 15572
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/PD_MeshToMeshActorArrForBatchedCloth.PD_MeshToMeshActorArrForBatchedCloth_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_MeshToMeshActorArrForBatchedCloth_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024EF8 RID: 151288 RVA: 0x0094C9D3 File Offset: 0x0094ABD3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MeshToMeshActorArrForBatchedCloth_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/PD_MeshToMeshActorArrForBatchedCloth.PD_MeshToMeshActorArrForBatchedCloth_C");
			}
			return PD_MeshToMeshActorArrForBatchedCloth_C._ClassPtr;
		}

		// Token: 0x06024EF9 RID: 151289 RVA: 0x0094C9F8 File Offset: 0x0094ABF8
		public PD_MeshToMeshActorArrForBatchedCloth_C() : this(BuiltinUtils.AllocNativeUObject(PD_MeshToMeshActorArrForBatchedCloth_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024EFA RID: 151290 RVA: 0x0094CA20 File Offset: 0x0094AC20
		public PD_MeshToMeshActorArrForBatchedCloth_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MeshToMeshActorArrForBatchedCloth_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170049ED RID: 18925
		// (get) Token: 0x06024EFB RID: 151291 RVA: 0x0094CA54 File Offset: 0x0094AC54
		// (set) Token: 0x06024EFC RID: 151292 RVA: 0x0094CA8D File Offset: 0x0094AC8D
		public TMap<UStaticMesh, S_BatchedClothColArrStruct> SMActor_To_SMActorArr_For_Batched_Cloth
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UStaticMesh, S_BatchedClothColArrStruct> result;
				if ((result = this._SMActor_To_SMActorArr_For_Batched_Cloth) == null)
				{
					result = (this._SMActor_To_SMActorArr_For_Batched_Cloth = new TMap<UStaticMesh, S_BatchedClothColArrStruct>(base.NativePtr + (IntPtr)PD_MeshToMeshActorArrForBatchedCloth_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMActor_To_SMActorArr_For_Batched_Cloth.CopyAssign(value);
			}
		}

		// Token: 0x06024EFD RID: 151293 RVA: 0x0094CA9B File Offset: 0x0094AC9B
		protected PD_MeshToMeshActorArrForBatchedCloth_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040125DD RID: 75229
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/BatchedCloth/PD_MeshToMeshActorArrForBatchedCloth.PD_MeshToMeshActorArrForBatchedCloth_C";

		// Token: 0x040125DE RID: 75230
		private static IntPtr _ClassPtr;

		// Token: 0x040125DF RID: 75231
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040125E0 RID: 75232
		internal static int __PropertyOffset_0;

		// Token: 0x040125E1 RID: 75233
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UStaticMesh, S_BatchedClothColArrStruct> _SMActor_To_SMActorArr_For_Batched_Cloth;
	}
}
