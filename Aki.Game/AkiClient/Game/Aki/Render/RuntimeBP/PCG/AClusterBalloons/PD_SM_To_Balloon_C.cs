using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG.AClusterBalloons
{
	// Token: 0x02003CE2 RID: 15586
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/PD_SM_To_Balloon.PD_SM_To_Balloon_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_SM_To_Balloon_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060250EF RID: 151791 RVA: 0x0094FDFC File Offset: 0x0094DFFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_SM_To_Balloon_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/PD_SM_To_Balloon.PD_SM_To_Balloon_C");
			}
			return PD_SM_To_Balloon_C._ClassPtr;
		}

		// Token: 0x060250F0 RID: 151792 RVA: 0x0094FE20 File Offset: 0x0094E020
		public PD_SM_To_Balloon_C() : this(BuiltinUtils.AllocNativeUObject(PD_SM_To_Balloon_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060250F1 RID: 151793 RVA: 0x0094FE48 File Offset: 0x0094E048
		public PD_SM_To_Balloon_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_SM_To_Balloon_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x060250F2 RID: 151794 RVA: 0x0094FE7C File Offset: 0x0094E07C
		// (set) Token: 0x060250F3 RID: 151795 RVA: 0x0094FEB5 File Offset: 0x0094E0B5
		public TMap<TSoftObjectPtr<UStaticMesh>, UDataTable> SMToBalloon
		{
			get
			{
				base.FastCheckIsValid();
				TMap<TSoftObjectPtr<UStaticMesh>, UDataTable> result;
				if ((result = this._SMToBalloon) == null)
				{
					result = (this._SMToBalloon = new TMap<TSoftObjectPtr<UStaticMesh>, UDataTable>(base.NativePtr + (IntPtr)PD_SM_To_Balloon_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.SMToBalloon.CopyAssign(value);
			}
		}

		// Token: 0x060250F4 RID: 151796 RVA: 0x0094FEC3 File Offset: 0x0094E0C3
		protected PD_SM_To_Balloon_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040126F5 RID: 75509
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/AClusterBalloons/PD_SM_To_Balloon.PD_SM_To_Balloon_C";

		// Token: 0x040126F6 RID: 75510
		private static IntPtr _ClassPtr;

		// Token: 0x040126F7 RID: 75511
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040126F8 RID: 75512
		internal static int __PropertyOffset_0;

		// Token: 0x040126F9 RID: 75513
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private TMap<TSoftObjectPtr<UStaticMesh>, UDataTable> _SMToBalloon;
	}
}
