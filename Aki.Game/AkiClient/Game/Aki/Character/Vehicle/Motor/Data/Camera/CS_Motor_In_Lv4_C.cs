using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004059 RID: 16473
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv4.CS_Motor_In_Lv4_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_In_Lv4_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4F9 RID: 173305 RVA: 0x009DC52C File Offset: 0x009DA72C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_In_Lv4_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv4.CS_Motor_In_Lv4_C");
			}
			return CS_Motor_In_Lv4_C._ClassPtr;
		}

		// Token: 0x0602A4FA RID: 173306 RVA: 0x009DC550 File Offset: 0x009DA750
		public CS_Motor_In_Lv4_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv4_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4FB RID: 173307 RVA: 0x009DC578 File Offset: 0x009DA778
		[NullableContext(1)]
		public CS_Motor_In_Lv4_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv4_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4FC RID: 173308 RVA: 0x009DC5AB File Offset: 0x009DA7AB
		protected CS_Motor_In_Lv4_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D3D RID: 89405
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv4.CS_Motor_In_Lv4_C";

		// Token: 0x04015D3E RID: 89406
		private static IntPtr _ClassPtr;

		// Token: 0x04015D3F RID: 89407
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
