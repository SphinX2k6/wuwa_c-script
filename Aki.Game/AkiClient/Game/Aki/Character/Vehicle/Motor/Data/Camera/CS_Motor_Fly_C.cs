using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004056 RID: 16470
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Fly.CS_Motor_Fly_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Fly_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4ED RID: 173293 RVA: 0x009DC394 File Offset: 0x009DA594
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Fly_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Fly.CS_Motor_Fly_C");
			}
			return CS_Motor_Fly_C._ClassPtr;
		}

		// Token: 0x0602A4EE RID: 173294 RVA: 0x009DC3B8 File Offset: 0x009DA5B8
		public CS_Motor_Fly_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Fly_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4EF RID: 173295 RVA: 0x009DC3E0 File Offset: 0x009DA5E0
		[NullableContext(1)]
		public CS_Motor_Fly_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Fly_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4F0 RID: 173296 RVA: 0x009DC413 File Offset: 0x009DA613
		protected CS_Motor_Fly_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D34 RID: 89396
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Fly.CS_Motor_Fly_C";

		// Token: 0x04015D35 RID: 89397
		private static IntPtr _ClassPtr;

		// Token: 0x04015D36 RID: 89398
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
