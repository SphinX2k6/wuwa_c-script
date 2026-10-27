using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x0200405B RID: 16475
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv6.CS_Motor_In_Lv6_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_In_Lv6_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A501 RID: 173313 RVA: 0x009DC63C File Offset: 0x009DA83C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_In_Lv6_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv6.CS_Motor_In_Lv6_C");
			}
			return CS_Motor_In_Lv6_C._ClassPtr;
		}

		// Token: 0x0602A502 RID: 173314 RVA: 0x009DC660 File Offset: 0x009DA860
		public CS_Motor_In_Lv6_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv6_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A503 RID: 173315 RVA: 0x009DC688 File Offset: 0x009DA888
		[NullableContext(1)]
		public CS_Motor_In_Lv6_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_In_Lv6_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A504 RID: 173316 RVA: 0x009DC6BB File Offset: 0x009DA8BB
		protected CS_Motor_In_Lv6_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D43 RID: 89411
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_In_Lv6.CS_Motor_In_Lv6_C";

		// Token: 0x04015D44 RID: 89412
		private static IntPtr _ClassPtr;

		// Token: 0x04015D45 RID: 89413
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
