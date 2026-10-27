using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200405C RID: 16476
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv7.CS_Motor_In_Lv7_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_In_Lv7_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A505 RID: 173317 RVA: 0x009DC6C4 File Offset: 0x009DA8C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_In_Lv7_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv7.CS_Motor_In_Lv7_C");
			}
			return CS_Motor_In_Lv7_C._ClassPtr;
		}

		// Token: 0x0602A506 RID: 173318 RVA: 0x009DC6E8 File Offset: 0x009DA8E8
		public CS_Motor_In_Lv7_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv7_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A507 RID: 173319 RVA: 0x009DC710 File Offset: 0x009DA910
		[NullableContext(1)]
		public CS_Motor_In_Lv7_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv7_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A508 RID: 173320 RVA: 0x009DC743 File Offset: 0x009DA943
		protected CS_Motor_In_Lv7_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D46 RID: 89414
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv7.CS_Motor_In_Lv7_C";

		// Token: 0x04015D47 RID: 89415
		private static IntPtr _ClassPtr;

		// Token: 0x04015D48 RID: 89416
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
