using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x02004036 RID: 16438
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Mengzhou.BP_Motor_BaseVehicle_Mengzhou_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_Motor_BaseVehicle_Mengzhou_C : BP_Motor_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A2F6 RID: 172790 RVA: 0x009D8812 File Offset: 0x009D6A12
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Mengzhou_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Mengzhou.BP_Motor_BaseVehicle_Mengzhou_C");
			}
			return BP_Motor_BaseVehicle_Mengzhou_C._ClassPtr;
		}

		// Token: 0x0602A2F7 RID: 172791 RVA: 0x009D8838 File Offset: 0x009D6A38
		public BP_Motor_BaseVehicle_Mengzhou_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Mengzhou_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A2F8 RID: 172792 RVA: 0x009D8860 File Offset: 0x009D6A60
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Mengzhou_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Mengzhou_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A2F9 RID: 172793 RVA: 0x009D8893 File Offset: 0x009D6A93
		protected BP_Motor_BaseVehicle_Mengzhou_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BF1 RID: 89073
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Mengzhou.BP_Motor_BaseVehicle_Mengzhou_C";

		// Token: 0x04015BF2 RID: 89074
		private static IntPtr _ClassPtr;

		// Token: 0x04015BF3 RID: 89075
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
