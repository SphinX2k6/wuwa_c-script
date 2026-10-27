using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Level.Vehicle.VehicleControlState
{
	// Token: 0x02003F00 RID: 16128
	[UnrealObjectPath("/Game/Aki/Data/Level/Vehicle/VehicleControlState/BP_VehicleCruiseBaseParams.BP_VehicleCruiseBaseParams_C")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class BP_VehicleCruiseBaseParams_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06028E21 RID: 167457 RVA: 0x009B6BAC File Offset: 0x009B4DAC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_VehicleCruiseBaseParams_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Level/Vehicle/VehicleControlState/BP_VehicleCruiseBaseParams.BP_VehicleCruiseBaseParams_C");
			}
			return BP_VehicleCruiseBaseParams_C._ClassPtr;
		}

		// Token: 0x06028E22 RID: 167458 RVA: 0x009B6BD0 File Offset: 0x009B4DD0
		public BP_VehicleCruiseBaseParams_C() : this(BuiltinUtils.AllocNativeUObject(BP_VehicleCruiseBaseParams_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06028E23 RID: 167459 RVA: 0x009B6BF8 File Offset: 0x009B4DF8
		[NullableContext(1)]
		public BP_VehicleCruiseBaseParams_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_VehicleCruiseBaseParams_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006024 RID: 24612
		// (get) Token: 0x06028E24 RID: 167460 RVA: 0x009B6C2B File Offset: 0x009B4E2B
		// (set) Token: 0x06028E25 RID: 167461 RVA: 0x009B6C3B File Offset: 0x009B4E3B
		public unsafe float 前进最大移动速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleCruiseBaseParams_C.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleCruiseBaseParams_C.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006025 RID: 24613
		// (get) Token: 0x06028E26 RID: 167462 RVA: 0x009B6C4C File Offset: 0x009B4E4C
		// (set) Token: 0x06028E27 RID: 167463 RVA: 0x009B6C5C File Offset: 0x009B4E5C
		public unsafe float 常态前进加速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_VehicleCruiseBaseParams_C.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_VehicleCruiseBaseParams_C.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x06028E28 RID: 167464 RVA: 0x009B6C6D File Offset: 0x009B4E6D
		protected BP_VehicleCruiseBaseParams_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014E87 RID: 85639
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Level/Vehicle/VehicleControlState/BP_VehicleCruiseBaseParams.BP_VehicleCruiseBaseParams_C";

		// Token: 0x04014E88 RID: 85640
		private static IntPtr _ClassPtr;

		// Token: 0x04014E89 RID: 85641
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014E8A RID: 85642
		internal static int __PropertyOffset_0;

		// Token: 0x04014E8B RID: 85643
		internal static int __PropertyOffset_1;
	}
}
