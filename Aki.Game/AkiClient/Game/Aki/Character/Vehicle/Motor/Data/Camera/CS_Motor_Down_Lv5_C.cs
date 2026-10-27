using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Data.Camera
{
	// Token: 0x02004052 RID: 16466
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv5.CS_Motor_Down_Lv5_C")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class CS_Motor_Down_Lv5_C : BP_CameraShakeAndForceFeedback_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A4DD RID: 173277 RVA: 0x009DC174 File Offset: 0x009DA374
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (CS_Motor_Down_Lv5_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv5.CS_Motor_Down_Lv5_C");
			}
			return CS_Motor_Down_Lv5_C._ClassPtr;
		}

		// Token: 0x0602A4DE RID: 173278 RVA: 0x009DC198 File Offset: 0x009DA398
		public CS_Motor_Down_Lv5_C() : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv5_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A4DF RID: 173279 RVA: 0x009DC1C0 File Offset: 0x009DA3C0
		[NullableContext(1)]
		public CS_Motor_Down_Lv5_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CS_Motor_Down_Lv5_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A4E0 RID: 173280 RVA: 0x009DC1F3 File Offset: 0x009DA3F3
		protected CS_Motor_Down_Lv5_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D28 RID: 89384
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Data/Camera/CS_Motor_Down_Lv5.CS_Motor_Down_Lv5_C";

		// Token: 0x04015D29 RID: 89385
		private static IntPtr _ClassPtr;

		// Token: 0x04015D2A RID: 89386
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
