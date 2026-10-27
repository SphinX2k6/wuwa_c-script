using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUBoxSimulation
{
	// Token: 0x02003CBB RID: 15547
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_SM_2_BPSM.PD_SM_2_BPSM_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_SM_2_BPSM_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024B14 RID: 150292 RVA: 0x009461E4 File Offset: 0x009443E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_SM_2_BPSM_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_SM_2_BPSM.PD_SM_2_BPSM_C");
			}
			return PD_SM_2_BPSM_C._ClassPtr;
		}

		// Token: 0x06024B15 RID: 150293 RVA: 0x00946208 File Offset: 0x00944408
		public PD_SM_2_BPSM_C() : this(BuiltinUtils.AllocNativeUObject(PD_SM_2_BPSM_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024B16 RID: 150294 RVA: 0x00946230 File Offset: 0x00944430
		public PD_SM_2_BPSM_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_SM_2_BPSM_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700487F RID: 18559
		// (get) Token: 0x06024B17 RID: 150295 RVA: 0x00946264 File Offset: 0x00944464
		// (set) Token: 0x06024B18 RID: 150296 RVA: 0x0094629D File Offset: 0x0094449D
		public TMap<TSoftObjectPtr<UStaticMesh>, UStaticMesh> SMTo2SM
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, UStaticMesh> result;
				if ((result = this._SMTo2SM) == null)
				{
					result = (this._SMTo2SM = new TMap<TSoftObjectPtr<UStaticMesh>, UStaticMesh>(base.NativePtr + (IntPtr)PD_SM_2_BPSM_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMTo2SM.CopyAssign(value);
			}
		}

		// Token: 0x06024B19 RID: 150297 RVA: 0x009462AB File Offset: 0x009444AB
		protected PD_SM_2_BPSM_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123B0 RID: 74672
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUBoxSimulation/PD_SM_2_BPSM.PD_SM_2_BPSM_C";

		// Token: 0x040123B1 RID: 74673
		private static IntPtr _ClassPtr;

		// Token: 0x040123B2 RID: 74674
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040123B3 RID: 74675
		internal static int __PropertyOffset_0;

		// Token: 0x040123B4 RID: 74676
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, UStaticMesh> _SMTo2SM;
	}
}
