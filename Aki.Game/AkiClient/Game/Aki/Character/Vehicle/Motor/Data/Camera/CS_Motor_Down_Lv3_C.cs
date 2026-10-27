using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004050 RID: 16464
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv3.CS_Motor_Down_Lv3_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Down_Lv3_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4D5 RID: 173269 RVA: 0x009DC064 File Offset: 0x009DA264
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Down_Lv3_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv3.CS_Motor_Down_Lv3_C");
			}
			return CS_Motor_Down_Lv3_C._ClassPtr;
		}

		// Token: 0x0602A4D6 RID: 173270 RVA: 0x009DC088 File Offset: 0x009DA288
		public CS_Motor_Down_Lv3_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv3_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4D7 RID: 173271 RVA: 0x009DC0B0 File Offset: 0x009DA2B0
		[NullableContext(1)]
		public CS_Motor_Down_Lv3_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv3_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4D8 RID: 173272 RVA: 0x009DC0E3 File Offset: 0x009DA2E3
		protected CS_Motor_Down_Lv3_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D22 RID: 89378
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv3.CS_Motor_Down_Lv3_C";

		// Token: 0x04015D23 RID: 89379
		private static IntPtr _ClassPtr;

		// Token: 0x04015D24 RID: 89380
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
