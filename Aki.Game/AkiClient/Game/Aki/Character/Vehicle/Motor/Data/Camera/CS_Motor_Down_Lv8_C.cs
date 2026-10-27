using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004055 RID: 16469
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv8.CS_Motor_Down_Lv8_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Down_Lv8_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4E9 RID: 173289 RVA: 0x009DC30C File Offset: 0x009DA50C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Down_Lv8_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv8.CS_Motor_Down_Lv8_C");
			}
			return CS_Motor_Down_Lv8_C._ClassPtr;
		}

		// Token: 0x0602A4EA RID: 173290 RVA: 0x009DC330 File Offset: 0x009DA530
		public CS_Motor_Down_Lv8_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv8_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4EB RID: 173291 RVA: 0x009DC358 File Offset: 0x009DA558
		[NullableContext(1)]
		public CS_Motor_Down_Lv8_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv8_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4EC RID: 173292 RVA: 0x009DC38B File Offset: 0x009DA58B
		protected CS_Motor_Down_Lv8_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D31 RID: 89393
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv8.CS_Motor_Down_Lv8_C";

		// Token: 0x04015D32 RID: 89394
		private static IntPtr _ClassPtr;

		// Token: 0x04015D33 RID: 89395
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
