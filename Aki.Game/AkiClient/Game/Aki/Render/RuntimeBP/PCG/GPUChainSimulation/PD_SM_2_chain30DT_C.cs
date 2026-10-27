using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.GPUChainSimulation
{
	// Token: 0x02003CB0 RID: 15536
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/PD_SM_2_chain30DT.PD_SM_2_chain30DT_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_SM_2_chain30DT_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060248FE RID: 149758 RVA: 0x00942216 File Offset: 0x00940416
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_SM_2_chain30DT_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/PD_SM_2_chain30DT.PD_SM_2_chain30DT_C");
			}
			return PD_SM_2_chain30DT_C._ClassPtr;
		}

		// Token: 0x060248FF RID: 149759 RVA: 0x0094223C File Offset: 0x0094043C
		public PD_SM_2_chain30DT_C() : this(BuiltinUtils.AllocNativeUObject(PD_SM_2_chain30DT_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024900 RID: 149760 RVA: 0x00942264 File Offset: 0x00940464
		public PD_SM_2_chain30DT_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_SM_2_chain30DT_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x06024901 RID: 149761 RVA: 0x00942298 File Offset: 0x00940498
		// (set) Token: 0x06024902 RID: 149762 RVA: 0x009422D1 File Offset: 0x009404D1
		public TMap<TSoftObjectPtr<UStaticMesh>, UDataTable> SMTo2SM
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, UDataTable> result;
				if ((result = this._SMTo2SM) == null)
				{
					result = (this._SMTo2SM = new TMap<TSoftObjectPtr<UStaticMesh>, UDataTable>(base.NativePtr + (IntPtr)PD_SM_2_chain30DT_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMTo2SM.CopyAssign(value);
			}
		}

		// Token: 0x06024903 RID: 149763 RVA: 0x009422DF File Offset: 0x009404DF
		protected PD_SM_2_chain30DT_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401227E RID: 74366
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/GPUChainSimulation/PD_SM_2_chain30DT.PD_SM_2_chain30DT_C";

		// Token: 0x0401227F RID: 74367
		private static IntPtr _ClassPtr;

		// Token: 0x04012280 RID: 74368
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012281 RID: 74369
		internal static int __PropertyOffset_0;

		// Token: 0x04012282 RID: 74370
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, UDataTable> _SMTo2SM;
	}
}
