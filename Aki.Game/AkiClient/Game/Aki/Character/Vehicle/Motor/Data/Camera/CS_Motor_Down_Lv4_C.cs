using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004051 RID: 16465
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv4.CS_Motor_Down_Lv4_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Down_Lv4_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4D9 RID: 173273 RVA: 0x009DC0EC File Offset: 0x009DA2EC
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Down_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv4.CS_Motor_Down_Lv4_C");
			}
			return CS_Motor_Down_Lv4_C._ClassPtr;
		}

		// Token: 0x0602A4DA RID: 173274 RVA: 0x009DC110 File Offset: 0x009DA310
		public CS_Motor_Down_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4DB RID: 173275 RVA: 0x009DC138 File Offset: 0x009DA338
		[NullableContext(1)]
		public CS_Motor_Down_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4DC RID: 173276 RVA: 0x009DC16B File Offset: 0x009DA36B
		protected CS_Motor_Down_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D25 RID: 89381
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv4.CS_Motor_Down_Lv4_C";

		// Token: 0x04015D26 RID: 89382
		private static IntPtr _ClassPtr;

		// Token: 0x04015D27 RID: 89383
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
