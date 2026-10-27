using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Render.RuntimeBP.PCG._2DRayCastingGamePlay.BuildNewVertexBuffer
{
	// Token: 0x02003CE8 RID: 15592
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/PD_EntityIDToBoxArr.PD_EntityIDToBoxArr_C")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class PD_EntityIDToBoxArr_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060251FF RID: 152063 RVA: 0x00951C03 File Offset: 0x0094FE03
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (PD_EntityIDToBoxArr_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/PD_EntityIDToBoxArr.PD_EntityIDToBoxArr_C");
			}
			return PD_EntityIDToBoxArr_C._ClassPtr;
		}

		// Token: 0x06025200 RID: 152064 RVA: 0x00951C28 File Offset: 0x0094FE28
		public PD_EntityIDToBoxArr_C() : this(BuiltinUtils.AllocNativeUObject(PD_EntityIDToBoxArr_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025201 RID: 152065 RVA: 0x00951C50 File Offset: 0x0094FE50
		public PD_EntityIDToBoxArr_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(PD_EntityIDToBoxArr_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004B01 RID: 19201
		// (get) Token: 0x06025202 RID: 152066 RVA: 0x00951C84 File Offset: 0x0094FE84
		// (set) Token: 0x06025203 RID: 152067 RVA: 0x00951CBD File Offset: 0x0094FEBD
		public TMap<int, S_FSBoxArr> EntityIDToBoxArr
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, S_FSBoxArr> result;
				if ((result = this._EntityIDToBoxArr) == null)
				{
					result = (this._EntityIDToBoxArr = new TMap<int, S_FSBoxArr>(base.NativePtr + (IntPtr)PD_EntityIDToBoxArr_C.__PropertyOffset_0, this));
				}
				return result;
			}
			set
			{
				this.EntityIDToBoxArr.CopyAssign(value);
			}
		}

		// Token: 0x06025204 RID: 152068 RVA: 0x00951CCB File Offset: 0x0094FECB
		protected PD_EntityIDToBoxArr_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040127BD RID: 75709
		public new const string __ObjectPath = "/Game/Aki/Render/RuntimeBP/PCG/2DRayCastingGamePlay/BuildNewVertexBuffer/PD_EntityIDToBoxArr.PD_EntityIDToBoxArr_C";

		// Token: 0x040127BE RID: 75710
		private static IntPtr _ClassPtr;

		// Token: 0x040127BF RID: 75711
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040127C0 RID: 75712
		internal static int __PropertyOffset_0;

		// Token: 0x040127C1 RID: 75713
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, S_FSBoxArr> _EntityIDToBoxArr;
	}
}
