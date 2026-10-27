using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Vehicle.Seq;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Seq
{
	// Token: 0x0200403A RID: 16442
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_BaseVehicle_Seq_V2.BP_Motor_BaseVehicle_Seq_V2_C")]
	[UnrealStructLayout(1216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1216)]
	public class BP_Motor_BaseVehicle_Seq_V2_C : BP_BaseVehicle_Seq_V2_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A351 RID: 172881 RVA: 0x009D92E1 File Offset: 0x009D74E1
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Seq_V2_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_BaseVehicle_Seq_V2.BP_Motor_BaseVehicle_Seq_V2_C");
			}
			return BP_Motor_BaseVehicle_Seq_V2_C._ClassPtr;
		}

		// Token: 0x0602A352 RID: 172882 RVA: 0x009D9308 File Offset: 0x009D7508
		public BP_Motor_BaseVehicle_Seq_V2_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Seq_V2_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A353 RID: 172883 RVA: 0x009D9330 File Offset: 0x009D7530
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Seq_V2_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Seq_V2_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A354 RID: 172884 RVA: 0x009D9363 File Offset: 0x009D7563
		protected BP_Motor_BaseVehicle_Seq_V2_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C27 RID: 89127
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Seq/BP_Motor_BaseVehicle_Seq_V2.BP_Motor_BaseVehicle_Seq_V2_C";

		// Token: 0x04015C28 RID: 89128
		private static IntPtr _ClassPtr;

		// Token: 0x04015C29 RID: 89129
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
