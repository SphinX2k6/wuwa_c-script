using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CBA RID: 15546
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_MeshToCloth33.PD_MeshToCloth33_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_MeshToCloth33_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024B0E RID: 150286 RVA: 0x00946114 File Offset: 0x00944314
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_MeshToCloth33_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_MeshToCloth33.PD_MeshToCloth33_C");
			}
			return PD_MeshToCloth33_C._ClassPtr;
		}

		// Token: 0x06024B0F RID: 150287 RVA: 0x00946138 File Offset: 0x00944338
		public PD_MeshToCloth33_C() : this(BuiltinUtils.AllocNativeUObject(PD_MeshToCloth33_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024B10 RID: 150288 RVA: 0x00946160 File Offset: 0x00944360
		public PD_MeshToCloth33_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_MeshToCloth33_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700487E RID: 18558
		// (get) Token: 0x06024B11 RID: 150289 RVA: 0x00946194 File Offset: 0x00944394
		// (set) Token: 0x06024B12 RID: 150290 RVA: 0x009461CD File Offset: 0x009443CD
		public TMap<TSoftObjectPtr<UStaticMesh>, struct_genCloth_33> MeshToCloth33
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, struct_genCloth_33> result;
				if ((result = this._MeshToCloth33) == null)
				{
					result = (this._MeshToCloth33 = new TMap<TSoftObjectPtr<UStaticMesh>, struct_genCloth_33>(base.NativePtr + (IntPtr)PD_MeshToCloth33_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.MeshToCloth33.CopyAssign(value);
			}
		}

		// Token: 0x06024B13 RID: 150291 RVA: 0x009461DB File Offset: 0x009443DB
		protected PD_MeshToCloth33_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123AB RID: 74667
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_MeshToCloth33.PD_MeshToCloth33_C";

		// Token: 0x040123AC RID: 74668
		private static IntPtr _ClassPtr;

		// Token: 0x040123AD RID: 74669
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123AE RID: 74670
		internal static int __PropertyOffset_0;

		// Token: 0x040123AF RID: 74671
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, struct_genCloth_33> _MeshToCloth33;
	}
}
