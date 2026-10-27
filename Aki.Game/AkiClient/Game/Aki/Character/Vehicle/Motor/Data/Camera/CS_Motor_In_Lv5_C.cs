using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200405A RID: 16474
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv5.CS_Motor_In_Lv5_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_In_Lv5_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4FD RID: 173309 RVA: 0x009DC5B4 File Offset: 0x009DA7B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_In_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv5.CS_Motor_In_Lv5_C");
			}
			return CS_Motor_In_Lv5_C._ClassPtr;
		}

		// Token: 0x0602A4FE RID: 173310 RVA: 0x009DC5D8 File Offset: 0x009DA7D8
		public CS_Motor_In_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4FF RID: 173311 RVA: 0x009DC600 File Offset: 0x009DA800
		[NullableContext(1)]
		public CS_Motor_In_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A500 RID: 173312 RVA: 0x009DC633 File Offset: 0x009DA833
		protected CS_Motor_In_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D40 RID: 89408
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv5.CS_Motor_In_Lv5_C";

		// Token: 0x04015D41 RID: 89409
		private static IntPtr _ClassPtr;

		// Token: 0x04015D42 RID: 89410
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
