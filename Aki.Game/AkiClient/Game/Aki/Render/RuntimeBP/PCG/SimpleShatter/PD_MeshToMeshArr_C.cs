using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SimpleShatter
{
	// Token: 0x02003BFE RID: 15358
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/PD_MeshToMeshArr.PD_MeshToMeshArr_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_MeshToMeshArr_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F48 RID: 143176 RVA: 0x00916D64 File Offset: 0x00914F64
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MeshToMeshArr_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/PD_MeshToMeshArr.PD_MeshToMeshArr_C");
			}
			return PD_MeshToMeshArr_C._ClassPtr;
		}

		// Token: 0x06022F49 RID: 143177 RVA: 0x00916D88 File Offset: 0x00914F88
		public PD_MeshToMeshArr_C() : this(BuiltinUtils.AllocNativeUObject(PD_MeshToMeshArr_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F4A RID: 143178 RVA: 0x00916DB0 File Offset: 0x00914FB0
		public PD_MeshToMeshArr_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MeshToMeshArr_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x06022F4B RID: 143179 RVA: 0x00916DE4 File Offset: 0x00914FE4
		// (set) Token: 0x06022F4C RID: 143180 RVA: 0x00916E1D File Offset: 0x0091501D
		public TMap<TSoftObjectPtr<UStaticMesh>, S_MeshToMeshArr> SMTo2SMArr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, S_MeshToMeshArr> result;
				if ((result = this._SMTo2SMArr) == null)
				{
					result = (this._SMTo2SMArr = new TMap<TSoftObjectPtr<UStaticMesh>, S_MeshToMeshArr>(base.NativePtr + (IntPtr)PD_MeshToMeshArr_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMTo2SMArr.CopyAssign(value);
			}
		}

		// Token: 0x06022F4D RID: 143181 RVA: 0x00916E2B File Offset: 0x0091502B
		protected PD_MeshToMeshArr_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011356 RID: 70486
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SimpleShatter/PD_MeshToMeshArr.PD_MeshToMeshArr_C";

		// Token: 0x04011357 RID: 70487
		private static IntPtr _ClassPtr;

		// Token: 0x04011358 RID: 70488
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011359 RID: 70489
		internal static int __PropertyOffset_0;

		// Token: 0x0401135A RID: 70490
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, S_MeshToMeshArr> _SMTo2SMArr;
	}
}
