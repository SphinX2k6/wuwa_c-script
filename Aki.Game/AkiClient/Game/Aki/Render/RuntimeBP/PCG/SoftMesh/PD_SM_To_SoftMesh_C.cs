using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.SoftMesh
{
	// Token: 0x02003BF6 RID: 15350
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/PD_SM_To_SoftMesh.PD_SM_To_SoftMesh_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_SM_To_SoftMesh_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022E93 RID: 142995 RVA: 0x009159AB File Offset: 0x00913BAB
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_SM_To_SoftMesh_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/PD_SM_To_SoftMesh.PD_SM_To_SoftMesh_C");
			}
			return PD_SM_To_SoftMesh_C._ClassPtr;
		}

		// Token: 0x06022E94 RID: 142996 RVA: 0x009159D0 File Offset: 0x00913BD0
		public PD_SM_To_SoftMesh_C() : this(BuiltinUtils.AllocNativeUObject(PD_SM_To_SoftMesh_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022E95 RID: 142997 RVA: 0x009159F8 File Offset: 0x00913BF8
		public PD_SM_To_SoftMesh_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_SM_To_SoftMesh_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x06022E96 RID: 142998 RVA: 0x00915A2C File Offset: 0x00913C2C
		// (set) Token: 0x06022E97 RID: 142999 RVA: 0x00915A65 File Offset: 0x00913C65
		public TMap<TSoftObjectPtr<UStaticMesh>, S_SoftMeshPreset> SMToSoftMesh
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, S_SoftMeshPreset> result;
				if ((result = this._SMToSoftMesh) == null)
				{
					result = (this._SMToSoftMesh = new TMap<TSoftObjectPtr<UStaticMesh>, S_SoftMeshPreset>(base.NativePtr + (IntPtr)PD_SM_To_SoftMesh_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMToSoftMesh.CopyAssign(value);
			}
		}

		// Token: 0x06022E98 RID: 143000 RVA: 0x00915A73 File Offset: 0x00913C73
		protected PD_SM_To_SoftMesh_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040112E9 RID: 70377
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/SoftMesh/PD_SM_To_SoftMesh.PD_SM_To_SoftMesh_C";

		// Token: 0x040112EA RID: 70378
		private static IntPtr _ClassPtr;

		// Token: 0x040112EB RID: 70379
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040112EC RID: 70380
		internal static int __PropertyOffset_0;

		// Token: 0x040112ED RID: 70381
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, S_SoftMeshPreset> _SMToSoftMesh;
	}
}
