using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004057 RID: 16471
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Fly_In.CS_Motor_Fly_In_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Fly_In_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4F1 RID: 173297 RVA: 0x009DC41C File Offset: 0x009DA61C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Fly_In_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Fly_In.CS_Motor_Fly_In_C");
			}
			return CS_Motor_Fly_In_C._ClassPtr;
		}

		// Token: 0x0602A4F2 RID: 173298 RVA: 0x009DC440 File Offset: 0x009DA640
		public CS_Motor_Fly_In_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Fly_In_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4F3 RID: 173299 RVA: 0x009DC468 File Offset: 0x009DA668
		[NullableContext(1)]
		public CS_Motor_Fly_In_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Fly_In_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4F4 RID: 173300 RVA: 0x009DC49B File Offset: 0x009DA69B
		protected CS_Motor_Fly_In_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D37 RID: 89399
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Fly_In.CS_Motor_Fly_In_C";

		// Token: 0x04015D38 RID: 89400
		private static IntPtr _ClassPtr;

		// Token: 0x04015D39 RID: 89401
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
