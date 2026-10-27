using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CB9 RID: 15545
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_MeshToBoxData.PD_MeshToBoxData_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_MeshToBoxData_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024B08 RID: 150280 RVA: 0x00946044 File Offset: 0x00944244
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MeshToBoxData_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_MeshToBoxData.PD_MeshToBoxData_C");
			}
			return PD_MeshToBoxData_C._ClassPtr;
		}

		// Token: 0x06024B09 RID: 150281 RVA: 0x00946068 File Offset: 0x00944268
		public PD_MeshToBoxData_C() : this(BuiltinUtils.AllocNativeUObject(PD_MeshToBoxData_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024B0A RID: 150282 RVA: 0x00946090 File Offset: 0x00944290
		public PD_MeshToBoxData_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MeshToBoxData_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700487D RID: 18557
		// (get) Token: 0x06024B0B RID: 150283 RVA: 0x009460C4 File Offset: 0x009442C4
		// (set) Token: 0x06024B0C RID: 150284 RVA: 0x009460FD File Offset: 0x009442FD
		public TMap<TSoftObjectPtr<UStaticMesh>, S_boxColSetupParams> MeshToBoxCol
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, S_boxColSetupParams> result;
				if ((result = this._MeshToBoxCol) == null)
				{
					result = (this._MeshToBoxCol = new TMap<TSoftObjectPtr<UStaticMesh>, S_boxColSetupParams>(base.NativePtr + (IntPtr)PD_MeshToBoxData_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MeshToBoxCol.CopyAssign(value);
			}
		}

		// Token: 0x06024B0D RID: 150285 RVA: 0x0094610B File Offset: 0x0094430B
		protected PD_MeshToBoxData_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123A6 RID: 74662
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_MeshToBoxData.PD_MeshToBoxData_C";

		// Token: 0x040123A7 RID: 74663
		private static IntPtr _ClassPtr;

		// Token: 0x040123A8 RID: 74664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123A9 RID: 74665
		internal static int __PropertyOffset_0;

		// Token: 0x040123AA RID: 74666
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, S_boxColSetupParams> _MeshToBoxCol;
	}
}
