using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x02004033 RID: 16435
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Aimisi.BP_Motor_BaseVehicle_Aimisi_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_Motor_BaseVehicle_Aimisi_C : BP_Motor_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A2BE RID: 172734 RVA: 0x009D819A File Offset: 0x009D639A
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Aimisi_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Aimisi.BP_Motor_BaseVehicle_Aimisi_C");
			}
			return BP_Motor_BaseVehicle_Aimisi_C._ClassPtr;
		}

		// Token: 0x0602A2BF RID: 172735 RVA: 0x009D81C0 File Offset: 0x009D63C0
		public BP_Motor_BaseVehicle_Aimisi_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Aimisi_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A2C0 RID: 172736 RVA: 0x009D81E8 File Offset: 0x009D63E8
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Aimisi_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Aimisi_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A2C1 RID: 172737 RVA: 0x009D821B File Offset: 0x009D641B
		protected BP_Motor_BaseVehicle_Aimisi_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BCF RID: 89039
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Aimisi.BP_Motor_BaseVehicle_Aimisi_C";

		// Token: 0x04015BD0 RID: 89040
		private static IntPtr _ClassPtr;

		// Token: 0x04015BD1 RID: 89041
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
